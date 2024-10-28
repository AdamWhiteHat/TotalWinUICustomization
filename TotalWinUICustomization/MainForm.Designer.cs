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
            PanelPropertyControls = new Panel();
            panelPropertyColorsControls = new Panel();
            label3 = new Label();
            sizeUpDown_Item = new DomainUpDown();
            label6 = new Label();
            buttonPropertyColor = new Button();
            panelPropertyColorSwatch = new Panel();
            comboBoxPropertySelection = new ComboBox();
            label1 = new Label();
            btnRefresh = new Button();
            panelFontControls = new Panel();
            panelFontColorsControls = new Panel();
            sizeUpDown_Font = new DomainUpDown();
            label5 = new Label();
            label4 = new Label();
            buttonFontColor = new Button();
            panelFontColorSwatch = new Panel();
            label2 = new Label();
            comboBoxFontSelection = new ComboBox();
            colorPickerDialog = new ColorDialog();
            fontPickerDialog = new FontDialog();
            panel1.SuspendLayout();
            PanelPropertyControls.SuspendLayout();
            panelPropertyColorsControls.SuspendLayout();
            buttonPropertyColor.SuspendLayout();
            panelFontControls.SuspendLayout();
            panelFontColorsControls.SuspendLayout();
            buttonFontColor.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(PanelPropertyControls);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(panelFontControls);
            panel1.Location = new Point(3, 348);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 174);
            panel1.TabIndex = 1;
            // 
            // PanelPropertyControls
            // 
            PanelPropertyControls.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelPropertyControls.Controls.Add(panelPropertyColorsControls);
            PanelPropertyControls.Controls.Add(comboBoxPropertySelection);
            PanelPropertyControls.Controls.Add(label1);
            PanelPropertyControls.Enabled = false;
            PanelPropertyControls.Location = new Point(1, 6);
            PanelPropertyControls.Name = "PanelPropertyControls";
            PanelPropertyControls.Size = new Size(571, 62);
            PanelPropertyControls.TabIndex = 19;
            // 
            // panelPropertyColorsControls
            // 
            panelPropertyColorsControls.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelPropertyColorsControls.Controls.Add(label3);
            panelPropertyColorsControls.Controls.Add(sizeUpDown_Item);
            panelPropertyColorsControls.Controls.Add(label6);
            panelPropertyColorsControls.Controls.Add(buttonPropertyColor);
            panelPropertyColorsControls.Location = new Point(387, 0);
            panelPropertyColorsControls.Margin = new Padding(0);
            panelPropertyColorsControls.Name = "panelPropertyColorsControls";
            panelPropertyColorsControls.Size = new Size(183, 62);
            panelPropertyColorsControls.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 2);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 8;
            label3.Text = "Size:";
            // 
            // sizeUpDown_Item
            // 
            sizeUpDown_Item.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sizeUpDown_Item.Location = new Point(3, 24);
            sizeUpDown_Item.Name = "sizeUpDown_Item";
            sizeUpDown_Item.Size = new Size(73, 27);
            sizeUpDown_Item.TabIndex = 7;
            sizeUpDown_Item.Text = "12";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(82, 2);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 13;
            label6.Text = "Color:";
            // 
            // buttonPropertyColor
            // 
            buttonPropertyColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPropertyColor.Controls.Add(panelPropertyColorSwatch);
            buttonPropertyColor.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPropertyColor.Location = new Point(80, 22);
            buttonPropertyColor.Name = "buttonPropertyColor";
            buttonPropertyColor.Size = new Size(94, 34);
            buttonPropertyColor.TabIndex = 11;
            buttonPropertyColor.Text = "│ ▾";
            buttonPropertyColor.TextAlign = ContentAlignment.MiddleRight;
            buttonPropertyColor.UseVisualStyleBackColor = true;
            buttonPropertyColor.Click += buttonPropertyColor_Click;
            // 
            // panelPropertyColorSwatch
            // 
            panelPropertyColorSwatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPropertyColorSwatch.BackColor = Color.Blue;
            panelPropertyColorSwatch.BorderStyle = BorderStyle.FixedSingle;
            panelPropertyColorSwatch.Location = new Point(4, 4);
            panelPropertyColorSwatch.Name = "panelPropertyColorSwatch";
            panelPropertyColorSwatch.Size = new Size(58, 26);
            panelPropertyColorSwatch.TabIndex = 2;
            panelPropertyColorSwatch.Click += buttonPropertyColor_Click;
            // 
            // comboBoxPropertySelection
            // 
            comboBoxPropertySelection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxPropertySelection.FormattingEnabled = true;
            comboBoxPropertySelection.Location = new Point(12, 24);
            comboBoxPropertySelection.Name = "comboBoxPropertySelection";
            comboBoxPropertySelection.Size = new Size(370, 28);
            comboBoxPropertySelection.TabIndex = 0;
            comboBoxPropertySelection.SelectedIndexChanged += ComboBoxPropertySelection_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 2);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 4;
            label1.Text = "Item:";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(467, 137);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(103, 34);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // panelFontControls
            // 
            panelFontControls.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFontControls.Controls.Add(panelFontColorsControls);
            panelFontControls.Controls.Add(label2);
            panelFontControls.Controls.Add(comboBoxFontSelection);
            panelFontControls.Enabled = false;
            panelFontControls.Location = new Point(1, 74);
            panelFontControls.Name = "panelFontControls";
            panelFontControls.Size = new Size(571, 62);
            panelFontControls.TabIndex = 16;
            // 
            // panelFontColorsControls
            // 
            panelFontColorsControls.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelFontColorsControls.Controls.Add(sizeUpDown_Font);
            panelFontColorsControls.Controls.Add(label5);
            panelFontColorsControls.Controls.Add(label4);
            panelFontColorsControls.Controls.Add(buttonFontColor);
            panelFontColorsControls.Location = new Point(387, 0);
            panelFontColorsControls.Margin = new Padding(0);
            panelFontColorsControls.Name = "panelFontColorsControls";
            panelFontColorsControls.Size = new Size(183, 62);
            panelFontColorsControls.TabIndex = 2;
            // 
            // sizeUpDown_Font
            // 
            sizeUpDown_Font.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sizeUpDown_Font.Location = new Point(3, 23);
            sizeUpDown_Font.Name = "sizeUpDown_Font";
            sizeUpDown_Font.Size = new Size(73, 27);
            sizeUpDown_Font.TabIndex = 1;
            sizeUpDown_Font.Text = "12";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(82, 1);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 10;
            label5.Text = "Color:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 1);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 9;
            label4.Text = "Size:";
            // 
            // buttonFontColor
            // 
            buttonFontColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFontColor.Controls.Add(panelFontColorSwatch);
            buttonFontColor.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFontColor.Location = new Point(82, 21);
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
            panelFontColorSwatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFontColorSwatch.BackColor = Color.Green;
            panelFontColorSwatch.BorderStyle = BorderStyle.FixedSingle;
            panelFontColorSwatch.Location = new Point(4, 4);
            panelFontColorSwatch.Name = "panelFontColorSwatch";
            panelFontColorSwatch.Size = new Size(58, 26);
            panelFontColorSwatch.TabIndex = 3;
            panelFontColorSwatch.Click += buttonFontColor_Click;
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
            // comboBoxFontSelection
            // 
            comboBoxFontSelection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxFontSelection.FormattingEnabled = true;
            comboBoxFontSelection.Location = new Point(12, 24);
            comboBoxFontSelection.Name = "comboBoxFontSelection";
            comboBoxFontSelection.Size = new Size(370, 28);
            comboBoxFontSelection.TabIndex = 6;
            comboBoxFontSelection.SelectedIndexChanged += comboBoxFontSelection_SelectedIndexChanged;
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
            ClientSize = new Size(578, 524);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimumSize = new Size(600, 575);
            Name = "MainForm";
            Padding = new Padding(2);
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Control Freak - Total Windows Customization";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            PanelPropertyControls.ResumeLayout(false);
            PanelPropertyControls.PerformLayout();
            panelPropertyColorsControls.ResumeLayout(false);
            panelPropertyColorsControls.PerformLayout();
            buttonPropertyColor.ResumeLayout(false);
            panelFontControls.ResumeLayout(false);
            panelFontControls.PerformLayout();
            panelFontColorsControls.ResumeLayout(false);
            panelFontColorsControls.PerformLayout();
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
        private Button buttonPropertyColor;
        private Label label6;
        private Button buttonFontColor;
        private Panel panelPropertyColorSwatch;
        private Panel panelFontColorSwatch;
        private Panel panelPropertyColorsControls;
        private Panel panelFontControls;
        private Button btnRefresh;
        private Panel PanelPropertyControls;
        private Panel panelFontColorsControls;
    }
}
