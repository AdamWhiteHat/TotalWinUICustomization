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
                CreateParams ret = base.CreateParams;
                //ret.Style = (int)WindowStyles.WS_THICKFRAME;
                //ret.Style |= (int)WindowStyles.WS_CHILD;
                ret.ExStyle |= (int)WindowStyles.WS_EX_NOACTIVATE;
                // ret.ExStyle |=  (int)WindowStyles.WS_EX_TOOLWINDOW;
                // ret.ExStyle |= (int)WindowStyles.WS_EX_TOPMOST;
                return ret;
            }
        }

        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }

        public override bool Focused
        {
            get
            {
                return false;
            }
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            window_MessageBox = new Panel();
            InfoWindowAndText = new Label();
            hyperlinkText = new LinkLabel();
            buttonX_MessageBox = new Label();
            button_MessageBox = new Label();
            font_MessageBox = new Label();
            titleBar_MessageBox = new Panel();
            font_MessageBoxTitleBar = new Label();
            panelActiveWindow = new Panel();
            activeWindowBorder = new Border();
            menu = new Panel();
            font_menuNormal = new Label();
            font_menuDisabled = new Label();
            font_menuSelected = new Label();
            textbox_ActiveWindow = new Panel();
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
            desktopWindow = new Panel();
            window_MessageBox.SuspendLayout();
            titleBar_MessageBox.SuspendLayout();
            panelActiveWindow.SuspendLayout();
            menu.SuspendLayout();
            textbox_ActiveWindow.SuspendLayout();
            titleBar_ActiveWindow.SuspendLayout();
            panelInactiveWindow.SuspendLayout();
            titleBar_InactiveWindow.SuspendLayout();
            SuspendLayout();
            // 
            // window_MessageBox
            // 
            window_MessageBox.BackColor = SystemColors.Control;
            window_MessageBox.BorderStyle = BorderStyle.Fixed3D;
            window_MessageBox.Controls.Add(InfoWindowAndText);
            window_MessageBox.Controls.Add(hyperlinkText);
            window_MessageBox.Controls.Add(buttonX_MessageBox);
            window_MessageBox.Controls.Add(button_MessageBox);
            window_MessageBox.Controls.Add(font_MessageBox);
            window_MessageBox.Controls.Add(titleBar_MessageBox);
            window_MessageBox.Location = new Point(52, 198);
            window_MessageBox.Margin = new Padding(0);
            window_MessageBox.Name = "window_MessageBox";
            window_MessageBox.Size = new Size(390, 117);
            window_MessageBox.TabIndex = 11;
            window_MessageBox.Click += window_MessageBox_Click;
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
            // 
            // hyperlinkText
            // 
            hyperlinkText.AutoSize = true;
            hyperlinkText.LinkColor = SystemColors.HotTrack;
            hyperlinkText.Location = new Point(6, 65);
            hyperlinkText.Name = "hyperlinkText";
            hyperlinkText.Size = new Size(72, 20);
            hyperlinkText.TabIndex = 10;
            hyperlinkText.TabStop = true;
            hyperlinkText.Text = "Hyperlink";
            // 
            // buttonX_MessageBox
            // 
            buttonX_MessageBox.BorderStyle = BorderStyle.FixedSingle;
            buttonX_MessageBox.FlatStyle = FlatStyle.Flat;
            buttonX_MessageBox.Location = new Point(355, 3);
            buttonX_MessageBox.Name = "buttonX_MessageBox";
            buttonX_MessageBox.Size = new Size(29, 29);
            buttonX_MessageBox.TabIndex = 9;
            buttonX_MessageBox.Text = "✕";
            buttonX_MessageBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_MessageBox
            // 
            button_MessageBox.Anchor = AnchorStyles.Bottom;
            button_MessageBox.BackColor = SystemColors.ButtonFace;
            button_MessageBox.BorderStyle = BorderStyle.FixedSingle;
            button_MessageBox.Location = new Point(146, 73);
            button_MessageBox.Name = "button_MessageBox";
            button_MessageBox.Size = new Size(94, 29);
            button_MessageBox.TabIndex = 8;
            button_MessageBox.Text = "OK";
            button_MessageBox.TextAlign = ContentAlignment.MiddleCenter;
            button_MessageBox.Click += button_MessageBox_Click;
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
            font_MessageBox.Click += font_MessageBox_Click;
            // 
            // titleBar_MessageBox
            // 
            titleBar_MessageBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleBar_MessageBox.BackColor = SystemColors.ActiveCaption;
            titleBar_MessageBox.Controls.Add(font_MessageBoxTitleBar);
            titleBar_MessageBox.ForeColor = SystemColors.ControlText;
            titleBar_MessageBox.Location = new Point(2, 2);
            titleBar_MessageBox.Margin = new Padding(0);
            titleBar_MessageBox.Name = "titleBar_MessageBox";
            titleBar_MessageBox.Size = new Size(384, 31);
            titleBar_MessageBox.TabIndex = 7;
            titleBar_MessageBox.Click += titleBar_MessageBox_Click;
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
            font_MessageBoxTitleBar.Click += font_MessageBoxTitleBar_Click;
            // 
            // panelActiveWindow
            // 
            panelActiveWindow.BackColor = Color.Lime;
            panelActiveWindow.BorderStyle = BorderStyle.Fixed3D;
            panelActiveWindow.Controls.Add(activeWindowBorder);
            panelActiveWindow.Controls.Add(menu);
            panelActiveWindow.Controls.Add(textbox_ActiveWindow);
            panelActiveWindow.Controls.Add(titleBar_ActiveWindow);
            panelActiveWindow.Location = new Point(31, 63);
            panelActiveWindow.Margin = new Padding(0);
            panelActiveWindow.Name = "panelActiveWindow";
            panelActiveWindow.Size = new Size(480, 200);
            panelActiveWindow.TabIndex = 10;
            // 
            // activeWindowBorder
            // 
            activeWindowBorder.BackColor = Color.Transparent;
            activeWindowBorder.ForeColor = Color.Red;
            activeWindowBorder.Location = new Point(6, 6);
            activeWindowBorder.Name = "activeWindowBorder";
            activeWindowBorder.Size = new Size(467, 185);
            activeWindowBorder.TabIndex = 12;
            activeWindowBorder.Text = "border1";
            // 
            // menu
            // 
            menu.BackColor = SystemColors.Menu;
            menu.Controls.Add(font_menuNormal);
            menu.Controls.Add(font_menuDisabled);
            menu.Controls.Add(font_menuSelected);
            menu.Location = new Point(6, 37);
            menu.Margin = new Padding(0);
            menu.Name = "menu";
            menu.Size = new Size(463, 28);
            menu.TabIndex = 11;
            // 
            // font_menuNormal
            // 
            font_menuNormal.AutoSize = true;
            font_menuNormal.ForeColor = SystemColors.MenuText;
            font_menuNormal.Location = new Point(5, 3);
            font_menuNormal.Name = "font_menuNormal";
            font_menuNormal.Size = new Size(59, 20);
            font_menuNormal.TabIndex = 1;
            font_menuNormal.Text = "Normal";
            font_menuNormal.Click += font_menuNormal_Click;
            // 
            // font_menuDisabled
            // 
            font_menuDisabled.AutoSize = true;
            font_menuDisabled.ForeColor = SystemColors.GrayText;
            font_menuDisabled.Location = new Point(70, 3);
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
            font_menuSelected.Location = new Point(144, 3);
            font_menuSelected.Name = "font_menuSelected";
            font_menuSelected.Size = new Size(66, 20);
            font_menuSelected.TabIndex = 3;
            font_menuSelected.Text = "Selected";
            font_menuSelected.Click += font_menuSelected_Click;
            // 
            // textbox_ActiveWindow
            // 
            textbox_ActiveWindow.BackColor = SystemColors.Window;
            textbox_ActiveWindow.BorderStyle = BorderStyle.Fixed3D;
            textbox_ActiveWindow.Controls.Add(font_ActiveWindow);
            textbox_ActiveWindow.Controls.Add(selectedText);
            textbox_ActiveWindow.Controls.Add(ScrollBarActiveWindow);
            textbox_ActiveWindow.Location = new Point(6, 64);
            textbox_ActiveWindow.Name = "textbox_ActiveWindow";
            textbox_ActiveWindow.Size = new Size(463, 126);
            textbox_ActiveWindow.TabIndex = 10;
            textbox_ActiveWindow.Click += textbox_ActiveWindow_Click;
            // 
            // font_ActiveWindow
            // 
            font_ActiveWindow.AutoSize = true;
            font_ActiveWindow.BackColor = SystemColors.Window;
            font_ActiveWindow.Font = new Font("Segoe UI", 9F);
            font_ActiveWindow.Location = new Point(3, 3);
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
            selectedText.Location = new Point(3, 29);
            selectedText.Margin = new Padding(3);
            selectedText.Name = "selectedText";
            selectedText.Size = new Size(97, 20);
            selectedText.TabIndex = 1;
            selectedText.Text = "Selected Text";
            // 
            // ScrollBarActiveWindow
            // 
            ScrollBarActiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ScrollBarActiveWindow.LargeChange = 5;
            ScrollBarActiveWindow.Location = new Point(432, 0);
            ScrollBarActiveWindow.Maximum = 20;
            ScrollBarActiveWindow.Name = "ScrollBarActiveWindow";
            ScrollBarActiveWindow.Size = new Size(26, 122);
            ScrollBarActiveWindow.TabIndex = 0;
            // 
            // titleBar_ActiveWindow
            // 
            titleBar_ActiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleBar_ActiveWindow.BackColor = SystemColors.ActiveCaption;
            titleBar_ActiveWindow.Controls.Add(buttonMinimize_ActiveWindow);
            titleBar_ActiveWindow.Controls.Add(buttonMaximize_ActiveWindow);
            titleBar_ActiveWindow.Controls.Add(font_ActiveWindowTitleBar);
            titleBar_ActiveWindow.Controls.Add(buttonX_ActiveWindow);
            titleBar_ActiveWindow.Location = new Point(6, 6);
            titleBar_ActiveWindow.Margin = new Padding(0);
            titleBar_ActiveWindow.Name = "titleBar_ActiveWindow";
            titleBar_ActiveWindow.Size = new Size(463, 31);
            titleBar_ActiveWindow.TabIndex = 8;
            titleBar_ActiveWindow.Click += titleBar_ActiveWindow_Click;
            titleBar_ActiveWindow.Paint += titleBar_ActiveWindow_Paint;
            // 
            // buttonMinimize_ActiveWindow
            // 
            buttonMinimize_ActiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimize_ActiveWindow.BackColor = SystemColors.Control;
            buttonMinimize_ActiveWindow.BorderStyle = BorderStyle.FixedSingle;
            buttonMinimize_ActiveWindow.FlatStyle = FlatStyle.Flat;
            buttonMinimize_ActiveWindow.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buttonMinimize_ActiveWindow.Location = new Point(369, 2);
            buttonMinimize_ActiveWindow.Name = "buttonMinimize_ActiveWindow";
            buttonMinimize_ActiveWindow.Size = new Size(29, 27);
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
            buttonMaximize_ActiveWindow.Location = new Point(400, 2);
            buttonMaximize_ActiveWindow.Name = "buttonMaximize_ActiveWindow";
            buttonMaximize_ActiveWindow.Size = new Size(29, 27);
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
            font_ActiveWindowTitleBar.Click += font_ActiveWindowTitleBar_Click;
            // 
            // buttonX_ActiveWindow
            // 
            buttonX_ActiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonX_ActiveWindow.BackColor = SystemColors.Control;
            buttonX_ActiveWindow.BorderStyle = BorderStyle.FixedSingle;
            buttonX_ActiveWindow.FlatStyle = FlatStyle.Flat;
            buttonX_ActiveWindow.Location = new Point(431, 2);
            buttonX_ActiveWindow.Name = "buttonX_ActiveWindow";
            buttonX_ActiveWindow.Size = new Size(29, 27);
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
            titleBar_InactiveWindow.Size = new Size(474, 31);
            titleBar_InactiveWindow.TabIndex = 12;
            titleBar_InactiveWindow.Click += titleBar_InactiveWindow_Click;
            titleBar_InactiveWindow.Paint += titleBar_InactiveWindow_Paint;
            // 
            // buttonMinimize_InactiveWindow
            // 
            buttonMinimize_InactiveWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimize_InactiveWindow.BackColor = SystemColors.Control;
            buttonMinimize_InactiveWindow.BorderStyle = BorderStyle.FixedSingle;
            buttonMinimize_InactiveWindow.FlatStyle = FlatStyle.Flat;
            buttonMinimize_InactiveWindow.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buttonMinimize_InactiveWindow.Location = new Point(380, 1);
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
            buttonMaximize_InactiveWindow.Location = new Point(411, 1);
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
            buttonX_InactiveWindow.Location = new Point(442, 1);
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
            font_InactiveWindowTitleBar.Click += font_InactiveWindowTitleBar_Click;
            // 
            // desktopWindow
            // 
            desktopWindow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            desktopWindow.Location = new Point(0, 0);
            desktopWindow.Margin = new Padding(0);
            desktopWindow.Name = "desktopWindow";
            desktopWindow.Size = new Size(536, 337);
            desktopWindow.TabIndex = 14;
            desktopWindow.Click += window_Desktop_Click;
            // 
            // WindowsUIMockupControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Desktop;
            Controls.Add(window_MessageBox);
            Controls.Add(panelActiveWindow);
            Controls.Add(panelInactiveWindow);
            Controls.Add(desktopWindow);
            Margin = new Padding(0);
            MaximumSize = new Size(536, 335);
            MinimumSize = new Size(536, 335);
            Name = "WindowsUIMockupControl";
            Size = new Size(536, 335);
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
        private Label font_menuDisabled;
        private Label font_menuNormal;
        private Panel titleBar_InactiveWindow;
        private Label font_InactiveWindowTitleBar;
        private Panel panelInactiveWindow;
        private Panel desktopWindow;
        private Label button_MessageBox;
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
        private Border activeWindowBorder;
    }
}
