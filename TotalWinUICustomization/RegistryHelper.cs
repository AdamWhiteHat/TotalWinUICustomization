using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using TotalWinUICustomization.Types;

namespace TotalWinUICustomization
{
    public static class RegistryHelper
    {
        private static string Key_WindowsColors = @"Control Panel\Colors";
        private static string Key_WindowMetrics = @"Control Panel\Desktop\WindowMetrics";
        private static string Key_VisualStyles = @"Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects";
        private static string Key_Explorer = @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private static string Value_ClassicStartBar = "Start_ShowClassicMode"; // 0 = Windows 11 Start Menu, 1 = Classic  Start Menu
        private static string Value_TaskbarSize = "TaskbarSi"; // 0 = Small, 1 = Medium, 2 = Large
        private static string Value_TaskbarAlignment = "TaskbarAl"; // 0 = Left, 1 = Center

        private static string Key_Desktop = @"Control Panel\Desktop";
        private static string Value_AutoColorization = "AutoColorization ";

        private static string Key_DWM = @"Software\Microsoft\Windows\DWM";
        private static string Value_AccentColor = "AccentColor";
        private static string Value_AccentColorInactive = "AccentColorInactive";
        private static string Value_ColorizationColor = "ColorizationColor";

        private static string Value_ColorPrevalence = "ColorPrevalence";
        private static string Value_EnableWindowColorization = "EnableWindowColorization";

        private static string Key_Themes = @"Software\Microsoft\Windows\CurrentVersion\Themes";
        private static string Value_CurrentTheme = "CurrentTheme"; // @"C:\Users\CodeNinja\AppData\Local\Microsoft\Windows\Themes\Custom.theme"

        public static void SetWindowsColor(WindowsUiElements uiElement, Color color)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(Key_WindowsColors, true))
            {
                if (key != null)
                {
                    key.SetValue(Helpers.EnumToKeyDictionary[uiElement], ColorHelper.ColorToString(color));
                }
            }
        }

        public static Color GetWindowsColor(WindowsUiElements uiElement)
        {
            string color = null;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(Key_WindowsColors, false))
            {
                if (key != null)
                {
                    color = (string)key.GetValue(Helpers.EnumToKeyDictionary[uiElement]);
                }
            }

            if (color != null)
            {
                return ColorHelper.StringToColor(color);
            }

            throw new Exception($"{nameof(GetWindowsColor)} failed to get registry key value for {Enum.GetName(typeof(WindowsUiElements), uiElement)}.");
        }


    }
}
