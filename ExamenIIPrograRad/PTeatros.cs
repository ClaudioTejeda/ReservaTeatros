using CapaDatos;
using CapaDatos.BasedeDatos.Modelos;
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
    public partial class PTeatros : Form
    {
        private NTeatros nTeatros;
        private NReservas nReservas;
        public PTeatros()
        {
            InitializeComponent();
            nTeatros = new NTeatros();
            nReservas = new NReservas();
            CargarDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PTeatros_Load(object sender, EventArgs e)
        {

        }
        void CargarDatos()
        {
            dgPacientes.DataSource = nTeatros.obtenerreatrosGrid();
        }

        void LimpiarDatos()
        {
            txtPacienteid.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            checkBEstado.Checked = false;
            errorProvider1.Clear();
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            var agregar = false;
            var teatroid = txtPacienteid.Text.ToString();
            var nombres = txtNombres.Text.ToString();
            var capacidad = txtApellidos.Text.ToString();
            if (string.IsNullOrEmpty(teatroid) || string.IsNullOrWhiteSpace(teatroid))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(nombres) || string.IsNullOrWhiteSpace(nombres))
            {
                errorProvider1.SetError(txtNombres, "Debe ingresar Nombre");
                return;
            }
            if (string.IsNullOrEmpty(capacidad) || string.IsNullOrWhiteSpace(capacidad))
            {
                errorProvider1.SetError(txtApellidos, "Debe ingresar Capacidad");
                return;
            }

            if (agregar)
            {
                nTeatros.Agregarteatros(new Teatros()
                {
                    Nombre = nombres,
                    Capacidad = int.Parse(capacidad),
                    Estado = checkBEstado.Checked,
                });
            }
            else
            {
                nTeatros.Editarteatros(new Teatros()
                {
                    TeatroId = int.Parse(teatroid),
                    Nombre = nombres,
                    Capacidad = int.Parse(capacidad),
                    Estado = checkBEstado.Checked,
                });
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void dgPacientes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgPacientes.Rows.Count)
            {
                txtPacienteid.Text = dgPacientes.CurrentRow.Cells["TeatroId"].Value.ToString();
                txtNombres.Text = dgPacientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellidos.Text = dgPacientes.CurrentRow.Cells["Capacidad"].Value.ToString();
                checkBEstado.Checked = bool.Parse(dgPacientes.CurrentRow.Cells["Estado"].Value.ToString());
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var teatroId = txtPacienteid.Text.ToString();
            if (string.IsNullOrEmpty(teatroId) || string.IsNullOrWhiteSpace(teatroId))
            {
                return;
            }
            var asociado = nReservas.todaslasreservas().Where(c => c.TeatroId == int.Parse(teatroId)).ToList();
            if (asociado.Count > 0)
            {
                MessageBox.Show("El Teatro esta asociado a una reservacion para eliminar desvincule ");
                return;
            }
            nTeatros.Eliminarteatros(int.Parse(teatroId));
            CargarDatos();
            LimpiarDatos();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
