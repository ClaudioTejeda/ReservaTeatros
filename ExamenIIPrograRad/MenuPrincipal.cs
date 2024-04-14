using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenIIPrograRad
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PClientes clientes = new PClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void gestionarTeatrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PTeatros teatros = new PTeatros();
            teatros.MdiParent = this;
            teatros.Show();
        }
    }
}
