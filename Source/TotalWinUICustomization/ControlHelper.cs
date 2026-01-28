using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalWinUICustomization
{
    public static class ControlHelper
    {
        public static Control FindParentControl(Control childControl)
        {
            bool isFound = false;
            Control result = null;
            Control currentControl = childControl;

            Form parentForm = childControl.FindForm();

            while (!isFound)
            {
                if (childControl.SelectNextControl(currentControl, false, false, true, true))
                {
                    currentControl = parentForm.ActiveControl;

                    if (currentControl.Controls.Contains(childControl))
                    {
                        result = currentControl;
                        isFound = true;
                        break;
                    }
                }

                if (currentControl == childControl)
                {
                    break;
                }
            }

            if (isFound)
            {
                return result;
            }
            return null;
        }
    }

    public static class ControlExtensionMethods
    {
        public static void ClearSelection(this ComboBox comboBox)
        {
            if (comboBox.SelectedIndex != -1)
            {
                comboBox.SelectedIndex = -1;
            }
        }

        public static void Enable(this Panel panel)
        {
            if (!panel.Enabled)
            {
                panel.Enabled = true;
            }
        }

        public static void Disable(this Panel panel)
        {
            if (panel.Enabled)
            {
                panel.Enabled = false;
            }
        }
    }
}
