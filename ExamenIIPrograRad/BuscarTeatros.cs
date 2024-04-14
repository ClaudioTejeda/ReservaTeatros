using CapaNegocio;
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
    public partial class BuscarTeatros : Form
    {
        NTeatros nteatros;
        public string Teatroid { get; set; }
        public string Nombre { get; set; }
        public string Capacidad { get; set; }
        public string Estado { get; set; }
        public BuscarTeatros()
        {
            InitializeComponent();
            nteatros = new NTeatros();
        }

        private void BuscarTeatros_Load(object sender, EventArgs e)
        {

        }
        private void cargardatos()
        {
            var datos = nteatros.buscarteatrosgrid();
            dgBuscarPaciente.DataSource = datos;
        }

        private void dgBuscarPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Teatroid = dgBuscarPaciente.CurrentRow.Cells["TeatroId"].Value.ToString();
            Nombre = dgBuscarPaciente.CurrentRow.Cells["Nombre"].Value.ToString();
            Capacidad = dgBuscarPaciente.CurrentRow.Cells["Capacidad"].Value.ToString();
            Estado = dgBuscarPaciente.CurrentRow.Cells["Estado"].Value.ToString();
            this.Visible = false;
        }
    }
}
