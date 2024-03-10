using RandomWallpaper.Controller.File;
using RandomWallpaper.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWallpaper.Controller.Settings
{
    public class SettingsMangaer
    {
        private AlertController _alertController;
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
            _alertController = new AlertController(_settings);
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

        public void SetColors(Color fontColor, Color borderColor, Color buttonColor)
        {
            _uiController.SetColors(fontColor, borderColor, buttonColor);
            SaveSetting();
        }

        public (Color font,Color border,Color button) GetColors()
        {
            return (  ColorTranslator.FromHtml(_settings.FontColorButton)
                    , ColorTranslator.FromHtml(_settings.BorderCollor)
                    , ColorTranslator.FromHtml(_settings.BackgroundCollorButton));
        }

        public void SetDefaultColor()
        {
            _uiController.SetDefaultColor();
            SaveSetting();
        }

        public void AutoLoadEnable()
        {
           
            _autoStartController.Enable();
            SaveSetting();
        }

        public void AutoLoadDisable()
        {
            _autoStartController.Disable();
            SaveSetting();
        }

        public bool AutoLoadStatus()
        {
           return _autoStartController.Status();
        }

        public bool AlertStatus()
        {
            return _alertController.AlertStatuse();
        }

        public void AlertEnable() 
        {
            _alertController.AlertEnable();
            SaveSetting();
        }

        public void AlertDisable()
        {
            _alertController.AlertDisable();
            SaveSetting();
        }
    }
}
