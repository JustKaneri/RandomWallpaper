using RandomWallpaper.Controller.Settings;
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
        private readonly SettingsMangaer _settingsManager;

        public FormProperties(SettingsMangaer settingsManager)
        {
            InitializeComponent();

            _settingsManager = settingsManager;

            TbxTime.Text = _settingsManager.TimerStatus().Item1.ToString();
            CbxChange.Checked = _settingsManager.TimerStatus().Item2;
            CbxAutoLoad.Checked = _settingsManager.AutoLoadStatus();
            CbxMessage.Checked = _settingsManager.AlertStatus();
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            UpdateUiLocal();

            PainIndicaterColor();
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

        #region Colors Settings
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
            _settingsManager.SetColors(BtnTest.ForeColor, controlBox1.BorderColor, BtnTest.BackColor);
            UpdateUiLocal();
        }


        private void PainIndicaterColor()
        {
            PbxColorBack.BackColor = BtnTest.BackColor;
            PbxColorFont.BackColor = BtnTest.ForeColor;
            PbxBorderColor.BackColor = controlBox1.BorderColor;
        }

        private void UpdateUiLocal()
        {
            var colors = _settingsManager.GetColors();

            BtnSave.BackColor = colors.button;
            BtnSave.ForeColor = colors.font;

            BtnDef.BackColor = colors.button;
            BtnDef.ForeColor = colors.font;

            BtnTest.BackColor = colors.button;
            BtnTest.ForeColor = colors.font;

            BtnDelHistory.BackColor = colors.button;
            BtnDelHistory.ForeColor = colors.font;

            controlBox1.BorderColor = colors.border;

            PainIndicaterColor();

            this.Opacity = 0.9;
            this.Opacity = 1;
        }

        private void BtnDef_Click(object sender, EventArgs e)
        {
            //propertiesManager.DefaultProperties();
            _settingsManager.SetDefaultColor();
            UpdateUiLocal();
        }
        #endregion 

        #region Timer Setting
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

                _settingsManager.TimerStart(int.Parse(TbxTime.Text));
            }
            else
            {
                _settingsManager.TimerStop();
            }
        }
        #endregion

        #region AutoLoad Setting
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

                _settingsManager.AutoLoadEnable();
            }
            else
            {
                _settingsManager.AutoLoadDisable();
            }
        }
        #endregion

        private void BtnDelHistory_Click(object sender, EventArgs e)
        {
            ManagetHistory managetHistory = new ManagetHistory();
            bool del = managetHistory.DeleteHistory();

            if (del)
            {
                MessageBox.Show("История удалена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            

        }

        private void CbxMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxMessage.Checked)
                _settingsManager.AlertEnable();
            else
                _settingsManager.AlertDisable();
        }

    }
}
