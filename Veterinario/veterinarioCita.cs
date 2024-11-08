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
    /// Autor:NixieNixi
    /// Fecha de Modificacion: 05/11/2024
    /// Descrpcion:
    /// Agregue la conexion a la DB y cree los metodos de los cbx de vacuna y id Expeidnete, examen,ciruagia, ademas de los metodos de limpiar.
    /// 
    /// Autor: NixieNixi
    /// Fecha de Modificacion: 06/11/2024
    /// Descripcion:
    /// Se agrego el metodo de Cargar datos la cita y mascota asociada.
    /// 
    ///</remarks>
    ///

    
   
    public partial class veterinarioCita : Form
    {
        public veterinarioCita()
        {
            InitializeComponent();

            // Cargar los IDs de citas al ComboBox cbxIdCita al inicializar el formulario
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


        /// <summary>
        /// Evento para cuando cambia la selección del ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxIdCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si no hay una selección (índice -1) y limpia los controles
            if (cbxIdCita.SelectedIndex == -1)
            {
                LimpiarControles();
            }
            else
            {
                // Obtiene el ID de cita seleccionado como cadena de texto
                string selectedCitaId = cbxIdCita.SelectedItem.ToString();
              

                // Muestra un mensaje con el ID de cita seleccionado
                MessageBox.Show("ID de Cita Seleccionado: " + selectedCitaId);

                // Llama al método CargarDatos para obtener los datos de la cita seleccionada
                CargarDatos(selectedCitaId);
            }
        }




        /// <summary>
        /// Función para cargar los datos de la cita y la mascota asociada
        /// </summary>
        /// <param name="selectedCitaId">ID de la cita seleccionada en el ComboBox</param>
        private void CargarDatos(string selectedCitaId)
        {
            
                                string query = @"
                                SELECT 
                                    citas.Estado, 
                                    citas.Fecha, 
                                    citas.Hora, 
                                    citas.Motivo, 
                                    mascotas.Nombre AS NombreMascota,
                                    mascotas.Especie
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
                                            // Asigna cada valor obtenido a los controles del formulario

                                            txtEstadoCita.Text = reader["Estado"].ToString();
                                   
                                            txtMotiConsulta.Text = reader["Motivo"].ToString();

                                            txtNomMascota.Text = reader["NombreMascota"].ToString();

                                            txtEspecie.Text = reader["Especie"].ToString();
                                            txtFechaCita.Text = reader["Fecha"].ToString();
                                        }
                                
                                    }
                                }
                    }
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error si ocurre alguna excepción
                    MessageBox.Show("Ocurrió un error al cargar los datos de la cita: " + ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            
        }


        /// <summary>
        /// Metodo que limpia los controles del formulario veterinarioCita
        /// </summary>
        private void LimpiarControles()
        {
            // Limpia los campos de texto relacionados con los datos de la cita y la mascota
            txtEstadoCita.Clear();
            txtMotiConsulta.Clear();
            txtNomMascota.Clear();
            txtEspecie.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarVeterinarioCita_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                

                // Solo insertar en la base de datos si se han ingresado datos en el formulario
                if (IsDataValid())
               {
                    string query = "INSERT INTO Examenes (TipoExamen, MotiExamen, DescripcionExamen, UsaMaterialesExamen, NotasExamen) " +
                                   "VALUES (@TipoExamen, @MotiExamen, @DescripcionExamen, @UsaMaterialesExamen, @NotasExamen)";

                    // Usar MySqlCommand para ejecutar la consulta
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                  {
                       // Solo añadir valores que no sean vacíos
                        command.Parameters.AddWithValue("@TipoExamen", cbxTipoExamen.SelectedItem?.ToString() ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@MotiExamen", string.IsNullOrEmpty(txtMotiExamen.Text) ? (object)DBNull.Value : txtMotiExamen.Text);
                        command.Parameters.AddWithValue("@DescripcionExamen", string.IsNullOrEmpty(txtDescripcionExamen.Text) ? (object)DBNull.Value : txtDescripcionExamen.Text);
                        command.Parameters.AddWithValue("@UsaMaterialesExamen", string.IsNullOrEmpty(txtUsaMateriaesExamen.Text) ? (object)DBNull.Value : txtUsaMateriaesExamen.Text);
                        command.Parameters.AddWithValue("@NotasExamen", string.IsNullOrEmpty(txtNotasExamen.Text) ? (object)DBNull.Value : txtNotasExamen.Text);

                         //Abrir la conexión y ejecutar el comando
                        connection.Open();
                        command.ExecuteNonQuery(); // Ejecutar la consulta
                    }
                    MessageBox.Show("Datos guardados exitosamente.");
                }
               else
                {
                    MessageBox.Show("Por favor, ingrese al menos un dato.");
                }
            }
        }

        // Verifica si hay datos ingresados en los campos
        private bool IsDataValid()
        {
            return !string.IsNullOrEmpty(txtMotiExamen.Text) ||
                   !string.IsNullOrEmpty(txtDescripcionExamen.Text) ||
                   !string.IsNullOrEmpty(txtUsaMateriaesExamen.Text) ||
                   !string.IsNullOrEmpty(txtNotasExamen.Text) ||
                   cbxTipoExamen.SelectedItem != null;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Aquí va el código para cancelar la operación, por ejemplo:
            this.Close(); // Cerrar el formulario
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkVacuna_CheckedChanged(object sender, EventArgs e)
        {
            // Activar o desactivar controles relacionados con vacuna
            bool isVacunaChecked = chkVacuna.Checked;
            cbxTipoVacuna.Enabled = isVacunaChecked;
            txtDescripcionVacuna.Enabled = isVacunaChecked;
            txtNotasVacuna.Enabled = isVacunaChecked;
            txtUsaMaterialesVacuna.Enabled = isVacunaChecked;
            txtMotiVacuna.Enabled = isVacunaChecked;


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkExamen_CheckedChanged(object sender, EventArgs e)
        {
            bool isExamenChecked = chkExamen.Checked;
            cbxTipoExamen.Enabled = isExamenChecked;
            txtDescripcionExamen.Enabled = isExamenChecked;
            txtNotasExamen.Enabled = isExamenChecked;
            txtNotasExamen.Enabled = isExamenChecked;
            txtUsaMateriaesExamen.Enabled = isExamenChecked;
            txtMotiExamen.Enabled = isExamenChecked;
        }
    }
}
