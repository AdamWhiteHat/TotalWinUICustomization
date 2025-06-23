using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWinUICustomization
{

    public static class BorderHelper
    {
        public static void AddBorder(Control control, Border3DStyle borderStyle)
        {
            control.Paint += (s, e) => { OnPaintHandler(s, e, borderStyle); };
        }

        private static void OnPaintHandler(object sender, PaintEventArgs e, Border3DStyle borderStyle)
        {
            Control self = sender as Control;
            Rectangle bounds = self.ClientRectangle; // e.ClipRectangle; 
            Graphics g = e.Graphics;

            DrawBorder3D(self, bounds, g);
        }

        public static Rectangle Shrink(Rectangle rectangle, int amount = 1)
        {
            return new Rectangle(rectangle.X + amount, rectangle.Y + amount, rectangle.Width - (amount * 2), rectangle.Height - (amount * 2));
        }

        public static Rectangle Grow(Rectangle rectangle, int amount = 1)
        {
            return new Rectangle(rectangle.X - amount, rectangle.Y - amount, rectangle.Width + (amount * 2), rectangle.Height + (amount * 2));
        }

        public static void DrawBorder3D(Control control, Rectangle bounds, Graphics windowsGraphics)
        {
            //Rectangle sizeRect = new Rectangle(new Point(0, 0), control.Size);
            //bounds = sizeRect;

            //Color backColor = control.BackColor;
            //Color windowDisabled = SystemColors.ControlDark;
            //Color buttonShadow = SystemColors.ControlDark;
            //Color buttonShadowDark = SystemColors.ControlDarkDark;
            //Color highlight = SystemColors.ControlLightLight;

            Pen lightLightPen = new Pen(SystemColors.ControlLightLight);
            Pen darkdarkPen = new Pen(SystemColors.ControlDarkDark);
            Pen controlPen = new Pen(SystemColors.Control);
            Pen darkPen = new Pen(SystemColors.ControlDark);

            Point MidTop_OuterRight = new Point(bounds.X + bounds.Width - 1, bounds.Y);
            Point MidTop_OuterLeft = new Point(bounds.X, bounds.Y);

            Point OuterBottom_MidLeft = new Point(bounds.X, bounds.Y + bounds.Height - 1);
            Point OuterBottom_OuterRight = new Point(bounds.X + bounds.Width - 1, bounds.Y + bounds.Height - 1);
            Point OuterTop_MidRight = new Point(bounds.X + bounds.Width - 1, bounds.Y - 1);

            Point InnerTop_InnerRight = new Point(bounds.X + bounds.Width - 2, bounds.Y + 1);
            Point InnerTop_InnerLeft = new Point(bounds.X + 1, bounds.Y + 1);

            Point InnerBottom_InnerLeft = new Point(bounds.X + 1, bounds.Y + bounds.Height - 2);
            Point InnerBottom_InnerRight = new Point(bounds.X + bounds.Width - 2, bounds.Y + bounds.Height - 2);
            Point MidTop_InnerRight = new Point(bounds.X + bounds.Width - 2, bounds.Y);

            try
            {
                windowsGraphics.DrawLine(lightLightPen, MidTop_OuterRight, MidTop_OuterLeft);
                windowsGraphics.DrawLine(lightLightPen, MidTop_OuterLeft, OuterBottom_MidLeft);

                windowsGraphics.DrawLine(darkdarkPen, OuterBottom_MidLeft, OuterBottom_OuterRight);
                windowsGraphics.DrawLine(darkdarkPen, OuterBottom_OuterRight, OuterTop_MidRight);

                windowsGraphics.DrawLine(controlPen, InnerTop_InnerRight, InnerTop_InnerLeft);
                windowsGraphics.DrawLine(controlPen, InnerTop_InnerLeft, InnerBottom_InnerLeft);

                windowsGraphics.DrawLine(darkPen, InnerBottom_InnerLeft, InnerBottom_InnerRight);
                windowsGraphics.DrawLine(darkPen, InnerBottom_InnerRight, MidTop_InnerRight);
            }
            finally
            {
                lightLightPen.Dispose();
                darkdarkPen.Dispose();
                controlPen.Dispose();
                darkPen.Dispose();
            }
        }

        /*
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
        */
    }
}
