using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper
{
    public class PrevievWallapeper:WallpaperBody
    {
        public PrevievWallapeper(Image img)
        {
            tmp = img;

            ResizeImage();
        }
        
    }
}
