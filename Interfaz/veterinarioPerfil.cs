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
        /// Fecha de Modificacion: 
        /// Modificado Por: NixieNixi
        /// </remarks>

        public veterinarioPerfil()
        {
            InitializeComponent();
        }

        private void btnConsultarExpediente_Click(object sender, EventArgs e)
        {
            //
            veterinarioExpediente veterinarioExpediente = new veterinarioExpediente();
            this.Hide();
            veterinarioExpediente.ShowDialog();

            // Vuelve a mostrar el formulario cuando se cierre el otro
            this.Show(); 
            
        }

        private void btnConsultarVacunas_Click(object sender, EventArgs e)
        {
            //
            veterinarioVacuna veterinarioVacuna = new veterinarioVacuna();

            // Oculta el formulario actual
            this.Hide();

            veterinarioVacuna.ShowDialog();
            this.Show();

        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            //
            veterinarioCita veterinarioCita = new veterinarioCita();
            this.Hide();
            veterinarioCita.ShowDialog();
            this.Show();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cerrar sesion y vouelve al menu principal
            MenuPrincipal menu = new MenuPrincipal();

            this.Hide(); // Ocultar el formulario actual

            menu.Show(); // Mostrar el formulario del menú principal

        }
    }
}
