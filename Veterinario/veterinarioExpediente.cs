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
    /// <summary>
    /// Autor: NixieNixi
    /// Fecha creacion: 21/10/2024
    /// Version: 1.0.0
    /// Descripcion: Este formulario maneja la interfaz para los expedientes de veterinarios
    /// en el sistema "Cat-Dog". Proporciona opciones para navegar hacia la sección de citas del veterinario.
    /// </summary>
    
    ///<remarks>
    ///Modificado por: NixieNixi
    ///Fecha de Modificacion:22/10/2024
    ///Descripcion: Se agrego un TapControl el cual contiene dos pestanas Informacion General y Historial Medico
    ///dentro de Informacion General se agrego lbl y txt que llevaran la informacion del dueno y mascota.
    ///dentro de Historial Medico se agrego DataGrid de historial, citas, Consultas y Vacunas,
    ///En el form veterinarioExpediente se agregaron dos btn: btnVolver y btnIrCita. ()
    ///</remarks>

    public partial class veterinarioExpediente : Form
    {
        /// <summary>
        /// Constructor del formulario veterinarioExpediente.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public veterinarioExpediente()
        {
            InitializeComponent();
        }

        // <summary>
        /// Evento click del botón 'Ir a Cita'. Este evento se activa cuando el usuario hace clic en el btn.
        /// Oculta el formulario actual y abre el formulario de veterinarioCita.
        /// </summary>
        ///<param name="sender">Objeto que dispara el evento, generalmente el botón.</param>
        /// <param name="e">Argumentos del evento, en este caso un evento de clic.</param>
        private void btnIrCita_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario veterinarioCita.
            veterinarioCita veterinarioCita = new veterinarioCita();

            // Oculta el formulario actual (veterinarioExpediente) para que no esté visible.
            this.Hide();

            // Muestra el formulario veterinarioCita como un cuadro de diálogo modal.
            // Esto significa que el formulario de citas estará activo y el formulario original
            // no podrá interactuar hasta que se cierre el nuevo formulario.
            veterinarioCita.ShowDialog();

            // Una vez que se cierra el formulario de veterinarioCita, se vuelve a mostrar el formulario original.
            this.Show();

        }
    }
}
