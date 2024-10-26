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
        ///<param name="sender">Objeto que dispara el evento, generalmente el botón.</param>
        /// <param name="e">Argumentos del evento, en este caso un evento de clic.</param>
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
            CargarDatosMascota(selectedUserId);

            // Llamamos al método para cargar los datos de citas
            string idMascota = txtIdMascota.Text; // Asegúrate de que este campo tenga el ID correcto
            CargarDatosCitas(int.Parse(idMascota));

        }

        private void CargarDatosMascota(string selectedUserId)
        {
            string query = @"
                SELECT 
                    u.Nombre AS NombreUsuario, 
                    u.Telefono, 
                    u.Correo, 
                    u.Direccion, 
                    m.IdMascota,
                    m.NombreMascota, 
                    m.Especie, 
                    m.Raza, 
                    m.Sexo, 
                    m.Peso, 
                    m.FechaNacimiento 
                FROM usuarios u
                JOIN mascotas m ON u.idUsuarios = m.IdUsuario
                WHERE u.idUsuarios = @idUsuario;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idUsuario", selectedUserId);

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
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
                                MessageBox.Show("No se encontraron datos para el ID seleccionado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show($"Error al obtener datos: {ex.Message}");
                    }

                }

            }

        }

        /// <summary>
        /// Carga los datos de citas en el DataGridView según el ID de la mascota.
        /// </summary>
        private void CargarDatosCitas(int idMascota)
        {
            string query = @"
                SELECT FechaHora, Motivo, Estado
                FROM citas
                WHERE idMascota = @idMascota;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idMascota", idMascota);

                    try
                    {
                        connection.Open();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            // Asigna el DataTable como fuente de datos del DataGridView
                            dgvHCitas.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener datos de citas: {ex.Message}");
                    }
                }
            }
        }



        private void LimpiarControles()
        {
            // Lógica para limpiar los controles del formulario
            txtNomDueno.Clear();
            txtTelefonoDueno.Clear();
            txtCorreoDueno.Clear();
            txtDireccionDueno.Clear();
            txtIdMascota.Clear();
            txtNomMascota.Clear();
            txtEspecie.Clear();
            txtRaza.Clear();
            txtSexo.Clear();
            txtPeso.Clear();
            txtFechaNacimiento.Clear();
            dgvHCitas.DataSource = null;
        }
    }
}
