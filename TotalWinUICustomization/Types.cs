using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWinUICustomization.Types
{
    public enum WindowsUiElements
    {
        InactiveTitle,
        InactiveTitleText,
        InactiveTitleGradient,

        ActiveTitle,
        ActiveTitleText,
        ActiveTitleGradient,

        Window,
        WindowText,

        ButtonFace,
        ButtonText,

        Menu,
        MenuText,
        GreyText,
        MenuHighlight,

        DesktopBackground,

        Highlight,
        HighlightText,

        InfoWindow,
        InfoText,

        Scrollbar,
        HotTrackingColor,

        // Not Implemented yet
        ActiveBorder,
        InactiveBorder,
        WindowFrame,

        ButtonAlternateFace,
        ButtonDkShadow,
        ButtonHighlight,
        ButtonLight,
        ButtonShadow,

        MenuBar,
        AppWorkspace
    }

    public enum ElementType
    {
        Control,
        Font,
        Both
    }

    public static class Helpers
    {
        public static Dictionary<WindowsUiElements, string> FontEnumToRegistryKey
        {
            get
            {
                return new Dictionary<WindowsUiElements, string>()
                {
                        { WindowsUiElements.InactiveTitleText, "CaptionFont"}, // SmCaptionFont
                        { WindowsUiElements.ActiveTitleText  , "CaptionFont"}, // "SmCaptionFont"
                        { WindowsUiElements.WindowText       , "MessageFont"},
                        { WindowsUiElements.ButtonText       , "MessageFont"},
                        { WindowsUiElements.MenuText         , "MenuFont"}, // 
                        { WindowsUiElements.GreyText         , "MenuFont"}, // 
                        { WindowsUiElements.HighlightText    , "MenuFont"}, // IconFont
                        { WindowsUiElements.InfoText         , "StatusFont" }, // StatusFont
                        { WindowsUiElements.DesktopBackground, "IconFont"}  // 
                };
            }
        }

        public static Dictionary<WindowsUiElements, string> ColorsEnumToRegistryKey
        {
            get
            {
                return new Dictionary<WindowsUiElements, string>()
                {
                    { WindowsUiElements.InactiveTitle, "InactiveTitle" },
                    { WindowsUiElements.InactiveTitleGradient, "GradientInactiveTitle" },
                    { WindowsUiElements.InactiveTitleText, "InactiveTitleText" },
                    { WindowsUiElements.InactiveBorder, "InactiveBorder" },
                    { WindowsUiElements.ActiveTitle, "ActiveTitle" },
                    { WindowsUiElements.ActiveTitleGradient, "GradientActiveTitle" },
                    { WindowsUiElements.ActiveTitleText, "TitleText" },
                    { WindowsUiElements.ActiveBorder, "ActiveBorder" },
                    { WindowsUiElements.Window, "Window" },
                    { WindowsUiElements.WindowText, "WindowText" },
                    { WindowsUiElements.WindowFrame, "WindowFrame" },
                    { WindowsUiElements.ButtonFace, "ButtonFace" },
                    { WindowsUiElements.ButtonText, "ButtonText" },
                    { WindowsUiElements.ButtonAlternateFace, "ButtonAlternateFace" },
                    { WindowsUiElements.ButtonDkShadow, "ButtonDkShadow" },
                    { WindowsUiElements.ButtonHighlight, "ButtonHilight" },
                    { WindowsUiElements.ButtonLight, "ButtonLight" },
                    { WindowsUiElements.ButtonShadow, "ButtonShadow" },
                    { WindowsUiElements.Menu, "Menu" },
                    { WindowsUiElements.MenuHighlight, "MenuHilight" },
                    { WindowsUiElements.MenuText, "MenuText" },
                    { WindowsUiElements.GreyText, "GrayText" },
                    { WindowsUiElements.DesktopBackground, "Background" },
                    { WindowsUiElements.Highlight, "Hilight" },
                    { WindowsUiElements.HighlightText, "HilightText" },
                    { WindowsUiElements.InfoText, "InfoText" },
                    { WindowsUiElements.InfoWindow, "InfoWindow" },
                    { WindowsUiElements.Scrollbar, "Scrollbar" },
                    { WindowsUiElements.HotTrackingColor, "HotTrackingColor" },
                    { WindowsUiElements.MenuBar, "MenuBar" },
                    { WindowsUiElements.AppWorkspace, "AppWorkspace" }
                };
            }
        }

        public static Dictionary<WindowsUiElements, bool> EnumToIsFontDictionary
        {
            get
            {
                return new Dictionary<WindowsUiElements, bool>()
                {
                    { WindowsUiElements.InactiveTitle, false },

                    { WindowsUiElements.InactiveTitleText, true },
                    { WindowsUiElements.InactiveTitleGradient, false },
                    { WindowsUiElements.InactiveBorder, false },
                    { WindowsUiElements.ActiveTitle,false },
                    { WindowsUiElements.ActiveTitleText,true },
                    { WindowsUiElements.ActiveTitleGradient,false },
                    { WindowsUiElements.ActiveBorder,false },
                    { WindowsUiElements.Window,false },
                    { WindowsUiElements.WindowText,true },
                    { WindowsUiElements.WindowFrame,false },
                    { WindowsUiElements.ButtonFace,false },
                    { WindowsUiElements.ButtonText,true },
                    { WindowsUiElements.ButtonAlternateFace,false },
                    { WindowsUiElements.ButtonDkShadow,false },
                    { WindowsUiElements.ButtonHighlight,false },
                    { WindowsUiElements.ButtonLight,false },
                    { WindowsUiElements.ButtonShadow,false },
                    { WindowsUiElements.Menu,false },
                    { WindowsUiElements.MenuText,true },
                    { WindowsUiElements.MenuHighlight,false },
                    { WindowsUiElements.GreyText, false },
                    { WindowsUiElements.DesktopBackground,false },
                    { WindowsUiElements.Highlight,false },
                    { WindowsUiElements.HighlightText,true },
                    { WindowsUiElements.InfoWindow,false },
                    { WindowsUiElements.InfoText,true },
                    { WindowsUiElements.Scrollbar,false },
                    { WindowsUiElements.HotTrackingColor,false },
                    { WindowsUiElements.MenuBar,false },
                    { WindowsUiElements.AppWorkspace,false }
                };
            }
        }

        public static Dictionary<WindowsUiElements, WindowsUiElements?> EnumToCompanionEnum
        {
            get
            {
                return new Dictionary<WindowsUiElements, WindowsUiElements?>()
                {
                    { WindowsUiElements.InactiveTitle, WindowsUiElements.InactiveTitleText },
                    { WindowsUiElements.InactiveTitleText, WindowsUiElements.InactiveTitle },
                    { WindowsUiElements.InactiveTitleGradient, null },
                    { WindowsUiElements.InactiveBorder, null },
                    { WindowsUiElements.ActiveTitle, WindowsUiElements.ActiveTitleText },
                    { WindowsUiElements.ActiveTitleText, WindowsUiElements.ActiveTitle },
                    { WindowsUiElements.ActiveTitleGradient,null },
                    { WindowsUiElements.ActiveBorder,null },
                    { WindowsUiElements.Window, WindowsUiElements.WindowText },
                    { WindowsUiElements.WindowText, WindowsUiElements.Window },
                    { WindowsUiElements.WindowFrame,null },
                    { WindowsUiElements.ButtonFace, WindowsUiElements.ButtonText },
                    { WindowsUiElements.ButtonText,WindowsUiElements.ButtonFace },
                    { WindowsUiElements.ButtonAlternateFace,null },
                    { WindowsUiElements.ButtonDkShadow,null },
                    { WindowsUiElements.ButtonHighlight,null },
                    { WindowsUiElements.ButtonLight,null },
                    { WindowsUiElements.ButtonShadow,null },
                    { WindowsUiElements.Menu, WindowsUiElements.MenuText },
                    { WindowsUiElements.MenuText,WindowsUiElements.Menu },
                    { WindowsUiElements.MenuHighlight, WindowsUiElements.HighlightText },
                    { WindowsUiElements.GreyText, WindowsUiElements.GreyText },
                    { WindowsUiElements.DesktopBackground,WindowsUiElements.DesktopBackground },
                    { WindowsUiElements.Highlight, WindowsUiElements.HighlightText },
                    { WindowsUiElements.HighlightText, WindowsUiElements.Highlight },
                    { WindowsUiElements.InfoWindow, WindowsUiElements.InfoText },
                    { WindowsUiElements.InfoText, WindowsUiElements.InfoWindow },
                    { WindowsUiElements.Scrollbar,null },
                    { WindowsUiElements.HotTrackingColor,null },
                    { WindowsUiElements.MenuBar,null },
                    { WindowsUiElements.AppWorkspace,null }
                };
            }
        }
    }
}
