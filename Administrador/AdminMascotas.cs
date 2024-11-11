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
    /// Fecha: 30/10/24
    /// Desccripcion: Parte de la clase Administrador perfil que se encarga de las funciones del panel AdminMascotas donde
    /// se realizan las operaciones de gestion de mascotas (Consultar, Modificar, Crear y Eliminar mascotas)
    /// </summary>

    ///<remarks>
    ///Modificado por: CanelaFeliz
    ///Fecha de modificacion: 31/10/24
    ///Descripcion: Funcion de consulta, nuevo y editar completas
    ///Falta Fucion de borrar
    ///Faltan agregar paneles para terminar funciones
    ///</remarks>
    public partial class AdministradorPerfil
    {
        /// <summary>
        /// Campo que permite activar o desactivar la actualizacion y limpieza de los registros de mascotas
        /// </summary>
        bool activarM = false;

        /// <summary>
        /// Evento Click del boton 'Mascotas'
        /// Oculta el resto de paneles y los desacopla de la ventana para que los paneles de las funciones de mascotas tomen
        /// su posicion correctamnte.
        /// 
        /// Carga inicial al combobox los idUsuario
        /// </summary>
        private void btnMascotas_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
            panelBtnUsuarios.Visible = false;
            panelBtnUsuarios.Dock = DockStyle.None;
            panelCitas.Visible = false;
            panelCitas.Dock = DockStyle.None;
            panelBtnCitas.Visible = false;
            panelBtnCitas.Dock = DockStyle.None;
            panelPagos.Visible = false;
            panelPagos.Dock = DockStyle.None;
            panelBtnPagos.Visible = false;
            panelBtnPagos.Dock = DockStyle.None;
            panelInventario.Visible = false;
            panelInventario.Dock = DockStyle.None;
            panelBtnInventario.Visible = false;
            panelBtnInventario.Dock = DockStyle.None;

            panelBtnMascota.Dock = DockStyle.Bottom;
            panelBtnMascota.Visible = true;
            panelMascotas.Dock = DockStyle.Fill;
            panelMascotas.Visible = true;

            ActualizarRegistrosDueno();
        }

        /// <summary>
        /// Este boton solo se activa si hay un usuario y una mascota seleccionada
        /// 
        /// Evento Click del boton 'Editar'
        /// Habilita las funciones de cancelar y guardar.
        /// Deshabilita la funcion de crear nueva mascota.
        /// Activa el estado de edicion al cambiar el campo booleano 'activar' a true para permitir el cambio de usuario
        /// sin limpiar los campos de mascota
        /// Llama a la funcion HabilitarEdicionM para habilitar la edicion de los controles
        /// </summary>
        private void btnEditM_Click(object sender, EventArgs e)
        {
            //Se establece el limite para colocar fecha de nacimiento al dia de hoy
            dtpFechaNacimiento.MaxDate = DateTime.Today;

            //habilitar botones
            btnCancelarM.Enabled = true;
            btnGuardarM.Enabled = true;
            //deshabilitar boton nuevo
            btnNuevoM.Enabled = false;
            btnBorrarMascota.Enabled = false;

            //activar modo de edicion
            activarM = true;
            HabilitarEdicionM(true);
        }

        /// <summary>
        /// Este boton solo se activa si hay un usuario seleccionado
        /// 
        /// Evento Click del boton 'Nuevo'
        /// Habilita las funciones de cancelar y guardar.
        /// Deshabilita la funcion de Editar
        /// Activa el estado de edicion al cambiar el campo booleano 'activar' a true para permitir el cambio de usuario
        /// sin limpiar los campos de mascota
        /// Llama a la funcion LimpiarMascota para limpiar los controles por si habia un regristro de mascota cargado
        /// Llama a la funcion HabilitarEdicionM para poder ingresar datos en los controles
        /// </summary>
        private void btnNuevoM_Click(object sender, EventArgs e)
        {
            //Se establece el limite para colocar fecha de nacimiento al dia de hoy
            dtpFechaNacimiento.MaxDate = DateTime.Today;

            //habilitar botones
            btnCancelarM.Enabled = true;
            btnGuardarM.Enabled = true;
            //deshabilitar boton editar
            btnEditM.Enabled = false;
            btnBorrarMascota.Enabled = false;
            btnBorrarMascota.Enabled = false;

            //limpiar controles
            LimpiarMascota();

            //activar modo de edicion
            activarM = true;
            HabilitarEdicionM(true);
        }

        /// <summary>
        /// Este boton solo se activa al tener la funcion de editar o nuevo activas
        /// 
        /// Evento Click del boton 'Cancelar'
        /// Deshabilita el boton de guardar para evitar guardar datos vacios o incorrectos
        /// Habilita el boton nuevo para crear una nueva mascota
        /// Deshabilita el estado de edicion y limpia los controles
        /// </summary>
        private void btnCancelarM_Click(object sender, EventArgs e)
        {
            //Se reestablece el limite para el control
            dtpFechaNacimiento.MaxDate = Convert.ToDateTime("31 / 12 / 9998");

            //Deshabilita el boton de guardar
            btnGuardarM.Enabled = false;
            //habilita el boton de nuevo
            btnNuevoM.Enabled = true;

            //deshabilita el estado de edicion
            activarM = false;
            HabilitarEdicionM(false);

            //vuelve a cargar los idUsuario y los idMasctoa en sus combobox 
            cbxIdDueno_SelectedIndexChanged(this, EventArgs.Empty);

            //desactiva el boton de cancelar
            btnCancelarM.Enabled = false;
        }

        /// <summary>
        /// Evento Click del boton 'Guardar'
        /// Dependiendo de la seleccion de combobox 'ID Mascota':
        /// Si esta vacio llama al metodo NuevaMascota para registrar una nueva mascota
        /// Si tiene seleccion se llama al metodo GuardarMascota para modificar el registro de la mascota seleccionada
        /// </summary>
        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            //Si no hay seleccion de ID Mascota significa que se esta guardando una nueva mascota
            if (cbxIdMascotaM.SelectedIndex == -1)
            {
                NuevaMascota();
            }
            //Si hay seleccion significa que se esta modificando la informacion de la mascota con el ID seleccionado
            else
            {
                GuardarMascota();
            }
        }

        /// <summary>
        /// Evento de Cambio de Seleccion de Elemento del combobox 'ID Usuario'
        /// Dependiendo de la seleccion del combobox:
        /// 
        /// Sin seleccion: Limpia los controles y deshablita el boton de editar porque no habria mascota seleccionada
        /// para editar su informacion
        /// 
        /// Con seleccion:
        /// 1. Muestra el nombre de usuario con le id seleccionado
        /// 2. Verifica si el usuario tiene mascotas registradas. En caso de tenerlas carga sus id en el combobox 'ID Mascota'
        /// En caso de no tener mascotas deshabilita el combobox y muestra un mensaje
        /// </summary>
        private void cbxIdDueno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIdDueno.SelectedIndex == -1)
            {
                //Limpiar controles
                LimpiarMascota();

                //Deshablitar la funcion de editar y crear
                btnEditM.Enabled = false;
                btnNuevoM.Enabled = false;
                btnBorrarMascota.Enabled = false;
            }
            else
            {
                //Deshabilita la funcion de editar porque no habria ninguna mascota seleccionada
                btnEditM.Enabled = false;
                btnBorrarMascota.Enabled = false;
                //habilita la creacion de una nueva mascota
                btnNuevoM.Enabled = true;

                //convierte el id seleccionado del combobox
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
            }
            //si no se esta en el modo de edicion entonces carga los idMascota en el combobox
            if (activarM == false)
            {
                ActualizarRegistrosMascota();
            }
        }

        /// <summary>
        /// Evento de Cambio de Seleccion de Elemento del combobox 'ID Mascota'
        /// Dependiendo de la seleccion del combobox:
        /// 
        /// Sin seleccion: Limpia los controles.
        /// Con seleccion: Muestra la informacion de la mascota seleccionada
        /// </summary>
        private void cbxIdMascotaMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si no se ha seleccionado ninguna opcion se limpian los controles
            if (cbxIdMascotaM.SelectedIndex == -1)
            {
                LimpiarMascota();
            }
            //Dependiendo de la seleccion de idMascota se muestra un nombre
            else
            {
                //si se ha seleccionado una mascota habilita la funcion de editar
                btnEditM.Enabled = true;
                btnBorrarMascota.Enabled = true;

                //guarda el texto de la seleccion en ConsultaIdMascota
                string ConsultaIdMascota = cbxIdMascotaM.SelectedItem.ToString();

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

        /// <summary>
        /// Metodo que carga y actualiza los idUsuario en el combobox al abrir el panel, guardar nueva mascota o editar
        /// </summary>
        private void ActualizarRegistrosDueno()
        {
            //Limpia los elementos del comboBox ID Usuario
            cbxIdUsuario.Items.Clear();

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
                                cbxIdDueno.Items.Add(reader["idUsuario"].ToString());
                            }
                        }
                    }
                }
            }
            catch
            {
                //Si no puede conectar mostrar mensaje de error
                MessageBox.Show("Error de conexion a la base de datos", "Error :(");

                //Cerrar menu de administracion de usuarios
                panelMascotas.Visible = false;
                panelBtnMascota.Visible = false;
            }
        }

        /// <summary>
        /// Metodo que actualiza los idMascota en caso de agregar nueva mascota o editarla
        /// </summary>
        private void ActualizarRegistrosMascota()
        {
            //convierte el id seleccionado del combobox
            string IdSeleccion = cbxIdDueno.SelectedItem.ToString();

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
                            //Limpiar los controles por si habia un registro cargado
                            LimpiarMascota();

                            //Si se encuentran mascotas registradas mostrar los idMascota en cbxidMascota
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //Cargar los idMascota en el comboBox
                                    cbxIdMascotaM.Items.Add(reader["idMascota"].ToString());
                                }
                                //habilitar el comboBox
                                cbxIdMascotaM.Enabled = true;
                            }
                            else
                            {
                                //Si no hay mascotas se deshabilita el comboBox y se muestra un mensaje
                                cbxIdMascotaM.Text = "No se encontraron mascotas";
                                btnEditM.Enabled = false;
                                btnBorrarMascota.Enabled = false;
                                cbxIdMascotaM.Enabled = false;
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

        /// <summary>
        /// Metodo de limpieza de los controles del panel de la informacion de la mascota
        /// </summary
        private void LimpiarMascota()
        {
            //limpia los controles
            cbxIdMascotaM.Text = null;
            cbxIdMascotaM.Items.Clear();
            txtNombreMascotaM.Text = null;
            txtRazaM.Text = null;
            txtEspecieM.Text = null;
            txtSexoM.Text = null;

            //Como DateTimePicker no tiene un valor vacio se coloca la fecha de hoy
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        /// <summary>
        /// Metodo que habilita la edicion de los controles. Primero deshabilita el cambio de seleccion del combobox 'ID Mascota'
        /// para evitar la edicion de un registro incorrecto y evitar que se inserte un ID al crear una nueva mascota
        /// 
        /// Recibe el parametro booleano 'habilitar' que decide si se va a usar el metodo para habilitar
        /// o deshabilitar los controles segun el valor true o false
        /// 
        /// Habilita/deshabilita los controles de informacion de mascota
        /// Habilita/deshabilita la edicion de informacion de los controles
        /// </summary>
        /// <param name="habilitar"></param>
        private void HabilitarEdicionM(bool habilitar)
        {
            //Desahabilta ID Mascota
            cbxIdMascotaM.Enabled = !habilitar;

            //Habilita los controles
            txtUsuario.Enabled = habilitar;
            txtNombreMascotaM.Enabled = habilitar;
            txtEspecieM.Enabled = habilitar;
            txtRazaM.Enabled = habilitar;
            txtSexoM.Enabled = habilitar;
            dtpFechaNacimiento.Enabled = habilitar;

            //Permite la edicion del contenido de los controles
            txtUsuario.ReadOnly = !habilitar;
            txtNombreMascotaM.ReadOnly = !habilitar;
            txtEspecieM.ReadOnly = !habilitar;
            txtRazaM.ReadOnly = !habilitar;
            txtSexoM.ReadOnly = !habilitar;
        }

        /// <summary>
        /// Metodo que inserta un registro de nueva mascota con la informacion de los controles
        /// </summary>
        private void NuevaMascota()
        {
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                //Consulta sql para insertar una nueva mascota
                string query = @"INSERT INTO mascotas (Nombre, FechaNacimiento, Especie, Raza, Sexo, idUsuario)
                     VALUES (@Nombre, @FechaNacimiento, @Especie, @Raza, @Sexo, @idUsuario);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //Intenta asignar los valores de los controles a los parámetros sql
                    try
                    {
                        //si los campos estan vacios mostrar mensaje de error
                        if (string.IsNullOrEmpty(txtNombreMascotaM.Text) || string.IsNullOrEmpty(txtRazaM.Text) || string.IsNullOrEmpty(txtEspecieM.Text) || string.IsNullOrEmpty(txtSexoM.Text))
                        {
                            MessageBox.Show("Por favor llene los campos", "Error", MessageBoxButtons.OK);
                            return;
                        }
                        //si no hay errores en los datos asignar los parametros con los datos del form
                        else
                        {
                            command.Parameters.AddWithValue("@Nombre", txtNombreMascotaM.Text);
                            command.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                            command.Parameters.AddWithValue("@Especie", txtEspecieM.Text);
                            command.Parameters.AddWithValue("@Raza", txtRazaM.Text);
                            command.Parameters.AddWithValue("@Sexo", txtSexoM.Text);
                            command.Parameters.AddWithValue("@idUsuario", cbxIdDueno.SelectedItem.ToString());
                        }
                    }
                    //si se produce otro error
                    catch (Exception error)
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
                            //Se deshabilita la edicion para evitar ingresar la misma mascota nuevamente por accidente
                            HabilitarEdicion(false);

                            MessageBox.Show("Nueva mascota registrada ♡", "Operacion exitosa!");

                            //Se actualizan los registros
                            ActualizarRegistrosDueno();
                            ActualizarRegistrosMascota();

                            //Se limpian los campos y se deshabilta el boton cancelar
                            btnCancelarM_Click(this, EventArgs.Empty);
                        }
                        //Si no se cambio ninguna fila mostrar mensaje de error
                        else
                        {
                            MessageBox.Show("Error al ingresar mascota.", "Error :(");
                        }

                        //Si no puede hacer el registro mostrar mensaje de error
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar los datos: " + ex.Message, "Error :(");
                    }
                }
            }
        }

        /// <summary>
        /// Metodo que actualiza el registro de una mascota con la informacion de los controles
        /// </summary>
        private void GuardarMascota()
        {
            //Consulta sql para actualizar los datos de la mascota
            string query = @"UPDATE mascotas 
                     SET Nombre = @Nombre, 
                         FechaNacimiento= @FechaNacimiento, 
                         Especie = @Especie,
                         Raza = @Raza, 
                         Sexo = @Sexo, 
                         idUsuario = @idUsuario
                     WHERE idMascota = @idMascota;";
            //WHERE indica en que registro se hara la actualizacion

            //Realizar la actualización en la base de datos
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        //si los campos estan vacios mostrar mensaje de error
                        if (string.IsNullOrEmpty(txtNombreMascotaM.Text) || string.IsNullOrEmpty(txtRazaM.Text) || string.IsNullOrEmpty(txtEspecieM.Text) || string.IsNullOrEmpty(txtSexoM.Text))
                        {
                            MessageBox.Show("Por favor llene los campos", "Error", MessageBoxButtons.OK);
                            return;
                        }
                        //si no hay errores en los datos asignar los parametros con los datos del form
                        else
                        {
                            command.Parameters.AddWithValue("@idMascota", cbxIdMascotaM.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Nombre", txtNombreMascotaM.Text);
                            command.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                            command.Parameters.AddWithValue("@Especie", txtEspecieM.Text);
                            command.Parameters.AddWithValue("@Raza", txtRazaM.Text);
                            command.Parameters.AddWithValue("@Sexo", txtSexoM.Text);
                            command.Parameters.AddWithValue("@idUsuario", cbxIdDueno.SelectedItem.ToString());
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

                        //Comprobar si la actualizacion fue exitosa, si rowsAffected es mayor que 0 significa que al menos una fila fue cambiada
                        if (rowsAffected > 0)
                        {
                            //Se deshabilita la edicion para evitar editar la misma mascota nuevamente por accidente
                            HabilitarEdicion(false);

                            MessageBox.Show("Informacion actualizada ♡", "Operacion exitosa!");

                            //se limpian los campos y se deshabilita el boton cancelar
                            btnCancelarM_Click(this, EventArgs.Empty);
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

        /// <summary>
        /// Evento del boton borrar que borra el registro de la mascota seleccionada
        /// </summary>
        private void btnBorrarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM mascotas WHERE idMascota = @idMascota";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Parámetro para identificar al usuario que se va a eliminar
                        command.Parameters.AddWithValue("@idMascota", cbxIdMascotaM.SelectedItem.ToString());

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        // Validar si la eliminación fue exitosa
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mascota eliminada correctamente.");
                            cbxIdUsuario.SelectedIndex = -1;
                            ActualizarRegistrosMascota();
                            btnCancelarM_Click(this, EventArgs.Empty);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar " + ex.Message, "Error", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
