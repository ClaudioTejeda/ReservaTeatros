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
    public partial class Buscarcliente : Form
    {
        NClientes   nclientes;
        public string ClienteId { get; set; }
        public string Nombre_Completo { get; set; }
        public string Apellidos { get; set; }
        public string FechaIngreso { get; set; }
        public string Estado { get; set; }
        public Buscarcliente()
        {
            InitializeComponent();
            nclientes = new NClientes();
            cargardatos();
        }

        private void Buscarcliente_Load(object sender, EventArgs e)
        {

        }
        private void cargardatos()
        {
            var datos = nclientes.BuscarclientesGrid();
            dgBuscarMedico.DataSource = datos;
        }

        private void checkBfiltro_CheckedChanged(object sender, EventArgs e)
        {
            dgBuscarMedico.DataSource = nclientes.BuscarClientesActivosGrid();
            if (checkBfiltro.Checked == false)
            {
                cargardatos();
            }
        }

        private void dgBuscarMedico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteId = dgBuscarMedico.CurrentRow.Cells["ClienteId"].Value.ToString();
            Nombre_Completo = dgBuscarMedico.CurrentRow.Cells["Nombre_Completo"].Value.ToString();
            FechaIngreso = dgBuscarMedico.CurrentRow.Cells["Fecha_de_Ingreso"].Value.ToString();
            Estado = dgBuscarMedico.CurrentRow.Cells["Estado"].Value.ToString();
            this.Visible = false;
        }
    }
}
