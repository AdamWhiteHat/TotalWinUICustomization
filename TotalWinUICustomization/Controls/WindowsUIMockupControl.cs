using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms.Design;
using CommonClassesLibrary;
using TotalWinUICustomization.Controls;
using TotalWinUICustomization.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TotalWinUICustomization
{
    public delegate void ColorUiElementClickedEventHandler(object sender, ColorUiElementClickedEventArgs e);

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

        public static List<WindowsUiElements> AllWindowsUiElements =  Enum.GetValues(typeof(WindowsUiElements)).OfType<WindowsUiElements>().ToList();

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

        #region Font Properties

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

        #region Pending Changes

        /// <summary>
        /// Returns true if <see cref="SettingUpdatesPending"/> contains any items.
        /// </summary>
        public bool IsDirty { get { return SettingUpdatesPending.Any(); } }

        public int PendingChangesCount { get { return SettingUpdatesPending.Count; } }

        /// <summary>
        /// Represents a set of Windows UI changes that are being previewed, but have yet to be applied.
        /// </summary>
        public List<SettingUpdateAction> SettingUpdatesPending { get; private set; }

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

            SettingUpdatesPending = new List<SettingUpdateAction>();
        }

        private void WindowsUIMockupControl_Load(object sender, EventArgs e)
        {
            window_MessageBox.Click += window_MessageBox_Click;
            button_MessageBox.Click += window_MessageBox_Click;
            toolTip_InfoWindow.Click += InfoWindowAndText_Click;
            hyperlinkText.Click += font_hyperlinkText_Click;
            font_MessageBox.Click += window_MessageBox_Click;
            titleBar_MessageBox.Click += ActiveTitleBar_Click;
            font_MessageBoxTitleBar.Click += ActiveTitleBar_Click;
            buttonX_MessageBox.Click += controlBox_MessageBox_Click;
            menuBar.Click += menuBar_Click;
            font_menuNormal.Click += font_menuNormal_Click;
            font_menuDisabled.Click += font_menuDisabled_Click;
            font_menuSelected.Click += font_menuSelected_Click;
            textbox_ActiveWindow.Click += textbox_ActiveWindow_Click;
            scrollbarClickInterceptor.Click += ScrollBar_Clicked;
            font_ActiveWindow.Click += font_ActiveWindow_Click;
            selectedText.Click += selectedText_Click;
            ScrollBarActiveWindow.Scroll += ScrollBar_Clicked;
            ScrollBarActiveWindow.ValueChanged += ScrollBar_Clicked;
            titleBar_ActiveWindow.Click += ActiveTitleBar_Click;
            buttonMinimize_ActiveWindow.Click += controlBox_ActiveWindow_Click;
            buttonMaximize_ActiveWindow.Click += controlBox_ActiveWindow_Click;
            font_ActiveWindowTitleBar.Click += ActiveTitleBar_Click;
            buttonX_ActiveWindow.Click += controlBox_ActiveWindow_Click;
            titleBar_InactiveWindow.Click += InactiveTitleBar_Click;
            buttonMinimize_InactiveWindow.Click += controlBox_InactiveWindow_Click;
            buttonMaximize_InactiveWindow.Click += controlBox_InactiveWindow_Click;
            buttonX_InactiveWindow.Click += controlBox_InactiveWindow_Click;
            font_InactiveWindowTitleBar.Click += InactiveTitleBar_Click;
            desktopWindow.Click += window_Desktop_Click;
            iconClickInterceptor.Click += iconClickInterceptor_Click;
            inactiveBorderClickInterceptor1.Click += inactiveBorderClickInterceptor_Click;
            inactiveBorderClickInterceptor3.Click += inactiveBorderClickInterceptor_Click;
            activeBorderClickInterceptor5.Click += activeBorderClickInterceptor_Click;
            inactiveBorderClickInterceptor2.Click += inactiveBorderClickInterceptor_Click;
            activeBorderClickInterceptor6.Click += activeBorderClickInterceptor_Click;
            activeBorderClickInterceptor7.Click += activeBorderClickInterceptor_Click;
            activeBorderClickInterceptor8.Click += activeBorderClickInterceptor_Click;
            activeBorderClickInterceptor9.Click += activeBorderClickInterceptor_Click;
            activeBorderClickInterceptor0.Click += activeBorderClickInterceptor_Click;
            activeBorderClickInterceptor3.Click += activeBorderClickInterceptor_Click;
            activeBorderClickInterceptor4.Click += activeBorderClickInterceptor_Click;
            activeBorderClickInterceptor2.Click += activeBorderClickInterceptor_Click;
            activeBorderClickInterceptor1.Click += activeBorderClickInterceptor_Click;

            Initialize();
        }

        private void Initialize()
        {
            LoadSizes();
            RefreshSettingsFromRegistry(AllWindowsUiElements);
        }

        /// <summary>
        ///  Removes any pending updates that modify the given setting, if it exists.
        ///  Returns true if a corresponding update for the setting was found, false otherwise.
        /// </summary>
        public bool RemovePendingUpdate(WindowsUiElements settingToRemove)
        {
            return RemovePendingUpdates(new List<WindowsUiElements>() { settingToRemove });
        }

        /// <summary>
        ///  Remove any pending updates that modify the supplied settings, if they exist.
        ///  Returns true if any updates to remove were found (and removed). Returns false if no corresponding updates were found.
        /// </summary>
        /// <param name="settingsToRemove"></param>
        /// <returns>True a corresponding update was found and removed. False if there was nothing to remove.</returns>
        public bool RemovePendingUpdates(List<WindowsUiElements> settingsToRemove)
        {
            List<SettingUpdateAction> updatesToRemove = SearchPendingUpdates(settingsToRemove);
            if (!updatesToRemove.Any())
            {
                return false;
            }

            foreach (var update in updatesToRemove)
            {
                SettingUpdatesPending.Remove(update);
            }

            RefreshSettingsFromRegistry(settingsToRemove);

            return true;
        }

        public bool PendingUpdateForSettingExists(WindowsUiElements settingToFind)
        {
            return SettingUpdatesPending.Any(sua => sua.Setting == settingToFind);
        }

        public SettingUpdateAction SearchPendingUpdates(WindowsUiElements settingToFind)
        {
            return SearchPendingUpdates(new List<WindowsUiElements>() { settingToFind }).FirstOrDefault();
        }

        public List<SettingUpdateAction> SearchPendingUpdates(List<WindowsUiElements> settingsToFind)
        {
            return SettingUpdatesPending.Where(sua => settingsToFind.Contains(sua.Setting)).ToList();
        }

        public void RefreshSettingFromRegistry(WindowsUiElements settingToRefresh)
        {
            RefreshSettingsFromRegistry(new List<WindowsUiElements>() { settingToRefresh });
        }

        public void RefreshSettingsFromRegistry(List<WindowsUiElements> settingsToRefresh)
        {
            // Update control colors from registry
            foreach (var item in settingsToRefresh)
            {
                if (Types.Helpers.SystemFonts.Contains(item))
                {
                    Font font = RegistryHelper.GetWindowsFont(item);
                    UpdateControlFont(item, font, true);
                }
                else
                {
                    Color itemColor = RegistryHelper.GetWindowsColor(item);
                    UpdateControlColor(item, itemColor, true);
                }
            }
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

        private object GetCurrentSystemSettingValue(WindowsUiElements setting)
        {
            if (Types.Helpers.SystemFonts.Contains(setting))
            {
                Font font = RegistryHelper.GetWindowsFont(setting);
                return font;
            }
            else
            {
                Color color = RegistryHelper.GetWindowsColor(setting);
                return color;
            }
        }

        public void UpdateControlFont(WindowsUiElements fontGroup, Font font)
        {
            UpdateControlFont(fontGroup, font, false);
        }

        private void UpdateControlFont(WindowsUiElements fontGroup, Font font, bool isInitializing)
        {
            if (!isInitializing)
            {
                RemovePendingUpdate(fontGroup);

                Font currentValue = (Font)GetCurrentSystemSettingValue(fontGroup);
                if (!currentValue.Equals(font))
                {
                    SettingUpdateAction updateAction = new SettingUpdateAction(fontGroup, font);
                    SettingUpdatesPending.Add(updateAction);
                }
            }

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
            UpdateControlColor(uiElement, color, false);
        }

        private void UpdateControlColor(WindowsUiElements uiElement, Color color, bool isInitializing)
        {
            if (!isInitializing)
            {
                RemovePendingUpdate(uiElement);

                Color currentValue = (Color)GetCurrentSystemSettingValue(uiElement);
                if (!currentValue.Equals(color))
                {
                    SettingUpdateAction updateAction = new SettingUpdateAction(uiElement, color);
                    SettingUpdatesPending.Add(updateAction);
                }
            }

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

        private void QueuePendingUpdate(SettingUpdateAction updateAction)
        {
            // Remove previous set value for this setting, if it exists
            RemovePendingUpdate(updateAction.Setting);

            // Add change as pending
            SettingUpdatesPending.Add(updateAction);
        }

        public void AcceptChanges()
        {
            List<SettingUpdateAction> successfullyApplied = new List<SettingUpdateAction>();

            string themeFile = ThemeHelper.CreateThemeFile(this);            

            // Apply settings, keeping track of which return success
            foreach (var updateAction in SettingUpdatesPending)
            {
                if (updateAction.ApplyAction())
                {
                    successfullyApplied.Add(updateAction);
                }
            }

            ThemeHelper.InstallThemeFile(themeFile);

            // Remove successfully applied
            SettingUpdatesPending = SettingUpdatesPending.Except(successfullyApplied, new SettingOnlyComparer()).ToList();
        }

        public void AbortChanges()
        {
            var settingsToRemove = SettingUpdatesPending.Select(sua => sua.Setting).ToList();
            RemovePendingUpdates(settingsToRemove);
        }

        public void LoadSizes()
        {
            int borderWidth = RegistryHelper.GetWindowMetric("BorderWidth");
            int paddedBorderWidth = RegistryHelper.GetWindowMetric("PaddedBorderWidth");
            int padding = 2*borderWidth;
            int fullPadding = 2*paddedBorderWidth;

            int captionWidth = RegistryHelper.GetWindowMetric("CaptionWidth");
            int captionHeight = RegistryHelper.GetWindowMetric("CaptionHeight");

            SetTitlebarHeight(captionHeight + fullPadding);

            SetTitlebarButtonSize(new Size(captionWidth + padding, captionHeight + padding));

            int menuWidth = RegistryHelper.GetWindowMetric("MenuWidth");
            int menuHeight = RegistryHelper.GetWindowMetric("MenuHeight");
            SetMenuSize(new Size(menuWidth + fullPadding, menuHeight + fullPadding));

            SetBorderSize(borderWidth);
        }

        public void SetBorderSize(int size)
        {
            int activeWidth = panelActiveWindow.Width - (size*2);
            int inactiveWidth = panelInactiveWindow.Width - (size*2);

            Padding middlePadding = new Padding(size, 0, size, 0);
            Padding topPadding = new Padding(size, size, size, 0);
            Padding bottomPadding = new Padding(size, 0, size, size);

            titleBar_ActiveWindow.Width = activeWidth;
            menuBar.Width = activeWidth;
            textbox_ActiveWindow.Width = activeWidth;

            titleBar_ActiveWindow.Margin = topPadding;
            menuBar.Margin = middlePadding;
            textbox_ActiveWindow.Margin = bottomPadding;

            int menuTop = titleBar_ActiveWindow.Height + size;
            int textboxTop = menuTop + menuBar.Height;

            int activeHeight = panelActiveWindow.Height - textboxTop - size;

            textbox_ActiveWindow.Height = activeHeight;

            //titleBar_ActiveWindow.Location = new Point(size, size);
            //menuBar.Location = new Point(size, menuTop);
            //textbox_ActiveWindow.Location = new Point(size, textboxTop);

            Point titleLoc =     titleBar_ActiveWindow.Location;
            Point menuLoc = menuBar.Location;
            Point tbLoc = textbox_ActiveWindow.Location;


            titleBar_MessageBox.Width = window_MessageBox.Width - (size * 2);
            titleBar_MessageBox.Location = new Point(size, size);

            titleBar_InactiveWindow.Width = inactiveWidth;
            titleBar_InactiveWindow.Location = new Point(size, size);

            int scrollLeft = panelActiveWindow.Width - ScrollBarActiveWindow.Width - size;

            // scrollbarClickInterceptor
        }

        public void SetMenuSize(Size size)
        {
            menuBar.Height = size.Height;
        }

        public void SetTitlebarHeight(int height)
        {
            titleBar_ActiveWindow.Height = height;
            titleBar_InactiveWindow.Height = height;
        }

        public void SetTitlebarButtonSize(Size size)
        {
            buttonMinimize_ActiveWindow.Size = size;
            buttonMaximize_ActiveWindow.Size = size;
            buttonX_ActiveWindow.Size = size;

            buttonMinimize_InactiveWindow.Size = size;
            buttonMaximize_InactiveWindow.Size = size;
            buttonX_InactiveWindow.Size = size;

            buttonX_MessageBox.Size = size;
            buttonX_MessageBox.BringToFront();
        }
    }
}
