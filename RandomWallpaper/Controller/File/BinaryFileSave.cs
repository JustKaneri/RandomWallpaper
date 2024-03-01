using RandomWallpaper.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RandomWallpaper.Controller.File
{
    public class BinaryFileSave
    {
        private readonly string _fileName;

        private const string _extension = "setting";

        public BinaryFileSave(string FileName)
        {
            _fileName = FileName;
        }

        public ApplicationSettings Save(ApplicationSettings settings, string path)
        {
            try
            {
                FileParameterChecker.Check(path, _fileName, settings);

                BinaryFormatter bf = new BinaryFormatter();

                using (FileStream fs = new FileStream($"{path}{_fileName}.{_extension}", FileMode.OpenOrCreate))
                {
                    bf.Serialize(fs, settings);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return settings;
        }
    }
}
