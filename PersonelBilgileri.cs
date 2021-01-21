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
    public partial class PersonelBilgileri : Form
    {
        public PersonelBilgileri()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void btnGetir_Click(object sender, EventArgs e)
        {
            datagrid.DataSource = ke.Personeller.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var personel = ke.Personeller.Where(w => w.AdSoyad == txtArama.text);

            if (personel != null)
            {
                foreach (var item in personel)
                {
                    datagrid.DataSource = personel.ToList();
                }
            }
            else
            {
                MessageBox.Show("Böyle bir personel bulunmamaktadır!");
            }
        }
    }
}
