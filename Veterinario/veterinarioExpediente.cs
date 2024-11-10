using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Clave1_GrupoDeTrabajo1.Clases;

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
    /// Modificado por: NixieNixi
    /// Fecha de Modificacion: 03/11/2024
    /// Descripcion: Se creo la clase mascota y se cambio parte del funcionamiento para un mejor rendimiento
    /// 
    ///  
    /// Modificado por: NxieNixi
    /// Fecha de Modificacion: 05/11/2024
    /// Descripcion: Se elimino el metodo de Subir Historial y en su lugar se crearon dos nuevos metodos, el de SubirHCirugia,SubirHExame
    /// y se les agrego su respectiva funcion, se realizo testeo de manera basica.
    ///</remarks>


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
                string query = "SELECT idMascota FROM mascotas ORDER BY idMascota ASC;";
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
                // Llamada al metodos;
                CargarDatosMascota(selecIdMascota);
                SubirHCitas(selecIdMascota);
                SubirHCirugia(selecIdMascota);
                SubirHVacuna(selecIdMascota);
                SubirHExamen(selecIdMascota);


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

                        // Ejecutar el comando y usa un lector para obtener los datos.
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
                                

                                // Campos de la informacion fundamental de la mascota
                                Mascota mascota = new Mascota
                                {
                                   
                                    NombreMascota = reader["NombreMascota"].ToString(),
                                    Especie = reader["Especie"].ToString(), // Ahora como string
                                    Raza = reader["Raza"].ToString(),
                                    Sexo = reader["Sexo"].ToString(),

                                };

                                

                                // Actualiza los controles de la UI con la informacion de la mascota
                                txtNomMascota.Text = mascota.NombreMascota;
                                txtEspecie.Text = mascota.Especie; 
                                txtRaza.Text = mascota.Raza;
                                txtSexo.Text = mascota.Sexo.ToString();
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
        /// <param name="selectedUserId">ID de la mascota para cargar su historial de citas.</param>
        private void SubirHCitas(string selectedUserId)
        {
            // Consulta SQL que obtiene información de las citas de la mascota
            string querycitas = @"
                SELECT DISTINCT
                    consultas.idCita, 
                    consultas.Motivo, 
                    consultas.FechaHora,
                    consultas.Sintomas, 
                    consultas.ExamenFisico, 
                    consultas.Diagnostico, 
                    consultas.Tratamiento, 
                    consultas.Medicamentos, 
                    consultas.Notas 
                FROM 
                    consultas 
                WHERE 
                    consultas.idMascota = @idMascota;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(querycitas, connection))
                    {
                        command.Parameters.AddWithValue("@idMascota", selectedUserId);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Limpia las filas existentes antes de agregar nuevas
                            dgvHCitas.Rows.Clear();

                            // Limpiar la lista de citas antes de llenarla
                            Mascota selectedMascota = new Mascota(); 
                            selectedMascota.Citas.Clear();

                            

                            while (reader.Read())
                            {
                                // Crear una nueva cita a partir de los datos leídos
                                Cita Cita = new Cita
                                {
                                    

                                    IdCita = reader.GetInt32("idCita"),
                                    Fecha = reader.GetDateTime("FechaHora"),
                                    Motivo = reader["motivo"].ToString(),
                                    Sintomas = reader["sintomas"].ToString(),
                                    ExamenFisico = reader["examenFisico"].ToString(),
                                    Diagnostico = reader["diagnostico"].ToString(),
                                    Tratamiento = reader["tratamiento"].ToString(),
                                    Medicamentos = reader["medicamentos"].ToString(),
                                    Notas = reader["notas"].ToString()
                                };

                                // Añadir la cita a la lista de citas de la mascota
                                selectedMascota.Citas.Add(Cita);

                                // Agregar la cita al DataGridView
                                dgvHCitas.Rows.Add(
                                    Cita.IdCita,
                                    Cita.Fecha,
                                    Cita.Motivo,
                                    Cita.Sintomas,
                                    Cita.ExamenFisico,
                                    Cita.Diagnostico,
                                    Cita.Tratamiento,
                                    Cita.Medicamentos,
                                    Cita.Notas
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el historial de citas: " + ex.Message);
            }

        }

        /// <summary>
        /// Metodo para subir los datos de cirugias de cada mascota
        /// </summary>
        /// <param name="selectedUserId">ID de la mascota seleccionada</param>
        private void SubirHCirugia(string selectedUserId)
        {
            string queryCirugias = @"
                    SELECT DISTINCT
                        cirugia.idCirugia, 
                        cirugia.Tipo, 
                        cirugia.Descripcion, 
                        cirugia.Motivo,
                        cirugia.FechaHora
                    FROM 
                        cirugia 
                    WHERE 
                        cirugia.idMascota = @idMascota;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(queryCirugias, connection))
                    {
                        command.Parameters.AddWithValue("@idMascota", selectedUserId);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dgvHCirugia.Rows.Clear();

                            Mascota selectedMascota = new Mascota();
                            selectedMascota.Cirugia.Clear();

                            while (reader.Read())
                            {
                                Cirugia cirugia = new Cirugia
                                {
                                    IdCirugia = reader.GetInt32("idCirugia"),
                                    FechaHoraCirugia = reader.GetDateTime("FechaHora"),
                                    Tipo = reader["Tipo"].ToString(),
                                    Descripcion = reader["Descripcion"].ToString(),
                                    Motivo = reader["Motivo"].ToString()
                                    
                                };

                                selectedMascota.Cirugia.Add(cirugia);

                                dgvHCirugia.Rows.Add(
                                    cirugia.IdCirugia,
                                    cirugia.FechaHoraCirugia,
                                    cirugia.Tipo,
                                    cirugia.Descripcion,
                                    cirugia.Motivo
                                    
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el historial de cirugías: " + ex.Message);
            }
        }






        /// <summary>
        /// Metodo para subir los datos de la DB al data grid del historial de vacunas.
        /// </summary>
        /// <param name="selectedUserId">ID de la mascota seleccionada</param>
        private void SubirHVacuna(string selectedUserId)
        {
           
            string queryVacunas = @"
                SELECT DISTINCT
                    vacuna.idVacuna, 
                    vacuna.Tipo, 
                    vacuna.Descripcion, 
                    vacuna.FechaHora,
                    vacuna.Motivo
                FROM 
                    vacuna 
                WHERE 
                    vacuna.idMascota = @idMascota;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(queryVacunas, connection))
                    {
                        command.Parameters.AddWithValue("@idMascota", selectedUserId);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dgvHVacunas.Rows.Clear();

                            Mascota selectedMascota = new Mascota();
                            selectedMascota.Vacuna.Clear();

                            while (reader.Read())
                            {
                                Vacuna vacuna = new Vacuna
                                {
                                    IdVacuna = reader.GetInt32("idVacuna"),
                                    FechaHora = reader.GetDateTime("FechaHora"),
                                    Tipo = reader["Tipo"].ToString(),
                                    Motivo = reader["Motivo"].ToString()
                                };

                                selectedMascota.Vacuna.Add(vacuna);

                                dgvHVacunas.Rows.Add(
                                    vacuna.IdVacuna,
                                    vacuna.FechaHora,
                                    vacuna.Tipo,
                                    vacuna.Motivo
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el historial de vacunas: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo para subir los datos de exámenes de la mascota al DataGridView
        /// </summary>
        /// <param name="selectedUserId">ID de la mascota seleccionada</param>
        private void SubirHExamen(string selectedUserId)
        {
            string queryExamenes = @"
                    SELECT DISTINCT
                        examen.idExamen, 
                        examen.Tipo, 
                        examen.Descripcion, 
                        examen.Motivo,
                        examen.FechaHora
                    FROM 
                        examen 
                    WHERE 
                        examen.idMascota = @idMascota;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(queryExamenes, connection))
                    {
                        command.Parameters.AddWithValue("@idMascota", selectedUserId);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dgvHExamenes.Rows.Clear();

                            Mascota selectedMascota = new Mascota();
                            selectedMascota.Examene.Clear();

                            while (reader.Read())
                            {
                                Examen examen = new Examen
                                {
                                    IdExamen = reader.GetInt32("idExamen"),
                                    FechaHora = reader.GetDateTime("FechaHora"),
                                    Tipo = reader["Tipo"].ToString(),
                                    Motivo = reader["Motivo"].ToString()
                                   
                                };

                                selectedMascota.Examene.Add(examen);

                                dgvHExamenes.Rows.Add(
                                    examen.IdExamen,
                                    examen.FechaHora,
                                    examen.Tipo,
                                    examen.Motivo
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el historial de exámenes: " + ex.Message);
            }
        }


        /// <summary>
        /// Metodo para limpiar los controles del formulario.
        /// </summary>
        private void LimpiarControles()
        {

            // Logica para limpiar los controles del formulario.
            txtNomDueno.Clear();           
            txtTelefonoDueno.Clear();      
            txtCorreoDueno.Clear();         
            txtDireccionDueno.Clear();      
            txtNomMascota.Clear();          
            txtEspecie.Clear();            
            txtRaza.Clear();                
            txtSexo.Clear();                
            txtFechaNacimiento.Clear();    
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
