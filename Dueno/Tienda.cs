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
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
        }

        private void btnVolD_Click(object sender, EventArgs e)
        {
            //se enlaza a suboton de perfil
            PerfilDueno Vo = new PerfilDueno();
            Vo.ShowDialog();
        }
    }
}
