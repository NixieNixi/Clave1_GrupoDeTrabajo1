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
            txtRol.Text = null;
            txtTelefono.Text = null;
            txtNombre.Text = null;
            txtEmail.Text = null;
            txtDireccion.Text = null;
            txtContraseña.Text = null;
        }

        private void HabilitarEdicion(bool Habilitar)
        {
            //Desahibilta cbxIdUsuario
            cbxIdUsuario.Enabled = !Habilitar;

            //Habilita los controles
            txtUsuario.Enabled = Habilitar;
            txtRol.Enabled = Habilitar;
            txtTelefono.Enabled = Habilitar;
            txtNombre.Enabled = Habilitar;
            txtEmail.Enabled = Habilitar;
            txtDireccion.Enabled = Habilitar;
            txtContraseña.Enabled = Habilitar;

            //Permite la edicion del contenido de los controles
            txtUsuario.ReadOnly = !Habilitar;
            txtTelefono.ReadOnly = !Habilitar;
            txtNombre.ReadOnly = !Habilitar;
            txtEmail.ReadOnly = !Habilitar;
            txtDireccion.ReadOnly = !Habilitar;
            txtContraseña.ReadOnly = !Habilitar;
            //Permite ver la contraseña para editar
            txtContraseña.UseSystemPasswordChar = !Habilitar;
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
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                //Consulta la columna idUsuarios de la tabla Usuarios
                string query = "SELECT idUsuarios FROM usuarios";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Inserta los registros de idUsuario en el comboBox cbxUsuario
                            cbxIdUsuario.Items.Add(reader["idUsuarios"].ToString());
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

            //habilita edicion
            HabilitarEdicion(true);
        }

        //Metodo de cambio de registro mediante la seleccion de opcion en cbxIdUsuario
        private void cbxIdUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si no se ha seleccionado una opcion se limpian los controles
            if (cbxIdUsuario.SelectedIndex == -1)
            {
                LimpiarControles();
            }
            //Dependiendo de la seleccion se muestra un registro
            else
            {
                //convierte la seleccion de cbxIdUsuario a string y la guarda en IDSeleccion
                string IDSeleccion = cbxIdUsuario.SelectedItem.ToString();

                //cadena de conexion DB
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    //cadena de consulta DB
                    string query = "SELECT NombreUsuario, Telefono, correo, Direccion, Rol, Usuario, Contrasena FROM usuarios WHERE idUsuarios = @idUsuario;";
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
                                txtRol.Text = reader["Rol"].ToString();
                                txtTelefono.Text = reader["Telefono"].ToString();
                                txtNombre.Text = reader["NombreUsuario"].ToString();
                                txtContraseña.Text = reader["Contrasena"].ToString();
                                txtEmail.Text = reader["correo"].ToString();
                                txtDireccion.Text = reader["Direccion"].ToString();
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
            //deshabilitar el boton de guarda
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
