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
        public static UIElementAssociation InactiveTitle            = new UIElementAssociation() { ControlElement = WindowsUiElements.InactiveTitle, AssociatedFontColor = WindowsUiElements.InactiveTitleText, AssociatedFont = SystemFontGroup.CaptionFont };
        public static UIElementAssociation InactiveTitleGradient    = new UIElementAssociation() { ControlElement = WindowsUiElements.InactiveTitleGradient };
        public static UIElementAssociation InactiveBorder           = new UIElementAssociation() { ControlElement = WindowsUiElements.InactiveBorder };
        public static UIElementAssociation ActiveTitle              = new UIElementAssociation() { ControlElement = WindowsUiElements.ActiveTitle, AssociatedFontColor = WindowsUiElements.ActiveTitleText, AssociatedFont = SystemFontGroup.CaptionFont };
        public static UIElementAssociation ActiveTitleGradient      = new UIElementAssociation() { ControlElement = WindowsUiElements.ActiveTitleGradient };
        public static UIElementAssociation ActiveBorder             = new UIElementAssociation() { ControlElement = WindowsUiElements.ActiveBorder };
        public static UIElementAssociation Window                   = new UIElementAssociation() { ControlElement = WindowsUiElements.Window, AssociatedFontColor = WindowsUiElements.WindowText, AssociatedFont = SystemFontGroup.MessageFont };
        public static UIElementAssociation WindowFrame              = new UIElementAssociation() { ControlElement = WindowsUiElements.WindowFrame };
        public static UIElementAssociation ButtonFace               = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonFace, AssociatedFontColor = WindowsUiElements.ButtonText, AssociatedFont = SystemFontGroup.SmCaptionFont };
        public static UIElementAssociation ButtonAlternateFace      = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonAlternateFace };
        public static UIElementAssociation ButtonDkShadow           = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonDkShadow };
        public static UIElementAssociation ButtonHighlight          = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonHighlight };
        public static UIElementAssociation ButtonLight              = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonLight };
        public static UIElementAssociation ButtonShadow             = new UIElementAssociation() { ControlElement = WindowsUiElements.ButtonShadow };
        public static UIElementAssociation Menu                     = new UIElementAssociation() { ControlElement = WindowsUiElements.Menu, AssociatedFontColor = WindowsUiElements.MenuText, AssociatedFont = SystemFontGroup.MenuFont };
        public static UIElementAssociation MenuHighlight            = new UIElementAssociation() { ControlElement = WindowsUiElements.MenuHighlight, AssociatedFontColor = WindowsUiElements.HighlightText, AssociatedFont = SystemFontGroup.MenuFont };
        public static UIElementAssociation GreyText                 = new UIElementAssociation() { ControlElement = WindowsUiElements.GreyText, AssociatedFont = SystemFontGroup.MenuFont };
        public static UIElementAssociation DesktopBackground        = new UIElementAssociation() { ControlElement = WindowsUiElements.DesktopBackground };
        public static UIElementAssociation Highlight                = new UIElementAssociation() { ControlElement = WindowsUiElements.Highlight, AssociatedFontColor = WindowsUiElements.HighlightText, AssociatedFont = SystemFontGroup.MessageFont };
        public static UIElementAssociation InfoWindow               = new UIElementAssociation() { ControlElement = WindowsUiElements.InfoWindow, AssociatedFontColor = WindowsUiElements.InfoText, AssociatedFont = SystemFontGroup.StatusFont };
        public static UIElementAssociation Scrollbar                = new UIElementAssociation() { ControlElement = WindowsUiElements.Scrollbar };
        public static UIElementAssociation HotTrackingColor         = new UIElementAssociation() { ControlElement = WindowsUiElements.HotTrackingColor };
        public static UIElementAssociation MenuBar                  = new UIElementAssociation() { ControlElement = WindowsUiElements.MenuBar };
        public static UIElementAssociation AppWorkspace             = new UIElementAssociation() { ControlElement = WindowsUiElements.AppWorkspace };
        public static UIElementAssociation IconFont                 = new UIElementAssociation() { AssociatedFont = SystemFontGroup.IconFont };

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
            IconFont             ,
        };

        public WindowsUiElements? ControlElement { get; set; }

        public SystemFontGroup? AssociatedFont { get; set; }

        public WindowsUiElements? AssociatedFontColor { get; set; }

        public UIElementAssociation()
        {
            ControlElement = null;
            AssociatedFont = null;
            AssociatedFontColor = null;
        }
    }
}
