using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper
{
    public class LastWallpaper:WallpaperBody
    {
        public LastWallpaper(Image img)
        {
            tmp = img;

            ResizeImage();
        }

        public Image GetImage()
        {
            return _Image;
        }
    }
}
