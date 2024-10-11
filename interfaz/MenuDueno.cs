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
    public partial class MenuDueno : Form
    {
        public MenuDueno()
        {
            InitializeComponent();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            AgendarCita agendarCita = new AgendarCita();
            this.Hide();
            agendarCita.ShowDialog();
        }

        private void btnVerCitas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            ComprarProductos comprarProductos = new ComprarProductos();
            this.Hide();
            comprarProductos.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
