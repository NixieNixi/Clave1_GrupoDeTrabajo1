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
    public partial class CitaMascota : Form
    {
        public CitaMascota()
        {
            InitializeComponent();
            ActualizarMascotas();
        }

        private void btnPerfilD_Click(object sender, EventArgs e)
        {
            //se enlaza conel perfil mediante el boton
            PerfilDueno VerDueno = new PerfilDueno();
            this.Hide();
            VerDueno.ShowDialog();
        }

        private void ActualizarMascotas()
        {
            //Limpia los elementos del comboBox ID Mascota
            cbxIDMascD.Items.Clear();

            //Intentar conectar a DB
            try
            {
                //Crea una conexion a la DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //Consulta la columna idMascota de la tabla mascotas y ordena los resultados por orden acendente
                    string query = "SELECT idMascota FROM mascotas ORDER BY idMascota ASC;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Inserta los registros de idMascota en el comboBox ID Mascota
                                cbxIDMascD.Items.Add(reader["idMascota"].ToString());
                            }
                        }
                    }
                }
            }
            catch
            {
                //Si no puede conectar mostrar mensaje de error
                MessageBox.Show("Error de conexion a Base de Datos", "Error :(");
            }
        }

        private void btnProgramarCitaD_Click(object sender, EventArgs e)
        {

            MessageBox.Show("No sirve, Ya vio", "No siga intenado, A menos que lo arregle");
            // Verificamos si el ID de mascota y los campos necesarios están seleccionados o llenados
            //if (cbxIDMascD.SelectedItem == null || string.IsNullOrEmpty(txtMotCiD.Text) || string.IsNullOrEmpty(txtEsCiD.Text))
            //{
            //    MessageBox.Show("Por favor, complete todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Obtener el ID de la mascota seleccionada desde el ComboBox
            //int idMascota = Convert.ToInt32(cbxIDMascD.SelectedItem.ToString());

            //// Usamos el idUsuario estático que ya se ha guardado
            //int idUsuario = Usuario.IdUsuario;

            //// Intentamos realizar la conexión a la base de datos
            //using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            //{
            //    // Consultamos si la mascota seleccionada pertenece al usuario actual
            //    string checkQuery = "SELECT COUNT(*) FROM mascotas WHERE idMascota = @IDMascota ;";

            //    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
            //    {
            //        checkCommand.Parameters.AddWithValue("@IDMascota", idMascota);
            //        //checkCommand.Parameters.AddWithValue("@IDUsuario", idUsuario);

            //        connection.Open();
            //        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

            //        // Si la mascota no pertenece al usuario, mostramos un mensaje de error
            //        if (count == 0)
            //        {
            //            MessageBox.Show("No tienes permiso para programar una cita para esta mascota.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //    }

            //    // Si la mascota pertenece al usuario, insertamos la cita en la base de datos
            //    string query = @"INSERT INTO citas (Fecha, Hora, Motivo, Estado, idMascota)
            //             VALUES (@Fecha, @Hora, @Motivo, @Estado, @IDMascota);";

            //    using (MySqlCommand command = new MySqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@Fecha", dtpCitaFecha.Value.Date);
            //        command.Parameters.AddWithValue("@Hora", dtpCitaHora.Value.TimeOfDay);
            //        command.Parameters.AddWithValue("@Motivo", txtMotCiD.Text);
            //        command.Parameters.AddWithValue("@Estado", txtEsCiD.Text);
            //        //command.Parameters.AddWithValue("@IDUsuario", idUsuario);
            //        command.Parameters.AddWithValue("@IDMascota", idMascota);

            //        int rowsAffected = command.ExecuteNonQuery();

            //        // Verificamos si la cita se insertó correctamente
            //        if (rowsAffected > 0)
            //        {
            //            MessageBox.Show("Cita programada correctamente.", "Operación exitosa!");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error al programar la cita.", "Error :(");
            //        }
            //    }
            //}
        }



        private void btnReprogramarCitaD_Click(object sender, EventArgs e)
        {

            MessageBox.Show("No sirve, Ya vio", "No siga intenado, A menos que lo arregle");
            //    // Verificamos si los campos necesarios están completos
            //    if (cbxIDMascD.SelectedItem == null || cbxIDCitaD.SelectedItem == null ||
            //        string.IsNullOrEmpty(txtMotCiD.Text) || string.IsNullOrEmpty(txtEsCiD.Text))
            //    {
            //        MessageBox.Show("Por favor, complete todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    // Obtener el ID de la mascota seleccionada desde el ComboBox
            //    int idMascota = Convert.ToInt32(cbxIDMascD.SelectedItem.ToString());
            //    int idCita = Convert.ToInt32(cbxIDCitaD.SelectedItem.ToString());

            //    // Intentamos realizar la conexión a la base de datos
            //    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            //    {
            //        // Consultamos si la cita y la mascota pertenecen a la base de datos
            //        string checkQuery = "SELECT COUNT(*) FROM citas WHERE idCita = @IDCita AND idMascota = @IDMascota;";

            //        using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
            //        {
            //            checkCommand.Parameters.AddWithValue("@IDMascota", idMascota);
            //            checkCommand.Parameters.AddWithValue("@IDCita", idCita);

            //            connection.Open();
            //            int count = Convert.ToInt32(checkCommand.ExecuteScalar());

            //            // Si la cita no pertenece a la mascota, mostramos un mensaje de error
            //            if (count == 0)
            //            {
            //                MessageBox.Show("Esta cita no pertenece a la mascota seleccionada.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //        }

            //        // Si la cita y la mascota están correctas, actualizamos la cita
            //        string updateQuery = @"UPDATE citas SET Fecha = @Fecha, Hora = @Hora, Motivo = @Motivo, Estado = @Estado
            //                       WHERE idCita = @IDCita AND idMascota = @IDMascota;";

            //        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
            //        {
            //            // Agregamos los parámetros para los nuevos valores
            //            updateCommand.Parameters.AddWithValue("@Fecha", dtpCitaFecha.Value.Date);
            //            updateCommand.Parameters.AddWithValue("@Hora", dtpCitaHora.Value.TimeOfDay);
            //            updateCommand.Parameters.AddWithValue("@Motivo", txtMotCiD.Text);
            //            updateCommand.Parameters.AddWithValue("@Estado", txtEsCiD.Text);
            //            updateCommand.Parameters.AddWithValue("@IDCita", idCita);
            //            updateCommand.Parameters.AddWithValue("@IDMascota", idMascota);

            //            int rowsAffected = updateCommand.ExecuteNonQuery();

            //            // Verificamos si la cita se actualizó correctamente
            //            if (rowsAffected > 0)
            //            {
            //                MessageBox.Show("Cita reprogramada correctamente.", "Operación exitosa!");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Error al reprogramar la cita.", "Error :(");
            //            }
            //        }
            //    }
        }




        private void CitaMascota_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Al presionar X en la ventana, finalizara la ejecucion total del progrma
            Application.Exit();
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No sirve, Ya vio", "No siga intenado, A menos que lo arregle");
        }
    }
}
