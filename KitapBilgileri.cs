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
    public partial class KitapBilgileri : Form
    {
        public KitapBilgileri()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void btnGetir_Click(object sender, EventArgs e)
        {
            datagrid.DataSource = ke.Kitaplar.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var kitap = ke.Kitaplar.Where(w => w.Ad == txtArama.text);

            if(kitap != null)
            {
                foreach (var item in kitap)
                {
                    datagrid.DataSource = kitap.ToList();
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kitap bulunmamaktadır!");
            }
        }
    }
}
