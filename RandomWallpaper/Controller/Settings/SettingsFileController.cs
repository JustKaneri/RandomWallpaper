using RandomWallpaper.Interface;
using RandomWallpaper.Model;
using System;

namespace RandomWallpaper.Controller.Settings
{
    public class SettingsFileController
    {
        private readonly ApplicationSettings _applicationSettings;

        public SettingsFileController(ApplicationSettings applicationSettings)
        {
            _applicationSettings = applicationSettings;
        }

        public void SaveSettings(string path, IFileSave fileSaved)
        {
            try
            {
                fileSaved.Save(_applicationSettings, path);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ApplicationSettings LoadSetting(string path,IFileLoader fileLoader)
        {
            ApplicationSettings settings = null;

            try
            {
                settings = fileLoader.Load(path);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return settings;
        }
    }
}
