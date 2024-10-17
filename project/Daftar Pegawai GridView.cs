using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelompok
{
    public partial class Daftar_Pegawai_GridView : Form
    {
        private bool isEditMode = false;
        public Daftar_Pegawai_GridView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Simpan")
            {
                UpdateData();
            }
            else
            {
                TambahData();
            }
        }

        private void TambahData()
        {
            string kodePegawai = textBox1.Text;
            string namaPegawai = textBox2.Text;
            string jenisKelamin = radioButton1.Checked ? "Pria" : "Wanita";
            string departemen = comboBox1.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(kodePegawai) || string.IsNullOrEmpty(namaPegawai) || string.IsNullOrEmpty(departemen))
            {
                MessageBox.Show("Harap isi semua field dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter("Pegawai.txt", true))
                {
                    sw.WriteLine($"{kodePegawai}|{namaPegawai}|{jenisKelamin}|{departemen}");
                }
                dataGridView1.Rows.Add(kodePegawai, namaPegawai, jenisKelamin, departemen);

                ClearInputFields();

                MessageBox.Show("Data pegawai berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void UpdateData()
        {
            string kodePegawai = textBox1.Text;
            string namaPegawai = textBox2.Text;
            string jenisKelamin = radioButton1.Checked ? "Pria" : "Wanita";
            string departemen = comboBox1.SelectedItem?.ToString() ?? "";

            try
            {
                UpdateDataDiFile(kodePegawai, namaPegawai, jenisKelamin, departemen); 
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["kode"].Value.ToString() == kodePegawai)
                    {
                        row.Cells["nama"].Value = namaPegawai;
                        row.Cells["kelamin"].Value = jenisKelamin;
                        row.Cells["departemen"].Value = departemen;
                        break;
                    }
                }

                ClearInputFields();
                isEditMode = false; 
                button1.Text = "Tambah";
                MessageBox.Show("Data pegawai berhasil diupdate.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        void UpdateDataDiFile(string kodePegawai, string namaPegawai, string jenisKelamin, string departemen)
        {
            try
            {
                string[] lines = File.ReadAllLines("Pegawai.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split('|');
                    if (data[0] == kodePegawai)
                    {
                        lines[i] = $"{kodePegawai}|{namaPegawai}|{jenisKelamin}|{departemen}";
                        break;
                    }
                }
                File.WriteAllLines("Pegawai.txt", lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs
 e)
        {
            TampilkanData("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TampilkanData("Pria");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TampilkanData("Wanita");
        }

        private void TampilkanData(string filterJenisKelamin)
        {
            dataGridView1.Rows.Clear();
            try
            {
                string[] lines = File.ReadAllLines("Pegawai.txt");
                foreach (string line in lines)
                {
                    string[] data = line.Split('|');
                    if (string.IsNullOrEmpty(filterJenisKelamin) || data[2] == filterJenisKelamin)
                    {
                        dataGridView1.Rows.Add(data[0], data[1], data[2], data[3]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string kodePegawai = selectedRow.Cells["kode"].Value.ToString();
                string namaPegawai = selectedRow.Cells["nama"].Value.ToString();
                string jenisKelamin = selectedRow.Cells["kelamin"].Value.ToString();
                string departemen = selectedRow.Cells["departemen"].Value.ToString();

                textBox1.Text = kodePegawai;
                textBox2.Text = namaPegawai;
                if (jenisKelamin == "Pria")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                comboBox1.SelectedItem = departemen;

                isEditMode = true;
                button1.Text = "Simpan";
            }
        }
    }
}
