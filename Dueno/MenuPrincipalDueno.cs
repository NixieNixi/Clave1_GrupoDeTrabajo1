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
    public partial class MenuPrincipalDueño : Form
    {
        public MenuPrincipalDueño()
        {
            InitializeComponent();
        }

        private void btnIniciarSesionD_Click(object sender, EventArgs e)
        {
            //se elaza mediante el boton correspondiente
            IniciarSesionDueno IniciarSesion = new IniciarSesionDueno();
            IniciarSesion.ShowDialog();
        }

        private void MenuPrincipalDueño_Load(object sender, EventArgs e)
        {

        }
    }
}
