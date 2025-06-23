using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
