﻿using System;
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
                                    mascotas.Especie,
                                    citas.idMascota
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
                                            txtIdMascota.Text = reader["idMascota"].ToString();
                                            txtEstadoCita.Text = reader["Estado"].ToString();
                                   
                                            txtMotiConsulta.Text = reader["Motivo"].ToString();

                                            txtNomMascota.Text = reader["NombreMascota"].ToString();

                                            txtEspecie.Text = reader["Especie"].ToString();
                                            dtpFechaHora.Text = reader["Fecha"].ToString();

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
            // Guardar siempre la consulta
            GuardarConsulta();

            // Guardar otros servicios si están seleccionados
            if (Vacuna)
            {
                GuardarVacuna();
            }

            if (Examen)
            {
                GuardarExamen();
            }

            //if (Cirugia)
            //{
            //    GuardarCirugia();
            //}

            // Mensaje de confirmación
            MessageBox.Show("La información se ha guardado correctamente.");
        }

        /// <summary>
        /// Metodo que guarda en la DB la consulta de la mascota
        /// </summary>
        private void GuardarConsulta()
        {
            
            string query = "INSERT INTO Consultas (idMascota,Sintomas,ExamenFisico,Diagnostico,Tratamiento,Medicamentos,Notas,FechaHora,Peso,Motivo) " +
                "VALUES (@idmascota,@sintomas,@examenfisico,@diagnostico,@tratamiento,@medicamentos, @notas,@fechahora,@peso,@motivo)";

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                     
                    if (string.IsNullOrWhiteSpace(mtxtPeso.Text))
                    {
                        MessageBox.Show("Por favor, introduce un valor de peso.");
                        return; 
                    }

                    if (!decimal.TryParse(mtxtPeso.Text, out decimal peso) || peso <= 0 || peso > 999.99m)
                    {
                        MessageBox.Show("Por favor, introduce un valor de peso válido (mayor que 0 y hasta 999.99).");
                        return; 
                    }

                    
                    if (string.IsNullOrWhiteSpace(txtIdMascota.Text))
                    {
                        MessageBox.Show("Por favor, introduce un valor de ID.");
                        return; 
                    }

                   
                    DateTime fechaHora = dtpFechaHora.Value;
                   //Que se evite elejir fechas que son futuras
                    if (fechaHora > DateTime.Now)
                    {
                        MessageBox.Show("La fecha no puede ser futura.");
                        return; 
                    }


                    command.Parameters.AddWithValue("@idmascota", txtIdMascota.Text.Trim());
                    command.Parameters.AddWithValue("@peso", Math.Round(peso, 2));
                    command.Parameters.AddWithValue("@sintomas", txtSintomas.Text.Trim());
                    command.Parameters.AddWithValue("@examenfisico", txtExamFisico.Text.Trim());
                    command.Parameters.AddWithValue("@diagnostico", txtDiagnostico.Text.Trim());
                    command.Parameters.AddWithValue("@tratamiento", txtTratamiento.Text.Trim());
                    command.Parameters.AddWithValue("@medicamentos", txtMedicamentos.Text.Trim());
                    command.Parameters.AddWithValue("@notas", txtNotasCita.Text.Trim());
                    command.Parameters.AddWithValue("@fechaHora", fechaHora);
                    command.Parameters.AddWithValue("@motivo", txtMotiConsulta.Text.Trim());

                    
                    
                    // Aquí ejecutas el comando para insertar en la base de datos
                    try
                    {

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registro de Consulta guardado con éxito.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el registro: " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Metodo que guarda las vacunas que se suministren
        /// </summary>
        private void GuardarVacuna()
        {
            string query = @"
            INSERT INTO vacuna (idMascota, Tipo, Descripcion, Motivo, Materiales)
            VALUES (@idmascota, @tipo, @descripcion, @motivo, @materiales)";

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idmascota", txtIdMascota.Text.Trim());
                command.Parameters.AddWithValue("@tipo", cbxTipoVacuna.Text.Trim());
                command.Parameters.AddWithValue("@descripcion", txtDescripcionVacuna.Text.Trim());
                command.Parameters.AddWithValue("@motivo", txtMotiVacuna.Text.Trim());
                command.Parameters.AddWithValue("@materiales", txtUsaMaterialesVacuna.Text.Trim());

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vacuna guardada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la vacuna: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GuardarExamen()
        {
            string query = @"
            INSERT INTO examen (idMascota, Tipo, Descripcion, Motivo, Materiales)
            VALUES (@idmascota, @tipo, @descripcion, @motivo, @materiales)";

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idmascota", txtIdMascota.Text.Trim());
                command.Parameters.AddWithValue("@tipo", cbxTipoExamen.Text.Trim());
                command.Parameters.AddWithValue("@descripcion", txtDescripcionExamen.Text.Trim());
                command.Parameters.AddWithValue("@motivo", txtMotiExamen.Text.Trim());
                command.Parameters.AddWithValue("@materiales", txtUsaMaterialesExamen.Text.Trim());

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Examen guardada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el Examen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GuardarCirugia()
        {
            
            if (string.IsNullOrWhiteSpace(txtIdMascota.Text) ||
                string.IsNullOrWhiteSpace(cbxTipoCirugia.Text) ||
                string.IsNullOrWhiteSpace(txtMotiCirugia.Text) ||
                string.IsNullOrWhiteSpace(txtUsaMaterialesCirugia.Text))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios antes de guardar la cirugía.",
                    "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
            INSERT INTO cirugia (idMascota, Tipo, Descripcion, Motivo, Materiales)
            VALUES (@idmascota, @tipo, @descripcion, @motivo, @materiales)";

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idmascota", txtIdMascota.Text.Trim());
                command.Parameters.AddWithValue("@tipo", cbxTipoCirugia.Text.Trim());
                command.Parameters.AddWithValue("@descripcion", txtDescripcionCirugia.Text.Trim());
                command.Parameters.AddWithValue("@motivo", txtMotiCirugia.Text.Trim());
                command.Parameters.AddWithValue("@materiales", txtUsaMaterialesCirugia.Text.Trim());

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cirugia guardada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la Cirugia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //FIN FUNCIONE DE BTNGUARDAR



        // Verifica si hay datos ingresados en los campos
        private bool IsDataValid()
        {
            return !string.IsNullOrEmpty(txtMotiExamen.Text) ||
                   !string.IsNullOrEmpty(txtDescripcionExamen.Text) ||
                   !string.IsNullOrEmpty(txtUsaMaterialesExamen.Text) ||
                   !string.IsNullOrEmpty(txtNotasExamen.Text) ||
                   cbxTipoExamen.SelectedItem != null;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Aquí va el código para cancelar la operación, por ejemplo:
            this.Close(); // Cerrar el formulario
        }


        // Variable global para indicar si hay vacuna
        private bool Vacuna = false;

        /// <summary>
        /// Evento que se ejecuta cuando se marca o desmarca el chkVacuna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkVacuna_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVacuna.Checked)
            {
                // Activar controles
                ActivarControlesVacuna(true);

                // Cambiar el valor de la variable
                Vacuna = true;
            }
            else
            {
                // Desactivar controles y limpia los campos
                ActivarControlesVacuna(false);

                LimpiarControlesVacuna();

                // Cambiar el valor de la variable
                Vacuna = false;
            }
        }


        /// <summary>
        ///Función para activar y desactivar controles relacionados con la vacuna
        /// </summary>
        /// <param name="estado"></param>
        private void ActivarControlesVacuna(bool estado)
        {
            cbxTipoVacuna.Enabled = estado;
            txtMotiVacuna.Enabled = estado;
            txtUsaMaterialesVacuna.Enabled = estado;
            txtDescripcionVacuna.Enabled = estado;
            txtNotasVacuna.Enabled = estado;
        }

        /// <summary>
        /// // Función para limpiar los campos relacionados con la vacuna
        /// </summary>
        private void LimpiarControlesVacuna()
        {
            cbxTipoVacuna.SelectedIndex = -1; 
            txtMotiVacuna.Clear();
            txtUsaMaterialesVacuna.Clear();
            txtDescripcionVacuna.Clear();
            txtNotasVacuna.Clear();
        }



        // Variable global para indicar si hay Examen
        private bool Examen = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkExamen_CheckedChanged(object sender, EventArgs e)
        {
            //bool isExamenChecked = chkExamen.Checked;
            //cbxTipoExamen.Enabled = isExamenChecked;
            //txtDescripcionExamen.Enabled = isExamenChecked;
            //txtNotasExamen.Enabled = isExamenChecked;
            //txtNotasExamen.Enabled = isExamenChecked;
            //txtUsaMateriaesExamen.Enabled = isExamenChecked;
            //txtMotiExamen.Enabled = isExamenChecked;

            if (chkExamen.Checked)
            {
                // Activar controles
                ActivarControlesExamen(true);

                // Cambiar el valor de la variable
                Vacuna = true;
            }
            else
            {
                // Desactivar controles y limpia los campos
                ActivarControlesExamen(false);

                //LimpiarControlesExamen();

                // Cambiar el valor de la variable
                Examen = false;
            }


        }

        //Hace falta el metodo de LimpiarControlesExamen

        /// <summary>
        ///Función para activar y desactivar controles relacionados con la vacuna
        /// </summary>
        /// <param name="estado"></param>
        private void ActivarControlesExamen(bool estado)
        {
            cbxTipoExamen.Enabled = estado;
            txtMotiExamen.Enabled = estado;
            txtUsaMaterialesExamen.Enabled = estado;
            txtDescripcionExamen.Enabled = estado;
            txtNotasExamen.Enabled = estado;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCirugia_CheckedChanged(object sender, EventArgs e)
        {
            //bool isCirugiaChecked = chkCirugia.Checked;
            //cbxTipoCirugia.Enabled = isCirugiaChecked;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkConsulta_CheckedChanged(object sender, EventArgs e)
        {
            //bool isConsultaCheked = chkConsulta.Checked;
            //txtMotiConsulta.Enabled = isConsultaCheked;
        }
    }
}
