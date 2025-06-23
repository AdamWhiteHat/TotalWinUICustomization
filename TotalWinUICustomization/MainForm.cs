using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using TotalWinUICustomization.Controls;
using TotalWinUICustomization.Types;

namespace TotalWinUICustomization
{
    public partial class MainForm : Form
    {
        public WindowsUiElements? CurrentUiColorElementSelected
        {
            get { return _currentUiColorElementSelected; }
            set
            {
                _currentUiColorElementSelected = value;
                PanelColorPropertyControls.Enabled = !(_currentUiColorElementSelected == null);
            }
        }
        private WindowsUiElements? _currentUiColorElementSelected;

        public WindowsUiElements? CurrentUiFontElementSelected
        {
            get { return _currentUiFontElementSelected; }
            set
            {
                _currentUiFontElementSelected = value;
                PanelFontPropertyControls.Enabled = !(_currentUiFontElementSelected == null);
            }
        }
        private WindowsUiElements? _currentUiFontElementSelected;

        private List<FontFamily> _fontFamilies = null;

        public MainForm()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();

            this.AllowTransparency = true;
            CurrentUiColorElementSelected = null;
            CurrentUiFontElementSelected = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(WindowsUiElements)).OfType<WindowsUiElements>())
            {
                bool isFont = Helpers.EnumToIsFontDictionary[item];
                if (!isFont)
                {
                    comboBoxColorPropertySelection.Items.Add(item);
                }
                else
                {
                    Font font = RegistryHelper.GetWindowsFont(item);
                    windowsuiMockupControl.UpdateControlFont(item, font);
                }

                Color itemColor = RegistryHelper.GetWindowsColor(item);
                windowsuiMockupControl.UpdateControlColor(item, itemColor);
            }

            if (_fontFamilies == null)
            {
                _fontFamilies = FontFamily.Families.ToList();
            }
            foreach (FontFamily family in _fontFamilies)
            {
                comboBoxFontPropertySelection.Items.Add(family.Name);
            }
            //comboBoxFontPropertySelection.SelectedItem = "SegoeUI";
        }

        private void WindowsuiMockupControl_ColorUiElementClicked(object sender, ColorUiElementClickedEventArgs e)
        {
            bool isFont = Helpers.EnumToIsFontDictionary[e.ElementClicked];
            WindowsUiElements? secondary = Helpers.EnumToCompanionEnum[e.ElementClicked];

            if (isFont)
            {
                CurrentUiFontElementSelected = e.ElementClicked;
                CurrentUiColorElementSelected = secondary.HasValue ? secondary.Value : null;
            }
            else
            {
                CurrentUiFontElementSelected = secondary.HasValue ? secondary.Value : null;
                CurrentUiColorElementSelected = e.ElementClicked;
            }

            comboBoxColorPropertySelection.SelectedIndex = -1;
            comboBoxFontPropertySelection.SelectedIndex = -1;

            UpdateComboboxes();
        }

        private void UpdateComboboxes()
        {
            if (CurrentUiColorElementSelected.HasValue)
            {
                if (comboBoxColorPropertySelection.SelectedIndex == -1 || (WindowsUiElements)comboBoxColorPropertySelection.SelectedItem != CurrentUiColorElementSelected.Value)
                {
                    comboBoxColorPropertySelection.SelectedItem = CurrentUiColorElementSelected.Value;
                }
                if (!PanelColorPropertyControls.Enabled)
                {
                    PanelColorPropertyControls.Enabled = true;
                }
                Color currentElementColor = RegistryHelper.GetWindowsColor(CurrentUiColorElementSelected.Value);
                panelPropertyColorSwatch1.BackColor = currentElementColor;
            }
            else
            {
                if (comboBoxColorPropertySelection.SelectedIndex != -1)
                {
                    comboBoxColorPropertySelection.SelectedIndex = -1;
                }
                if (PanelColorPropertyControls.Enabled)
                {
                    PanelColorPropertyControls.Enabled = false;
                }
            }

            if (CurrentUiFontElementSelected.HasValue)
            {
                if (comboBoxFontPropertySelection.SelectedIndex == -1)
                {
                    Font font = RegistryHelper.GetWindowsFont(CurrentUiFontElementSelected.Value);
                    int index = _fontFamilies.ToList().IndexOf(font.FontFamily);
                    if (index != -1)
                    {
                        comboBoxFontPropertySelection.SelectedIndex = index;
                    }

                    float fontSize = font.SizeInPoints;
                    sizeUpDown_Font.Text = fontSize.ToString();
                }
                if (!PanelFontPropertyControls.Enabled)
                {
                    PanelFontPropertyControls.Enabled = true;
                }
                Color currentFontColor = RegistryHelper.GetWindowsColor(CurrentUiFontElementSelected.Value);
                panelFontColorSwatch.BackColor = currentFontColor;
            }
            else
            {
                if (comboBoxFontPropertySelection.SelectedIndex != -1)
                {
                    comboBoxFontPropertySelection.SelectedIndex = -1;
                }
                if (PanelFontPropertyControls.Enabled)
                {
                    PanelFontPropertyControls.Enabled = false;
                }
            }
        }

        private void comboBoxColorPropertySelection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxColorPropertySelection.SelectedIndex != -1)
            {
                WindowsUiElements selectedProperty = (WindowsUiElements)comboBoxColorPropertySelection.Items[comboBoxColorPropertySelection.SelectedIndex];
                if (CurrentUiColorElementSelected != selectedProperty)
                {
                    CurrentUiColorElementSelected = selectedProperty;
                }

                WindowsUiElements? secondary = Helpers.EnumToCompanionEnum[selectedProperty];
                if (secondary.HasValue)
                {
                    CurrentUiFontElementSelected = secondary.Value;
                }
                else
                {
                    CurrentUiFontElementSelected = null;
                }

                UpdateComboboxes();
            }
            else
            {
                CurrentUiColorElementSelected = null;
                CurrentUiFontElementSelected = null;
            }
        }

        private void buttonPropertyColor1_Click(object sender, EventArgs e)
        {
            colorPickerDialog.Color = panelPropertyColorSwatch1.BackColor;
            if (colorPickerDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorPickerDialog.Color;
                panelPropertyColorSwatch1.BackColor = selectedColor;
                WindowsUiElements selectedProperty = (WindowsUiElements)comboBoxColorPropertySelection.Items[comboBoxColorPropertySelection.SelectedIndex];
                windowsuiMockupControl.UpdateControlColor(selectedProperty, selectedColor);
                RegistryHelper.SetWindowsColor(selectedProperty, selectedColor);
            }
        }

        private void buttonPropertyColor2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            colorPickerDialog.Color = panelFontColorSwatch.BackColor;
            if (colorPickerDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorPickerDialog.Color;
                panelFontColorSwatch.BackColor = selectedColor;

                if (CurrentUiFontElementSelected.HasValue)
                {
                    WindowsUiElements selectedProperty = CurrentUiFontElementSelected.Value;

                    windowsuiMockupControl.UpdateControlColor(selectedProperty, selectedColor);
                    RegistryHelper.SetWindowsColor(selectedProperty, selectedColor);
                }
            }
        }

        private void comboBoxFontPropertySelection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CurrentUiFontElementSelected.HasValue)
            {
                Font selectedFont = GetSelectedComboBoxFont();
                if (selectedFont != null)
                {
                    windowsuiMockupControl.UpdateControlFont(CurrentUiFontElementSelected.Value, selectedFont);
                    RegistryHelper.SetWindowsFont(CurrentUiFontElementSelected.Value, selectedFont);
                }
            }
        }

        public Font GetSelectedComboBoxFont()
        {
            if (comboBoxFontPropertySelection != null && comboBoxFontPropertySelection.SelectedIndex != -1)
            {
                var selectedValue = comboBoxFontPropertySelection.Items[comboBoxFontPropertySelection.SelectedIndex].ToString();
                var match = _fontFamilies.Where(f => string.Equals(f.Name, selectedValue, StringComparison.InvariantCultureIgnoreCase));
                if (match.Any())
                {
                    FontFamily selectedFontFamily = match.Single();
                    float fontSize = float.Parse(sizeUpDown_Font.Text);

                    return new Font(selectedFontFamily, fontSize, GraphicsUnit.Point);
                }
            }
            return null;
        }

        private void sizeUpDown_Font_SelectedItemChanged(object sender, EventArgs e)
        {
            if (CurrentUiFontElementSelected.HasValue)
            {
                Font font = RegistryHelper.GetWindowsFont(CurrentUiFontElementSelected.Value);

                float fontSize = float.Parse(sizeUpDown_Font.Text);

                if (fontSize > 0)
                {
                    Font newFont = new Font(font.FontFamily, fontSize, GraphicsUnit.Point);
                    windowsuiMockupControl.UpdateControlFont(CurrentUiFontElementSelected.Value, newFont);
                    RegistryHelper.SetWindowsFont(CurrentUiFontElementSelected.Value, newFont);
                }

            }
        }
    }
}
