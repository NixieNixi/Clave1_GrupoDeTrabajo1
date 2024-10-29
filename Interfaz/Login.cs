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
using Clave1_GrupoDeTrabajo1.Administrador;
using Clave1_GrupoDeTrabajo1.Interfaz;
using MySql.Data.MySqlClient;

namespace Clave1_GrupoDeTrabajo1
{
    /// <summary>
    /// Autores: NixieNixe, CanelaFeliz
    /// </summary>
    /// 
    ///<remarks>
    ///Fecha de Modificacion: 24/10/2024
    ///Autor: NixieNixi
    ///Descripcion: Agregue la DB y agregue el btnIngresar y su funcionamiento que segun las credenciales ingresadas asi sera al form que lo llevara.
    ///actualemte solo permite para veterinario y dueno, ya que en mi rama (Nixie) no me aparece la parte del Administrador. Falta Documentacion Interna.
    /// </remarks>
    public partial class Login : Form
    {
        string connectionString = "Server=localhost;Database=clave1_grupodetrabajodb1; Uid =root;Pwd=MIMAMAMEMIMA;";
        

        public Login()
        {
            InitializeComponent();
        }

        //Metodo para volver al menu principal
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
        }

        //Metodo para abrir el perfil de Dueño
        private void btnDueño_Click(object sender, EventArgs e)
        {
            PerfilDueno VerDueñoPerfil = new PerfilDueno();
            this.Hide();
            VerDueñoPerfil.ShowDialog();
        }

        //Metodo para abrir el perfil del veterinario
        private void btnVeterinario_Click(object sender, EventArgs e)
        {
            veterinarioPerfil veterinarioPerfil = new veterinarioPerfil();
            this.Hide();
            veterinarioPerfil.ShowDialog();
        }

        //Metodo para abrir el perfil del Administrador
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdministradorPerfil administrador = new AdministradorPerfil();
            this.Hide();
            administrador.ShowDialog();
            this.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            // Obtener los valores del formulario
            // Obtener los valores del formulario
            string usuario = txtLoginUser.Text; // Nombre de usuario
            string contrasena = txtLoginContra.Text; // Contraseña
            //string nombre;

            // Consulta para obtener la contraseña y el rol del usuario
            string query = "SELECT contrasena, Rol FROM usuarios WHERE Usuario = @usuario";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener la contraseña y el rol de la base de datos
                            string storedPassword = reader["Contrasena"].ToString();
                            string rol = reader["Rol"].ToString();

                                 

                            // Comparar la contraseña ingresada con la almacenada
                            if (contrasena == storedPassword)
                            {
                                // Redirigir según el rol del usuario
                                switch (rol)
                                {
                                    case "Veterinario":
                                        veterinarioPerfil veterinarioPerfil = new veterinarioPerfil();
                                        veterinarioPerfil.Show();
                                        this.Hide();
                                        break;

                                    case "Dueno":
                                        PerfilDueno perfilDueno = new PerfilDueno();
                                        perfilDueno.Show();
                                        this.Hide();
                                        break;

                                   case "Administrador":
                                        AdministradorPerfil menuAdmin = new AdministradorPerfil();
                                        menuAdmin.Show();
                                        this.Hide();
                                        break;
                                    default:
                                        MessageBox.Show("Rol no válido.");
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta.");
                            }

                            

                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado.");
                        }
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
