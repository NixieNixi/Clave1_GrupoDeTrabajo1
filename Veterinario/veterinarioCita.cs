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
using Clave1_GrupoDeTrabajo1.Clases;

namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    /// Autor: NixieNixi
    /// Fecha creacion: 21/10/2024
    /// Version: 1.0.0
    /// Descripcion: Este formulario maneja la interfaz para los citas de veterinarios
    /// en el sistema "Cat-Dog". Proporciona opciones para navegar dentro de el.
    /// </summary>

    ///<remarks>
    ///Autor: NixieNixi
    ///Fecha de Modificacion: 24/10/2024
    ///Descripcion:
    ///Se agrego un Panel ('panelVeterinarioCita') para contener la interfaz de citas del veterinario.
    ///Se añadieron dos GroupBox: 
    ///1. gbxaInfoExpediente para organizar la información del expediente de la mascota.
    ///2. gbxInfoCita para agrupar los detalles de la cita, como sintomas, diagnostico y tratamiento.
    ///3.gbxInfoCirugia,gbxVacuna,gbxExamen
    /// Se añadieron múltiples TextBox (txt) y Label (lbl) dentro de los GroupBox para gestionar informacion datos de la mascota.
    /// En el formulario 'veterinarioExpediente' se añadieron dos botones: 'btnVolver' para regresar al menú principal
    ///y 'btnIrCita' para acceder directamente a la sección de citas.
    /// 
    /// NixieNixi
    /// Agregue la conexion a la DB y cree los metodos de los cbx de vacuna y id Expeidnete, examen,ciruagia, ademas de los metodos d elimpiar. 
    /// 
    ///</remarks>
    ///

    

    public partial class veterinarioCita : Form
    {
        public veterinarioCita()
        {
            InitializeComponent();

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                string query = "SELECT idCita FROM citas;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbxIdCita.Items.Add(reader["idCita"].ToString());
                        }
                    }
                }
            }
        }


        // Evento para cuando cambia la selección del ComboBox
        private void cbxIdCita_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxIdCita.SelectedIndex == -1)
            {
                LimpiarControles();
            }
            else
            {
                // Convierte la selección de cbxIdExpedienteMascota a string y la guarda en selectedUserId
                string selectedCitaId = cbxIdCita.SelectedItem.ToString();
                // Llamada al metodos;
                MessageBox.Show("ID de Cita Seleccionado: " + selectedCitaId);
                CargarDatos(selectedCitaId);
            }
        }

        // Función para cargar los datos de la cita y la mascota asociada
        private void CargarDatos(string selectedCitaId)
        {
            
                                string query = @"
                                SELECT 
                                    citas.Estado, 
                                    citas.Fecha, 
                                    citas.Hora, 
                                    citas.Motivo, 
                                    mascotas.Nombre AS NombreMascota,
                                    mascotas.Especie,
                                FROM 
                                    citas 
                                LEFT JOIN 
                                    mascotas  ON citas.idMascota = mascotas.idMascota
                                WHERE 
                                    citas.idCita = @idCita;";

                try
                {


                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {

                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@idCita", selectedCitaId);

                                    connection.Open();

                                    using (MySqlDataReader reader = command.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            txtEstadoCita.Text = reader["Estado"].ToString();
                                   
                                            txtMotiConsulta.Text = reader["Motivo"].ToString();

                                            txtNomMascota.Text = reader["NombreMascota"].ToString();

                                            txtEspecie.Text = reader["Especie"].ToString();

                                        }
                                
                                    }
                                }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar los datos de la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void LimpiarControles()
        {
            txtEstadoCita.Clear();
            txtMotiConsulta.Clear();
            txtNomMascota.Clear();
            txtEspecie.Clear();
        }

    }
}
