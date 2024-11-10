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

        private void AdministradorPerfil_Load(object sender, EventArgs e)
        {
            Login ventana = new Login();
            ventana.Close();
        }
    }
}
