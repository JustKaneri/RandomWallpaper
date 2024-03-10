using Microsoft.Win32;
using RandomWallpaper.Controller.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWallpaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private List<ImageBacground> BacgroundsArray = new List<ImageBacground>();
        private Manager WallpaperManager;
        private History history;
        private ManagetHistory managetHistory = new ManagetHistory();
        private SettingsMangaer _mangaerSettings;


        /// <summary>
        /// Загрузка формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            _mangaerSettings = new SettingsMangaer();
            _mangaerSettings.UpdateUI(this);

            WallpaperManager = new Manager(this);
            history = managetHistory.GetHistory();
            FillCmb();

            string[] arg = Environment.GetCommandLineArgs();

            if (arg.Length > 1)
            {
                TbxFolder.Text = arg[1];

                if (arg[2].Trim() == "fon")
                {
                    this.Hide();
                    this.ShowInTaskbar = false;
                    WindowState = FormWindowState.Minimized;

                    if (TbxFolder.Items.Count == 0)
                    {
                        history.AddFolder(arg[1]);
                        FillCmb();
                    }

                    TbxFolder.SelectedIndex = history.GetAutoFolder(arg[1]);
                    GetFiles();
                    BtnSelectAndSet_Click(null, null);
                }

            }

            TimeWorker(_mangaerSettings.TimerStatus().Item1, _mangaerSettings.TimerStatus().Item2);
        }

        private void TimeWorker(int time,bool isWork)
        {
            timer1.Interval = int.Parse(time.ToString()) * 60000;
            timer1.Enabled = isWork;
        }

        private void BtnFindFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                history.AddFolder(folderBrowserDialog1.SelectedPath);
                FillCmb();
                GetFiles();
            }
        }

        /// <summary>
        /// Получение картинок из папки.
        /// </summary>
        private void GetFiles()
        {
            if(string.IsNullOrWhiteSpace(TbxFolder.Text))
            {
                BacgroundsArray.Clear();
                PbxRandom.Image = null;
                return;
            }
            

            try
            {
                string[] file = Directory.GetFiles(TbxFolder.Text);
                BacgroundsArray.Clear();

                for (int i = 0; i < file.Length; i++)
                {
                    string Exten = Path.GetExtension(file[i]);

                    if (Exten.Equals(".png") || Exten.Equals(".jpeg") || Exten.Equals(".jpg"))
                    {
                        ImageBacground bacground = new ImageBacground();
                        bacground.Name = Path.GetFileName(file[i]);
                        bacground.PathImage = file[i];
                        BacgroundsArray.Add(bacground);
                    }
                    
                }
            }
            catch
            {
            }


            if (BacgroundsArray.Count == 0)
            {
                MessageBox.Show("Изображения не найдены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                history.PathsFolder.RemoveAt(history.PathsFolder.Count - 1);
                FillCmb();
                return;
            }
            else
            {
                managetHistory.SaveHisory(history);
                WallpaperManager.GetNewImage(BacgroundsArray);
            }
        }
        
        private void BtnSelectAndSet_Click(object sender, EventArgs e)
        {
            if (BacgroundsArray.Count == 0)
            {
                MessageBox.Show("Изображения не найдены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                WallpaperManager.GetNewImage(BacgroundsArray);
                WallpaperManager.SetImage();
                WallpaperManager.SetImageOnWallpaper();
                WallpaperManager.GetNewImage(BacgroundsArray);

                AlertShow();
            }
            catch 
            {
            }
        }  

        /// <summary>
        /// Кнопка установить обои.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSet_Click(object sender, EventArgs e)
        {
            if (PbxRandom.Image == null)
                return;

            try
            {
                WallpaperManager.SetImage();
                WallpaperManager.SetImageOnWallpaper();
                WallpaperManager.GetNewImage(BacgroundsArray);

                AlertShow();
            }
            catch 
            {
            }
        }

        /// <summary>
        /// Вывод сообщения.
        /// </summary>
        private void AlertShow()
        {
            //var cfg = managerProperties.GetConfigurat();

            //if (cfg.IsShowMessage)
            //{
            //    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            //    notifyIcon1.BalloonTipText = "Обои успешно установлены";
            //    notifyIcon1.BalloonTipTitle = "Успех";
            //    notifyIcon1.ShowBalloonTip(4);
            //}
        }

        private void FillCmb()
        {
            TbxFolder.Items.Clear();
            //TbxFolder.DropDownHeight = TbxFolder.ItemHeight;
            foreach (var item in history.PathsFolder)
            {
                TbxFolder.Items.Add(item);
            }

            TbxFolder.SelectedIndex = TbxFolder.Items.Count - 1;

            if (history.PathsFolder.Count > 0)
                GetFiles();
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (BacgroundsArray.Count == 0)
            {
                MessageBox.Show("Изображения не найдены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WallpaperManager.GetNewImage(BacgroundsArray);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BtnSet_Click(null, null);
        }
        
        private void PbxLast_Click(object sender, EventArgs e)
        {
            try
            {
                WallpaperManager.SetLastWallpaper();

                AlertShow();
            }
            catch
            {

            }
        }

        private void PbxRandom_Click(object sender, EventArgs e)
        {
            if (BacgroundsArray.Count == 0)
            {
                MessageBox.Show("Изображения не найдены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WallpaperManager.GetNewImage(BacgroundsArray);
        }

        private void LbxProperties_Click(object sender, EventArgs e)
        {
            FormProperties properties = new FormProperties(_mangaerSettings);
            properties.ShowDialog();

            _mangaerSettings.UpdateUI(this);

            //if(properties.IsDelete)
            //{
            //    history = managetHistory.GetHistory();
            //    FillCmb();
            //    GetFiles();
            //}

            TimeWorker(_mangaerSettings.TimerStatus().Item1, _mangaerSettings.TimerStatus().Item2);

        }

        private void TbxFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFiles();
        }

        private void CntQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LbxHelp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\help.chm");
            }
            catch
            {
            }
        }
    }
}
