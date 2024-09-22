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

        InfoText,
        InfoWindow,

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

        // MenuBar, // ??
        // AppWorkspace // ??
    }

    public static class Helpers
    {
        public static Dictionary<WindowsUiElements, string> EnumToKeyDictionary = new Dictionary<WindowsUiElements, string>()
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

            // { WindowsUiElements.MenuBar, "MenuBar" },
            // { WindowsUiElements.AppWorkspace, "AppWorkspace" }
        };
    }
}
