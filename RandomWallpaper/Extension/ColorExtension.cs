using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper.Extension
{
    public static class ColorExtension
    {
        public static string ToHex(this Color color)
        {
            string hex = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
            return hex;
        }
    }
}
