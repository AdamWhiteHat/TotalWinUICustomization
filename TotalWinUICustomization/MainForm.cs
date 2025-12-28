using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using TotalWinUICustomization.Controls;
using TotalWinUICustomization.Types;

namespace TotalWinUICustomization
{
    public partial class MainForm : Form
    {
        protected UIElementAssociation CurrentUiElementSelected { get; set; }

        public MainForm()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();

            fontPickerDialog.AllowVectorFonts = false;
            fontPickerDialog.AllowVerticalFonts = false;

            this.AllowTransparency = true;

            Load += MainForm_Load;
            comboBoxColorPropertySelection.SelectionChangeCommitted += comboBoxColorPropertySelection_SelectionChangeCommitted;
            font_ClickInterceptorBox.Click += font_ClickInterceptorBox_Click;
            buttonColorProperty1.Click += buttonPropertyColor1_Click;
            panelColorPropertySwatch1.Click += buttonPropertyColor1_Click;
            checkBoxFontItalic.CheckedChanged += checkBoxFontStyle_CheckedChanged;
            comboFontSize.SelectedIndexChanged += comboFontSize_SelectedItemChanged;
            comboFontSize.TextChanged += comboFontSize_TextChanged;
            checkBoxFontBold.CheckedChanged += checkBoxFontStyle_CheckedChanged;
            comboBoxFontPropertySelection.SelectionChangeCommitted += comboBoxFontPropertySelection_SelectionChangeCommitted;
            windowsuiMockupControl.ColorUiElementClicked += WindowsuiMockupControl_ColorUiElementClicked;

            panelColorPropertyLeft.Disable();
            panelColorProperty1.Disable();
            panelColorProperty2.Disable();

            panelFontPropertyLeft.Disable();
            panelFontPropertyRight.Disable();
            panelFontPropertyColor.Disable();

            panelColorPropertySwatch1.EnabledChanged += ColorSwatch_EnabledChanged;
            panelColorPropertySwatch2.EnabledChanged += ColorSwatch_EnabledChanged;
            panelFontColorSwatch.EnabledChanged += ColorSwatch_EnabledChanged;
            comboBoxColorPropertySelection.EnabledChanged += ComboBox_EnabledChanged;
            comboBoxFontPropertySelection.EnabledChanged += ComboBox_EnabledChanged;
            comboFontSize.EnabledChanged += comboFontSize_EnabledChanged;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            windowsuiMockupControl.LoadSizes();

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

        private void comboFontSize_EnabledChanged(object sender, EventArgs e)
        {
            ComboBox source = sender as ComboBox;
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
                    float? fontSize = GetFontSize();

                    if (fontSize.HasValue)
                    {
                        return new Font(selectedFontFamily, fontSize.Value, GraphicsUnit.Point);
                    }
                    else
                    {
                        return new Font(selectedFontFamily, selectedFontFamily.GetEmHeight(FontStyle.Regular));
                    }
                }
            }
            return null;
        }

        public float? GetFontSize()
        {
            if (float.TryParse(comboFontSize.Text, out float fontSize))
            {
                return (float)Math.Round(fontSize, 1);
            }
            return null;
        }

        public FontStyle GetFontStyle()
        {
            FontStyle result = FontStyle.Regular;
            if (checkBoxFontBold.Checked)
            {
                result |= FontStyle.Bold;
            }
            if (checkBoxFontItalic.Checked)
            {
                result |= FontStyle.Italic;
            }
            return result;
        }

        public void SetFontComboBoxFont(Font font)
        {
            if (CurrentUiElementSelected.HasAssociatedFont)
            {
                int index = FontHelper.FontFamilies.IndexOf(font.FontFamily);
                if (index != -1)
                {
                    comboBoxFontPropertySelection.SelectedIndex = index;
                }
            }
        }

        public void SetFontSize(float fontSize)
        {
            if (CurrentUiElementSelected.HasAssociatedFont)
            {
                List<float> sizes = comboFontSize.Items.Cast<string>().Select(s => float.Parse(s)).ToList();
                if (!sizes.Contains(fontSize))
                {
                    sizes.Add(fontSize);
                    sizes = sizes.OrderByDescending(s => s).ToList();
                    comboFontSize.Items.Clear();
                    comboFontSize.Items.AddRange(sizes.Select(f => f.ToString()).ToArray());
                }

                int fontSizeIndex = comboFontSize.Items.IndexOf(fontSize.ToString());
                comboFontSize.SelectedIndex = -1;
                comboFontSize.SelectedIndex = fontSizeIndex;
            }
        }

        public void SetFontStyle(Font font)
        {
            if (CurrentUiElementSelected.HasAssociatedFont)
            {
                checkBoxFontBold.Checked = font.Bold;
                checkBoxFontItalic.Checked = font.Italic;
            }
        }

        public void SetFontColor(Color color)
        {
            if (CurrentUiElementSelected.HasAssociatedFontColor)
            {
                panelFontColorSwatch.BackColor = color;
            }
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

            #region AssociatedFont

            // Update associated font
            if (clickedElement.HasAssociatedFont)
            {
                panelFontPropertyLeft.Enable();
                panelFontPropertyRight.Enable();

                Font font = RegistryHelper.GetWindowsFont(clickedElement.AssociatedFont.Value);
                SetFontComboBoxFont(font);

                float fontSize = (float)Math.Round(font.SizeInPoints,1);
                SetFontSize(fontSize);

                SetFontStyle(font);

                if (!clickedElement.HasControlElement && !clickedElement.HasAssociatedFontColor)
                {
                    panelColorPropertyLeft.Enable();
                    comboBoxColorPropertySelection.SelectedItem = clickedElement.AssociatedFont.Value;
                }
            }
            else
            {
                panelFontPropertyLeft.Disable();
                panelFontPropertyRight.Disable();
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

        private void comboFontSize_SelectedItemChanged(object sender, EventArgs e)
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

        private void checkBoxFontStyle_CheckedChanged(object sender, EventArgs e)
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

        private void comboFontSize_TextChanged(object sender, EventArgs e)
        {
            float? size = GetFontSize();
            if (size.HasValue)
            {
                string newSize = size.ToString();
                if (comboFontSize.Text != newSize)
                {
                    comboFontSize.Text = newSize;
                }
            }
        }

        private void font_ClickInterceptorBox_Click(object sender, EventArgs e)
        {
            if (CurrentUiElementSelected == null)
            {
                return;
            }

            if (!CurrentUiElementSelected.HasAssociatedFont)
            {
                return;
            }

            panelInnerFontProperty.Enabled = false;

            Font oldFont = RegistryHelper.GetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value);
            fontPickerDialog.Font = oldFont;

            bool fontHasColor = false;
            if (CurrentUiElementSelected.AssociatedFontColor.HasValue)
            {
                Color oldFontColor = RegistryHelper.GetWindowsColor(CurrentUiElementSelected.AssociatedFontColor.Value);
                fontPickerDialog.Color = oldFontColor;
                fontHasColor = true;
            }

            font_ClickInterceptorBox.Visible = false;
            panelInnerFontProperty.Visible = false;
            thatchedPanel1.Visible = true;
            thatchedPanel1.BringToFront();
            DialogResult fontDialogResult = fontPickerDialog.ShowDialog();
            thatchedPanel1.Visible = false;
            thatchedPanel1.SendToBack();
            panelInnerFontProperty.Visible = true;
            font_ClickInterceptorBox.Visible = true;

            if (fontDialogResult == DialogResult.OK)
            {
                Font newFont = fontPickerDialog.Font;

                SetFontComboBoxFont(newFont);
                SetFontStyle(newFont);
                SetFontSize(newFont.SizeInPoints);

                windowsuiMockupControl.UpdateControlFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                RegistryHelper.SetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);

                if (fontHasColor)
                {
                    Color newColor = fontPickerDialog.Color;
                    SetFontColor(newColor);

                    windowsuiMockupControl.UpdateControlColor(CurrentUiElementSelected.AssociatedFontColor.Value, newColor);
                    RegistryHelper.SetWindowsColor(CurrentUiElementSelected.AssociatedFontColor.Value, newColor);
                }
            }
            else
            {
                UpdateComboboxes();
            }

            panelInnerFontProperty.Enabled = true;
        }
    }
}
