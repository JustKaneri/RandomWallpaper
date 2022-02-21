using Microsoft.Win32;
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

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        //Список изображений.
        private List<ImageBacground> BacgroundsArray = new List<ImageBacground>();
        //Индекс выбранного изображения.
        private int CurrentItem = -1;


        private void BtnFindFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TbxFolder.Text = folderBrowserDialog1.SelectedPath;
                GetFiles();

                if (BacgroundsArray.Count != 0 && CbxAutoLoad.Checked)
                {
                    CbxAutoLoad.Checked = false;
                    CbxAutoLoad.Checked = true;
                }
            }
        }

        /// <summary>
        /// Получение картинок из папки.
        /// </summary>
        private void GetFiles()
        {
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
                PbxRandom.Image = null;
                TbxFolder.Clear();
                return;
            }
            else
            {
                SelectImage();
            }
        }

        /// <summary>
        /// Выбор обоев.
        /// </summary>
        private void SelectImage()
        {
            Random rnd = new Random();

            int Index = rnd.Next(BacgroundsArray.Count - 1);

            try
            {
                PbxRandom.Image = Image.FromFile(BacgroundsArray[Index].PathImage);
            }
            catch
            {
                BacgroundsArray.RemoveAt(Index);
                Index = rnd.Next(BacgroundsArray.Count - 1);
                PbxRandom.Image = Image.FromFile(BacgroundsArray[Index].PathImage);
            }

            CurrentItem = Index;
        }

        private void BtnSelectAndSet_Click(object sender, EventArgs e)
        {

            if (BacgroundsArray.Count == 0)
            {
                MessageBox.Show("Изображения не найдены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectImage();
            SetImage();
        }

        /// <summary>
        /// Установка обоев.
        /// </summary>
        private void SetImage()
        {
            using (var key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true))
            {
                key.SetValue("WallPaper", BacgroundsArray[CurrentItem].PathImage);
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, BacgroundsArray[CurrentItem].PathImage, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);

            CurrentItem = -1;

            AlertShow();
        }

        /// <summary>
        /// Кнопка установить обои.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSet_Click(object sender, EventArgs e)
        {
            if (CurrentItem != -1)
                SetImage();
        }

        /// <summary>
        /// Вывод сообщения.
        /// </summary>
        private void AlertShow()
        {
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Обои успешно установлены";
            notifyIcon1.BalloonTipTitle = "Успех";
            notifyIcon1.ShowBalloonTip(4);

        }
  
        private void ChbxAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxAutoLoad.Checked)
            {
                SetAutoLoadApp();
            }
            else
            {
                DisAutoLoadApp();
            }
        }

        /// <summary>
        /// Удаление из автозагрузки.
        /// </summary>
        private void DisAutoLoadApp()
        {
            using (var reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                if (reg.GetValue(Application.ProductName) != null)
                    reg.DeleteValue(Application.ProductName);

            }
        }

        /// <summary>
        /// Установка автозагрузки
        /// </summary>
        private void SetAutoLoadApp()
        {
            string Exect = $"\"{Application.ExecutablePath}\" {TbxFolder.Text} fon";

            using (var reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\"))
            {
                reg.SetValue(Application.ProductName, Exect);
            }
        }

        /// <summary>
        /// Загрузка формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arg = Environment.GetCommandLineArgs();

            if (arg.Length > 1)
            {
                TbxFolder.Text = arg[1];

                if (arg[2].Trim() == "fon")
                {
                    this.Hide();
                    this.ShowInTaskbar = false;
                    WindowState = FormWindowState.Minimized;
                    GetFiles();
                    BtnSelectAndSet_Click(null, null);
                }

            }

            using (var reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run"))
            {
                if(reg.GetValue(Application.ProductName) != null)
                {
                    TbxFolder.Text = reg.GetValue(Application.ProductName).ToString().Split(' ')[1];
                    CbxAutoLoad.Checked = true;
                    GetFiles();
                }
                
            }
        }

        /// <summary>
        /// Блокировка автозагруки если путь не указан.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxFolder_TextChanged(object sender, EventArgs e)
        {
            if (TbxFolder.Text == String.Empty)
                CbxAutoLoad.Enabled = false;
            else
                CbxAutoLoad.Enabled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;

                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "Нажмите, чтобы отобразить окно";
                notifyIcon1.BalloonTipTitle = "Внимание";
                notifyIcon1.ShowBalloonTip(4);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
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

            SelectImage();
        }
    }
}
