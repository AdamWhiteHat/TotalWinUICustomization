using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TotalWinUICustomization.Types;

namespace TotalWinUICustomization.Controls
{
    /// <summary>
    /// For most purposes involving finding SettingUpdateActions in a list, we only care if the same setting is being set, not what the value is (because we will just remove all matches, and add the new one).
    /// </summary>
    public class SettingOnlyComparer : IEqualityComparer<SettingUpdateAction>
    {
        public bool Equals(SettingUpdateAction x, SettingUpdateAction y)
        {
            return x.Setting.Equals(y.Setting);
        }
        public int GetHashCode(SettingUpdateAction obj)
        {
            return obj.Setting.GetHashCode();
        }
    }

    /// <summary>
    /// Represents a change to a Windows UI setting, a preview of which is shown in the control, but has yet to be applied.
    /// </summary>
    public class SettingUpdateAction : IEquatable<SettingUpdateAction>
    {
        public bool Save { get; set; }
        public string Display { get; set; }
        public WindowsUiElements Setting { get; set; }
        public object Value
        {
            get
            {
                if (_fontValue != null)
                {
                    return _fontValue;
                }
                else if (_colorValue != Color.Empty)
                {
                    return _colorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value is Font)
                {
                    _fontValue = (Font)value;
                    _colorValue = Color.Empty;
                }
                else if (value is Color)
                {
                    _colorValue = (Color)value;
                    _fontValue = null;
                }
            }
        }

        public Font FontValue { get { return _fontValue; } }
        public Color ColorValue { get { return _colorValue; } }

        private Font _fontValue = null;
        private Color _colorValue = Color.Empty;

        public SettingUpdateAction(WindowsUiElements setting, object value)
        {
            Setting = setting;
            Value = value;
            Save = true;
            Display = ToString();
        }

        public bool ApplyAction(Graphics g)
        {
            if (FontValue != null)
            {
                RegistryHelper.SetWindowsFont(Setting, FontValue, g);
                return true;
            }
            else if (ColorValue != Color.Empty)
            {
                RegistryHelper.SetWindowsColor(Setting, ColorValue);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(SettingUpdateAction other)
        {
            if (other == null)
            {
                return false;
            }
            if (this.Setting != other.Setting)
            {
                return false;
            }
            if (this.FontValue != null && other.FontValue != null)
            {
                return this.FontValue.Equals(other.FontValue);
            }
            if (this.ColorValue != Color.Empty && other.ColorValue != Color.Empty)
            {
                return this.ColorValue.Equals(other.ColorValue);
            }
            if (this.FontValue == null && other.FontValue == null && this.ColorValue == Color.Empty && other.ColorValue == Color.Empty)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int result = Setting.GetHashCode();
            if (FontValue != null)
            {
                result ^= FontValue.GetHashCode();
            }
            else if (ColorValue != Color.Empty)
            {
                result ^= ColorValue.GetHashCode();
            }
            return result;
        }

        public override string ToString()
        {
            string valueString = string.Empty;

            if (FontValue != null)
            {
                bool isSerif = FontValue.FontFamily.Equals(FontFamily.GenericSerif);

                string fontStyleString = "";
                if (FontValue.Bold && FontValue.Italic)
                {
                    fontStyleString += " 𝑩𝒐𝒍𝒅 𝑰𝒕𝒂𝒍𝒊𝒄";
                }
                else if (FontValue.Bold)
                {
                    fontStyleString += " 𝐁𝐨𝐥𝐝";
                }
                else if (FontValue.Italic)
                {
                    fontStyleString += " 𝐼𝑡𝑎𝑙𝑖𝑐";
                }
                valueString = $"{FontValue.Name.Trim()}{fontStyleString}, {FontValue.SizeInPoints}pt".Trim();
            }
            else if (ColorValue != Color.Empty)
            {
                if (ColorValue.IsNamedColor)
                {
                    valueString = "Color." + ColorValue.Name.Trim();
                }
                else
                {
                    valueString = $"#{ColorValue.R:X2}{ColorValue.G:X2}{ColorValue.B:X2}";
                }
            }
            else
            {
                valueString = $"<Unset>";
            }

            return Enum.GetName(typeof(WindowsUiElements), Setting).Trim() + " = " + valueString.Trim();
        }
    }
}
