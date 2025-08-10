﻿using System;
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
using CommonClassesLibrary;

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
                if (!titleBar_InactiveWindow.BackColor.Equals(value))
                {
                    titleBar_InactiveWindow.BackColor = value;
                    titleBar_InactiveWindow.Invalidate();
                }
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
                if (!_inactiveTitle_Color2.Equals(value))
                {
                    _inactiveTitle_Color2 = value;
                }
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
                if (!font_InactiveWindowTitleBar.ForeColor.Equals(value))
                {
                    font_InactiveWindowTitleBar.ForeColor = value;
                    font_InactiveWindowTitleBar.Invalidate();
                }
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
                if (!titleBar_ActiveWindow.BackColor.Equals(value))
                {
                    titleBar_ActiveWindow.BackColor = value;
                    titleBar_ActiveWindow.Invalidate();
                }
                if (!titleBar_MessageBox.BackColor.Equals(value))
                {
                    titleBar_MessageBox.BackColor = value;
                    titleBar_MessageBox.Invalidate();
                }
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
                if (!_activeTitle_Color2.Equals(value))
                {
                    _activeTitle_Color2 = value;
                }
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
                if (!font_ActiveWindowTitleBar.ForeColor.Equals(value))
                {
                    font_ActiveWindowTitleBar.ForeColor = value;
                    font_ActiveWindowTitleBar.Invalidate();
                }
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
                if (!textbox_ActiveWindow.BackColor.Equals(value))
                {
                    textbox_ActiveWindow.BackColor = value;
                    textbox_ActiveWindow.Invalidate();
                }
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
                if (!font_ActiveWindow.ForeColor.Equals(value))
                {
                    font_ActiveWindow.ForeColor = value;
                    font_ActiveWindow.Invalidate();
                }
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
                if (!button_MessageBox.BackColor.Equals(value))
                {
                    button_MessageBox.BackColor = value;
                    button_MessageBox.Invalidate();
                }
                if (!window_MessageBox.BackColor.Equals(value))
                {
                    window_MessageBox.BackColor = value;
                    window_MessageBox.Invalidate();
                }
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
                if (!font_MessageBox.ForeColor.Equals(value))
                {
                    font_MessageBox.ForeColor = value;
                    font_MessageBox.Invalidate();
                }
                if (!button_MessageBox.ForeColor.Equals(value))
                {
                    button_MessageBox.ForeColor = value;
                    button_MessageBox.Invalidate();
                }
            }
        }


        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color MenuBarColor
        {
            get { return menuBar.BackColor; }
            set
            {
                if (!menuBar.BackColor.Equals(value))
                {
                    menuBar.BackColor = value;
                    menuBar.Invalidate();
                }
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
                if (!font_menuNormal.ForeColor.Equals(value))
                {
                    font_menuNormal.ForeColor = value;
                    font_menuNormal.Invalidate();
                }
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
                if (!font_menuDisabled.ForeColor.Equals(value))
                {
                    font_menuDisabled.ForeColor = value;
                    font_menuDisabled.Invalidate();
                }
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
                if (!font_menuSelected.BackColor.Equals(value))
                {
                    font_menuSelected.BackColor = value;
                    font_menuSelected.Invalidate();
                }
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
                if (!desktopWindow.BackColor.Equals(value))
                {
                    desktopWindow.BackColor = value;
                    desktopWindow.Invalidate();
                }
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color InfoTextColor
        {
            get { return toolTip_InfoWindow.ForeColor; }
            set
            {
                if (!toolTip_InfoWindow.ForeColor.Equals(value))
                {
                    toolTip_InfoWindow.ForeColor = value;
                    toolTip_InfoWindow.Invalidate();
                }
            }
        }

        [Browsable(true)]
        [Category(nameof(CategoryAttribute.Appearance))]
        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color InfoWindowColor
        {
            get { return toolTip_InfoWindow.BackColor; }
            set
            {
                if (!toolTip_InfoWindow.BackColor.Equals(value))
                {
                    toolTip_InfoWindow.BackColor = value;
                    toolTip_InfoWindow.Invalidate();
                }
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
                if (!selectedText.BackColor.Equals(value))
                {
                    selectedText.BackColor = value;
                    selectedText.Invalidate();
                }
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
                if (!selectedText.ForeColor.Equals(value))
                {
                    selectedText.ForeColor = value;
                    selectedText.Invalidate();
                }
                if (!font_menuSelected.ForeColor.Equals(value))
                {
                    font_menuSelected.ForeColor = value;
                    font_menuSelected.Invalidate();
                }
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
                if (!hyperlinkText.LinkColor.Equals(value))
                {
                    hyperlinkText.LinkColor = value;
                    hyperlinkText.Invalidate();
                }
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
                if (!ScrollBarActiveWindow.BackColor.Equals(value))
                {
                    ScrollBarActiveWindow.BackColor = value;
                    ScrollBarActiveWindow.Invalidate();
                }
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
                if (!_activeBorderColor.Equals(value))
                {
                    _activeBorderColor = value;
                }
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
                if (!_inactiveBorderColor.Equals(value))
                {
                    _inactiveBorderColor = value;
                }
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
                if (!_windowFrameColor.Equals(value))
                {
                    _windowFrameColor = value;
                }
            }
        }
        private Color _windowFrameColor = Color.Black;

        #endregion

        #region FontProperties

        public Font CaptionFont
        {
            get { return _captionFont; }
            set
            {
                _captionFont = value;
                if (!font_ActiveWindowTitleBar.Font.Equals(value))
                {
                    font_ActiveWindowTitleBar.Font = value;
                    font_ActiveWindowTitleBar.Invalidate();
                }
                if (!font_InactiveWindowTitleBar.Font.Equals(value))
                {
                    font_InactiveWindowTitleBar.Font = value;
                    font_InactiveWindowTitleBar.Invalidate();
                }
                if (!font_MessageBoxTitleBar.Font.Equals(value))
                {
                    font_MessageBoxTitleBar.Font = value;
                    font_MessageBoxTitleBar.Invalidate();
                }
            }
        }
        private Font _captionFont;

        public Font SmCaptionFont
        {
            get { return _smCaptionFont; }
            set
            {
                if (_smCaptionFont != value)
                {
                    _smCaptionFont = value;
                }
            }
        }
        private Font _smCaptionFont;

        public Font MessageFont
        {
            get { return _messageFont; }
            set
            {
                _messageFont = value;
                if (!font_MessageBox.Font.Equals(value))
                {
                    font_MessageBox.Font = value;
                    font_MessageBox.Invalidate();
                }
                if (!button_MessageBox.Font.Equals(value))
                {
                    button_MessageBox.Font = value;
                    button_MessageBox.Invalidate();
                }
                if (!font_ActiveWindow.Font.Equals(value))
                {
                    font_ActiveWindow.Font = value;
                    font_ActiveWindow.Invalidate();
                }
                if (!hyperlinkText.Font.Equals(value))
                {
                    hyperlinkText.Font = value;
                    hyperlinkText.Invalidate();
                }
                if (!selectedText.Font.Equals(value))
                {
                    selectedText.Font = value;
                    selectedText.Invalidate();
                }
            }
        }
        private Font _messageFont;

        public Font MenuFont
        {
            get { return _menuFont; }
            set
            {
                _menuFont = value;
                if (!font_menuNormal.Font.Equals(value))
                {
                    font_menuNormal.Font = value;
                    font_menuNormal.Invalidate();
                }
                if (!font_menuDisabled.Font.Equals(value))
                {
                    font_menuDisabled.Font = value;
                    font_menuDisabled.Invalidate();
                }
                if (!font_menuSelected.Font.Equals(value))
                {
                    font_menuSelected.Font = value;
                    font_menuSelected.Invalidate();
                }
            }
        }
        private Font _menuFont;

        public Font StatusFont
        {
            get { return _statusFont; }
            set
            {
                _statusFont = value;
                if (!toolTip_InfoWindow.Font.Equals(value))
                {
                    toolTip_InfoWindow.Font = value;
                    toolTip_InfoWindow.Invalidate();
                }
            }
        }
        private Font _statusFont;

        public Font IconFont
        {
            get { return _iconFont; }
            set
            {
                _iconFont = value;
                if (!IconText.Font.Equals(value))
                {
                    IconText.Font = value;
                    IconText.Invalidate();
                }
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

            BorderHelper.AddBorder(button_MessageBox, Border3DStyle.Raised);
            BorderHelper.AddBorder(buttonX_MessageBox, Border3DStyle.Raised);

            BorderHelper.AddBorder(buttonMinimize_ActiveWindow, Border3DStyle.Raised);
            BorderHelper.AddBorder(buttonMaximize_ActiveWindow, Border3DStyle.Raised);
            BorderHelper.AddBorder(buttonX_ActiveWindow, Border3DStyle.Raised);

            BorderHelper.AddBorder(buttonMinimize_InactiveWindow, Border3DStyle.Raised);
            BorderHelper.AddBorder(buttonMaximize_InactiveWindow, Border3DStyle.Raised);
            BorderHelper.AddBorder(buttonX_InactiveWindow, Border3DStyle.Raised);
        }

        private void WindowsUIMockupControl_Load(object sender, EventArgs e)
        {
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


        private void menuBar_Click(object sender, EventArgs e)
        {
            RaiseColorUiElementClickedEvent(UIElementAssociation.MenuBar);
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

        public void UpdateControlFont(WindowsUiElements fontGroup, Font font)
        {
            switch (fontGroup)
            {
                case WindowsUiElements.CaptionFont:
                    CaptionFont = font;
                    break;

                case WindowsUiElements.SmCaptionFont:
                    SmCaptionFont = font;
                    break;

                case WindowsUiElements.MessageFont:
                    MessageFont = font;
                    break;

                case WindowsUiElements.MenuFont:
                    MenuFont = font;
                    break;

                case WindowsUiElements.StatusFont:
                    StatusFont = font;
                    break;

                case WindowsUiElements.IconFont:
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

                    break;
                case WindowsUiElements.MenuBar:
                    MenuBarColor = color;
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

    }
}
