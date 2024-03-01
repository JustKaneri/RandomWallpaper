using Microsoft.Win32;
using RandomWallpaper.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWallpaper.Controller.Settings
{
    public class AutoStartController
    {
        private readonly ApplicationSettings _settings;

        private const string _applicationName = "RandomWallpaper";

        public AutoStartController(ApplicationSettings settings)
        {
            _settings = settings;
        }

        public void Disable()
        {
            using (var reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                if (reg.GetValue(_applicationName) != null)
                    reg.DeleteValue(_applicationName);

                _settings.IsAutoLoader = false;
            }
        }

        public void Enable()
        {
            string Exect = $"\"{Application.ExecutablePath}\" fon";

            using (var reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\"))
            {
                reg.SetValue(Application.ProductName, Exect);

                _settings.IsAutoLoader = true;
            }
        }

        public bool Status()
        {
            bool isAutoLoad = false;

            using (var reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run"))
            {
                if (reg.GetValue(Application.ProductName) != null)
                {
                    isAutoLoad = true;
                }
            }

            _settings.IsAutoLoader = isAutoLoad;

            return isAutoLoad;
        }
    }
}
