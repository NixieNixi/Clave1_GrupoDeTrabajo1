using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    public partial class AdministradorPerfil : Form
    {
        public AdministradorPerfil()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Text = "A10000";
            txtUsuario.Text = "canela.feliz";
            txtRol.Text = "Administrador";
            txtNombre.Text = "Galleta";
            txtTelefono.Text = "60506482";
            txtEmail.Text = "galletadecanela2048@gmail.com";
            txtDireccion.Text = "Comunidad Adesco Flores, Sector #3, Casa #44, Ilopango";

            panelUsuario.Visible = true;
        }
    }
}
