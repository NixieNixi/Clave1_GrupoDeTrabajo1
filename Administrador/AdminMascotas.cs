using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    /// <summary>
    /// Autor: CanelaFeliz
    /// Fecha: 30/10/24
    /// Desccripcion: Parte de la clase Administrador perfil que se encarga de las funciones del panel AdminMascotas donde
    /// se realizan las operaciones de gestion de mascotas (Consultar, Modificar, Crear y Eliminar mascotas)
    /// </summary>

    ///<remarks>
    ///Modificado por: CanelaFeliz
    ///Fecha de modificacion: 31/10/24
    ///Descripcion: Funcio de consulta de informacion completa
    ///Falta Fuciones de editar, crear y borrar
    ///</remarks>
    public partial class AdministradorPerfil
    {
        bool habilitar = false;

        /// <summary>
        /// Evento Click del boton 'Mascotas'
        /// Oculta el resto de paneles y los desacopla de la ventana para que los paneles de las funciones de mascotas tomen
        /// su posicion correctamnte.
        /// 
        /// Carga inicial al combobox los idUsuario
        /// </summary>
        private void btnMascotas_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
            panelBtnUsuarios.Visible = false;
            panelBtnUsuarios.Dock = DockStyle.None;

            panelBtnMascota.Dock = DockStyle.Bottom;
            panelBtnMascota.Visible = true;
            panelMascotas.Dock = DockStyle.Fill;
            panelMascotas.Visible = true;

            ActualizarRegistrosDueno();
        }

        private void btnEditM_Click(object sender, EventArgs e)
        {
            btnGuardarM.Enabled = true;
            btnNuevoM.Enabled = false;
            habilitar = true;
            HabilitarEdicionM(true);
        }

        private void btnNuevoM_Click(object sender, EventArgs e)
        {
                btnGuardarM.Enabled = true;
                btnEditM.Enabled = false;
                habilitar = true;

                LimpiarMascota();
                HabilitarEdicionM(true);
        }

        /// <summary>
        /// Evento de Cambio de Seleccion de Elemento del combobox 'ID Usuario'
        /// Dependiendo de la seleccion del combobox:
        /// 
        /// Sin seleccion: Limpia los controles y deshablita el boton de editar porque no habria mascota seleccionada
        /// para editar su informacion
        /// 
        /// Con seleccion:
        /// 1. Muestra el nombre de usuario con le id seleccionado
        /// 2. Verifica si el usuario tiene mascotas registradas. En caso de tenerlas carga sus id en el combobox 'ID Mascota'
        /// En caso de no tener mascotas deshabilita el combobox y muestra un mensaje
        /// </summary>
        private void cbxIdDueno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIdDueno.SelectedIndex == -1)
            {
                //Limpiar controles
                LimpiarMascota();

                //Deshablitar la funcion de editar
                btnEditM.Enabled = false;
                btnNuevoM.Enabled = false;
            }
            else
            {
                btnNuevoM.Enabled = true;
                //convierte el id seleccionado del combobox
                string IdSeleccion = cbxIdDueno.SelectedItem.ToString();

                try
                {
                    //cadena de conexion DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta DB
                        string query = "SELECT Nombre FROM usuarios WHERE idUsuario = @idUsuario;";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            //Agregar el parametro a la consulta
                            command.Parameters.AddWithValue("@idUsuario", IdSeleccion);

                            //Establecer conexion a DB
                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtNombreDueno.Text = reader["Nombre"].ToString();
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
            if (habilitar == false)
            {
                ActualizarRegistrosMascota();
            }
        }

        /// <summary>
        /// Evento de Cambio de Seleccion de Elemento del combobox 'ID Mascota'
        /// Dependiendo de la seleccion del combobox:
        /// 
        /// Sin seleccion: Limpia los controles.
        /// Con seleccion: Muestra la informacion de la mascota seleccionada
        /// </summary>
        private void cbxIdMascotaMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si no se ha seleccionado ninguna opcion se limpian los controles
            if (cbxIdMascotaM.SelectedIndex == -1)
            {
                LimpiarMascota();
            }
            //Dependiendo de la seleccion de idMascota se muestra un nombre
            else
            {
                btnEditM.Enabled = true;
                //guarda el texto de la seleccion en ConsultaIdMascota
                string ConsultaIdMascota = cbxIdMascotaM.SelectedItem.ToString();

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
                                    txtNombreMascotaM.Text = reader["Nombre"].ToString();
                                    txtRazaM.Text = reader["Raza"].ToString();
                                    txtEspecieM.Text = reader["Especie"].ToString();
                                    txtSexoM.Text = reader["Sexo"].ToString();
                                    dtpFechaNacimiento.Value = Convert.ToDateTime(reader["FechaNacimiento"]);
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

        /// <summary>
        /// Metodo que carga y actualiza los idUsuario en el combobox al abrir el panel, guardar nueva mascota o editar
        /// </summary>
        private void ActualizarRegistrosDueno()
        {
            //Limpia los elementos del comboBox ID Usuario
            cbxIdUsuario.Items.Clear();

            //Intentar conectar a DB
            try
            {
                //Crea una conexion a la DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //Consulta la columna idUsuarios de la tabla Usuarios que tengan rol de 'Dueño'
                    string query = "SELECT idUsuario FROM usuarios WHERE rol = 'Dueño';";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Inserta los registros de idUsuario en el comboBox cbxUsuario
                                cbxIdDueno.Items.Add(reader["idUsuario"].ToString());
                            }
                        }
                    }
                }
            }
            catch
            {
                //Si no puede conectar mostrar mensaje de error
                MessageBox.Show("No hay sistema xd", "Error :(");

                //Cerrar menu de administracion de usuarios
                panelMascotas.Visible = false;
                panelBtnMascota.Visible = false;
            }
        }

        /// <summary>
        /// Metodo que actualiza los idMascota en caso de agregar nueva mascota o editarla
        /// </summary>
        private void ActualizarRegistrosMascota()
        {
            //convierte el id seleccionado del combobox
            string IdSeleccion = cbxIdDueno.SelectedItem.ToString();

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
                            //Limpiar los controles por si habia un registro cargado
                            LimpiarMascota();

                            //Si se encuentran mascotas registradas mostrar los idMascota en cbxidMascota
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //Cargar los idMascota en el comboBox
                                    cbxIdMascotaM.Items.Add(reader["idMascota"].ToString());
                                }
                                //habilitar el comboBox
                                cbxIdMascotaM.Enabled = true;
                            }
                            else
                            {
                                //Si no hay mascotas se deshabilita el comboBox y se muestra un mensaje
                                cbxIdMascotaM.Text = "No se encontraron mascotas";
                                cbxIdMascotaM.Enabled = false;
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

        /// <summary>
        /// Metodo de limpieza de los controles del panel de la informacion de la mascota
        /// </summary
        private void LimpiarMascota()
        {
            cbxIdMascotaM.Text = null;
            cbxIdMascotaM.Items.Clear();
            txtNombreMascotaM.Text = null;
            txtRazaM.Text = null;
            txtEspecieM.Text = null;
            txtSexoM.Text = null;

            //Como DateTimePicker no tiene un valor vacio se coloca la fecha de hoy
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        private void HabilitarEdicionM(bool habilitar)
        {
            //Desahabilta ID Mascota
            cbxIdMascotaM.Enabled = !habilitar;

            //Habilita los controles
            txtUsuario.Enabled = habilitar;
            cbxIdDueno.Enabled = habilitar;
            txtNombreMascotaM.Enabled = habilitar;
            txtEspecieM.Enabled = habilitar;
            txtRazaM.Enabled = habilitar;
            txtSexoM.Enabled = habilitar;
            dtpFechaNacimiento.Enabled = habilitar;

            //Permite la edicion del contenido de los controles
            txtUsuario.ReadOnly = !habilitar;
            txtNombreMascotaM.ReadOnly = !habilitar;
            txtEspecieM.ReadOnly = !habilitar;
            txtRazaM.ReadOnly = !habilitar;
            txtSexoM.ReadOnly = !habilitar;
        }
    }
}
