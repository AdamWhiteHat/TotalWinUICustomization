using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClassesLibrary;
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

        public static string Key_Themes = @"Software\Microsoft\Windows\CurrentVersion\Themes";
        private static string Value_CurrentTheme = "CurrentTheme"; // @"C:\Users\CodeNinja\AppData\Local\Microsoft\Windows\Themes\Custom.theme"

        public static void SetWindowsFont(WindowsUiElements fontGroup, Font font)
        {
            string fontKey = Enum.GetName(typeof(WindowsUiElements), fontGroup);
            SetBytesValue(Key_WindowMetrics, fontKey, LogicalFonts.ToBytes(font));
        }

        public static Font GetWindowsFont(WindowsUiElements fontGroup)
        {
            string fontKey = Enum.GetName(typeof(WindowsUiElements), fontGroup);

            byte[] bytes = GetBytesValue(Key_WindowMetrics, fontKey);
            if (bytes != null)
            {
                Font result = LogicalFonts.FromBytes(bytes);
                return result;
            }
            throw new Exception($"{nameof(GetWindowsFont)} failed to get registry key value for {Enum.GetName(typeof(WindowsUiElements), fontGroup)}.");
        }

        public static void SetWindowsColor(WindowsUiElements uiElement, Color color)
        {
            SetStringValue(Key_WindowsColors, Helpers.ColorsEnumToRegistryKey[uiElement], ColorHelper.ColorToString(color));
        }

        public static Color GetWindowsColor(WindowsUiElements uiElement)
        {
            string color = GetStringValue(Key_WindowsColors,Helpers.ColorsEnumToRegistryKey[uiElement]);
            if (color != null)
            {
                return ColorHelper.StringToColor(color);
            }

            throw new Exception($"{nameof(GetWindowsColor)} failed to get registry key value for {Enum.GetName(typeof(WindowsUiElements), uiElement)}.");
        }

        public static string GetCurrentTheme()
        {
            return GetStringValue(Key_Themes, Value_CurrentTheme);
        }

        public static void SetCurrentTheme(string themeFilePath)
        {
            SetStringValue(Key_Themes, Value_CurrentTheme, themeFilePath);
        }

        public static void SetBytesValue(string keyName, string valueName, byte[] bytes)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key != null)
                {
                    key.SetValue(valueName, bytes);
                }
            }
        }

        public static byte[] GetBytesValue(string keyName, string valueName)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, false))
            {
                if (key != null)
                {
                    return (byte[])key.GetValue(valueName);
                }
            }
            throw new Exception($"{nameof(GetBytesValue)} failed to get registry key value at {keyName}\\{valueName}.");
        }

        public static void SetStringValue(string keyName, string valueName, string valueString)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key != null)
                {
                    key.SetValue(valueName, valueString);
                }
            }
        }

        public static string GetStringValue(string keyName, string valueName)
        {
            string result =null;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key == null)
                {
                    throw new Exception($"{nameof(GetStringValue)} failed to get registry key value at {keyName}\\{valueName}");
                }
                result = (string)key.GetValue(valueName);
            }

            return result;
        }

        public static int GetIntegerValue(string keyName, string valueName)
        {
            string stringResult = GetStringValue(keyName, valueName);
            return int.Parse(stringResult);
        }

        public static int GetWindowMetric(string valueName)
        {
            int rawValue = GetIntegerValue(Key_WindowMetrics, valueName);
            return rawValue / -15;
        }
    }
}
