using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSistemi
{
    public partial class DergiTakip : Form
    {
        public DergiTakip()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void DergiTakip_Load(object sender, EventArgs e)
        {
            var tur = ke.Turler.ToList();

            foreach (var item in tur)
            {
                cmbxTur.AddItem(item.TurAdi);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Dergiler dergi = new Dergiler();

            dergi.Ad = txtAd.Text;
            dergi.Dil = txtDil.Text;
            dergi.CiltSayisi = txtCiltSayisi.Text;
            dergi.Tur = cmbxTur.selectedValue.ToString();
            dergi.Yayinci = txtYayinci.Text;
            dergi.YayinTarihi = Convert.ToDateTime(dtYayinTarihi.Value);
            dergi.YayinSayisi = txtYayinSayisi.Text;

            ke.Dergiler.Add(dergi);
            ke.SaveChanges();

            MessageBox.Show("Dergi Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var dergi = ke.Dergiler.Where(w => w.DergiId == id).FirstOrDefault();

            ke.Dergiler.Remove(dergi);
            ke.SaveChanges();

            MessageBox.Show("Dergi Silindi");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var dergi = ke.Dergiler.Where(w => w.Ad == txtAd.Text).FirstOrDefault();

            if (dergi != null)
            {
                txtDil.Text = dergi.Dil;
                txtID.Text = dergi.DergiId.ToString();
                txtCiltSayisi.Text = dergi.CiltSayisi;
                txtYayinci.Text = dergi.Yayinci;
                txtYayinSayisi.Text = dergi.YayinSayisi;
                dtYayinTarihi.Value = dergi.YayinTarihi.Value;
                lblTur.Text = "Tür = " + dergi.Tur;
            }
            else
            {
                MessageBox.Show("Böyle Bir Dergi Bulunmamaktadır");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var dergi = ke.Dergiler.Where(w => w.DergiId == id).FirstOrDefault();

            dergi.Ad = txtAd.Text;
            dergi.Dil = txtDil.Text;
            dergi.CiltSayisi = txtCiltSayisi.Text;
            dergi.Tur = cmbxTur.selectedValue.ToString();
            dergi.Yayinci = txtYayinci.Text;
            dergi.YayinTarihi = Convert.ToDateTime(dtYayinTarihi.Value);
            dergi.YayinSayisi = txtYayinSayisi.Text;

            ke.SaveChanges();

            MessageBox.Show("Dergi Güncellendi");
        }
    }
}
