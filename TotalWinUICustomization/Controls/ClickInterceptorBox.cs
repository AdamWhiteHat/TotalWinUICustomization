using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;
using System.Windows.Forms.Layout;

namespace TotalWinUICustomization.Controls
{
    public class ClickInterceptorBox : Control
    {

        #region Overridden and hidden properties

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Text { get => ""; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font { get => base.Font; set => base.Font = value; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }
        public override bool Focused => false;

        #endregion

        public ClickInterceptorBox()
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
            this.BringToFront();
        }

        protected override bool ShowFocusCues => false;
        protected override bool ShowKeyboardCues => false;
        protected override Padding DefaultMargin => new Padding(0);
        protected override Padding DefaultPadding => new Padding(0);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= (int)WindowStyles.WS_EX_TRANSPARENT;
                //cp.Style |= (int)WindowStyles.WS_CHILD;
                //cp.ExStyle |= (int)WindowStyles.WS_EX_NOACTIVATE;
                cp.ExStyle |= (int)WindowStyles.WS_EX_TOPMOST;
                return cp;
            }
        }

        protected override void InitLayout()
        {
            if (this.Parent != null)
            {
                this.BringToFront();
            }
            base.InitLayout();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bounds = this.ClientRectangle;
            Graphics g = e.Graphics;

            //g.Clear(Color.Transparent);

            if (DesignMode)
            {
                Color overlayColor = Color.HotPink; //Color.FromArgb(alpha: 128, baseColor: Color.HotPink); //Color.FromArgb(alpha: 128, baseColor: Color.HotPink);

                Brush thatchedBrush = new HatchBrush(HatchStyle.DashedHorizontal, overlayColor, Color.Transparent);
                g.FillRectangle(thatchedBrush, bounds);
                thatchedBrush.Dispose();

                ControlPaint.DrawBorder(g, bounds, overlayColor, ButtonBorderStyle.Solid);
            }

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

        protected override void OnParentForeColorChanged(EventArgs e)
        {
            Invalidate();
            base.OnParentForeColorChanged(e);
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
