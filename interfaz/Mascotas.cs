using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_GrupoDeTrabajo1.interfaz
{
    public partial class Mascotas : Form
    {
        public Mascotas()
        {
            InitializeComponent();
        }

        //metodo de selleccion de mascota
        //cbxMascota permite selelcionar uno de los registros de las mascotas registradas por el dueño y alternar entre estas para ver su infomacion
        private void cbxMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Switch qye cambia el registro segun la mascota seleccionada
            switch(cbxMascota.SelectedIndex)
            {
                case -1:
                    txtMascota.Text = "Sin mascota";
                    break;
                case 0:
                    txtMascota.Text = "Tortuga";
                    break;
                case 1:
                    txtMascota.Text = "Perro";
                    break;
                case 2:
                    txtMascota.Text = "Gato";
                    break;
            }
        }

        //metodo cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
