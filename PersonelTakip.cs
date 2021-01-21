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
    public partial class PersonelTakip : Form
    {
        public PersonelTakip()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personeller personel = new Personeller();

            personel.Adres = txtAdres.Text;
            personel.AdSoyad = txtAdSoyad.Text;
            personel.CV = txtCV.Text;
            personel.DogumGunu = Convert.ToDateTime(dtDogumGunu.Value);
            personel.Gsm = txtGsm.Text;
            personel.KullaniciAd = txtKullaniciAd.Text;
            personel.Mail = txtEmail.Text;
            personel.Sifre = txtSifre.Text;

            ke.Personeller.Add(personel);
            ke.SaveChanges();

            MessageBox.Show("Personel Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var personel = ke.Personeller.Where(w => w.PersonelId == id).FirstOrDefault();

            ke.Personeller.Remove(personel);
            ke.SaveChanges();

            MessageBox.Show("Personel Silindi");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var personel = ke.Personeller.Where(w => w.KullaniciAd == txtKullaniciAd.Text).FirstOrDefault();

            if (personel != null)
            {
                txtAdres.Text = personel.Adres;
                txtSifre.Text = personel.Sifre;
                txtID.Text = personel.PersonelId.ToString();
                txtGsm.Text = personel.Gsm;
                txtEmail.Text = personel.Mail;
                txtCV.Text = personel.CV;
                txtAdSoyad.Text = personel.AdSoyad;
                dtDogumGunu.Value = personel.DogumGunu.Value;
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı adı bulunmamaktadır!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var personel = ke.Personeller.Where(w => w.PersonelId == id).FirstOrDefault();

            personel.Adres = txtAdres.Text;
            personel.AdSoyad = txtAdSoyad.Text;
            personel.CV = txtCV.Text;
            personel.DogumGunu = Convert.ToDateTime(dtDogumGunu.Value);
            personel.Gsm = txtGsm.Text;
            personel.KullaniciAd = txtKullaniciAd.Text;
            personel.Mail = txtEmail.Text;
            personel.Sifre = txtSifre.Text;

            ke.SaveChanges();

            MessageBox.Show("Personel Güncellendi");
        }
    }
}
