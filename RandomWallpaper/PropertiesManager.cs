using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using CustomUIDll;
using System.Drawing;

namespace RandomWallpaper
{
    public class PropertiesManager
    {
        private Form Self;

        public PropertiesManager(Form form)
        {
            Self = form;
        }

        public void SetUI()
        {
            if (!File.Exists(Application.StartupPath + "\\configUI.dat"))
                return;

            Configurat config = GetConfigUI();

            Self.Opacity = 0.9;
            Self.Opacity = 1;

            foreach (Control item in Self.Controls)
            {
                if (item is Button)
                {
                    if ((item as Button).Tag != null)
                        continue;

                    (item as Button).BackColor = config.BackColorButton;
                    (item as Button).ForeColor = config.FontColorButton;
                }

                if (item is ControlBox)
                {
                    (item as ControlBox).BorderColor = config.BorderColorButton;
                }
            }
        }

        public Configurat GetConfigurat()
        {
            if (!File.Exists(Application.StartupPath + "\\configUI.dat"))
                return null;

            Configurat config = GetConfigUI();

            return config;
        }

        private Configurat GetConfigUI()
        {
            Configurat con = null;

            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(Application.StartupPath + "\\configUI.dat", FileMode.Open))
            {
                con = bf.Deserialize(fs) as Configurat;
            }

            return con;
        }

        public void SaveUI(Configurat config)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(Application.StartupPath+"\\configUI.dat",FileMode.OpenOrCreate))
            {
                bf.Serialize(fs,config);
            }
        }

        public void DefaultProperties()
        {
            Configurat conf = new Configurat();
            conf.BackColorButton = Color.FromArgb(80,53,96);
            conf.FontColorButton = Color.White;
            conf.BorderColorButton = Color.FromArgb(64,0,64);

            SaveUI(conf);
        }
    }
}
