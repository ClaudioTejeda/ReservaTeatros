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
    public partial class PClientes : Form
    {
        private NClientes nclientes;
        public PClientes()
        {
            InitializeComponent();
            nclientes = new NClientes();
            CargarDatos();
        }

        private void PClientes_Load(object sender, EventArgs e)
        {

        }
        void CargarDatos()
        {
            dgclientes.DataSource = nclientes.obtenerClientesGrid();
        }

        void LimpiarDatos()
        {
            txtClienteid.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            checkBEstado.Checked = false;
            dateTimeFechaingreso.Value = DateTime.Now;
            errorProvider1.Clear();
        }

        private void checkBFiltro_CheckedChanged_1(object sender, EventArgs e)
        {
            dgclientes.DataSource = nclientes.obtenerClientesActivosGrid();
            if (checkBFiltro.Checked == false)
            {
                CargarDatos();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var clienteid = txtClienteid.Text.ToString();
            var nombres = txtNombres.Text.ToString();
            var apellidos = txtApellidos.Text.ToString();
            if (string.IsNullOrEmpty(clienteid) || string.IsNullOrWhiteSpace(clienteid))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(nombres) || string.IsNullOrWhiteSpace(nombres))
            {
                errorProvider1.SetError(txtNombres, "Debe ingresar Nombres");
                return;
            }
            if (string.IsNullOrEmpty(apellidos) || string.IsNullOrWhiteSpace(apellidos))
            {
                errorProvider1.SetError(txtApellidos, "Debe ingresar Apellidos");
                return;
            }

            if (agregar)
            {
                nclientes.AgregarClienets(new Clientes()
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaIngreso = dateTimeFechaingreso.Value,
                    Estado = checkBEstado.Checked,
                });
            }
            else
            {
                nclientes.EditarClientes(new Clientes()
                {
                    ClienteId = int.Parse(clienteid),
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaIngreso = dateTimeFechaingreso.Value,
                    Estado = checkBEstado.Checked
                });
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void dgmedicos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgclientes.Rows.Count)
            {
                txtClienteid.Text = dgclientes.CurrentRow.Cells["ClienteId"].Value.ToString();
                txtNombres.Text = dgclientes.CurrentRow.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = dgclientes.CurrentRow.Cells["Apellidos"].Value.ToString();
                if (DateTime.TryParse(dgclientes.CurrentRow.Cells["Fecha_de_Ingreso"].Value.ToString(), out DateTime fechaingreso))
                {
                    dateTimeFechaingreso.Value = fechaingreso;
                }
                checkBEstado.Checked = bool.Parse(dgclientes.CurrentRow.Cells["Estado"].Value.ToString());
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var clienteid = txtClienteid.Text.ToString();
            if (string.IsNullOrEmpty(clienteid) || string.IsNullOrWhiteSpace(clienteid))
            {
                return;
            }
            nclientes.EliminarClientes(int.Parse(clienteid));
            CargarDatos();
            LimpiarDatos();
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
