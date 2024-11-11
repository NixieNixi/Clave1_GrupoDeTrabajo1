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
    /// Autor: NixieNixi
    /// Descripcion: 
    /// Este formulario permite al dueño gestionar la información de sus mascotas y citas.
    /// </summary>
    public partial class CitaMascota : Form
    {
        private int IdUsuario;

        public CitaMascota(int idUsuario)
        {
            InitializeComponent();
            IdUsuario = idUsuario;
            ActualizarMascotas();

            // Deshabilitar controles de entrada de cita inicialmente
            txtMotCiD.Enabled = false;
            txtEsCiD.Enabled = false;
            dtpCitaFecha.Enabled = false;
            dtpCitaHora.Enabled = false;
        }

        // Método para actualizar las mascotas del usuario en el ComboBox
        private void ActualizarMascotas()
        {
            cbxIDMascD.Items.Clear();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    string query = "SELECT idMascota FROM mascotas WHERE idUsuario = @idUsuario ORDER BY idMascota ASC;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idUsuario", IdUsuario);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            bool hasData = false;
                            while (reader.Read())
                            {
                                cbxIDMascD.Items.Add(reader["idMascota"].ToString());
                                hasData = true;
                            }
                            if (!hasData)
                            {
                                MessageBox.Show("No se encontraron mascotas para este usuario.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a Base de Datos: " + ex.Message, "Error :(");
            }
        }

        // Método para actualizar los IDs de citas de una mascota
        private void ActualizarCitasDeMascota(int idMascota)
        {
            cbxIDCitaD.Items.Clear();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    string query = "SELECT idCita FROM Citas WHERE idMascota = @idMascota ORDER BY idCita ASC;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idMascota", idMascota);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            bool hasData = false;
                            while (reader.Read())
                            {
                                cbxIDCitaD.Items.Add(reader["idCita"].ToString());
                                hasData = true;
                            }
                            if (!hasData)
                            {
                                MessageBox.Show("No se encontraron citas para la mascota seleccionada.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a Base de Datos: " + ex.Message, "Error :(");
            }
        }

        // Método para cargar detalles de la cita seleccionada
        private void CargarDetallesCita(int idCita)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    string query = "SELECT Motivo, Estado, Fecha, Hora FROM Citas WHERE idCita = @idCita;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idCita", idCita);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMotCiD.Text = reader["Motivo"].ToString();
                                txtEsCiD.Text = reader["Estado"].ToString();

                                DateTime fecha = (DateTime)reader["Fecha"];
                                dtpCitaFecha.Value = fecha;

                                TimeSpan horaDB = (TimeSpan)reader["Hora"];
                                DateTime hora = new DateTime(2023, 05, 05).Add(horaDB);
                                dtpCitaHora.Value = hora;
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron detalles para la cita seleccionada.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a Base de Datos: " + ex.Message, "Error :(");
            }
        }

        // Eventos de selección de ComboBox para cargar datos de mascotas y citas
        private void cbxIDMascD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIDMascD.SelectedItem != null)
            {
                int idMascotaSeleccionada = int.Parse(cbxIDMascD.SelectedItem.ToString());
                ActualizarCitasDeMascota(idMascotaSeleccionada);
            }
        }

        private void cbxIDCitaD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIDCitaD.SelectedItem != null)
            {
                int idCitaSeleccionada = int.Parse(cbxIDCitaD.SelectedItem.ToString());
                CargarDetallesCita(idCitaSeleccionada);
            }
        }

        // Programación y reprogramación de citas
        private void btnProgramarCitaD_Click(object sender, EventArgs e)
        {
            txtMotCiD.Enabled = true;
            txtEsCiD.Enabled = true;
            dtpCitaFecha.Enabled = true;
            dtpCitaHora.Enabled = true;

            if (cbxIDMascD.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una mascota para programar una cita.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    string query = "INSERT INTO Citas (idMascota, Motivo, Estado, Fecha, Hora) VALUES (@idMascota, @Motivo, @Estado, @Fecha, @Hora);";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idMascota", int.Parse(cbxIDMascD.SelectedItem.ToString()));
                        command.Parameters.AddWithValue("@Motivo", txtMotCiD.Text);
                        command.Parameters.AddWithValue("@Estado", txtEsCiD.Text);
                        command.Parameters.AddWithValue("@Fecha", dtpCitaFecha.Value.Date);
                        command.Parameters.AddWithValue("@Hora", dtpCitaHora.Value.TimeOfDay);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Cita programada exitosamente.");
                            ActualizarCitasDeMascota(int.Parse(cbxIDMascD.SelectedItem.ToString()));
                        }
                        else
                        {
                            MessageBox.Show("No se pudo programar la cita.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a Base de Datos: " + ex.Message, "Error :(");
            }
        }

        private void btnCancelarEdicionCita_Click(object sender, EventArgs e)
        {
            txtMotCiD.Enabled = false;
            txtEsCiD.Enabled = false;
            dtpCitaFecha.Enabled = false;
            dtpCitaHora.Enabled = false;
        }
    }
}

