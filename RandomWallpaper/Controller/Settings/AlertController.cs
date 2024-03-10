using RandomWallpaper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper.Controller.Settings
{
    public class AlertController
    {
        private readonly ApplicationSettings _settings;

        public AlertController(ApplicationSettings settings)
        {
            _settings = settings;
        }

        public void AlertEnable()
        {
            _settings.IsShowAllert = true;
        }

        public void AlertDisable()
        {
            _settings.IsShowAllert = false;
        }

        public bool AlertStatuse()
        {
            return _settings.IsShowAllert;
        }
    }
}
