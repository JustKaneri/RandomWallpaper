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

        public FormProperties(string path)
        {
            InitializeComponent();

            Path = path;
        }

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

            PropertiesManager manager = new PropertiesManager(this);
            manager.SaveUI(configurat);
            PaintUI();
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            PaintUI();

            PbxColorBack.BackColor = BtnTest.BackColor;
            PbxColorFont.BackColor = BtnTest.ForeColor;
            PbxBorderColor.BackColor = controlBox1.BorderColor;

            PropertiesManager manager = new PropertiesManager(this);

            CbxAutoLoad.Checked = manager.IsAutoLoad();
        }
        
        private void PaintUI()
        {
            PropertiesManager manager = new PropertiesManager(this);
            var cfg = manager.GetConfigurat();

            if (cfg == null)
                return;

            BtnSave.BackColor = cfg.BackColorButton;
            BtnSave.ForeColor = cfg.FontColorButton;

            BtnDef.BackColor = cfg.BackColorButton;
            BtnDef.ForeColor = cfg.FontColorButton;

            BtnTest.BackColor = cfg.BackColorButton;
            BtnTest.ForeColor = cfg.FontColorButton;

            BtnDelHistory.BackColor = cfg.BackColorButton;
            BtnDelHistory.ForeColor = cfg.FontColorButton;

            controlBox1.BorderColor = cfg.BorderColorButton;
            
            this.Opacity = 0.9;
            this.Opacity = 1;
        }

        private void BtnDef_Click(object sender, EventArgs e)
        {
            PropertiesManager manager = new PropertiesManager(this);
            manager.DefaultProperties();
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
        }

        private void CbxAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            PropertiesManager manager = new PropertiesManager(this);

            if (CbxAutoLoad.Checked)
            {
                if(string.IsNullOrWhiteSpace(Path))
                {
                    MessageBox.Show("Для того что бы установить автозагрузку, нужно выбрать папку с обоями в главном окне.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                manager.SetAutoLoadApp(Path);
            }
            else
            {
                manager.DisAutoLoadApp();
            }
        }

        private void BtnDelHistory_Click(object sender, EventArgs e)
        {
            ManagetHistory managetHistory = new ManagetHistory();
            bool del = managetHistory.DeleteHistory();

            if (del)
                MessageBox.Show("История удалена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
