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
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace OverlayControlsLibrary
{
    public class ThatchedPanel : Panel
    {
        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [DefaultValue(HatchStyle.DarkDownwardDiagonal)]
        public HatchStyle HatchingStyle
        {
            get { return _hatchingStyle; }
            set
            {
                if (_hatchingStyle != value)
                {
                    _hatchingStyle = value;
                    BuildThatchedBrush();
                    OnStyleChanged(EventArgs.Empty);
                    Invalidate();
                }
            }
        }
        private HatchStyle _hatchingStyle = HatchStyle.BackwardDiagonal;

        #region Overridden and hidden properties

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Text { get => ""; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font { get => base.Font; set => base.Font = value; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }

        protected override Padding DefaultMargin => new Padding(0);
        protected override Padding DefaultPadding => new Padding(0);

        private Brush _thatchedBrush = null;

        #endregion

        public ThatchedPanel()
            : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.Selectable, false);
            //this.SetStyle(ControlStyles.CacheText, true);
            //this.SetStyle(ControlStyles.ResizeRedraw, true);

            //this.BackColor = Color.Transparent;

            this.Margin = DefaultMargin;
            this.Padding = DefaultPadding;
            this.TabStop = false;
            //this.CausesValidation = false;
            //this.BringToFront();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                //cp.ExStyle |= (int)WindowStyles.WS_EX_TRANSPARENT;
                cp.Style |= (int)WindowStyles.WS_EX_CONTROLPARENT;
                //cp.Style |= (int)WindowStyles.WS_CHILD;
                //cp.ExStyle |= (int)WindowStyles.WS_EX_NOACTIVATE;
                cp.ExStyle |= (int)WindowStyles.WS_EX_COMPOSITED;
                //cp.ExStyle |= (int)WindowStyles.WS_EX_OVERLAPPEDWINDOW;
                //cp.ExStyle |= (int)WindowStyles.WS_EX_NOINHERITLAYOUT;
                //cp.ExStyle |= (int)WindowStyles.WS_EX_NOPARENTNOTIFY;
                //cp.ExStyle |= (int)WindowStyles.WS_EX_TOPMOST;
                return cp;
            }
        }

        protected override void InitLayout()
        {
            base.InitLayout();
        }

        private void BuildThatchedBrush()
        {
            if (_thatchedBrush != null)
            {
                _thatchedBrush.Dispose();
                _thatchedBrush = null;
            }
            _thatchedBrush = new HatchBrush(HatchingStyle, this.ForeColor, this.BackColor);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = e.ClipRectangle;

            if (this.Visible)
            {
                if (_thatchedBrush == null)
                {
                    BuildThatchedBrush();
                }

                g.Clear(this.BackColor);

                g.FillRectangle(_thatchedBrush, bounds);
                ControlPaint.DrawBorder(g, bounds, this.ForeColor, ButtonBorderStyle.Solid);
            }

            base.OnPaint(e);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            Invalidate();
            base.OnBackColorChanged(e);
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            Invalidate();
            base.OnLocationChanged(e);
        }

        protected override void OnMove(EventArgs e)
        {
            Invalidate();
            base.OnMove(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Invalidate();
            base.OnSizeChanged(e);
        }

        protected override void OnDockChanged(EventArgs e)
        {
            Invalidate();
            base.OnDockChanged(e);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            if (this.Visible)
            {
                Invalidate();
            }
            base.OnVisibleChanged(e);
        }
    }
}
