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
    public partial class AgendarCita : Form
    {
        public AgendarCita()
        {
            InitializeComponent();
           
        }

        private void btnVolverMenuDueno_Click(object sender, EventArgs e)
        {
            //this.Close();
            MenuDueno menuDueno = new MenuDueno(); //para llamar al objeto menudueno
           this.Hide(); // ste es para que el form de agendar cita se oculte
           menuDueno.ShowDialog(); // pa abir el form 
        }
    }
}
