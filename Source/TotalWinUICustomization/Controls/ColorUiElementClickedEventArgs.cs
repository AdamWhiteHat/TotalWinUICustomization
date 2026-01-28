using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalWinUICustomization.Types;

namespace TotalWinUICustomization.Controls
{
    public class ColorUiElementClickedEventArgs : EventArgs
    {
        public UIElementAssociation ElementClicked { get; private set; }

        public ColorUiElementClickedEventArgs(UIElementAssociation elementClicked)
            : base()
        {
            ElementClicked = elementClicked;
        }
    }
}
