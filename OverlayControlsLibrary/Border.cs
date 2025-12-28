using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Design;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using CommonClassesLibrary;

namespace OverlayControlsLibrary
{
    public enum BorderControlType
    {
        None,
        Border3D,
        SolidBorder,
        LockedFrame,
        FocusRectangle,
        SelectionFrame,
        DisabledBorder
    }

    public class Border : Control
    {
        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [DefaultValue(BorderControlType.Border3D)]
        public BorderControlType BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                if (_borderStyle != value)
                {
                    _borderStyle = value;
                    OnStyleChanged(EventArgs.Empty);
                    Invalidate();
                }
            }
        }
        private BorderControlType _borderStyle;

        public Border()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.Selectable, false);
            this.BackColor = Color.Magenta;

            this.Margin = DefaultMargin;
            this.Padding = DefaultPadding;
            this.TabStop = false;
            this.CausesValidation = false;
        }

        public override bool Focused => false;
        protected override bool CanRaiseEvents => false;
        protected override bool ShowFocusCues => false;
        protected override bool ShowKeyboardCues => false;
        protected override Padding DefaultMargin => new Padding(0);
        protected override Padding DefaultPadding => new Padding(0);

        private const int WM_NCHITTEST = 0x0084;
        private const int HTTRANSPARENT = (-1);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= (int)WindowStyles.WS_EX_TRANSPARENT;
                if (!DesignMode)
                {
                    cp.ExStyle |= (int)WindowStyles.WS_EX_NOACTIVATE;
                }
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST)
            {
                if (!DesignMode)
                {
                    m.Result = (IntPtr)HTTRANSPARENT;
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        protected override void InitLayout()
        {
            if (this.Parent != null)
            {
                this.ForeColor = ColorHelper.InvertColor(this.Parent.ForeColor);
            }
            base.InitLayout();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bounds = this.ClientRectangle;
            Graphics g = e.Graphics;

            // g.Clear(backColor);

            switch (this.BorderStyle)
            {
                case BorderControlType.Border3D:
                    ControlPaint.DrawBorder3D(g, bounds);
                    break;
                case BorderControlType.SolidBorder:
                    ControlPaint.DrawBorder(g, bounds, this.ForeColor, ButtonBorderStyle.Solid);
                    break;
                case BorderControlType.LockedFrame:
                    ControlPaint.DrawLockedFrame(g, bounds, true);
                    break;
                case BorderControlType.FocusRectangle:
                    ControlPaint.DrawFocusRectangle(g, bounds);
                    break;
                case BorderControlType.SelectionFrame:
                    ControlPaint.DrawSelectionFrame(g, true, bounds, BorderHelper.Grow(bounds, 1), this.BackColor);
                    break;
                case BorderControlType.DisabledBorder:
                    ControlPaint.DrawVisualStyleBorder(g, bounds);
                    break;
                case BorderControlType.None:
                default:
                    break;
            }

            /*
            if (DesignMode)
            {
                ControlPaint.DrawBorder(g, bounds, Color.Fuchsia, ButtonBorderStyle.Solid);
            }
            */

            base.OnPaint(e);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            if (this.Parent != null)
            {
                Parent.Invalidate(this.Bounds, true);
            }
            this.Invalidate();
            base.OnBackColorChanged(e);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            this.Invalidate();
            base.OnParentBackColorChanged(e);
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            if (DesignMode)
            {
                Invalidate();
            }
            base.OnLocationChanged(e);
        }

        protected override void OnMove(EventArgs e)
        {
            if (DesignMode)
            {
                Invalidate();
            }
            base.OnMove(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (DesignMode)
            {
                Invalidate();
            }
            base.OnSizeChanged(e);
        }
    }
}
