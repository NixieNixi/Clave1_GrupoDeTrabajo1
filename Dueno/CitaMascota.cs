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

            // Deshabilitar campos de edición al iniciar
            DeshabilitarEdicion();
        }

        // Método para deshabilitar campos de edición
        private void DeshabilitarEdicion()
        {
            txtMotCiD.Enabled = false;
            txtEsCiD.Enabled = false;
            dtpCitaFecha.Enabled = false;
            dtpCitaHora.Enabled = false;
            btnGuardarCita.Enabled = false; // Solo se habilitará al editar
        }

        // Método para habilitar campos de edición
        private void HabilitarEdicion()
        {
            txtMotCiD.Enabled = true;
            txtEsCiD.Enabled = true;
            dtpCitaFecha.Enabled = true;
            dtpCitaHora.Enabled = true;
            btnGuardarCita.Enabled = true;
        }

        // Método para actualizar el ComboBox de mascotas del usuario específico
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

        // Método para cargar los detalles de la cita seleccionada
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

        private void cbxIDCitaD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIDCitaD.SelectedItem != null)
            {
                int idCitaSeleccionada = int.Parse(cbxIDCitaD.SelectedItem.ToString());
                CargarDetallesCita(idCitaSeleccionada);
                DeshabilitarEdicion(); // Asegurarse de que los campos están bloqueados al cargar
            }
        }

        private void btnEditarCita_Click(object sender, EventArgs e)
        {
            if (cbxIDCitaD.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una cita para editar.");
                return;
            }
            HabilitarEdicion(); // Habilitar los campos para edición
        }

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

                    if (cbxIDCitaD.SelectedItem == null) // Si no se ha seleccionado una cita, es una nueva cita
                    {
                        query = "INSERT INTO Citas (Fecha, Hora, Motivo, Estado, idMascota) VALUES (@Fecha, @Hora, @Motivo, @Estado, @idMascota);";
                    }
                    else // Si hay cita seleccionada, es una reprogramación
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
                        if (cbxIDCitaD.SelectedItem != null)
                            command.Parameters.AddWithValue("@idCita", int.Parse(cbxIDCitaD.SelectedItem.ToString()));

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Cita guardada exitosamente.");
                            DeshabilitarEdicion(); // Deshabilitar los campos tras guardar
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

        private void btnCancelarEdicionCita_Click(object sender, EventArgs e)
        {
            DeshabilitarEdicion();
        }

        private void btnProgramarCitaD_Click(object sender, EventArgs e)
        {
            LimpiarCampos(); // Limpiar campos para nueva cita
            HabilitarEdicion(); //
        }
        private void LimpiarCampos()
        {
            txtMotCiD.Text = "";
            txtEsCiD.Text = "";
            dtpCitaFecha.Value = DateTime.Now;
            dtpCitaHora.Value = DateTime.Now;
        }
        private void btnRepreogramarCitaD_Click(object sender, EventArgs e)
        {
            if (cbxIDCitaD.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una cita para reprogramar.");
                return;
            }
            HabilitarEdicion(); // Habilitar los campos para edición
        }

        private void cbxIDMascD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}