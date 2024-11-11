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
    /// Este form a sido creado para la parte del dueño, donde podra manejar la inforacion de sus mascotas y sus citas.
    /// 
    /// </summary>
    public partial class CitaMascota : Form
    {
        private int IdUsuario;

        public CitaMascota(int idUsuario)
        {
            InitializeComponent();
            IdUsuario = idUsuario;
            ActualizarMascotas(); 
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

        // Método para actualizar los IDs de citas de la mascota seleccionada
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

        private void btnPerfilD_Click(object sender, EventArgs e)
        {
            PerfilDueno VerDueno = new PerfilDueno();
            this.Hide();
            VerDueno.ShowDialog();
        }

        private void CitaMascota_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = Usuario.Nombre;
            lblUsuarioUser.Text = Usuario.IdUsuario.ToString();
        }

        private void CitaMascota_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
