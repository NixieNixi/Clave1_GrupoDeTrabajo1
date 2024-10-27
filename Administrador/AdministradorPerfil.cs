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
    }
}
