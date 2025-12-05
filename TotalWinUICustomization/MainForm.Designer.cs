using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using OverlayControlsLibrary;

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
            panelColorPropertyLeft = new Panel();
            label1 = new Label();
            comboBoxColorPropertySelection = new ComboBox();
            font_ClickInterceptorBox = new ClickInterceptorBox();
            flowLayoutPanelColor = new FlowLayoutPanel();
            panelColorPropertyRight = new Panel();
            panelColorProperty1 = new Panel();
            label6 = new Label();
            buttonColorProperty1 = new Button();
            panelColorPropertySwatch1 = new Panel();
            panelColorProperty2 = new Panel();
            label3 = new Label();
            buttonColorProperty2 = new Button();
            panelColorPropertySwatch2 = new Panel();
            label7 = new Label();
            panelFontPropertyRight = new Panel();
            checkBoxFontItalic = new CheckBox();
            comboFontSize = new ComboBox();
            checkBoxFontBold = new CheckBox();
            label4 = new Label();
            panelFontPropertyLeft = new Panel();
            label2 = new Label();
            comboBoxFontPropertySelection = new ComboBox();
            panelFontProperty = new Panel();
            thatchedPanel1 = new ThatchedPanel();
            label8 = new Label();
            panelInnerFontProperty = new Panel();
            panelFontPropertyColor = new Panel();
            label5 = new Label();
            buttonFontColor = new Button();
            panelFontColorSwatch = new Panel();
            colorPickerDialog = new ColorDialog();
            fontPickerDialog = new FontDialog();
            windowsuiMockupControl = new WindowsUIMockupControl();
            flowLayoutPanelMain = new FlowLayoutPanel();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            panelColorPropertyLeft.SuspendLayout();
            flowLayoutPanelColor.SuspendLayout();
            panelColorPropertyRight.SuspendLayout();
            panelColorProperty1.SuspendLayout();
            buttonColorProperty1.SuspendLayout();
            panelColorProperty2.SuspendLayout();
            buttonColorProperty2.SuspendLayout();
            panelFontPropertyRight.SuspendLayout();
            panelFontPropertyLeft.SuspendLayout();
            panelFontProperty.SuspendLayout();
            thatchedPanel1.SuspendLayout();
            panelInnerFontProperty.SuspendLayout();
            panelFontPropertyColor.SuspendLayout();
            buttonFontColor.SuspendLayout();
            flowLayoutPanelMain.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelColorPropertyLeft
            // 
            panelColorPropertyLeft.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelColorPropertyLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelColorPropertyLeft.Controls.Add(label1);
            panelColorPropertyLeft.Controls.Add(comboBoxColorPropertySelection);
            panelColorPropertyLeft.Location = new Point(0, 0);
            panelColorPropertyLeft.Margin = new Padding(0);
            panelColorPropertyLeft.Name = "panelColorPropertyLeft";
            panelColorPropertyLeft.Size = new Size(336, 52);
            panelColorPropertyLeft.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "Item:";
            // 
            // comboBoxColorPropertySelection
            // 
            comboBoxColorPropertySelection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxColorPropertySelection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColorPropertySelection.FormattingEnabled = true;
            comboBoxColorPropertySelection.Location = new Point(11, 18);
            comboBoxColorPropertySelection.Margin = new Padding(2);
            comboBoxColorPropertySelection.Name = "comboBoxColorPropertySelection";
            comboBoxColorPropertySelection.Size = new Size(313, 23);
            comboBoxColorPropertySelection.TabIndex = 0;
            comboBoxColorPropertySelection.SelectionChangeCommitted += comboBoxColorPropertySelection_SelectionChangeCommitted;
            // 
            // font_ClickInterceptorBox
            // 
            font_ClickInterceptorBox.CausesValidation = false;
            font_ClickInterceptorBox.Location = new Point(1, 20);
            font_ClickInterceptorBox.Name = "font_ClickInterceptorBox";
            font_ClickInterceptorBox.Size = new Size(397, 24);
            font_ClickInterceptorBox.TabIndex = 7;
            font_ClickInterceptorBox.TabStop = false;
            font_ClickInterceptorBox.Click += font_ClickInterceptorBox_Click;
            // 
            // flowLayoutPanelColor
            // 
            flowLayoutPanelColor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelColor.Controls.Add(panelColorPropertyLeft);
            flowLayoutPanelColor.Controls.Add(panelColorPropertyRight);
            flowLayoutPanelColor.Location = new Point(0, 0);
            flowLayoutPanelColor.Margin = new Padding(0);
            flowLayoutPanelColor.Name = "flowLayoutPanelColor";
            flowLayoutPanelColor.Size = new Size(530, 52);
            flowLayoutPanelColor.TabIndex = 0;
            // 
            // panelColorPropertyRight
            // 
            panelColorPropertyRight.Controls.Add(panelColorProperty1);
            panelColorPropertyRight.Controls.Add(panelColorProperty2);
            panelColorPropertyRight.Location = new Point(336, 0);
            panelColorPropertyRight.Margin = new Padding(0);
            panelColorPropertyRight.Name = "panelColorPropertyRight";
            panelColorPropertyRight.Size = new Size(149, 52);
            panelColorPropertyRight.TabIndex = 20;
            // 
            // panelColorProperty1
            // 
            panelColorProperty1.Controls.Add(label6);
            panelColorProperty1.Controls.Add(buttonColorProperty1);
            panelColorProperty1.Location = new Point(0, 0);
            panelColorProperty1.Margin = new Padding(0);
            panelColorProperty1.Name = "panelColorProperty1";
            panelColorProperty1.Size = new Size(74, 52);
            panelColorProperty1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 3);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 13;
            label6.Text = "Color 1:";
            // 
            // buttonColorProperty1
            // 
            buttonColorProperty1.Controls.Add(panelColorPropertySwatch1);
            buttonColorProperty1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonColorProperty1.Location = new Point(4, 18);
            buttonColorProperty1.Margin = new Padding(2);
            buttonColorProperty1.MaximumSize = new Size(63, 27);
            buttonColorProperty1.MinimumSize = new Size(63, 27);
            buttonColorProperty1.Name = "buttonColorProperty1";
            buttonColorProperty1.Size = new Size(63, 27);
            buttonColorProperty1.TabIndex = 11;
            buttonColorProperty1.Text = "│▾";
            buttonColorProperty1.TextAlign = ContentAlignment.MiddleRight;
            buttonColorProperty1.UseVisualStyleBackColor = true;
            buttonColorProperty1.Click += buttonPropertyColor1_Click;
            // 
            // panelColorPropertySwatch1
            // 
            panelColorPropertySwatch1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelColorPropertySwatch1.BorderStyle = BorderStyle.FixedSingle;
            panelColorPropertySwatch1.Location = new Point(4, 3);
            panelColorPropertySwatch1.Margin = new Padding(0);
            panelColorPropertySwatch1.MaximumSize = new Size(34, 22);
            panelColorPropertySwatch1.MinimumSize = new Size(34, 22);
            panelColorPropertySwatch1.Name = "panelColorPropertySwatch1";
            panelColorPropertySwatch1.Size = new Size(34, 22);
            panelColorPropertySwatch1.TabIndex = 0;
            panelColorPropertySwatch1.Click += buttonPropertyColor1_Click;
            // 
            // panelColorProperty2
            // 
            panelColorProperty2.Controls.Add(label3);
            panelColorProperty2.Controls.Add(buttonColorProperty2);
            panelColorProperty2.Location = new Point(74, 0);
            panelColorProperty2.Margin = new Padding(0);
            panelColorProperty2.Name = "panelColorProperty2";
            panelColorProperty2.Size = new Size(74, 52);
            panelColorProperty2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 3);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 17;
            label3.Text = "Color 2:";
            // 
            // buttonColorProperty2
            // 
            buttonColorProperty2.Controls.Add(panelColorPropertySwatch2);
            buttonColorProperty2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonColorProperty2.Location = new Point(4, 18);
            buttonColorProperty2.Margin = new Padding(2);
            buttonColorProperty2.MaximumSize = new Size(63, 27);
            buttonColorProperty2.MinimumSize = new Size(63, 27);
            buttonColorProperty2.Name = "buttonColorProperty2";
            buttonColorProperty2.Size = new Size(63, 27);
            buttonColorProperty2.TabIndex = 0;
            buttonColorProperty2.Text = "│▾";
            buttonColorProperty2.TextAlign = ContentAlignment.MiddleRight;
            buttonColorProperty2.UseVisualStyleBackColor = true;
            // 
            // panelColorPropertySwatch2
            // 
            panelColorPropertySwatch2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelColorPropertySwatch2.BorderStyle = BorderStyle.FixedSingle;
            panelColorPropertySwatch2.Location = new Point(4, 3);
            panelColorPropertySwatch2.Margin = new Padding(0);
            panelColorPropertySwatch2.MaximumSize = new Size(34, 22);
            panelColorPropertySwatch2.MinimumSize = new Size(34, 22);
            panelColorPropertySwatch2.Name = "panelColorPropertySwatch2";
            panelColorPropertySwatch2.Size = new Size(34, 22);
            panelColorPropertySwatch2.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 0;
            label7.Text = "Please use font properties dialog";
            // 
            // panelFontPropertyRight
            // 
            panelFontPropertyRight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFontPropertyRight.Controls.Add(checkBoxFontItalic);
            panelFontPropertyRight.Controls.Add(comboFontSize);
            panelFontPropertyRight.Controls.Add(checkBoxFontBold);
            panelFontPropertyRight.Controls.Add(label4);
            panelFontPropertyRight.Location = new Point(336, 0);
            panelFontPropertyRight.Margin = new Padding(0);
            panelFontPropertyRight.Name = "panelFontPropertyRight";
            panelFontPropertyRight.Size = new Size(120, 52);
            panelFontPropertyRight.TabIndex = 8;
            // 
            // checkBoxFontItalic
            // 
            checkBoxFontItalic.Appearance = Appearance.Button;
            checkBoxFontItalic.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxFontItalic.Checked = true;
            checkBoxFontItalic.CheckState = CheckState.Checked;
            checkBoxFontItalic.FlatAppearance.BorderSize = 2;
            checkBoxFontItalic.FlatStyle = FlatStyle.System;
            checkBoxFontItalic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBoxFontItalic.Location = new Point(92, 20);
            checkBoxFontItalic.Margin = new Padding(0);
            checkBoxFontItalic.Name = "checkBoxFontItalic";
            checkBoxFontItalic.Size = new Size(26, 22);
            checkBoxFontItalic.TabIndex = 12;
            checkBoxFontItalic.Text = "/";
            checkBoxFontItalic.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxFontItalic.UseVisualStyleBackColor = true;
            checkBoxFontItalic.CheckedChanged += checkBoxFontStyle_CheckedChanged;
            // 
            // comboFontSize
            // 
            comboFontSize.FormattingEnabled = true;
            comboFontSize.Items.AddRange(new object[] { "72", "48", "36", "28", "26", "24", "22", "20", "18", "16", "14", "12", "11", "10", "9", "8" });
            comboFontSize.Location = new Point(5, 21);
            comboFontSize.Margin = new Padding(3, 2, 3, 2);
            comboFontSize.Name = "comboFontSize";
            comboFontSize.Size = new Size(54, 23);
            comboFontSize.TabIndex = 11;
            comboFontSize.Text = "9";
            comboFontSize.SelectedIndexChanged += comboFontSize_SelectedItemChanged;
            comboFontSize.TextChanged += comboFontSize_TextChanged;
            // 
            // checkBoxFontBold
            // 
            checkBoxFontBold.Appearance = Appearance.Button;
            checkBoxFontBold.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxFontBold.Checked = true;
            checkBoxFontBold.CheckState = CheckState.Checked;
            checkBoxFontBold.FlatAppearance.BorderSize = 2;
            checkBoxFontBold.FlatStyle = FlatStyle.System;
            checkBoxFontBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxFontBold.Location = new Point(66, 20);
            checkBoxFontBold.Margin = new Padding(0);
            checkBoxFontBold.Name = "checkBoxFontBold";
            checkBoxFontBold.Size = new Size(26, 22);
            checkBoxFontBold.TabIndex = 10;
            checkBoxFontBold.Text = "B";
            checkBoxFontBold.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxFontBold.UseVisualStyleBackColor = true;
            checkBoxFontBold.CheckedChanged += checkBoxFontStyle_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 3);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 9;
            label4.Text = "Size:";
            // 
            // panelFontPropertyLeft
            // 
            panelFontPropertyLeft.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFontPropertyLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFontPropertyLeft.Controls.Add(label2);
            panelFontPropertyLeft.Controls.Add(comboBoxFontPropertySelection);
            panelFontPropertyLeft.Location = new Point(0, 0);
            panelFontPropertyLeft.Margin = new Padding(0);
            panelFontPropertyLeft.Name = "panelFontPropertyLeft";
            panelFontPropertyLeft.Size = new Size(336, 52);
            panelFontPropertyLeft.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
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
            comboBoxFontPropertySelection.Location = new Point(11, 20);
            comboBoxFontPropertySelection.Margin = new Padding(2);
            comboBoxFontPropertySelection.Name = "comboBoxFontPropertySelection";
            comboBoxFontPropertySelection.Size = new Size(316, 23);
            comboBoxFontPropertySelection.TabIndex = 6;
            comboBoxFontPropertySelection.SelectionChangeCommitted += comboBoxFontPropertySelection_SelectionChangeCommitted;
            // 
            // panelFontProperty
            // 
            panelFontProperty.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFontProperty.Controls.Add(panelInnerFontProperty);
            panelFontProperty.Controls.Add(thatchedPanel1);
            panelFontProperty.Location = new Point(0, 52);
            panelFontProperty.Margin = new Padding(0);
            panelFontProperty.Name = "panelFontProperty";
            panelFontProperty.Size = new Size(530, 52);
            panelFontProperty.TabIndex = 7;
            // 
            // thatchedPanel1
            // 
            thatchedPanel1.Controls.Add(label8);
            thatchedPanel1.ForeColor = Color.Gray;
            thatchedPanel1.HatchingStyle = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
            thatchedPanel1.Location = new Point(0, 0);
            thatchedPanel1.Name = "thatchedPanel1";
            thatchedPanel1.Size = new Size(530, 52);
            thatchedPanel1.TabIndex = 8;
            thatchedPanel1.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(194, 18);
            label8.Margin = new Padding(6);
            label8.Name = "label8";
            label8.Padding = new Padding(2);
            label8.Size = new Size(141, 19);
            label8.TabIndex = 0;
            label8.Text = "Use font selection dialog";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelInnerFontProperty
            // 
            panelInnerFontProperty.Controls.Add(font_ClickInterceptorBox);
            panelInnerFontProperty.Controls.Add(panelFontPropertyLeft);
            panelInnerFontProperty.Controls.Add(panelFontPropertyRight);
            panelInnerFontProperty.Controls.Add(panelFontPropertyColor);
            panelInnerFontProperty.Location = new Point(0, 0);
            panelInnerFontProperty.Margin = new Padding(3, 2, 3, 2);
            panelInnerFontProperty.Name = "panelInnerFontProperty";
            panelInnerFontProperty.Size = new Size(530, 52);
            panelInnerFontProperty.TabIndex = 22;
            // 
            // panelFontPropertyColor
            // 
            panelFontPropertyColor.Controls.Add(label5);
            panelFontPropertyColor.Controls.Add(buttonFontColor);
            panelFontPropertyColor.Location = new Point(456, 0);
            panelFontPropertyColor.Margin = new Padding(0);
            panelFontPropertyColor.Name = "panelFontPropertyColor";
            panelFontPropertyColor.Size = new Size(74, 52);
            panelFontPropertyColor.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 3);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 16;
            label5.Text = "Color:";
            // 
            // buttonFontColor
            // 
            buttonFontColor.Controls.Add(panelFontColorSwatch);
            buttonFontColor.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFontColor.Location = new Point(4, 18);
            buttonFontColor.Margin = new Padding(2);
            buttonFontColor.MaximumSize = new Size(63, 27);
            buttonFontColor.MinimumSize = new Size(63, 27);
            buttonFontColor.Name = "buttonFontColor";
            buttonFontColor.Size = new Size(63, 27);
            buttonFontColor.TabIndex = 17;
            buttonFontColor.Text = "│▾";
            buttonFontColor.TextAlign = ContentAlignment.MiddleRight;
            buttonFontColor.UseVisualStyleBackColor = true;
            // 
            // panelFontColorSwatch
            // 
            panelFontColorSwatch.BorderStyle = BorderStyle.FixedSingle;
            panelFontColorSwatch.Location = new Point(4, 3);
            panelFontColorSwatch.Margin = new Padding(0);
            panelFontColorSwatch.MaximumSize = new Size(34, 22);
            panelFontColorSwatch.MinimumSize = new Size(34, 22);
            panelFontColorSwatch.Name = "panelFontColorSwatch";
            panelFontColorSwatch.Size = new Size(34, 22);
            panelFontColorSwatch.TabIndex = 3;
            // 
            // colorPickerDialog
            // 
            colorPickerDialog.AnyColor = true;
            colorPickerDialog.FullOpen = true;
            // 
            // fontPickerDialog
            // 
            fontPickerDialog.FontMustExist = true;
            fontPickerDialog.MaxSize = 200;
            fontPickerDialog.MinSize = 4;
            fontPickerDialog.ShowColor = true;
            // 
            // windowsuiMockupControl
            // 
            windowsuiMockupControl.ActiveBorderColor = Color.Gray;
            windowsuiMockupControl.ActiveTitleColor = SystemColors.ActiveCaption;
            windowsuiMockupControl.ActiveTitleGradientColor = SystemColors.GradientActiveCaption;
            windowsuiMockupControl.ActiveTitleTextColor = SystemColors.ActiveCaptionText;
            windowsuiMockupControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            windowsuiMockupControl.MaximumSize = new Size(570, 370);
            windowsuiMockupControl.MenuBarColor = SystemColors.Menu;
            windowsuiMockupControl.MenuFont = null;
            windowsuiMockupControl.MenuHighlightColor = SystemColors.MenuHighlight;
            windowsuiMockupControl.MenuTextColor = SystemColors.MenuText;
            windowsuiMockupControl.MessageFont = null;
            windowsuiMockupControl.MinimumSize = new Size(499, 278);
            windowsuiMockupControl.Name = "windowsuiMockupControl";
            windowsuiMockupControl.ScrollbarColor = SystemColors.Window;
            windowsuiMockupControl.Size = new Size(570, 370);
            windowsuiMockupControl.SmCaptionFont = null;
            windowsuiMockupControl.StatusFont = null;
            windowsuiMockupControl.TabIndex = 1;
            windowsuiMockupControl.WindowColor = SystemColors.Window;
            windowsuiMockupControl.WindowFrameColor = Color.Black;
            windowsuiMockupControl.WindowTextColor = SystemColors.ControlText;
            windowsuiMockupControl.ColorUiElementClicked += WindowsuiMockupControl_ColorUiElementClicked;
            // 
            // flowLayoutPanelMain
            // 
            flowLayoutPanelMain.AutoSize = true;
            flowLayoutPanelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelMain.Controls.Add(windowsuiMockupControl);
            flowLayoutPanelMain.Controls.Add(flowLayoutPanelBottom);
            flowLayoutPanelMain.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelMain.Location = new Point(0, 5);
            flowLayoutPanelMain.Margin = new Padding(0);
            flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            flowLayoutPanelMain.Size = new Size(570, 481);
            flowLayoutPanelMain.TabIndex = 4;
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelBottom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelBottom.Controls.Add(flowLayoutPanelColor);
            flowLayoutPanelBottom.Controls.Add(panelFontProperty);
            flowLayoutPanelBottom.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelBottom.Location = new Point(0, 370);
            flowLayoutPanelBottom.Margin = new Padding(0);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Size = new Size(570, 111);
            flowLayoutPanelBottom.TabIndex = 20;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(572, 488);
            Controls.Add(flowLayoutPanelMain);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainForm";
            Padding = new Padding(3, 2, 3, 2);
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Control Freak - Total Windows Customization";
            Load += MainForm_Load;
            panelColorPropertyLeft.ResumeLayout(false);
            panelColorPropertyLeft.PerformLayout();
            flowLayoutPanelColor.ResumeLayout(false);
            panelColorPropertyRight.ResumeLayout(false);
            panelColorProperty1.ResumeLayout(false);
            panelColorProperty1.PerformLayout();
            buttonColorProperty1.ResumeLayout(false);
            panelColorProperty2.ResumeLayout(false);
            panelColorProperty2.PerformLayout();
            buttonColorProperty2.ResumeLayout(false);
            panelFontPropertyRight.ResumeLayout(false);
            panelFontPropertyRight.PerformLayout();
            panelFontPropertyLeft.ResumeLayout(false);
            panelFontPropertyLeft.PerformLayout();
            panelFontProperty.ResumeLayout(false);
            thatchedPanel1.ResumeLayout(false);
            thatchedPanel1.PerformLayout();
            panelInnerFontProperty.ResumeLayout(false);
            panelFontPropertyColor.ResumeLayout(false);
            panelFontPropertyColor.PerformLayout();
            buttonFontColor.ResumeLayout(false);
            flowLayoutPanelMain.ResumeLayout(false);
            flowLayoutPanelBottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxColorPropertySelection;
        private ColorDialog colorPickerDialog;
        private ComboBox comboBoxFontPropertySelection;
        private Label label2;
        private Label label1;
        private Label label4;
        private FontDialog fontPickerDialog;
        private Button buttonColorProperty1;
        private Label label6;
        private Panel panelColorPropertySwatch1;
        private WindowsUIMockupControl windowsuiMockupControl;
        private FlowLayoutPanel flowLayoutPanelMain;
        private Panel panelColorProperty1;
        private FlowLayoutPanel flowLayoutPanelColor;
        private Panel panelFontProperty;
        private Panel panelFontPropertyRight;
        private Panel panelColorPropertyLeft;
        private Panel panelFontPropertyLeft;
        private CheckBox checkBoxFontBold;
        private ComboBox comboFontSize;
        private ClickInterceptorBox font_ClickInterceptorBox;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private CheckBox checkBoxFontItalic;
        private Panel panelColorPropertyRight;
        private Panel panelColorProperty2;
        private Label label3;
        private Button buttonColorProperty2;
        private Panel panelColorPropertySwatch2;
        private Panel panelFontPropertyColor;
        private Label label5;
        private Button buttonFontColor;
        private Panel panelFontColorSwatch;
        private Panel panelInnerFontProperty;
        private ThatchedPanel thatchedPanel1;
        private Label label7;
        private Label label8;
    }
}
