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
    public partial class KitapTakip : Form
    {
        public KitapTakip()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void KitapTakip_Load(object sender, EventArgs e)
        {
            var tur = ke.Turler.ToList();

            foreach (var item in tur)
            {
                cmbxTur.AddItem(item.TurAdi);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();

            kitap.Ad = txtAd.Text;
            kitap.Dil = txtDil.Text;
            kitap.SayfaSayisi = txtSayfaSayisi.Text;
            kitap.Tur = cmbxTur.selectedValue.ToString();
            kitap.Yayinci = txtYayinci.Text;
            kitap.YayinTarihi = Convert.ToDateTime(dtYayinTarihi.Value);
            kitap.Yazar = txtYazar.Text;

            ke.Kitaplar.Add(kitap);
            ke.SaveChanges();

            MessageBox.Show("Kitap Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var kitap = ke.Kitaplar.Where(w => w.KitapId == id).FirstOrDefault();

            ke.Kitaplar.Remove(kitap);
            ke.SaveChanges();

            MessageBox.Show("Kitap Silindi");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var kitap = ke.Kitaplar.Where(w => w.Ad == txtAd.Text).FirstOrDefault();

            if (kitap != null)
            {
                txtDil.Text = kitap.Dil;
                txtID.Text = kitap.KitapId.ToString();
                txtSayfaSayisi.Text = kitap.SayfaSayisi;
                txtYayinci.Text = kitap.Yayinci;
                txtYazar.Text = kitap.Yazar;
                dtYayinTarihi.Value = kitap.YayinTarihi.Value;
                lblTur.Text = "Tür = " + kitap.Tur;
            }
            else
            {
                MessageBox.Show("Böyle Bir Kitap Bulunmamaktadır");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var kitap = ke.Kitaplar.Where(w => w.KitapId == id).FirstOrDefault();

            kitap.Ad = txtAd.Text;
            kitap.Dil = txtDil.Text;
            kitap.SayfaSayisi = txtSayfaSayisi.Text;
            kitap.Tur = cmbxTur.selectedValue.ToString();
            kitap.Yayinci = txtYayinci.Text;
            kitap.YayinTarihi = Convert.ToDateTime(dtYayinTarihi.Value);
            kitap.Yazar = txtYazar.Text;

            ke.SaveChanges();

            MessageBox.Show("Kitap Güncellendi");
        }
    }
}
