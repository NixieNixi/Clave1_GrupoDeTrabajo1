using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    //Clase parcial que se encarga de las funciones de Administracion de usuarios
    public partial class AdministradorPerfil
    {
        private void LimpiarControles()
        {
            //Limpia los controles
            txtUsuario.Text = null;
            cbxRol.Text = null;
            txtTelefono.Text = null;
            txtNombre.Text = null;
            txtEmail.Text = null;
            txtDireccion.Text = null;
            txtContraseña.Text = null;
        }

        private void LimpiarControlesMascota()
        {
            //se desactivan y limpian los controles de consulta de mascota
            cbxIdMascota.Enabled = false;
            cbxIdMascota.Items.Clear();
            cbxIdMascota.Text = null;
            txtNombreMascota.Text = null;
        }

        private void HabilitarEdicion(bool habilitar)
        {
            //Desahibilta cbxIdUsuario
            cbxIdUsuario.Enabled = !habilitar;

            //Habilita los controles
            txtUsuario.Enabled = habilitar;
            cbxRol.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            txtNombre.Enabled = habilitar;
            txtEmail.Enabled = habilitar;
            txtDireccion.Enabled = habilitar;
            txtContraseña.Enabled = habilitar;

            //Permite la edicion del contenido de los controles
            txtUsuario.ReadOnly = !habilitar;
            txtTelefono.ReadOnly = !habilitar;
            txtNombre.ReadOnly = !habilitar;
            txtEmail.ReadOnly = !habilitar;
            txtDireccion.ReadOnly = !habilitar;
            txtContraseña.ReadOnly = !habilitar;
            //Permite ver la contraseña para editar
            txtContraseña.UseSystemPasswordChar = !habilitar;
        }

        //Metodo del boton btnUsuarios que muestra el panel de usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //Se oculta el resto de los paneles
            panelInventario.Visible = false;
            panelCitas.Visible = false;
            //Se muestra el panel Usuario
            panelUsuario.Visible = true;

            //Crea una conexion a la DB
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                //Consulta la columna idUsuarios de la tabla Usuarios
                string query = "SELECT idUsuario FROM usuarios;";
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
        
        //Metodo del boton btnEditUser que cambia los controles al modo de edicion
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            //habilita funcion de guardar
            btnGuardarUser.Enabled = true;

            //desahabilitar funcion de nuevo usuario
            btnNuevoUser.Enabled = false;

            //Habilita la edicion de los campos
            HabilitarEdicion(true);

            //deshabilita los campos de mascota
            LimpiarControlesMascota();
        }

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            //habilita funcion de guardar
            btnGuardarUser.Enabled = true;

            //desahabilitar funcion de editar
            btnEditUser.Enabled = false;

            //se limpia el comboBox cbxIdUsuarios porque este campo se genera automaticamente
            cbxIdUsuario.Text = null;

            //limpia los controles
            LimpiarControles();
            LimpiarControlesMascota();

            //habilita edicion
            HabilitarEdicion(true);
        }

        //Metodo de cambio de registro mediante la seleccion de opcion en cbxIdUsuario
        private void cbxIdUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarControlesMascota();

            //Si no se ha seleccionado una opcion se limpian los controles
            if (cbxIdUsuario.SelectedIndex == -1)
            {
                LimpiarControles();
                LimpiarControlesMascota();
            }
            //Dependiendo de la seleccion se muestra un registro
            else
            {
                //convierte la seleccion de cbxIdUsuario a string y la guarda en IDSeleccion
                string IDSeleccion = cbxIdUsuario.SelectedItem.ToString();

                //cadena de conexion DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //cadena de consulta DB
                    string query = "SELECT Nombre, Telefono, Correo, Direccion, Rol, Usuario, Contrasena FROM usuarios WHERE idUsuario = @idUsuario;";
                    //Ni idea, esta no me la se
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idUsuario", IDSeleccion);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Cargar los datos obtenidos en los controles correspondientes
                                txtUsuario.Text = reader["Usuario"].ToString();
                                cbxRol.Text = reader["Rol"].ToString();
                                txtTelefono.Text = reader["Telefono"].ToString();
                                txtNombre.Text = reader["Nombre"].ToString();
                                txtContraseña.Text = reader["Contrasena"].ToString();
                                txtEmail.Text = reader["Correo"].ToString();
                                txtDireccion.Text = reader["Direccion"].ToString();
                            }
                        }
                    }
                }
                //Si el rol del usuario se muestra como "Dueno"
                if(cbxRol.Text=="Dueño")
                {
                    //se habilita el cbxIdMascota
                    cbxIdMascota.Enabled = true;

                    //Se consultan en DB los registros de idUsuario en la tabla mascotas que coincidan con el idUsuario seleccionado en cbxIdUsuario
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta
                        string query = "SELECT idMascota FROM mascotas WHERE idUsuario = @idUsuario";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@idUsuario", IDSeleccion);
                            connection.Open();
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    //cargar los id de las mascotas al comboBox
                                    cbxIdMascota.Items.Add(reader["idMascota"].ToString());
                                }
                            }
                        }
                    }
                }
                //si el rol no es "Dueno" entonces se deshabilita el comboBox cbxIdMascota
                else
                {
                    LimpiarControlesMascota();
                }
            }
        }

        //Metodo de que cambia la informacion de "Nombre de la mascota" segun el idMascota que se seleccione en el comboBox
        private void cbxIdMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si no se ha seleccionado ninguna opcion se limpian los controles
            if(cbxIdMascota.SelectedIndex == -1)
            {
                LimpiarControlesMascota();
            }
            //Dependiendo de la seleccion de idMascota se muestra un nombre
            else
            {
                //guarda el texto de la seleccion en ConsultaIdMascota
                string ConsultaIdMascota = cbxIdMascota.SelectedItem.ToString();

                //cadena de conexion a DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //cadena de consulta a DB
                    string query = "SELECT Nombre FROM mascotas WHERE idMascota = @idMascota;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idMascota", ConsultaIdMascota);
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            //inserta el nombre de la mascota segun la seleccion
                            if (reader.Read())
                            {
                                txtNombreMascota.Text = reader["Nombre"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void btnCancelarUser_Click(object sender, EventArgs e)
        {
            //habilitar los botones de editar y nuevo usuario
            btnEditUser.Enabled = true;
            btnNuevoUser.Enabled = true;
            //deshabilitar el boton de guardar
            btnGuardarUser.Enabled = false;
            //habilita nuevamente cbxIdUsuario y desahabilita el resto de controles
            HabilitarEdicion(false);

            //dependiendo de la seleccion en cbxIdUsuarios:
            //Sin seleccion - limpia los campos
            //Con seleccion - recupera la informacion segun el IdUsuario seleccionado
            cbxIdUsuario_SelectedIndexChanged(this, EventArgs.Empty);
        }
    }
}
