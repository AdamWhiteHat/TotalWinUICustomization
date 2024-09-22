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
            panel1 = new Panel();
            btnRefresh = new Button();
            panelItemControls = new Panel();
            label3 = new Label();
            sizeUpDown_Item = new DomainUpDown();
            label6 = new Label();
            buttonItemColor = new Button();
            panelItemColorSwatch = new Panel();
            panelFontControls = new Panel();
            label2 = new Label();
            sizeUpDown_Font = new DomainUpDown();
            comboBoxFontSelection = new ComboBox();
            buttonFontColor = new Button();
            panelFontColorSwatch = new Panel();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            comboBoxPropertySelection = new ComboBox();
            colorPickerDialog = new ColorDialog();
            fontPickerDialog = new FontDialog();
            panel1.SuspendLayout();
            panelItemControls.SuspendLayout();
            buttonItemColor.SuspendLayout();
            panelFontControls.SuspendLayout();
            buttonFontColor.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(panelItemControls);
            panel1.Controls.Add(panelFontControls);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxPropertySelection);
            panel1.Location = new Point(9, 345);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 186);
            panel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.Location = new Point(453, 154);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // panelItemControls
            // 
            panelItemControls.Controls.Add(label3);
            panelItemControls.Controls.Add(sizeUpDown_Item);
            panelItemControls.Controls.Add(label6);
            panelItemControls.Controls.Add(buttonItemColor);
            panelItemControls.Enabled = false;
            panelItemControls.Location = new Point(333, 6);
            panelItemControls.Name = "panelItemControls";
            panelItemControls.Size = new Size(181, 59);
            panelItemControls.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 8;
            label3.Text = "Size:";
            // 
            // sizeUpDown_Item
            // 
            sizeUpDown_Item.Location = new Point(3, 26);
            sizeUpDown_Item.Name = "sizeUpDown_Item";
            sizeUpDown_Item.Size = new Size(73, 27);
            sizeUpDown_Item.TabIndex = 7;
            sizeUpDown_Item.Text = "12";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 3);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 13;
            label6.Text = "Color:";
            // 
            // buttonItemColor
            // 
            buttonItemColor.Controls.Add(panelItemColorSwatch);
            buttonItemColor.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonItemColor.Location = new Point(80, 23);
            buttonItemColor.Name = "buttonItemColor";
            buttonItemColor.Size = new Size(94, 34);
            buttonItemColor.TabIndex = 11;
            buttonItemColor.Text = "│ ▾";
            buttonItemColor.TextAlign = ContentAlignment.MiddleRight;
            buttonItemColor.UseVisualStyleBackColor = true;
            buttonItemColor.Click += buttonItemColor_Click;
            // 
            // panelItemColorSwatch
            // 
            panelItemColorSwatch.BackColor = Color.Blue;
            panelItemColorSwatch.BorderStyle = BorderStyle.FixedSingle;
            panelItemColorSwatch.Location = new Point(4, 4);
            panelItemColorSwatch.Name = "panelItemColorSwatch";
            panelItemColorSwatch.Size = new Size(58, 26);
            panelItemColorSwatch.TabIndex = 2;
            // 
            // panelFontControls
            // 
            panelFontControls.Controls.Add(label2);
            panelFontControls.Controls.Add(sizeUpDown_Font);
            panelFontControls.Controls.Add(comboBoxFontSelection);
            panelFontControls.Controls.Add(buttonFontColor);
            panelFontControls.Controls.Add(label4);
            panelFontControls.Controls.Add(label5);
            panelFontControls.Enabled = false;
            panelFontControls.Location = new Point(3, 71);
            panelFontControls.Name = "panelFontControls";
            panelFontControls.Size = new Size(510, 59);
            panelFontControls.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 2);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "Font:";
            // 
            // sizeUpDown_Font
            // 
            sizeUpDown_Font.Location = new Point(333, 26);
            sizeUpDown_Font.Name = "sizeUpDown_Font";
            sizeUpDown_Font.Size = new Size(73, 27);
            sizeUpDown_Font.TabIndex = 1;
            sizeUpDown_Font.Text = "12";
            // 
            // comboBoxFontSelection
            // 
            comboBoxFontSelection.FormattingEnabled = true;
            comboBoxFontSelection.Location = new Point(12, 24);
            comboBoxFontSelection.Name = "comboBoxFontSelection";
            comboBoxFontSelection.Size = new Size(313, 28);
            comboBoxFontSelection.TabIndex = 6;
            // 
            // buttonFontColor
            // 
            buttonFontColor.Controls.Add(panelFontColorSwatch);
            buttonFontColor.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFontColor.Location = new Point(412, 23);
            buttonFontColor.Name = "buttonFontColor";
            buttonFontColor.Size = new Size(94, 34);
            buttonFontColor.TabIndex = 15;
            buttonFontColor.Text = "│ ▾";
            buttonFontColor.TextAlign = ContentAlignment.MiddleRight;
            buttonFontColor.UseVisualStyleBackColor = true;
            buttonFontColor.Click += buttonFontColor_Click;
            // 
            // panelFontColorSwatch
            // 
            panelFontColorSwatch.BackColor = Color.Green;
            panelFontColorSwatch.BorderStyle = BorderStyle.FixedSingle;
            panelFontColorSwatch.Location = new Point(4, 4);
            panelFontColorSwatch.Name = "panelFontColorSwatch";
            panelFontColorSwatch.Size = new Size(58, 26);
            panelFontColorSwatch.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 3);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 9;
            label4.Text = "Size:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(412, 3);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 10;
            label5.Text = "Color:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 4;
            label1.Text = "Item:";
            // 
            // comboBoxPropertySelection
            // 
            comboBoxPropertySelection.FormattingEnabled = true;
            comboBoxPropertySelection.Location = new Point(15, 33);
            comboBoxPropertySelection.Name = "comboBoxPropertySelection";
            comboBoxPropertySelection.Size = new Size(313, 28);
            comboBoxPropertySelection.TabIndex = 0;
            comboBoxPropertySelection.SelectedIndexChanged += ComboBoxPropertySelection_SelectedIndexChanged;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 540);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Control Freak - Total Windows Customization";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelItemControls.ResumeLayout(false);
            panelItemControls.PerformLayout();
            buttonItemColor.ResumeLayout(false);
            panelFontControls.ResumeLayout(false);
            panelFontControls.PerformLayout();
            buttonFontColor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ComboBox comboBoxPropertySelection;
        private DomainUpDown sizeUpDown_Font;
        private ColorDialog colorPickerDialog;
        private ComboBox comboBoxFontSelection;
        private Label label2;
        private Label label1;
        private Label label3;
        private DomainUpDown sizeUpDown_Item;
        private Label label5;
        private Label label4;
        private FontDialog fontPickerDialog;
        private Button buttonItemColor;
        private Label label6;
        private Button buttonFontColor;
        private Panel panelItemColorSwatch;
        private Panel panelFontColorSwatch;
        private Panel panelItemControls;
        private Panel panelFontControls;
        private Button btnRefresh;
    }
}
