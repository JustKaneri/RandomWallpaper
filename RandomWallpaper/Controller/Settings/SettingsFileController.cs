using RandomWallpaper.Interface;
using RandomWallpaper.Model;
using System;

namespace RandomWallpaper.Controller.Settings
{
    public class SettingsFileController
    {
        private ApplicationSettings _applicationSettings;

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

            try
            {
                _applicationSettings = fileLoader.Load(path);
            }
            catch (Exception ex)
            {
                _applicationSettings = null;
                Console.WriteLine(ex.Message);
            }


            return _applicationSettings;
        }
    }
}
