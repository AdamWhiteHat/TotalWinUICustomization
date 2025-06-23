using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWinUICustomization.Controls
{
    public class DisabledStyleLabel : Label
    {
        public DisabledStyleLabel()
            : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.Selectable, false);

            this.Margin = DefaultMargin;
            this.Padding = DefaultPadding;
            this.TabStop = false;
            //base.Text = "Disabled";
        }

        protected override void InitLayout()
        {
            base.InitLayout();
        }

        protected override bool ShowFocusCues => false;
        protected override bool ShowKeyboardCues => false;
        protected override Padding DefaultMargin => new Padding(0);
        protected override Padding DefaultPadding => new Padding(0);

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Point origin = g.RenderingOrigin;
            Rectangle clientRect = this.ClientRectangle;

            g.Clear(this.BackColor);

            Size textSize = TextRenderer.MeasureText(this.Text, this.Font);

            ControlPaint.DrawStringDisabled(g, this.Text, this.Font, this.BackColor, new RectangleF(new Point(clientRect.Left, clientRect.Top), textSize), StringFormat.GenericDefault);

            //base.OnPaint(e);
        }
    }
}
