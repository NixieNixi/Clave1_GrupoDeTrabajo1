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
    //Modificado por: RaRMustis
    public partial class MenuVeterinario : Form
    {
        public MenuVeterinario()
        {
            InitializeComponent();
        }

      

        private void BtnMenuVeteIr_Click(object sender, EventArgs e)
        {
            //Radio Btns, para selccionar historial de Vacunas o Expediente clinico de las mascotas
           if(rdbVacunas.Checked == true)
            {
                //Para el caso del historial de vacunas
                formVacunas formVacunas = new formVacunas();
                this.Hide();
                formVacunas.ShowDialog();
            }
            else
            {
                //si el caso es el expediente de la mascota
                formExpediente formExpediente = new formExpediente();
                this.Hide();
                formExpediente.ShowDialog();
            }
            
        }
    }
}
