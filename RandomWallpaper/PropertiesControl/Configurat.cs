using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper
{
    [Serializable]
    public class Configurat
    {
        public Color BackColorButton { get; set; }
        public Color FontColorButton { get; set; }
        public Color BorderColorButton { get; set; }
        public bool IsShowMessage { get; set; } = true;
    }
}
