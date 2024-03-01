using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper.Model
{
    public class Source
    {
        public string SourcePath { get; set; }

        public DateTime TimeSelected { get; set; } = DateTime.Now;
    }
}
