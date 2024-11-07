using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Clave1_GrupoDeTrabajo1.Clases;

namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    /// Autor: NixieNixi
    /// Fecha creacion: 21/10/2024
    /// Version: 1.0.0
    /// Descripcion: Este formulario maneja la interfaz para los citas de veterinarios
    /// en el sistema "Cat-Dog". Proporciona opciones para navegar dentro de el.
    /// </summary>

    ///<remarks>
    ///Autor: NixieNixi
    ///Fecha de Modificacion: 24/10/2024
    ///Descripcion:
    ///Se agrego un Panel ('panelVeterinarioCita') para contener la interfaz de citas del veterinario.
    ///Se añadieron dos GroupBox: 
    ///1. gbxaInfoExpediente para organizar la información del expediente de la mascota.
    ///2. gbxInfoCita para agrupar los detalles de la cita, como sintomas, diagnostico y tratamiento.
    ///3.gbxInfoCirugia,gbxVacuna,gbxExamen
    /// Se añadieron múltiples TextBox (txt) y Label (lbl) dentro de los GroupBox para gestionar informacion datos de la mascota.
    /// En el formulario 'veterinarioExpediente' se añadieron dos botones: 'btnVolver' para regresar al menú principal
    ///y 'btnIrCita' para acceder directamente a la sección de citas.
    /// 
    /// NixieNixi
    /// Agregue la conexion a la DB y cree los metodos de los cbx de vacuna y id Expeidnete, examen,ciruagia, ademas de los metodos d elimpiar. 
    /// 
    ///</remarks>
    ///

    

    public partial class veterinarioCita : Form
    {
        public veterinarioCita()
        {
            InitializeComponent();



        }


        // Evento cuando cambia la selección de mascota en el ComboBox**
        private void cbxIdMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

       

        // Evento cuando cambia la selección de cita en el ComboBox
        private void cbxIdCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}
