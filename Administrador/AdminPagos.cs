using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    /// <summary>
    /// Autor: CanelaFeliz
    /// Fecha: 07/11/24
    /// Desccripcion: Parte de la clase AdministradorPerfil que se encarga de las funciones del panel
    /// </summary>
    public partial class AdministradorPerfil
    {
        private void btnPagos_Click(object sender, EventArgs e)
        {
            //Se oculta el resto de los paneles
            panelMascotas.Visible = false;
            panelMascotas.Dock = DockStyle.None;
            panelBtnMascota.Visible = false;
            panelBtnMascota.Dock = DockStyle.None;
            panelCitas.Visible = false;
            panelCitas.Dock = DockStyle.None;
            panelBtnCitas.Visible = false;
            panelBtnCitas.Dock = DockStyle.None;
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
            panelBtnUsuarios.Visible = false;
            panelBtnUsuarios.Dock = DockStyle.None;

            //Se muestran los paneles de Pagos
            panelBtnPagos.Dock = DockStyle.Bottom;
            panelBtnPagos.Visible = true;
            panelPagos.Dock = DockStyle.Fill;
            panelPagos.Visible = true;

            CargarUsuariosConRolDueno();
        }

        private void CargarUsuariosConRolDueno()
        {
            cbxIdDuenoP.Items.Clear();
            try
            {
                // Conexión a la base de datos
                using (MySqlConnection conexion = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    conexion.Open();
                    string query = "SELECT IdUsuario FROM usuarios WHERE Rol = 'Dueño'";
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        cbxIdDuenoP.Items.Add(reader["IdUsuario"].ToString());
                    }
                    if (cbxIdDuenoP.Items.Count == 0)
                    {
                        cbxIdDuenoP.Items.Add("No hay usuarios disponibles");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }

        // Evento para cargar los detalles del usuario seleccionado en cbxIdDuenoP
        private void cbxIdDuenoP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIdDuenoP.SelectedItem != null && cbxIdDuenoP.SelectedItem.ToString() != "No hay usuarios disponibles")
            {
                CargarNombreUsuarioYPagos(cbxIdDuenoP.SelectedItem.ToString());
            }
        }

        private void CargarNombreUsuarioYPagos(string idUsuario)
        {
            txtNombreP.Clear();
            cbxIdPago.Items.Clear();
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    conexion.Open();

                    // Obtener el nombre del usuario
                    string queryNombre = "SELECT Nombre FROM usuarios WHERE IdUsuario = @IdUsuario";
                    MySqlCommand cmdNombre = new MySqlCommand(queryNombre, conexion);
                    cmdNombre.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    txtNombreP.Text = cmdNombre.ExecuteScalar()?.ToString() ?? "No disponible";

                    // Cargar los pagos asociados al usuario
                    string queryPagos = "SELECT IdPago FROM pagos WHERE IdUsuario = @IdUsuario";
                    MySqlCommand cmdPagos = new MySqlCommand(queryPagos, conexion);
                    cmdPagos.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    MySqlDataReader reader = cmdPagos.ExecuteReader();

                    bool hayPagos = false;
                    while (reader.Read())
                    {
                        cbxIdPago.Items.Add(reader["IdPago"].ToString());
                        hayPagos = true;
                    }

                    if (!hayPagos)
                    {
                        cbxIdPago.Items.Add("No hay pagos registrados");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message);
            }
        }

        // Evento para cargar detalles del pago seleccionado en cbxIdPago
        private void cbxIdPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIdPago.SelectedItem != null && cbxIdPago.SelectedItem.ToString() != "No hay pagos registrados")
            {
                CargarDetallesPago(cbxIdPago.SelectedItem.ToString());
            }
        }

        private void CargarDetallesPago(string idPago)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    conexion.Open();
                    string query = "SELECT Estado, Fecha, Total, TipoServicio, TipoPago FROM pagos WHERE IdPago = @IdPago";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@IdPago", idPago);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        cbxEstadoP.Text = reader["Estado"].ToString();
                        dtpFechaP.Value = Convert.ToDateTime(reader["Fecha"]);
                        txtTotalP.Text = reader["Total"].ToString();
                        txtTipoServicio.Text = reader["TipoServicio"].ToString();
                        cbxTipoPago.Text = reader["TipoPago"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles del pago: " + ex.Message);
            }
        }

    }
}
