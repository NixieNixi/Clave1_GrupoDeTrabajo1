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
    public partial class PerfilDueno : Form
    {
        public PerfilDueno()
        {
            InitializeComponent();
        }

        private void btnIrTiendaD_Click(object sender, EventArgs e)
        {
           //se enlaza con la tienda mediantte el boton correspondiente 
            Tienda Comprar = new Tienda();
            this.Hide();
            Comprar.ShowDialog();
        }

        private void btnPerfilMascotaD_Click(object sender, EventArgs e)
        {
            //se enlaza con el perfil de mascota con su boton correspondiente
            PerfilMascota VerPerMascota = new PerfilMascota();
            this.Hide();
            VerPerMascota.ShowDialog();
        }

        private void btnCitaMascD_Click(object sender, EventArgs e)
        {
            //se enlaza con su boton a la cita
            CitaMascota VerCitas = new CitaMascota();
            this.Hide();
            VerCitas.ShowDialog();
        }
    }
}
