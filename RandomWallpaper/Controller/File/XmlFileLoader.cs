using RandomWallpaper.Interface;
using RandomWallpaper.Model;
using System;
using System.IO;
using System.Xml.Serialization;

namespace RandomWallpaper.Controller.File
{
    public class XmlFileLoader : IFileLoader
    {
        private readonly string _fileName;

        public XmlFileLoader(string FileName)
        {
            _fileName = FileName;
        }

        public ApplicationSettings Load(string path)
        {
            ApplicationSettings settings = null;

            try
            {
                FileParameterChecker.Check(path, _fileName);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ApplicationSettings));

                using (FileStream fs = new FileStream($"{path}{_fileName}.xml", FileMode.OpenOrCreate))
                {
                   settings = (ApplicationSettings)xmlSerializer.Deserialize(fs);
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
