using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TotalWinUICustomization.Controls;

namespace TotalWinUICustomization
{
    public static class FontHelper
    {
        public static List<FontFamily> FontFamilies
        {
            get
            {
                if (_fontFamilies == null)
                {
                    _fontFamilies = FontFamily.Families.Where(fnt => IsTrueType(fnt.Name)).ToList();
                }
                return _fontFamilies;
            }
        }
        private static List<FontFamily> _fontFamilies = null;

        public static bool IsTrueType(string name)
        {
            IntPtr fontfamily = IntPtr.Zero;
            IntPtr nativeFontCollection = IntPtr.Zero;

            int status = Win32.GdipCreateFontFamilyFromName(name, new HandleRef(null, nativeFontCollection), out fontfamily);

            if (status != 0)
            {
                if (status == 16)  // not true type font)
                {
                    return false;
                }
                else
                {
                    throw new ArgumentException("GDI Error occurred creating Font");
                }
            }
            return true;
        }
    }
}
