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
    public partial class UyeTakip : Form
    {
        public UyeTakip()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Uyeler uye = new Uyeler();

            uye.Adres = txtAdres.Text;
            uye.AdSoyad = txtAdSoyad.Text;
            uye.DogumGunu = Convert.ToDateTime(dtDogumGunu.Value);
            uye.Gsm = txtGsm.Text;
            uye.KullaniciAd = txtKullaniciAd.Text;
            uye.Mail = txtEmail.Text;
            uye.Sifre = txtSifre.Text;
            uye.OkunanKitapSayisi = 0;

            ke.Uyeler.Add(uye);
            ke.SaveChanges();

            MessageBox.Show("Üye Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var uye = ke.Uyeler.Where(w => w.UyeId == id).FirstOrDefault();

            ke.Uyeler.Remove(uye);
            ke.SaveChanges();

            MessageBox.Show("Üye Silindi");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var uye = ke.Uyeler.Where(w => w.KullaniciAd == txtKullaniciAd.Text).FirstOrDefault();

            if (uye != null)
            {
                txtAdres.Text = uye.Adres;
                txtSifre.Text = uye.Sifre;
                txtID.Text = uye.UyeId.ToString();
                txtGsm.Text = uye.Gsm;
                txtEmail.Text = uye.Mail;
                txtAdSoyad.Text = uye.AdSoyad;
                dtDogumGunu.Value = uye.DogumGunu.Value;
                txtOkunanKitapSayisi.Text = uye.OkunanKitapSayisi.ToString();
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı adı bulunmamaktadır!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var uye = ke.Uyeler.Where(w => w.UyeId == id).FirstOrDefault();

            uye.Adres = txtAdres.Text;
            uye.AdSoyad = txtAdSoyad.Text;
            uye.DogumGunu = Convert.ToDateTime(dtDogumGunu.Value);
            uye.Gsm = txtGsm.Text;
            uye.KullaniciAd = txtKullaniciAd.Text;
            uye.Mail = txtEmail.Text;
            uye.Sifre = txtSifre.Text;
            uye.OkunanKitapSayisi = Convert.ToInt32(txtOkunanKitapSayisi.Text);

            ke.SaveChanges();

            MessageBox.Show("Üye Güncellendi");
        }
    }
}
