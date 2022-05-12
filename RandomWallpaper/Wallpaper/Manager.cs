using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RandomWallpaper
{
    public class Manager
    {
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private  NowWallpaper CurrentImage { get; set; }
        private  LastWallpaper LastImage { get; set; }
        private  PrevievWallapeper PreviewImage { get; set; }

        private Form1 Self { get; set; }
        public bool IsAllGood { get; private set; }

        public Manager(Form1 self)
        {
            CurrentImage = new NowWallpaper();

            self.PbxNow.Image = CurrentImage.GetImage();

            Self = self;
        }

        public void SetImage(Image value)
        {
            LastImage = new LastWallpaper(CurrentImage.GetImage());

            CurrentImage.SetImage(value);

            Self.PbxLast.Image = LastImage.GetImage();
            Self.PbxNow.Image = CurrentImage.GetImage();
        }

        public void SetImage()
        {
            LastImage = new LastWallpaper(CurrentImage.GetImage());
            LastImage.FullPath = CurrentImage.FullPath;

            CurrentImage.SetImage(PreviewImage.GetImage());
            CurrentImage.FullPath = PreviewImage.FullPath;

            Self.PbxLast.Image = LastImage.GetImage();
            Self.PbxNow.Image = CurrentImage.GetImage();
        }

        public void GetNewImage(List<ImageBacground> BacgroundsArray)
        {
            Random rnd = new Random();

            int Index = -1;

            IsAllGood = false;

            do
            {
                if (BacgroundsArray.Count == 0)
                {
                    throw new Exception("Нет изображения");
                   
                }

                Index = rnd.Next(BacgroundsArray.Count - 1);

                try
                {
                    PreviewImage = new PrevievWallapeper(Image.FromFile(BacgroundsArray[Index].PathImage));
                    PreviewImage.FullPath = BacgroundsArray[Index].PathImage;
                    Self.PbxRandom.Image = PreviewImage.GetImage();
                }
                catch
                {
                    BacgroundsArray.RemoveAt(Index);
                }

                IsAllGood = true;

            } while (!IsAllGood);
            
        }

        public void SetImageOnWallpaper()
        {
            using (var key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true))
            {
                key.SetValue("WallPaper", CurrentImage.FullPath);
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, CurrentImage.FullPath, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        public void SetLastWallpaper()
        {
           if(LastImage == null || LastImage.GetImage() == null)
           {
                return;
           }

            string lastPath = LastImage.FullPath; 

            LastImage.FullPath = CurrentImage.FullPath;
            LastImage.SetImage(Image.FromFile(LastImage.FullPath));

            CurrentImage.FullPath = lastPath;
            CurrentImage.SetImage(Image.FromFile(CurrentImage.FullPath));

            SetImageOnWallpaper();

            Self.PbxLast.Image = LastImage.GetImage();
            Self.PbxNow.Image = CurrentImage.GetImage();
        }
    }
}
