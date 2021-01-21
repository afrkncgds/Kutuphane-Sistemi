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
    public partial class AnsiklopediBilgileri : Form
    {
        public AnsiklopediBilgileri()
        {
            InitializeComponent();
        }

        KutuphaneEntities ke = new KutuphaneEntities();

        private void btnGetir_Click(object sender, EventArgs e)
        {
            datagrid.DataSource = ke.Ansiklopediler.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var ansiklopedi = ke.Ansiklopediler.Where(w => w.Ad == txtArama.text);

            if (ansiklopedi != null)
            {
                foreach (var item in ansiklopedi)
                {
                    datagrid.DataSource = ansiklopedi.ToList();
                }
            }
            else
            {
                MessageBox.Show("Böyle bir ansiklopedi bulunmamaktadır!");
            }
        }
    }
}
