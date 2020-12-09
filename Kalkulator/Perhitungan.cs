using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorEventNew
{
    public partial class Perhitungan : Form
    {
        public delegate void CreateUpdateEventHandler(Mesinhitung klk);
        public event Perhitungan.CreateUpdateEventHandler OnCreate;
        private Mesinhitung klk;
        public Perhitungan()
        {
            InitializeComponent();
        }

        private void Hitung_Click(object sender, EventArgs e)
        {
            klk = new Mesinhitung();
            klk.nama = this.Operasi.Text.ToLower();
            klk.operasi = string.Empty;
            klk.hasil = 0;
            klk.x = Double.Parse(this.NilaiA.Text);
            klk.y = Double.Parse(this.NilaiB.Text);


            if (this.Operasi.SelectedIndex == -1)
            {
                MessageBox.Show("Silahkan Pilih Operasi Yang Ingin Di jalankan");
            }
            else if (this.Operasi.SelectedIndex == 0)
            {
                klk.hasil = klk.x + klk.y;
                klk.operasi = "+";

            }
            else if (this.Operasi.SelectedIndex == 1)
            {
                klk.hasil = klk.x - klk.y;
                klk.operasi = "-";
            }
            else if (this.Operasi.SelectedIndex == 2)
            {
                klk.hasil = klk.x * klk.y;
                klk.operasi = "*";
            }
            else if (this.Operasi.SelectedIndex == 3)
            {
                klk.hasil = klk.x / klk.y;
                klk.operasi = "/";
            }

            this.OnCreate(klk);
        }
    }
}
