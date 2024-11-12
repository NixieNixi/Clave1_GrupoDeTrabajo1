﻿using System;
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
    public partial class PerfilMascota : Form
    {
        public PerfilMascota()
        {
            InitializeComponent();
            ActualizarRegistrosMascota();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PerfilDueno perfil = new PerfilDueno();
            this.Hide();
            perfil.ShowDialog();
        }

        private void PerfilMascota_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ActualizarRegistrosMascota()
        {
            //convierte el id seleccionado del combobox
            string IdSeleccion = txtIdDueno.Text;

            try
            {
                //cadena de conexion DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //cadena de consulta DB
                    string query = "SELECT idMascota FROM mascotas WHERE idUsuario = @idUsuario";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //Agregar el parametro a la consulta
                        command.Parameters.AddWithValue("@idUsuario", IdSeleccion);

                        //Establecer conexion a DB
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            //Si se encuentran mascotas registradas mostrar los idMascota en cbxidMascota
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //Cargar los idMascota en el comboBox
                                    cbxIdMascota.Items.Add(reader["idMascota"].ToString());
                                }
                                //habilitar el comboBox
                                cbxIdMascota.Enabled = true;
                            }
                            else
                            {
                                //Si no hay mascotas se deshabilita el comboBox y se muestra un mensaje
                                cbxIdMascota.Text = "No se encontraron mascotas";
                                cbxIdMascota.Enabled = false;
                            }
                        }
                    }
                }
            }
            //Si ocurre un error al conectar o hacer la consulta mostrar mensaje de error
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error.Message, "Error :(", MessageBoxButtons.OK);
            }
        }

        private void cbxIdMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //guarda el texto de la seleccion en ConsultaIdMascota
            string ConsultaIdMascota = cbxIdMascota.SelectedItem.ToString();

            //Intentar conectar a DB y hacer la consulta del nombre de la mascota
            try
            {
                //cadena de conexion a DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //cadena de consulta a DB
                    string query = "SELECT Nombre, Raza, Especie, Sexo, FechaNacimiento FROM mascotas WHERE idMascota = @idMascota;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //Agregar el parametro a la consulta
                        command.Parameters.AddWithValue("@idMascota", ConsultaIdMascota);

                        //Conectar a DB
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            //Inserta la informacion en los controles correspondientes
                            if (reader.Read())
                            {
                                txtMascota.Text = reader["Nombre"].ToString();
                                txtRaza.Text = reader["Raza"].ToString();
                                txtEspecie.Text = reader["Especie"].ToString();
                                txtSexo.Text = reader["Sexo"].ToString();
                                dtpFecha.Value = Convert.ToDateTime(reader["FechaNacimiento"]);
                            }
                        }
                    }
                }
            }
            //Si ocurre un error al conectar o hacer la consulta mostrar mensaje de error
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error.Message, "Error :(", MessageBoxButtons.OK);
            }
        }
    }
}
