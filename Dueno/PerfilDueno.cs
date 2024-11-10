using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clave1_GrupoDeTrabajo1;
using MySql.Data.MySqlClient;
using Clave1_GrupoDeTrabajo1.Clases;



namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    public partial class PerfilDueno : Form
    {
        public PerfilDueno()
        {
            InitializeComponent();
        }

        private void btnIrTiendaD_Click(object sender, EventArgs e)
        {
            int idUsuario = ObtenerIdUsuarioActual();
            Tienda tienda = new Tienda(idUsuario);
            tienda.ShowDialog();
        }

        private int ObtenerIdUsuarioActual()
        {
            int idUsuario = 0;
            string nombreUsuario = "nombreUsuarioActual"; // Reemplaza con la variable que almacena el nombre de usuario logueado.

            string query = "SELECT idUsuario FROM usuarios WHERE Nombre = @Nombre";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombreUsuario);
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            idUsuario = Convert.ToInt32(resultado);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el ID del usuario.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del usuario: " + ex.Message);
            }

            return idUsuario;
        }

        


        private void btnPerfilMascotaD_Click(object sender, EventArgs e)
        {
            //se enlaza con el perfil de mascota con su boton correspondiente
            PerfilMascota VerPerMascota = new PerfilMascota();
            this.Hide();
            VerPerMascota.ShowDialog();
        }

        private void btnCitaMascD_Click(object sender, EventArgs e)
        {
            //se enlaza con su boton a la cita
            CitaMascota VerCitas = new CitaMascota();
            this.Hide();
            VerCitas.ShowDialog();
        }

        private void PerfilDueno_Load(object sender, EventArgs e)
        {
            lblNomD.Text = Usuario.Nombre;  // Muestra el nombre del usuario
            lblUsuD.Text = Usuario.IdUsuario.ToString();
        }
    }
}
