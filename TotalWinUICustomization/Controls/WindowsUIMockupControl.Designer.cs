using System.Windows.Forms;
using System.Windows.Forms.Layout;
using TotalWinUICustomization.Controls;
using OverlayControlsLibrary;
using System.Drawing;

namespace TotalWinUICustomization
{
    partial class WindowsUIMockupControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                //cp.Style |= (int)WindowStyles.WS_THICKFRAME;
                //cp.Style |= (int)WindowStyles.WS_CHILD;
                cp.ExStyle |= (int)WindowStyles.WS_EX_NOACTIVATE;
                cp.ExStyle |= (int)WindowStyles.WS_EX_TRANSPARENT;
                // cp.ExStyle |=  (int)WindowStyles.WS_EX_TOOLWINDOW;
                // rcpet.ExStyle |= (int)WindowStyles.WS_EX_TOPMOST;
                return cp;
            }
        }

        protected override bool ShowFocusCues => false;
        public override bool Focused => false;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.window_MessageBox = new System.Windows.Forms.Panel();
            this.button_MessageBox = new System.Windows.Forms.Label();
            this.toolTip_InfoWindow = new System.Windows.Forms.Label();
            this.hyperlinkText = new System.Windows.Forms.LinkLabel();
            this.font_MessageBox = new System.Windows.Forms.Label();
            this.titleBar_MessageBox = new System.Windows.Forms.Panel();
            this.font_MessageBoxTitleBar = new System.Windows.Forms.Label();
            this.buttonX_MessageBox = new System.Windows.Forms.Label();
            this.panelActiveWindow = new System.Windows.Forms.Panel();
            this.flowLayoutPanelActiveWindow = new System.Windows.Forms.FlowLayoutPanel();
            this.titleBar_ActiveWindow = new System.Windows.Forms.Panel();
            this.buttonMinimize_ActiveWindow = new System.Windows.Forms.Label();
            this.buttonMaximize_ActiveWindow = new System.Windows.Forms.Label();
            this.font_ActiveWindowTitleBar = new System.Windows.Forms.Label();
            this.buttonX_ActiveWindow = new System.Windows.Forms.Label();
            this.menuBar = new System.Windows.Forms.Panel();
            this.font_menuNormal = new System.Windows.Forms.Label();
            this.font_menuDisabled = new OverlayControlsLibrary.DisabledStyleLabel();
            this.font_menuSelected = new System.Windows.Forms.Label();
            this.textbox_ActiveWindow = new System.Windows.Forms.Panel();
            this.scrollbarClickInterceptor = new OverlayControlsLibrary.ClickInterceptorBox();
            this.font_ActiveWindow = new System.Windows.Forms.Label();
            this.selectedText = new System.Windows.Forms.Label();
            this.ScrollBarActiveWindow = new System.Windows.Forms.VScrollBar();
            this.panelInactiveWindow = new System.Windows.Forms.Panel();
            this.titleBar_InactiveWindow = new System.Windows.Forms.Panel();
            this.buttonMinimize_InactiveWindow = new System.Windows.Forms.Label();
            this.buttonMaximize_InactiveWindow = new System.Windows.Forms.Label();
            this.buttonX_InactiveWindow = new System.Windows.Forms.Label();
            this.font_InactiveWindowTitleBar = new System.Windows.Forms.Label();
            this.border1 = new OverlayControlsLibrary.Border();
            this.desktopWindow = new System.Windows.Forms.Panel();
            this.iconClickInterceptor = new OverlayControlsLibrary.ClickInterceptorBox();
            this.border2 = new OverlayControlsLibrary.Border();
            this.IconText = new System.Windows.Forms.Label();
            this.pictureBoxDesktopIcon = new System.Windows.Forms.PictureBox();
            this.inactiveBorderClickInterceptor1 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.inactiveBorderClickInterceptor3 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.inactiveBorderClickInterceptor2 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.activeBorderClickInterceptor5 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.activeBorderClickInterceptor6 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.activeBorderClickInterceptor7 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.activeBorderClickInterceptor8 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.activeBorderClickInterceptor9 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.activeBorderClickInterceptor0 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.activeBorderClickInterceptor3 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.activeBorderClickInterceptor4 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.activeBorderClickInterceptor2 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.activeBorderClickInterceptor1 = new OverlayControlsLibrary.ClickInterceptorBox();
            this.window_MessageBox.SuspendLayout();
            this.titleBar_MessageBox.SuspendLayout();
            this.panelActiveWindow.SuspendLayout();
            this.flowLayoutPanelActiveWindow.SuspendLayout();
            this.titleBar_ActiveWindow.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.textbox_ActiveWindow.SuspendLayout();
            this.panelInactiveWindow.SuspendLayout();
            this.titleBar_InactiveWindow.SuspendLayout();
            this.desktopWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesktopIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // window_MessageBox
            // 
            this.window_MessageBox.BackColor = System.Drawing.SystemColors.Control;
            this.window_MessageBox.Controls.Add(this.button_MessageBox);
            this.window_MessageBox.Controls.Add(this.toolTip_InfoWindow);
            this.window_MessageBox.Controls.Add(this.hyperlinkText);
            this.window_MessageBox.Controls.Add(this.font_MessageBox);
            this.window_MessageBox.Controls.Add(this.titleBar_MessageBox);
            this.window_MessageBox.Location = new System.Drawing.Point(52, 198);
            this.window_MessageBox.Margin = new System.Windows.Forms.Padding(0);
            this.window_MessageBox.Name = "window_MessageBox";
            this.window_MessageBox.Size = new System.Drawing.Size(390, 117);
            this.window_MessageBox.TabIndex = 11;
            this.window_MessageBox.Click += this.window_MessageBox_Click;
            // 
            // button_MessageBox
            // 
            this.button_MessageBox.Location = new System.Drawing.Point(148, 76);
            this.button_MessageBox.Name = "button_MessageBox";
            this.button_MessageBox.Size = new System.Drawing.Size(94, 29);
            this.button_MessageBox.TabIndex = 13;
            this.button_MessageBox.Text = "OK";
            this.button_MessageBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_MessageBox.Click += this.window_MessageBox_Click;
            // 
            // toolTip_InfoWindow
            // 
            this.toolTip_InfoWindow.AutoSize = true;
            this.toolTip_InfoWindow.BackColor = System.Drawing.SystemColors.Info;
            this.toolTip_InfoWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolTip_InfoWindow.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolTip_InfoWindow.Location = new System.Drawing.Point(71, 81);
            this.toolTip_InfoWindow.Margin = new System.Windows.Forms.Padding(0);
            this.toolTip_InfoWindow.Name = "toolTip_InfoWindow";
            this.toolTip_InfoWindow.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolTip_InfoWindow.Size = new System.Drawing.Size(41, 17);
            this.toolTip_InfoWindow.TabIndex = 11;
            this.toolTip_InfoWindow.Text = "Tooltip";
            this.toolTip_InfoWindow.Click += this.InfoWindowAndText_Click;
            // 
            // hyperlinkText
            // 
            this.hyperlinkText.AutoSize = true;
            this.hyperlinkText.BackColor = System.Drawing.Color.Transparent;
            this.hyperlinkText.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.hyperlinkText.Location = new System.Drawing.Point(6, 65);
            this.hyperlinkText.Name = "hyperlinkText";
            this.hyperlinkText.Size = new System.Drawing.Size(51, 13);
            this.hyperlinkText.TabIndex = 10;
            this.hyperlinkText.TabStop = true;
            this.hyperlinkText.Text = "Hyperlink";
            this.hyperlinkText.Click += this.font_hyperlinkText_Click;
            // 
            // font_MessageBox
            // 
            this.font_MessageBox.AutoSize = true;
            this.font_MessageBox.BackColor = System.Drawing.Color.Transparent;
            this.font_MessageBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.font_MessageBox.Location = new System.Drawing.Point(6, 40);
            this.font_MessageBox.Name = "font_MessageBox";
            this.font_MessageBox.Size = new System.Drawing.Size(83, 15);
            this.font_MessageBox.TabIndex = 1;
            this.font_MessageBox.Text = "Message Text";
            this.font_MessageBox.Click += this.window_MessageBox_Click;
            // 
            // titleBar_MessageBox
            // 
            this.titleBar_MessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar_MessageBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleBar_MessageBox.Controls.Add(this.font_MessageBoxTitleBar);
            this.titleBar_MessageBox.Controls.Add(this.buttonX_MessageBox);
            this.titleBar_MessageBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleBar_MessageBox.Location = new System.Drawing.Point(2, 2);
            this.titleBar_MessageBox.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar_MessageBox.Name = "titleBar_MessageBox";
            this.titleBar_MessageBox.Size = new System.Drawing.Size(386, 30);
            this.titleBar_MessageBox.Click += this.ActiveTitleBar_Click;
            // 
            // font_MessageBoxTitleBar
            // 
            this.font_MessageBoxTitleBar.AutoSize = true;
            this.font_MessageBoxTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.font_MessageBoxTitleBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.font_MessageBoxTitleBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.font_MessageBoxTitleBar.Location = new System.Drawing.Point(2, 5);
            this.font_MessageBoxTitleBar.Name = "font_MessageBoxTitleBar";
            this.font_MessageBoxTitleBar.Size = new System.Drawing.Size(80, 15);
            this.font_MessageBoxTitleBar.TabIndex = 2;
            this.font_MessageBoxTitleBar.Text = "Message Box";
            this.font_MessageBoxTitleBar.Click += this.ActiveTitleBar_Click;
            // 
            // buttonX_MessageBox
            // 
            this.buttonX_MessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX_MessageBox.BackColor = System.Drawing.SystemColors.Control;
            this.buttonX_MessageBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX_MessageBox.Location = new System.Drawing.Point(357, 2);
            this.buttonX_MessageBox.Name = "buttonX_MessageBox";
            this.buttonX_MessageBox.Size = new System.Drawing.Size(25, 25);
            this.buttonX_MessageBox.TabIndex = 9;
            this.buttonX_MessageBox.Text = "✕";
            this.buttonX_MessageBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonX_MessageBox.Click += this.controlBox_MessageBox_Click;
            // 
            // panelActiveWindow
            // 
            this.panelActiveWindow.BackColor = System.Drawing.SystemColors.Control;
            this.panelActiveWindow.Controls.Add(this.flowLayoutPanelActiveWindow);
            this.panelActiveWindow.Location = new System.Drawing.Point(29, 61);
            this.panelActiveWindow.Margin = new System.Windows.Forms.Padding(5);
            this.panelActiveWindow.Name = "panelActiveWindow";
            this.panelActiveWindow.Size = new System.Drawing.Size(512, 200);
            this.panelActiveWindow.TabIndex = 10;
            // 
            // flowLayoutPanelActiveWindow
            // 
            this.flowLayoutPanelActiveWindow.Controls.Add(this.titleBar_ActiveWindow);
            this.flowLayoutPanelActiveWindow.Controls.Add(this.menuBar);
            this.flowLayoutPanelActiveWindow.Controls.Add(this.textbox_ActiveWindow);
            this.flowLayoutPanelActiveWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelActiveWindow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelActiveWindow.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelActiveWindow.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelActiveWindow.Name = "flowLayoutPanelActiveWindow";
            this.flowLayoutPanelActiveWindow.Size = new System.Drawing.Size(512, 200);
            this.flowLayoutPanelActiveWindow.TabIndex = 12;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Menu;
            this.menuBar.Controls.Add(this.font_menuNormal);
            this.menuBar.Controls.Add(this.font_menuDisabled);
            this.menuBar.Controls.Add(this.font_menuSelected);
            this.menuBar.Location = new System.Drawing.Point(0, 30);
            this.menuBar.Margin = new System.Windows.Forms.Padding(0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(512, 26);
            this.menuBar.TabIndex = 11;
            this.menuBar.Click += this.menuBar_Click;
            // 
            // font_menuNormal
            // 
            this.font_menuNormal.AutoSize = true;
            this.font_menuNormal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.font_menuNormal.Location = new System.Drawing.Point(5, 5);
            this.font_menuNormal.Name = "font_menuNormal";
            this.font_menuNormal.Size = new System.Drawing.Size(40, 13);
            this.font_menuNormal.TabIndex = 1;
            this.font_menuNormal.Text = "Normal";
            this.font_menuNormal.Click += this.font_menuNormal_Click;
            // 
            // font_menuDisabled
            // 
            this.font_menuDisabled.AccessibleName = "";
            this.font_menuDisabled.AutoSize = true;
            this.font_menuDisabled.Location = new System.Drawing.Point(68, 5);
            this.font_menuDisabled.Name = "font_menuDisabled";
            this.font_menuDisabled.Size = new System.Drawing.Size(48, 13);
            this.font_menuDisabled.TabIndex = 2;
            this.font_menuDisabled.Text = "Disabled";
            this.font_menuDisabled.Click += this.font_menuDisabled_Click;
            // 
            // font_menuSelected
            // 
            this.font_menuSelected.AutoSize = true;
            this.font_menuSelected.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.font_menuSelected.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.font_menuSelected.Location = new System.Drawing.Point(144, 5);
            this.font_menuSelected.Name = "font_menuSelected";
            this.font_menuSelected.Size = new System.Drawing.Size(49, 13);
            this.font_menuSelected.TabIndex = 3;
            this.font_menuSelected.Text = "Selected";
            this.font_menuSelected.Click += this.font_menuSelected_Click;
            // 
            // textbox_ActiveWindow
            // 
            this.textbox_ActiveWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_ActiveWindow.BackColor = System.Drawing.SystemColors.Control;
            this.textbox_ActiveWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textbox_ActiveWindow.Controls.Add(this.scrollbarClickInterceptor);
            this.textbox_ActiveWindow.Controls.Add(this.font_ActiveWindow);
            this.textbox_ActiveWindow.Controls.Add(this.selectedText);
            this.textbox_ActiveWindow.Controls.Add(this.ScrollBarActiveWindow);
            this.textbox_ActiveWindow.Location = new System.Drawing.Point(0, 56);
            this.textbox_ActiveWindow.Margin = new System.Windows.Forms.Padding(0);
            this.textbox_ActiveWindow.Name = "textbox_ActiveWindow";
            this.textbox_ActiveWindow.Size = new System.Drawing.Size(512, 137);
            this.textbox_ActiveWindow.Click += this.textbox_ActiveWindow_Click;
            // 
            // scrollbarClickInterceptor
            // 
            this.scrollbarClickInterceptor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollbarClickInterceptor.CausesValidation = false;
            this.scrollbarClickInterceptor.Location = new System.Drawing.Point(486, 0);
            this.scrollbarClickInterceptor.Name = "scrollbarClickInterceptor";
            this.scrollbarClickInterceptor.Size = new System.Drawing.Size(28, 130);
            this.scrollbarClickInterceptor.TabIndex = 10;
            this.scrollbarClickInterceptor.TabStop = false;
            this.scrollbarClickInterceptor.Click += this.ScrollBar_Clicked;
            // 
            // font_ActiveWindow
            // 
            this.font_ActiveWindow.AutoSize = true;
            this.font_ActiveWindow.BackColor = System.Drawing.Color.Transparent;
            this.font_ActiveWindow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.font_ActiveWindow.Location = new System.Drawing.Point(4, 5);
            this.font_ActiveWindow.Name = "font_ActiveWindow";
            this.font_ActiveWindow.Size = new System.Drawing.Size(75, 15);
            this.font_ActiveWindow.TabIndex = 9;
            this.font_ActiveWindow.Text = "Window Text";
            this.font_ActiveWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.font_ActiveWindow.Click += this.font_ActiveWindow_Click;
            // 
            // selectedText
            // 
            this.selectedText.AutoSize = true;
            this.selectedText.BackColor = System.Drawing.SystemColors.Highlight;
            this.selectedText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.selectedText.Location = new System.Drawing.Point(4, 27);
            this.selectedText.Margin = new System.Windows.Forms.Padding(3);
            this.selectedText.Name = "selectedText";
            this.selectedText.Size = new System.Drawing.Size(73, 13);
            this.selectedText.TabIndex = 1;
            this.selectedText.Text = "Selected Text";
            this.selectedText.Click += this.selectedText_Click;
            // 
            // ScrollBarActiveWindow
            // 
            this.ScrollBarActiveWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarActiveWindow.LargeChange = 0;
            this.ScrollBarActiveWindow.Location = new System.Drawing.Point(482, 0);
            this.ScrollBarActiveWindow.Maximum = 20;
            this.ScrollBarActiveWindow.Name = "ScrollBarActiveWindow";
            this.ScrollBarActiveWindow.Size = new System.Drawing.Size(26, 132);
            this.ScrollBarActiveWindow.SmallChange = 0;
            this.ScrollBarActiveWindow.TabIndex = 0;
            this.ScrollBarActiveWindow.Scroll += this.ScrollBar_Clicked;
            this.ScrollBarActiveWindow.ValueChanged += this.ScrollBar_Clicked;
            // 
            // titleBar_ActiveWindow
            // 
            this.titleBar_ActiveWindow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleBar_ActiveWindow.Controls.Add(this.buttonMinimize_ActiveWindow);
            this.titleBar_ActiveWindow.Controls.Add(this.buttonMaximize_ActiveWindow);
            this.titleBar_ActiveWindow.Controls.Add(this.font_ActiveWindowTitleBar);
            this.titleBar_ActiveWindow.Controls.Add(this.buttonX_ActiveWindow);
            this.titleBar_ActiveWindow.Location = new System.Drawing.Point(0, 0);
            this.titleBar_ActiveWindow.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar_ActiveWindow.Name = "titleBar_ActiveWindow";
            this.titleBar_ActiveWindow.Size = new System.Drawing.Size(512, 30);
            this.titleBar_ActiveWindow.TabIndex = 8;
            this.titleBar_ActiveWindow.Click += this.ActiveTitleBar_Click;
            // 
            // buttonMinimize_ActiveWindow
            // 
            this.buttonMinimize_ActiveWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize_ActiveWindow.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMinimize_ActiveWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize_ActiveWindow.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMinimize_ActiveWindow.Location = new System.Drawing.Point(425, 2);
            this.buttonMinimize_ActiveWindow.Name = "buttonMinimize_ActiveWindow";
            this.buttonMinimize_ActiveWindow.Size = new System.Drawing.Size(25, 25);
            this.buttonMinimize_ActiveWindow.TabIndex = 12;
            this.buttonMinimize_ActiveWindow.Text = "0";
            this.buttonMinimize_ActiveWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMinimize_ActiveWindow.Click += this.controlBox_ActiveWindow_Click;
            // 
            // buttonMaximize_ActiveWindow
            // 
            this.buttonMaximize_ActiveWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize_ActiveWindow.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMaximize_ActiveWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize_ActiveWindow.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMaximize_ActiveWindow.Location = new System.Drawing.Point(453, 2);
            this.buttonMaximize_ActiveWindow.Name = "buttonMaximize_ActiveWindow";
            this.buttonMaximize_ActiveWindow.Size = new System.Drawing.Size(25, 25);
            this.buttonMaximize_ActiveWindow.TabIndex = 11;
            this.buttonMaximize_ActiveWindow.Text = "1";
            this.buttonMaximize_ActiveWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMaximize_ActiveWindow.Click += this.controlBox_ActiveWindow_Click;
            // 
            // font_ActiveWindowTitleBar
            // 
            this.font_ActiveWindowTitleBar.AutoSize = true;
            this.font_ActiveWindowTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.font_ActiveWindowTitleBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.font_ActiveWindowTitleBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.font_ActiveWindowTitleBar.Location = new System.Drawing.Point(2, 5);
            this.font_ActiveWindowTitleBar.Name = "font_ActiveWindowTitleBar";
            this.font_ActiveWindowTitleBar.Size = new System.Drawing.Size(92, 15);
            this.font_ActiveWindowTitleBar.TabIndex = 2;
            this.font_ActiveWindowTitleBar.Text = "Active Window";
            this.font_ActiveWindowTitleBar.Click += this.ActiveTitleBar_Click;
            // 
            // buttonX_ActiveWindow
            // 
            this.buttonX_ActiveWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX_ActiveWindow.BackColor = System.Drawing.SystemColors.Control;
            this.buttonX_ActiveWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX_ActiveWindow.Location = new System.Drawing.Point(482, 2);
            this.buttonX_ActiveWindow.Name = "buttonX_ActiveWindow";
            this.buttonX_ActiveWindow.Size = new System.Drawing.Size(25, 25);
            this.buttonX_ActiveWindow.TabIndex = 10;
            this.buttonX_ActiveWindow.Text = "✕";
            this.buttonX_ActiveWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonX_ActiveWindow.Click += this.controlBox_ActiveWindow_Click;
            // 
            // panelInactiveWindow
            // 
            this.panelInactiveWindow.BackColor = System.Drawing.SystemColors.Control;
            this.panelInactiveWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInactiveWindow.Controls.Add(this.titleBar_InactiveWindow);
            this.panelInactiveWindow.Location = new System.Drawing.Point(25, 25);
            this.panelInactiveWindow.Margin = new System.Windows.Forms.Padding(0);
            this.panelInactiveWindow.Name = "panelInactiveWindow";
            this.panelInactiveWindow.Size = new System.Drawing.Size(480, 200);
            this.panelInactiveWindow.TabIndex = 13;
            // 
            // titleBar_InactiveWindow
            // 
            this.titleBar_InactiveWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar_InactiveWindow.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.titleBar_InactiveWindow.Controls.Add(this.buttonMinimize_InactiveWindow);
            this.titleBar_InactiveWindow.Controls.Add(this.buttonMaximize_InactiveWindow);
            this.titleBar_InactiveWindow.Controls.Add(this.buttonX_InactiveWindow);
            this.titleBar_InactiveWindow.Controls.Add(this.font_InactiveWindowTitleBar);
            this.titleBar_InactiveWindow.Location = new System.Drawing.Point(2, 2);
            this.titleBar_InactiveWindow.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar_InactiveWindow.Name = "titleBar_InactiveWindow";
            this.titleBar_InactiveWindow.Size = new System.Drawing.Size(474, 30);
            this.titleBar_InactiveWindow.Click += this.InactiveTitleBar_Click;
            // 
            // buttonMinimize_InactiveWindow
            // 
            this.buttonMinimize_InactiveWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize_InactiveWindow.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMinimize_InactiveWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize_InactiveWindow.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMinimize_InactiveWindow.Location = new System.Drawing.Point(388, 2);
            this.buttonMinimize_InactiveWindow.Name = "buttonMinimize_InactiveWindow";
            this.buttonMinimize_InactiveWindow.Size = new System.Drawing.Size(25, 25);
            this.buttonMinimize_InactiveWindow.TabIndex = 15;
            this.buttonMinimize_InactiveWindow.Text = "0";
            this.buttonMinimize_InactiveWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMinimize_InactiveWindow.Click += this.controlBox_InactiveWindow_Click;
            // 
            // buttonMaximize_InactiveWindow
            // 
            this.buttonMaximize_InactiveWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize_InactiveWindow.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMaximize_InactiveWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize_InactiveWindow.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMaximize_InactiveWindow.Location = new System.Drawing.Point(417, 2);
            this.buttonMaximize_InactiveWindow.Name = "buttonMaximize_InactiveWindow";
            this.buttonMaximize_InactiveWindow.Size = new System.Drawing.Size(25, 25);
            this.buttonMaximize_InactiveWindow.TabIndex = 14;
            this.buttonMaximize_InactiveWindow.Text = "1";
            this.buttonMaximize_InactiveWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMaximize_InactiveWindow.Click += this.controlBox_InactiveWindow_Click;
            // 
            // buttonX_InactiveWindow
            // 
            this.buttonX_InactiveWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX_InactiveWindow.BackColor = System.Drawing.SystemColors.Control;
            this.buttonX_InactiveWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX_InactiveWindow.Location = new System.Drawing.Point(446, 2);
            this.buttonX_InactiveWindow.Name = "buttonX_InactiveWindow";
            this.buttonX_InactiveWindow.Size = new System.Drawing.Size(25, 25);
            this.buttonX_InactiveWindow.TabIndex = 13;
            this.buttonX_InactiveWindow.Text = "✕";
            this.buttonX_InactiveWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonX_InactiveWindow.Click += this.controlBox_InactiveWindow_Click;
            // 
            // font_InactiveWindowTitleBar
            // 
            this.font_InactiveWindowTitleBar.AutoSize = true;
            this.font_InactiveWindowTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.font_InactiveWindowTitleBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.font_InactiveWindowTitleBar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.font_InactiveWindowTitleBar.Location = new System.Drawing.Point(2, 5);
            this.font_InactiveWindowTitleBar.Name = "font_InactiveWindowTitleBar";
            this.font_InactiveWindowTitleBar.Size = new System.Drawing.Size(101, 15);
            this.font_InactiveWindowTitleBar.TabIndex = 2;
            this.font_InactiveWindowTitleBar.Text = "Inactive Window";
            this.font_InactiveWindowTitleBar.Click += this.InactiveTitleBar_Click;
            // 
            // border1
            // 
            this.border1.BackColor = System.Drawing.Color.Transparent;
            this.border1.BorderStyle = OverlayControlsLibrary.BorderControlType.FocusRectangle;
            this.border1.CausesValidation = false;
            this.border1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.border1.Location = new System.Drawing.Point(482, 328);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(62, 19);
            this.border1.TabIndex = 2;
            this.border1.TabStop = false;
            // 
            // desktopWindow
            // 
            this.desktopWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desktopWindow.BackColor = System.Drawing.SystemColors.Desktop;
            this.desktopWindow.Controls.Add(this.iconClickInterceptor);
            this.desktopWindow.Controls.Add(this.border2);
            this.desktopWindow.Controls.Add(this.IconText);
            this.desktopWindow.Controls.Add(this.pictureBoxDesktopIcon);
            this.desktopWindow.Controls.Add(this.border1);
            this.desktopWindow.Location = new System.Drawing.Point(0, 0);
            this.desktopWindow.Margin = new System.Windows.Forms.Padding(0);
            this.desktopWindow.Name = "desktopWindow";
            this.desktopWindow.Size = new System.Drawing.Size(570, 370);
            this.desktopWindow.TabIndex = 14;
            this.desktopWindow.Click += this.window_Desktop_Click;
            // 
            // iconClickInterceptor
            // 
            this.iconClickInterceptor.CausesValidation = false;
            this.iconClickInterceptor.Location = new System.Drawing.Point(478, 274);
            this.iconClickInterceptor.Name = "iconClickInterceptor";
            this.iconClickInterceptor.Size = new System.Drawing.Size(68, 73);
            this.iconClickInterceptor.TabIndex = 4;
            this.iconClickInterceptor.TabStop = false;
            this.iconClickInterceptor.Click += this.iconClickInterceptor_Click;
            // 
            // border2
            // 
            this.border2.BackColor = System.Drawing.Color.Transparent;
            this.border2.BorderStyle = OverlayControlsLibrary.BorderControlType.FocusRectangle;
            this.border2.CausesValidation = false;
            this.border2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.border2.Location = new System.Drawing.Point(484, 278);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(51, 49);
            this.border2.TabIndex = 3;
            this.border2.TabStop = false;
            // 
            // IconText
            // 
            this.IconText.AutoSize = true;
            this.IconText.BackColor = System.Drawing.SystemColors.Highlight;
            this.IconText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.IconText.Location = new System.Drawing.Point(485, 330);
            this.IconText.Name = "IconText";
            this.IconText.Size = new System.Drawing.Size(52, 13);
            this.IconText.TabIndex = 1;
            this.IconText.Text = "Icon Text";
            this.IconText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxDesktopIcon
            // 
            this.pictureBoxDesktopIcon.Image = global::TotalWinUICustomization.Properties.Resources.file;
            this.pictureBoxDesktopIcon.Location = new System.Drawing.Point(486, 279);
            this.pictureBoxDesktopIcon.Name = "pictureBoxDesktopIcon";
            this.pictureBoxDesktopIcon.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxDesktopIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDesktopIcon.TabIndex = 0;
            this.pictureBoxDesktopIcon.TabStop = false;
            // 
            // inactiveBorderClickInterceptor1
            // 
            this.inactiveBorderClickInterceptor1.CausesValidation = false;
            this.inactiveBorderClickInterceptor1.Location = new System.Drawing.Point(25, 23);
            this.inactiveBorderClickInterceptor1.Name = "inactiveBorderClickInterceptor1";
            this.inactiveBorderClickInterceptor1.Size = new System.Drawing.Size(481, 5);
            this.inactiveBorderClickInterceptor1.TabIndex = 7;
            this.inactiveBorderClickInterceptor1.TabStop = false;
            this.inactiveBorderClickInterceptor1.Click += this.inactiveBorderClickInterceptor_Click;
            // 
            // inactiveBorderClickInterceptor3
            // 
            this.inactiveBorderClickInterceptor3.CausesValidation = false;
            this.inactiveBorderClickInterceptor3.Location = new System.Drawing.Point(25, 24);
            this.inactiveBorderClickInterceptor3.Name = "inactiveBorderClickInterceptor3";
            this.inactiveBorderClickInterceptor3.Size = new System.Drawing.Size(4, 202);
            this.inactiveBorderClickInterceptor3.TabIndex = 12;
            this.inactiveBorderClickInterceptor3.TabStop = false;
            this.inactiveBorderClickInterceptor3.Click += this.inactiveBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor5
            // 
            this.activeBorderClickInterceptor5.CausesValidation = false;
            this.activeBorderClickInterceptor5.Location = new System.Drawing.Point(538, 62);
            this.activeBorderClickInterceptor5.Name = "activeBorderClickInterceptor5";
            this.activeBorderClickInterceptor5.Size = new System.Drawing.Size(4, 199);
            this.activeBorderClickInterceptor5.TabIndex = 13;
            this.activeBorderClickInterceptor5.TabStop = false;
            this.activeBorderClickInterceptor5.Click += this.activeBorderClickInterceptor_Click;
            // 
            // inactiveBorderClickInterceptor2
            // 
            this.inactiveBorderClickInterceptor2.CausesValidation = false;
            this.inactiveBorderClickInterceptor2.Location = new System.Drawing.Point(502, 25);
            this.inactiveBorderClickInterceptor2.Name = "inactiveBorderClickInterceptor2";
            this.inactiveBorderClickInterceptor2.Size = new System.Drawing.Size(4, 34);
            this.inactiveBorderClickInterceptor2.TabIndex = 14;
            this.inactiveBorderClickInterceptor2.TabStop = false;
            this.inactiveBorderClickInterceptor2.Click += this.inactiveBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor6
            // 
            this.activeBorderClickInterceptor6.CausesValidation = false;
            this.activeBorderClickInterceptor6.Location = new System.Drawing.Point(29, 63);
            this.activeBorderClickInterceptor6.Name = "activeBorderClickInterceptor6";
            this.activeBorderClickInterceptor6.Size = new System.Drawing.Size(4, 200);
            this.activeBorderClickInterceptor6.TabIndex = 15;
            this.activeBorderClickInterceptor6.TabStop = false;
            this.activeBorderClickInterceptor6.Click += this.activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor7
            // 
            this.activeBorderClickInterceptor7.CausesValidation = false;
            this.activeBorderClickInterceptor7.Location = new System.Drawing.Point(29, 259);
            this.activeBorderClickInterceptor7.Name = "activeBorderClickInterceptor7";
            this.activeBorderClickInterceptor7.Size = new System.Drawing.Size(24, 4);
            this.activeBorderClickInterceptor7.TabIndex = 16;
            this.activeBorderClickInterceptor7.TabStop = false;
            this.activeBorderClickInterceptor7.Click += this.activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor8
            // 
            this.activeBorderClickInterceptor8.CausesValidation = false;
            this.activeBorderClickInterceptor8.Location = new System.Drawing.Point(55, 197);
            this.activeBorderClickInterceptor8.Name = "activeBorderClickInterceptor8";
            this.activeBorderClickInterceptor8.Size = new System.Drawing.Size(385, 5);
            this.activeBorderClickInterceptor8.TabIndex = 18;
            this.activeBorderClickInterceptor8.TabStop = false;
            this.activeBorderClickInterceptor8.Click += this.activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor9
            // 
            this.activeBorderClickInterceptor9.CausesValidation = false;
            this.activeBorderClickInterceptor9.Location = new System.Drawing.Point(441, 259);
            this.activeBorderClickInterceptor9.Name = "activeBorderClickInterceptor9";
            this.activeBorderClickInterceptor9.Size = new System.Drawing.Size(101, 4);
            this.activeBorderClickInterceptor9.TabIndex = 19;
            this.activeBorderClickInterceptor9.TabStop = false;
            this.activeBorderClickInterceptor9.Click += this.activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor0
            // 
            this.activeBorderClickInterceptor0.CausesValidation = false;
            this.activeBorderClickInterceptor0.Location = new System.Drawing.Point(28, 60);
            this.activeBorderClickInterceptor0.Name = "activeBorderClickInterceptor0";
            this.activeBorderClickInterceptor0.Size = new System.Drawing.Size(514, 4);
            this.activeBorderClickInterceptor0.TabIndex = 20;
            this.activeBorderClickInterceptor0.TabStop = false;
            this.activeBorderClickInterceptor0.Click += this.activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor3
            // 
            this.activeBorderClickInterceptor3.CausesValidation = false;
            this.activeBorderClickInterceptor3.Location = new System.Drawing.Point(51, 313);
            this.activeBorderClickInterceptor3.Name = "activeBorderClickInterceptor3";
            this.activeBorderClickInterceptor3.Size = new System.Drawing.Size(390, 4);
            this.activeBorderClickInterceptor3.TabIndex = 5;
            this.activeBorderClickInterceptor3.TabStop = false;
            this.activeBorderClickInterceptor3.Click += this.activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor4
            // 
            this.activeBorderClickInterceptor4.CausesValidation = false;
            this.activeBorderClickInterceptor4.Location = new System.Drawing.Point(51, 197);
            this.activeBorderClickInterceptor4.Name = "activeBorderClickInterceptor4";
            this.activeBorderClickInterceptor4.Size = new System.Drawing.Size(392, 5);
            this.activeBorderClickInterceptor4.TabIndex = 6;
            this.activeBorderClickInterceptor4.TabStop = false;
            this.activeBorderClickInterceptor4.Click += this.activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor2
            // 
            this.activeBorderClickInterceptor2.CausesValidation = false;
            this.activeBorderClickInterceptor2.Location = new System.Drawing.Point(51, 198);
            this.activeBorderClickInterceptor2.Name = "activeBorderClickInterceptor2";
            this.activeBorderClickInterceptor2.Size = new System.Drawing.Size(4, 119);
            this.activeBorderClickInterceptor2.TabIndex = 5;
            this.activeBorderClickInterceptor2.TabStop = false;
            this.activeBorderClickInterceptor2.Click += this.activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor1
            // 
            this.activeBorderClickInterceptor1.CausesValidation = false;
            this.activeBorderClickInterceptor1.Location = new System.Drawing.Point(439, 198);
            this.activeBorderClickInterceptor1.Name = "activeBorderClickInterceptor1";
            this.activeBorderClickInterceptor1.Size = new System.Drawing.Size(4, 119);
            this.activeBorderClickInterceptor1.TabIndex = 5;
            this.activeBorderClickInterceptor1.TabStop = false;
            this.activeBorderClickInterceptor1.Click += this.activeBorderClickInterceptor_Click;
            // 
            // WindowsUIMockupControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.inactiveBorderClickInterceptor3);
            this.Controls.Add(this.inactiveBorderClickInterceptor2);
            this.Controls.Add(this.inactiveBorderClickInterceptor1);
            this.Controls.Add(this.activeBorderClickInterceptor0);
            this.Controls.Add(this.activeBorderClickInterceptor9);
            this.Controls.Add(this.activeBorderClickInterceptor8);
            this.Controls.Add(this.activeBorderClickInterceptor7);
            this.Controls.Add(this.activeBorderClickInterceptor6);
            this.Controls.Add(this.activeBorderClickInterceptor5);
            this.Controls.Add(this.activeBorderClickInterceptor4);
            this.Controls.Add(this.activeBorderClickInterceptor3);
            this.Controls.Add(this.activeBorderClickInterceptor2);
            this.Controls.Add(this.activeBorderClickInterceptor1);
            this.Controls.Add(this.window_MessageBox);
            this.Controls.Add(this.panelActiveWindow);
            this.Controls.Add(this.panelInactiveWindow);
            this.Controls.Add(this.desktopWindow);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(570, 370);
            this.MinimumSize = new System.Drawing.Size(570, 370);
            this.Name = "WindowsUIMockupControl";
            this.Size = new System.Drawing.Size(570, 370);
            this.window_MessageBox.ResumeLayout(false);
            this.window_MessageBox.PerformLayout();
            this.titleBar_MessageBox.ResumeLayout(false);
            this.titleBar_MessageBox.PerformLayout();
            this.panelActiveWindow.ResumeLayout(false);
            this.flowLayoutPanelActiveWindow.ResumeLayout(false);
            this.titleBar_ActiveWindow.ResumeLayout(false);
            this.titleBar_ActiveWindow.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.textbox_ActiveWindow.ResumeLayout(false);
            this.textbox_ActiveWindow.PerformLayout();
            this.panelInactiveWindow.ResumeLayout(false);
            this.titleBar_InactiveWindow.ResumeLayout(false);
            this.titleBar_InactiveWindow.PerformLayout();
            this.desktopWindow.ResumeLayout(false);
            this.desktopWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesktopIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel window_MessageBox;
        private Label font_MessageBox;
        private Panel titleBar_MessageBox;
        private Label font_MessageBoxTitleBar;
        private Panel panelActiveWindow;
        private Panel titleBar_ActiveWindow;
        private Label font_ActiveWindowTitleBar;
        private Label font_menuSelected;
        private Label font_menuNormal;
        private Panel titleBar_InactiveWindow;
        private Label font_InactiveWindowTitleBar;
        private Panel panelInactiveWindow;
        private Panel desktopWindow;
        private Label buttonX_MessageBox;
        private Label buttonMinimize_ActiveWindow;
        private Label buttonMaximize_ActiveWindow;
        private Label buttonX_ActiveWindow;
        private Label buttonMinimize_InactiveWindow;
        private Label buttonMaximize_InactiveWindow;
        private Label buttonX_InactiveWindow;
        private Label font_ActiveWindow;
        private Panel textbox_ActiveWindow;
        private VScrollBar ScrollBarActiveWindow;
        private Panel menuBar;
        private LinkLabel hyperlinkText;
        private Label selectedText;
        private DisabledStyleLabel font_menuDisabled;
        private ClickInterceptorBox scrollbarClickInterceptor;
        private PictureBox pictureBoxDesktopIcon;
        private Label IconText;
        private Border border1;
        private Border border2;
        private ClickInterceptorBox iconClickInterceptor;
        private ClickInterceptorBox activeBorderClickInterceptor1;
        private ClickInterceptorBox activeBorderClickInterceptor2;
        private ClickInterceptorBox activeBorderClickInterceptor4;
        private ClickInterceptorBox activeBorderClickInterceptor3;
        private ClickInterceptorBox inactiveBorderClickInterceptor1;
        private ClickInterceptorBox inactiveBorderClickInterceptor2;
        private ClickInterceptorBox activeBorderClickInterceptor5;
        private ClickInterceptorBox inactiveBorderClickInterceptor3;
        private ClickInterceptorBox activeBorderClickInterceptor7;
        private ClickInterceptorBox activeBorderClickInterceptor6;
        private ClickInterceptorBox activeBorderClickInterceptor9;
        private ClickInterceptorBox activeBorderClickInterceptor8;
        private ClickInterceptorBox activeBorderClickInterceptor0;
        private Label toolTip_InfoWindow;
        private Label button_MessageBox;
        private FlowLayoutPanel flowLayoutPanelActiveWindow;
    }
}
