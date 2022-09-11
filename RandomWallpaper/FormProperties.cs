using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWallpaper
{
    public partial class FormProperties : Form
    {
        private string Path;
        private PropertiesManager propertiesManager;
        public bool IsDelete = false;
        public bool IsUpdateWallp = false;

        public FormProperties(string path)
        {
            InitializeComponent();

            Path = path;

            propertiesManager = new PropertiesManager(this);

            int tm = propertiesManager.GetTime();

            if(tm>-1)
            {
                TbxTime.Text = tm.ToString();
                CbxChange.Checked = true;
            }
        }

        #region Переключения по вкладкам
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            TabPanel.SelectedIndex = 0;
        }

        private void BtnUI_Click(object sender, EventArgs e)
        {
            TabPanel.SelectedIndex = 1;
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            TabPanel.SelectedIndex = 2;
        }
        #endregion

        private void PbxColorBack_Click(object sender, EventArgs e)
        {
             if(colorDialog1.ShowDialog() == DialogResult.OK)
             {
                BtnTest.BackColor = colorDialog1.Color;
                PbxColorBack.BackColor = colorDialog1.Color;
             }
        }

        private void PbxColorFont_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BtnTest.ForeColor = colorDialog1.Color;
                PbxColorFont.BackColor = colorDialog1.Color;
            }
        }

        private void PbxBorderColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                controlBox1.BorderColor = colorDialog1.Color;
                PbxBorderColor.BackColor = colorDialog1.Color;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Configurat configurat = new Configurat();
            configurat.BackColorButton = BtnTest.BackColor;
            configurat.FontColorButton = BtnTest.ForeColor;
            configurat.BorderColorButton = controlBox1.BorderColor;

            propertiesManager.SaveUI(configurat);
            PaintUI();
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            PaintUI();

            PainIndicaterColor();

            CbxAutoLoad.Checked = propertiesManager.IsAutoLoad();
        }

        private void PainIndicaterColor()
        {
            PbxColorBack.BackColor = BtnTest.BackColor;
            PbxColorFont.BackColor = BtnTest.ForeColor;
            PbxBorderColor.BackColor = controlBox1.BorderColor;
        }
        
        private void PaintUI()
        {
            var cfg = propertiesManager.GetConfigurat();

            if (cfg == null)
                return;

            CbxMessage.Checked = !cfg.IsShowMessage;

            BtnSave.BackColor = cfg.BackColorButton;
            BtnSave.ForeColor = cfg.FontColorButton;

            BtnDef.BackColor = cfg.BackColorButton;
            BtnDef.ForeColor = cfg.FontColorButton;

            BtnTest.BackColor = cfg.BackColorButton;
            BtnTest.ForeColor = cfg.FontColorButton;

            BtnDelHistory.BackColor = cfg.BackColorButton;
            BtnDelHistory.ForeColor = cfg.FontColorButton;

            controlBox1.BorderColor = cfg.BorderColorButton;

            PainIndicaterColor();
            
            this.Opacity = 0.9;
            this.Opacity = 1;
        }

        private void BtnDef_Click(object sender, EventArgs e)
        {
            propertiesManager.DefaultProperties();
            PaintUI();
        }

        private void TbxTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;

            if ((Keys)e.KeyChar == Keys.Back)
                e.Handled = false;
        }

        private void TbxTime_TextChanged(object sender, EventArgs e)
        {
            if (TbxTime.Text.Equals("0"))
                TbxTime.Text = "5";

            CbxChange_CheckedChanged(null,null);
        }

        private void CbxAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            

            if (CbxAutoLoad.Checked)
            {
                if(string.IsNullOrWhiteSpace(Path))
                {
                    MessageBox.Show("Для того что бы установить автозагрузку, нужно выбрать папку с обоями в главном окне.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CbxAutoLoad.Checked = false;
                    return;
                }

                propertiesManager.SetAutoLoadApp(Path);
            }
            else
            {
                propertiesManager.DisAutoLoadApp();
            }
        }

        private void BtnDelHistory_Click(object sender, EventArgs e)
        {
            ManagetHistory managetHistory = new ManagetHistory();
            bool del = managetHistory.DeleteHistory();

            if (del)
            {
                MessageBox.Show("История удалена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsDelete = del;
            }
            

        }

        private void CbxChange_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxChange.Checked)
            {
                if (string.IsNullOrWhiteSpace(Path))
                {
                    MessageBox.Show("Для того что бы начать автоматическую смену обоев, нужно выбрать папку с обоями в главном окне.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CbxChange.Checked = false;
                    return;
                }

                propertiesManager.StartUpdate(int.Parse(TbxTime.Text));

                IsUpdateWallp = true;
            }
            else
            {
                propertiesManager.StopUpdate();
                IsUpdateWallp = false;
            }
        }

        private void CbxMessage_CheckedChanged(object sender, EventArgs e)
        {
            var cfg = propertiesManager.GetConfigurat();

            cfg.IsShowMessage = !CbxMessage.Checked;

            propertiesManager.SaveUI(cfg);
        }
    }
}
