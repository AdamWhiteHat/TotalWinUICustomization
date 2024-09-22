using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWinUICustomization
{
    public static class ColorHelper
    {
        public static string ColorToString(Color color)
        {
            return $"{color.R} {color.G} {color.B}";
        }

        public static Color StringToColor(string str)
        {
            string[] parts = str.Split(' ');
            return Color.FromArgb(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
        }
    }
}
