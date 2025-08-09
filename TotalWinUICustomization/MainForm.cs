using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using TotalWinUICustomization.Controls;
using TotalWinUICustomization.Types;

namespace TotalWinUICustomization
{
    public partial class MainForm : Form
    {
        protected UIElementAssociation? CurrentUiElementSelected { get; set; }

        public MainForm()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();

            this.AllowTransparency = true;

            panelColorPropertyLeft.Disable();
            panelColorProperty1.Disable();
            panelColorProperty2.Disable();

            panelFontPropertyLeft.Disable();
            panelFontPropertySize.Disable();
            panelFontPropertyColor.Disable();

            panelColorPropertySwatch1.EnabledChanged += ColorSwatch_EnabledChanged;
            panelColorPropertySwatch2.EnabledChanged += ColorSwatch_EnabledChanged;
            panelFontColorSwatch.EnabledChanged += ColorSwatch_EnabledChanged;
            comboBoxColorPropertySelection.EnabledChanged += ComboBox_EnabledChanged;
            comboBoxFontPropertySelection.EnabledChanged += ComboBox_EnabledChanged;
            sizeUpDown_Font.EnabledChanged += SizeUpDown_Font_EnabledChanged;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Update control colors from registry
            foreach (var item in Enum.GetValues(typeof(WindowsUiElements)).OfType<WindowsUiElements>())
            {
                comboBoxColorPropertySelection.Items.Add(item);

                if (Types.Helpers.SystemFonts.Contains(item))
                {
                    Font font = RegistryHelper.GetWindowsFont(item);
                    windowsuiMockupControl.UpdateControlFont(item, font);
                }
                else
                {
                    Color itemColor = RegistryHelper.GetWindowsColor(item);
                    windowsuiMockupControl.UpdateControlColor(item, itemColor);
                }
            }


            // Populate font ComboBox with all available system TrueType fonts
            foreach (FontFamily family in FontHelper.FontFamilies)
            {
                comboBoxFontPropertySelection.Items.Add(family.Name);
            }
        }

        #region EnabledChanged

        private void ColorSwatch_EnabledChanged(object sender, EventArgs e)
        {
            Control source = sender as Control;
            if (source != null)
            {
                if (!source.Enabled)
                {
                    source.BackColor = Panel.DefaultBackColor;
                }
            }
        }

        private void ComboBox_EnabledChanged(object sender, EventArgs e)
        {
            ComboBox source = sender as ComboBox;
            if (source != null)
            {
                if (!source.Enabled)
                {
                    source.ClearSelection();
                }
            }
        }

        private void SizeUpDown_Font_EnabledChanged(object sender, EventArgs e)
        {
            DomainUpDown source = sender as DomainUpDown;
            if (source != null)
            {
                if (!source.Enabled)
                {
                    source.Text = "";
                }
            }
        }

        #endregion

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
                string selectedValue = comboBoxFontPropertySelection.Items[comboBoxFontPropertySelection.SelectedIndex].ToString();
                IEnumerable<FontFamily> match = FontHelper.FontFamilies.Where(f => string.Equals(f.Name, selectedValue, StringComparison.InvariantCultureIgnoreCase));
                if (match.Any())
                {
                    FontFamily selectedFontFamily = match.Single();
                    float fontSize = float.Parse(sizeUpDown_Font.Text);

                    return new Font(selectedFontFamily, fontSize, GraphicsUnit.Point);
                }
            }
            return null;
        }

        public float? GetFontSize()
        {
            if (float.TryParse(sizeUpDown_Font.Text, out float fontSize))
            {
                return (float)Math.Round(fontSize, 1);
            }
            return null;
        }

        public FontStyle GetFontStyle()
        {
            if (checkBoxFontBold.Checked)
            {
                return FontStyle.Bold;
            }
            return FontStyle.Regular;
        }

        private void WindowsuiMockupControl_ColorUiElementClicked(object sender, ColorUiElementClickedEventArgs e)
        {
            CurrentUiElementSelected = e.ElementClicked;
            UpdateComboboxes();
        }

        private void UpdateComboboxes()
        {
            UIElementAssociation clickedElement = CurrentUiElementSelected;

            #region ControlElement

            // Update UI Element Color Property
            if (clickedElement.HasControlElement)
            {
                panelColorPropertyLeft.Enable();
                panelColorProperty1.Enable();

                if (comboBoxColorPropertySelection.SelectedIndex == -1 || (WindowsUiElements)comboBoxColorPropertySelection.SelectedItem != clickedElement.ControlElement)
                {
                    comboBoxColorPropertySelection.SelectedItem = clickedElement.ControlElement.Value;
                }

                Color currentElementColor = RegistryHelper.GetWindowsColor(clickedElement.ControlElement.Value);
                panelColorPropertySwatch1.BackColor = currentElementColor;
            }
            else
            {
                comboBoxColorPropertySelection.ClearSelection();
                panelColorPropertyLeft.Disable();
                panelColorProperty1.Disable();
            }

            #endregion

            #region AssociatedFontColor

            // Update associated font color
            if (clickedElement.HasAssociatedFontColor)
            {
                panelFontPropertyColor.Enable();

                Color currentFontColor = RegistryHelper.GetWindowsColor(clickedElement.AssociatedFontColor.Value);
                panelFontColorSwatch.BackColor = currentFontColor;

                if (!clickedElement.HasControlElement)
                {
                    panelColorPropertyLeft.Enable();
                    comboBoxColorPropertySelection.SelectedItem = clickedElement.AssociatedFontColor.Value;
                }
            }
            else
            {
                panelFontPropertyColor.Disable();
            }

            #endregion

            #region AssociatedFont

            // Update associated font
            if (clickedElement.HasAssociatedFont)
            {
                panelFontPropertyLeft.Enable();
                panelFontPropertySize.Enable();

                Font font = RegistryHelper.GetWindowsFont(clickedElement.AssociatedFont.Value);
                int index = FontHelper.FontFamilies.IndexOf(font.FontFamily);
                if (index != -1)
                {
                    comboBoxFontPropertySelection.SelectedIndex = index;
                }

                float fontSize = (float)Math.Round(font.SizeInPoints,1);

                List<float> sizes = sizeUpDown_Font.Items.Cast<string>().Select(s => float.Parse(s)).ToList();
                if (!sizes.Contains(fontSize))
                {
                    sizes.Add(fontSize);
                    sizes = sizes.OrderByDescending(s => s).ToList();
                    sizeUpDown_Font.Items.Clear();
                    sizeUpDown_Font.Items.AddRange(sizes.Select(f => f.ToString()).ToList());
                }

                int fontSizeIndex = sizeUpDown_Font.Items.IndexOf(fontSize.ToString());
                sizeUpDown_Font.SelectedIndex = fontSizeIndex;
                //sizeUpDown_Font.Text = sizeUpDown_Font.SelectedItem.ToString();

                checkBoxFontBold.Checked = font.Bold;

                if (!clickedElement.HasControlElement && !clickedElement.HasAssociatedFontColor)
                {
                    panelColorPropertyLeft.Enable();
                    comboBoxColorPropertySelection.SelectedItem = clickedElement.AssociatedFont.Value;
                }
            }
            else
            {
                panelFontPropertyLeft.Disable();
                panelFontPropertySize.Disable();
            }

            #endregion

        }

        private void comboBoxColorPropertySelection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CurrentUiElementSelected = null;

            WindowsUiElements? selectedProperty = GetSelectedComboBoxUIProperty();
            if (selectedProperty.HasValue)
            {
                UIElementAssociation match = UIElementAssociation.AllAssociations
                                                                 .Where(a => a.ControlElement == selectedProperty.Value)
                                                                 .FirstOrDefault();

                if (match == null)
                {
                    match = UIElementAssociation.AllAssociations
                                                 .Where(a => !a.HasControlElement && a.AssociatedFontColor == selectedProperty.Value)
                                                 .FirstOrDefault();
                }

                if (match == null)
                {
                    match = UIElementAssociation.AllAssociations
                                                 .Where(a => !a.HasControlElement && !a.HasAssociatedFontColor && a.AssociatedFont == selectedProperty.Value)
                                                 .FirstOrDefault();
                }

                if (match != null)
                {
                    CurrentUiElementSelected = match;
                }
            }

            UpdateComboboxes();
        }


        private void comboBoxFontPropertySelection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CurrentUiElementSelected != null)
            {
                Font selectedFont = GetSelectedComboBoxFont();
                if (selectedFont != null)
                {
                    if (CurrentUiElementSelected.HasAssociatedFont)
                    {
                        windowsuiMockupControl.UpdateControlFont(CurrentUiElementSelected.AssociatedFont.Value, selectedFont);
                        RegistryHelper.SetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value, selectedFont);
                    }
                }
            }
        }

        private void buttonPropertyColor1_Click(object sender, EventArgs e)
        {
            colorPickerDialog.Color = panelColorPropertySwatch1.BackColor;
            if (colorPickerDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorPickerDialog.Color;
                panelColorPropertySwatch1.BackColor = selectedColor;
                WindowsUiElements? selectedProperty = GetSelectedComboBoxUIProperty();
                if (selectedProperty.HasValue)
                {
                    windowsuiMockupControl.UpdateControlColor(selectedProperty.Value, selectedColor);
                    RegistryHelper.SetWindowsColor(selectedProperty.Value, selectedColor);
                }
            }
        }

        private void buttonPropertyColor2_Click(object sender, EventArgs e)
        {
            // Currently not in use, but things like the second color for a gradient title bar color would use this.
        }

        private void sizeUpDown_Font_SelectedItemChanged(object sender, EventArgs e)
        {
            if (CurrentUiElementSelected != null)
            {
                if (CurrentUiElementSelected.HasAssociatedFont)
                {
                    Font font = RegistryHelper.GetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value);

                    float? fontSize = GetFontSize();
                    if (!fontSize.HasValue)
                    {
                        return;
                    }

                    FontStyle fontStyle = GetFontStyle();

                    if (fontSize > 0)
                    {
                        Font newFont = new Font(font.FontFamily, fontSize.Value, fontStyle, GraphicsUnit.Point);
                        windowsuiMockupControl.UpdateControlFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                        RegistryHelper.SetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                    }
                }
            }
        }

        private void checkBoxFontBold_CheckedChanged(object sender, EventArgs e)
        {
            if (CurrentUiElementSelected != null)
            {
                if (CurrentUiElementSelected.HasAssociatedFont)
                {
                    Font font = RegistryHelper.GetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value);

                    float? fontSize = GetFontSize();
                    if (!fontSize.HasValue)
                    {
                        return;
                    }

                    FontStyle fontStyle = GetFontStyle();

                    Font newFont = new Font(font.FontFamily, fontSize.Value, fontStyle,GraphicsUnit.Point);

                    windowsuiMockupControl.UpdateControlFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                    RegistryHelper.SetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                }
            }
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

        private void sizeUpDown_Font_TextChanged(object sender, EventArgs e)
        {
            float? size = GetFontSize();
            if (size.HasValue)
            {
                string newSize = size.ToString();
                if (sizeUpDown_Font.Text != newSize)
                {
                    sizeUpDown_Font.Text = newSize;
                }
            }
        }
    }
}
