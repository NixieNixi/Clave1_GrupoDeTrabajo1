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
            //Creacion del objeto inicio de la clase inicioSesion(CanelaFeliz)
            inicioSesion inicio = new inicioSesion();
            //se usa la propiedad ShowDialog del objeto creado para abrir el nuevo form
            inicio.ShowDialog();
        }
        
        private void btnIngresoVete_Click(object sender, EventArgs e)
        {
            //Aqui iria el para abrir donde el user vete realizara su login.(NixieNixi)
        }

        private void btnIngresoAdmin_Click(object sender, EventArgs e)
        {
            //Aqui iria el para abrir donde el user Administrador realizara su login.(NixieNixi)

        }

        private void btnIngresoDueno_Click(object sender, EventArgs e)
        {
            //Aqui iria el para abrir donde el user Dueño  realizara su login.(NixieNixi)

        }
    }
}
