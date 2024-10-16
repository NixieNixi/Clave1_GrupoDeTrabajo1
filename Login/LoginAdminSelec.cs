using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_GrupoDeTrabajo1.Login
{
    public partial class LoginAdminSelec : Form
    {
        public LoginAdminSelec()
        {
            InitializeComponent();
        }

        //Abrir la ventana de login del adminstrador del sistema
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin login = new LoginAdmin();
            login.ShowDialog();
        }

        //Abrir la ventana de login del medico veterinario
        private void btnVeterinario_Click(object sender, EventArgs e)
        {
            LoginVeterinario login = new LoginVeterinario();
            this.Visible = false;
            login.ShowDialog();
        }
    }
}
