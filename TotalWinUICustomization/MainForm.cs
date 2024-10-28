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
            windowsuiMockupControl.Location = new Point(2, 2);
            windowsuiMockupControl.Name = "WindowsUiMockupControl";
            windowsuiMockupControl.ColorUiElementClicked += WindowsuiMockupControl_ColorUiElementClicked;
            Controls.Add(windowsuiMockupControl);

            this.AllowTransparency = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(WindowsUiElements)).OfType<WindowsUiElements>())
            {
                bool isFont = Helpers.EnumToIsFontDictionary[item];

                if (isFont)
                {
                    comboBoxFontSelection.Items.Add(item);
                }
                else
                {
                    comboBoxPropertySelection.Items.Add(item);
                }

                Color itemColor = RegistryHelper.GetWindowsColor(item);
                windowsuiMockupControl.UpdateControlColor(item, itemColor);
            }
        }

        private void WindowsuiMockupControl_ColorUiElementClicked(object sender, ColorUiElementClickedEventArgs e)
        {
            bool isFont = Helpers.EnumToIsFontDictionary[e.ElementClicked];
            WindowsUiElements? secondary = Helpers.EnumToCompanionEnum[e.ElementClicked];

            if (isFont)
            {
                comboBoxFontSelection.SelectedItem = e.ElementClicked;
                if (secondary != null)
                {
                    comboBoxPropertySelection.SelectedItem = secondary.Value;
                }
                else
                {
                    comboBoxPropertySelection.SelectedIndex = -1;
                }
            }
            else
            {
                comboBoxPropertySelection.SelectedItem = e.ElementClicked;
                if (secondary != null)
                {
                    comboBoxFontSelection.SelectedItem = secondary.Value;
                }
                else
                {
                    comboBoxFontSelection.SelectedIndex = -1;
                }
            }
        }

        private void ComboBoxPropertySelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPropertySelection.SelectedIndex == -1)
            {
                PanelPropertyControls.Enabled = false;
            }
            else
            {
                if (!PanelPropertyControls.Enabled)
                {
                    PanelPropertyControls.Enabled = true;
                }
                WindowsUiElements selectedProperty = (WindowsUiElements)comboBoxPropertySelection.Items[comboBoxPropertySelection.SelectedIndex];
                Color selectedColor = RegistryHelper.GetWindowsColor(selectedProperty);
                panelPropertyColorSwatch.BackColor = selectedColor;
            }
        }

        private void comboBoxFontSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFontSelection.SelectedIndex == -1)
            {
                panelFontControls.Enabled = false;
            }
            else
            {
                if (!panelFontControls.Enabled)
                {
                    panelFontControls.Enabled = true;
                }
                WindowsUiElements selectedProperty = (WindowsUiElements)comboBoxFontSelection.Items[comboBoxFontSelection.SelectedIndex];
                Color selectedColor = RegistryHelper.GetWindowsColor(selectedProperty);
                panelFontColorSwatch.BackColor = selectedColor;
            }
        }

        private void buttonPropertyColor_Click(object sender, EventArgs e)
        {
            colorPickerDialog.Color = panelPropertyColorSwatch.BackColor;
            if (colorPickerDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorPickerDialog.Color;
                panelPropertyColorSwatch.BackColor = selectedColor;
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

                WindowsUiElements selectedProperty = (WindowsUiElements)comboBoxFontSelection.Items[comboBoxFontSelection.SelectedIndex];
                windowsuiMockupControl.UpdateControlColor(selectedProperty, selectedColor);
                RegistryHelper.SetWindowsColor(selectedProperty, selectedColor);
            }
        }

    }
}
