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
    /// Co-Autores: RaRMustis,CanelaFeliz,Esmeralda
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
    /// Autor:NixeNixi
    /// Fecha de Mpdificacion: 07/11/2024
    /// Descripcion:
    /// Se agregaron los metodos de guardar vacunas,consulta,examen cirugia.
    /// se les agrego funciones a los metodos al btn guadar y se le agrego funcion a los metodo de guardar consulta y vacuna.
    /// Se agrego try-cacht para la captacion de errores y asi poder corregirlos.
    /// se agrego checkbbox a vacuna,examen,cirugia, solo vacuna tiene su funcionamiento completo, en las demas falta implementarlo
    /// 
    /// Autor:NixieNixi
    /// Fecha de Modificacion: 08/11/2024
    /// Descripcion:
    /// Se le agrego validaciones a los metodos de guardar, vacuna,citas,examen y cirugia, FALTA TESTEO
    /// Se reordeno, en backend para un mejor entendienmiento, se agrego funcion a cirugia. y se agrego el la funcion faltante de LimpiarControlesMascota
    /// 
    /// Autor: CanelaFeliz
    /// Fecha: 08/11/2024
    /// Descripcion: Se cambio el diseño del formulario y se agregaron funciones para cargar los idMascota e idCita
    /// 
    /// Autor: CanelaFeliz
    /// Fecha: 09/11/2024
    /// Descripcion: Se agrego funcion para limpiar los controles de consulta, se agrego comportamiento de limmpiar todos los controles si se cambia el
    /// idMascota. se reorganizo el codigo por funciones
    ///</remarks>

    public partial class veterinarioCita : Form
    {
        public veterinarioCita()
        {
            InitializeComponent();
            //Cargar los idMascota en el combobox
            CargarMascotas();
        }

        /// <summary>
        /// Variables que se utilizan para los comprobar si se debe o no llamar a metodos especificos
        /// </summary>
        private bool Cirugia = false;
        private bool Vacuna = false;
        private bool Examen = false;

        //INICIO INFORMACION DE LA MASCOTA
        /// <summary>
        /// Evento de cambio de seleccion de idMascota que carga la info de la mascota seleccionada y si tiene citas carga los idCita
        /// </summary>
        private void cbxIdMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpieza de todos los controles del form
            LimpiarControlesMascota();
            LimpiarControlesConsulta();
            LimpiarControlesVacuna();
            LimpiarControlesExamen();
            LimpiarControlesCirugia();

            string IdSeleccion = cbxIdMascota.SelectedItem.ToString();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    string query = "SELECT Nombre, Especie, Sexo FROM mascotas WHERE idMascota = @idMascota;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idMascota", IdSeleccion);
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                cbxIdCita.Enabled = true;
                                if (reader.Read())
                                {
                                    txtNomMascota.Text = reader["Nombre"].ToString();
                                    txtEspecie.Text = reader["Especie"].ToString();
                                    txtSexo.Text = reader["Sexo"].ToString();
                                }
                            }
                            else
                            {
                                cbxIdCita.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error.Message, "Error :(", MessageBoxButtons.OK);
            }
            CargarIdCita();
        }

        /// <summary>
        /// Evento para cuando cambia la selección del ComboBox
        /// </summary>
        private void cbxIdCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si no hay una selección (índice -1) y limpia los controles
            if (cbxIdCita.SelectedIndex == -1)
            {
                LimpiarControlesMascota();
            }
            else
            {

                // Obtiene el ID de cita seleccionado como cadena de texto
                string selectedCitaId = cbxIdCita.SelectedItem.ToString();

                // Llama al método CargarDatos para obtener los datos de la cita seleccionada
                CargarDatos(selectedCitaId);
            }
        }

        /// <summary>
        /// Funcion para cargar los idCita en el combobox si la mascota tiene citas programadas
        /// </summary>
        private void CargarIdCita()
        {
            cbxIdCita.Items.Clear();

            string IdSeleccion = cbxIdMascota.SelectedItem.ToString();
            try
            {
                DateTime fechaHoy = DateTime.Today;
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    string query = "SELECT idCita FROM citas WHERE idMascota = @idMascota AND Estado = 'Programada' AND Fecha >= @fechaHoy;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idMascota", IdSeleccion);
                        command.Parameters.AddWithValue("@fechaHoy", fechaHoy.Date);
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                cbxIdCita.Enabled = true;
                                while (reader.Read())
                                {
                                    cbxIdCita.Text = null;
                                    cbxIdCita.Items.Add(reader["idCita"].ToString());
                                }
                            }
                            else
                            {
                                cbxIdCita.Enabled = false;
                                cbxIdCita.Items.Add("No se encontraron citas");
                                cbxIdCita.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error.Message, "Error :(", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Funcion para cargar los idMascota en le combobox
        /// </summary>
        private void CargarMascotas()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    string query = "SELECT idMascota FROM mascotas ORDER BY idMascota ASC;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    cbxIdMascota.Items.Add(reader["idMascota"].ToString());
                                }
                                cbxIdMascota.Enabled = true;
                            }
                            else
                            {
                                cbxIdMascota.Text = "No se encontraron mascotas";
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error.Message, "Error :(", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Función para cargar los datos de la cita y la mascota asociada
        /// </summary>
        /// <param name="selectedCitaId">ID de la cita seleccionada en el ComboBox</param>
        private void CargarDatos(string selectedCitaId)
        {
            string query = "SELECT Estado, Fecha, Hora, Motivo FROM citas WHERE idCita = @idCita;";
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
                                DateTime fecha = (DateTime)reader["Fecha"];
                                TimeSpan hora = (TimeSpan)reader["Hora"];
                                dtpFechaHora.Value = fecha.Add(hora);

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
        /// Metodo que limpia los controles del formulario veterinarioCita de la informacion de mascota
        /// </summary>
        private void LimpiarControlesMascota()
        {
            // Limpia los campos de texto relacionados con los datos de la cita y la mascota
            txtEstadoCita.Clear();
            txtMotiConsulta.Clear();
            dtpFechaHora.Value = DateTime.Now;
            txtSintomas.Clear();
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            txtMedicamentos.Clear();
            txtExamFisico.Clear();
            txtNotasCita.Clear();
            txtPeso.Clear();
        }

        //FIN INFORMACION DE LA MASCOTA

        /// <summary>
        /// Metodo que guarda, GuardarConsulta por defecto, y si el check de algun groupbox esta activado, entonces lo guarda
        /// siempre y cuando los datos sena validos, si no da errror.
        /// </summary>
        private void btnGuardarVeterinarioCita_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                MessageBox.Show("Hay un error en los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
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

                if (Cirugia)
                {
                    GuardarCirugia();
                }

                MessageBox.Show("La información se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpieza de todos los controles del form
                LimpiarControlesMascota();
                LimpiarControlesConsulta();
                LimpiarControlesVacuna();
                LimpiarControlesExamen();
                LimpiarControlesCirugia();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la información: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo de validaciones de los campos de consulta, vacuna, examen y cirugia
        /// </summary>
        /// <returns>
        /// Retorna false si hay un error en algun dato
        /// </returns>
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(cbxIdMascota.Text))
            {
                MessageBox.Show("Por favor, introduce un valor de ID Mascota.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("Por favor, introduce un valor de peso.");
                return false;
            }

            if (!decimal.TryParse(txtPeso.Text, out decimal peso) || peso <= 0 || peso > 999.99m)
            {
                MessageBox.Show("Por favor, introduce un valor de peso válido (mayor que 0 y hasta 999.99).");
                return false;
            }

            if (Vacuna)
            {
                if (string.IsNullOrWhiteSpace(cbxIdMascota.Text) || string.IsNullOrWhiteSpace(cbxTipoVacuna.Text) ||
                    string.IsNullOrWhiteSpace(txtMotiVacuna.Text) || string.IsNullOrWhiteSpace(txtUsaMaterialesVacuna.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos obligatorios antes de guardar la vacuna.",
                                    "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (Examen)
            {
                if (string.IsNullOrWhiteSpace(cbxIdMascota.Text) || string.IsNullOrWhiteSpace(cbxTipoExamen.Text) ||
                    string.IsNullOrWhiteSpace(txtMotiExamen.Text) || string.IsNullOrWhiteSpace(txtUsaMaterialesExamen.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos obligatorios antes de guardar el examen.",
                                    "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (Cirugia)
            {
                if (string.IsNullOrWhiteSpace(cbxIdMascota.Text) || string.IsNullOrWhiteSpace(cbxTipoCirugia.Text) ||
                    string.IsNullOrWhiteSpace(txtMotiCirugia.Text) || string.IsNullOrWhiteSpace(txtUsaMaterialesCirugia.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos obligatorios antes de guardar la cirugía.",
                                    "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Metodo que anula la cita una vez se paso consulta
        /// </summary>

        /// <summary>
        /// Metodo que cancela el ingreso de citas
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //INICIO CONSULTA

        /// <summary>
        /// Metodo que guarda en la DB la consulta de la mascota
        /// </summary>
        private void GuardarConsulta()
        {

            string query = @"INSERT INTO Consultas (idMascota, idCita, FechaHora, Peso, Motivo, Sintomas, ExamenFisico, Diagnostico, Tratamiento, Medicamentos, Notas)
                             VALUES (@idMascota, @idCita, @FechaHora, @Peso, @Motivo, @Sintomas, @ExamenFisico, @Diagnostico, @Tratamiento, @Medicamentos, @Notas)";

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idMascota", cbxIdMascota.Text.Trim());
                    command.Parameters.AddWithValue("@idCita", cbxIdCita.Text.Trim());
                    command.Parameters.AddWithValue("@FechaHora", DateTime.Now);
                    command.Parameters.AddWithValue("@Peso", Math.Round(Convert.ToDecimal(txtPeso.Text), 2));
                    command.Parameters.AddWithValue("@Motivo", txtMotiConsulta.Text.Trim());
                    command.Parameters.AddWithValue("@Sintomas", txtSintomas.Text.Trim());
                    command.Parameters.AddWithValue("@ExamenFisico", txtExamFisico.Text.Trim());
                    command.Parameters.AddWithValue("@Diagnostico", txtDiagnostico.Text.Trim());
                    command.Parameters.AddWithValue("@Tratamiento", txtTratamiento.Text.Trim());
                    command.Parameters.AddWithValue("@Medicamentos", txtMedicamentos.Text.Trim());
                    command.Parameters.AddWithValue("@Notas", txtNotasCita.Text.Trim());

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

            query = @"UPDATE citas SET Estado = 'Finalizada' WHERE idCita = @idCita;";

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("idCita", cbxIdCita.SelectedItem.ToString());

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el estado de cita " + ex.Message, "Error :(");
                    }
                }
            }
        }

        /// <summary>
        /// Metodo para limpiar los controles de la informacion de consulta
        /// </summary>
        private void LimpiarControlesConsulta()
        {
            txtSintomas.Clear();
            txtTratamiento.Clear();
            txtExamFisico.Clear();
            txtMedicamentos.Clear();
            txtDiagnostico.Clear();
            txtPeso.Clear();
            txtNotasCita.Clear();
        }

        //FIN CONSULTA

        //INICIO VACUNA

        /// <summary>
        /// Evento que se ejecuta cuando se marca o desmarca el chkVacuna
        /// </summary>
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
        /// Metodo que guarda las vacunas que se suministren
        /// </summary>
        private void GuardarVacuna()
        {
            string query = @"INSERT INTO vacuna (idMascota, idCita, FechaHora, Tipo, Descripcion, Motivo, Materiales)
                             VALUES (@idMascota, @idCita, @FechaHora, @Tipo, @Descripcion, @Motivo, @Materiales)";

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idMascota", cbxIdMascota.Text.Trim());
                command.Parameters.AddWithValue("@idCita", cbxIdCita.Text.Trim());
                command.Parameters.AddWithValue("@FechaHora", DateTime.Now);
                command.Parameters.AddWithValue("@Tipo", cbxTipoVacuna.Text.Trim());

                //No se agrego validacion para la descripcion, ya que segun la Db es un dato no obligatorio
                command.Parameters.AddWithValue("@Descripcion", txtDescripcionVacuna.Text.Trim());
                command.Parameters.AddWithValue("@Motivo", txtMotiVacuna.Text.Trim());
                command.Parameters.AddWithValue("@Materiales", txtUsaMaterialesVacuna.Text.Trim());

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

        //FIN VACUNA

        //INICIO EXAMEN

        /// <summary>
        /// metodo que activa y desactiva los controles del examen
        /// </summary>
        private void chkExamen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExamen.Checked)
            {
                // Activar controles
                ActivarControlesExamen(true);

                // Cambiar el valor de la variable
                Examen = true;
            }
            else
            {
                // Desactivar controles y limpia los campos
                ActivarControlesExamen(false);

                LimpiarControlesExamen();

                // Cambiar el valor de la variable
                Examen = false;
            }


        }

        /// <summary>
        /// Evento que se ejecuta cuando se marca o desmarca el chkExamen
        /// </summary>
        private void GuardarExamen()
        {
            string query = @"INSERT INTO examen (idMascota, idCita, FechaHora, Tipo, Descripcion, Motivo, Materiales)
                             VALUES (@idMascota, @idCita, @FechaHora, @Tipo, @Descripcion, @Motivo, @Materiales)";

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idMascota", cbxIdMascota.Text.Trim());
                command.Parameters.AddWithValue("@idCita", cbxIdCita.Text.Trim());
                command.Parameters.AddWithValue("@FechaHora", DateTime.Now);
                command.Parameters.AddWithValue("@Tipo", cbxTipoExamen.Text.Trim());
                command.Parameters.AddWithValue("@Descripcion", txtDescripcionExamen.Text.Trim());
                command.Parameters.AddWithValue("@Motivo", txtMotiExamen.Text.Trim());
                command.Parameters.AddWithValue("@Materiales", txtUsaMaterialesExamen.Text.Trim());

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
        /// // Función para limpiar los campos relacionados con la vacuna
        /// </summary>
        private void LimpiarControlesExamen()
        {
            cbxTipoExamen.SelectedIndex = -1;
            txtMotiExamen.Clear();
            txtUsaMaterialesExamen.Clear();
            txtDescripcionExamen.Clear();
            txtNotasExamen.Clear();
        }

        //FIN EXAMEN

        //INICIO CIRUGIA

        /// <summary>
        /// Evento que se ejecuta cuando se marca o desmarca el chkCirugia
        /// </summary>
        private void chkCirugia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCirugia.Checked)
            {
                // Activar controles
                ActivarControlesCirugia(true);

                // Cambiar el valor de la variable
                Cirugia = true;
            }
            else
            {
                // Desactivar controles y limpia los campos
                ActivarControlesCirugia(false);

                LimpiarControlesCirugia();

                // Cambiar el valor de la variable
                Cirugia = false;
            }

        }

        /// <summary>
        /// Metodo que guarda los datos de cirugia que se ingresen, siempre y cuando cumplan con las validaciones
        /// </summary>
        private void GuardarCirugia()
        {
            string query = @"INSERT INTO cirugia (idMascota, idCita, FechaHora, Tipo, Descripcion, Motivo, Materiales)
                             VALUES (@idMascota, @idCita, @FechaHora, @Tipo, @Descripcion, @Motivo, @Materiales)";

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idMascota", cbxIdMascota.Text.Trim());
                command.Parameters.AddWithValue("@idCita", cbxIdCita.Text.Trim());
                command.Parameters.AddWithValue("@FechaHora", DateTime.Now);
                command.Parameters.AddWithValue("@Tipo", cbxTipoCirugia.Text.Trim());
                command.Parameters.AddWithValue("@Descripcion", txtDescripcionCirugia.Text.Trim());
                command.Parameters.AddWithValue("@Motivo", txtMotiCirugia.Text.Trim());
                command.Parameters.AddWithValue("@Materiales", txtUsaMaterialesCirugia.Text.Trim());

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

        /// <summary>
        ///Función para activar y desactivar controles relacionados con la Cirugia
        /// </summary>
        /// <param name="estado"></param>
        private void ActivarControlesCirugia(bool estado)
        {
            cbxTipoCirugia.Enabled = estado;
            txtMotiCirugia.Enabled = estado;
            txtUsaMaterialesCirugia.Enabled = estado;
            txtDescripcionCirugia.Enabled = estado;
            txtNotasCirugia.Enabled = estado;
        }

        /// <summary>
        /// // Función para limpiar los campos relacionados con la Cirugia
        /// </summary>
        private void LimpiarControlesCirugia()
        {
            cbxTipoCirugia.SelectedIndex = -1;
            txtMotiVacuna.Clear();
            txtUsaMaterialesCirugia.Clear();
            txtDescripcionCirugia.Clear();
            txtNotasCirugia.Clear();
        }

        //FIN CIRUGIA
    }
}