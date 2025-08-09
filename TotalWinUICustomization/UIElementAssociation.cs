using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalWinUICustomization.Types;

namespace TotalWinUICustomization
{
    public class UIElementAssociation
    {
        public static UIElementAssociation InactiveTitle            = new UIElementAssociation() { ControlElement = WindowsUiElements.InactiveTitle,            AssociatedFontColor = WindowsUiElements.InactiveTitleText,  AssociatedFont = WindowsUiElements.CaptionFont  };
        public static UIElementAssociation ActiveTitle              = new UIElementAssociation() { ControlElement = WindowsUiElements.ActiveTitle,              AssociatedFontColor = WindowsUiElements.ActiveTitleText,    AssociatedFont = WindowsUiElements.CaptionFont  };
        public static UIElementAssociation Window                   = new UIElementAssociation() { ControlElement = WindowsUiElements.Window,                   AssociatedFontColor = WindowsUiElements.WindowText,         AssociatedFont = WindowsUiElements.MessageFont  };
        public static UIElementAssociation ButtonFace               = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonFace,               AssociatedFontColor = WindowsUiElements.ButtonText,         AssociatedFont = WindowsUiElements.MessageFont  };
        public static UIElementAssociation Menu                     = new UIElementAssociation() { ControlElement = WindowsUiElements.Menu,                     AssociatedFontColor = WindowsUiElements.MenuText,           AssociatedFont = WindowsUiElements.MenuFont     };
        public static UIElementAssociation MenuBar                  = new UIElementAssociation() { ControlElement = WindowsUiElements.MenuBar,                  AssociatedFontColor = WindowsUiElements.MenuText,           AssociatedFont = WindowsUiElements.MenuFont     };
        public static UIElementAssociation GreyText                 = new UIElementAssociation() { ControlElement = WindowsUiElements.GreyText,                                                                             AssociatedFont = WindowsUiElements.MenuFont     };
        public static UIElementAssociation MenuHighlight            = new UIElementAssociation() { ControlElement = WindowsUiElements.MenuHighlight,            AssociatedFontColor = WindowsUiElements.HighlightText,      AssociatedFont = WindowsUiElements.MenuFont     };
        public static UIElementAssociation Highlight                = new UIElementAssociation() { ControlElement = WindowsUiElements.Highlight,                AssociatedFontColor = WindowsUiElements.HighlightText,      AssociatedFont = WindowsUiElements.MessageFont  };
        public static UIElementAssociation InfoWindow               = new UIElementAssociation() { ControlElement = WindowsUiElements.InfoWindow,               AssociatedFontColor = WindowsUiElements.InfoText,           AssociatedFont = WindowsUiElements.StatusFont   };
        public static UIElementAssociation DesktopBackground        = new UIElementAssociation() { ControlElement = WindowsUiElements.DesktopBackground,                                                                    AssociatedFont = WindowsUiElements.IconFont     };

        public static UIElementAssociation InactiveTitleGradient    = new UIElementAssociation() { ControlElement = WindowsUiElements.InactiveTitleGradient                                                                                                                 };
        public static UIElementAssociation ActiveTitleGradient      = new UIElementAssociation() { ControlElement = WindowsUiElements.ActiveTitleGradient                                                                                                                   };
        public static UIElementAssociation InactiveBorder           = new UIElementAssociation() { ControlElement = WindowsUiElements.InactiveBorder                                                                                                                        };
        public static UIElementAssociation ActiveBorder             = new UIElementAssociation() { ControlElement = WindowsUiElements.ActiveBorder                                                                                                                          };
        public static UIElementAssociation WindowFrame              = new UIElementAssociation() { ControlElement = WindowsUiElements.WindowFrame                                                                                                                           };
        public static UIElementAssociation Scrollbar                = new UIElementAssociation() { ControlElement = WindowsUiElements.Scrollbar                                                                                                                             };
        public static UIElementAssociation HotTrackingColor         = new UIElementAssociation() { ControlElement = WindowsUiElements.HotTrackingColor                                                                                                                      };
        public static UIElementAssociation AppWorkspace             = new UIElementAssociation() { ControlElement = WindowsUiElements.AppWorkspace                                                                                                                          };

        public static UIElementAssociation ButtonAlternateFace      = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonAlternateFace                                                                                                                   };
        public static UIElementAssociation ButtonDkShadow           = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonDkShadow                                                                                                                        };
        public static UIElementAssociation ButtonHighlight          = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonHighlight                                                                                                                       };
        public static UIElementAssociation ButtonLight              = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonLight                                                                                                                           };
        public static UIElementAssociation ButtonShadow             = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonShadow                                                                                                                          };

        public static UIElementAssociation InactiveTitleText        = new UIElementAssociation() {                                                              AssociatedFontColor = WindowsUiElements.InactiveTitleText,  AssociatedFont = WindowsUiElements.CaptionFont  };
        public static UIElementAssociation ActiveTitleText          = new UIElementAssociation() {                                                              AssociatedFontColor = WindowsUiElements.ActiveTitleText,    AssociatedFont = WindowsUiElements.CaptionFont  };
        public static UIElementAssociation WindowText               = new UIElementAssociation() {                                                              AssociatedFontColor = WindowsUiElements.WindowText,         AssociatedFont = WindowsUiElements.MessageFont  };
        public static UIElementAssociation ButtonText               = new UIElementAssociation() {                                                              AssociatedFontColor = WindowsUiElements.ButtonText,         AssociatedFont = WindowsUiElements.MessageFont  };
        public static UIElementAssociation MenuText                 = new UIElementAssociation() {                                                              AssociatedFontColor = WindowsUiElements.MenuText,           AssociatedFont = WindowsUiElements.MenuFont     };
        public static UIElementAssociation HighlightText            = new UIElementAssociation() {                                                              AssociatedFontColor = WindowsUiElements.HighlightText,      AssociatedFont = WindowsUiElements.MenuFont     };
        public static UIElementAssociation InfoText                 = new UIElementAssociation() {                                                              AssociatedFontColor = WindowsUiElements.InfoText,           AssociatedFont = WindowsUiElements.StatusFont   };

        public static UIElementAssociation CaptionFont              = new UIElementAssociation() {                                                                                                                          AssociatedFont = WindowsUiElements.CaptionFont  };
        public static UIElementAssociation SmCaptionFont            = new UIElementAssociation() {                                                                                                                          AssociatedFont = WindowsUiElements.SmCaptionFont};
        public static UIElementAssociation MenuFont                 = new UIElementAssociation() {                                                                                                                          AssociatedFont = WindowsUiElements.MenuFont     };
        public static UIElementAssociation MessageFont              = new UIElementAssociation() {                                                                                                                          AssociatedFont = WindowsUiElements.MessageFont  };
        public static UIElementAssociation IconFont                 = new UIElementAssociation() {                                                                                                                          AssociatedFont = WindowsUiElements.IconFont     };
        public static UIElementAssociation StatusFont               = new UIElementAssociation() {                                                                                                                          AssociatedFont = WindowsUiElements.StatusFont   };

        public static List<UIElementAssociation> AllAssociations = new List<UIElementAssociation>()
        {
            InactiveTitle        ,
            InactiveTitleGradient,
            InactiveBorder       ,
            ActiveTitle          ,
            ActiveTitleGradient  ,
            ActiveBorder         ,
            Window               ,
            WindowFrame          ,
            ButtonFace           ,
            ButtonAlternateFace  ,
            ButtonDkShadow       ,
            ButtonHighlight      ,
            ButtonLight          ,
            ButtonShadow         ,
            Menu                 ,
            MenuHighlight        ,
            GreyText             ,
            DesktopBackground    ,
            Highlight            ,
            InfoWindow           ,
            Scrollbar            ,
            HotTrackingColor     ,
            MenuBar              ,
            AppWorkspace         ,

            InactiveTitleText    ,
            ActiveTitleText      ,
            WindowText           ,
            ButtonText           ,
            MenuText             ,
            HighlightText        ,
            InfoText             ,

            CaptionFont          ,
            SmCaptionFont        ,
            MenuFont             ,
            MessageFont          ,
            IconFont             ,
            StatusFont           ,
        };

        public WindowsUiElements? ControlElement { get; set; } = null;
        public WindowsUiElements? AssociatedFontColor { get; set; } = null;
        public WindowsUiElements? AssociatedFont { get; set; } = null;

        public bool HasControlElement { get { return ControlElement.HasValue; } }
        public bool HasAssociatedFontColor { get { return AssociatedFontColor.HasValue; } }
        public bool HasAssociatedFont { get { return AssociatedFont.HasValue; } }

        public UIElementAssociation()
        {
            ControlElement = null;
            AssociatedFont = null;
            AssociatedFontColor = null;
        }
    }
}
