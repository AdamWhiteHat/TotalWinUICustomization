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

        protected bool IsDirty { get { return windowsuiMockupControl.IsDirty; } }

        private static string _titleText = "Control Freak - Total Windows Customization";
        private static string _pendingChangesFormatText = "{0} pending changes...";

        public MainForm()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();

            fontPickerDialog.AllowVectorFonts = false;
            fontPickerDialog.AllowVerticalFonts = false;

            this.AllowTransparency = true;

            Load += MainForm_Load;
            FormClosing += MainForm_FormClosing;

            font_ClickInterceptorBox.Click += font_ClickInterceptorBox_Click;
            comboFontSize.TextChanged += comboFontSize_TextChanged;
            comboFontSize.SelectedIndexChanged += comboFontSize_SelectedItemChanged;

            checkBoxFontItalic.CheckedChanged += checkBoxFontStyle_CheckedChanged;
            checkBoxFontBold.CheckedChanged += checkBoxFontStyle_CheckedChanged;

            comboBoxFontPropertySelection.SelectionChangeCommitted += comboBoxFontPropertySelection_SelectionChangeCommitted;
            comboBoxColorPropertySelection.SelectionChangeCommitted += comboBoxColorPropertySelection_SelectionChangeCommitted;

            buttonColorProperty1.Click += buttonPropertyColor1_Click;
            panelColorPropertySwatch1.Click += buttonPropertyColor1_Click;
            buttonFontColor.Click += buttonFontColor_Click;
            panelFontColorSwatch.Click += buttonFontColor_Click;

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

            buttonChangesApply.Click += ButtonChangesApply_Click;
            buttonChangesDiscard.Click += ButtonChangesDiscard_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Populate property selection ComboBox with all available properties
            foreach (var item in Enum.GetValues(typeof(WindowsUiElements)).OfType<WindowsUiElements>())
            {
                comboBoxColorPropertySelection.Items.Add(item);
            }

            // Populate font ComboBox with all available system TrueType fonts
            foreach (FontFamily family in FontHelper.FontFamilies)
            {
                comboBoxFontPropertySelection.Items.Add(family.Name);
            }

            UpdateDirtyIndicators();
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
            if (comboBoxColorPropertySelection.SelectedIndex != -1)
            {
                return (WindowsUiElements)comboBoxColorPropertySelection.Items[comboBoxColorPropertySelection.SelectedIndex];
            }
            return null;
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
                    float? fontSize = GetSelectedFontSize();

                    FontStyle fontStyle = GetSelectedFontStyle();

                    if (fontSize.HasValue)
                    {
                        return new Font(selectedFontFamily, fontSize.Value, fontStyle, GraphicsUnit.World);
                    }
                    //else
                    //{
                    //    //throw new Exception("No font size selected.");
                    //    return new Font(selectedFontFamily, selectedFontFamily.GetEmHeight(fontStyle), fontStyle );
                    //}
                }
            }
            return null;
        }

        public float? GetSelectedFontSize()
        {
            if (float.TryParse(comboFontSize.Text, out float fontSize))
            {
                return (float)Math.Round(fontSize, 1);
            }
            if (string.IsNullOrWhiteSpace(comboFontSize.Text))
            {
                comboFontSize.SelectedIndex = -1;
            }
            return null;
        }

        public FontStyle GetSelectedFontStyle()
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
            if (!CurrentUiElementSelected.HasAssociatedFont)
            {
                return;
            }

            int index = FontHelper.FontFamilies.IndexOf(font.FontFamily);
            if (index == -1)
            {
                return;
            }

            if (comboBoxFontPropertySelection.SelectedIndex != index)
            {
                comboBoxFontPropertySelection.SelectedIndex = index;
            }
        }

        public void SetFontSize(float fontSize)
        {
            if (!CurrentUiElementSelected.HasAssociatedFont)
            {
                return;
            }

            List<float> sizes = comboFontSize.Items.Cast<string>().Select(s => float.Parse(s)).ToList();
            if (!sizes.Contains(fontSize))
            {
                sizes.Add(fontSize);
                sizes = sizes.OrderByDescending(s => s).ToList();

                comboFontSize.SelectedIndexChanged -= comboFontSize_SelectedItemChanged;
                comboFontSize.TextChanged -= comboFontSize_TextChanged;

                comboFontSize.Items.Clear();
                comboFontSize.SelectedIndex = -1;
                comboFontSize.Items.AddRange(sizes.Select(f => f.ToString()).ToArray());

                comboFontSize.SelectedIndexChanged += comboFontSize_SelectedItemChanged;
                comboFontSize.TextChanged += comboFontSize_TextChanged;
            }

            int fontSizeIndex = comboFontSize.Items.IndexOf(fontSize.ToString());
            if (comboFontSize.SelectedIndex != fontSizeIndex)
            {
                comboFontSize.SelectedIndex = fontSizeIndex;
            }
        }

        public void SetFontStyle(Font font)
        {
            if (!CurrentUiElementSelected.HasAssociatedFont)
            {
                return;
            }

            if (checkBoxFontBold.Checked != font.Bold)
            {
                checkBoxFontBold.Checked = font.Bold;
            }
            if (checkBoxFontItalic.Checked != font.Italic)
            {
                checkBoxFontItalic.Checked = font.Italic;
            }
        }

        public void SetFontColor(Color color)
        {
            if (!CurrentUiElementSelected.HasAssociatedFontColor)
            {
                return;
            }

            if (!panelFontColorSwatch.BackColor.Equals(color))
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

                Color currentElementColor = Color.Empty;

                WindowsUiElements setting = clickedElement.ControlElement.Value;
                SettingUpdateAction pending = windowsuiMockupControl.SearchPendingUpdates(setting);
                if (pending != default(SettingUpdateAction))
                {
                    currentElementColor = pending.ColorValue;
                }
                else
                {
                    currentElementColor = RegistryHelper.GetWindowsColor(setting);
                }

                if (currentElementColor != Color.Empty)
                {
                    panelColorPropertySwatch1.BackColor = currentElementColor;
                }
            }
            else
            {
                //comboBoxColorPropertySelection.ClearSelection();
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

                Font font=null;


                WindowsUiElements setting = clickedElement.AssociatedFont.Value;
                SettingUpdateAction pending = windowsuiMockupControl.SearchPendingUpdates(setting);
                if (pending != default(SettingUpdateAction))
                {
                    font = pending.FontValue;
                }
                else
                {
                    font = RegistryHelper.GetWindowsFont(setting);
                }

                if (font != null)
                {
                    SetFontComboBoxFont(font);

                    float fontSize = (float)Math.Round(font.Size,1);
                    SetFontSize(fontSize);

                    SetFontStyle(font);
                }

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

                Color currentFontColor = Color.Empty;

                WindowsUiElements setting = clickedElement.AssociatedFontColor.Value;
                SettingUpdateAction pending = windowsuiMockupControl.SearchPendingUpdates(setting);
                if (pending != default(SettingUpdateAction))
                {
                    currentFontColor = pending.ColorValue;
                }
                else
                {
                    currentFontColor = RegistryHelper.GetWindowsColor(setting);
                }

                if (currentFontColor != Color.Empty)
                {
                    panelFontColorSwatch.BackColor = currentFontColor;
                }

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

            UpdateDirtyIndicators();
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

        #region Methods that make a settings change

        private void comboBoxFontPropertySelection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CurrentUiElementSelected == null)
            {
                return;
            }
            if (!CurrentUiElementSelected.HasAssociatedFont)
            {
                return;
            }

            Font newFont = GetSelectedComboBoxFont();
            if (newFont == null)
            {
                return;
            }

            Font oldFont = RegistryHelper.GetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value);
            if (!oldFont.Equals(newFont))
            {
                windowsuiMockupControl.UpdateControlFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                UpdateDirtyIndicators();
                //RegistryHelper.SetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value, selectedFont);
            }
            else
            {
                if (windowsuiMockupControl.RemovePendingUpdate(CurrentUiElementSelected.AssociatedFont.Value))
                {
                    UpdateDirtyIndicators();
                }
            }
        }

        private void buttonPropertyColor1_Click(object sender, EventArgs e)
        {
            colorPickerDialog.Color = panelColorPropertySwatch1.BackColor;
            if (colorPickerDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Color selectedColor = colorPickerDialog.Color;
            panelColorPropertySwatch1.BackColor = selectedColor;
            WindowsUiElements? selectedProperty = GetSelectedComboBoxUIProperty();
            if (selectedProperty.HasValue)
            {
                windowsuiMockupControl.UpdateControlColor(selectedProperty.Value, selectedColor);
                UpdateDirtyIndicators();
                //RegistryHelper.SetWindowsColor(selectedProperty.Value, selectedColor);
            }
        }

        private void buttonPropertyColor2_Click(object sender, EventArgs e)
        {
            // Currently not in use, but things like the second color for a gradient title bar color would use this.
        }

        private void comboFontSize_SelectedItemChanged(object sender, EventArgs e)
        {
            if (CurrentUiElementSelected == null)
            {
                comboFontSize.SelectedIndex = -1;
                return;
            }
            if (!CurrentUiElementSelected.HasAssociatedFont)
            {
                comboFontSize.SelectedIndex = -1;
                return;
            }

            float? newFontSize = GetSelectedFontSize();
            if (!newFontSize.HasValue || newFontSize <= 0)
            {
                return;
            }

            Font oldFont = RegistryHelper.GetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value);
            if (newFontSize == oldFont.Size)
            {
                return;
            }

            Font newFont = GetSelectedComboBoxFont();
            if (!oldFont.Equals(newFont))
            {
                windowsuiMockupControl.UpdateControlFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                UpdateDirtyIndicators();
                //RegistryHelper.SetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
            }
            else
            {
                if (windowsuiMockupControl.RemovePendingUpdate(CurrentUiElementSelected.AssociatedFont.Value))
                {
                    UpdateDirtyIndicators();
                }
            }
        }

        private void checkBoxFontStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (CurrentUiElementSelected == null)
            {
                return;
            }
            if (!CurrentUiElementSelected.HasAssociatedFont)
            {
                return;
            }

            Font oldFont = RegistryHelper.GetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value);
            Font newFont = GetSelectedComboBoxFont();
            if (newFont == null)
            {
                return;
            }

            if (!oldFont.Equals(newFont))
            {
                windowsuiMockupControl.UpdateControlFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                UpdateDirtyIndicators();
                //RegistryHelper.SetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
            }
            else
            {
                if (windowsuiMockupControl.RemovePendingUpdate(CurrentUiElementSelected.AssociatedFont.Value))
                {
                    UpdateDirtyIndicators();
                }
            }
        }

        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            colorPickerDialog.Color = panelFontColorSwatch.BackColor;
            if (colorPickerDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Color newColor = colorPickerDialog.Color;
            panelFontColorSwatch.BackColor = newColor;

            if (CurrentUiElementSelected == null)
            {
                return;
            }

            WindowsUiElements? selectedProperty = CurrentUiElementSelected.AssociatedFontColor;
            if (!selectedProperty.HasValue)
            {
                return;
            }

            Color oldColor = RegistryHelper.GetWindowsColor(selectedProperty.Value);
            if (!oldColor.Equals(newColor))
            {
                windowsuiMockupControl.UpdateControlColor(selectedProperty.Value, newColor);
                UpdateDirtyIndicators();
                //RegistryHelper.SetWindowsColor(selectedProperty.Value, selectedColor);
            }
            else
            {
                if (windowsuiMockupControl.RemovePendingUpdate(selectedProperty.Value))
                {
                    UpdateDirtyIndicators();
                }
            }
        }

        private void comboFontSize_TextChanged(object sender, EventArgs e)
        {
            float? size = GetSelectedFontSize();
            if (!size.HasValue)
            {
                return;
            }

            string newSize = size.ToString();
            if (comboFontSize.Text == newSize)
            {
                return;
            }

            comboFontSize.Text = newSize;
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

            Font oldFont = null;
            SettingUpdateAction found = windowsuiMockupControl.SearchPendingUpdates(CurrentUiElementSelected.AssociatedFont.Value);
            if (found == default(SettingUpdateAction))
            {
                oldFont = RegistryHelper.GetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value);
            }
            fontPickerDialog.Font = oldFont;

            Color oldColor = Color.Empty;
            bool fontHasColor = false;
            if (CurrentUiElementSelected.AssociatedFontColor.HasValue)
            {
                oldColor = RegistryHelper.GetWindowsColor(CurrentUiElementSelected.AssociatedFontColor.Value);
                fontPickerDialog.Color = oldColor;
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
                if (!newFont.Equals(oldFont))
                {
                    SetFontComboBoxFont(newFont);
                    SetFontStyle(newFont);

                    float fontSize = (float)Math.Round(newFont.Size, 1);
                    SetFontSize(fontSize);

                    windowsuiMockupControl.UpdateControlFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                    UpdateDirtyIndicators();
                    //RegistryHelper.SetWindowsFont(CurrentUiElementSelected.AssociatedFont.Value, newFont);
                }

                if (fontHasColor)
                {
                    Color newColor = fontPickerDialog.Color;

                    if (!newColor.Equals(oldColor))
                    {
                        SetFontColor(newColor);

                        windowsuiMockupControl.UpdateControlColor(CurrentUiElementSelected.AssociatedFontColor.Value, newColor);
                        UpdateDirtyIndicators();
                        //RegistryHelper.SetWindowsColor(CurrentUiElementSelected.AssociatedFontColor.Value, newColor);
                    }
                }
            }
            else
            {
                UpdateComboboxes();
            }

            panelInnerFontProperty.Enabled = true;
        }

        #endregion

        #region IsDirty state

        private void UpdateDirtyIndicators()
        {
            if (IsDirty)
            {
                this.Text = _titleText + " *";

                labelChangesUnsaved.Text = string.Format(_pendingChangesFormatText, windowsuiMockupControl.PendingChangesCount);

                panelApplyChanges.Visible = true;
            }
            else
            {
                this.Text = _titleText;

                labelChangesUnsaved.Text = string.Format(_pendingChangesFormatText, 0);

                panelApplyChanges.Visible = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsDirty)
            {
                var dialogResult = MessageBox.Show(string.Format("You have {0} unsaved changes. Are you sure you want to exit and lose your changes?", windowsuiMockupControl.PendingChangesCount), "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    windowsuiMockupControl.AbortChanges();
                }
            }
        }

        private void ButtonChangesDiscard_Click(object sender, EventArgs e)
        {
            if (IsDirty)
            {
                windowsuiMockupControl.AbortChanges();
            }
            UpdateDirtyIndicators();
        }

        private void ButtonChangesApply_Click(object sender, EventArgs e)
        {
            if (IsDirty)
            {
                windowsuiMockupControl.AcceptChanges();
                MessageBox.Show("Settings applied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UpdateDirtyIndicators();
        }

        private void labelChangesUnsaved_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PendingChangesForm editPendingChanges = new PendingChangesForm(this, windowsuiMockupControl.SettingUpdatesPending);

            if (editPendingChanges.ShowDialog() == DialogResult.OK)
            {
                List<SettingUpdateAction> checkedItems =  editPendingChanges.CheckedItems.ToList();
                List<SettingUpdateAction> uncheckedItems = windowsuiMockupControl.SettingUpdatesPending.Except(checkedItems, new SettingOnlyComparer()).ToList();
                List<WindowsUiElements> settingsToReset = uncheckedItems.Select(sua => sua.Setting).ToList();

                if (windowsuiMockupControl.RemovePendingUpdates(settingsToReset))
                {
                    UpdateDirtyIndicators();
                }
            }
        }


        #endregion

    }
}
