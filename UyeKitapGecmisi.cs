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
    public partial class UyeKitapGecmisi : Form
    {
        public UyeKitapGecmisi()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        public string verilmedurum;
        public string cins;

        private void rdVerilmeDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdVerilmeDurumu.SelectedIndex == 0)
            {
                verilmedurum = "Verilmedi";
            }
            else
            {
                verilmedurum = "Verildi";
                dtVerimTarihi.Enabled = true;
            }
        }

        private void rdCins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdVerilmeDurumu.SelectedIndex == 0 )
            {
                cins = "Kitap";
            }
            else if (rdVerilmeDurumu.SelectedIndex == 1)
            {
                cins = "Dergi";
            }
            else
            {
                cins = "Ansiklopedi";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UyeGecmisi gecmis = new UyeGecmisi();

            gecmis.Ad = txtAd.Text;
            gecmis.AlinmaTarihi = dtAlimTarihi.Value;
            gecmis.KullaniciAd = txtKullaniciAd.Text;
            gecmis.OkunanCins = cins;
            gecmis.Tur = cmbxTur.selectedValue;
            gecmis.VerilmeDurumu = verilmedurum;
            
            if (verilmedurum == "Verildi")
            {
                gecmis.VerilmeTarihi = dtVerimTarihi.Value;
            }

            ke.UyeGecmisi.Add(gecmis);
            ke.SaveChanges();

            MessageBox.Show("Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var gecmis = ke.UyeGecmisi.Where(w => w.UyeId == id).FirstOrDefault();

            ke.UyeGecmisi.Remove(gecmis);
            ke.SaveChanges();

            MessageBox.Show("Silindi");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var gecmis = ke.UyeGecmisi.Where(w => w.KullaniciAd == txtKullaniciAd.Text && w.Ad == txtAd.Text).FirstOrDefault();

            txtID.Text = gecmis.UyeId.ToString();
            lblTur.Text = "Tür = " + gecmis.Tur;
            dtAlimTarihi.Value = gecmis.AlinmaTarihi.Value;
            dtVerimTarihi.Value = gecmis.VerilmeTarihi.Value;

            if (gecmis.OkunanCins == "Kitap")
            {
                rdCins.SelectedIndex = 0;
            }
            else if (gecmis.OkunanCins == "Dergi")
            {
                rdCins.SelectedIndex = 1;
            }
            else
            {
                rdCins.SelectedIndex = 2;
            }

            if (gecmis.VerilmeDurumu == "Verilmedi")
            {
                rdVerilmeDurumu.SelectedIndex = 0;
            }
            else
            {
                rdVerilmeDurumu.SelectedIndex = 1;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var gecmis = ke.UyeGecmisi.Where(w => w.UyeId == id).FirstOrDefault();

            gecmis.Ad = txtAd.Text;
            gecmis.AlinmaTarihi = dtAlimTarihi.Value;
            gecmis.KullaniciAd = txtKullaniciAd.Text;
            gecmis.OkunanCins = cins;
            gecmis.Tur = cmbxTur.selectedValue;
            gecmis.VerilmeDurumu = verilmedurum;

            if (verilmedurum == "Verildi")
            {
                gecmis.VerilmeTarihi = dtVerimTarihi.Value;
            }

            ke.SaveChanges();

            MessageBox.Show("Güncellendi");
        }

        private void UyeKitapGecmisi_Load(object sender, EventArgs e)
        {
            var tur = ke.Turler.ToList();

            foreach (var item in tur)
            {
                cmbxTur.AddItem(item.TurAdi);
            }
        }
    }
}
