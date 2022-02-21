namespace RandomWallpaper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlBox1 = new CustomUIDll.ControlBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TbxFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFindFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.PbxRandom = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSelectAndSet = new System.Windows.Forms.Button();
            this.BtnSet = new System.Windows.Forms.Button();
            this.GpProperties = new System.Windows.Forms.GroupBox();
            this.CbxAutoLoad = new System.Windows.Forms.CheckBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRandom)).BeginInit();
            this.GpProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlBox1
            // 
            this.controlBox1.BackColor = System.Drawing.Color.White;
            this.controlBox1.BackColorClose = System.Drawing.Color.White;
            this.controlBox1.BackColorCloseSelect = System.Drawing.Color.Red;
            this.controlBox1.BackColorMax = System.Drawing.Color.White;
            this.controlBox1.BackColorMaxSelect = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.controlBox1.BackColorMin = System.Drawing.Color.White;
            this.controlBox1.BackColorMinSelect = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.controlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.controlBox1.BorderSize = 8;
            this.controlBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBox1.ForeColorClose = System.Drawing.Color.Black;
            this.controlBox1.ForeColorCloseSelect = System.Drawing.Color.White;
            this.controlBox1.ForeColorMax = System.Drawing.Color.Black;
            this.controlBox1.ForeColorMaxSelect = System.Drawing.Color.Black;
            this.controlBox1.ForeColorMin = System.Drawing.Color.Black;
            this.controlBox1.ForeColorMinSelect = System.Drawing.Color.Black;
            this.controlBox1.Icon = ((System.Drawing.Image)(resources.GetObject("controlBox1.Icon")));
            this.controlBox1.IsSizeFixed = true;
            this.controlBox1.Location = new System.Drawing.Point(0, 0);
            this.controlBox1.MaxBox = false;
            this.controlBox1.MiniBox = true;
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(801, 42);
            this.controlBox1.TabIndex = 0;
            this.controlBox1.Text = "Random Wallpapers";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Random Wallpapers";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // TbxFolder
            // 
            this.TbxFolder.BackColor = System.Drawing.Color.White;
            this.TbxFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxFolder.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxFolder.Location = new System.Drawing.Point(16, 97);
            this.TbxFolder.Name = "TbxFolder";
            this.TbxFolder.ReadOnly = true;
            this.TbxFolder.Size = new System.Drawing.Size(206, 31);
            this.TbxFolder.TabIndex = 4;
            this.TbxFolder.TextChanged += new System.EventHandler(this.TbxFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Путь:";
            // 
            // BtnFindFolder
            // 
            this.BtnFindFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.BtnFindFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFindFolder.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFindFolder.ForeColor = System.Drawing.Color.White;
            this.BtnFindFolder.Location = new System.Drawing.Point(228, 92);
            this.BtnFindFolder.Name = "BtnFindFolder";
            this.BtnFindFolder.Size = new System.Drawing.Size(136, 40);
            this.BtnFindFolder.TabIndex = 6;
            this.BtnFindFolder.Text = "Обзор";
            this.BtnFindFolder.UseVisualStyleBackColor = false;
            this.BtnFindFolder.Click += new System.EventHandler(this.BtnFindFolder_Click);
            // 
            // PbxRandom
            // 
            this.PbxRandom.Location = new System.Drawing.Point(417, 92);
            this.PbxRandom.Name = "PbxRandom";
            this.PbxRandom.Size = new System.Drawing.Size(357, 240);
            this.PbxRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxRandom.TabIndex = 7;
            this.PbxRandom.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(412, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Случайное изображение:";
            // 
            // BtnSelectAndSet
            // 
            this.BtnSelectAndSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.BtnSelectAndSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectAndSet.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSelectAndSet.ForeColor = System.Drawing.Color.White;
            this.BtnSelectAndSet.Location = new System.Drawing.Point(30, 297);
            this.BtnSelectAndSet.Name = "BtnSelectAndSet";
            this.BtnSelectAndSet.Size = new System.Drawing.Size(348, 40);
            this.BtnSelectAndSet.TabIndex = 10;
            this.BtnSelectAndSet.Text = "Выбрать и установить";
            this.BtnSelectAndSet.UseVisualStyleBackColor = false;
            this.BtnSelectAndSet.Click += new System.EventHandler(this.BtnSelectAndSet_Click);
            // 
            // BtnSet
            // 
            this.BtnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.BtnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSet.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSet.ForeColor = System.Drawing.Color.White;
            this.BtnSet.Location = new System.Drawing.Point(30, 194);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(348, 40);
            this.BtnSet.TabIndex = 11;
            this.BtnSet.Text = "Установить";
            this.BtnSet.UseVisualStyleBackColor = false;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // GpProperties
            // 
            this.GpProperties.Controls.Add(this.CbxAutoLoad);
            this.GpProperties.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GpProperties.Location = new System.Drawing.Point(30, 390);
            this.GpProperties.Name = "GpProperties";
            this.GpProperties.Size = new System.Drawing.Size(734, 122);
            this.GpProperties.TabIndex = 12;
            this.GpProperties.TabStop = false;
            this.GpProperties.Text = "Доп параметры";
            // 
            // CbxAutoLoad
            // 
            this.CbxAutoLoad.AutoSize = true;
            this.CbxAutoLoad.Enabled = false;
            this.CbxAutoLoad.Location = new System.Drawing.Point(6, 40);
            this.CbxAutoLoad.Name = "CbxAutoLoad";
            this.CbxAutoLoad.Size = new System.Drawing.Size(361, 30);
            this.CbxAutoLoad.TabIndex = 0;
            this.CbxAutoLoad.Text = "Смена обоев при загрузке Windows";
            this.CbxAutoLoad.UseVisualStyleBackColor = true;
            this.CbxAutoLoad.CheckedChanged += new System.EventHandler(this.ChbxAutoLoad_CheckedChanged);
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSelect.ForeColor = System.Drawing.Color.White;
            this.BtnSelect.Location = new System.Drawing.Point(30, 244);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(348, 40);
            this.BtnSelect.TabIndex = 13;
            this.BtnSelect.Text = "Выбрать";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 524);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.GpProperties);
            this.Controls.Add(this.BtnSet);
            this.Controls.Add(this.BtnSelectAndSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PbxRandom);
            this.Controls.Add(this.BtnFindFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxFolder);
            this.Controls.Add(this.controlBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Wallpapers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PbxRandom)).EndInit();
            this.GpProperties.ResumeLayout(false);
            this.GpProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomUIDll.ControlBox controlBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox TbxFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFindFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox PbxRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSelectAndSet;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.GroupBox GpProperties;
        private System.Windows.Forms.CheckBox CbxAutoLoad;
        private System.Windows.Forms.Button BtnSelect;
    }
}

