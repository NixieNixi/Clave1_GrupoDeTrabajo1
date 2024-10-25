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

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    public partial class AdministradorPerfil : Form
    {
        private string connectionString = "Server=localhost;Database=clave1_grupodetrabajodb1; Uid=root;Pwd=MIMAMAMEMIMA;";

        public AdministradorPerfil()
        {
            InitializeComponent();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT idUsuarios FROM usuarios";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Cargar cada ID en el ComboBox
                            cbxIdUsuario.Items.Add(reader["idUsuarios"].ToString());
                        }
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            cbxIdUsuario.Text = "A10000";
            txtUsuario.Text = "canela.feliz";
            txtRol.Text = "Administrador";
            txtNombre.Text = "Galleta";
            txtTelefono.Text = "60506482";
            txtEmail.Text = "galletadecanela2048@gmail.com";
            txtDireccion.Text = "Comunidad Adesco Flores, Sector #3, Casa #44, Ilopango";

            panelInventario.Visible = false;
            panelCitas.Visible = false;
            panelUsuario.Visible = true;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            txtUsuario.ReadOnly = false;
            txtRol.Enabled = true;
            txtRol.ReadOnly = false;
            txtTelefono.Enabled = true;
            txtTelefono.ReadOnly = false;
            txtNombre.Enabled = true;
            txtNombre.ReadOnly = false;
            txtEmail.Enabled = true;
            txtEmail.ReadOnly = false;
            txtDireccion.Enabled = true;
            txtDireccion.ReadOnly = false;
        }

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            txtUsuario.ReadOnly = false;
            txtRol.Enabled = true;
            txtRol.ReadOnly = false;
            txtTelefono.Enabled = true;
            txtTelefono.ReadOnly = false;
            txtNombre.Enabled = true;
            txtNombre.ReadOnly = false;
            txtEmail.Enabled = true;
            txtEmail.ReadOnly = false;
            txtDireccion.Enabled = true;
            txtDireccion.ReadOnly = false;

            cbxIdUsuario.Text = null;
            txtUsuario.Text = null;
            txtRol.Text = null;
            txtTelefono.Text = null;
            txtNombre.Text = null;
            txtEmail.Text = null;
            txtDireccion.Text = null;
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            panelInventario.Visible = false;
            panelUsuario.Visible = false;
            panelCitas.Visible = true;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            panelCitas.Visible = false;
            panelUsuario.Visible = false;
            panelInventario.Visible = true;
        }

        private void cbxIdUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIdUsuario.SelectedIndex == -1)
            {
                cbxIdUsuario.Text = null;
                txtUsuario.Text = null;
                txtRol.Text = null;
                txtTelefono.Text = null;
                txtNombre.Text = null;
                txtEmail.Text = null;
                txtDireccion.Text = null;
            }
            else
            {
                string selectedId = cbxIdUsuario.SelectedItem.ToString();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT NombreUsuario, Telefono, correo, Direccion, Rol, Usuario, Contrasena FROM usuarios WHERE idUsuarios = @idUsuario;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idUsuario", selectedId);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Cargar los datos obtenidos en los controles correspondientes
                                txtUsuario.Text = reader["Usuario"].ToString();
                                txtRol.Text = reader["Rol"].ToString();
                                txtTelefono.Text = reader["Telefono"].ToString();
                                txtNombre.Text = reader["NombreUsuario"].ToString();
                                txtContraseña.Text = reader["Contrasena"].ToString();
                                txtEmail.Text = reader["correo"].ToString();
                                txtDireccion.Text = reader["Direccion"].ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}
