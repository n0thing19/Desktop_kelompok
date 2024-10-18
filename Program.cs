using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelompok
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Daftar_Barang());
            //Application.Run(new Daftar_Pegawai_ListBox());
            //Application.Run(new Daftar_Pegawai_GridView());
            //Application.Run(new Daftar_Pegawai_ListView());
            //Application.Run(new Contoh1());
            Application.Run(new Pertemuan09());
        }
    }
}
