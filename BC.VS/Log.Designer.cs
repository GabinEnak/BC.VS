namespace BC.VS
{
    partial class Log
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cari = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sampai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dari = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datalog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idlogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbllogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCDataSet2 = new BC.VS.BCDataSet2();
            this.aktivitas = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.user = new Guna.UI2.WinForms.Guna2Button();
            this.gudang = new Guna.UI2.WinForms.Guna2Button();
            this.tbl_logTableAdapter = new BC.VS.BCDataSet2TableAdapters.tbl_logTableAdapter();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCDataSet2)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2CustomGradientPanel2.Controls.Add(this.label3);
            this.guna2CustomGradientPanel2.Controls.Add(this.label2);
            this.guna2CustomGradientPanel2.Controls.Add(this.cari);
            this.guna2CustomGradientPanel2.Controls.Add(this.label1);
            this.guna2CustomGradientPanel2.Controls.Add(this.sampai);
            this.guna2CustomGradientPanel2.Controls.Add(this.dari);
            this.guna2CustomGradientPanel2.Controls.Add(this.datalog);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(171, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(629, 450);
            this.guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(144, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sampai tanggal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(10, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dari tanggal:";
            // 
            // cari
            // 
            this.cari.BackColor = System.Drawing.Color.Transparent;
            this.cari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cari.FillColor = System.Drawing.Color.Khaki;
            this.cari.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.cari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cari.Location = new System.Drawing.Point(282, 157);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(62, 31);
            this.cari.TabIndex = 7;
            this.cari.Text = "Cari";
            this.cari.Click += new System.EventHandler(this.loginn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kelola Aktivitas";
            // 
            // sampai
            // 
            this.sampai.BorderColor = System.Drawing.Color.Silver;
            this.sampai.Checked = true;
            this.sampai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sampai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sampai.ForeColor = System.Drawing.Color.Silver;
            this.sampai.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.sampai.Location = new System.Drawing.Point(147, 156);
            this.sampai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.sampai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.sampai.Name = "sampai";
            this.sampai.Size = new System.Drawing.Size(129, 32);
            this.sampai.TabIndex = 2;
            this.sampai.Value = new System.DateTime(2026, 7, 3, 17, 11, 21, 210);
            // 
            // dari
            // 
            this.dari.BorderColor = System.Drawing.Color.Silver;
            this.dari.Checked = true;
            this.dari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dari.ForeColor = System.Drawing.Color.Silver;
            this.dari.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dari.Location = new System.Drawing.Point(12, 156);
            this.dari.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dari.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dari.Name = "dari";
            this.dari.Size = new System.Drawing.Size(129, 32);
            this.dari.TabIndex = 1;
            this.dari.Value = new System.DateTime(2026, 7, 3, 17, 11, 21, 210);
            // 
            // datalog
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.datalog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datalog.AutoGenerateColumns = false;
            this.datalog.BackgroundColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datalog.ColumnHeadersHeight = 4;
            this.datalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlogDataGridViewTextBoxColumn,
            this.iduserDataGridViewTextBoxColumn,
            this.aktivitasDataGridViewTextBoxColumn,
            this.waktuDataGridViewTextBoxColumn});
            this.datalog.DataSource = this.tbllogBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datalog.DefaultCellStyle = dataGridViewCellStyle3;
            this.datalog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(188)))));
            this.datalog.Location = new System.Drawing.Point(11, 199);
            this.datalog.Name = "datalog";
            this.datalog.RowHeadersVisible = false;
            this.datalog.Size = new System.Drawing.Size(605, 241);
            this.datalog.TabIndex = 0;
            this.datalog.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Yellow;
            this.datalog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.datalog.ThemeStyle.BackColor = System.Drawing.Color.Khaki;
            this.datalog.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(188)))));
            this.datalog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Khaki;
            this.datalog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datalog.ThemeStyle.HeaderStyle.Height = 4;
            this.datalog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Khaki;
            this.datalog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datalog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Khaki;
            this.datalog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalog_CellContentClick);
            // 
            // idlogDataGridViewTextBoxColumn
            // 
            this.idlogDataGridViewTextBoxColumn.DataPropertyName = "id_log";
            this.idlogDataGridViewTextBoxColumn.HeaderText = "id_log";
            this.idlogDataGridViewTextBoxColumn.Name = "idlogDataGridViewTextBoxColumn";
            this.idlogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            // 
            // aktivitasDataGridViewTextBoxColumn
            // 
            this.aktivitasDataGridViewTextBoxColumn.DataPropertyName = "aktivitas";
            this.aktivitasDataGridViewTextBoxColumn.HeaderText = "aktivitas";
            this.aktivitasDataGridViewTextBoxColumn.Name = "aktivitasDataGridViewTextBoxColumn";
            // 
            // waktuDataGridViewTextBoxColumn
            // 
            this.waktuDataGridViewTextBoxColumn.DataPropertyName = "waktu";
            this.waktuDataGridViewTextBoxColumn.HeaderText = "waktu";
            this.waktuDataGridViewTextBoxColumn.Name = "waktuDataGridViewTextBoxColumn";
            // 
            // tbllogBindingSource
            // 
            this.tbllogBindingSource.DataMember = "tbl_log";
            this.tbllogBindingSource.DataSource = this.bCDataSet2;
            // 
            // bCDataSet2
            // 
            this.bCDataSet2.DataSetName = "BCDataSet2";
            this.bCDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aktivitas
            // 
            this.aktivitas.BackColor = System.Drawing.Color.Transparent;
            this.aktivitas.BorderColor = System.Drawing.Color.Transparent;
            this.aktivitas.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.aktivitas.Checked = true;
            this.aktivitas.CheckedState.FillColor = System.Drawing.Color.Khaki;
            this.aktivitas.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aktivitas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aktivitas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aktivitas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aktivitas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aktivitas.FillColor = System.Drawing.Color.Transparent;
            this.aktivitas.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.aktivitas.ForeColor = System.Drawing.Color.Silver;
            this.aktivitas.Location = new System.Drawing.Point(-40, 168);
            this.aktivitas.Name = "aktivitas";
            this.aktivitas.Size = new System.Drawing.Size(208, 29);
            this.aktivitas.TabIndex = 0;
            this.aktivitas.Text = "Kelola Aktivitas";
            this.aktivitas.UseTransparentBackground = true;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2CustomGradientPanel1.Controls.Add(this.logout);
            this.guna2CustomGradientPanel1.Controls.Add(this.user);
            this.guna2CustomGradientPanel1.Controls.Add(this.gudang);
            this.guna2CustomGradientPanel1.Controls.Add(this.aktivitas);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(171, 450);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logout.CheckedState.FillColor = System.Drawing.Color.Khaki;
            this.logout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logout.FillColor = System.Drawing.Color.Transparent;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.logout.ForeColor = System.Drawing.Color.Silver;
            this.logout.Location = new System.Drawing.Point(3, 403);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(165, 29);
            this.logout.TabIndex = 4;
            this.logout.Text = "Log Out";
            this.logout.UseTransparentBackground = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.user.CheckedState.FillColor = System.Drawing.Color.Khaki;
            this.user.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.user.FillColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.user.ForeColor = System.Drawing.Color.Silver;
            this.user.Location = new System.Drawing.Point(-59, 198);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(227, 29);
            this.user.TabIndex = 3;
            this.user.Text = "Kelola User";
            this.user.UseTransparentBackground = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // gudang
            // 
            this.gudang.BackColor = System.Drawing.Color.Transparent;
            this.gudang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gudang.CheckedState.FillColor = System.Drawing.Color.Khaki;
            this.gudang.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gudang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gudang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gudang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gudang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gudang.FillColor = System.Drawing.Color.Transparent;
            this.gudang.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gudang.ForeColor = System.Drawing.Color.Silver;
            this.gudang.Location = new System.Drawing.Point(-40, 234);
            this.gudang.Name = "gudang";
            this.gudang.Size = new System.Drawing.Size(208, 29);
            this.gudang.TabIndex = 2;
            this.gudang.Text = "Kelola Gudang";
            this.gudang.UseTransparentBackground = true;
            this.gudang.Click += new System.EventHandler(this.gudang_Click);
            // 
            // tbl_logTableAdapter
            // 
            this.tbl_logTableAdapter.ClearBeforeFill = true;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCDataSet2)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button aktivitas;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button gudang;
        private Guna.UI2.WinForms.Guna2Button user;
        private Guna.UI2.WinForms.Guna2Button logout;
        private Guna.UI2.WinForms.Guna2DateTimePicker dari;
        private Guna.UI2.WinForms.Guna2DataGridView datalog;
        private Guna.UI2.WinForms.Guna2DateTimePicker sampai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button cari;
        private BCDataSet2 bCDataSet2;
        private System.Windows.Forms.BindingSource tbllogBindingSource;
        private BCDataSet2TableAdapters.tbl_logTableAdapter tbl_logTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn;
    }
}