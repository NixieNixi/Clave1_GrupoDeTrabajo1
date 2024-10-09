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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Metodo para abrir otro form
        private void txtInicioSesion_Click(object sender, EventArgs e)
        {
            //Creacion del objeto inicio de la clase inicioSesion
            inicioSesion inicio = new inicioSesion();
            //se usa la propiedad ShowDialog del objeto creado para abrir el nuevo form
            inicio.ShowDialog();
        }
    }
}
