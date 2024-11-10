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
    public partial class veterinarioPerfil : Form
    {
        /// <summary>
        /// Autor de el area del Veterinario: NixieNixi
        /// Fecha de Re-Creacion: 21/10/2024
        /// Version: 1.0.01
        /// Descripcion: Esta clase nos permite visualizar las distintas areas del perfil del veterinario
        ///              como lo son veterinarioExpediente, veterinarioVacuna, veterinarioCita y el btncerrar
        ///              que regresa al menu principal
        /// </summary>/

        ///<remarks>
        /// Fecha de Modificacion: 22/10/2024
        /// Modificado Por: NixieNixi
        /// Descripcion: pediente
        /// </remarks>

        public veterinarioPerfil()
        {
            InitializeComponent();
        }

        //Mostrar el form veterinarioExpediente mediante el boton btnConsultarExpediente
        private void btnConsultarExpediente_Click(object sender, EventArgs e)
        {
            //instancia de objeto veterinarioExpediente
            veterinarioExpediente veterinarioExpediente = new veterinarioExpediente();
            this.Hide();
            veterinarioExpediente.ShowDialog();
            // Vuelve a mostrar el formulario cuando se cierre el otro
            this.Show(); 
            
        }

    
       

        //Mostrar el form veterinarioCita mediante el boton btnCita
        private void btnCita_Click(object sender, EventArgs e)
        {
            //instancia de objeto 
            veterinarioCita veterinarioCita = new veterinarioCita();
            //Oculta el formulario actual
            this.Hide();
            //Abre el formulario veterinarioCita
            veterinarioCita.ShowDialog();
            this.Show();

        }

        //Mostrar el menu principal mediante el boton btnCerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Cerrar sesion y vouelve al menu principal
            MenuPrincipal menu = new MenuPrincipal();
            //Ocultar el formulario actual
            this.Hide();
            //Mostrar el formulario del menú principal
            menu.Show();

        }

        private void veterinarioPerfil_Load(object sender, EventArgs e)
        {

        }
    }
}
