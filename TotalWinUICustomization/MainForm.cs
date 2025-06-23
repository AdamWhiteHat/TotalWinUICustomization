using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using TotalWinUICustomization.Controls;
using TotalWinUICustomization.Types;

namespace TotalWinUICustomization
{
    public partial class MainForm : Form
    {
        protected UIElementAssociation? CurrentUiElementSelected { get; set; }

        private List<FontFamily> _fontFamilies = null;

        public MainForm()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();

            this.AllowTransparency = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Update control colors from registry
            foreach (var item in Enum.GetValues(typeof(WindowsUiElements)).OfType<WindowsUiElements>())
            {

                comboBoxColorPropertySelection.Items.Add(item);
                Color itemColor = RegistryHelper.GetWindowsColor(item);
                windowsuiMockupControl.UpdateControlColor(item, itemColor);
            }

            // Update control fonts from registry
            foreach (var item in Enum.GetValues(typeof(SystemFontGroup)).OfType<SystemFontGroup>())
            {
                Font font = RegistryHelper.GetWindowsFont(item);
                windowsuiMockupControl.UpdateControlFont(item, font);
            }

            if (_fontFamilies == null)
            {
                _fontFamilies = FontFamily.Families.ToList();
            }

            // Populate font combobox with all available system TrueType fonts
            foreach (FontFamily family in _fontFamilies)
            {
                if (FontHelper.IsTrueType(family.Name))
                {
                    comboBoxFontPropertySelection.Items.Add(family.Name);
                }
            }
        }

        private WindowsUiElements? GetSelectedComboBoxUIProperty()
        {
            if (comboBoxColorPropertySelection.SelectedIndex == -1)
            {
                return null;
            }
            else
            {
                return (WindowsUiElements)comboBoxColorPropertySelection.Items[comboBoxColorPropertySelection.SelectedIndex];
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

        private void WindowsuiMockupControl_ColorUiElementClicked(object sender, ColorUiElementClickedEventArgs e)
        {

            CurrentUiElementSelected = e.ElementClicked;
            UpdateComboboxes();
        }

        private void UpdateComboboxes()
        {
            UIElementAssociation clickedElement = CurrentUiElementSelected;

            // Update UI Element Color Property
            if (clickedElement.ControlElement != null)
            {
                if (comboBoxColorPropertySelection.SelectedIndex == -1 || (WindowsUiElements)comboBoxColorPropertySelection.SelectedItem != clickedElement.ControlElement)
                {
                    comboBoxColorPropertySelection.SelectedItem = clickedElement.ControlElement.Value;
                }
                if (!PanelColorPropertyControls.Enabled)
                {
                    PanelColorPropertyControls.Enabled = true;
                }
                Color currentElementColor = RegistryHelper.GetWindowsColor(clickedElement.ControlElement.Value);
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

            // Update associated font color
            if (clickedElement.AssociatedFontColor != null)
            {
                if (!PanelFontPropertyControls.Enabled)
                {
                    PanelFontPropertyControls.Enabled = true;
                }
                if (!panelPropertyFontColor.Enabled)
                {
                    panelPropertyFontColor.Enabled = true;
                }
                Color currentFontColor = RegistryHelper.GetWindowsColor(clickedElement.AssociatedFontColor.Value);
                panelFontColorSwatch.BackColor = currentFontColor;
            }
            else
            {
                if (panelPropertyFontColor.Enabled)
                {
                    panelPropertyFontColor.Enabled = false;
                }
                if (PanelFontPropertyControls.Enabled)
                {
                    PanelFontPropertyControls.Enabled = false;
                }
            }

            // Update associated font
            if (clickedElement.AssociatedFont != null)
            {
                if (comboBoxFontPropertySelection.SelectedIndex == -1)
                {
                    Font font = RegistryHelper.GetWindowsFont(clickedElement.AssociatedFont.Value);
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

                UIElementAssociation match = UIElementAssociation.AllAssociations
                                                                 .Where(a => a.ControlElement == selectedProperty)
                                                                 .FirstOrDefault();
                if (match != null)
                {
                    CurrentUiElementSelected = match;
                }
            }
            else
            {
                CurrentUiElementSelected = null;
            }

            UpdateComboboxes();
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
            // Currently not in use, but things like the second color for a gradient title bar color would use this.
        }

        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            colorPickerDialog.Color = panelFontColorSwatch.BackColor;
            if (colorPickerDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorPickerDialog.Color;
                panelFontColorSwatch.BackColor = selectedColor;

                if (CurrentUiElementSelected != null)
                {
                    WindowsUiElements? selectedProperty = CurrentUiElementSelected.AssociatedFontColor;
                    if (selectedProperty.HasValue)
                    {
                        windowsuiMockupControl.UpdateControlColor(selectedProperty.Value, selectedColor);
                        RegistryHelper.SetWindowsColor(selectedProperty.Value, selectedColor);
                    }
                }
            }
        }

        private void comboBoxFontPropertySelection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CurrentUiElementSelected != null)
            {
                Font selectedFont = GetSelectedComboBoxFont();
                if (selectedFont != null)
                {
                    if (CurrentUiElementSelected.AssociatedFont.HasValue)
                    {
                        windowsuiMockupControl.UpdateControlFont(CurrentUiElementSelected.AssociatedFont.Value, selectedFont);
                        RegistryHelper.SetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value, selectedFont);
                    }
                }
            }
        }

        private void sizeUpDown_Font_SelectedItemChanged(object sender, EventArgs e)
        {
            if (CurrentUiElementSelected != null)
            {
                if (CurrentUiElementSelected.AssociatedFont.HasValue)
                {
                    Font font = RegistryHelper.GetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value);

                    if (!float.TryParse(sizeUpDown_Font.Text, out float fontSize))
                    {
                        return;
                    }

                    if (fontSize > 0)
                    {
                        Font newFont = new Font(font.FontFamily, fontSize, GraphicsUnit.Point);
                        windowsuiMockupControl.UpdateControlFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                        RegistryHelper.SetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                    }
                }
            }
        }
    }
}
