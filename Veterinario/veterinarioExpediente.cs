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

        /// <summary>
        /// Cadena de conexion a la base de datos.
        /// </summary>
        string connectionString = "Server=localhost;Database=clave1_grupodetrabajodb1; Uid =root;Pwd=MIMAMAMEMIMA;";

        public veterinarioExpediente()
        {
            InitializeComponent();
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

        private void cbxIdExpedienteMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia los controles si no se ha seleccionado una opción
            if (cbxIdExpedienteMascota.SelectedIndex == -1)
            {
                LimpiarControles();
                return; // Salir del método si no hay selección
            }

            // Convierte la selección de cbxIdExpedienteMascota a string y la guarda en selectedUserId
            string selectedUserId = cbxIdExpedienteMascota.SelectedItem.ToString();

            // Validar que el ID seleccionado no esté vacío o nulo
            if (string.IsNullOrWhiteSpace(selectedUserId))
            {
                MessageBox.Show("Por favor, seleccione un ID de expediente válido.");
                return;
            }

            SubirDatosMascota(selectedUserId);

            // Llamamos al método para cargar los datos de citas
            string idMascota = txtIdMascota.Text; // Asegúrate de que este campo tenga el ID correcto
            SubirDatosCitas(int.Parse(idMascota));

        }


        // Metodo para cargar los datos de la mascota y el dueño según el ID de usuario seleccionado.
        private void SubirDatosMascota(string selectedUserId)
        {

            // Consulta SQL para obtener los datos del usuario y la mascota asociada.
            //Use este formato, ya que se asemeja a las de sql
            string query = @"
                               SELECT 
                    usuarios.Nombre AS NombreDelUsuario, 
                    usuarios.Telefono AS TelefonoDelUsuario, 
                    usuarios.Correo AS CorreoDelUsuario, 
                    usuarios.Direccion AS DireccionDelUsuario, 
                    mascotas.IdMascota AS IdDeLaMascota,
                    mascotas.NombreMascota AS NombreDeLaMascota, 
                    mascotas.Especie AS EspecieDeLaMascota, 
                    mascotas.Raza AS RazaDeLaMascota, 
                    mascotas.Sexo AS SexoDeLaMascota, 
                    mascotas.Peso AS PesoDeLaMascota, 
                    mascotas.FechaNacimiento AS FechaDeNacimientoDeLaMascota 
                FROM usuarios 
                JOIN mascotas ON usuarios.idUsuarios = mascotas.IdUsuario
                WHERE usuarios.idUsuarios = @idUsuario;";



            // Crear una conexión a la base de datos usando la cadena de conexion.
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                // Crear un comando para ejecutar la consulta.
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Agregar el parametro de ID de usuario a la consulta.
                    command.Parameters.AddWithValue("@idUsuario", selectedUserId);

                    try
                    {
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
                                txtNomDueno.Text = reader["NombreUsuario"].ToString();
                                txtTelefonoDueno.Text = reader["Telefono"].ToString();
                                txtCorreoDueno.Text = reader["Correo"].ToString();
                                txtDireccionDueno.Text = reader["Direccion"].ToString();

                                //gbxDatosMascota
                                txtIdMascota.Text = reader["IdMascota"].ToString();
                                txtNomMascota.Text = reader["NombreMascota"].ToString();
                                txtEspecie.Text = reader["Especie"].ToString();
                                txtRaza.Text = reader["Raza"].ToString();
                                txtSexo.Text = reader["Sexo"].ToString();
                                txtPeso.Text = reader["Peso"].ToString();
                                txtFechaNacimiento.Text = Convert.ToDateTime(reader["FechaNacimiento"]).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                // Mostrar un mensaje si no se encuentran datos.
                                MessageBox.Show("No se encontraron datos para el ID seleccionado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores: mostrar mensaje si ocurre un error al obtener datos.
                        MessageBox.Show($"Error al obtener datos: {ex.Message}");
                    }

                }

            }

        }


        /// <summary>
        /// Carga los datos de citas en el DataGridView según el ID de la mascota.
        /// </summary>
        private void SubirDatosCitas(int idMascota)
        {
            // Consulta SQL para obtener los datos de las citas de la mascota.
            string query = @"
                SELECT FechaHora, Motivo, Estado
                FROM citas
                WHERE idMascota = @idMascota;";

            // Crear una conexion a la base de datos usando la cadena de conexion.
            using (MySqlConnection connection = new MySqlConnection(connectionString))
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


        // Metodo para limpiar los controles del formulario.
        private void LimpiarControles()
        {
            // Logica para limpiar los controles del formulario.
            txtNomDueno.Clear(); // Limpiar el nombre del dueño.
            txtTelefonoDueno.Clear(); // Limpiar el telefono del dueño.
            txtCorreoDueno.Clear(); // Limpiar el correo del dueño.
            txtDireccionDueno.Clear(); // Limpiar la dirección del dueño.
            txtIdMascota.Clear(); // Limpiar el ID de la mascota.
            txtNomMascota.Clear(); // Limpiar el nombre de la mascota.
            txtEspecie.Clear(); // Limpiar la especie de la mascota.
            txtRaza.Clear(); // Limpiar la raza de la mascota.
            txtSexo.Clear(); // Limpiar el sexo de la mascota.
            txtPeso.Clear(); // Limpiar el peso de la mascota.
            txtFechaNacimiento.Clear(); // Limpiar la fecha de nacimiento de la mascota.
            dgvHCitas.DataSource = null; // Limpiar el DataGridView.
        }
    }
}
