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
    /// <summary>
    /// Autores: NixieNixi y CanelaFeliz
    /// </summary>
    /// 

    ///<remarks>
    ///Autor: NixeNixi
    ///Fecha: 10/11/2024
    ///Descipcion:
    ///Se agrego toda la funcionabilidad
    ///</remarks>
    public partial class PerfilDueno : Form
    {
        public PerfilDueno()
        {
            InitializeComponent();
        }

        private void btnIrTiendaD_Click(object sender, EventArgs e)
        {
            int idUsuario = Usuario.IdUsuario;  

            if (idUsuario != 0) 
            {
                
                Tienda tienda = new Tienda(idUsuario);
                tienda.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El ID del usuario no fue encontrado. Asegúrate de estar logueado correctamente.", "Error");
            }
        }

        private int ObtenerIdUsuarioActual()
        {
            int idUsuario = 0;
            string nombreUsuario = Usuario.Nombre; 

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
            int idUsuario = Usuario.IdUsuario; 
            //se enlaza con el perfil de mascota con su boton correspondiente
            PerfilMascota VerPerMascota = new PerfilMascota(idUsuario);
           
            this.Hide();
            VerPerMascota.ShowDialog();
        }

        private void btnCitaMascD_Click(object sender, EventArgs e)
        {

            int idUsuario = Usuario.IdUsuario;

            if (idUsuario != 0)
            {

                //se enlaza con su boton a la cita
                CitaMascota cita = new CitaMascota(idUsuario);
                cita.RecibirInfoUser(idUsuario);
                this.Hide();
                cita.ShowDialog();
            }
            else
            {
                MessageBox.Show("El ID del usuario no fue encontrado. Asegúrate de estar logueado correctamente.", "Error");
            }
           
        }

        private void PerfilDueno_Load(object sender, EventArgs e)
        {
            lblNomD.Text = Usuario.Nombre;  // Muestra el nombre del usuario
            lblIduser.Text = Usuario.IdUsuario.ToString();
        }

        private void btnCerrarSeD_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void PerfilDueno_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Al presionar X en la ventana, finalizara la ejecucion total del progrma
            Application.Exit();
        }
    }
}
