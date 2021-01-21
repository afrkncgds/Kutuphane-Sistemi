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
    public partial class AnsiklopediTakip : Form
    {
        public AnsiklopediTakip()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void AnsiklopediTakip_Load(object sender, EventArgs e)
        {
            var tur = ke.Turler.ToList();

            foreach (var item in tur)
            {
                cmbxTur.AddItem(item.TurAdi);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ansiklopediler ansiklopedi = new Ansiklopediler();

            ansiklopedi.Ad = txtAd.Text;
            ansiklopedi.Dil = txtDil.Text;
            ansiklopedi.SayfaSayisi = txtSayfaSayisi.Text;
            ansiklopedi.Tur = cmbxTur.selectedValue.ToString();
            ansiklopedi.Yayinci = txtYayinci.Text;
            ansiklopedi.YayinTarihi = Convert.ToDateTime(dtYayinTarihi.Value);
            ansiklopedi.Yazar = txtYazar.Text;

            ke.Ansiklopediler.Add(ansiklopedi);
            ke.SaveChanges();

            MessageBox.Show("Ansiklopedi Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var ansiklopedi = ke.Ansiklopediler.Where(w => w.AnsiklopediId == id).FirstOrDefault();

            ke.Ansiklopediler.Remove(ansiklopedi);
            ke.SaveChanges();

            MessageBox.Show("Ansiklopedi Silindi");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var ansiklopedi = ke.Ansiklopediler.Where(w => w.Ad == txtAd.Text).FirstOrDefault();

            if (ansiklopedi != null)
            {
                txtDil.Text = ansiklopedi.Dil;
                txtID.Text = ansiklopedi.AnsiklopediId.ToString();
                txtSayfaSayisi.Text = ansiklopedi.SayfaSayisi;
                txtYayinci.Text = ansiklopedi.Yayinci;
                txtYazar.Text = ansiklopedi.Yazar;
                dtYayinTarihi.Value = ansiklopedi.YayinTarihi.Value;
                lblTur.Text = "Tür = " + ansiklopedi.Tur;
            }
            else
            {
                MessageBox.Show("Böyle Bir Ansiklopedi Bulunmamaktadır");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var ansiklopedi = ke.Ansiklopediler.Where(w => w.AnsiklopediId == id).FirstOrDefault();

            ansiklopedi.Ad = txtAd.Text;
            ansiklopedi.Dil = txtDil.Text;
            ansiklopedi.SayfaSayisi = txtSayfaSayisi.Text;
            ansiklopedi.Tur = cmbxTur.selectedValue.ToString();
            ansiklopedi.Yayinci = txtYayinci.Text;
            ansiklopedi.YayinTarihi = Convert.ToDateTime(dtYayinTarihi.Value);
            ansiklopedi.Yazar = txtYazar.Text;

            ke.SaveChanges();

            MessageBox.Show("Ansiklopedi Güncellendi");
        }
    }
}
