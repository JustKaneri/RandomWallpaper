using RandomWallpaper.Interface;
using RandomWallpaper.Model;
using System;
using System.IO;
using System.Xml.Serialization;

namespace RandomWallpaper.Controller.File
{
    public class XmlFileSave : IFileSave
    {
        private readonly string _fileName;

        public XmlFileSave(string FileName) 
        {
            _fileName = FileName;
        }

        public ApplicationSettings Save(ApplicationSettings settings, string path)
        {
            try
            {
                FileParameterChecker.Check(path,_fileName,settings);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ApplicationSettings));

                using (FileStream fs = new FileStream($"{path}{_fileName}.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, settings);
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
