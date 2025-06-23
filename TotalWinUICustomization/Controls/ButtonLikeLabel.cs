using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWinUICustomization.Controls
{
    public class ButtonLikeLabel : Label
    {
        public ButtonLikeLabel()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.Selectable, false);

            this.Margin = DefaultMargin;
            this.Padding = DefaultPadding;
            this.TabStop = false;
            this.TextAlign = ContentAlignment.MiddleCenter;

        }

        protected override bool ShowFocusCues => false;
        protected override bool ShowKeyboardCues => false;
        protected override Padding DefaultMargin => new Padding(0);
        protected override Padding DefaultPadding => new Padding(0);

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle clientRect = this.ClientRectangle;

            g.Clear(this.BackColor);

            //ControlPaint.DrawBorder3D(g, clientRect);
            ControlPaint.DrawButton(g, clientRect, ButtonState.Normal);

            base.OnPaint(e);
        }
    }
}
