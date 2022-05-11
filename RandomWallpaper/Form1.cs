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

        //Список изображений.
        private List<ImageBacground> BacgroundsArray = new List<ImageBacground>();
        private Manager manager;
        private History history;
        private ManagetHistory managetHistory = new ManagetHistory();

        /// <summary>
        /// Загрузка формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            PropertiesManager managerProp = new PropertiesManager(this);
            managerProp.SetUI();

            manager = new Manager(this);
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
                    TbxFolder.SelectedIndex = history.GetAutoFolder(arg[1]);
                    GetFiles();
                    BtnSelectAndSet_Click(null, null);
                }

            }
            
           
            //using (var reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run"))
            //{
            //    if (reg.GetValue(Application.ProductName) != null)
            //    {
            //        int index = history.GetAutoFolder(reg.GetValue(Application.ProductName).ToString().Split(' ')[1]);

            //        if (index > -1)
            //            TbxFolder.SelectedIndex = index;

            //        GetFiles();
            //    }

            //}
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
                manager.GetNewImage(BacgroundsArray);
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

                manager.GetNewImage(BacgroundsArray);
                manager.SetImage();
                manager.SetImageOnWallpaper();
                manager.GetNewImage(BacgroundsArray);
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
                manager.SetImage();
                manager.SetImageOnWallpaper();
                manager.GetNewImage(BacgroundsArray);
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
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Обои успешно установлены";
            notifyIcon1.BalloonTipTitle = "Успех";
            notifyIcon1.ShowBalloonTip(4);

        }
        
        private void FillCmb()
        {
            TbxFolder.Items.Clear();

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

            manager.GetNewImage(BacgroundsArray);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BtnSelectAndSet_Click(null, null);
        }

        //private void CbxChange_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(CbxChange.Checked)
        //    {
        //        timer1.Interval = int.Parse(TbxTime.Text) * 60000;
        //        timer1.Enabled = true;
        //    } 
        //    else
        //    {
        //        timer1.Enabled = false;
        //    }
        //}
        
        
        private void PbxLast_Click(object sender, EventArgs e)
        {
            try
            {
                manager.SetLastWallpaper();
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

            manager.GetNewImage(BacgroundsArray);
        }

        private void LbxProperties_Click(object sender, EventArgs e)
        {
            FormProperties properties = new FormProperties(TbxFolder.Text);
            properties.ShowDialog();

            PropertiesManager managerProp = new PropertiesManager(this);
            managerProp.SetUI();
        }

        private void TbxFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFiles();
        }
    }
}
