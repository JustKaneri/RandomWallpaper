using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWallpaper
{
    public class ManagetHistory
    {
        public void SaveHisory(History history)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(Application.StartupPath + "\\history.dat", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, history);
            }
        }

        public History GetHistory()
        {
            History his = new History();

            if (!File.Exists(Application.StartupPath + "\\history.dat"))
                return his;

            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(Application.StartupPath + "\\history.dat", FileMode.Open))
            {
                his = bf.Deserialize(fs) as History;
            }

            return his;
        }
    }
}
