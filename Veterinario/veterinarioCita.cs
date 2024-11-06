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
    public partial class veterinarioCita : Form
    {
        public veterinarioCita()
        {
            InitializeComponent();

            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                connection.Open();

                //Consulta la columna idExpediente de la tabla expedientes
                string query = "SELECT idExpediente FROM expedientes;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                   
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Inserta los registros de idMascota en el comboBox cbxIdMascota

                            cbxIdExpediente.Items.Add(reader["idExpediente"].ToString());
                        }
                    }
                }


            }

        }

        private void btnGuardarVeterinarioCita_Click(object sender, EventArgs e)
        {
            //Aqui se guardar los datos

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Aqui se cancelara
        }

        private void cbxIdExpediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia los controles si no se ha seleccionado una opción
            if (cbxIdExpediente.SelectedIndex == -1)
            {
                LimpiarControles();
            }
            else
            {
                // Convierte la selección de cbxIdExpedienteMascota a string y la guarda en selectedUserId
                string selecIdExpediente = cbxIdExpediente.SelectedItem.ToString();
            }
        }

        private void LimpiarControles()
        {
            txtNomMascota.Clear();
            txtIdMascota.Clear();
            txtIDCita.Clear();

        }

        /// <summary>
        /// 
        /// </summary>
        private void LimpiarInfoVacuna()
        {
            txtDescripcionVacuna.Clear();
        }

        private void LimpiarInfoExamen()
        {
            txtDescripcionExamen.Clear();

        }

        private void LimpiarInfoCirugia()
        {
            txtDescripcionCirugia.Clear();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTipoVacuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia los controles si no se ha seleccionado una opción
            if (cbxTipoVacuna.SelectedIndex == -1)
            {
                LimpiarInfoVacuna();
            }
            else
            {
                // Convierte la selección de cbxIdExpedienteMascota a string y la guarda en selectedUserId
                string selecTipoVacuna = cbxTipoVacuna.SelectedItem.ToString();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTipoExamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia los controles si no se ha seleccionado una opción
            if (cbxTipoExamen.SelectedIndex == -1)
            {
                LimpiarInfoExamen();
            }
            else
            {
                // Convierte la selección de cbxIdExpedienteMascota a string y la guarda en selectedUserId
                string selecTipoExamen = cbxTipoExamen.SelectedItem.ToString();
            }
        }

        private void cbxTipoCirugia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia los controles si no se ha seleccionado una opción
            if (cbxTipoCirugia.SelectedIndex == -1)
            {
                LimpiarInfoCirugia();
            }
            else
            {
                // Convierte la selección de cbxIdExpedienteMascota a string y la guarda en selectedUserId
                string selecTipoCirugia = cbxTipoCirugia.SelectedItem.ToString();
            }
        }



    }
}
