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
    public partial class CitaMascota : Form
    {
        public CitaMascota()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            //Aca no era perdón
        }

        private void btnPerfilD_Click(object sender, EventArgs e)
        {
            //se enlaza conel perfil mediante el boton
            PerfilDueno VerDueño = new PerfilDueno();
            VerDueño.ShowDialog();
        }

        private void CitaMascota_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnProgramarCitaD_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                //Consulta sql para insertar un nueva cita
                string query = @"INSERT INTO citas (Fecha, Hora , Motivo, Estado, idUsuarios, idMascota)
                     VALUES (@Fecha, @Hora, @Motivo, @Estado, @IDUsuario, @IDMascota);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDUsuario", txtIDUsuD.Text);
                    command.Parameters.AddWithValue("@IDMascota", txtIDMascD.Text);
                    command.Parameters.AddWithValue("@Motivo", txtMotCiD.Text);
                    command.Parameters.AddWithValue("@Estado", txtEsCiD.Text);
                    command.Parameters.AddWithValue("@Fecha", dtpCitaFecha.Value.Date);
                    command.Parameters.AddWithValue("@Hora", dtpCitaHora.Value.TimeOfDay);

                    connection.Open();

                    //variable para comprobar cuantas filas fueron agregadas
                    int rowsAffected = command.ExecuteNonQuery();

                    //Comprobar si la inserción fue exitosa, si rowsAffected es mayor que 0 significa que al menos una fila fue agregada
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario ingresado correctamente.", "Operacion exitosa!");
                    }
                    //Si no se cambio ninguna fila mostrar mensaje de error
                    else
                    {
                        MessageBox.Show("Error al ingresar el usuario.", "Error :(");
                    }
                }
            }

        }

        private void btnRepreogramarCitaD_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(@"INSERT INTO citas (FechaHora, Motivo, Estado, idUsuarios, idMascota)
                     VALUES (@FechaHora, @Motivo, @Estado, @IDUsuario, @IDMascota)", connection);

                // Asigna los valores nuevos
                command.Parameters.AddWithValue("@IDUsuario", txtIDUsuD.Text);
                command.Parameters.AddWithValue("@IDMascota", txtIDMascD.Text);
                command.Parameters.AddWithValue("@Motivo", txtMotCiD.Text);
                command.Parameters.AddWithValue("@Estado", txtEsCiD.Text);
                command.Parameters.AddWithValue("@FechaHora", txtFeHoCiD.Text);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cita reprogramada exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al reprogramar la cita.");
                }
            }
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            txtEsCiD.Text = "";
            txtFeHoCiD.Text = "";
            txtIDMascD.Text = "";
            txtIDUsuD.Text = "";
            txtMotCiD.Text = "";

        }
    }

    }
