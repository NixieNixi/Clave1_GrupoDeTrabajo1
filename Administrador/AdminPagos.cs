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

            CargarUsuarios();
        }

        private void CargarUsuarios()

        {
            //Limpia los elementos del comboBox ID Usuario
            cbxIdDuenoP.Items.Clear();

            //Intentar conectar a DB
            try
            {
                //Crea una conexion a la DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //Consulta la columna idUsuarios de la tabla Usuarios que tengan rol de 'Dueño'
                    string query = "SELECT idUsuario FROM usuarios WHERE rol = 'Dueño';";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Inserta los registros de idUsuario en el comboBox cbxUsuario
                                cbxIdDuenoP.Items.Add(reader["idUsuario"].ToString());
                            }
                        }
                    }
                }
            }
            catch
            {
                //Si no puede conectar mostrar mensaje de error
                MessageBox.Show("Error de conexion a Base de datos", "Error :(");

                //Cerrar menu de administracion de usuarios
                panelPagos.Visible = false;
                panelBtnPagos.Visible = false;
            }
        }

        private void cbxIdDuenoP_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (cbxIdDuenoP.SelectedIndex == -1)
            {
                //Limpiar controles
                LimpiarPagos();

                btnRegistrarP.Enabled = false;
                btnGuardarP.Enabled = false;
            }
            else
            {
                btnRegistrarP.Enabled = true;

                //convierte el id seleccionado del combobox
                string IdSeleccion = cbxIdDuenoP.SelectedItem.ToString();

                try
                {
                    //cadena de conexion DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta DB
                        string query = "SELECT Nombre FROM usuarios WHERE idUsuario = @idUsuario;";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            //Agregar el parametro a la consulta
                            command.Parameters.AddWithValue("@idUsuario", IdSeleccion);

                            //Establecer conexion a DB
                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtNombreP.Text = reader["Nombre"].ToString();
                                }
                            }
                        }
                    }
                }
                //Si ocurre un error al conectar o hacer la consulta mostrar mensaje de error
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error: " + error.Message, "Error :(", MessageBoxButtons.OK);
                }
            }
                CargarPagos();
        }

        private void CargarPagos()
        {
            //convierte el id seleccionado del combobox
            string IdSeleccion = cbxIdDuenoP.SelectedItem.ToString();

            try
            {
                //cadena de conexion DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //cadena de consulta DB
                    string query = "SELECT idPago FROM pagos WHERE idUsuario = @idUsuario AND Estado = 'Pendiente'";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //Agregar el parametro a la consulta
                        command.Parameters.AddWithValue("@idUsuario", IdSeleccion);

                        //Establecer conexion a DB
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            //Limpiar los controles por si habia un registro cargado
                            LimpiarPagos();

                            //Si se encuentran mascotas registradas mostrar los idMascota en cbxidMascota
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //Cargar los idMascota en el comboBox
                                    cbxIdPago.Items.Add(reader["idPago"].ToString());
                                }
                                //habilitar el comboBox
                                cbxIdPago.Enabled = true;
                            }
                            else
                            {
                                cbxIdPago.Items.Add("No se encontraron pagos");
                                cbxIdPago.SelectedIndex = 0;
                                cbxIdPago.Enabled = false;
                            }
                        }
                    }
                }
            }
            //Si ocurre un error al conectar o hacer la consulta mostrar mensaje de error
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error.Message, "Error :(", MessageBoxButtons.OK);
            }
        }

        private void LimpiarPagos()
        {
            //limpia los controles
            cbxIdPago.Text = null;
            cbxIdPago.Items.Clear();
            cbxEstado.SelectedIndex = -1;
            dtpFechaP.Value = DateTime.Now;
            cbxFormaPago.SelectedIndex = -1;
            txtTipoServicio.Clear();
            txtTotalP.Clear();
        }

        private void cbxIdPago_SelectedIndexChanged(object sender, EventArgs e)

        {
            //Si no se ha seleccionado ninguna opcion se limpian los controles
            if (cbxIdPago.SelectedIndex == -1)
            {
                LimpiarMascota();
            }
            //Dependiendo de la seleccion de idMascota se muestra un nombre
            else
            {
                //si se ha seleccionado una mascota habilita la funcion de editar
                btnEditM.Enabled = true;

                //guarda el texto de la seleccion en ConsultaIdMascota
                string ConsultaIdMascota = cbxIdPago.SelectedItem.ToString();

                //Intentar conectar a DB y hacer la consulta del nombre de la mascota
                try
                {
                    //cadena de conexion a DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta a DB
                        string query = "SELECT Nombre, Raza, Especie, Sexo, FechaNacimiento FROM mascotas WHERE idMascota = @idMascota;";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            //Agregar el parametro a la consulta
                            command.Parameters.AddWithValue("@idMascota", ConsultaIdMascota);

                            //Conectar a DB
                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                //Inserta la informacion en los controles correspondientes
                                if (reader.Read())
                                {
                                    txtNombreMascotaM.Text = reader["Nombre"].ToString();
                                    txtRazaM.Text = reader["Raza"].ToString();
                                    txtEspecieM.Text = reader["Especie"].ToString();
                                    txtSexoM.Text = reader["Sexo"].ToString();
                                    dtpFechaNacimiento.Value = Convert.ToDateTime(reader["FechaNacimiento"]);
                                }
                            }
                        }
                    }
                }
                //Si ocurre un error al conectar o hacer la consulta mostrar mensaje de error
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error: " + error.Message, "Error :(", MessageBoxButtons.OK);
                }
            }
        }

    }
}
