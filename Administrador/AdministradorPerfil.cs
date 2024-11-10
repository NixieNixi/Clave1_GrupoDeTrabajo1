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
        string nombreUser;
        string user;

        public AdministradorPerfil()
        {
            InitializeComponent();
        }

        public void InfoUser(string nombreadmin, string useradmin)
        {
            nombreUser = nombreadmin;
            user = useradmin;

            lblNombreAdmin.Text = nombreUser;
            lblUserAdmin.Text = user;
        }

        //Metodo para cerrar el formulario mediante el boton btnCerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
        }

        //Metodo para mostrar el panel de inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
        }

        private void AdministradorPerfil_Load(object sender, EventArgs e)
        {
            Login ventana = new Login();
            ventana.Close();
        }

        private void cbxIdMascotaMascota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxIdDueno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditM_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarM_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoM_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarM_Click(object sender, EventArgs e)
        {

        }
    }
}
