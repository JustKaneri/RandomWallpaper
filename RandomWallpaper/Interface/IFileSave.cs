using RandomWallpaper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper.Interface
{
    public interface IFileSave
    {
        ApplicationSettings Save(ApplicationSettings settings,string path);
    }
}
