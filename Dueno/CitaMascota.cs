using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Clave1_GrupoDeTrabajo1.Interfaz;
using Clave1_GrupoDeTrabajo1.Clases;
using Clave1_GrupoDeTrabajo1.Administrador;


namespace Clave1_GrupoDeTrabajo1.Interfaz
{

    /// <summary>
    /// Autores: NixieNixi y CanelaFeliz
    /// Descripcion: 
    /// Este form a sido creado para la parte del dueño, donde podra manejar la inforacion de sus mascotas y sus citas.
    /// 
    /// </summary>
    public partial class CitaMascota : Form
    {
        private int IdUsuario;
        
        public void RecibirInfoUser(int idUsuario)
        {
            IdUsuario = idUsuario;
            lblidUsuario.Text = Usuario.IdUsuario.ToString();
            lblNombreUsuario.Text = Usuario.Nombre.ToString();
        }

        public CitaMascota(int idUsuario)
        {
            InitializeComponent();
            IdUsuario = idUsuario;
            ActualizarMascotas();
        }

        /// <summary>
        /// campo que permite activar o desactivar la actualizacion y limpieza de registros de Citas
        /// </summary>
        bool activarC = false;


        /// <summary>
        /// Este boton solo se activa si hay una mascota seleccionada
        /// Evento del boton Nueva que permite programar una nueva cita
        /// Habilita los botones de guardar y deshacer, limpia y ajusta los controles para ingresar los datos de la cita
        /// </summary>
        private void btnNueva_Click(object sender, EventArgs e)
        {
            //Activa botones de guardar y deshacer
            btnGuardarC.Enabled = true;
            btnDeshacer.Enabled = true;
            //Selecciona en el combobox Estado la opcion "Programada"
            cbxEstado.SelectedIndex = 0;
            //Deshabilita botones de reprogramar, cancelar y nueva cita
            btnReprogramar.Enabled = false;
            btnCancelarC.Enabled = false;
            btnNueva.Enabled = false;
            //Limpia los controles de informacion
            LimpiarCita();
            //Limita el la fecha minima al dia de mañana
            dtpFecha.MinDate = DateTime.Today.AddDays(1);
            //habilita el modo de edicion
            activarC = true;
            HabilitarEdicionC(true);
        }

        /// <summary>
        /// Este boton solo se activa si hay una mascota y cita seleccionada
        /// Evento del boton Reporgramar que permite editar la informacion de fecha y hora de la cita
        /// Habilita los botones de guardar y deshacer, ajusta el control de Fecha
        /// </summary>
        private void btnReprogramar_Click(object sender, EventArgs e)
        {
            //habilitar botones
            btnDeshacer.Enabled = true;
            btnGuardarC.Enabled = true;
            //deshabilitar botones de nueva nueva cita, cancelar y reprogramar 
            btnNueva.Enabled = false;
            btnCancelarC.Enabled = false;
            btnReprogramar.Enabled = false;
            //Limita el la fecha minima al dia de mañana
            dtpFecha.MinDate = DateTime.Today.AddDays(1);

            //activar modo de edicion
            activarC = true;
            HabilitarEdicionC(true);
        }

        /// <summary>
        /// Este boton solo se activa si hay una mascota y cita seleccionada
        /// Evento del boton Cancelar que permite cancelar una cita
        /// Habilita los botones de guardar y deshacer, cambia la seleccion de Estado a Cancelar y deshabilita el resto de controles
        /// Importante: Despues de guardar los cambios de una cita no se puede volver a editar
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Activa botones de guardar y deshacer
            btnGuardarC.Enabled = true;
            btnDeshacer.Enabled = true;
            //Selecciona en el combobox Estado la opcion "Cancelada"
            cbxEstado.SelectedIndex = 1;
            //Deshabilita botones de reprogramar, nueva cita y cancelar
            btnReprogramar.Enabled = false;
            btnNueva.Enabled = false;
            btnCancelarC.Enabled = false;
            //Deshabilita los combobox de idMascota e idCita
            cbxIdCita.Enabled = false;
            cbxIdMascotaC.Enabled = false;
        }

        /// <summary>
        /// Este boton solo se activa si se ha activado la funcion Nueva, Reprogramar o Cancelar
        /// Evento del boton Guardar que dependiendo de la seleccion en el combobox idCita permite crear un nuevo registro de cita o modificarlo
        /// </summary>
        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            //Si no hay cita seleccionada crea una nueva
            if (cbxIdCita.SelectedIndex == -1)
            {
                NuevaCita();
            }
            //Edita la cita seleccionada
            else
            {
                EditarCita();
            }
        }

        /// <summary>
        /// Evento del boton Deshacer que permite volver el registro a un estado anterior a la edicion 
        /// </summary>
        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            //Se reestablece el limite para el control de fecha para poder mostrar el fechas anteriores de citas canceladas o finalizadas
            dtpFecha.MinDate = Convert.ToDateTime("01/01/1753");

            //Deshabilita el boton de guardar
            btnGuardarC.Enabled = false;
            //habilita el boton de nuevo
            btnNueva.Enabled = true;

            //deshabilita el estado de edicion
            activarC = false;
            HabilitarEdicionC(false);

            //vuelve a cargar los idUsuario y los idMasctoa en sus combobox 
            cbxIdMascotaC_SelectedIndexChanged(this, EventArgs.Empty);

            //desactiva el boton de cancelar
            btnDeshacer.Enabled = false;
        }

        /// <summary>
        /// Evento de cambio de seleccion del combobox ID Mascota que permite cargar el nombre de la mascota
        /// y actualizar los idCita segun la mascota seleccionada
        /// </summary>
        private void cbxIdMascotaC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si no hay mascota seleccionada deshabilta el cambio de idCita porque no habria ninguna cita cargada
            if (cbxIdMascotaC.SelectedIndex == -1)
            {
                cbxIdCita.Enabled = false;
            }
            //Si se selecciona una mascota se habilita en boton Nueva y el combobox ID Cita
            else
            {
                //Habilitar para consultar las citas de la mascota elegida
                cbxIdCita.Enabled = true;
                //Para nueva cita
                btnNueva.Enabled = true;

                //convierte el id seleccionado del combobox
                string IdSeleccion = cbxIdMascotaC.SelectedItem.ToString();

                try
                {
                    //cadena de conexion DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta DB
                        string query = "SELECT Nombre FROM Mascotas WHERE idMascota = @idMascota;";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            //Agregar el parametro a la consulta
                            command.Parameters.AddWithValue("@idMascota", IdSeleccion);

                            //Establecer conexion a DB
                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                //cargar nombre de la mascota
                                if (reader.Read())
                                {
                                    txtNombreMascotaC.Text = reader["Nombre"].ToString();
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
            //Dependiendo del modo de edicion actualiza los idCita en el combobox
            if (activarC == false)
            {
                ActualizarCitas();
            }
        }

        /// <summary>
        /// Evento de cambio de seleccion del combobox ID Cita que permite cargar la informacion de la cita seleccionada
        /// </summary>
        private void cbxIdCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si no se ha seleccionado ninguna cita se limpian los controles
            if (cbxIdCita.SelectedIndex == -1)
            {
                LimpiarCita();
                btnReprogramar.Enabled = false;
                btnCancelarC.Enabled = false;
            }
            //Dependiendo de la seleccion de idCita se muestra la informacion
            else
            {
                //Intentar conectar a DB y hacer la consulta del nombre de la mascota
                try
                {
                    //guarda el texto de la seleccion en ConsultaIdCita
                    string ConsultaIdCita = cbxIdCita.SelectedItem.ToString();

                    //cadena de conexion a DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta a DB
                        string query = "SELECT Estado, Fecha, Hora, Motivo FROM citas WHERE idCita = @idCita;";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            //Agregar el parametro a la consulta
                            command.Parameters.AddWithValue("@idCita", ConsultaIdCita);

                            //Conectar a DB
                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                //Inserta la informacion en los controles correspondientes
                                if (reader.Read())
                                {
                                    cbxEstado.Text = reader["Estado"].ToString();
                                    dtpFecha.Value = (DateTime)reader["Fecha"];

                                    //El control DateTimePicker solo acepta valores del tipo DateTime pero la DB contiene valores de tipo Time.
                                    //Pasa solucionar esto se guarda el valor de DB en la variable horaDB
                                    TimeSpan horaDB = (TimeSpan)reader["Hora"];
                                    //Luego se combina el valor de horaDB con una fecha y se guarda en la variable hora
                                    DateTime hora = new DateTime(2023, 05, 05).Add(horaDB);
                                    //Finalmente se agrega la hora al control para mostrar la hora 
                                    dtpHora.Value = hora;
                                    txtMotivo.Text = reader["Motivo"].ToString();
                                }
                            }
                        }
                    }
                    //Si la fecha de la cita es anterior al dia de hoy se muestra como finalizada y no se podra editar
                    if (cbxEstado.Text == "Programada" && dtpFecha.Value < DateTime.Today)
                    {
                        cbxEstado.Text = "Finalizada";

                    }
                    //Si el estado de al cita aparece como cancelads o finalizads no se podra editar
                    else if (cbxEstado.Text == "Cancelada" || cbxEstado.Text == "Finalizada")
                    {
                        btnReprogramar.Enabled = false;
                        btnCancelarC.Enabled = false;
                    }
                    //Si el estado aparece como programada se habilitan los controles para reprogramarla o cancelarla
                    else
                    {
                        btnReprogramar.Enabled = true;
                        btnCancelarC.Enabled = true;
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
        /// Funcion de actualizacion de los idMascota del combobox
        /// </summary>
        private void ActualizarMascotas()
        {
            
            cbxIdMascotaC.Items.Clear(); 

            try
            {
                // Establecer la conexión con la base de datos
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    // Consulta para obtener los idMascota de las mascotas del dueño que inició sesión
                    string query = "SELECT idMascota FROM Mascotas WHERE idUsuario = @idUsuario ORDER BY idMascota ASC;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar el parámetro idDueño con el ID del dueño que ha iniciado sesión
                        command.Parameters.AddWithValue("@idUsuario", IdUsuario); 

                        connection.Open(); // Abrir la conexión

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            bool hasData = false;
                            // Leer cada idMascota y añadirlo al ComboBox
                            while (reader.Read())
                            {
                                cbxIdMascotaC.Items.Add(reader["idMascota"].ToString());
                                hasData = true;
                            }

                            // Si no se encuentran mascotas, mostrar un mensaje
                            if (!hasData)
                            {
                                MessageBox.Show("No se encontraron mascotas para este dueño.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si falla la conexión o la consulta
                MessageBox.Show("Error de conexión a la Base de Datos: " + ex.Message, "Error :(");
            }

        }

        /// <summary>
        /// Funcion de actualizacion de idCita del combobox
        /// </summary>
        private void ActualizarCitas()
        {
            try
            {
                //convierte el id seleccionado del combobox
                string IdSeleccion = cbxIdMascotaC.Text;

                //cadena de conexion DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //cadena de consulta DB
                    string query = "SELECT idCita FROM citas WHERE idMascota = @idMascota";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //Agregar el parametro a la consulta
                        command.Parameters.AddWithValue("@idMascota", IdSeleccion);

                        //Establecer conexion a DB
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            LimpiarCita();
                            //Si se encuentra citas registradas mostrar los idCita en cbxCitas
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //Cargar los idCita en el comboBox
                                    cbxIdCita.Items.Add(reader["idCita"].ToString());
                                }
                                //habilitar el comboBox
                                cbxIdCita.Enabled = true;
                            }
                            else
                            {
                                //Si no hay citass se deshabilita el comboBox y se muestra un mensaje
                                cbxIdCita.Text = "No se encontraron citas";
                                cbxIdCita.Enabled = false;
                                btnReprogramar.Enabled = false;
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
        /// Funcion de limpieza de controles del panel citas
        /// </summary>
        private void LimpiarCita()
        {
            //limpia el texto de los controles
            cbxEstado.Text = null;
            txtMotivo.Text = null;
            cbxIdCita.Text = null;
            //limpia los elementos del combobox ID Cita
            cbxIdCita.Items.Clear();
            //Establece el valor de fecha y hora a las actuales
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            //Reestablece la fecha minima para poder mostrar registros antiguos
            dtpFecha.MinDate = Convert.ToDateTime("01/01/1753");
        }

        /// <summary>
        /// Funcion que habilita o deshabilita la modificacion de la informacion de los controles
        /// </summary>
        private void HabilitarEdicionC(bool habilitar)
        {
            cbxIdMascotaC.Enabled = !habilitar;
            cbxIdCita.Enabled = !habilitar;

            txtMotivo.Enabled = habilitar;
            dtpFecha.Enabled = habilitar;
            dtpHora.Enabled = habilitar;

            txtMotivo.ReadOnly = !habilitar;
        }

        /// <summary>
        /// Funcion que permite modificar un registro de cita
        /// </summary>
        private void EditarCita()
        {
            //Establece la fecha minima para reprogramar cita al dia de mañana
            dtpFecha.MinDate = DateTime.Today.AddDays(1);

            //Consulta sql para actualizar los datos de la cita
            string query = @"UPDATE citas 
                     SET Fecha = @Fecha, 
                         Hora= @Hora, 
                         Motivo= @Motivo,
                         Estado= @Estado
                     WHERE idCita = @idCita;";

            //Realizar la actualización en la base de datos
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {

                        //Establece las horas de apertura y cierre que se usaran como limites
                        TimeSpan horaIngresada = dtpHora.Value.TimeOfDay;
                        TimeSpan cierre = new TimeSpan(8, 0, 0);
                        TimeSpan abrir = new TimeSpan(16, 0, 0);

                        //Verifica que la hora ingresada este en el horario
                        if (horaIngresada > abrir || horaIngresada < cierre)
                        {
                            MessageBox.Show("ingrese una hora valida entre\n8:00 a.m. y 4:00 p.m.", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("idCita", cbxIdCita.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);
                            command.Parameters.AddWithValue("@Hora", dtpHora.Value.TimeOfDay);
                            command.Parameters.AddWithValue("@Motivo", txtMotivo.Text);
                            command.Parameters.AddWithValue("@Estado", cbxEstado.SelectedItem.ToString());
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
                            HabilitarEdicionC(false);

                            MessageBox.Show("Informacion actualizada", "Operacion exitosa!");

                            //Se limpian los campos y se deshabilta el boton deshacer
                            btnDeshacer_Click(this, EventArgs.Empty);
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
        /// Funcion que permite crear un registro de nueva cita
        /// </summary>
        private void NuevaCita()
        {
            //establece la fecha minima para programar la cita a mañana
            dtpFecha.MinDate = DateTime.Today.AddDays(1);

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                //Consulta sql para insertar una nueva mascota
                string query = @"INSERT INTO citas (idMascota, Estado, Fecha, Hora, Motivo)
                     VALUES (@idMascota, @Estado, @Fecha, @Hora, @Motivo);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //Intenta asignar los valores de los controles a los parámetros sql
                    try
                    {
                        //establece las horas de apertura y cierre
                        TimeSpan horaIngresada = dtpHora.Value.TimeOfDay;
                        TimeSpan cierre = new TimeSpan(8, 0, 0);
                        TimeSpan abrir = new TimeSpan(16, 0, 0);

                        //si el motivo esta vacio mostrar mensaje de error
                        if (string.IsNullOrEmpty(txtMotivo.Text))
                        {
                            MessageBox.Show("Ingrese un motivo para la cita", "Error", MessageBoxButtons.OK);
                            return;
                        }
                        //si la hora esta fuera del horario de antencion mostrar un mensaje
                        else if (horaIngresada > abrir || horaIngresada < cierre)
                        {
                            MessageBox.Show("ingrese una hora valida entre\n8:00 a.m. y 4:00 p.m.", "Error", MessageBoxButtons.OK);
                            return;
                        }
                        //si no hay errores en los datos asignar los parametros con los datos del form
                        else
                        {
                            command.Parameters.AddWithValue("@idMascota", cbxIdMascotaC.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Estado", "Programada");
                            command.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);
                            command.Parameters.AddWithValue("@Hora", dtpHora.Value.TimeOfDay);
                            command.Parameters.AddWithValue("@Motivo", txtMotivo.Text);
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
                            //Se deshabilita la edicion
                            HabilitarEdicionC(false);

                            MessageBox.Show("Cita programada, por favor sea puntual", "Operacion exitosa!");

                            //Se limpian los campos y se deshabilta el boton deshacer
                            btnDeshacer_Click(this, EventArgs.Empty);

                            //Se actualizan los registros
                            ActualizarMascotas();
                            ActualizarCitas();
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

        private void btnVolverMenuDuenu_Click(object sender, EventArgs e)
        {
            PerfilDueno perfil = new PerfilDueno();
            perfil.Show();
            this.Close();
        }
    }

}
