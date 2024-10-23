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
    public partial class IniciarSesionDueño : Form
    {
        public IniciarSesionDueño()
        {
            InitializeComponent();
        }

        private void btnVolverD_Click(object sender, EventArgs e)
        {
            MenuPrincipalDueño VolverMenu = new MenuPrincipalDueño();
            VolverMenu.ShowDialog();
        }

        private void btnIniciarD_Click(object sender, EventArgs e)
        {
            PerfilDueño IniPer = new PerfilDueño();
            IniPer.ShowDialog();
        }
    }
}
