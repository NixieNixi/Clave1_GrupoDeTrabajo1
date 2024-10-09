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
    public partial class inicioSesion : Form
    {
        public inicioSesion()
        {
            InitializeComponent();
        }

        //Metodo cerrar
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo de mensaje. En teoria despues de verificar si las credenciales son correcta deberia abrir un nuevo form con otras opciones
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui deberia salir otro formulario despues del inicio de sesion");
            this.Close();
        }
    }
}
