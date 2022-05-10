using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper
{
    public class NowWallpaper:WallpaperBody
    {
        public NowWallpaper()
        {
            using (var key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true))
            {
                FullPath = key.GetValue("WallPaper").ToString();
            }
            
            try
            {
                tmp = Image.FromFile(FullPath);

                ResizeImage();
            }
            catch
            {

                throw new Exception("Не удалось получь изображение");
            }
        }
    }
}
