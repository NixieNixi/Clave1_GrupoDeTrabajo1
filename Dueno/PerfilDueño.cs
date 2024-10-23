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


namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    public partial class PerfilDueño : Form
    {
        public PerfilDueño()
        {
            InitializeComponent();
        }

        private void btnIrTiendaD_Click(object sender, EventArgs e)
        {
            Tienda Comprar = new Tienda();
            Comprar.ShowDialog();
        }

        private void btnPerfilMascotaD_Click(object sender, EventArgs e)
        {
            PerfilMascota VerPerMascota = new PerfilMascota();
            VerPerMascota.ShowDialog();
        }

        private void btnCitaMascD_Click(object sender, EventArgs e)
        {
            CitaMascota VerCitas = new CitaMascota();
            VerCitas.ShowDialog();
        }

        private void PerfilDueño_Load(object sender, EventArgs e)
        {

        }
    }
}
