using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelompok
{
    public partial class Pertemuan09 : Form
    {
        const string filename = "data.pegawai.txt";
        public Pertemuan09()
        {
            InitializeComponent();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtKode.Text.Trim().Equals(""))
                    throw new Exception("Sorry, kolom kode wajib isi ...");
                else if (this.txtNama.Text.Trim().Equals(""))
                    throw new Exception("Sorry, kolom nama wajib isi ...");
                else if (this.radPria.Checked && this.radWanita.Checked)
                    throw new Exception("Sorry, jenis kelamin wajib isi ...");
                else if (this.cboDepartemen.Text.Trim().Equals(""))
                    throw new Exception("Sorry, departemen nama wajib isi ...");

                string kode = this.txtKode.Text.Trim();
                string nama = this.txtNama.Text.Trim();
                string jenisKelamin = this.radPria.Checked ?
                    this.radPria.Text.Trim() : this.radWanita.Text.Trim();
                string departemen = this.cboDepartemen.Text.Trim();

                //validasi

                string[] fileContent = File.ReadAllLines(filename);
                if (this.btnTambah.Text.Equals("Tambah", StringComparison.CurrentCultureIgnoreCase))
                {
                    if (File.Exists(filename))
                    {
                        foreach (string line in fileContent)
                        {
                            string[] arr = line.Split('|');
                            string kodeAtSource = arr[0].Trim();
                            if (kodeAtSource.Equals(kode, StringComparison.CurrentCultureIgnoreCase))
                                throw new Exception("Sorry, kode yang sama sudah terdaftar...");
                        }

                    }
                    //write new item to file
                    using (StreamWriter writer = new StreamWriter(filename, true))
                    {
                        writer.WriteLine($"{kode} | {nama} | {jenisKelamin} | {departemen}");
                    }

                }
                else
                {
                    // mode : update
                    using (StreamWriter writer = new StreamWriter(filename, false))
                    {
                        foreach (string line in fileContent)
                        {
                            string[] arr = line?.Split('|');
                            string kodeInSource = arr[0].Trim();
                            if (kodeInSource.Equals(kode, StringComparison.CurrentCultureIgnoreCase))
                            {
                                writer.WriteLine($"{kode} | {nama} | {jenisKelamin} | {departemen}");
                            }
                            else
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                    btnTambah.Text = "Tambah";

                }

                //clearform
                foreach (Control ctl in this.Controls)
                {
                    if (ctl is TextBox t) t.Clear();
                    if (ctl is RadioButton r) r.Checked = false;
                    if (ctl is ComboBox cb) cb.Text = "";
                }

                this.txtKode.Focus();

                LoadData("all");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadData(string kriteria)
        {
            try
            {
                this.dgvData.Rows.Clear();
                if (File.Exists(filename))
                {
                    string[] fileContent = File.ReadAllLines(filename);
                    if (fileContent.Length > 0)
                    {
                        foreach (string line in fileContent)
                        {
                            string[] arrline = line.Split('|');
                            string kode = arrline[0].Trim();
                            string nama = arrline[1].Trim();
                            string jeniskelamin = arrline[2].Trim();
                            string departemen = arrline[3];

                            if (kriteria.Equals("all", StringComparison.CurrentCultureIgnoreCase))
                            {
                                this.dgvData.Rows.Add(new string[] { kode, nama, jeniskelamin, departemen });
                            }
                            else
                            {
                                if (jeniskelamin.Equals(kriteria, StringComparison.CurrentCultureIgnoreCase))
                                {
                                    this.dgvData.Rows.Add(new string[] { kode, nama, jeniskelamin, departemen });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or display a user-friendly error message
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Pertemuan09_Load(object sender, EventArgs e)
        {
            LoadData("all");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvData.CurrentRow != null)
            {
                if (MessageBox.Show($"Edit baris data terpilih ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow row = this.dgvData.CurrentRow;
                    string kode = row.Cells[0].Value.ToString().Trim();
                    string nama = row.Cells[1].Value.ToString().Trim();
                    string jenisKelamin = row.Cells[2].Value.ToString().Trim();
                    string departemen = row.Cells[3].Value.ToString().Trim();
                    this.txtKode.Text = kode;
                    this.txtNama.Text = nama;
                    if (jenisKelamin.Equals("pria", StringComparison.CurrentCultureIgnoreCase))
                        this.radPria.Checked = true;
                    else
                    {
                        this.radWanita.Checked = true;
                    }
                    this.cboDepartemen.Text = departemen;
                    this.txtKode.Enabled = false;
                    this.btnTambah.Text = "Update";
                }
            }
        }

        private void hapusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvData.CurrentRow != null)
            {
                string kode = this.dgvData.CurrentRow.Cells[0].Value.ToString().Trim();
                if (MessageBox.Show($"Hapus item data dengan kode: {kode} ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var fileContent = File.ReadAllLines(filename);
                        using (var writer = new StreamWriter(filename, false))
                        {
                            foreach (string line in fileContent)
                            {
                                string kodeAtLine = line.Split('|')[0].Trim();
                                if (!kodeAtLine.Equals(kode, StringComparison.CurrentCultureIgnoreCase))
                                    writer.WriteLine(line);
                            }
                        }
                        LoadData("all");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTampilPria_Click(object sender, EventArgs e)
        {
            LoadData("pria");
        }

        private void btnTampilWanita_Click(object sender, EventArgs e)
        {
            LoadData("wanita");
        }

        private void btnTampilSemua_Click(object sender, EventArgs e)
        {
            LoadData("all");
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox t) t.Clear();
                if (ctl is RadioButton r) r.Checked = false;
                if (ctl is ComboBox cb) cb.Text = "";
            }
            this.txtKode.Enabled = true;
            this.btnTambah.Text = "Tambah";

        }
    }
}
