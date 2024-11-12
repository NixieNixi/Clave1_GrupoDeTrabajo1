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
    public partial class CitaMascota : Form
    {
        private int IdUsuario;
        private bool esNuevaCita; // Variable para identificar si es nueva cita

        public CitaMascota(int idUsuario)
        {
            InitializeComponent();
            IdUsuario = idUsuario;
            ActualizarMascotas();
            DeshabilitarEdicion();
        }

        // Método para actualizar las mascotas del usuario
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
                            while (reader.Read())
                            {
                                cbxIDMascD.Items.Add(reader["idMascota"].ToString());
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

        // Deshabilitar campos para la edición
        private void DeshabilitarEdicion()
        {
            txtMotCiD.Enabled = false;
            txtEsCiD.Enabled = false;
            dtpCitaFecha.Enabled = false;
            dtpCitaHora.Enabled = false;
            btnGuardarCita.Enabled = false;
        }

        // Habilitar campos para la edición
        private void HabilitarEdicion()
        {
            txtMotCiD.Enabled = true;
            txtEsCiD.Enabled = true;
            dtpCitaFecha.Enabled = true;
            dtpCitaHora.Enabled = true;
            btnGuardarCita.Enabled = true;
        }

        // Cargar detalles de la cita seleccionada
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
                                dtpCitaFecha.Value = (DateTime)reader["Fecha"];
                                dtpCitaHora.Value = new DateTime(2023, 05, 05).Add((TimeSpan)reader["Hora"]);
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


        private void CargarCitas(int idMascota)
        {
            cbxIDCitaD.Items.Clear(); // Limpiar el ComboBox antes de agregar nuevos ítems
            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    string query = "SELECT idCita FROM Citas WHERE idMascota = @idMascota ORDER BY idCita ASC;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idMascota", idMascota); // Usamos el idMascota recibido
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Verificamos si la consulta devuelve registros
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    cbxIDCitaD.Items.Add(reader["idCita"].ToString()); // Agregar los idCita al ComboBox
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron citas para esta mascota.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error :(");
            }
        }


        // Evento de cambio en el ComboBox de citas
        private void cbxIDCitaD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIDMascD.SelectedItem != null)
            {
                int idMascotaSeleccionada = int.Parse(cbxIDMascD.SelectedItem.ToString());
                CargarCitas(idMascotaSeleccionada); // Cargar las citas de la mascota seleccionada
            }
        }

        // Botón para programar una nueva cita
        private void btnProgramarCitaD_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarEdicion();
            esNuevaCita = true; // Nueva cita
        }

        // Botón para reprogramar una cita existente
        private void btnReprogramarCitaD_Click(object sender, EventArgs e)
        {
            if (cbxIDCitaD.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una cita para reprogramar.");
                return;
            }
            HabilitarEdicion();
            esNuevaCita = false; // Reprogramar cita existente
        }

        // Guardar nueva cita o reprogramar una cita existente
        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMotCiD.Text) || string.IsNullOrEmpty(txtEsCiD.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    string query;
                    if (esNuevaCita) // Si es nueva cita
                    {
                        query = "INSERT INTO Citas (Fecha, Hora, Motivo, Estado, idMascota) VALUES (@Fecha, @Hora, @Motivo, @Estado, @idMascota);";
                    }
                    else // Si es reprogramación de una cita existente
                    {
                        query = "UPDATE Citas SET Fecha = @Fecha, Hora = @Hora, Motivo = @Motivo, Estado = @Estado WHERE idCita = @idCita;";
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Fecha", dtpCitaFecha.Value.Date);
                        command.Parameters.AddWithValue("@Hora", dtpCitaHora.Value.TimeOfDay);
                        command.Parameters.AddWithValue("@Motivo", txtMotCiD.Text);
                        command.Parameters.AddWithValue("@Estado", txtEsCiD.Text);
                        command.Parameters.AddWithValue("@idMascota", cbxIDMascD.SelectedItem);
                        if (!esNuevaCita) // Solo si es reprogramación, agregar idCita
                        {
                            command.Parameters.AddWithValue("@idCita", int.Parse(cbxIDCitaD.SelectedItem.ToString()));
                        }

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Cita guardada exitosamente.");
                            DeshabilitarEdicion();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar la cita.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a Base de Datos: " + ex.Message, "Error :(");
            }
        }

        // Botón de cancelar edición
        private void btnCancelarEdicionCita_Click(object sender, EventArgs e)
        {
            DeshabilitarEdicion();
            LimpiarCampos();
        }

        // Limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtMotCiD.Text = "";
            txtEsCiD.Text = "";
            dtpCitaFecha.Value = DateTime.Now;
            dtpCitaHora.Value = DateTime.Now;
        }

        private void btnEditarCita_Click(object sender, EventArgs e)
        {

        }
    }
}
