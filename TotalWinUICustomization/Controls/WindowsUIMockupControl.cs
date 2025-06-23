using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;
using TotalWinUICustomization.Types;
using System.Drawing.Design;
using TotalWinUICustomization.Controls;

namespace TotalWinUICustomization
{
    public delegate void ColorUiElementClickedEventHandler(object? sender, ColorUiElementClickedEventArgs e);

    [System.ComponentModel.DefaultEvent("ColorUiElementClicked")]
    public partial class WindowsUIMockupControl : UserControl
    {
        /// <summary>
        /// Primary event. Raised whenever the user clicks on a UI element.
        /// The intent is to then to handle this event, 
        /// and populate a color swatch and color picker control to set the color
        /// for the system color the UI element represents
        /// </summary>
        public event ColorUiElementClickedEventHandler ColorUiElementClicked;

        #region Color Properties

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color InactiveTitleColor
        {
            get { return _inactiveTitle_Color1; }
            set
            {
                SetColorPropertyField(WindowsUiElements.InactiveTitle, ref _inactiveTitle_Color1, value);
                titleBar_InactiveWindow.Invalidate();
            }
        }
        private Color _inactiveTitle_Color1 = Color.FromKnownColor(KnownColor.InactiveCaption);

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color InactiveTitleGradientColor
        {
            get { return _inactiveTitle_Color2; }
            set
            {
                SetColorPropertyField(WindowsUiElements.InactiveTitleGradient, ref _inactiveTitle_Color2, value);
                titleBar_InactiveWindow.Invalidate();
            }
        }
        private Color _inactiveTitle_Color2 = Color.FromKnownColor(KnownColor.GradientInactiveCaption);

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color InactiveTitleTextColor
        {
            get { return font_InactiveWindowTitleBar.ForeColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(font_InactiveWindowTitleBar.ForeColor));
                SetColorPropertyField2(WindowsUiElements.InactiveTitleText, font_InactiveWindowTitleBar, propertyInfo, value);
            }
        }


        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color ActiveTitleColor
        {
            get { return _activeTitle_Color1; }
            set
            {
                SetColorPropertyField(WindowsUiElements.ActiveTitle, ref _activeTitle_Color1, value);
                titleBar_ActiveWindow.Invalidate();
            }
        }
        private Color _activeTitle_Color1 = Color.FromKnownColor(KnownColor.ActiveCaption);

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color ActiveTitleGradientColor
        {
            get { return _activeTitle_Color2; }
            set
            {
                SetColorPropertyField(WindowsUiElements.ActiveTitleGradient, ref _activeTitle_Color2, value);
                titleBar_ActiveWindow.Invalidate();
            }
        }
        private Color _activeTitle_Color2 = Color.FromKnownColor(KnownColor.GradientActiveCaption);

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color ActiveTitleTextColor
        {
            get { return font_ActiveWindowTitleBar.ForeColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(font_ActiveWindowTitleBar.ForeColor));
                SetColorPropertyField2(WindowsUiElements.ActiveTitleText, font_ActiveWindowTitleBar, propertyInfo, value);
            }
        }


        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color WindowColor
        {
            get { return textbox_ActiveWindow.BackColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(textbox_ActiveWindow.BackColor));
                SetColorPropertyField2(WindowsUiElements.Window, textbox_ActiveWindow, propertyInfo, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color WindowTextColor
        {
            get { return font_ActiveWindow.ForeColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(font_ActiveWindow.ForeColor));
                SetColorPropertyField2(WindowsUiElements.WindowText, font_ActiveWindow, propertyInfo, value);
            }
        }


        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color ButtonFaceColor
        {
            get { return button_MessageBox.BackColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(button_MessageBox.BackColor));
                SetColorPropertyField2(WindowsUiElements.ButtonFace, button_MessageBox, propertyInfo, value);

                PropertyInfo propertyInfo2 = typeof(Label).GetProperty(nameof(window_MessageBox.BackColor));
                SetColorPropertyField2(WindowsUiElements.ButtonFace, window_MessageBox, propertyInfo2, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color ButtonTextColor
        {
            get { return font_MessageBox.ForeColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(font_MessageBox.ForeColor));
                SetColorPropertyField2(WindowsUiElements.ButtonText, font_MessageBox, propertyInfo, value);

                PropertyInfo propertyInfo2 = typeof(Label).GetProperty(nameof(button_MessageBox.ForeColor));
                SetColorPropertyField2(WindowsUiElements.ButtonText, button_MessageBox, propertyInfo2, value);
            }
        }


        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color MenuColor
        {
            get { return menu.BackColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(menu.BackColor));
                SetColorPropertyField2(WindowsUiElements.Menu, menu, propertyInfo, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color MenuTextColor
        {
            get { return font_menuNormal.ForeColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(font_menuNormal.ForeColor));
                SetColorPropertyField2(WindowsUiElements.MenuText, font_menuNormal, propertyInfo, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color GrayTextColor
        {
            get { return font_menuDisabled.ForeColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(font_menuDisabled.ForeColor));
                SetColorPropertyField2(WindowsUiElements.GreyText, font_menuDisabled, propertyInfo, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color MenuHighlightColor
        {
            get { return font_menuSelected.BackColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(font_menuSelected.BackColor));
                SetColorPropertyField2(WindowsUiElements.MenuHighlight, font_menuSelected, propertyInfo, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color DesktopBackgroundColor
        {
            get { return desktopWindow.BackColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(desktopWindow.BackColor));
                SetColorPropertyField2(WindowsUiElements.DesktopBackground, desktopWindow, propertyInfo, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color InfoTextColor
        {
            get { return InfoWindowAndText.ForeColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(InfoWindowAndText.ForeColor));
                SetColorPropertyField2(WindowsUiElements.InfoText, InfoWindowAndText, propertyInfo, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color InfoWindowColor
        {
            get { return InfoWindowAndText.BackColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(InfoWindowAndText.BackColor));
                SetColorPropertyField2(WindowsUiElements.InfoWindow, InfoWindowAndText, propertyInfo, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color HilightColor
        {
            get { return selectedText.BackColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(selectedText.BackColor));
                SetColorPropertyField2(WindowsUiElements.Highlight, selectedText, propertyInfo, value);
            }
        }


        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color HilightTextColor
        {
            get { return selectedText.ForeColor; }
            set
            {
                PropertyInfo propertyInfo1 = typeof(Label).GetProperty(nameof(selectedText.ForeColor));
                SetColorPropertyField2(WindowsUiElements.HighlightText, selectedText, propertyInfo1, value);

                PropertyInfo propertyInfo2 = typeof(Label).GetProperty(nameof(font_menuSelected.ForeColor));
                SetColorPropertyField2(WindowsUiElements.HighlightText, font_menuSelected, propertyInfo2, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color HotTrackingColor
        {
            get { return hyperlinkText.LinkColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(LinkLabel).GetProperty(nameof(hyperlinkText.LinkColor));
                SetColorPropertyField2(WindowsUiElements.HotTrackingColor, hyperlinkText, propertyInfo, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color ScrollbarColor
        {
            get { return ScrollBarActiveWindow.BackColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(VScrollBar).GetProperty(nameof(ScrollBarActiveWindow.BackColor));
                SetColorPropertyField2(WindowsUiElements.Scrollbar, ScrollBarActiveWindow, propertyInfo, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color ActiveBorderColor
        {
            get { return _activeBorderColor; }
            set
            {
                SetColorPropertyField(WindowsUiElements.ActiveBorder, ref _activeBorderColor, value);
            }
        }
        private Color _activeBorderColor = Color.Gray;

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color InactiveBorderColor
        {
            get { return _inactiveBorderColor; }
            set
            {
                SetColorPropertyField(WindowsUiElements.InactiveBorder, ref _inactiveBorderColor, value);
            }
        }
        private Color _inactiveBorderColor = Color.Silver;

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color WindowFrameColor
        {
            get { return _windowFrameColor; }
            set
            {
                SetColorPropertyField(WindowsUiElements.WindowFrame, ref _windowFrameColor, value);
            }
        }
        private Color _windowFrameColor = Color.Black;



        /*
ButtonShadow=128 128 128
ButtonDkShadow=0 0 0
ButtonLight=192 192 192
ButtonHilight=192 192 192
ButtonAlternateFace=192 192 192

MenuBar=255 255 255
AppWorkspace=128 128 128
         */

        #endregion

        #region FontProperties

        public Font CaptionFont
        {
            get { return _captionFont; }
            set
            {
                _captionFont = value;
                font_ActiveWindowTitleBar.Font = value;
                font_InactiveWindowTitleBar.Font = value;
                font_MessageBoxTitleBar.Font = value;
            }
        }
        private Font _captionFont;

        public Font SmCaptionFont
        {
            get { return _smCaptionFont; }
            set
            {
                _smCaptionFont = value;
            }
        }
        private Font _smCaptionFont;

        public Font MessageFont
        {
            get { return _messageFont; }
            set
            {
                _messageFont = value;
                font_ActiveWindow.Font = value;
                selectedText.Font = value;
                button_MessageBox.Font = value;
                font_MessageBox.Font = value;
                hyperlinkText.Font = value;
            }
        }
        private Font _messageFont;

        public Font MenuFont
        {
            get { return _menuFont; }
            set
            {
                _menuFont = value;
                font_menuNormal.Font = value;
                font_menuDisabled.Font = value;
                font_menuSelected.Font = value;
            }
        }
        private Font _menuFont;

        public Font StatusFont
        {
            get { return _statusFont; }
            set
            {
                _statusFont = value;
                InfoWindowAndText.Font = value;
            }
        }
        private Font _statusFont;

        public Font IconFont
        {
            get { return _iconFont; }
            set
            {
                _iconFont = value;
                IconText.Font = value;
            }
        }
        private Font _iconFont;

        #endregion

        #region Constructor

        public WindowsUIMockupControl()
        {
            InitializeComponent();
            this.Load += WindowsUIMockupControl_Load;

            BorderHelper.AddBorder(window_MessageBox, Border3DStyle.SunkenOuter);
            BorderHelper.AddBorder(panelActiveWindow, Border3DStyle.SunkenOuter);

            //BorderHelper.AddBorder(button_MessageBox, Border3DStyle.Raised);
            //BorderHelper.AddBorder(buttonX_MessageBox, Border3DStyle.Raised);

            //BorderHelper.AddBorder(buttonMinimize_ActiveWindow, Border3DStyle.Raised);
            //BorderHelper.AddBorder(buttonMaximize_ActiveWindow, Border3DStyle.Raised);
            //BorderHelper.AddBorder(buttonX_ActiveWindow, Border3DStyle.Raised);
            //
            //BorderHelper.AddBorder(buttonMinimize_InactiveWindow, Border3DStyle.Raised);
            //BorderHelper.AddBorder(buttonMaximize_InactiveWindow, Border3DStyle.Raised);
            //BorderHelper.AddBorder(buttonX_InactiveWindow, Border3DStyle.Raised);
        }

        private void WindowsUIMockupControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                inactiveBorderClickInterceptor1.BringToFront();
                inactiveBorderClickInterceptor2.BringToFront();
                inactiveBorderClickInterceptor3.BringToFront();

                activeBorderClickInterceptor5.BringToFront();
                activeBorderClickInterceptor6.BringToFront();
                activeBorderClickInterceptor7.BringToFront();
                activeBorderClickInterceptor8.BringToFront();
                activeBorderClickInterceptor9.BringToFront();
                activeBorderClickInterceptor0.BringToFront();

                activeBorderClickInterceptor1.BringToFront();
                activeBorderClickInterceptor2.BringToFront();
                activeBorderClickInterceptor3.BringToFront();
                activeBorderClickInterceptor4.BringToFront();
            }
        }

        #endregion

        #region Paint Overrides

        private void titleBar_InactiveWindow_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(titleBar_InactiveWindow.ClientRectangle, _inactiveTitle_Color1, _inactiveTitle_Color2, 1f);
            e.Graphics.FillRectangle(gradientBrush, titleBar_InactiveWindow.ClientRectangle);
        }

        private void titleBar_ActiveWindow_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(titleBar_ActiveWindow.ClientRectangle, _activeTitle_Color1, _activeTitle_Color2, 1f);
            e.Graphics.FillRectangle(gradientBrush, titleBar_ActiveWindow.ClientRectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Rectangle bounds = this.ClientRectangle;
            //Graphics g = e.Graphics;

            // LinearGradientBrush gradientBrushInactive = new LinearGradientBrush(titleBar_InactiveWindow.ClientRectangle, InactiveTitle_Color1, InactiveTitle_Color2, 1f);
            //e.Graphics.FillRectangle(gradientBrushInactive, titleBar_InactiveWindow.ClientRectangle);

            //LinearGradientBrush gradientBrushActive = new LinearGradientBrush(titleBar_ActiveWindow.ClientRectangle, ActiveTitle_Color1, ActiveTitle_Color2, 1f);
            //e.Graphics.FillRectangle(gradientBrushActive, titleBar_ActiveWindow.ClientRectangle);


            // ControlPaint.DrawBorder(g, bounds, this.ForeColor, ButtonBorderStyle.Solid);
        }

        #endregion

        #region Internal Control Click Events

        private void titleBar_ActiveWindow_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.ActiveTitle);
        }

        private void titleBar_InactiveWindow_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.InactiveTitle);
        }

        private void titleBar_MessageBox_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.ActiveTitle);
        }

        private void textbox_ActiveWindow_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.Window);
        }



        private void window_MessageBox_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.ButtonFace);
        }

        private void window_Desktop_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.DesktopBackground);
        }

        private void button_MessageBox_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.ButtonFace);
        }


        private void font_InactiveWindowTitleBar_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.InactiveTitleText);
        }

        private void font_ActiveWindowTitleBar_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.ActiveTitleText);
        }

        private void font_ActiveWindow_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.WindowText);
        }

        private void font_MessageBoxTitleBar_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.ActiveTitleText);
        }

        private void font_MessageBox_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.ButtonText);
        }

        private void font_menuNormal_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.MenuText);
        }

        private void font_menuDisabled_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.GreyText);
        }

        private void font_menuSelected_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.MenuHighlight);
        }



        private void controlBox_InactiveWindow_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.WindowText);
        }

        private void controlBox_ActiveWindow_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.WindowText);
        }
        private void controlBox_MessageBox_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.DesktopBackground);
        }


        private void font_hyperlinkText_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.HotTrackingColor);
        }

        private void InfoWindowAndText_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.InfoWindow);
        }


        private void menu_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.Menu);
        }

        private void selectedText_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.Highlight);
        }

        private void ScrollBar_Clicked(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.Scrollbar);
        }

        private void iconClickInterceptor_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.DesktopBackground);
        }

        private void activeBorderClickInterceptor_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.ActiveBorder);
        }

        private void inactiveBorderClickInterceptor_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(WindowsUiElements.InactiveBorder);
        }

        #endregion

        /// <summary>Helper methods. Raises the ColorUiElementClickedEvent Event</summary>
        protected void RaiseColorUiElementClickedEvent(WindowsUiElements elementClicked)
        {
            ColorUiElementClicked?.Invoke(this, new ColorUiElementClickedEventArgs(elementClicked));
        }

        public void UpdateControlFont(WindowsUiElements uiElement, Font font)
        {
            switch (uiElement)
            {
                case WindowsUiElements.ActiveTitleText:
                case WindowsUiElements.InactiveTitleText:
                    CaptionFont = font;
                    break;

                case WindowsUiElements.WindowText:
                case WindowsUiElements.ButtonText:
                    MessageFont = font;
                    break;

                case WindowsUiElements.MenuText:
                case WindowsUiElements.GreyText:
                case WindowsUiElements.HighlightText:
                    MenuFont = font;
                    break;

                case WindowsUiElements.InfoText:
                    StatusFont = font;
                    break;
            }
        }

        public void UpdateControlColor(WindowsUiElements uiElement, Color color)
        {
            switch (uiElement)
            {
                case WindowsUiElements.InactiveTitle:
                    InactiveTitleColor = color;
                    break;
                case WindowsUiElements.InactiveTitleGradient:
                    InactiveTitleGradientColor = color;
                    break;
                case WindowsUiElements.InactiveTitleText:
                    InactiveTitleTextColor = color;
                    break;

                case WindowsUiElements.ActiveTitle:
                    ActiveTitleColor = color;
                    break;
                case WindowsUiElements.ActiveTitleGradient:
                    ActiveTitleGradientColor = color;
                    break;
                case WindowsUiElements.ActiveTitleText:
                    ActiveTitleTextColor = color;
                    break;

                case WindowsUiElements.Window:
                    WindowColor = color;
                    break;
                case WindowsUiElements.WindowText:
                    WindowTextColor = color;
                    break;

                case WindowsUiElements.ButtonFace:
                    ButtonFaceColor = color;
                    break;
                case WindowsUiElements.ButtonText:
                    ButtonTextColor = color;
                    break;

                case WindowsUiElements.Menu:
                    MenuColor = color;
                    break;
                case WindowsUiElements.MenuText:
                    MenuTextColor = color;
                    break;
                case WindowsUiElements.GreyText:
                    GrayTextColor = color;
                    break;
                case WindowsUiElements.MenuHighlight:
                    MenuHighlightColor = color;
                    break;

                case WindowsUiElements.DesktopBackground:
                    DesktopBackgroundColor = color;
                    break;

                case WindowsUiElements.InfoText:
                    InfoTextColor = color;
                    break;
                case WindowsUiElements.InfoWindow:
                    InfoWindowColor = color;
                    break;

                case WindowsUiElements.Highlight:
                    HilightColor = color;
                    break;
                case WindowsUiElements.HighlightText:
                    HilightTextColor = color;
                    break;

                case WindowsUiElements.HotTrackingColor:
                    HotTrackingColor = color;
                    break;
                case WindowsUiElements.Scrollbar:
                    ScrollbarColor = color;
                    break;
            }
        }

        protected static void SetColorPropertyField(WindowsUiElements uiElement, ref Color field, Color value)
        {
            if (!field.Equals(value))
            {
                field = value;
                //RegistryHelper.SetWindowsColor(uiElement, value);
            }
        }

        protected static void SetColorPropertyField2(WindowsUiElements uiElement, object target, PropertyInfo field, Color value)
        {
            Color fieldValue = (Color)field.GetValue(target);

            if (!fieldValue.Equals(value))
            {
                MethodInfo setMethod = field.GetSetMethod(); // PropertyInfo.GetSetMethod
                setMethod.Invoke(target, new object[] { value });
                //  RegistryHelper.SetWindowsColor(uiElement, value);
            }
        }

    }
}
