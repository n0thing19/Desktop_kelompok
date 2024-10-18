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
    public partial class Daftar_Pegawai_ListBox : Form
    {
        public Daftar_Pegawai_ListBox()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
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
                listBox1.Font = new Font("Courier New", listBox1.Font.Size);
                string formattedOutput =
                    kodePegawai.PadRight(8) + "|" +
                    namaPegawai.PadRight(10) + "|" +
                    jenisKelamin.PadRight(10) + "|" +
                    departemen.PadRight(12);
                listBox1.Items.Add(formattedOutput);

                ClearInputFields();

                MessageBox.Show("Data pegawai berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            listBox1.Items.Clear();

            try
            {
                listBox1.Font = new Font("Courier New", listBox1.Font.Size);

                string[] lines = File.ReadAllLines("Pegawai.txt");
                foreach (string line in lines)
                {
                    string[] data = line.Split('|');
                    if (string.IsNullOrEmpty(filterJenisKelamin) || data[2] == filterJenisKelamin)
                    {
                        string formattedOutput =
                            data[0].PadRight(8) +"|"+
                            data[1].PadRight(10) + "|" +
                            data[2].PadRight(10) + "|" +
                            data[3].PadRight(12);

                        listBox1.Items.Add(formattedOutput);
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

        private void Daftar_Pegawai_ListBox_Load(object sender, EventArgs e)
        {
            TampilkanData("");
        }
    }
}
