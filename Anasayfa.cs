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
    public partial class Anasayfa : Form
    {
        private int childFormNumber = 0;

        public Anasayfa()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void personelBilgileriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelBilgileri frm = new PersonelBilgileri();
            frm.Show();
        }

        private void personelTakipToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelTakip frm = new PersonelTakip();
            frm.Show();
        }

        private void kitapBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapBilgileri frm = new KitapBilgileri();
            frm.Show();
        }

        private void kitapTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapTakip frm = new KitapTakip();
            frm.Show();
        }

        private void dergiBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DergiBilgileri frm = new DergiBilgileri();
            frm.Show();
        }

        private void dergiTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DergiTakip frm = new DergiTakip();
            frm.Show();
        }

        private void ansiklopediBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnsiklopediBilgileri frm = new AnsiklopediBilgileri();
            frm.Show();
        }

        private void ansiklopediTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnsiklopediTakip frm = new AnsiklopediTakip();
            frm.Show();
        }

        private void üyeBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeBilgileri frm = new UyeBilgileri();
            frm.Show();
        }

        private void üyeKitapGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeKitapGecmisi frm = new UyeKitapGecmisi();
            frm.Show();
        }

        private void üyeTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeTakip frm = new UyeTakip();
            frm.Show();
        }

        private void kitapAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapBilgileri frm = new KitapBilgileri();
            frm.Show();
        }

        private void dergiAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DergiBilgileri frm = new DergiBilgileri();
            frm.Show();
        }

        private void ansiklopediAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnsiklopediBilgileri frm = new AnsiklopediBilgileri();
            frm.Show();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAd.Text != null && txtSifre.Text != null)
            {
                var kullanici = ke.Personeller.Where(w => w.KullaniciAd == txtKullaniciAd.Text).FirstOrDefault();

                if (kullanici != null)
                {
                    if (kullanici.Sifre == txtSifre.Text)
                    {
                        menuStrip1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Yanlış Şifre Girdiniz!");
                        txtSifre.Text = "";
                    }
                    
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı Girdiniz!");
                    txtKullaniciAd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adını ve Şifreyi Eksiksiz Doldurun");
                txtKullaniciAd.Text = "";
                txtSifre.Text = "";
            }
        }

        private void üyeGeçmişiBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeKitapGecmisBilgileri frm = new UyeKitapGecmisBilgileri();
            frm.Show();
        }
    }
}
