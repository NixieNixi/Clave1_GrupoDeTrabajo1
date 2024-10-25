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
using Clave1_GrupoDeTrabajo1.Interfaz;

namespace Clave1_GrupoDeTrabajo1
{
    public partial class Login : Form
    {
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

        }
    }
}
