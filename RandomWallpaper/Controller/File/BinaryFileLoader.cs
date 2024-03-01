using RandomWallpaper.Interface;
using RandomWallpaper.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RandomWallpaper.Controller.File
{
    public class BinaryFileLoader : IFileLoader
    {
        private readonly string _fileName;

        private const string _extension = "setting";

        public BinaryFileLoader(string FileName)
        {
            _fileName = FileName;
        }

        public ApplicationSettings Load(string path)
        {
            ApplicationSettings settings = null;

            

            try
            {
                FileParameterChecker.Check(path, _fileName);

                BinaryFormatter bf = new BinaryFormatter();

                using (FileStream fs = new FileStream($"{path}{_fileName}.{_extension}", FileMode.Open))
                {
                    settings = bf.Deserialize(fs) as ApplicationSettings;
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
