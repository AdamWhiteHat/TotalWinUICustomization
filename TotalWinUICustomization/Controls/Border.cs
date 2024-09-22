using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;

namespace TotalWinUICustomization.Controls
{
    public class Border : Control
    {

        [Browsable(true)]
        [DefaultValue(1)]
        [Category(nameof(CategoryAttribute.Appearance))]
        public int BorderWidth { get; set; } = 1;

        protected override Padding DefaultMargin => new Padding(0);
        protected override Padding DefaultPadding => new Padding(0);

        private bool isMouseDown = false;
        private bool isDragging = false;

        public Border()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x20;
                return cp;
            }
        }
        protected override void OnBackColorChanged(EventArgs e)
        {
            if (this.Parent != null)
            {
                Parent.Invalidate(this.Bounds, true);
            }
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

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bounds = this.ClientRectangle;
            Graphics g = e.Graphics;
            ControlPaint.DrawBorder(g, bounds, this.ForeColor, ButtonBorderStyle.Solid);
            
            // g.Clear(backColor);
            // ControlPaint.DrawReversibleFrame(bounds, this.ForeColor, FrameStyle.Thick);// ButtonBorderStyle.Solid);
            // ControlPaint.DrawFocusRectangle(g, bounds, this.ForeColor, this.BackColor);
            // ControlPaint.DrawBorder3D(g, bounds, Border3DStyle.SunkenOuter, Border3DSide.All);
            // ControlPaint.DrawBorder(g, bounds,
            //     this.ForeColor, BorderWidth, ButtonBorderStyle.Solid,
            //     this.ForeColor, BorderWidth, ButtonBorderStyle.Solid,
            //     this.ForeColor, BorderWidth, ButtonBorderStyle.Solid,
            //     this.ForeColor, BorderWidth, ButtonBorderStyle.Solid);
            // using (Pen light = new Pen(this.ForeColor))            {            }

            base.OnPaint(e);
        }


        protected void Paint3dBorder(Graphics g)
        {
            Color backColor = this.BackColor;
            Rectangle bounds = this.ClientRectangle;

            using (Pen light = new Pen(ControlPaint.Light(backColor, 1.0f)))
            {
                using (Pen dark = new Pen(ControlPaint.Dark(backColor, 0f)))
                {


                    // left
                    g.DrawLine(light, bounds.Left + 1, bounds.Top + 1, bounds.Left + 1, bounds.Height - 1);
                    g.DrawLine(dark, bounds.Left, bounds.Top + 1, bounds.Left, bounds.Height - 2);

                    // bottom
                    g.DrawLine(light, bounds.Left, bounds.Height - 1, bounds.Width - 1, bounds.Height - 1);
                    g.DrawLine(dark, bounds.Left, bounds.Height - 2, bounds.Width - 1, bounds.Height - 2);

                    // top
                    g.DrawLine(light, bounds.Left + 1, bounds.Top + 1, bounds.Width - 1, bounds.Top + 1);
                    g.DrawLine(dark, bounds.Left, bounds.Top, bounds.Width - 2, bounds.Top);

                    // right
                    g.DrawLine(light, bounds.Width - 1, bounds.Top, bounds.Width - 1, bounds.Height - 1);
                    g.DrawLine(dark, bounds.Width - 2, bounds.Top, bounds.Width - 2, bounds.Height - 2);
                }
            }
        }


    }
}
