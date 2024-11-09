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
            ActualizarMascotas();
        }

        private void btnPerfilD_Click(object sender, EventArgs e)
        {
            //se enlaza conel perfil mediante el boton
            PerfilDueno VerDueño = new PerfilDueno();
            this.Hide();
            VerDueño.ShowDialog();
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
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                //Consulta sql para insertar un nueva cita
                string query = @"INSERT INTO citas (Fecha, Hora , Motivo, Estado, idUsuarios, idMascota)
                     VALUES (@Fecha, @Hora, @Motivo, @Estado, @IDUsuario, @IDMascota);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDUsuario", txtNomUsuD.Text);
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
                command.Parameters.AddWithValue("@IDUsuario", txtNomUsuD.Text);
                command.Parameters.AddWithValue("@Motivo", txtMotCiD.Text);
                command.Parameters.AddWithValue("@Estado", txtEsCiD.Text);

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
    }
}
