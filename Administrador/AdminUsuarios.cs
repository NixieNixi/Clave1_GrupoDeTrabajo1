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
        //Metodo del boton Usuarios que muestra el panel de usuarios y carga los registros de idUsuario de DB
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //Se oculta el resto de los paneles
            panelCitas.Visible = false;
            PanelPagos.Visible = false;
            panelMascotas.Visible = false;

            //----------------------------------------------------------------
            //Esta instruccion hace que el panel usuario ocupe el espacio designado pero se debe remover despues
            panelUsuario.Dock = DockStyle.Fill;
            //----------------------------------------------------------------

            //Se muestran los paneles de Usuario
            panelUsuario.Visible = true;
            panelBtnUsuarios.Visible = true;

            //se deshabilita por defecto el boton de editar para evitar que se editen registros vacios
            btnEditUser.Enabled = false;

            //Carga los registros de idUsuario de la DB
            ActualizarRegistros();
        }

        //Metodo del boton Cancelar que cancela los cambios en el modo de edicion y recupera al estado anterior
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

        //Metodo del boton Guardar para guardar los cambios en caso de edicion o creacion de nuevo user
        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            //Si no hay seleccion el comboBOx ID Usuario significa que se esta ingresando la informacion de un nuevo usuario
            if (cbxIdUsuario.SelectedIndex == -1)
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

        //Metodo del boton Editar que cambia los controles al modo de edicion
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

        //Metodo del boton Nuevo que limpia los controles y preprara para la edicion y posterior creacion de usuario
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

        //Metodo del ComboBox ID Usuario de cambio de registro mediante la seleccion de opcion en cbxIdUsuario
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
                //si se selecciona una opcion se habilita el boton editar para editar la informacion de ese usuario
                btnEditUser.Enabled = true;

                //convierte la seleccion de cbxIdUsuario a string y la guarda en IDSeleccion
                string IdSeleccion = cbxIdUsuario.SelectedItem.ToString();

                //Intentar conectar a DB y hacer la consulta de los datos del usuario
                try
                {
                    //cadena de conexion DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta DB
                        string query = "SELECT Nombre, Telefono, Correo, Direccion, Rol, Usuario, Contrasena FROM usuarios WHERE idUsuario = @idUsuario;";

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
                }
                //Si ocurre un error al conectar o hacer la consulta mostrar mensaje de error
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error: " + error.Message, "Error :(", MessageBoxButtons.OK);
                }

                //Si el rol del usuario se muestra como "Dueño"
                if (cbxRol.Text == "Dueño")
                {
                    //Intenta conectar a DB y hacer la cosulta de los id de las mascotas registradas a ese usuario
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
                                    LimpiarControlesMascota();

                                    //Si se encuentran mascotas registradas mostrar los idMascota en cbxidMascota
                                    if (reader.HasRows)
                                    {
                                        while (reader.Read())
                                        {
                                            //Cargar los idMascota en el comboBox
                                            cbxIdMascota.Items.Add(reader["idMascota"].ToString());
                                        }
                                        //habilitar el comboBox
                                        cbxIdMascota.Enabled = true;
                                    }
                                    else
                                    {
                                        //Si no hay mascotas se deshabilita el comboBox y se muestra un mensaje
                                        cbxIdMascota.Text = "No se encontraron mascotas";
                                        cbxIdMascota.Enabled = false;
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
                //si el rol no es "Dueno" entonces se deshabilita el comboBox cbxIdMascota
                else
                {
                    LimpiarControlesMascota();
                }
            }
        }

        //Metodo del ComboBox ID Mascota de que cambia la informacion segun el idMascota que se seleccione
        private void cbxIdMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si no se ha seleccionado ninguna opcion se limpian los controles
            if (cbxIdMascota.SelectedIndex == -1)
            {
                LimpiarControlesMascota();
            }
            //Dependiendo de la seleccion de idMascota se muestra un nombre
            else
            {
                //guarda el texto de la seleccion en ConsultaIdMascota
                string ConsultaIdMascota = cbxIdMascota.SelectedItem.ToString();

                //Intentar conectar a DB y hacer la consulta del nombre de la mascota
                try
                {
                    //cadena de conexion a DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta a DB
                        string query = "SELECT Nombre FROM mascotas WHERE idMascota = @idMascota;";

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
                                    txtNombreMascota.Text = reader["Nombre"].ToString();
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
            cbxIdMascota.Items.Clear();
            cbxIdMascota.Enabled = false;
            cbxIdMascota.Text = null;
            cbxIdMascota.SelectedIndex = -1;
            txtNombreMascota.Text = null;
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
                    //Intenta asignar los valores de los controles a los parámetros sql
                    try
                    {
                        //si los campos estan vacios mostrar mensaje de error
                        if(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtDireccion.Text))
                        {
                            MessageBox.Show("Por favor llene los campos", "Error", MessageBoxButtons.OK);
                        }
                        //si no se ha seleccionado un rol mostrar mensaje de error
                        else if(cbxRol.SelectedIndex == -1)
                        {
                            MessageBox.Show("Seleccione un rol", "Error", MessageBoxButtons.OK);
                        }
                        //si no se ha ingresado un numero entero o el numero no es de 8 digitos mostrar mesaje de error
                        else if(!int.TryParse(txtTelefono.Text, out _) || txtTelefono.Text.Length != 8)
                        {
                            MessageBox.Show("Ingrese un numero de telefono valido", "Error", MessageBoxButtons.OK);
                        }
                        //si no hay errores en los datos asignar los parametros con los datos del form
                        else
                        {
                        command.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                        command.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                        command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@Rol", cbxRol.Text);
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        command.Parameters.AddWithValue("@Correo", txtEmail.Text);
                        command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                        }
                    }
                    //si se produce otro error
                    catch(Exception error)
                    {
                        MessageBox.Show("Hay un error en los datos: " + error.Message, "Error", MessageBoxButtons.OK);
                    }

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

                            ActualizarRegistros();
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
                        MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error :(");
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
                    try
                    {
                        //si los campos estan vacios mostrar mensaje de error
                        if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtDireccion.Text))
                        {
                            MessageBox.Show("Por favor llene los campos", "Error", MessageBoxButtons.OK);
                        }
                        //si no se ha ingresado un numero entero o el numero no es de 8 digitos mostrar mesaje de error
                        else if (!int.TryParse(txtTelefono.Text, out _) || txtTelefono.Text.Length != 8)
                        {
                            MessageBox.Show("Ingrese un numero de telefono valido", "Error", MessageBoxButtons.OK);
                        }
                        //si no hay errores en los datos asignar los parametros con los datos del form
                        else
                        {
                            command.Parameters.AddWithValue("@idUsuario", cbxIdUsuario.Text);
                            command.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                            command.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                            command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                            command.Parameters.AddWithValue("@Rol", cbxRol.SelectedIndex.ToString());
                            command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                            command.Parameters.AddWithValue("@Correo", txtEmail.Text);
                            command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                        }
                    }
                    //si se produce otro error
                    catch (Exception error)
                    {
                        MessageBox.Show("Hay un error en los datos: " + error.Message, "Error", MessageBoxButtons.OK);
                    }

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
                        MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error :(");
                    }
                }
            }
        }

        //Metodo de actualizacion de registros de DB a comboBox ID Usuario
        private void ActualizarRegistros()
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
            catch
            {
                //Si no puede conectar mostrar mensaje de error
                MessageBox.Show("No hay sistema xd", "Error :(");

                //Cerrar menu de administracion de usuarios
                panelUsuario.Visible = false;
                panelBtnUsuarios.Visible = false;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AdministradorPerfil
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "AdministradorPerfil";
            this.ResumeLayout(false);

        }
    }
}
