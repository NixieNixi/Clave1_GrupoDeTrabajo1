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
    public partial class PerfilMascota : Form
    {
        public PerfilMascota()
        {
            InitializeComponent();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            CitaMascota cita = new CitaMascota();
            this.Hide();
            cita.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PerfilDueno perfil = new PerfilDueno();
            this.Hide();
            perfil.ShowDialog();
        }

        private void PerfilMascota_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
