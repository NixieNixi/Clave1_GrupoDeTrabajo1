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

namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    /// <summary>
    /// Autor: NixieNixi
    /// Fecha creacion: 21/10/2024
    /// Version: 1.0.0
    /// Descripcion: Este formulario maneja la interfaz para los expedientes de veterinarios
    /// en el sistema "Cat-Dog". Proporciona opciones para navegar hacia la sección de citas del veterinario.
    /// </summary>

    ///<remarks>
    ///Modificado por: NixieNixi
    ///Fecha de Modificacion:22/10/2024
    ///Descripcion: Se agrego un TapControl el cual contiene dos pestanas Informacion General y Historial Medico
    ///dentro de Informacion General se agrego lbl y txt que llevaran la informacion del dueno y mascota.
    ///dentro de Historial Medico se agrego DataGrid de historial, citas, Consultas y Vacunas,
    ///En el form veterinarioExpediente se agregaron dos btn: btnVolver y btnIrCita. ()
    ///
    /// Modificado Por: NixieNixi
    /// Fecha de Mpdificacion:25/10/2024
    /// Descripcion: se agg el cbxIdExpedienteMascota, y segun la opcion que el veterinario selecciones, asi le mostrara
    /// segun Id del Expediente(Falta Testeo).
    /// se agrego validaciones y se cambio el como hacia la consulta sql, para evitar ambiguedades futuras. 
    /// 
    /// Modificado por: NixieNixi
    /// Fecha de Modificacion: 27/10/2024
    /// Descripcion: Se agrego el metodo del btnVolver que devuelve al form veterinariPerfil.
    /// Ademas a los labels del diseno se les nombro segun el rol que desempenan dentro del programa.
    /// y se gg comentarios a los distintos metodos
    /// 
    /// Modificado por:
    /// Fecha de Modificacion:
    /// Descripcion:
    /// 
    /// Modificado por: NixieNixi
    /// Fecha de Modificacion: 30/10/2024
    /// Descripcion: Al inicio daba El error CS0246 con el using MySql.Data.MySqlClient, se soluciono con desisntalar 
    /// el paquete de mysql.data y volverlo a instalar.
    /// 
    /// ///</remarks>


    public partial class veterinarioExpediente : Form
    {
        /// <summary>
        ///Constructor del formulario veterinarioExpediente.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public veterinarioExpediente()
        {
            InitializeComponent();

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                //Consulta la columna idMascota de la tabla mascotas
                string query = "SELECT idMascota FROM mascotas;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Inserta los registros de idMascota en el comboBox cbxIdMascota
                            
                            cbxIdMascota.Items.Add(reader["idMascota"].ToString());
                        }
                    }
                }
            }
        }

        /// <summary>
        ///Evento click del botón 'Ir a Cita'. Este evento se activa cuando el usuario hace clic en el btn.
        /// Oculta el formulario actual y abre el formulario de veterinarioCita.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIrCita_Click(object sender, EventArgs e)
        {
           // Crea una nueva instancia del formulario veterinarioCita.
            veterinarioCita veterinarioCita = new veterinarioCita();

            // Oculta el formulario actual (veterinarioExpediente) para que no esté visible.
            this.Hide();

            // Muestra el formulario veterinarioCita como un cuadro de diálogo modal.
            // Esto significa que el formulario de citas estará activo y el formulario original
            // no podrá interactuar hasta que se cierre el nuevo formulario.
            veterinarioCita.ShowDialog();

            // Una vez que se cierra el formulario de veterinarioCita, se vuelve a mostrar el formulario original.
            this.Show();
        }

        /// <summary>
        /// Metodo cambio de seleccion en el comboBox ID Mascota. Se activa al cambiar la seleccion del comboBox
        /// Si no se ha seleccionado una opcion se limpian los controles
        /// Si se ha seleccionado una opcion se llama al metodo CargarDatosMascota con el parametro selecIdMascota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxIdMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia los controles si no se ha seleccionado una opción
            if (cbxIdMascota.SelectedIndex == -1)
            {
                LimpiarControles();
            }
            else
            {
                // Convierte la selección de cbxIdExpedienteMascota a string y la guarda en selectedUserId
                string selecIdMascota = cbxIdMascota.SelectedItem.ToString();
                // Llamada al metodo CargarDatosMascota;
                CargarDatosMascota(selecIdMascota);
                
            }
        }

        /// <summary>
        /// Metodo para cargar los datos de la mascota y el dueño según el ID de usuario seleccionado.
        /// </summary>
        /// <param name="selectedUserId"></param>
        /// recibe como parametro de tipo string selectedUserId que guarda la seleccion en el comboBox ID Mascota
        private void CargarDatosMascota(string selectedUserId)
        {

            // Consulta SQL para obtener los datos del usuario y la mascota asociada.
            //Use este formato, ya que se asemeja a las de sql
            string query = @"SELECT
            usuarios.idUsuario,
            usuarios.Nombre,
            usuarios.Telefono,
            usuarios.Correo,
            usuarios.Direccion,
            mascotas.idMascota,
            mascotas.Nombre AS NombreMascota,
            mascotas.Especie,
            mascotas.Raza,
            mascotas.Sexo,
            mascotas.FechaNacimiento
            FROM usuarios 
            LEFT JOIN mascotas ON usuarios.idUsuario = mascotas.idUsuario
            WHERE mascotas.idMascota = @idMascota;";

            //Agg el try porque, si
            try
            {


                // Crear una conexión a la base de datos usando la cadena de conexion.
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    // Crear un comando para ejecutar la consulta.
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar el parametro de ID de mascota a la consulta.
                        command.Parameters.AddWithValue("@idMascota", selectedUserId);

                        // Abrir la conexion a la base de datos.
                        connection.Open();

                        // Ejecutar el comando y usar un lector para obtener los datos.
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Leer los datos devueltos por la consulta.
                            if (reader.Read())
                            {
                                // Cargar los datos obtenidos en los controles correspondientes
                                //campos del dueño de la mascota
                                txtIdDuenoExp.Text = reader["idUsuario"].ToString();
                                txtNomDueno.Text = reader["Nombre"].ToString();
                                txtTelefonoDueno.Text = reader["Telefono"].ToString();
                                txtCorreoDueno.Text = reader["Correo"].ToString();
                                txtDireccionDueno.Text = reader["Direccion"].ToString();
                                //campos de la informacion fundamental de la mascota
                                txtNomMascota.Text = reader["NombreMascota"].ToString();
                                txtEspecie.Text = reader["Especie"].ToString();
                                txtRaza.Text = reader["Raza"].ToString();
                                txtSexo.Text = reader["Sexo"].ToString();
                                txtFechaNacimiento.Text = Convert.ToDateTime(reader["FechaNacimiento"]).ToString("dd/MM/yyyy");
                            }
                        }
                    }

                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mor da error " + ex.Message);

            }


        }
        //Fin TapInformacionGeneral


        /// Inicio TapHistorialMedico
        /// <summary>
        /// Carga los datos de citas en el DataGridView según el ID de la mascota.
        /// </summary>
        /// <param name="idMascota">ID de la mascota para cargar su historial de citas.</param>
        private void SubirHCitas(int idMascota)
        {
            string querycitas = @"
                SELECT 
                    citas.idCita, 
                    citas.Motivo, 
                    consultas.Sintomas, 
                    consultas.ExamenFisico, 
                    consultas.Diagnostico, 
                    consultas.Tratamiento, 
                    consultas.Medicamentos, 
                    consultas.Notas 
                FROM 
                    citas 
                JOIN 
                    consultas ON citas.idMascota = consultas.idMascota
                WHERE 
                    citas.idMascota = @idMascota;";

            // Crea un DataTable para almacenar los resultados de la consulta realizada.
            DataTable dataTable = new DataTable();

            // Inicia la conexión hacia la base de datos.
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                // Crea un comando para ejecutar la consulta.
                using (MySqlCommand command = new MySqlCommand(querycitas, connection))
                {
                    // Agrega el parámetro del ID de mascota a la consulta.
                    command.Parameters.AddWithValue("@idMascota", idMascota); 

                    // Se abre la conexión a la base de datos.
                    connection.Open();

                    // Se utiliza un DataAdapter para llenar el DataTable con los resultados de la consulta.
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable); // Llena el DataTable con los resultados
                        dgvHCitas.DataSource = dataTable; // Asigna el DataTable como fuente de datos del DataGridView

                        // Verifica que el DataTable tenga filas y configura los encabezados de las columnas.
                        if (dataTable.Rows.Count > 0)
                        {
                            dgvHCitas.Columns["idCita"].HeaderText = "ID Cita Anterio AAAA";
                            dgvHCitas.Columns["Motivo"].HeaderText = "Motivo Consulta";
                            dgvHCitas.Columns["Sintomas"].HeaderText = "Síntomas";
                            dgvHCitas.Columns["ExamenFisico"].HeaderText = "Examen Físico";
                            dgvHCitas.Columns["Diagnostico"].HeaderText = "Diagnóstico";
                            dgvHCitas.Columns["Tratamiento"].HeaderText = "Tratamiento";
                            dgvHCitas.Columns["Medicamentos"].HeaderText = "Medicamentos";
                            dgvHCitas.Columns["Notas"].HeaderText = "Notas";
                        }
                        else
                        {
                            // Si no encuentra el historial de citas, muestra un mensaje.
                            MessageBox.Show("No se encontro citas.");
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Metodo para subir los datos de la DB al data grid el Historial del paciente
        /// </summary>
        /// <param name="idMascota"></param>
        private void SubirHPaciente(string idMascota)
        {
            //Aqui ira para el dgvHPaciente
            //FALTA PONER LA CONNSULTA SQL
            string query = @"
                    SELECT 
                        
                    FROM  
                    WHERE IdMascota = @idMascota;";

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idMascota", idMascota);

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            // Asigna el DataTable al DataGrid
                            dgvHPaciente.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar el Historial Medico del Paciente: {ex.Message}");
                    }
                }
            }
        }


        /// <summary>
        /// Metodo para subir los datos de la DB al data grid del historial de vacunas.
        /// </summary>
        /// <param name="idMascota"></param>
        private void SubirHVacuna(string idMascota)
        {
            //Aqui ira para el dgvHVacuna
            //FALTA PONER LA CONNSULTA SQL
            string query = @"
                    SELECT 
                        
                    FROM  
                    WHERE IdMascota = @idMascota;";

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idMascota", idMascota);

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            // Asigna el DataTable al DataGrid
                            dgvHVacunas.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar el Historial de Vacunas del Paciente: {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Metodo para limpiar los controles del formulario.
        /// </summary>
        private void LimpiarControles()
        {

            // Logica para limpiar los controles del formulario.
            txtNomDueno.Clear();            // Limpiar el nombre del dueño.
            txtTelefonoDueno.Clear();       // Limpiar el telefono del dueño.
            txtCorreoDueno.Clear();         // Limpiar el correo del dueño.
            txtDireccionDueno.Clear();      // Limpiar la dirección del dueño.
            txtNomMascota.Clear();          // Limpiar el nombre de la mascota.
            txtEspecie.Clear();             // Limpiar la especie de la mascota.
            txtRaza.Clear();                // Limpiar la raza de la mascota.
            txtSexo.Clear();                // Limpiar el sexo de la mascota.
            txtFechaNacimiento.Clear();     // Limpiar la fecha de nacimiento de la mascota.
        }

        /// <summary>
        /// metodo para volver al form veterinarioPerfil.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            veterinarioPerfil veterinarioPerfil = new veterinarioPerfil();
            this.Hide();
            veterinarioPerfil.ShowDialog();
        }
    }
}
