using System.Windows.Input;

namespace TotalWinUICustomization
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelBottomControls = new Panel();
            PanelColorPropertyControls = new Panel();
            panelPropertyColorsControls = new Panel();
            panelPropertyColor2 = new Panel();
            label3 = new Label();
            buttonPropertyColor2 = new Button();
            panelPropertyColorSwatch2 = new Panel();
            label6 = new Label();
            buttonPropertyColor1 = new Button();
            panelPropertyColorSwatch1 = new Panel();
            comboBoxColorPropertySelection = new ComboBox();
            label1 = new Label();
            PanelFontPropertyControls = new Panel();
            panelFontColorsControls = new Panel();
            sizeUpDown_Font = new DomainUpDown();
            label5 = new Label();
            label4 = new Label();
            buttonFontColor = new Button();
            panelFontColorSwatch = new Panel();
            label2 = new Label();
            comboBoxFontPropertySelection = new ComboBox();
            colorPickerDialog = new ColorDialog();
            fontPickerDialog = new FontDialog();
            windowsuiMockupControl = new WindowsUIMockupControl();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelPropertyFontColor = new Panel();
            panelBottomControls.SuspendLayout();
            PanelColorPropertyControls.SuspendLayout();
            panelPropertyColorsControls.SuspendLayout();
            panelPropertyColor2.SuspendLayout();
            buttonPropertyColor2.SuspendLayout();
            buttonPropertyColor1.SuspendLayout();
            PanelFontPropertyControls.SuspendLayout();
            panelFontColorsControls.SuspendLayout();
            buttonFontColor.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelPropertyFontColor.SuspendLayout();
            SuspendLayout();
            // 
            // panelBottomControls
            // 
            panelBottomControls.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBottomControls.Controls.Add(PanelColorPropertyControls);
            panelBottomControls.Controls.Add(PanelFontPropertyControls);
            panelBottomControls.Location = new Point(3, 477);
            panelBottomControls.Margin = new Padding(3, 4, 3, 4);
            panelBottomControls.Name = "panelBottomControls";
            panelBottomControls.Size = new Size(564, 158);
            panelBottomControls.TabIndex = 1;
            // 
            // PanelColorPropertyControls
            // 
            PanelColorPropertyControls.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelColorPropertyControls.Controls.Add(panelPropertyColorsControls);
            PanelColorPropertyControls.Controls.Add(comboBoxColorPropertySelection);
            PanelColorPropertyControls.Controls.Add(label1);
            PanelColorPropertyControls.Enabled = false;
            PanelColorPropertyControls.Location = new Point(1, 4);
            PanelColorPropertyControls.Margin = new Padding(3, 4, 3, 4);
            PanelColorPropertyControls.Name = "PanelColorPropertyControls";
            PanelColorPropertyControls.Size = new Size(562, 72);
            PanelColorPropertyControls.TabIndex = 19;
            // 
            // panelPropertyColorsControls
            // 
            panelPropertyColorsControls.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelPropertyColorsControls.Controls.Add(panelPropertyColor2);
            panelPropertyColorsControls.Controls.Add(label6);
            panelPropertyColorsControls.Controls.Add(buttonPropertyColor1);
            panelPropertyColorsControls.Location = new Point(355, 0);
            panelPropertyColorsControls.Margin = new Padding(0);
            panelPropertyColorsControls.Name = "panelPropertyColorsControls";
            panelPropertyColorsControls.Size = new Size(206, 72);
            panelPropertyColorsControls.TabIndex = 17;
            // 
            // panelPropertyColor2
            // 
            panelPropertyColor2.Controls.Add(label3);
            panelPropertyColor2.Controls.Add(buttonPropertyColor2);
            panelPropertyColor2.Enabled = false;
            panelPropertyColor2.Location = new Point(99, 0);
            panelPropertyColor2.Margin = new Padding(0);
            panelPropertyColor2.Name = "panelPropertyColor2";
            panelPropertyColor2.Size = new Size(107, 72);
            panelPropertyColor2.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(6, 5);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 17;
            label3.Text = "Color 2:";
            // 
            // buttonPropertyColor2
            // 
            buttonPropertyColor2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPropertyColor2.Controls.Add(panelPropertyColorSwatch2);
            buttonPropertyColor2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPropertyColor2.Location = new Point(3, 28);
            buttonPropertyColor2.Margin = new Padding(3, 4, 3, 4);
            buttonPropertyColor2.Name = "buttonPropertyColor2";
            buttonPropertyColor2.Size = new Size(99, 40);
            buttonPropertyColor2.TabIndex = 16;
            buttonPropertyColor2.Text = "│ ▾";
            buttonPropertyColor2.TextAlign = ContentAlignment.MiddleRight;
            buttonPropertyColor2.UseVisualStyleBackColor = true;
            buttonPropertyColor2.Click += buttonPropertyColor2_Click;
            // 
            // panelPropertyColorSwatch2
            // 
            panelPropertyColorSwatch2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPropertyColorSwatch2.BackColor = Color.Blue;
            panelPropertyColorSwatch2.BorderStyle = BorderStyle.FixedSingle;
            panelPropertyColorSwatch2.Location = new Point(4, 5);
            panelPropertyColorSwatch2.Margin = new Padding(3, 4, 3, 4);
            panelPropertyColorSwatch2.MaximumSize = new Size(58, 30);
            panelPropertyColorSwatch2.MinimumSize = new Size(58, 30);
            panelPropertyColorSwatch2.Name = "panelPropertyColorSwatch2";
            panelPropertyColorSwatch2.Size = new Size(58, 30);
            panelPropertyColorSwatch2.TabIndex = 2;
            panelPropertyColorSwatch2.Click += buttonPropertyColor2_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 5);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 13;
            label6.Text = "Color 1:";
            // 
            // buttonPropertyColor1
            // 
            buttonPropertyColor1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPropertyColor1.Controls.Add(panelPropertyColorSwatch1);
            buttonPropertyColor1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPropertyColor1.Location = new Point(1, 28);
            buttonPropertyColor1.Margin = new Padding(3, 4, 3, 4);
            buttonPropertyColor1.Name = "buttonPropertyColor1";
            buttonPropertyColor1.Size = new Size(99, 40);
            buttonPropertyColor1.TabIndex = 11;
            buttonPropertyColor1.Text = "│ ▾";
            buttonPropertyColor1.TextAlign = ContentAlignment.MiddleRight;
            buttonPropertyColor1.UseVisualStyleBackColor = true;
            buttonPropertyColor1.Click += buttonPropertyColor1_Click;
            // 
            // panelPropertyColorSwatch1
            // 
            panelPropertyColorSwatch1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPropertyColorSwatch1.BackColor = Color.Blue;
            panelPropertyColorSwatch1.BorderStyle = BorderStyle.FixedSingle;
            panelPropertyColorSwatch1.Location = new Point(4, 5);
            panelPropertyColorSwatch1.Margin = new Padding(3, 4, 3, 4);
            panelPropertyColorSwatch1.MaximumSize = new Size(58, 30);
            panelPropertyColorSwatch1.MinimumSize = new Size(58, 30);
            panelPropertyColorSwatch1.Name = "panelPropertyColorSwatch1";
            panelPropertyColorSwatch1.Size = new Size(58, 30);
            panelPropertyColorSwatch1.TabIndex = 2;
            panelPropertyColorSwatch1.Click += buttonPropertyColor1_Click;
            // 
            // comboBoxColorPropertySelection
            // 
            comboBoxColorPropertySelection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxColorPropertySelection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColorPropertySelection.FormattingEnabled = true;
            comboBoxColorPropertySelection.Location = new Point(14, 28);
            comboBoxColorPropertySelection.Margin = new Padding(3, 4, 3, 4);
            comboBoxColorPropertySelection.Name = "comboBoxColorPropertySelection";
            comboBoxColorPropertySelection.Size = new Size(336, 31);
            comboBoxColorPropertySelection.TabIndex = 0;
            comboBoxColorPropertySelection.SelectionChangeCommitted += comboBoxColorPropertySelection_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 3);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 4;
            label1.Text = "UI Element:";
            // 
            // PanelFontPropertyControls
            // 
            PanelFontPropertyControls.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelFontPropertyControls.Controls.Add(panelFontColorsControls);
            PanelFontPropertyControls.Controls.Add(label2);
            PanelFontPropertyControls.Controls.Add(comboBoxFontPropertySelection);
            PanelFontPropertyControls.Enabled = false;
            PanelFontPropertyControls.Location = new Point(1, 82);
            PanelFontPropertyControls.Margin = new Padding(3, 4, 3, 4);
            PanelFontPropertyControls.Name = "PanelFontPropertyControls";
            PanelFontPropertyControls.Size = new Size(562, 72);
            PanelFontPropertyControls.TabIndex = 16;
            // 
            // panelFontColorsControls
            // 
            panelFontColorsControls.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelFontColorsControls.Controls.Add(panelPropertyFontColor);
            panelFontColorsControls.Controls.Add(sizeUpDown_Font);
            panelFontColorsControls.Controls.Add(label4);
            panelFontColorsControls.Location = new Point(355, 0);
            panelFontColorsControls.Margin = new Padding(0);
            panelFontColorsControls.Name = "panelFontColorsControls";
            panelFontColorsControls.Size = new Size(206, 72);
            panelFontColorsControls.TabIndex = 2;
            // 
            // sizeUpDown_Font
            // 
            sizeUpDown_Font.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sizeUpDown_Font.Items.Add("72");
            sizeUpDown_Font.Items.Add("48");
            sizeUpDown_Font.Items.Add("36");
            sizeUpDown_Font.Items.Add("28");
            sizeUpDown_Font.Items.Add("26");
            sizeUpDown_Font.Items.Add("24");
            sizeUpDown_Font.Items.Add("22");
            sizeUpDown_Font.Items.Add("20");
            sizeUpDown_Font.Items.Add("18");
            sizeUpDown_Font.Items.Add("16");
            sizeUpDown_Font.Items.Add("14");
            sizeUpDown_Font.Items.Add("12");
            sizeUpDown_Font.Items.Add("11");
            sizeUpDown_Font.Items.Add("10");
            sizeUpDown_Font.Items.Add("9");
            sizeUpDown_Font.Items.Add("8");
            sizeUpDown_Font.Location = new Point(3, 29);
            sizeUpDown_Font.Margin = new Padding(3, 4, 3, 4);
            sizeUpDown_Font.Name = "sizeUpDown_Font";
            sizeUpDown_Font.Size = new Size(87, 30);
            sizeUpDown_Font.TabIndex = 1;
            sizeUpDown_Font.Text = "12";
            sizeUpDown_Font.TextAlign = HorizontalAlignment.Center;
            sizeUpDown_Font.SelectedItemChanged += sizeUpDown_Font_SelectedItemChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(7, 5);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 10;
            label5.Text = "Color:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 5);
            label4.Name = "label4";
            label4.Size = new Size(41, 23);
            label4.TabIndex = 9;
            label4.Text = "Size:";
            // 
            // buttonFontColor
            // 
            buttonFontColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFontColor.Controls.Add(panelFontColorSwatch);
            buttonFontColor.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFontColor.Location = new Point(2, 28);
            buttonFontColor.Margin = new Padding(3, 4, 3, 4);
            buttonFontColor.Name = "buttonFontColor";
            buttonFontColor.Size = new Size(99, 40);
            buttonFontColor.TabIndex = 15;
            buttonFontColor.Text = "│ ▾";
            buttonFontColor.TextAlign = ContentAlignment.MiddleRight;
            buttonFontColor.UseVisualStyleBackColor = true;
            buttonFontColor.Click += buttonFontColor_Click;
            // 
            // panelFontColorSwatch
            // 
            panelFontColorSwatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFontColorSwatch.BackColor = Color.Green;
            panelFontColorSwatch.BorderStyle = BorderStyle.FixedSingle;
            panelFontColorSwatch.Location = new Point(4, 5);
            panelFontColorSwatch.Margin = new Padding(3, 4, 3, 4);
            panelFontColorSwatch.Name = "panelFontColorSwatch";
            panelFontColorSwatch.Size = new Size(58, 30);
            panelFontColorSwatch.TabIndex = 3;
            panelFontColorSwatch.Click += buttonFontColor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 3);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 5;
            label2.Text = "Font:";
            // 
            // comboBoxFontPropertySelection
            // 
            comboBoxFontPropertySelection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxFontPropertySelection.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxFontPropertySelection.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxFontPropertySelection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFontPropertySelection.FormattingEnabled = true;
            comboBoxFontPropertySelection.Location = new Point(14, 28);
            comboBoxFontPropertySelection.Margin = new Padding(3, 4, 3, 4);
            comboBoxFontPropertySelection.Name = "comboBoxFontPropertySelection";
            comboBoxFontPropertySelection.Size = new Size(336, 31);
            comboBoxFontPropertySelection.TabIndex = 6;
            comboBoxFontPropertySelection.SelectionChangeCommitted += comboBoxFontPropertySelection_SelectionChangeCommitted;
            // 
            // colorPickerDialog
            // 
            colorPickerDialog.AnyColor = true;
            colorPickerDialog.FullOpen = true;
            // 
            // fontPickerDialog
            // 
            fontPickerDialog.Color = Color.FromArgb(182, 246, 240);
            // 
            // windowsuiMockupControl
            // 
            windowsuiMockupControl.ActiveBorderColor = Color.Gray;
            windowsuiMockupControl.ActiveTitleColor = SystemColors.ActiveCaption;
            windowsuiMockupControl.ActiveTitleGradientColor = SystemColors.GradientActiveCaption;
            windowsuiMockupControl.ActiveTitleTextColor = SystemColors.ActiveCaptionText;
            windowsuiMockupControl.AutoValidate = AutoValidate.EnablePreventFocusChange;
            windowsuiMockupControl.BackColor = SystemColors.Desktop;
            windowsuiMockupControl.ButtonFaceColor = SystemColors.Control;
            windowsuiMockupControl.ButtonTextColor = SystemColors.ControlText;
            windowsuiMockupControl.CaptionFont = null;
            windowsuiMockupControl.DesktopBackgroundColor = SystemColors.Desktop;
            windowsuiMockupControl.GrayTextColor = SystemColors.ControlText;
            windowsuiMockupControl.HilightColor = SystemColors.Highlight;
            windowsuiMockupControl.HilightTextColor = SystemColors.HighlightText;
            windowsuiMockupControl.HotTrackingColor = SystemColors.HotTrack;
            windowsuiMockupControl.IconFont = null;
            windowsuiMockupControl.InactiveBorderColor = Color.Silver;
            windowsuiMockupControl.InactiveTitleColor = SystemColors.InactiveCaption;
            windowsuiMockupControl.InactiveTitleGradientColor = SystemColors.GradientInactiveCaption;
            windowsuiMockupControl.InactiveTitleTextColor = SystemColors.InactiveCaptionText;
            windowsuiMockupControl.InfoTextColor = SystemColors.InfoText;
            windowsuiMockupControl.InfoWindowColor = SystemColors.Info;
            windowsuiMockupControl.Location = new Point(0, 0);
            windowsuiMockupControl.Margin = new Padding(0);
            windowsuiMockupControl.MaximumSize = new Size(570, 473);
            windowsuiMockupControl.MenuColor = SystemColors.Menu;
            windowsuiMockupControl.MenuFont = null;
            windowsuiMockupControl.MenuHighlightColor = SystemColors.MenuHighlight;
            windowsuiMockupControl.MenuTextColor = SystemColors.MenuText;
            windowsuiMockupControl.MessageFont = null;
            windowsuiMockupControl.MinimumSize = new Size(570, 434);
            windowsuiMockupControl.Name = "windowsuiMockupControl";
            windowsuiMockupControl.ScrollbarColor = SystemColors.Window;
            windowsuiMockupControl.Size = new Size(570, 473);
            windowsuiMockupControl.SmCaptionFont = null;
            windowsuiMockupControl.StatusFont = null;
            windowsuiMockupControl.TabIndex = 2;
            windowsuiMockupControl.WindowColor = SystemColors.Window;
            windowsuiMockupControl.WindowFrameColor = Color.Black;
            windowsuiMockupControl.WindowTextColor = SystemColors.ControlText;
            windowsuiMockupControl.ColorUiElementClicked += WindowsuiMockupControl_ColorUiElementClicked;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(windowsuiMockupControl);
            flowLayoutPanel1.Controls.Add(panelBottomControls);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(8, 3);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(570, 639);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panelPropertyFontColor
            // 
            panelPropertyFontColor.Controls.Add(label5);
            panelPropertyFontColor.Controls.Add(buttonFontColor);
            panelPropertyFontColor.Enabled = false;
            panelPropertyFontColor.Location = new Point(99, 0);
            panelPropertyFontColor.Name = "panelPropertyFontColor";
            panelPropertyFontColor.Size = new Size(107, 72);
            panelPropertyFontColor.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(582, 649);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            Padding = new Padding(2, 3, 2, 3);
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Control Freak - Total Windows Customization";
            Load += MainForm_Load;
            panelBottomControls.ResumeLayout(false);
            PanelColorPropertyControls.ResumeLayout(false);
            PanelColorPropertyControls.PerformLayout();
            panelPropertyColorsControls.ResumeLayout(false);
            panelPropertyColorsControls.PerformLayout();
            panelPropertyColor2.ResumeLayout(false);
            panelPropertyColor2.PerformLayout();
            buttonPropertyColor2.ResumeLayout(false);
            buttonPropertyColor1.ResumeLayout(false);
            PanelFontPropertyControls.ResumeLayout(false);
            PanelFontPropertyControls.PerformLayout();
            panelFontColorsControls.ResumeLayout(false);
            panelFontColorsControls.PerformLayout();
            buttonFontColor.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panelPropertyFontColor.ResumeLayout(false);
            panelPropertyFontColor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelBottomControls;
        private ComboBox comboBoxColorPropertySelection;
        private DomainUpDown sizeUpDown_Font;
        private ColorDialog colorPickerDialog;
        private ComboBox comboBoxFontPropertySelection;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private FontDialog fontPickerDialog;
        private Button buttonPropertyColor1;
        private Label label6;
        private Button buttonFontColor;
        private Panel panelPropertyColorSwatch1;
        private Panel panelFontColorSwatch;
        private Panel panelPropertyColorsControls;
        private Panel PanelFontPropertyControls;
        private Panel PanelColorPropertyControls;
        private Panel panelFontColorsControls;
        private Panel panelPropertyColor2;
        private Label label3;
        private Button buttonPropertyColor2;
        private Panel panelPropertyColorSwatch2;
        private WindowsUIMockupControl windowsuiMockupControl;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelPropertyFontColor;
    }
}
