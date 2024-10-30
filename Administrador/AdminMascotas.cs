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
        }

        private void cbxIdUsuarioMascota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxIdMascotaMascota_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    string query = "SELECT idUsuario FROM usuarios WHERE;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Inserta los registros de idUsuario en el comboBox cbxUsuario
                                cbxIdUsuario.Items.Add(reader["idUsuario"].ToString());
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
                panelUsuario.Visible = false;
                panelBtnUsuarios.Visible = false;
            }
        }

    }
}
