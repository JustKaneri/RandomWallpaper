using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper
{
    public abstract class WallpaperBody
    {
        protected Image tmp;
        protected Image _Image { get; set; }
        public string FullPath { get; set; }

        protected virtual void ResizeImage()
        {
            if (tmp.Width > 300 && tmp.Height > 191)
                _Image = new Bitmap(tmp, 300, 191);
            else
                _Image = new Bitmap(tmp);

            tmp.Dispose();
        }

        public Image GetImage()
        {
            return _Image;
        }

        public void SetImage(Image value)
        {
            tmp = value;

            ResizeImage();
        }
    }
}
