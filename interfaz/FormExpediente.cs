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
    public partial class formExpediente : Form
    {
        public formExpediente()
        {
            InitializeComponent();
        }

        private void btnIrVeteExp_Click(object sender, EventArgs e)
        {
            //btn que regresa al veterinario al menuVeterinario.
            MenuVeterinario menuVeterinario = new MenuVeterinario();
            this.Hide();
            menuVeterinario.ShowDialog();
        }
    }
}
