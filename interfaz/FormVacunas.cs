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
    public partial class formVacunas : Form
    {
        public formVacunas()
        {
            InitializeComponent();
        }

        private void btnIrVeteVac_Click(object sender, EventArgs e)
        {
            //Regresa al Menu Veterinario.
           MenuVeterinario menuVeterinario = new MenuVeterinario();
            this.Hide();
            menuVeterinario.ShowDialog();
            //Si se puede
            //Mi mama me mima a los 37. Metas ami me reganan :c
            //un saludo a todo el mundo, mi gente latinooo.
        }
    }
}
