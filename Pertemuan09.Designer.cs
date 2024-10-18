namespace kelompok
{
    partial class Pertemuan09
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
            this.btnTampilWanita = new System.Windows.Forms.Button();
            this.btnTampilPria = new System.Windows.Forms.Button();
            this.btnTampilSemua = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.cboDepartemen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radWanita = new System.Windows.Forms.RadioButton();
            this.radPria = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departemen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTampilWanita
            // 
            this.btnTampilWanita.Location = new System.Drawing.Point(549, 196);
            this.btnTampilWanita.Name = "btnTampilWanita";
            this.btnTampilWanita.Size = new System.Drawing.Size(135, 25);
            this.btnTampilWanita.TabIndex = 39;
            this.btnTampilWanita.Text = "Tampil Wanita";
            this.btnTampilWanita.UseVisualStyleBackColor = true;
            this.btnTampilWanita.Click += new System.EventHandler(this.btnTampilWanita_Click);
            // 
            // btnTampilPria
            // 
            this.btnTampilPria.Location = new System.Drawing.Point(301, 196);
            this.btnTampilPria.Name = "btnTampilPria";
            this.btnTampilPria.Size = new System.Drawing.Size(242, 25);
            this.btnTampilPria.TabIndex = 38;
            this.btnTampilPria.Text = "Tampil Pria";
            this.btnTampilPria.UseVisualStyleBackColor = true;
            this.btnTampilPria.Click += new System.EventHandler(this.btnTampilPria_Click);
            // 
            // btnTampilSemua
            // 
            this.btnTampilSemua.Location = new System.Drawing.Point(12, 196);
            this.btnTampilSemua.Name = "btnTampilSemua";
            this.btnTampilSemua.Size = new System.Drawing.Size(283, 25);
            this.btnTampilSemua.TabIndex = 37;
            this.btnTampilSemua.Text = "Tampil Semua";
            this.btnTampilSemua.UseVisualStyleBackColor = true;
            this.btnTampilSemua.Click += new System.EventHandler(this.btnTampilSemua_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(12, 165);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(531, 25);
            this.btnTambah.TabIndex = 36;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // cboDepartemen
            // 
            this.cboDepartemen.FormattingEnabled = true;
            this.cboDepartemen.Items.AddRange(new object[] {
            "",
            "Gudang",
            "Keuangan",
            "HRD",
            "Penjualan",
            "Pembelian"});
            this.cboDepartemen.Location = new System.Drawing.Point(150, 126);
            this.cboDepartemen.Name = "cboDepartemen";
            this.cboDepartemen.Size = new System.Drawing.Size(534, 24);
            this.cboDepartemen.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Departemen";
            // 
            // radWanita
            // 
            this.radWanita.AutoSize = true;
            this.radWanita.Location = new System.Drawing.Point(251, 89);
            this.radWanita.Name = "radWanita";
            this.radWanita.Size = new System.Drawing.Size(70, 20);
            this.radWanita.TabIndex = 33;
            this.radWanita.TabStop = true;
            this.radWanita.Text = "Wanita";
            this.radWanita.UseVisualStyleBackColor = true;
            // 
            // radPria
            // 
            this.radPria.AutoSize = true;
            this.radPria.Location = new System.Drawing.Point(150, 89);
            this.radPria.Name = "radPria";
            this.radPria.Size = new System.Drawing.Size(52, 20);
            this.radPria.TabIndex = 32;
            this.radPria.TabStop = true;
            this.radPria.Text = "Pria";
            this.radPria.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Jenis Kelamin";
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Location = new System.Drawing.Point(150, 49);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(534, 22);
            this.txtNama.TabIndex = 30;
            // 
            // txtKode
            // 
            this.txtKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKode.Location = new System.Drawing.Point(150, 10);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(534, 22);
            this.txtKode.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nama Pegawai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Kode Pegawai";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(549, 165);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(135, 25);
            this.btnBatal.TabIndex = 41;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode,
            this.nama,
            this.jeniskelamin,
            this.departemen});
            this.dgvData.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvData.GridColor = System.Drawing.SystemColors.Info;
            this.dgvData.Location = new System.Drawing.Point(12, 227);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(672, 203);
            this.dgvData.TabIndex = 42;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // kode
            // 
            this.kode.FillWeight = 80F;
            this.kode.HeaderText = "Kode";
            this.kode.MinimumWidth = 6;
            this.kode.Name = "kode";
            this.kode.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.FillWeight = 200F;
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // jeniskelamin
            // 
            this.jeniskelamin.HeaderText = "Jenis Kelamin";
            this.jeniskelamin.MinimumWidth = 6;
            this.jeniskelamin.Name = "jeniskelamin";
            this.jeniskelamin.ReadOnly = true;
            // 
            // departemen
            // 
            this.departemen.FillWeight = 150F;
            this.departemen.HeaderText = "Departemen";
            this.departemen.MinimumWidth = 6;
            this.departemen.Name = "departemen";
            this.departemen.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.hapusToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // hapusToolStripMenuItem
            // 
            this.hapusToolStripMenuItem.Name = "hapusToolStripMenuItem";
            this.hapusToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.hapusToolStripMenuItem.Text = "Hapus";
            this.hapusToolStripMenuItem.Click += new System.EventHandler(this.hapusToolStripMenuItem_Click);
            // 
            // Pertemuan09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 438);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTampilWanita);
            this.Controls.Add(this.btnTampilPria);
            this.Controls.Add(this.btnTampilSemua);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.cboDepartemen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radWanita);
            this.Controls.Add(this.radPria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pertemuan09";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Pegawai";
            this.Load += new System.EventHandler(this.Pertemuan09_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTampilWanita;
        private System.Windows.Forms.Button btnTampilPria;
        private System.Windows.Forms.Button btnTampilSemua;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cboDepartemen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radWanita;
        private System.Windows.Forms.RadioButton radPria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn departemen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
    }
}