using System.Windows.Forms.Layout;
using TotalWinUICustomization.Controls;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsUIMockupControl));
            window_MessageBox = new Panel();
            button_MessageBox = new ButtonLikeLabel();
            InfoWindowAndText = new Label();
            hyperlinkText = new LinkLabel();
            font_MessageBox = new Label();
            titleBar_MessageBox = new Panel();
            font_MessageBoxTitleBar = new Label();
            buttonX_MessageBox = new Label();
            panelActiveWindow = new Panel();
            menu = new Panel();
            font_menuNormal = new Label();
            font_menuDisabled = new DisabledStyleLabel();
            font_menuSelected = new Label();
            textbox_ActiveWindow = new Panel();
            scrollbarClickInterceptor = new ClickInterceptorBox();
            font_ActiveWindow = new Label();
            selectedText = new Label();
            ScrollBarActiveWindow = new VScrollBar();
            titleBar_ActiveWindow = new Panel();
            buttonMinimize_ActiveWindow = new Label();
            buttonMaximize_ActiveWindow = new Label();
            font_ActiveWindowTitleBar = new Label();
            buttonX_ActiveWindow = new Label();
            panelInactiveWindow = new Panel();
            titleBar_InactiveWindow = new Panel();
            buttonMinimize_InactiveWindow = new Label();
            buttonMaximize_InactiveWindow = new Label();
            buttonX_InactiveWindow = new Label();
            font_InactiveWindowTitleBar = new Label();
            border1 = new Border();
            desktopWindow = new Panel();
            iconClickInterceptor = new ClickInterceptorBox();
            border2 = new Border();
            IconText = new Label();
            pictureBox1 = new PictureBox();
            inactiveBorderClickInterceptor1 = new ClickInterceptorBox();
            inactiveBorderClickInterceptor3 = new ClickInterceptorBox();
            activeBorderClickInterceptor5 = new ClickInterceptorBox();
            inactiveBorderClickInterceptor2 = new ClickInterceptorBox();
            activeBorderClickInterceptor6 = new ClickInterceptorBox();
            activeBorderClickInterceptor7 = new ClickInterceptorBox();
            activeBorderClickInterceptor8 = new ClickInterceptorBox();
            activeBorderClickInterceptor9 = new ClickInterceptorBox();
            activeBorderClickInterceptor0 = new ClickInterceptorBox();
            activeBorderClickInterceptor3 = new ClickInterceptorBox();
            activeBorderClickInterceptor4 = new ClickInterceptorBox();
            activeBorderClickInterceptor2 = new ClickInterceptorBox();
            activeBorderClickInterceptor1 = new ClickInterceptorBox();
            window_MessageBox.SuspendLayout();
            titleBar_MessageBox.SuspendLayout();
            panelActiveWindow.SuspendLayout();
            menu.SuspendLayout();
            textbox_ActiveWindow.SuspendLayout();
            titleBar_ActiveWindow.SuspendLayout();
            panelInactiveWindow.SuspendLayout();
            titleBar_InactiveWindow.SuspendLayout();
            desktopWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // window_MessageBox
            // 
            window_MessageBox.BackColor = SystemColors.Control;
            window_MessageBox.Controls.Add(button_MessageBox);
            window_MessageBox.Controls.Add(InfoWindowAndText);
            window_MessageBox.Controls.Add(hyperlinkText);
            window_MessageBox.Controls.Add(font_MessageBox);
            window_MessageBox.Controls.Add(titleBar_MessageBox);
            window_MessageBox.Location = new Point(52, 198);
            window_MessageBox.Margin = new Padding(0);
            window_MessageBox.Name = "window_MessageBox";
            window_MessageBox.Size = new Size(390, 117);
            window_MessageBox.TabIndex = 11;
            window_MessageBox.Click += window_MessageBox_Click;
            // 
            // button_MessageBox
            // 
            button_MessageBox.Location = new Point(148, 77);
            button_MessageBox.Name = "button_MessageBox";
            button_MessageBox.Size = new Size(94, 29);
            button_MessageBox.TabIndex = 12;
            button_MessageBox.Text = "OK";
            button_MessageBox.TextAlign = ContentAlignment.MiddleCenter;
            button_MessageBox.Click += window_MessageBox_Click;
            // 
            // InfoWindowAndText
            // 
            InfoWindowAndText.AutoSize = true;
            InfoWindowAndText.BackColor = SystemColors.Info;
            InfoWindowAndText.BorderStyle = BorderStyle.FixedSingle;
            InfoWindowAndText.ForeColor = SystemColors.InfoText;
            InfoWindowAndText.Location = new Point(71, 81);
            InfoWindowAndText.Margin = new Padding(0);
            InfoWindowAndText.Name = "InfoWindowAndText";
            InfoWindowAndText.Padding = new Padding(0, 1, 0, 1);
            InfoWindowAndText.Size = new Size(58, 24);
            InfoWindowAndText.TabIndex = 11;
            InfoWindowAndText.Text = "Tooltip";
            InfoWindowAndText.Click += InfoWindowAndText_Click;
            // 
            // hyperlinkText
            // 
            hyperlinkText.AutoSize = true;
            hyperlinkText.BackColor = Color.Transparent;
            hyperlinkText.LinkColor = SystemColors.HotTrack;
            hyperlinkText.Location = new Point(6, 65);
            hyperlinkText.Name = "hyperlinkText";
            hyperlinkText.Size = new Size(72, 20);
            hyperlinkText.TabIndex = 10;
            hyperlinkText.TabStop = true;
            hyperlinkText.Text = "Hyperlink";
            hyperlinkText.Click += font_hyperlinkText_Click;
            // 
            // font_MessageBox
            // 
            font_MessageBox.AutoSize = true;
            font_MessageBox.BackColor = Color.Transparent;
            font_MessageBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            font_MessageBox.Location = new Point(6, 40);
            font_MessageBox.Name = "font_MessageBox";
            font_MessageBox.Size = new Size(104, 20);
            font_MessageBox.TabIndex = 1;
            font_MessageBox.Text = "Message Text";
            font_MessageBox.Click += window_MessageBox_Click;
            // 
            // titleBar_MessageBox
            // 
            titleBar_MessageBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleBar_MessageBox.BackColor = SystemColors.ActiveCaption;
            titleBar_MessageBox.Controls.Add(font_MessageBoxTitleBar);
            titleBar_MessageBox.Controls.Add(buttonX_MessageBox);
            titleBar_MessageBox.ForeColor = SystemColors.ControlText;
            titleBar_MessageBox.Location = new Point(2, 2);
            titleBar_MessageBox.Margin = new Padding(0);
            titleBar_MessageBox.Name = "titleBar_MessageBox";
            titleBar_MessageBox.Size = new Size(386, 33);
            titleBar_MessageBox.TabIndex = 7;
            titleBar_MessageBox.Click += ActiveTitleBar_Click;
            // 
            // font_MessageBoxTitleBar
            // 
            font_MessageBoxTitleBar.AutoSize = true;
            font_MessageBoxTitleBar.BackColor = Color.Transparent;
            font_MessageBoxTitleBar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            font_MessageBoxTitleBar.ForeColor = SystemColors.ControlText;
            font_MessageBoxTitleBar.Location = new Point(2, 5);
            font_MessageBoxTitleBar.Name = "font_MessageBoxTitleBar";
            font_MessageBoxTitleBar.Size = new Size(101, 20);
            font_MessageBoxTitleBar.TabIndex = 2;
            font_MessageBoxTitleBar.Text = "Message Box";
            font_MessageBoxTitleBar.Click += ActiveTitleBar_Click;
            // 
            // buttonX_MessageBox
            // 
            buttonX_MessageBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonX_MessageBox.BackColor = SystemColors.Control;
            buttonX_MessageBox.BorderStyle = BorderStyle.FixedSingle;
            buttonX_MessageBox.FlatStyle = FlatStyle.Flat;
            buttonX_MessageBox.Location = new Point(354, 2);
            buttonX_MessageBox.Name = "buttonX_MessageBox";
            buttonX_MessageBox.Size = new Size(29, 29);
            buttonX_MessageBox.TabIndex = 9;
            buttonX_MessageBox.Text = "✕";
            buttonX_MessageBox.TextAlign = ContentAlignment.MiddleCenter;
            buttonX_MessageBox.Click += controlBox_MessageBox_Click;
            // 
            // panelActiveWindow
            // 
            panelActiveWindow.BackColor = SystemColors.Control;
            panelActiveWindow.Controls.Add(menu);
            panelActiveWindow.Controls.Add(textbox_ActiveWindow);
            panelActiveWindow.Controls.Add(titleBar_ActiveWindow);
            panelActiveWindow.Location = new Point(29, 61);
            panelActiveWindow.Margin = new Padding(0);
            panelActiveWindow.Name = "panelActiveWindow";
            panelActiveWindow.Size = new Size(512, 200);
            panelActiveWindow.TabIndex = 10;
            // 
            // menu
            // 
            menu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menu.BackColor = SystemColors.Menu;
            menu.Controls.Add(font_menuNormal);
            menu.Controls.Add(font_menuDisabled);
            menu.Controls.Add(font_menuSelected);
            menu.Location = new Point(0, 34);
            menu.Margin = new Padding(0);
            menu.Name = "menu";
            menu.Size = new Size(509, 30);
            menu.TabIndex = 11;
            menu.Click += menu_Click;
            // 
            // font_menuNormal
            // 
            font_menuNormal.AutoSize = true;
            font_menuNormal.ForeColor = SystemColors.MenuText;
            font_menuNormal.Location = new Point(5, 5);
            font_menuNormal.Name = "font_menuNormal";
            font_menuNormal.Size = new Size(59, 20);
            font_menuNormal.TabIndex = 1;
            font_menuNormal.Text = "Normal";
            font_menuNormal.Click += font_menuNormal_Click;
            // 
            // font_menuDisabled
            // 
            font_menuDisabled.AccessibleName = "";
            font_menuDisabled.AutoSize = true;
            font_menuDisabled.Location = new Point(68, 5);
            font_menuDisabled.Name = "font_menuDisabled";
            font_menuDisabled.Size = new Size(68, 20);
            font_menuDisabled.TabIndex = 2;
            font_menuDisabled.Text = "Disabled";
            font_menuDisabled.Click += font_menuDisabled_Click;
            // 
            // font_menuSelected
            // 
            font_menuSelected.AutoSize = true;
            font_menuSelected.BackColor = SystemColors.MenuHighlight;
            font_menuSelected.ForeColor = SystemColors.HighlightText;
            font_menuSelected.Location = new Point(144, 5);
            font_menuSelected.Name = "font_menuSelected";
            font_menuSelected.Size = new Size(66, 20);
            font_menuSelected.TabIndex = 3;
            font_menuSelected.Text = "Selected";
            font_menuSelected.Click += font_menuSelected_Click;
            // 
            // textbox_ActiveWindow
            // 
            textbox_ActiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_ActiveWindow.BackColor = SystemColors.Window;
            textbox_ActiveWindow.BorderStyle = BorderStyle.Fixed3D;
            textbox_ActiveWindow.Controls.Add(scrollbarClickInterceptor);
            textbox_ActiveWindow.Controls.Add(font_ActiveWindow);
            textbox_ActiveWindow.Controls.Add(selectedText);
            textbox_ActiveWindow.Controls.Add(ScrollBarActiveWindow);
            textbox_ActiveWindow.Location = new Point(2, 65);
            textbox_ActiveWindow.Name = "textbox_ActiveWindow";
            textbox_ActiveWindow.Size = new Size(509, 134);
            textbox_ActiveWindow.TabIndex = 10;
            textbox_ActiveWindow.Click += textbox_ActiveWindow_Click;
            // 
            // scrollbarClickInterceptor
            // 
            scrollbarClickInterceptor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            scrollbarClickInterceptor.CausesValidation = false;
            scrollbarClickInterceptor.Location = new Point(476, 0);
            scrollbarClickInterceptor.Name = "scrollbarClickInterceptor";
            scrollbarClickInterceptor.Size = new Size(28, 130);
            scrollbarClickInterceptor.TabIndex = 10;
            scrollbarClickInterceptor.TabStop = false;
            scrollbarClickInterceptor.Click += ScrollBar_Clicked;
            // 
            // font_ActiveWindow
            // 
            font_ActiveWindow.AutoSize = true;
            font_ActiveWindow.BackColor = Color.Transparent;
            font_ActiveWindow.Font = new Font("Segoe UI", 9F);
            font_ActiveWindow.Location = new Point(1, 1);
            font_ActiveWindow.Name = "font_ActiveWindow";
            font_ActiveWindow.Size = new Size(95, 20);
            font_ActiveWindow.TabIndex = 9;
            font_ActiveWindow.Text = "Window Text";
            font_ActiveWindow.TextAlign = ContentAlignment.MiddleLeft;
            font_ActiveWindow.Click += font_ActiveWindow_Click;
            // 
            // selectedText
            // 
            selectedText.AutoSize = true;
            selectedText.BackColor = SystemColors.Highlight;
            selectedText.ForeColor = SystemColors.HighlightText;
            selectedText.Location = new Point(1, 27);
            selectedText.Margin = new Padding(3);
            selectedText.Name = "selectedText";
            selectedText.Size = new Size(97, 20);
            selectedText.TabIndex = 1;
            selectedText.Text = "Selected Text";
            selectedText.Click += selectedText_Click;
            // 
            // ScrollBarActiveWindow
            // 
            ScrollBarActiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScrollBarActiveWindow.LargeChange = 0;
            ScrollBarActiveWindow.Location = new Point(478, 1);
            ScrollBarActiveWindow.Maximum = 20;
            ScrollBarActiveWindow.Name = "ScrollBarActiveWindow";
            ScrollBarActiveWindow.Size = new Size(26, 124);
            ScrollBarActiveWindow.SmallChange = 0;
            ScrollBarActiveWindow.TabIndex = 0;
            ScrollBarActiveWindow.Scroll += ScrollBar_Clicked;
            ScrollBarActiveWindow.ValueChanged += ScrollBar_Clicked;
            // 
            // titleBar_ActiveWindow
            // 
            titleBar_ActiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleBar_ActiveWindow.BackColor = SystemColors.ActiveCaption;
            titleBar_ActiveWindow.Controls.Add(buttonMinimize_ActiveWindow);
            titleBar_ActiveWindow.Controls.Add(buttonMaximize_ActiveWindow);
            titleBar_ActiveWindow.Controls.Add(font_ActiveWindowTitleBar);
            titleBar_ActiveWindow.Controls.Add(buttonX_ActiveWindow);
            titleBar_ActiveWindow.Location = new Point(2, 2);
            titleBar_ActiveWindow.Margin = new Padding(0);
            titleBar_ActiveWindow.Name = "titleBar_ActiveWindow";
            titleBar_ActiveWindow.Size = new Size(509, 33);
            titleBar_ActiveWindow.TabIndex = 8;
            titleBar_ActiveWindow.Click += ActiveTitleBar_Click;
            // 
            // buttonMinimize_ActiveWindow
            // 
            buttonMinimize_ActiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimize_ActiveWindow.BackColor = SystemColors.Control;
            buttonMinimize_ActiveWindow.BorderStyle = BorderStyle.FixedSingle;
            buttonMinimize_ActiveWindow.FlatStyle = FlatStyle.Flat;
            buttonMinimize_ActiveWindow.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buttonMinimize_ActiveWindow.Location = new Point(415, 2);
            buttonMinimize_ActiveWindow.Name = "buttonMinimize_ActiveWindow";
            buttonMinimize_ActiveWindow.Size = new Size(29, 29);
            buttonMinimize_ActiveWindow.TabIndex = 12;
            buttonMinimize_ActiveWindow.Text = "0";
            buttonMinimize_ActiveWindow.TextAlign = ContentAlignment.MiddleCenter;
            buttonMinimize_ActiveWindow.Click += controlBox_ActiveWindow_Click;
            // 
            // buttonMaximize_ActiveWindow
            // 
            buttonMaximize_ActiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximize_ActiveWindow.BackColor = SystemColors.Control;
            buttonMaximize_ActiveWindow.BorderStyle = BorderStyle.FixedSingle;
            buttonMaximize_ActiveWindow.FlatStyle = FlatStyle.Flat;
            buttonMaximize_ActiveWindow.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buttonMaximize_ActiveWindow.Location = new Point(446, 2);
            buttonMaximize_ActiveWindow.Name = "buttonMaximize_ActiveWindow";
            buttonMaximize_ActiveWindow.Size = new Size(29, 29);
            buttonMaximize_ActiveWindow.TabIndex = 11;
            buttonMaximize_ActiveWindow.Text = "1";
            buttonMaximize_ActiveWindow.TextAlign = ContentAlignment.MiddleCenter;
            buttonMaximize_ActiveWindow.Click += controlBox_ActiveWindow_Click;
            // 
            // font_ActiveWindowTitleBar
            // 
            font_ActiveWindowTitleBar.AutoSize = true;
            font_ActiveWindowTitleBar.BackColor = Color.Transparent;
            font_ActiveWindowTitleBar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            font_ActiveWindowTitleBar.ForeColor = SystemColors.ActiveCaptionText;
            font_ActiveWindowTitleBar.Location = new Point(2, 5);
            font_ActiveWindowTitleBar.Name = "font_ActiveWindowTitleBar";
            font_ActiveWindowTitleBar.Size = new Size(115, 20);
            font_ActiveWindowTitleBar.TabIndex = 2;
            font_ActiveWindowTitleBar.Text = "Active Window";
            font_ActiveWindowTitleBar.Click += ActiveTitleBar_Click;
            // 
            // buttonX_ActiveWindow
            // 
            buttonX_ActiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonX_ActiveWindow.BackColor = SystemColors.Control;
            buttonX_ActiveWindow.BorderStyle = BorderStyle.FixedSingle;
            buttonX_ActiveWindow.FlatStyle = FlatStyle.Flat;
            buttonX_ActiveWindow.Location = new Point(477, 2);
            buttonX_ActiveWindow.Name = "buttonX_ActiveWindow";
            buttonX_ActiveWindow.Size = new Size(29, 29);
            buttonX_ActiveWindow.TabIndex = 10;
            buttonX_ActiveWindow.Text = "✕";
            buttonX_ActiveWindow.TextAlign = ContentAlignment.MiddleCenter;
            buttonX_ActiveWindow.Click += controlBox_ActiveWindow_Click;
            // 
            // panelInactiveWindow
            // 
            panelInactiveWindow.BackColor = SystemColors.Control;
            panelInactiveWindow.BorderStyle = BorderStyle.Fixed3D;
            panelInactiveWindow.Controls.Add(titleBar_InactiveWindow);
            panelInactiveWindow.Location = new Point(25, 25);
            panelInactiveWindow.Margin = new Padding(0);
            panelInactiveWindow.Name = "panelInactiveWindow";
            panelInactiveWindow.Size = new Size(480, 200);
            panelInactiveWindow.TabIndex = 13;
            // 
            // titleBar_InactiveWindow
            // 
            titleBar_InactiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleBar_InactiveWindow.BackColor = SystemColors.InactiveCaption;
            titleBar_InactiveWindow.Controls.Add(buttonMinimize_InactiveWindow);
            titleBar_InactiveWindow.Controls.Add(buttonMaximize_InactiveWindow);
            titleBar_InactiveWindow.Controls.Add(buttonX_InactiveWindow);
            titleBar_InactiveWindow.Controls.Add(font_InactiveWindowTitleBar);
            titleBar_InactiveWindow.Location = new Point(2, 2);
            titleBar_InactiveWindow.Margin = new Padding(0);
            titleBar_InactiveWindow.Name = "titleBar_InactiveWindow";
            titleBar_InactiveWindow.Size = new Size(474, 33);
            titleBar_InactiveWindow.TabIndex = 12;
            titleBar_InactiveWindow.Click += InactiveTitleBar_Click;
            // 
            // buttonMinimize_InactiveWindow
            // 
            buttonMinimize_InactiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimize_InactiveWindow.BackColor = SystemColors.Control;
            buttonMinimize_InactiveWindow.BorderStyle = BorderStyle.FixedSingle;
            buttonMinimize_InactiveWindow.FlatStyle = FlatStyle.Flat;
            buttonMinimize_InactiveWindow.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buttonMinimize_InactiveWindow.Location = new Point(380, 2);
            buttonMinimize_InactiveWindow.Name = "buttonMinimize_InactiveWindow";
            buttonMinimize_InactiveWindow.Size = new Size(29, 29);
            buttonMinimize_InactiveWindow.TabIndex = 15;
            buttonMinimize_InactiveWindow.Text = "0";
            buttonMinimize_InactiveWindow.TextAlign = ContentAlignment.MiddleCenter;
            buttonMinimize_InactiveWindow.Click += controlBox_InactiveWindow_Click;
            // 
            // buttonMaximize_InactiveWindow
            // 
            buttonMaximize_InactiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximize_InactiveWindow.BackColor = SystemColors.Control;
            buttonMaximize_InactiveWindow.BorderStyle = BorderStyle.FixedSingle;
            buttonMaximize_InactiveWindow.FlatStyle = FlatStyle.Flat;
            buttonMaximize_InactiveWindow.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buttonMaximize_InactiveWindow.Location = new Point(411, 2);
            buttonMaximize_InactiveWindow.Name = "buttonMaximize_InactiveWindow";
            buttonMaximize_InactiveWindow.Size = new Size(29, 29);
            buttonMaximize_InactiveWindow.TabIndex = 14;
            buttonMaximize_InactiveWindow.Text = "1";
            buttonMaximize_InactiveWindow.TextAlign = ContentAlignment.MiddleCenter;
            buttonMaximize_InactiveWindow.Click += controlBox_InactiveWindow_Click;
            // 
            // buttonX_InactiveWindow
            // 
            buttonX_InactiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonX_InactiveWindow.BackColor = SystemColors.Control;
            buttonX_InactiveWindow.BorderStyle = BorderStyle.FixedSingle;
            buttonX_InactiveWindow.FlatStyle = FlatStyle.Flat;
            buttonX_InactiveWindow.Location = new Point(442, 2);
            buttonX_InactiveWindow.Name = "buttonX_InactiveWindow";
            buttonX_InactiveWindow.Size = new Size(29, 29);
            buttonX_InactiveWindow.TabIndex = 13;
            buttonX_InactiveWindow.Text = "✕";
            buttonX_InactiveWindow.TextAlign = ContentAlignment.MiddleCenter;
            buttonX_InactiveWindow.Click += controlBox_InactiveWindow_Click;
            // 
            // font_InactiveWindowTitleBar
            // 
            font_InactiveWindowTitleBar.AutoSize = true;
            font_InactiveWindowTitleBar.BackColor = Color.Transparent;
            font_InactiveWindowTitleBar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            font_InactiveWindowTitleBar.ForeColor = SystemColors.InactiveCaptionText;
            font_InactiveWindowTitleBar.Location = new Point(2, 5);
            font_InactiveWindowTitleBar.Name = "font_InactiveWindowTitleBar";
            font_InactiveWindowTitleBar.Size = new Size(126, 20);
            font_InactiveWindowTitleBar.TabIndex = 2;
            font_InactiveWindowTitleBar.Text = "Inactive Window";
            font_InactiveWindowTitleBar.Click += InactiveTitleBar_Click;
            // 
            // border1
            // 
            border1.BackColor = Color.Transparent;
            border1.BorderStyle = BorderControlType.FocusRectangle;
            border1.CausesValidation = false;
            border1.ForeColor = Color.FromArgb(255, 255, 255);
            border1.Location = new Point(474, 328);
            border1.Name = "border1";
            border1.Size = new Size(74, 24);
            border1.TabIndex = 2;
            border1.TabStop = false;
            // 
            // desktopWindow
            // 
            desktopWindow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            desktopWindow.BackColor = SystemColors.Desktop;
            desktopWindow.Controls.Add(iconClickInterceptor);
            desktopWindow.Controls.Add(border2);
            desktopWindow.Controls.Add(IconText);
            desktopWindow.Controls.Add(pictureBox1);
            desktopWindow.Controls.Add(border1);
            desktopWindow.Location = new Point(0, 0);
            desktopWindow.Margin = new Padding(0);
            desktopWindow.Name = "desktopWindow";
            desktopWindow.Size = new Size(570, 370);
            desktopWindow.TabIndex = 14;
            desktopWindow.Click += window_Desktop_Click;
            // 
            // iconClickInterceptor
            // 
            iconClickInterceptor.CausesValidation = false;
            iconClickInterceptor.Location = new Point(477, 279);
            iconClickInterceptor.Name = "iconClickInterceptor";
            iconClickInterceptor.Size = new Size(68, 71);
            iconClickInterceptor.TabIndex = 4;
            iconClickInterceptor.TabStop = false;
            iconClickInterceptor.Click += iconClickInterceptor_Click;
            // 
            // border2
            // 
            border2.BackColor = Color.Transparent;
            border2.BorderStyle = BorderControlType.FocusRectangle;
            border2.CausesValidation = false;
            border2.ForeColor = Color.FromArgb(255, 255, 255);
            border2.Location = new Point(484, 278);
            border2.Name = "border2";
            border2.Size = new Size(51, 49);
            border2.TabIndex = 3;
            border2.TabStop = false;
            // 
            // IconText
            // 
            IconText.AutoSize = true;
            IconText.BackColor = SystemColors.Highlight;
            IconText.ForeColor = SystemColors.HighlightText;
            IconText.Location = new Point(477, 330);
            IconText.Name = "IconText";
            IconText.Size = new Size(68, 20);
            IconText.TabIndex = 1;
            IconText.Text = "Icon Text";
            IconText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(486, 279);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // inactiveBorderClickInterceptor1
            // 
            inactiveBorderClickInterceptor1.CausesValidation = false;
            inactiveBorderClickInterceptor1.Location = new Point(25, 23);
            inactiveBorderClickInterceptor1.Name = "inactiveBorderClickInterceptor1";
            inactiveBorderClickInterceptor1.Size = new Size(481, 5);
            inactiveBorderClickInterceptor1.TabIndex = 7;
            inactiveBorderClickInterceptor1.TabStop = false;
            inactiveBorderClickInterceptor1.Click += inactiveBorderClickInterceptor_Click;
            // 
            // inactiveBorderClickInterceptor3
            // 
            inactiveBorderClickInterceptor3.CausesValidation = false;
            inactiveBorderClickInterceptor3.Location = new Point(25, 24);
            inactiveBorderClickInterceptor3.Name = "inactiveBorderClickInterceptor3";
            inactiveBorderClickInterceptor3.Size = new Size(4, 202);
            inactiveBorderClickInterceptor3.TabIndex = 12;
            inactiveBorderClickInterceptor3.TabStop = false;
            inactiveBorderClickInterceptor3.Click += inactiveBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor5
            // 
            activeBorderClickInterceptor5.CausesValidation = false;
            activeBorderClickInterceptor5.Location = new Point(538, 62);
            activeBorderClickInterceptor5.Name = "activeBorderClickInterceptor5";
            activeBorderClickInterceptor5.Size = new Size(4, 199);
            activeBorderClickInterceptor5.TabIndex = 13;
            activeBorderClickInterceptor5.TabStop = false;
            activeBorderClickInterceptor5.Click += activeBorderClickInterceptor_Click;
            // 
            // inactiveBorderClickInterceptor2
            // 
            inactiveBorderClickInterceptor2.CausesValidation = false;
            inactiveBorderClickInterceptor2.Location = new Point(502, 25);
            inactiveBorderClickInterceptor2.Name = "inactiveBorderClickInterceptor2";
            inactiveBorderClickInterceptor2.Size = new Size(4, 34);
            inactiveBorderClickInterceptor2.TabIndex = 14;
            inactiveBorderClickInterceptor2.TabStop = false;
            inactiveBorderClickInterceptor2.Click += inactiveBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor6
            // 
            activeBorderClickInterceptor6.CausesValidation = false;
            activeBorderClickInterceptor6.Location = new Point(29, 63);
            activeBorderClickInterceptor6.Name = "activeBorderClickInterceptor6";
            activeBorderClickInterceptor6.Size = new Size(4, 200);
            activeBorderClickInterceptor6.TabIndex = 15;
            activeBorderClickInterceptor6.TabStop = false;
            activeBorderClickInterceptor6.Click += activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor7
            // 
            activeBorderClickInterceptor7.CausesValidation = false;
            activeBorderClickInterceptor7.Location = new Point(29, 259);
            activeBorderClickInterceptor7.Name = "activeBorderClickInterceptor7";
            activeBorderClickInterceptor7.Size = new Size(24, 4);
            activeBorderClickInterceptor7.TabIndex = 16;
            activeBorderClickInterceptor7.TabStop = false;
            activeBorderClickInterceptor7.Click += activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor8
            // 
            activeBorderClickInterceptor8.CausesValidation = false;
            activeBorderClickInterceptor8.Location = new Point(55, 197);
            activeBorderClickInterceptor8.Name = "activeBorderClickInterceptor8";
            activeBorderClickInterceptor8.Size = new Size(385, 5);
            activeBorderClickInterceptor8.TabIndex = 18;
            activeBorderClickInterceptor8.TabStop = false;
            activeBorderClickInterceptor8.Click += activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor9
            // 
            activeBorderClickInterceptor9.CausesValidation = false;
            activeBorderClickInterceptor9.Location = new Point(441, 259);
            activeBorderClickInterceptor9.Name = "activeBorderClickInterceptor9";
            activeBorderClickInterceptor9.Size = new Size(101, 4);
            activeBorderClickInterceptor9.TabIndex = 19;
            activeBorderClickInterceptor9.TabStop = false;
            activeBorderClickInterceptor9.Click += activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor0
            // 
            activeBorderClickInterceptor0.CausesValidation = false;
            activeBorderClickInterceptor0.Location = new Point(28, 60);
            activeBorderClickInterceptor0.Name = "activeBorderClickInterceptor0";
            activeBorderClickInterceptor0.Size = new Size(514, 4);
            activeBorderClickInterceptor0.TabIndex = 20;
            activeBorderClickInterceptor0.TabStop = false;
            activeBorderClickInterceptor0.Click += activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor3
            // 
            activeBorderClickInterceptor3.CausesValidation = false;
            activeBorderClickInterceptor3.Location = new Point(51, 313);
            activeBorderClickInterceptor3.Name = "activeBorderClickInterceptor3";
            activeBorderClickInterceptor3.Size = new Size(390, 4);
            activeBorderClickInterceptor3.TabIndex = 5;
            activeBorderClickInterceptor3.TabStop = false;
            activeBorderClickInterceptor3.Click += activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor4
            // 
            activeBorderClickInterceptor4.CausesValidation = false;
            activeBorderClickInterceptor4.Location = new Point(51, 197);
            activeBorderClickInterceptor4.Name = "activeBorderClickInterceptor4";
            activeBorderClickInterceptor4.Size = new Size(392, 5);
            activeBorderClickInterceptor4.TabIndex = 6;
            activeBorderClickInterceptor4.TabStop = false;
            activeBorderClickInterceptor4.Click += activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor2
            // 
            activeBorderClickInterceptor2.CausesValidation = false;
            activeBorderClickInterceptor2.Location = new Point(51, 198);
            activeBorderClickInterceptor2.Name = "activeBorderClickInterceptor2";
            activeBorderClickInterceptor2.Size = new Size(4, 119);
            activeBorderClickInterceptor2.TabIndex = 5;
            activeBorderClickInterceptor2.TabStop = false;
            activeBorderClickInterceptor2.Click += activeBorderClickInterceptor_Click;
            // 
            // activeBorderClickInterceptor1
            // 
            activeBorderClickInterceptor1.CausesValidation = false;
            activeBorderClickInterceptor1.Location = new Point(439, 198);
            activeBorderClickInterceptor1.Name = "activeBorderClickInterceptor1";
            activeBorderClickInterceptor1.Size = new Size(4, 119);
            activeBorderClickInterceptor1.TabIndex = 5;
            activeBorderClickInterceptor1.TabStop = false;
            activeBorderClickInterceptor1.Click += activeBorderClickInterceptor_Click;
            // 
            // WindowsUIMockupControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Desktop;
            Controls.Add(inactiveBorderClickInterceptor2);
            Controls.Add(inactiveBorderClickInterceptor3);
            Controls.Add(inactiveBorderClickInterceptor1);
            Controls.Add(activeBorderClickInterceptor0);
            Controls.Add(activeBorderClickInterceptor9);
            Controls.Add(activeBorderClickInterceptor8);
            Controls.Add(activeBorderClickInterceptor7);
            Controls.Add(activeBorderClickInterceptor6);
            Controls.Add(activeBorderClickInterceptor5);
            Controls.Add(activeBorderClickInterceptor4);
            Controls.Add(activeBorderClickInterceptor3);
            Controls.Add(activeBorderClickInterceptor2);
            Controls.Add(activeBorderClickInterceptor1);
            Controls.Add(window_MessageBox);
            Controls.Add(panelActiveWindow);
            Controls.Add(panelInactiveWindow);
            Controls.Add(desktopWindow);
            Margin = new Padding(0);
            MaximumSize = new Size(570, 370);
            MinimumSize = new Size(570, 340);
            Name = "WindowsUIMockupControl";
            Size = new Size(570, 370);
            window_MessageBox.ResumeLayout(false);
            window_MessageBox.PerformLayout();
            titleBar_MessageBox.ResumeLayout(false);
            titleBar_MessageBox.PerformLayout();
            panelActiveWindow.ResumeLayout(false);
            menu.ResumeLayout(false);
            menu.PerformLayout();
            textbox_ActiveWindow.ResumeLayout(false);
            textbox_ActiveWindow.PerformLayout();
            titleBar_ActiveWindow.ResumeLayout(false);
            titleBar_ActiveWindow.PerformLayout();
            panelInactiveWindow.ResumeLayout(false);
            titleBar_InactiveWindow.ResumeLayout(false);
            titleBar_InactiveWindow.PerformLayout();
            desktopWindow.ResumeLayout(false);
            desktopWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Panel menu;
        private LinkLabel hyperlinkText;
        private Label selectedText;
        private Label InfoWindowAndText;
        private DisabledStyleLabel font_menuDisabled;
        private ClickInterceptorBox scrollbarClickInterceptor;
        private PictureBox pictureBox1;
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
        private ButtonLikeLabel button_MessageBox;
    }
}
