using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace TotalWinUICustomization
{
    public class ThreadsafeInterlock : IDisposable
    {
        private readonly object _fieldOwnerInstance;
        private FieldInfo _fieldInfo;

        public ThreadsafeInterlock(object fieldOwner, FieldInfo boolStateFieldInfo)
        {
            _fieldOwnerInstance = fieldOwner;
            _fieldInfo = boolStateFieldInfo;
            InterlockToken.InternalState.StateChanged += InternalState_StateChanged;
        }
        public InterlockToken GetToken()
        {
            return new InterlockToken();
        }

        private void InternalState_StateChanged(object sender, StateChangedEventArgs e)
        {
            bool enableField = e.IsOccupied;

            object oldValue = _fieldInfo.GetValue(_fieldOwnerInstance);

            _fieldInfo.SetValue(_fieldOwnerInstance, enableField);

            object newValue = _fieldInfo.GetValue(_fieldOwnerInstance);

            bool changed = !oldValue.Equals(newValue);
        }

        public void Dispose()
        {
            InterlockToken.InternalState.StateChanged -= InternalState_StateChanged;
            _fieldInfo = null;
        }

        public class StateChangedEventArgs : EventArgs
        {
            public bool IsOccupied { get; private set; }
            public StateChangedEventArgs(bool isOccupied)
            {
                IsOccupied = isOccupied;
            }
        }

        public class InterlockToken : IDisposable
        {
            private bool _isDisposed = true;

            public InterlockToken()
            {
                _isDisposed = false;
                InternalState.EnterSection();
            }

            public void Dispose()
            {
                if (!_isDisposed)
                {
                    _isDisposed = true;
                    InternalState.ExitSection();
                }
            }

            internal static class InternalState
            {
                public static event EventHandler<StateChangedEventArgs> StateChanged;

                public static bool IsOccupied
                {
                    get
                    {
                        return TestIsOccupied();
                    }
                }

                private static long _incrementValue = 0;

                private static bool TestIsOccupied()
                {
                    return (Interlocked.Read(ref _incrementValue) == 0);
                }

                public static void EnterSection()
                {
                    long currentValue = Interlocked.Read(ref _incrementValue);

                    if (Interlocked.Increment(ref _incrementValue) > 0)
                    {
                        if (currentValue == 0)
                        {
                            RaiseStateChanged(true);
                        }
                    }
                }

                public static void ExitSection()
                {
                    if (Interlocked.Decrement(ref _incrementValue) == 0)
                    {
                        RaiseStateChanged(false);
                    }
                }

                private static void RaiseStateChanged(bool isOccupied)
                {
                    StateChanged?.Invoke(null, new StateChangedEventArgs(isOccupied));
                }
            }
        }
    }
}
