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
    public partial class UyeBilgileri : Form
    {
        public UyeBilgileri()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void btnGetir_Click(object sender, EventArgs e)
        {
            datagrid.DataSource = ke.Uyeler.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var uye = ke.Uyeler.Where(w => w.AdSoyad == txtArama.text);

            if (uye != null)
            {
                foreach (var item in uye)
                {
                    datagrid.DataSource = uye.ToList();
                }
            }
            else
            {
                MessageBox.Show("Böyle bir üye bulunmamaktadır!");
            }
        }
    }
}
