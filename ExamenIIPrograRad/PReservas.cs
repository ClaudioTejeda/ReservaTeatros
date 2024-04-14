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
    public partial class PReservas : Form
    {
        NReservas nreservas;
        public PReservas()
        {
            InitializeComponent();
            nreservas = new NReservas();
            CargarDatos();
        }

        private void PReservas_Load(object sender, EventArgs e)
        {

        }
        void CargarDatos()
        {
            var datos = nreservas.obtenerreservasGrid();
            dgReservas.DataSource = datos;
        }
        void LimpiarDatos()
        {
            txtCliente.Text = "";
            txtTeatro.Text = "";
            idmedico.Text = "";
            idpaciente.Text = "";
            txtCitaId.Text = "";
            dateTimeFechaingreso.Value = DateTime.Now;
            errorProvider1.Clear();
        }
        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtCliente.Text.ToString()) || string.IsNullOrWhiteSpace(txtCliente.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtCliente, "Debe de buscar y seleccionar un Cliente");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtTeatro.Text.ToString()) || string.IsNullOrWhiteSpace(txtTeatro.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtTeatro, "Debe buscar y seleccionar un Teatro");
                return FormularioValido;
            }
            return FormularioValido;
        }

        private void PCitas_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnbuscarMedico_Click_1(object sender, EventArgs e)
        {
            Buscarcliente reserva = new Buscarcliente();
            reserva.ShowDialog();
            idmedico.Text = reserva.ClienteId;
            txtCliente.Text = reserva.Nombre_Completo;
        }
        private void btnBuscarPaciente_Click_1(object sender, EventArgs e)
        {
            BuscarTeatros paciente = new BuscarTeatros();
            paciente.ShowDialog();
            idpaciente.Text = paciente.Teatroid;
            txtTeatro.Text = paciente.Nombre;
        }
        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Reservas reserva = new Reservas()
                {
                    ClienteId = int.Parse(idmedico.Text.ToString()),
                    TeatroId = int.Parse(idpaciente.Text.ToString()),
                    Cliente = txtCliente.Text,
                    Teatro = txtTeatro.Text,
                    FechaReserva = dateTimeFechaingreso.Value,
                };
                if (!string.IsNullOrEmpty(txtCitaId.Text) && int.TryParse(txtCitaId.Text.ToString(), out int reservaid) && reservaid != 0)
                {
                    reserva.ReservaId = reservaid;
                    nreservas.Editarreservas(reserva);
                }
                else
                {
                    nreservas.Agregarreservas(reserva);
                }
                LimpiarDatos();
                CargarDatos();
            }

        }

        private void dgPacientes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgReservas.Rows.Count)
            {
                txtCitaId.Text = dgReservas.CurrentRow.Cells["ReservaId"].Value.ToString();
                idmedico.Text = dgReservas.CurrentRow.Cells["ClienteId"].Value.ToString();
                idpaciente.Text = dgReservas.CurrentRow.Cells["TeatroId"].Value.ToString();
                txtCliente.Text = dgReservas.CurrentRow.Cells["Cliente"].Value.ToString();
                txtTeatro.Text = dgReservas.CurrentRow.Cells["Teatro"].Value.ToString();
                dateTimeFechaingreso.Text = dgReservas.CurrentRow.Cells["FechaReserva"].Value.ToString();
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            var reservaid = txtCitaId.Text.ToString();
            if (string.IsNullOrEmpty(reservaid) || string.IsNullOrWhiteSpace(reservaid))
            {
                return;
            }
            nreservas.Eliminar(int.Parse(reservaid));
            CargarDatos();
            LimpiarDatos();
        }
    }
}
