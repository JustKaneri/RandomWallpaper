using RandomWallpaper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper.Controller.Settings
{
    public class TimerController
    {
        private readonly ApplicationSettings _settings;

        public TimerController(ApplicationSettings settings) {
           _settings = settings;
        }

        public void StartChange(int time)
        {
            _settings.IsChange = true;
            _settings.PeriodСhange = time;
        }

        public void StopChange()
        {
            _settings.IsChange= false;
        }

    }
}
