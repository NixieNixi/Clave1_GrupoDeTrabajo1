using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    //Clase parcial que se encarga de las funciones de Administracion de usuarios
    public partial class AdministradorPerfil
    {
        //Metodo para limpiar los controles del panel de la informacion de usuario
        private void LimpiarControles()
        {
            //Limpia los controles
            txtUsuario.Text = null;
            cbxRol.Text = null;
            txtTelefono.Text = null;
            txtNombre.Text = null;
            txtEmail.Text = null;
            txtDireccion.Text = null;
            txtContrasena.Text = null;
        }

        //Metodo para limpiar los controles del panel de la informacion de mascota
        private void LimpiarControlesMascota()
        {
            //se desactivan y limpian los controles de consulta de mascota
            cbxIdMascota.Enabled = false;
            cbxIdMascota.Items.Clear();
            cbxIdMascota.Text = null;
            txtNombreMascota.Text = null;
        }

        //Metodo para habilitar la edicion de los controles de la informacion del usuario
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
            txtContrasena.Enabled = habilitar;

            //Permite la edicion del contenido de los controles
            txtUsuario.ReadOnly = !habilitar;
            txtTelefono.ReadOnly = !habilitar;
            txtNombre.ReadOnly = !habilitar;
            txtEmail.ReadOnly = !habilitar;
            txtDireccion.ReadOnly = !habilitar;
            txtContrasena.ReadOnly = !habilitar;
            //Permite ver la contraseña para editar
            txtContrasena.UseSystemPasswordChar = !habilitar;
        }

        //Metodo del boton btnUsuarios que muestra el panel de usuarios y carga los registros de idUsuario de DB
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //Se oculta el resto de los paneles
            //panelCitas.Visible = false;
            //Se muestra el panel Usuario
            panelUsuario.Visible = true;
            //se deshabilita por defecto el boton de editar para evitar que se editen registros vacios
            btnEditUser.Enabled = false;

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

        //Metodo del boton btnNuevoUser que limpia los controles y preprara para la edicion y posterior creacion de usuario
        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            //habilita funcion de guardar
            btnGuardarUser.Enabled = true;

            //desahabilitar funcion de editar
            btnEditUser.Enabled = false;

            //se limpia el comboBox cbxIdUsuarios porque este campo se genera automaticamente
            cbxIdUsuario.SelectedIndex = -1;

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
                //si no se ha seleccionado una opcion se deshabilita el boton de editar para evitar editar registros vacios
                btnEditUser.Enabled = false;
            }
            //Dependiendo de la seleccion se muestra un registro
            else
            {
                //si se selecciona una opcion se habilita el boton editar para editar la informacion
                btnEditUser.Enabled = true;

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
                                txtContrasena.Text = reader["Contrasena"].ToString();
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

        //Metodo que cancela los cambios en el modo de edicion y recupera al estado anterior
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

        //Metodo para guardar los cambios en caso de edicion o creacion de nuevo user
        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            // Obtener los datos de los controles en el formulario
            string idUsuario = cbxIdUsuario.Text.ToString();
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            string nombre = txtNombre.Text.ToString();
            string rol = cbxRol.SelectedItem.ToString();
            string telefono = txtTelefono.Text;
            string correo = txtEmail.Text;
            string direccion = txtDireccion.Text;
            
            //Si no hay seleccion el comboBOx ID Usuario significa que se esta ingresando la informacion de un nuevo usuario
            if(cbxIdUsuario.SelectedIndex == -1)
            {
                //Lammada al metodo NuevoUser que guardara la informacion en DB
                NuevoUser();
            }
            //Si hay seleccion entonces se esta modificando la informacion de el usuario con el ID mostrado en el comboBox
            else
            {
                //Llamada al metodo GuardarUser que actualizara la informacion del usuario con el ID correspondiente
                GuardarUser();
            }
           
        }

        //Metodo de insercion de nuevo usuario a DB
        private void NuevoUser()
        {
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                //Consulta sql para insertar un nuevo usuario
                string query = @"INSERT INTO usuarios (Usuario, Contrasena, Nombre, Rol, Telefono, Correo, Direccion)
                     VALUES (@Usuario, @Contrasena, @Nombre, @Rol, @Telefono, @Correo, @Direccion);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //Asignar los valores de los controles a los parámetros sql
                    command.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    command.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Rol", cbxRol.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    command.Parameters.AddWithValue("@Correo", txtEmail.Text);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                    //Intenta insertar nuevo registro a DB
                    try
                    {
                        //Abrir la conexión a la base de datos
                        connection.Open();
                        
                        //variable para comprobar cuantas filas fueron agregadas
                        int rowsAffected = command.ExecuteNonQuery();

                        //Comprobar si la inserción fue exitosa, si rowsAffected es mayor que 0 significa que al menos una fila fue agregada
                        if (rowsAffected > 0)
                        {
                            //Se deshabilita la edicion para evitar ingresar el mismo usuario nuevamente por accidente
                            HabilitarEdicion(false);

                            MessageBox.Show("Usuario ingresado correctamente.", "Operacion exitosa!");
                        }
                        //Si no se cambio ninguna fila mostrar mensaje de error
                        else
                        {
                            MessageBox.Show("Error al ingresar el usuario.", "Error :(");
                        }
                    //Si no puede hacer el registro mostrar mensaje de error
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Ha ocurrido un error");
                    }
                }
            }
        }

        //Metodo de actualizacion de datos de usuario en DB
        private void GuardarUser()
        {
            //Consulta sql para actualizar los datos del usuario
            string query = @"UPDATE usuarios 
                     SET Usuario = @Usuario, 
                         Contrasena = @Contrasena, 
                         Nombre = @nombre,
                         Rol = @Rol, 
                         Telefono = @Telefono, 
                         Correo = @Correo, 
                         Direccion = @Direccion
                     WHERE idUsuario = @idUsuario";
            //WHERE indica en que registro se hara la actualizacion

            //Realizar la actualización en la base de datos
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Asignar parámetros con los datos de los controles del formulario
                    command.Parameters.AddWithValue("@idUsuario", cbxIdUsuario);
                    command.Parameters.AddWithValue("@Usuario", txtUsuario);
                    command.Parameters.AddWithValue("@Contrasena", txtContrasena);
                    command.Parameters.AddWithValue("@Nombre", txtNombre);
                    command.Parameters.AddWithValue("@Rol", cbxRol);
                    command.Parameters.AddWithValue("@Telefono", txtTelefono);
                    command.Parameters.AddWithValue("@Correo", txtEmail);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion);

                    //Intentar hacer la actualizacion del registro
                    try
                    {
                        //conexion a DB
                        connection.Open();

                        //variable para comprobar cuantas filas fueron modificadas
                        int rowsAffected = command.ExecuteNonQuery();

                        //Si al menos una fila fue cambiada se muestra el mensaje de exito
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos actualizados correctamente", "Operacion exitosa");

                            //Se deshabilita la edicion para evitar actualizar los datos por accidente
                            HabilitarEdicion(false);
                            //habilitar los botones de editar y nuevo usuario
                            btnEditUser.Enabled = true;
                            btnNuevoUser.Enabled = true;
                            //deshabilitar el boton de guardar
                            btnGuardarUser.Enabled = false;
                        }
                        //Si no se cambio ninguna fila se muestra un mensaje de error
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el registro.", "Error :(");
                        }
                    }
                    //Si no puede modificar el registro mostrar mensaje de error
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                    }
                }
            }
        }
    }
}
