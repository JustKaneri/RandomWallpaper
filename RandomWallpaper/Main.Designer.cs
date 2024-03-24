namespace RandomWallpaper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.controlBox1 = new CustomUIDll.ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSourceDel = new System.Windows.Forms.Button();
            this.BtnSoucreEdit = new System.Windows.Forms.Button();
            this.BtnSouceAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvSource = new System.Windows.Forms.DataGridView();
            this.SourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckSource = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbxCurrent = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PbxOld1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PbxOld2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PbxOld3 = new System.Windows.Forms.PictureBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCurrent)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxOld1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxOld2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxOld3)).BeginInit();
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
            this.controlBox1.Size = new System.Drawing.Size(1190, 44);
            this.controlBox1.TabIndex = 1;
            this.controlBox1.Text = "Random Wallpapers";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnSourceDel);
            this.panel1.Controls.Add(this.BtnSoucreEdit);
            this.panel1.Controls.Add(this.BtnSouceAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DgvSource);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 608);
            this.panel1.TabIndex = 2;
            // 
            // BtnSourceDel
            // 
            this.BtnSourceDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.BtnSourceDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSourceDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSourceDel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSourceDel.ForeColor = System.Drawing.Color.White;
            this.BtnSourceDel.Location = new System.Drawing.Point(137, 555);
            this.BtnSourceDel.Name = "BtnSourceDel";
            this.BtnSourceDel.Size = new System.Drawing.Size(48, 48);
            this.BtnSourceDel.TabIndex = 16;
            this.BtnSourceDel.UseVisualStyleBackColor = false;
            // 
            // BtnSoucreEdit
            // 
            this.BtnSoucreEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.BtnSoucreEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSoucreEdit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSoucreEdit.ForeColor = System.Drawing.Color.White;
            this.BtnSoucreEdit.Location = new System.Drawing.Point(68, 555);
            this.BtnSoucreEdit.Name = "BtnSoucreEdit";
            this.BtnSoucreEdit.Size = new System.Drawing.Size(48, 48);
            this.BtnSoucreEdit.TabIndex = 15;
            this.BtnSoucreEdit.UseVisualStyleBackColor = false;
            // 
            // BtnSouceAdd
            // 
            this.BtnSouceAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.BtnSouceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSouceAdd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSouceAdd.ForeColor = System.Drawing.Color.White;
            this.BtnSouceAdd.Location = new System.Drawing.Point(3, 555);
            this.BtnSouceAdd.Name = "BtnSouceAdd";
            this.BtnSouceAdd.Size = new System.Drawing.Size(48, 48);
            this.BtnSouceAdd.TabIndex = 14;
            this.BtnSouceAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Источники";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvSource
            // 
            this.DgvSource.AllowUserToAddRows = false;
            this.DgvSource.AllowUserToDeleteRows = false;
            this.DgvSource.AllowUserToResizeColumns = false;
            this.DgvSource.AllowUserToResizeRows = false;
            this.DgvSource.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSource.ColumnHeadersVisible = false;
            this.DgvSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SourceColumn,
            this.CheckSource});
            this.DgvSource.GridColor = System.Drawing.SystemColors.Control;
            this.DgvSource.Location = new System.Drawing.Point(-1, 47);
            this.DgvSource.MultiSelect = false;
            this.DgvSource.Name = "DgvSource";
            this.DgvSource.ReadOnly = true;
            this.DgvSource.RowHeadersVisible = false;
            this.DgvSource.RowHeadersWidth = 51;
            this.DgvSource.RowTemplate.Height = 27;
            this.DgvSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSource.Size = new System.Drawing.Size(190, 506);
            this.DgvSource.TabIndex = 3;
            // 
            // SourceColumn
            // 
            this.SourceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SourceColumn.FillWeight = 139.1979F;
            this.SourceColumn.HeaderText = "Column1";
            this.SourceColumn.MinimumWidth = 6;
            this.SourceColumn.Name = "SourceColumn";
            this.SourceColumn.ReadOnly = true;
            // 
            // CheckSource
            // 
            this.CheckSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckSource.FillWeight = 50.80214F;
            this.CheckSource.HeaderText = "Column1";
            this.CheckSource.MinimumWidth = 6;
            this.CheckSource.Name = "CheckSource";
            this.CheckSource.ReadOnly = true;
            this.CheckSource.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckSource.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.PbxCurrent);
            this.panel2.Location = new System.Drawing.Point(437, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 288);
            this.panel2.TabIndex = 3;
            // 
            // PbxCurrent
            // 
            this.PbxCurrent.Image = ((System.Drawing.Image)(resources.GetObject("PbxCurrent.Image")));
            this.PbxCurrent.Location = new System.Drawing.Point(5, 5);
            this.PbxCurrent.Margin = new System.Windows.Forms.Padding(5);
            this.PbxCurrent.Name = "PbxCurrent";
            this.PbxCurrent.Size = new System.Drawing.Size(502, 278);
            this.PbxCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCurrent.TabIndex = 0;
            this.PbxCurrent.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(208, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(970, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текущие обои";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panel3.Controls.Add(this.PbxOld1);
            this.panel3.Location = new System.Drawing.Point(222, 510);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 144);
            this.panel3.TabIndex = 4;
            // 
            // PbxOld1
            // 
            this.PbxOld1.Image = ((System.Drawing.Image)(resources.GetObject("PbxOld1.Image")));
            this.PbxOld1.Location = new System.Drawing.Point(5, 5);
            this.PbxOld1.Margin = new System.Windows.Forms.Padding(5);
            this.PbxOld1.Name = "PbxOld1";
            this.PbxOld1.Size = new System.Drawing.Size(246, 134);
            this.PbxOld1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxOld1.TabIndex = 0;
            this.PbxOld1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panel4.Controls.Add(this.PbxOld2);
            this.panel4.Location = new System.Drawing.Point(567, 510);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 144);
            this.panel4.TabIndex = 5;
            // 
            // PbxOld2
            // 
            this.PbxOld2.Image = ((System.Drawing.Image)(resources.GetObject("PbxOld2.Image")));
            this.PbxOld2.Location = new System.Drawing.Point(5, 5);
            this.PbxOld2.Margin = new System.Windows.Forms.Padding(5);
            this.PbxOld2.Name = "PbxOld2";
            this.PbxOld2.Size = new System.Drawing.Size(246, 134);
            this.PbxOld2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxOld2.TabIndex = 0;
            this.PbxOld2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panel5.Controls.Add(this.PbxOld3);
            this.panel5.Location = new System.Drawing.Point(910, 510);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(256, 144);
            this.panel5.TabIndex = 6;
            // 
            // PbxOld3
            // 
            this.PbxOld3.Image = ((System.Drawing.Image)(resources.GetObject("PbxOld3.Image")));
            this.PbxOld3.Location = new System.Drawing.Point(5, 5);
            this.PbxOld3.Margin = new System.Windows.Forms.Padding(5);
            this.PbxOld3.Name = "PbxOld3";
            this.PbxOld3.Size = new System.Drawing.Size(246, 134);
            this.PbxOld3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxOld3.TabIndex = 0;
            this.PbxOld3.TabStop = false;
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSelect.ForeColor = System.Drawing.Color.White;
            this.BtnSelect.Location = new System.Drawing.Point(553, 401);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(281, 40);
            this.BtnSelect.TabIndex = 14;
            this.BtnSelect.Text = "Выбрать";
            this.BtnSelect.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(208, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(970, 44);
            this.label3.TabIndex = 15;
            this.label3.Text = "История:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 676);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Wallpaper";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCurrent)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxOld1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxOld2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxOld3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUIDll.ControlBox controlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSource;
        private System.Windows.Forms.Button BtnSourceDel;
        private System.Windows.Forms.Button BtnSoucreEdit;
        private System.Windows.Forms.Button BtnSouceAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PbxCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PbxOld1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox PbxOld2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox PbxOld3;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}