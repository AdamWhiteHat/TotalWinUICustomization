using TotalWinUICustomization.Controls;
using TotalWinUICustomization.Types;

namespace TotalWinUICustomization
{
    public partial class MainForm : Form
    {
        private WindowsUIMockupControl windowsuiMockupControl;

        public MainForm()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            windowsuiMockupControl = new WindowsUIMockupControl();
            windowsuiMockupControl.AutoValidate = AutoValidate.EnablePreventFocusChange;
            windowsuiMockupControl.Location = new Point(9, 9);
            windowsuiMockupControl.Name = "WindowsUiMockupControl";
            Controls.Add(windowsuiMockupControl);

            this.AllowTransparency = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(WindowsUiElements)).OfType<WindowsUiElements>())
            {
                comboBoxPropertySelection.Items.Add(item);
                Color itemColor = RegistryHelper.GetWindowsColor(item);
                windowsuiMockupControl.UpdateControlColor(item, itemColor);
            }


            Border b = new Border();
            b.Location = new Point(37, 44);
            b.BringToFront();
            b.Size = new Size(347, 115);
            b.Name = "border1";
            b.BringToFront();
            panel1.Controls.Add(b);
            b.BringToFront();

        }

        private void ComboBoxPropertySelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPropertySelection.SelectedIndex == -1)
            {
                panelItemControls.Enabled = false;
            }
            else
            {
                if (!panelItemControls.Enabled)
                {
                    panelItemControls.Enabled = true;
                }
                WindowsUiElements selectedProperty = (WindowsUiElements)comboBoxPropertySelection.Items[comboBoxPropertySelection.SelectedIndex];
                Color selectedColor = RegistryHelper.GetWindowsColor(selectedProperty);
                panelItemColorSwatch.BackColor = selectedColor;
            }
        }

        private void buttonItemColor_Click(object sender, EventArgs e)
        {
            colorPickerDialog.Color = panelItemColorSwatch.BackColor;
            if (colorPickerDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorPickerDialog.Color;
                panelItemColorSwatch.BackColor = selectedColor;
                WindowsUiElements selectedProperty = (WindowsUiElements)comboBoxPropertySelection.Items[comboBoxPropertySelection.SelectedIndex];
                windowsuiMockupControl.UpdateControlColor(selectedProperty, selectedColor);
                RegistryHelper.SetWindowsColor(selectedProperty, selectedColor);
            }
        }

        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            colorPickerDialog.Color = panelFontColorSwatch.BackColor;
            if (colorPickerDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorPickerDialog.Color;
                panelFontColorSwatch.BackColor = selectedColor;

                //WindowsUiElements selectedProperty = (WindowsUiElements)comboBoxPropertySelection.Items[comboBoxPropertySelection.SelectedIndex];
                //windowsuiMockupControl.UpdateControlColor(selectedProperty, selectedColor);
                //RegistryHelper.SetWindowsColor(selectedProperty, selectedColor);
            }
        }

    }
}
