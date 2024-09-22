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

        #region Constructor

        public WindowsUIMockupControl()
        {
            InitializeComponent();
            this.Load += WindowsUIMockupControl_Load;
        }

        private void WindowsUIMockupControl_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Color Properties

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color InactiveTitleColor
        {
            get { return InactiveTitle_Color1; }
            set
            {
                SetColorPropertyField(WindowsUiElements.InactiveTitle, ref InactiveTitle_Color1, value);
                titleBar_InactiveWindow.Invalidate();
            }
        }
        private Color InactiveTitle_Color1 = Color.FromKnownColor(KnownColor.InactiveCaption);

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color InactiveTitleGradientColor
        {
            get { return InactiveTitle_Color2; }
            set
            {
                SetColorPropertyField(WindowsUiElements.InactiveTitleGradient, ref InactiveTitle_Color2, value);
                titleBar_InactiveWindow.Invalidate();
            }
        }
        private Color InactiveTitle_Color2 = Color.FromKnownColor(KnownColor.GradientInactiveCaption);

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
            get { return ActiveTitle_Color1; }
            set
            {
                SetColorPropertyField(WindowsUiElements.ActiveTitle, ref ActiveTitle_Color1, value);
                titleBar_ActiveWindow.Invalidate();
            }
        }
        private Color ActiveTitle_Color1 = Color.FromKnownColor(KnownColor.ActiveCaption);

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color ActiveTitleGradientColor
        {
            get { return ActiveTitle_Color2; }
            set
            {
                SetColorPropertyField(WindowsUiElements.ActiveTitleGradient, ref ActiveTitle_Color2, value);
                titleBar_ActiveWindow.Invalidate();
            }
        }
        private Color ActiveTitle_Color2 = Color.FromKnownColor(KnownColor.GradientActiveCaption);

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

                PropertyInfo propertyInfo2 = typeof(Label).GetProperty(nameof(font_ActiveWindow.BackColor));
                SetColorPropertyField2(WindowsUiElements.Window, font_ActiveWindow, propertyInfo2, value);
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
            get { return selectedText.ForeColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(selectedText.ForeColor));
                SetColorPropertyField2(WindowsUiElements.Highlight, selectedText, propertyInfo, value);
            }
        }


        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color HilightTextColor
        {
            get { return selectedText.BackColor; }
            set
            {
                PropertyInfo propertyInfo = typeof(Label).GetProperty(nameof(selectedText.BackColor));
                SetColorPropertyField2(WindowsUiElements.HighlightText, selectedText, propertyInfo, value);
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

        /*
        public Color ActiveBorderColor
        {
            get { return Color.Gray; }
        }

        public Color InactiveBorderColor
        {
            get { return Color.Silver; }
        }

        public Color WindowFrameColor
        {
            get { return Color.Black; }
        }
        */
        /*
ActiveBorder=128 128 128
InactiveBorder=192 192 192
WindowFrame=255 255 255

ButtonShadow=128 128 128
ButtonDkShadow=0 0 0
ButtonLight=192 192 192
ButtonHilight=192 192 192
ButtonAlternateFace=192 192 192

InfoText=0 0 0
InfoWindow=255 255 255

MenuBar=255 255 255
AppWorkspace=128 128 128
         */

        #endregion



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

        private void titleBar_InactiveWindow_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(titleBar_InactiveWindow.ClientRectangle, InactiveTitle_Color1, InactiveTitle_Color2, 1f);
            e.Graphics.FillRectangle(gradientBrush, titleBar_InactiveWindow.ClientRectangle);
        }

        private void titleBar_ActiveWindow_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(titleBar_ActiveWindow.ClientRectangle, ActiveTitle_Color1, ActiveTitle_Color2, 1f);
            e.Graphics.FillRectangle(gradientBrush, titleBar_ActiveWindow.ClientRectangle);
        }





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

        /// <summary>Helper methods. Raises the ColorUiElementClickedEvent Event</summary>
        protected void RaiseColorUiElementClickedEvent(WindowsUiElements elementClicked)
        {
            ColorUiElementClicked?.Invoke(this, new ColorUiElementClickedEventArgs(elementClicked));
        }

        #endregion

    }
}
