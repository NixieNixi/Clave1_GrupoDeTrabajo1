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
            txtIdUsuario.Text = "A10000";
            txtUsuario.Text="canela.feliz";
            txtNombre.Text = "Galleta";
            txtTelefono.Text = "60506482";
            txtEmail.Text = "galletadecanela2048@gmail.com";
            txtDireccion.Text = "Comunidad Adesco Flores, Sector #3, Casa #44, Ilopango";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
