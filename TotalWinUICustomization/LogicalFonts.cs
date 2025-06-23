using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalWinUICustomization.Controls;

namespace TotalWinUICustomization
{
    public static class LogicalFonts
    {
        public static byte[] ToBytes(Font font)
        {
            var logicalFont = new LOGFONT();
            font.ToLogFont(logicalFont);

            return new byte[][]
            {
                BitConverter.GetBytes(logicalFont.lfHeight),
                BitConverter.GetBytes(logicalFont.lfWidth),
                BitConverter.GetBytes(logicalFont.lfEscapement),
                BitConverter.GetBytes(logicalFont.lfOrientation),
                BitConverter.GetBytes(logicalFont.lfWeight),
                new byte[]
                {
                    logicalFont.lfItalic,
                    logicalFont.lfUnderline,
                    logicalFont.lfStrikeOut,
                    logicalFont.lfCharSet,
                    logicalFont.lfOutPrecision,
                    logicalFont.lfClipPrecision,
                    logicalFont.lfQuality,
                    logicalFont.lfClipPrecision,
                },
                Encoding.Unicode.GetBytes(logicalFont.lfFaceName.ToArray())
            }
            .SelectMany(ARR => ARR)
            .ToArray();
        }

        public static Font FromBytes(byte[] fontBytes)
        {
            LOGFONT lOGFONT = new LOGFONT();
            lOGFONT.lfHeight = BitConverter.ToInt32(fontBytes, 0);
            lOGFONT.lfWidth = BitConverter.ToInt32(fontBytes, 4);
            lOGFONT.lfEscapement = BitConverter.ToInt32(fontBytes, 8);
            lOGFONT.lfOrientation = BitConverter.ToInt32(fontBytes, 12);
            lOGFONT.lfWeight = BitConverter.ToInt32(fontBytes, 16);
            lOGFONT.lfItalic = fontBytes[20];
            lOGFONT.lfUnderline = fontBytes[21];
            lOGFONT.lfStrikeOut = fontBytes[22];
            lOGFONT.lfCharSet = fontBytes[23];
            lOGFONT.lfOutPrecision = fontBytes[24];
            lOGFONT.lfClipPrecision = fontBytes[25];
            lOGFONT.lfQuality = fontBytes[26];
            lOGFONT.lfClipPrecision = fontBytes[27];

            int remainingBytes = fontBytes.Length - 28;

            byte[] array = new byte[remainingBytes];
            for (int i = 0; i < remainingBytes; i++)
            {
                array[i] = fontBytes[i + 28];
            }
            lOGFONT.lfFaceName = Encoding.Unicode.GetString(array).TrimEnd(default(char));

            Font result = Font.FromLogFont(lOGFONT);
            return result;
        }
    }
}
