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
    public partial class DergiBilgileri : Form
    {
        public DergiBilgileri()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void btnAra_Click(object sender, EventArgs e)
        {
            var dergi = ke.Dergiler.Where(w => w.Ad == txtArama.text);

            if (dergi != null)
            {
                foreach (var item in dergi)
                {
                    datagrid.DataSource = dergi.ToList();
                }
            }
            else
            {
                MessageBox.Show("Böyle bir dergi bulunmamaktadır!");
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            datagrid.DataSource = ke.Dergiler.ToList();
        }
    }
}
