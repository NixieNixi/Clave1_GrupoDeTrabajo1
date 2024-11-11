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
    /// Fecha: 07/11/24
    /// Desccripcion: Parte de la clase AdministradorPerfil que se encarga de las funciones del panel
    /// </summary>

    ///<remarks> 
    ///Modificado por: CanelaFeliz
    ///Fecha de modificacion: 10/11/24
    ///Descripcion: Funcion AdminPagos completa
    ///</remarks>
    public partial class AdministradorPerfil
    {
        /// <summary>
        /// Boton Pagos que oculta el resto de paneles y muestra los paneles de las funciones de pagos y carga los id usuario
        /// </summary>
        private void btnPagos_Click(object sender, EventArgs e)
        {
            //Se oculta el resto de los paneles
            panelMascotas.Visible = false;
            panelMascotas.Dock = DockStyle.None;
            panelBtnMascota.Visible = false;
            panelBtnMascota.Dock = DockStyle.None;
            panelCitas.Visible = false;
            panelCitas.Dock = DockStyle.None;
            panelBtnCitas.Visible = false;
            panelBtnCitas.Dock = DockStyle.None;
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
            panelBtnUsuarios.Visible = false;
            panelBtnUsuarios.Dock = DockStyle.None;
            panelInventario.Visible = false;
            panelInventario.Dock = DockStyle.None;
            panelBtnInventario.Visible = false;
            panelBtnInventario.Dock = DockStyle.None;

            //Se muestran los paneles de Pagos
            panelBtnPagos.Dock = DockStyle.Bottom;
            panelBtnPagos.Visible = true;
            panelPagos.Dock = DockStyle.Fill;
            panelPagos.Visible = true;

            //Cargar los idUsuario en el combobox ID Dueño
            CargarUsuarios();
        }

        /// <summary>
        /// Funcion que carga los idUsuario con rol de Dueño en el combobox
        /// </summary>
        private void CargarUsuarios()
        {
            //Limpia los elementos del comboBox ID Dueño
            cbxIdDuenoP.Items.Clear();

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
                                cbxIdDuenoP.Items.Add(reader["idUsuario"].ToString());
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Si no puede conectar mostrar mensaje de error
                MessageBox.Show("Error de conexion a Base de datos", "Error :(" + ex.Message);

                //Cerrar menu de administracion de usuarios
                panelPagos.Visible = false;
                panelBtnPagos.Visible = false;
            }
        }

        /// <summary>
        /// Evento de cambio de seleccion del combobox id dueño que cambia el nombre del dueño y los id de los pagos pendientes de ese dueño
        /// </summary>
        private void cbxIdDuenoP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIdDuenoP.SelectedIndex == -1)
            {
                //Limpiar controles
                LimpiarPagos();
                //deshabilitar botones de registrar y guardar porque no hay dueño ni pago seleccionado
                btnRegistrarP.Enabled = false;
                btnGuardarP.Enabled = false;
            }
            else
            {

                //convierte el id seleccionado del combobox
                string IdSeleccion = cbxIdDuenoP.SelectedItem.ToString();

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
                                    txtNombreP.Text = reader["Nombre"].ToString();
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
            //Carga los id pagos en el combobox
            CargarPagos();
        }

        /// <summary>
        /// Funcion que carga los id pago en el combobox, si no encuentra registros de pagos para el usuario desahbilita el combobox
        /// </summary>
        private void CargarPagos()
        {
            //convierte el id seleccionado del combobox
            string IdSeleccion = cbxIdDuenoP.SelectedItem.ToString();

            try
            {
                //cadena de conexion DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //cadena de consulta DB
                    string query = "SELECT idPago FROM pagos WHERE idUsuario = @idUsuario AND Estado = 'Pendiente'";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //Agregar el parametro a la consulta
                        command.Parameters.AddWithValue("@idUsuario", IdSeleccion);

                        //Establecer conexion a DB
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            //Limpiar los controles por si habia un registro cargado
                            LimpiarPagos();

                            //Si se encuentran mascotas registradas mostrar los idMascota en cbxidMascota
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //Cargar los idMascota en el comboBox
                                    cbxIdPago.Items.Add(reader["idPago"].ToString());
                                }
                                //habilitar el comboBox
                                cbxIdPago.Enabled = true;
                            }
                            else
                            {
                                cbxIdPago.Enabled = false;
                                cbxIdPago.Text = "No se encontraron pagos";
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
        /// Funcion que limpia la informacion de los controles
        /// </summary>
        private void LimpiarPagos()
        {
            cbxIdPago.Text = null;
            cbxIdPago.Items.Clear();
            cbxEstadoP.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;
            dtpFechaP.Value = DateTime.Now;
            cbxFormaPago.SelectedIndex = -1;
            txtTipoServicio.Clear();
            txtTotalP.Clear();
        }

        /// <summary>
        /// Evento de cambio de seleccion del combobox idPago que carga la informacion del pago en los controles
        /// </summary>
        private void cbxIdPago_SelectedIndexChanged(object sender, EventArgs e)

        {
            //Si no se ha seleccionado ninguna opcion se limpian los controles
            if (cbxIdPago.SelectedIndex == -1)
            {
                LimpiarPagos();
            }
            //Dependiendo de la seleccion de pago
            else
            {
                //guarda el texto de la seleccion en consultaIDPago
                string consultaIDPago = cbxIdPago.SelectedItem.ToString();

                //Intentar conectar a DB y hacer la consulta del nombre de la mascota
                try
                {
                    //cadena de conexion a DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta a DB
                        string query = "SELECT Fecha, Estado, Total, TipoPago, TipoServicio FROM pagos WHERE idPago = @idPago;";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            //Agregar el parametro a la consulta
                            command.Parameters.AddWithValue("@idPago", consultaIDPago);

                            //Conectar a DB
                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    //si se ha seleccionado un pago habilita el boton registrar
                                    btnRegistrarP.Enabled = true;

                                    //Inserta la informacion en los controles correspondientes
                                    if (reader.Read())
                                    {
                                        dtpFechaP.Value = (DateTime)reader["Fecha"];
                                        string estado = reader["Estado"].ToString();
                                        if (estado == "Pendiente")
                                        {
                                            cbxEstadoP.SelectedIndex = 0;
                                        }
                                        txtTotalP.Text = "$" + reader["Total"].ToString();
                                        string formaPago = reader["TipoPago"].ToString();
                                        if (formaPago == "Sin pagar")
                                        {
                                            cbxFormaPago.SelectedIndex = 0;
                                        }
                                        txtTipoServicio.Text = reader["TipoServicio"].ToString();
                                    }
                                }
                                else
                                {
                                    //si no hay registro se deshabilita el boton registrar
                                    btnRegistrarP.Enabled = false;
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
        /// Funcion que llama al metodo de edicion para seleccionar una forma de pago
        /// </summary>
        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            PagosEdicion(true);
        }

        /// <summary>
        /// Evento del boton cancelar que limpia los controles, recupera la informacion si se ha modificado y deshabilta los controles
        /// </summary>
        private void btnCancelarP_Click(object sender, EventArgs e)
        {
            PagosEdicion(false);
            cbxIdPago_SelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Evento del boton que registra el pago cambiando su estado y forma de pago
        /// </summary>
        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            //Consulta sql para actualizar los datos de la mascota
            string query = @"UPDATE pagos
                            SET Estado = 'Pagado', 
                                TipoPago = @TipoPago
                          WHERE idPago = @idPago;";

            //Realizar la actualización en la base de datos
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        if (cbxFormaPago.SelectedIndex == 0)
                        {
                            MessageBox.Show("Seleccione un tipo de pago", "Error", MessageBoxButtons.OK);
                            tool.Show("Por favor seleccione una forma de pago.", cbxFormaPago, 0, -20, 3000);
                            return;
                        }
                        //si no hay errores en los datos asignar los parametros con los datos del form
                        else
                        {
                            command.Parameters.AddWithValue("@idPago", cbxIdPago.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@TipoPago", cbxFormaPago.SelectedItem.ToString());
                        }
                    }
                    //si se produce otro error
                    catch (Exception error)
                    {
                        MessageBox.Show("Hay un error en los datos: " + error.Message, "Error", MessageBoxButtons.OK);
                    }

                    //Intentar hacer la actualizacion del registro
                    try
                    {
                        //conexion a DB
                        connection.Open();

                        //variable para comprobar cuantas filas fueron modificadas
                        int rowsAffected = command.ExecuteNonQuery();

                        //Comprobar si la actualizacion fue exitosa, si rowsAffected es mayor que 0 significa que al menos una fila fue cambiada
                        if (rowsAffected > 0)
                        {
                            //Se deshabilita la edicion para evitar editar la misma mascota nuevamente por accidente
                            PagosEdicion(false);

                            MessageBox.Show("Pago completo", "Operacion exitosa!");

                            //se limpian los campos y se deshabilita el boton cancelar
                            cbxIdDuenoP_SelectedIndexChanged(this, EventArgs.Empty);
                        }
                        //Si no se cambio ninguna fila se muestra un mensaje de error
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el registro.", "Error :(");
                        }
                    }
                    //Si no puede modificar el registro mostrar mensaje de error
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error :(");
                    }
                }
            }
        }

        /// <summary>
        /// Evento que habilita o deshabilita la edicion de los controles
        /// </summary>
        /// <param name="edicion">si es true activa los controles para la edicion la edicion</param>
        private void PagosEdicion(bool edicion)
        {
            cbxIdDuenoP.Enabled = !edicion;
            cbxIdPago.Enabled = !edicion;
            cbxFormaPago.Enabled = edicion;
            btnRegistrarP.Enabled = !edicion;
            btnGuardarP.Enabled = edicion;
            btnCancelarP.Enabled = edicion;
        }
    }
}
