using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    public partial class CitaMascota : Form
    {
        public CitaMascota()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            //Aca no era perdón
        }

        private void btnPerfilD_Click(object sender, EventArgs e)
        {
            PerfilDueño VerDueño = new PerfilDueño();
            VerDueño.ShowDialog();
        }
    }
}
