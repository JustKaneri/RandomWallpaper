using RandomWallpaper.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWallpaper.Controller.File
{
    public static class FileParameterChecker
    {
        public static void Check(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            if (!Directory.Exists(path))
                throw new Exception("Текущий путь не найден");
        }

        public static void Check(string path, string fileName)
        {
            Check(path);

            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException(nameof(fileName));
        }

        public static void Check(string path, string fileName,ApplicationSettings settings)
        {
            Check(path,fileName);

            if (settings == null)
                throw new ArgumentNullException(nameof(settings));
        }

        public static void Check(string path, ApplicationSettings settings)
        {
            Check(path);

            if (settings == null)
                throw new ArgumentNullException(nameof(settings));
        }
    }
}
