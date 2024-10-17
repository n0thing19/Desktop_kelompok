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
    public partial class Daftar_Barang : Form
    {
        public Daftar_Barang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teks1 = textBox1.Text;
            string teks2 = textBox2.Text;

            if (checkBox1.CheckState == CheckState.Checked)
            {
                using (StreamWriter daftar = new StreamWriter("Barang.txt", true))
                {
                    daftar.WriteLine(teks1 + " " + teks2);
                }
                listBox1.Items.Add(teks1 + " " + teks2); 
            }
            else
            {
                listBox1.Items.Clear();
                using (StreamWriter daftar = new StreamWriter("Barang.txt"))
                {
                    daftar.WriteLine(teks1 + " " + teks2);
                }
                using (StreamReader tulis = new StreamReader("Barang.txt"))
                {
                    while (!tulis.EndOfStream)
                    {
                        listBox1.Items.Add(tulis.ReadLine());
                    }
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Barang.txt", string.Empty);
            listBox1.Items.Clear(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
