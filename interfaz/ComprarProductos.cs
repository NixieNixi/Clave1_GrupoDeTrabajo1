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
    public partial class ComprarProductos : Form
    {
        int i = 0;
        
        public ComprarProductos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuDueno menu = new MenuDueno();
            menu.ShowDialog();
        }

        private int Mas() => i++;
        private int Menos() => i--;

        private void btnProd1Mas_Click(object sender, EventArgs e)
        {
            txtProducto1.Text = Convert.ToString(i);
            Menos();
        }
    }
}
