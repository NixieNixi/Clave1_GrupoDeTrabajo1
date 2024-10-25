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
    public partial class IniciarSesionDueno : Form
    {
        public IniciarSesionDueno()
        {
            InitializeComponent();
        }

        private void btnVolverD_Click(object sender, EventArgs e)
        {
            //sse enlaza con el menu principal mediante l boton correspondiente
            MenuPrincipalDueño VolverMenu = new MenuPrincipalDueño();
            VolverMenu.ShowDialog();
        }

        private void btnIniciarD_Click(object sender, EventArgs e)
        {
            
            //se enlaza con el perfil del dueño mediante el boton correspondiente
            PerfilDueno IniPer = new PerfilDueno();
            IniPer.ShowDialog();
        }

        private void IniciarSesionDueño_Load(object sender, EventArgs e)
        {

        }
    }
}
