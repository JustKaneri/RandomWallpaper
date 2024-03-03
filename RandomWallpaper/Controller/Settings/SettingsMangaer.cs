using RandomWallpaper.Controller.File;
using RandomWallpaper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWallpaper.Controller.Settings
{
    public class SettingsMangaer
    {
        private AutoStartController _autoStartController;
        private SettingsFileController _settingsFileController;
        private TimerController _timerController;
        private UIController _uiController;

        private ApplicationSettings _settings;


        private string Path = Application.StartupPath + "\\";
        private string FileName = "settings";

        public SettingsMangaer()
        {
            _settingsFileController = new SettingsFileController(_settings);
            _settings = _settingsFileController.LoadSetting(Path,new XmlFileLoader(FileName));

            if (_settings == null)
            {
                _settings = new ApplicationSettings();
                _settingsFileController = new SettingsFileController(_settings);
                _settingsFileController.SaveSettings(Path, new XmlFileSave(FileName));
            }

            _timerController = new TimerController(_settings);
            _autoStartController = new AutoStartController(_settings);
        }

        #region Таймер
        public bool TimerStart(int time)
        {
            _timerController.StartChange(time);

            _settingsFileController.SaveSettings(Path,new XmlFileSave(FileName));

            return _settings.IsChange;
        }

        public void TimerStop()
        {
            _timerController.StopChange();

            _settingsFileController.SaveSettings(Path, new XmlFileSave(FileName));
        }

        public (int, bool) TimerStatus()
        {
            return (_settings.PeriodСhange, _settings.IsChange);
        }

        #endregion

        public void SaveSetting()
        {
            _settingsFileController.SaveSettings(Path, new XmlFileSave(FileName));
        }

        public void UpdateUI(Form form)
        {
            _uiController = new UIController(_settings, form);
            _uiController.UpdateColorTheme();
        }

        public void AutoLoadEnable()
        {
           
            _autoStartController.Enable();
            _settingsFileController.SaveSettings(Path, new XmlFileSave(FileName));
        }

        public void AutoLoadDisable()
        {
            _autoStartController.Disable();
            _settingsFileController.SaveSettings(Path, new XmlFileSave(FileName));
        }

        public bool AutoLoadStatus()
        {
           return _autoStartController.Status();
        }
    }
}
