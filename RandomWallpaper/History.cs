using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper
{
    [Serializable]
    public class History
    {
        public List<string> PathsFolder { get; set; } = new List<string>();

        public int GetAutoFolder(string value)
        {
            return PathsFolder.IndexOf(value);
        }

        public void AddFolder(string value)
        {
            if (PathsFolder.IndexOf(value) > 0)
                return;

            PathsFolder.Add(value);
        }
    }
}
