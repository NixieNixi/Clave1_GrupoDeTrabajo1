using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    //Clase parcial que se encarga de las funciones de Administracion de mascotas
    public partial class AdministradorPerfil
    {
        private void btnMascotas_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
            panelBtnUsuarios.Visible = false;
            panelBtnUsuarios.Dock = DockStyle.None;

            panelBtnMascota.Dock = DockStyle.Bottom;
            panelBtnMascota.Visible = true;
            panelMascotas.Dock = DockStyle.Fill;
            panelMascotas.Visible = true;

            ActualizarRegistrosMascota();
        }

        private void cbxIdDueno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIdDueno.SelectedIndex == -1)
            {
                //cosas
            }
            else
            {
                string IdSeleccion = cbxIdDueno.SelectedItem.ToString();

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
                                    txtNombreDueno.Text = reader["Nombre"].ToString();
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

                try
                {
                    //cadena de conexion DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta DB
                        string query = "SELECT idMascota FROM mascotas WHERE idUsuario = @idUsuario";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            //Agregar el parametro a la consulta
                            command.Parameters.AddWithValue("@idUsuario", IdSeleccion);

                            //Establecer conexion a DB
                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                //Limpiar los controles de mascota por si habia un registro cargado
                                LimpiarMascota();

                                //Si se encuentran mascotas registradas mostrar los idMascota en cbxidMascota
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        //Cargar los idMascota en el comboBox
                                        cbxIdMascotaMascota.Items.Add(reader["idMascota"].ToString());
                                    }
                                    //habilitar el comboBox
                                    cbxIdMascotaMascota.Enabled = true;
                                }
                                else
                                {
                                    //Si no hay mascotas se deshabilita el comboBox y se muestra un mensaje
                                    cbxIdMascotaMascota.Text = "No se encontraron mascotas";
                                    cbxIdMascotaMascota.Enabled = false;
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

        private void cbxIdMascotaMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si no se ha seleccionado ninguna opcion se limpian los controles
            if (cbxIdMascotaMascota.SelectedIndex == -1)
            {
                LimpiarMascota();
            }
            //Dependiendo de la seleccion de idMascota se muestra un nombre
            else
            {
                //guarda el texto de la seleccion en ConsultaIdMascota
                string ConsultaIdMascota = cbxIdMascotaMascota.SelectedItem.ToString();

                //Intentar conectar a DB y hacer la consulta del nombre de la mascota
                try
                {
                    //cadena de conexion a DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta a DB
                        string query = "SELECT Nombre, Raza, Especie, Sexo FROM mascotas WHERE idMascota = @idMascota;";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            //Agregar el parametro a la consulta
                            command.Parameters.AddWithValue("@idMascota", ConsultaIdMascota);

                            //Conectar a DB
                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                //inserta el nombre de la mascota segun la seleccion
                                if (reader.Read())
                                {
                                    txtNombreMascotaMascota.Text = reader["Nombre"].ToString();
                                    txtRazaMascota.Text = reader["Raza"].ToString();
                                    txtEspecieMascota.Text = reader["Especie"].ToString();
                                    txtSexoMascota.Text = reader["Sexo"].ToString();
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

        private void ActualizarRegistrosMascota()
        {
            //Limpia los elementos del comboBox ID Usuario
            cbxIdUsuario.Items.Clear();

            //Intentar conectar a DB
            try
            {
                //Crea una conexion a la DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //Consulta la columna idUsuarios de la tabla Usuarios
                    string query = "SELECT idUsuario FROM usuarios WHERE rol = 'Dueño';";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Inserta los registros de idUsuario en el comboBox cbxUsuario
                                cbxIdDueno.Items.Add(reader["idUsuario"].ToString());
                            }
                        }
                    }
                }
            }
            catch
            {
                //Si no puede conectar mostrar mensaje de error
                MessageBox.Show("No hay sistema xd", "Error :(");

                //Cerrar menu de administracion de usuarios
                panelMascotas.Visible = false;
                panelBtnMascota.Visible = false;
            }
        }

        private void LimpiarMascota()
        {
            cbxIdMascotaMascota.Text = null;
            cbxIdMascotaMascota.Items.Clear();
            txtNombreMascotaMascota.Text = null;
            txtRazaMascota.Text = null;
            txtEspecieMascota.Text = null;
            txtSexoMascota.Text = null;
        }
    }
}
