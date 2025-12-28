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
            this.panelColorPropertyLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColorPropertySelection = new System.Windows.Forms.ComboBox();
            this.font_ClickInterceptorBox = new OverlayControlsLibrary.ClickInterceptorBox();
            this.flowLayoutPanelColor = new System.Windows.Forms.FlowLayoutPanel();
            this.panelColorPropertyRight = new System.Windows.Forms.Panel();
            this.panelColorProperty1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonColorProperty1 = new System.Windows.Forms.Button();
            this.panelColorPropertySwatch1 = new System.Windows.Forms.Panel();
            this.panelColorProperty2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonColorProperty2 = new System.Windows.Forms.Button();
            this.panelColorPropertySwatch2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelFontPropertyRight = new System.Windows.Forms.Panel();
            this.checkBoxFontItalic = new System.Windows.Forms.CheckBox();
            this.comboFontSize = new System.Windows.Forms.ComboBox();
            this.checkBoxFontBold = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFontPropertyLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFontPropertySelection = new System.Windows.Forms.ComboBox();
            this.panelFontProperty = new System.Windows.Forms.Panel();
            this.panelInnerFontProperty = new System.Windows.Forms.Panel();
            this.panelFontPropertyColor = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFontColor = new System.Windows.Forms.Button();
            this.panelFontColorSwatch = new System.Windows.Forms.Panel();
            this.thatchedPanel1 = new OverlayControlsLibrary.ThatchedPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.colorPickerDialog = new System.Windows.Forms.ColorDialog();
            this.fontPickerDialog = new System.Windows.Forms.FontDialog();
            this.windowsuiMockupControl = new TotalWinUICustomization.WindowsUIMockupControl();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.panelColorPropertyLeft.SuspendLayout();
            this.flowLayoutPanelColor.SuspendLayout();
            this.panelColorPropertyRight.SuspendLayout();
            this.panelColorProperty1.SuspendLayout();
            this.buttonColorProperty1.SuspendLayout();
            this.panelColorProperty2.SuspendLayout();
            this.buttonColorProperty2.SuspendLayout();
            this.panelFontPropertyRight.SuspendLayout();
            this.panelFontPropertyLeft.SuspendLayout();
            this.panelFontProperty.SuspendLayout();
            this.panelInnerFontProperty.SuspendLayout();
            this.panelFontPropertyColor.SuspendLayout();
            this.buttonFontColor.SuspendLayout();
            this.thatchedPanel1.SuspendLayout();
            this.flowLayoutPanelMain.SuspendLayout();
            this.flowLayoutPanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColorPropertyLeft
            // 
            this.panelColorPropertyLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColorPropertyLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelColorPropertyLeft.Controls.Add(this.label1);
            this.panelColorPropertyLeft.Controls.Add(this.comboBoxColorPropertySelection);
            this.panelColorPropertyLeft.Location = new System.Drawing.Point(0, 0);
            this.panelColorPropertyLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelColorPropertyLeft.Name = "panelColorPropertyLeft";
            this.panelColorPropertyLeft.Size = new System.Drawing.Size(288, 45);
            this.panelColorPropertyLeft.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item:";
            // 
            // comboBoxColorPropertySelection
            // 
            this.comboBoxColorPropertySelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColorPropertySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColorPropertySelection.FormattingEnabled = true;
            this.comboBoxColorPropertySelection.Location = new System.Drawing.Point(9, 16);
            this.comboBoxColorPropertySelection.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxColorPropertySelection.Name = "comboBoxColorPropertySelection";
            this.comboBoxColorPropertySelection.Size = new System.Drawing.Size(269, 21);
            // 
            // font_ClickInterceptorBox
            // 
            this.font_ClickInterceptorBox.CausesValidation = false;
            this.font_ClickInterceptorBox.Location = new System.Drawing.Point(1, 17);
            this.font_ClickInterceptorBox.Name = "font_ClickInterceptorBox";
            this.font_ClickInterceptorBox.Size = new System.Drawing.Size(340, 21);
            this.font_ClickInterceptorBox.TabIndex = 7;
            this.font_ClickInterceptorBox.TabStop = false;
            // 
            // flowLayoutPanelColor
            // 
            this.flowLayoutPanelColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelColor.Controls.Add(this.panelColorPropertyLeft);
            this.flowLayoutPanelColor.Controls.Add(this.panelColorPropertyRight);
            this.flowLayoutPanelColor.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelColor.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelColor.Name = "flowLayoutPanelColor";
            this.flowLayoutPanelColor.Size = new System.Drawing.Size(454, 45);
            this.flowLayoutPanelColor.TabIndex = 0;
            // 
            // panelColorPropertyRight
            // 
            this.panelColorPropertyRight.Controls.Add(this.panelColorProperty1);
            this.panelColorPropertyRight.Controls.Add(this.panelColorProperty2);
            this.panelColorPropertyRight.Location = new System.Drawing.Point(288, 0);
            this.panelColorPropertyRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelColorPropertyRight.Name = "panelColorPropertyRight";
            this.panelColorPropertyRight.Size = new System.Drawing.Size(128, 45);
            this.panelColorPropertyRight.TabIndex = 20;
            // 
            // panelColorProperty1
            // 
            this.panelColorProperty1.Controls.Add(this.label6);
            this.panelColorProperty1.Controls.Add(this.buttonColorProperty1);
            this.panelColorProperty1.Location = new System.Drawing.Point(0, 0);
            this.panelColorProperty1.Margin = new System.Windows.Forms.Padding(0);
            this.panelColorProperty1.Name = "panelColorProperty1";
            this.panelColorProperty1.Size = new System.Drawing.Size(63, 45);
            this.panelColorProperty1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Color 1:";
            // 
            // buttonColorProperty1
            // 
            this.buttonColorProperty1.Controls.Add(this.panelColorPropertySwatch1);
            this.buttonColorProperty1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColorProperty1.Location = new System.Drawing.Point(3, 16);
            this.buttonColorProperty1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonColorProperty1.MaximumSize = new System.Drawing.Size(54, 23);
            this.buttonColorProperty1.MinimumSize = new System.Drawing.Size(54, 23);
            this.buttonColorProperty1.Name = "buttonColorProperty1";
            this.buttonColorProperty1.Size = new System.Drawing.Size(54, 23);
            this.buttonColorProperty1.TabIndex = 11;
            this.buttonColorProperty1.Text = "│▾";
            this.buttonColorProperty1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonColorProperty1.UseVisualStyleBackColor = true;
            // 
            // panelColorPropertySwatch1
            // 
            this.panelColorPropertySwatch1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColorPropertySwatch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorPropertySwatch1.Location = new System.Drawing.Point(3, 3);
            this.panelColorPropertySwatch1.Margin = new System.Windows.Forms.Padding(0);
            this.panelColorPropertySwatch1.MaximumSize = new System.Drawing.Size(29, 19);
            this.panelColorPropertySwatch1.MinimumSize = new System.Drawing.Size(29, 19);
            this.panelColorPropertySwatch1.Name = "panelColorPropertySwatch1";
            this.panelColorPropertySwatch1.TabIndex = 0;
            // 
            // panelColorProperty2
            // 
            this.panelColorProperty2.Controls.Add(this.label3);
            this.panelColorProperty2.Controls.Add(this.buttonColorProperty2);
            this.panelColorProperty2.Location = new System.Drawing.Point(63, 0);
            this.panelColorProperty2.Margin = new System.Windows.Forms.Padding(0);
            this.panelColorProperty2.Name = "panelColorProperty2";
            this.panelColorProperty2.Size = new System.Drawing.Size(63, 45);
            this.panelColorProperty2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Color 2:";
            // 
            // buttonColorProperty2
            // 
            this.buttonColorProperty2.Controls.Add(this.panelColorPropertySwatch2);
            this.buttonColorProperty2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColorProperty2.Location = new System.Drawing.Point(3, 16);
            this.buttonColorProperty2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonColorProperty2.MaximumSize = new System.Drawing.Size(54, 23);
            this.buttonColorProperty2.MinimumSize = new System.Drawing.Size(54, 23);
            this.buttonColorProperty2.Name = "buttonColorProperty2";
            this.buttonColorProperty2.Size = new System.Drawing.Size(54, 23);
            this.buttonColorProperty2.TabIndex = 0;
            this.buttonColorProperty2.Text = "│▾";
            this.buttonColorProperty2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonColorProperty2.UseVisualStyleBackColor = true;
            // 
            // panelColorPropertySwatch2
            // 
            this.panelColorPropertySwatch2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColorPropertySwatch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorPropertySwatch2.Location = new System.Drawing.Point(3, 3);
            this.panelColorPropertySwatch2.Margin = new System.Windows.Forms.Padding(0);
            this.panelColorPropertySwatch2.MaximumSize = new System.Drawing.Size(29, 19);
            this.panelColorPropertySwatch2.MinimumSize = new System.Drawing.Size(29, 19);
            this.panelColorPropertySwatch2.Name = "panelColorPropertySwatch2";
            this.panelColorPropertySwatch2.Size = new System.Drawing.Size(29, 19);
            this.panelColorPropertySwatch2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Please use font properties dialog";
            // 
            // panelFontPropertyRight
            // 
            this.panelFontPropertyRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFontPropertyRight.Controls.Add(this.checkBoxFontItalic);
            this.panelFontPropertyRight.Controls.Add(this.comboFontSize);
            this.panelFontPropertyRight.Controls.Add(this.checkBoxFontBold);
            this.panelFontPropertyRight.Controls.Add(this.label4);
            this.panelFontPropertyRight.Location = new System.Drawing.Point(288, 0);
            this.panelFontPropertyRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelFontPropertyRight.Name = "panelFontPropertyRight";
            this.panelFontPropertyRight.Size = new System.Drawing.Size(103, 45);
            this.panelFontPropertyRight.TabIndex = 8;
            // 
            // checkBoxFontItalic
            // 
            this.checkBoxFontItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxFontItalic.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxFontItalic.Checked = true;
            this.checkBoxFontItalic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFontItalic.FlatAppearance.BorderSize = 2;
            this.checkBoxFontItalic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxFontItalic.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFontItalic.Location = new System.Drawing.Point(79, 17);
            this.checkBoxFontItalic.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxFontItalic.Name = "checkBoxFontItalic";
            this.checkBoxFontItalic.Size = new System.Drawing.Size(22, 19);
            this.checkBoxFontItalic.TabIndex = 12;
            this.checkBoxFontItalic.Text = "/";
            this.checkBoxFontItalic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxFontItalic.UseVisualStyleBackColor = true;
            // 
            // comboFontSize
            // 
            this.comboFontSize.FormattingEnabled = true;
            this.comboFontSize.Items.AddRange(new object[] {
            "72",
            "48",
            "36",
            "28",
            "26",
            "24",
            "22",
            "20",
            "18",
            "16",
            "14",
            "12",
            "11",
            "10",
            "9",
            "8"});
            this.comboFontSize.Location = new System.Drawing.Point(4, 18);
            this.comboFontSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboFontSize.Name = "comboFontSize";
            this.comboFontSize.Size = new System.Drawing.Size(47, 21);
            this.comboFontSize.TabIndex = 11;
            this.comboFontSize.Text = "9";
            // 
            // checkBoxFontBold
            // 
            this.checkBoxFontBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxFontBold.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxFontBold.Checked = true;
            this.checkBoxFontBold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFontBold.FlatAppearance.BorderSize = 2;
            this.checkBoxFontBold.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxFontBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFontBold.Location = new System.Drawing.Point(57, 17);
            this.checkBoxFontBold.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxFontBold.Name = "checkBoxFontBold";
            this.checkBoxFontBold.Size = new System.Drawing.Size(22, 19);
            this.checkBoxFontBold.TabIndex = 10;
            this.checkBoxFontBold.Text = "B";
            this.checkBoxFontBold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxFontBold.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Size:";
            // 
            // panelFontPropertyLeft
            // 
            this.panelFontPropertyLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFontPropertyLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFontPropertyLeft.Controls.Add(this.label2);
            this.panelFontPropertyLeft.Controls.Add(this.comboBoxFontPropertySelection);
            this.panelFontPropertyLeft.Location = new System.Drawing.Point(0, 0);
            this.panelFontPropertyLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelFontPropertyLeft.Name = "panelFontPropertyLeft";
            this.panelFontPropertyLeft.Size = new System.Drawing.Size(288, 45);
            this.panelFontPropertyLeft.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Font:";
            // 
            // comboBoxFontPropertySelection
            // 
            this.comboBoxFontPropertySelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFontPropertySelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxFontPropertySelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFontPropertySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontPropertySelection.FormattingEnabled = true;
            this.comboBoxFontPropertySelection.Location = new System.Drawing.Point(9, 17);
            this.comboBoxFontPropertySelection.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFontPropertySelection.Name = "comboBoxFontPropertySelection";
            this.comboBoxFontPropertySelection.Size = new System.Drawing.Size(271, 21);
            this.comboBoxFontPropertySelection.TabIndex = 6;
            // 
            // panelFontProperty
            // 
            this.panelFontProperty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFontProperty.Controls.Add(this.panelInnerFontProperty);
            this.panelFontProperty.Controls.Add(this.thatchedPanel1);
            this.panelFontProperty.Location = new System.Drawing.Point(0, 45);
            this.panelFontProperty.Margin = new System.Windows.Forms.Padding(0);
            this.panelFontProperty.Name = "panelFontProperty";
            this.panelFontProperty.Size = new System.Drawing.Size(454, 45);
            this.panelFontProperty.TabIndex = 7;
            // 
            // panelInnerFontProperty
            // 
            this.panelInnerFontProperty.Controls.Add(this.font_ClickInterceptorBox);
            this.panelInnerFontProperty.Controls.Add(this.panelFontPropertyLeft);
            this.panelInnerFontProperty.Controls.Add(this.panelFontPropertyRight);
            this.panelInnerFontProperty.Controls.Add(this.panelFontPropertyColor);
            this.panelInnerFontProperty.Location = new System.Drawing.Point(0, 0);
            this.panelInnerFontProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInnerFontProperty.Name = "panelInnerFontProperty";
            this.panelInnerFontProperty.Size = new System.Drawing.Size(454, 45);
            this.panelInnerFontProperty.TabIndex = 22;
            // 
            // panelFontPropertyColor
            // 
            this.panelFontPropertyColor.Controls.Add(this.label5);
            this.panelFontPropertyColor.Controls.Add(this.buttonFontColor);
            this.panelFontPropertyColor.Location = new System.Drawing.Point(391, 0);
            this.panelFontPropertyColor.Margin = new System.Windows.Forms.Padding(0);
            this.panelFontPropertyColor.Name = "panelFontPropertyColor";
            this.panelFontPropertyColor.Size = new System.Drawing.Size(63, 45);
            this.panelFontPropertyColor.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Color:";
            // 
            // buttonFontColor
            // 
            this.buttonFontColor.Controls.Add(this.panelFontColorSwatch);
            this.buttonFontColor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFontColor.Location = new System.Drawing.Point(3, 16);
            this.buttonFontColor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFontColor.MaximumSize = new System.Drawing.Size(54, 23);
            this.buttonFontColor.MinimumSize = new System.Drawing.Size(54, 23);
            this.buttonFontColor.Name = "buttonFontColor";
            this.buttonFontColor.Size = new System.Drawing.Size(54, 23);
            this.buttonFontColor.TabIndex = 17;
            this.buttonFontColor.Text = "│▾";
            this.buttonFontColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFontColor.UseVisualStyleBackColor = true;
            // 
            // panelFontColorSwatch
            // 
            this.panelFontColorSwatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFontColorSwatch.Location = new System.Drawing.Point(3, 3);
            this.panelFontColorSwatch.Margin = new System.Windows.Forms.Padding(0);
            this.panelFontColorSwatch.MaximumSize = new System.Drawing.Size(29, 19);
            this.panelFontColorSwatch.MinimumSize = new System.Drawing.Size(29, 19);
            this.panelFontColorSwatch.Name = "panelFontColorSwatch";
            this.panelFontColorSwatch.Size = new System.Drawing.Size(29, 19);
            this.panelFontColorSwatch.TabIndex = 3;
            // 
            // thatchedPanel1
            // 
            this.thatchedPanel1.Controls.Add(this.label8);
            this.thatchedPanel1.ForeColor = System.Drawing.Color.Gray;
            this.thatchedPanel1.HatchingStyle = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
            this.thatchedPanel1.Location = new System.Drawing.Point(0, 0);
            this.thatchedPanel1.Name = "thatchedPanel1";
            this.thatchedPanel1.Size = new System.Drawing.Size(454, 45);
            this.thatchedPanel1.TabIndex = 8;
            this.thatchedPanel1.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(166, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2);
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Use font selection dialog";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorPickerDialog
            // 
            this.colorPickerDialog.AnyColor = true;
            this.colorPickerDialog.FullOpen = true;
            // 
            // fontPickerDialog
            // 
            this.fontPickerDialog.FontMustExist = true;
            this.fontPickerDialog.MaxSize = 200;
            this.fontPickerDialog.MinSize = 4;
            this.fontPickerDialog.ShowColor = true;
            // 
            // windowsuiMockupControl
            // 
            this.windowsuiMockupControl.ActiveBorderColor = System.Drawing.Color.Gray;
            this.windowsuiMockupControl.ActiveTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.windowsuiMockupControl.ActiveTitleGradientColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.windowsuiMockupControl.ActiveTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.windowsuiMockupControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windowsuiMockupControl.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.windowsuiMockupControl.BackColor = System.Drawing.SystemColors.Desktop;
            this.windowsuiMockupControl.ButtonFaceColor = System.Drawing.SystemColors.Control;
            this.windowsuiMockupControl.ButtonTextColor = System.Drawing.SystemColors.ControlText;
            this.windowsuiMockupControl.CaptionFont = null;
            this.windowsuiMockupControl.DesktopBackgroundColor = System.Drawing.SystemColors.Desktop;
            this.windowsuiMockupControl.GrayTextColor = System.Drawing.SystemColors.ControlText;
            this.windowsuiMockupControl.HilightColor = System.Drawing.SystemColors.Highlight;
            this.windowsuiMockupControl.HilightTextColor = System.Drawing.SystemColors.HighlightText;
            this.windowsuiMockupControl.HotTrackingColor = System.Drawing.SystemColors.HotTrack;
            this.windowsuiMockupControl.IconFont = null;
            this.windowsuiMockupControl.InactiveBorderColor = System.Drawing.Color.Silver;
            this.windowsuiMockupControl.InactiveTitleColor = System.Drawing.SystemColors.InactiveCaption;
            this.windowsuiMockupControl.InactiveTitleGradientColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.windowsuiMockupControl.InactiveTitleTextColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.windowsuiMockupControl.InfoTextColor = System.Drawing.SystemColors.InfoText;
            this.windowsuiMockupControl.InfoWindowColor = System.Drawing.SystemColors.Info;
            this.windowsuiMockupControl.Location = new System.Drawing.Point(0, 0);
            this.windowsuiMockupControl.Margin = new System.Windows.Forms.Padding(0);
            this.windowsuiMockupControl.MaximumSize = new System.Drawing.Size(489, 321);
            this.windowsuiMockupControl.MenuBarColor = System.Drawing.SystemColors.Menu;
            this.windowsuiMockupControl.MenuFont = null;
            this.windowsuiMockupControl.MenuHighlightColor = System.Drawing.SystemColors.MenuHighlight;
            this.windowsuiMockupControl.MenuTextColor = System.Drawing.SystemColors.MenuText;
            this.windowsuiMockupControl.MessageFont = null;
            this.windowsuiMockupControl.MinimumSize = new System.Drawing.Size(570, 370);
            this.windowsuiMockupControl.Name = "windowsuiMockupControl";
            this.windowsuiMockupControl.ScrollbarColor = System.Drawing.SystemColors.Window;
            this.windowsuiMockupControl.Size = new System.Drawing.Size(570, 370);
            this.windowsuiMockupControl.SmCaptionFont = null;
            this.windowsuiMockupControl.StatusFont = null;
            this.windowsuiMockupControl.TabIndex = 1;
            this.windowsuiMockupControl.WindowColor = System.Drawing.SystemColors.Window;
            this.windowsuiMockupControl.WindowFrameColor = System.Drawing.Color.Black;
            this.windowsuiMockupControl.WindowTextColor = System.Drawing.SystemColors.ControlText;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelMain.Controls.Add(this.windowsuiMockupControl);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelBottom);
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(570, 465);
            this.flowLayoutPanelMain.TabIndex = 4;
            // 
            // flowLayoutPanelBottom
            // 
            this.flowLayoutPanelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelBottom.Controls.Add(this.flowLayoutPanelColor);
            this.flowLayoutPanelBottom.Controls.Add(this.panelFontProperty);
            this.flowLayoutPanelBottom.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBottom.Location = new System.Drawing.Point(0, 371);
            this.flowLayoutPanelBottom.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            this.flowLayoutPanelBottom.Size = new System.Drawing.Size(570, 92);
            this.flowLayoutPanelBottom.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(570, 465);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Control Freak - Total Windows Customization";
            this.panelColorPropertyLeft.ResumeLayout(false);
            this.panelColorPropertyLeft.PerformLayout();
            this.flowLayoutPanelColor.ResumeLayout(false);
            this.panelColorPropertyRight.ResumeLayout(false);
            this.panelColorProperty1.ResumeLayout(false);
            this.panelColorProperty1.PerformLayout();
            this.buttonColorProperty1.ResumeLayout(false);
            this.panelColorProperty2.ResumeLayout(false);
            this.panelColorProperty2.PerformLayout();
            this.buttonColorProperty2.ResumeLayout(false);
            this.panelFontPropertyRight.ResumeLayout(false);
            this.panelFontPropertyRight.PerformLayout();
            this.panelFontPropertyLeft.ResumeLayout(false);
            this.panelFontPropertyLeft.PerformLayout();
            this.panelFontProperty.ResumeLayout(false);
            this.panelInnerFontProperty.ResumeLayout(false);
            this.panelFontPropertyColor.ResumeLayout(false);
            this.panelFontPropertyColor.PerformLayout();
            this.buttonFontColor.ResumeLayout(false);
            this.thatchedPanel1.ResumeLayout(false);
            this.thatchedPanel1.PerformLayout();
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.flowLayoutPanelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

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
