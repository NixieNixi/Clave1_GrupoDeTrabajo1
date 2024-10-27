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
    ///</remarks>

    public partial class veterinarioExpediente : Form
    {
        /// <summary>
        /// Constructor del formulario veterinarioExpediente.
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

        // <summary>
        /// Evento click del botón 'Ir a Cita'. Este evento se activa cuando el usuario hace clic en el btn.
        /// Oculta el formulario actual y abre el formulario de veterinarioCita.
        /// </summary>
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
                string selectedUserId = cbxIdMascota.SelectedItem.ToString();

                SubirDatosMascota(selectedUserId);

                //// Llamamos al método para cargar los datos de citas
                //string idMascota = txtIdMascota.Text; // Asegúrate de que este campo tenga el ID correcto
                //SubirHCitas(int.Parse(idMascota)); //Pertene al tap2
            }
        }

        /// <summary>
        /// Metodo para cargar los datos de la mascota y el dueño según el ID de usuario seleccionado.
        /// </summary>
        /// <param name="selectedUserId"></param>
        private void SubirDatosMascota(string selectedUserId)
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
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))  // Crear una conexión a la base de datos usando la cadena de conexion.
            {

                // Crear un comando para ejecutar la consulta.
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agregar el parametro de ID de usuario a la consulta.
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
                            //gbxDatosDueno
                                txtIdDuenoExp.Text = reader["idUsuario"].ToString();
                                txtNomDueno.Text = reader["Nombre"].ToString();
                                txtTelefonoDueno.Text = reader["Telefono"].ToString();
                                txtCorreoDueno.Text = reader["Correo"].ToString();
                                txtDireccionDueno.Text = reader["Direccion"].ToString();

                                txtNomMascota.Text = reader["NombreMascota"].ToString();
                                txtEspecie.Text = reader["Especie"].ToString();
                                txtRaza.Text = reader["Raza"].ToString();
                                txtSexo.Text = reader["Sexo"].ToString();
                                txtFechaNacimiento.Text = Convert.ToDateTime(reader["FechaNacimiento"]).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                // Mostrar un mensaje si no se encuentran datos.
                                MessageBox.Show("No se encontraron datos para el ID seleccionado.");
                            }
                        }
                }

            }

        }
        //Fin TapInformacionGeneral


        //Inicio TapHistorialMedico
        /// <summary>
        /// Carga los datos de citas en el DataGridView según el ID de la mascota.
        /// </summary>
        private void SubirHCitas(int idMascota)
        {
            // Consulta SQL para obtener los datos de las citas de la mascota.
            string query = @"
                SELECT 
                FROM 
                WHERE idMascota = @idMascota;";

            // Crear una conexion a la base de datos usando la cadena de conexion.
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                // Crear un comando para ejecutar la consulta.
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agregar el parametro de ID de mascota a la consulta.
                    command.Parameters.AddWithValue("@idMascota", idMascota);

                    try
                    {
                        // Abrir la conexión a la base de datos.
                        connection.Open();

                        // Crear un adaptador para llenar un DataTable con los datos de la consulta.
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            // Crear un nuevo DataTable.
                            DataTable dt = new DataTable();
                            // Llenar el DataTable con los datos de la consulta.
                            adapter.Fill(dt);
                            // Asigna el DataTable como fuente de datos del DataGridView.
                            dgvHCitas.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores: mostrar mensaje si ocurre un error al obtener datos.
                        MessageBox.Show($"Error al obtener datos de citas: {ex.Message}");
                    }
                }
            }
        }

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
            txtNomDueno.Clear(); // Limpiar el nombre del dueño.
            txtTelefonoDueno.Clear(); // Limpiar el telefono del dueño.
            txtCorreoDueno.Clear(); // Limpiar el correo del dueño.
            txtDireccionDueno.Clear(); // Limpiar la dirección del dueño.
            txtNomMascota.Clear(); // Limpiar el nombre de la mascota.
            txtEspecie.Clear(); // Limpiar la especie de la mascota.
            txtRaza.Clear(); // Limpiar la raza de la mascota.
            txtSexo.Clear(); // Limpiar el sexo de la mascota.
            txtFechaNacimiento.Clear(); // Limpiar la fecha de nacimiento de la mascota.
            dgvHCitas.DataSource = null; // Limpiar el DataGridView.

        }
    }
}
