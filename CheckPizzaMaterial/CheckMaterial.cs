using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckPizzaMaterial
{
    public partial class CheckMaterial : Form
    {
        decimal fiyat = 120;
        public CheckMaterial()
        {
            InitializeComponent();
            lblFiyat.Text = fiyat.ToString("C");
            lblTutar.Text = fiyat.ToString("C");
            //Hesapla();
        }

        private void Hesapla(object sender, EventArgs e)
        {
            decimal tutar = fiyat;
            if (chkMisir.Checked)
                tutar += 10m;
            if (chkSucuk.Checked)
                tutar += 15m;
            if (chkZeytin.Checked)
                tutar += 8m;
            if (chkKasar.Checked)
                tutar += 10m;
            if (chkMantar.Checked)
                tutar += 8m;
            if (chkJambon.Checked)
                tutar += 15m;

            lblTutar.Text = tutar.ToString("C");
        }
    }
}
