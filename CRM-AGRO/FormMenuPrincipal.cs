using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_AGRO
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
           new FormVendas().ShowDialog();
        }

        private void btnLogistica_Click(object sender, EventArgs e)
        {
           new Formlogistica().ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
          new FormRelatorio().ShowDialog();
        }
    }
}
