using Clave1_GrupoDeTrabajo1.interfaz;
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
               
        //Metodo de cierre de sesion. redirige al menu principal
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Este metodo permitiria abrir una ventana donde al Dueño pueda editar informacion personal tal como el numero de telefono o el email
        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un saludo al grupo");
        }

        //Este metodo permitiria abrir una ventana donde pueda ver las citas que tiene agendadas, editarlas o crear una nueva
        private void btnCitas_Click(object sender, EventArgs e)
        {
            VerCitas verCitas = new VerCitas();
            this.Hide();
            verCitas.ShowDialog();
        }

        //Comprar productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            ComprarProductos comprarProductos = new ComprarProductos();
            this.Hide();
            comprarProductos.ShowDialog();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            Mascotas mascotas = new Mascotas();
            mascotas.ShowDialog();
        }
    }
}
