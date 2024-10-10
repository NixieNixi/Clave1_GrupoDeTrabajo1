using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_GrupoDeTrabajo1
{
    public partial class LoginDueno : Form
    {
        public LoginDueno()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresoDueno_Click(object sender, EventArgs e)
        {
            MenuDueno menuDueno = new MenuDueno();
            menuDueno.ShowDialog();
            this.Hide();
        }
    }
}
