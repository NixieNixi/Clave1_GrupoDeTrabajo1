using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    public partial class AdministradorPerfil
    {
        bool activarC = false;

        //Metodo para mostrar el panel de citas
        private void btnCitas_Click(object sender, EventArgs e)
        {
            //Se oculta el resto de los paneles
            panelMascotas.Visible = false;
            panelMascotas.Dock = DockStyle.None;
            panelBtnMascota.Visible = false;
            panelBtnMascota.Dock = DockStyle.None;
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
            panelBtnUsuarios.Visible = false;
            panelBtnUsuarios.Dock = DockStyle.None;

            //Se muestran los paneles de Usuario
            panelBtnCitas.Dock = DockStyle.Bottom;
            panelBtnCitas.Visible = true;
            panelCitas.Dock = DockStyle.Fill;
            panelCitas.Visible = true;

            ActualizarMascotas();
        }


        private void cbxIdMascotaC_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxIdMascotaC.SelectedIndex == -1)
            {
                cbxIdCita.Enabled = false;
            }
            else
            {
                cbxIdCita.Enabled = true;
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

            if (activarC == false)
            {
                ActualizarCitas();
            }
        }

        private void cbxIdCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si no se ha seleccionado ninguna opcion se limpian los controles
            if (cbxIdCita.SelectedIndex == -1)
            {
                LimpiarCita();
                btnReprogramar.Enabled = false;
            }
            //Dependiendo de la seleccion de idMascota se muestra un nombre
            else
            {
                btnReprogramar.Enabled = true;
                //guarda el texto de la seleccion en ConsultaIdMascota
                string ConsultaIdMascota = cbxIdCita.SelectedItem.ToString();

                //Intentar conectar a DB y hacer la consulta del nombre de la mascota
                try
                {
                    //cadena de conexion a DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta a DB
                        string query = "SELECT Estado, Fecha, Hora, Motivo FROM citas WHERE idCita = @idCita;";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            //Agregar el parametro a la consulta
                            command.Parameters.AddWithValue("@idCita", ConsultaIdMascota);

                            //Conectar a DB
                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                //Inserta la informacion en los controles correspondientes
                                if (reader.Read())
                                {
                                    cbxEstado.Text = reader["Estado"].ToString();
                                    dtpFecha.Value = (DateTime)reader["Fecha"];
                                    TimeSpan horaDB = (TimeSpan)reader["Hora"];
                                    DateTime hora = new DateTime(2020, 3, 25).Add(horaDB);
                                    dtpHora.Value = hora;
                                    txtMotivo.Text = reader["Motivo"].ToString();
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

        private void btnNueva_Click(object sender, EventArgs e)
        {
            btnGuardarC.Enabled = true;
            btnDeshacer.Enabled = true;
            btnReprogramar.Enabled = false;
            cbxEstado.SelectedIndex = 0;

            LimpiarCita();
            dtpFecha.MinDate = DateTime.Today.AddDays(1);
            activarC = true;
            HabilitarEdicionC(true);
        }

        private void btnReprogramar_Click(object sender, EventArgs e)
        {
            //habilitar botones
            btnDeshacer.Enabled = true;
            btnGuardarC.Enabled = true;
            //deshabilitar boton nuevo
            btnNueva.Enabled = false;

            //activar modo de edicion
            activarC = true;
            HabilitarEdicionC(true);
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            if(cbxIdCita.SelectedIndex == -1)
            {
                NuevaCita();
            }
            else
            {
                ReprogramarCita();
            }
        }

        private void ActualizarMascotas()
        {
            //Limpia los elementos del comboBox ID Usuario
            cbxIdMascotaC.Items.Clear();

            //Intentar conectar a DB
            try
            {
                //Crea una conexion a la DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //Consulta la columna idUsuarios de la tabla Usuarios
                    string query = "SELECT idMascota FROM mascotas ORDER BY idMascota ASC;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Inserta los registros de idUsuario en el comboBox cbxUsuario
                                cbxIdMascotaC.Items.Add(reader["idMascota"].ToString());
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
                panelCitas.Visible = false;
                panelBtnCitas.Visible = false;
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            //Se reestablece el limite para el control
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

        private void ActualizarCitas()
        {
            //convierte el id seleccionado del combobox
            string IdSeleccion = cbxIdMascotaC.SelectedItem.ToString();

            try
            {
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
                            //Si se encuentran mascotas registradas mostrar los idMascota en cbxidMascota
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //Cargar los idMascota en el comboBox
                                    cbxIdCita.Items.Add(reader["idCita"].ToString());
                                }
                                //habilitar el comboBox
                                cbxIdMascotaC.Enabled = true;
                            }
                            else
                            {
                                //Si no hay mascotas se deshabilita el comboBox y se muestra un mensaje
                                cbxIdCita.Text = "No se encontraron citas";
                                cbxIdCita.Enabled = false;
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

        private void LimpiarCita()
        {
            cbxIdCita.Text = null;
            cbxIdCita.Items.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpFecha.MinDate = Convert.ToDateTime("01/01/1753");
            dtpHora.Value = DateTime.Now;
            txtMotivo.Text = null;
        }

        private void HabilitarEdicionC(bool habilitar)
        {
            cbxIdCita.Enabled = !habilitar;

            txtMotivo.Enabled = habilitar;
            dtpFecha.Enabled = habilitar;
            dtpHora.Enabled = habilitar;

            txtMotivo.ReadOnly = !habilitar;
        }

        private void ReprogramarCita()
        {
            dtpFecha.MinDate = DateTime.Today.AddDays(1);
            //Consulta sql para actualizar los datos de la mascota
            string query = @"UPDATE citas 
                     SET Fecha = @Fecha, 
                         Hora= @Hora, 
                         Motivo= @Motivo
                     WHERE idCita = @idCita;";
                //WHERE indica en que registro se hara la actualizacion

                //Realizar la actualización en la base de datos
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        try
                        {
                        TimeSpan horaIngresada = dtpHora.Value.TimeOfDay;
                        TimeSpan cierre = new TimeSpan(8, 0, 0);
                        TimeSpan abrir = new TimeSpan(16, 0, 0);

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

                                MessageBox.Show("Informacion actualizada ♡", "Operacion exitosa!");

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

        private void NuevaCita()
        {
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
                        TimeSpan horaIngresada = dtpHora.Value.TimeOfDay;
                        TimeSpan cierre = new TimeSpan(8,0,0);
                        TimeSpan abrir = new TimeSpan(16, 0, 0);

                        //si los campos estan vacios mostrar mensaje de error
                        if (string.IsNullOrEmpty(txtMotivo.Text))
                        {
                            MessageBox.Show("Ingrese un motivo para la cita", "Error", MessageBoxButtons.OK);
                        }
                        else if(horaIngresada > abrir || horaIngresada < cierre)
                        {
                            MessageBox.Show("ingrese una hora valida entre\n8:00 a.m. y 4:00 p.m.", "Error", MessageBoxButtons.OK);
                        }
                        //si no hay errores en los datos asignar los parametros con los datos del form
                        else
                        {
                            command.Parameters.AddWithValue("@idMascota", cbxIdMascotaC.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Estado", cbxEstado.SelectedItem.ToString());
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
                            //Se deshabilita la edicion para evitar ingresar la misma mascota nuevamente por accidente
                            HabilitarEdicionC(false);

                            MessageBox.Show("Cita programada, por favor sea puntual", "Operacion exitosa!");

                            //Se limpian los campos y se deshabilta el boton deshacer
                            btnDeshacer_Click(this, EventArgs.Empty);

                            //Se actualizan los registros
                            ActualizarCitas();
                            ActualizarMascotas();
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
    }
}
