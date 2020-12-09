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
    public partial class FormInduk : Form
    {
        public FormInduk()
        {
            InitializeComponent();
        }

        private void Hitung_Click(object sender, EventArgs e)
        {
            Perhitungan perhitungan = new Perhitungan();
            perhitungan.OnCreate += FrmEntry_OnCreate;
            perhitungan.ShowDialog();
        }
        private void FrmEntry_OnCreate(Mesinhitung klk)
        {
            Hasil.Items.Add("Hasil " + klk.nama + " " + klk.x + " " + klk.operasi + " " + klk.y + " " + "=" + " " + klk.hasil);
        }
    }
}
