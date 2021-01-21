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
    public partial class UyeKitapGecmisBilgileri : Form
    {
        public UyeKitapGecmisBilgileri()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void btnGetir_Click(object sender, EventArgs e)
        {
            datagrid.DataSource = ke.UyeGecmisi.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var kullanici = ke.UyeGecmisi.Where(w => w.KullaniciAd == txtArama.text);

            if (kullanici != null)
            {
                foreach (var item in kullanici)
                {
                    datagrid.DataSource = kullanici.ToList();
                }
            }
            else
            {
                MessageBox.Show("Böyle Bir Kullanıcı Bulunmamaktadır");
            }
        }
    }
}
