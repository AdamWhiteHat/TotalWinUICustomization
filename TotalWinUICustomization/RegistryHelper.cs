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
        private static string Key_WindowsColors { get { return @"Control Panel\Colors"; } }
        private static string Key_WindowMetrics { get { return @"Control Panel\Desktop\WindowMetrics"; } }
        private static string Key_VisualStyles { get { return @"Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects"; } }
        private static string Key_Explorer { get { return @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced"; } }
        private static string Value_ClassicStartBar { get { return "Start_ShowClassicMode"; } }// 0 = Windows 11 Start Menu, 1 = Classic  Start Menu
        private static string Value_TaskbarSize { get { return "TaskbarSi"; } }// 0 = Small, 1 = Medium, 2 = Large
        private static string Value_TaskbarAlignment { get { return "TaskbarAl"; } }// 0 = Left, 1 = Center

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

        public static void SetWindowsFont(WindowsUiElements uiElement, Font font)
        {
            if (!Helpers.FontEnumToRegistryKey.ContainsKey(uiElement))
            {
                return;
            }
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(Key_WindowMetrics, true))
            {
                if (key != null)
                {
                    key.SetValue(Helpers.FontEnumToRegistryKey[uiElement], LogicalFonts.ToBytes(font));
                }
            }
        }

        public static Font GetWindowsFont(WindowsUiElements uiElement)
        {
            string fontKey = "";
            if (Helpers.FontEnumToRegistryKey.ContainsKey(uiElement))
            {
                fontKey = Helpers.FontEnumToRegistryKey[uiElement];
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(Key_WindowMetrics, true))
                {
                    if (key != null)
                    {
                        byte[] bytes = (byte[])key.GetValue(fontKey);

                        Font result = LogicalFonts.FromBytes(bytes);
                        return result;
                    }
                }
            }

            string failedValue = fontKey;
            if (string.IsNullOrWhiteSpace(failedValue))
            {
                failedValue = Enum.GetName(typeof(WindowsUiElements), uiElement);
            }
            throw new Exception($"{nameof(GetWindowsFont)} failed to get registry key value for {failedValue}.");
        }


        public static void SetWindowsColor(WindowsUiElements uiElement, Color color)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(Key_WindowsColors, true))
            {
                if (key != null)
                {
                    key.SetValue(Helpers.ColorsEnumToRegistryKey[uiElement], ColorHelper.ColorToString(color));
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
                    color = (string)key.GetValue(Helpers.ColorsEnumToRegistryKey[uiElement]);
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
