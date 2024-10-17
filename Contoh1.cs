using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kelompok
{
    public partial class Contoh1 : Form
    {
        public Contoh1()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Mahasiswa.txt", true);
            sw.Write(txtNIM.Text + " - " + txtNama.Text + "|");
            sw.Close();
            txtNIM.Clear();
            txtNama.Clear();
            txtNIM.Focus();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Mahasiswa.txt");
            string[] data;
            data = sr.ReadLine().Split('|');
            listBox1.Items.Clear();
            for (int i = 0; i < data.GetUpperBound(0); i++)
            {
                listBox1.Items.Add(data[i]);
            }
            sr.Close();
        }
    }
}
