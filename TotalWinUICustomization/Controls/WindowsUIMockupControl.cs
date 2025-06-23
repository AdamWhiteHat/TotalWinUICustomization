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
            get { return titleBar_InactiveWindow.BackColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Panel).GetProperty(nameof(BackColor));
                SetColorPropertyField2(WindowsUiElements.InactiveTitle, titleBar_InactiveWindow, propertyInfo, value);
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color InactiveTitleGradientColor
        {
            get { return _inactiveTitle_Color2; }
            set
            {
                SetColorPropertyField(WindowsUiElements.InactiveTitle, ref _inactiveTitle_Color2, value);
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(ForeColor));
                SetColorPropertyField2(WindowsUiElements.InactiveTitleText, font_InactiveWindowTitleBar, propertyInfo, value);
                font_InactiveWindowTitleBar.Invalidate();
            }
        }


        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color ActiveTitleColor
        {
            get { return titleBar_ActiveWindow.BackColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Panel).GetProperty(nameof(BackColor));
                SetColorPropertyField2(WindowsUiElements.InactiveTitle, titleBar_ActiveWindow, propertyInfo, value);
                titleBar_ActiveWindow.Invalidate();
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color ActiveTitleGradientColor
        {
            get { return _activeTitle_Color2; }
            set
            {
                SetColorPropertyField(WindowsUiElements.ActiveTitleGradient, ref _activeTitle_Color2, value);
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(ForeColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(BackColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(ForeColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(BackColor));
                SetColorPropertyField2(WindowsUiElements.ButtonFace, button_MessageBox, propertyInfo, value);

                PropertyInfo propertyInfo2 = typeof(Label).GetProperty(nameof(BackColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(ForeColor));
                SetColorPropertyField2(WindowsUiElements.ButtonText, font_MessageBox, propertyInfo, value);

                PropertyInfo propertyInfo2 = typeof(Label).GetProperty(nameof(ForeColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(BackColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(ForeColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(ForeColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(BackColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(BackColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(ForeColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(BackColor));
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
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(BackColor));
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
                PropertyInfo propertyInfo1 = typeof(Label).GetProperty(nameof(ForeColor));
                SetColorPropertyField2(WindowsUiElements.HighlightText, selectedText, propertyInfo1, value);

                PropertyInfo propertyInfo2 = typeof(Label).GetProperty(nameof(ForeColor));
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
                PropertyInfo propertyInfo = typeof(VScrollBar).GetProperty(nameof(BackColor));
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
            }
        }
        private Font _captionFont;

        public Font SmCaptionFont
        {
            get { return _smCaptionFont; }
            set
            {
                _smCaptionFont = value;
                font_MessageBoxTitleBar.Font = value;
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

        /*
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
        */

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

        private void ActiveTitleBar_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.ActiveTitle);
        }
        private void controlBox_MessageBox_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.ActiveTitle);
        }
        private void controlBox_ActiveWindow_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.ActiveTitle);
        }

        private void InactiveTitleBar_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.InactiveTitle);
        }
        private void controlBox_InactiveWindow_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.InactiveTitle);
        }

        private void textbox_ActiveWindow_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.Window);
        }
        private void font_ActiveWindow_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.Window);
        }


        private void window_MessageBox_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.ButtonFace);
        }

        private void activeBorderClickInterceptor_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.ActiveBorder);
        }

        private void inactiveBorderClickInterceptor_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.InactiveBorder);
        }

        private void window_Desktop_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.DesktopBackground);
        }



        private void font_menuNormal_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.Menu);
        }

        private void font_menuDisabled_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.GreyText);
        }

        private void font_menuSelected_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.MenuHighlight);
        }


        private void font_hyperlinkText_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.HotTrackingColor);
        }

        private void InfoWindowAndText_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.InfoWindow);
        }


        private void menu_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.Menu);
        }

        private void selectedText_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.Highlight);
        }

        private void ScrollBar_Clicked(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.Scrollbar);
        }

        private void iconClickInterceptor_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.IconFont);
        }


        #endregion

        /// <summary>Helper methods. Raises the ColorUiElementClickedEvent Event</summary>
        protected void RaiseColorUiElementClickedEvent(UIElementAssociation elementClicked)
        {
            ColorUiElementClicked?.Invoke(this, new ColorUiElementClickedEventArgs(elementClicked));
        }

        public void UpdateControlFont(SystemFontGroup fontGroup, Font font)
        {
            switch (fontGroup)
            {
                case SystemFontGroup.CaptionFont:
                    CaptionFont = font;
                    break;

                case SystemFontGroup.SmCaptionFont:
                    SmCaptionFont = font;
                    break;

                case SystemFontGroup.MessageFont:
                    MessageFont = font;
                    break;

                case SystemFontGroup.MenuFont:
                    MenuFont = font;
                    break;

                case SystemFontGroup.StatusFont:
                    StatusFont = font;
                    break;

                case SystemFontGroup.IconFont:
                    IconFont = font;
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
            }
        }

        protected static void SetColorPropertyField2(WindowsUiElements uiElement, object target, PropertyInfo field, Color value)
        {
            Color fieldValue = (Color)field.GetValue(target);

            if (!fieldValue.Equals(value))
            {
                MethodInfo setMethod = field.GetSetMethod(); // PropertyInfo.GetSetMethod
                setMethod.Invoke(target, new object[] { value });
            }
        }

    }
}
