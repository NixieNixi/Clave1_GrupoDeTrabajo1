﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Clave1_GrupoDeTrabajo1.Clases;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    public partial class AdministradorPerfil

    {
        /// <summary>
        /// Boton Pagos que oculta el resto de paneles y muestra los paneles de las funciones de pagos y carga los id usuario
        /// </summary>
        private void btnInventario_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
            panelBtnUsuarios.Visible = false;
            panelBtnUsuarios.Dock = DockStyle.None;
            panelCitas.Visible = false;
            panelCitas.Dock = DockStyle.None;
            panelBtnCitas.Visible = false;
            panelBtnCitas.Dock = DockStyle.None;
            panelPagos.Visible = false;
            panelPagos.Dock = DockStyle.None;
            panelBtnPagos.Visible = false;
            panelBtnPagos.Dock = DockStyle.None;
            panelBtnMascota.Visible = false;
            panelBtnMascota.Dock = DockStyle.Bottom;
            panelMascotas.Visible = false;
            panelMascotas.Dock = DockStyle.Fill;

            panelBtnInventario.Dock = DockStyle.Bottom;
            panelBtnInventario.Visible = true;
            panelInventario.Dock = DockStyle.Fill;
            panelInventario.Visible = true;

            CargarProductos();
        }

        /// <summary>
        /// Funcion que carga los idProducto en el combobox ID producto
        /// </summary>
        private void CargarProductos()
        {
            //Limpia los elementos del comboBox
            cbxIdProducto.Items.Clear();

            //Intentar conectar a DB
            try
            {
                //Crea una conexion a la DB
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    //Consulta a la tabla productos
                    string query = "SELECT idProductos FROM productos";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Inserta los registros en el comboBox cbxUsuario
                                cbxIdProducto.Items.Add(reader["idProductos"].ToString());
                            }
                        }
                    }
                }
            }
            catch
            {
                //Si no puede conectar mostrar mensaje de error
                MessageBox.Show("Error de conexion a Base de datos", "Error :(");

                //Cerrar menu de administracion de usuarios
                panelInventario.Visible = false;
                panelBtnInventario.Visible = false;
            }
        }

        /// <summary>
        /// Evento del combobox que cambia la informacion segun el id del producto seleccionado
        /// </summary>
        private void cbxIdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si no se ha seleccionado ninguna opcion se limpian los controles
            if (cbxIdProducto.SelectedIndex == -1)
            {
                LimpiarProducto();
            }
            //Dependiendo de la seleccion de producto
            else
            {
                //guarda el texto de la seleccion en consultaIDPago
                string consultaIDPago = cbxIdProducto.SelectedItem.ToString();

                //Intentar conectar a DB
                try
                {
                    //cadena de conexion a DB
                    using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        //cadena de consulta a DB
                        string query = "SELECT Nombre, Precio, Descripcion, Cantidad FROM productos WHERE idProductos = @idProductos;";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            //Agregar el parametro a la consulta
                            command.Parameters.AddWithValue("@idProductos", consultaIDPago);

                            //Conectar a DB
                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    //si se ha seleccionado un producto se habilita el boton editar para editar la informacion del producto
                                    btnEditI.Enabled = true;

                                    //Inserta la informacion en los controles correspondientes
                                    if (reader.Read())
                                    {
                                        txtProducto.Text = reader["Nombre"].ToString();
                                        txtPrecio.Text = reader["Precio"].ToString();
                                        txtCantidad.Text = reader["Cantidad"].ToString();
                                        txtDescripcion.Text = reader["Descripcion"].ToString();
                                    }
                                }
                                else
                                {
                                    //si no hay registro se deshabilita el boton editar
                                    btnEditI.Enabled = false;
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
        /// Funcion para limpiar los campos
        /// </summary>
        private void LimpiarProducto()
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtDescripcion.Clear();
        }

        /// <summary>
        /// Funcion que activa o desativa los controles
        /// </summary>
        /// <param name="activar">Segun el valor que reciba activa o desactiva los controles</param>
        private void EditProducto(bool activar)
        {
            cbxIdProducto.Enabled = !activar;
            txtProducto.Enabled = activar;
            txtPrecio.Enabled = activar;
            txtCantidad.Enabled = activar;
            txtDescripcion.Enabled = activar;
            btnEditI.Enabled = !activar;
            btnGuardarI.Enabled = activar;
            btnCancelarI.Enabled = activar;

            txtProducto.ReadOnly = !activar;
            txtPrecio.ReadOnly = !activar;
            txtCantidad.ReadOnly = !activar;
            txtDescripcion.ReadOnly = !activar;
        }

        /// <summary>
        /// Evento del boton editar que llama a la funcion para activar la edicion los controles
        /// </summary>
        private void btnEditI_Click(object sender, EventArgs e)
        {
            EditProducto(true);
        }

        /// <summary>
        /// Evento del boton cancelar que deshace los cambios en la informacion de los controles y desactiva la edicion
        /// </summary>
        private void btnCancelarI_Click(object sender, EventArgs e)
        {
            EditProducto(false);
            cbxIdProducto_SelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Evento del boton guardar que actualiza la informacion del producto seleccionado
        /// </summary>
        private void btnGuardarI_Click(object sender, EventArgs e)
        {
            //Consulta sql para actualizar los datos de la mascota
            string query = @"UPDATE productos
                            SET Nombre = @Nombre,
                                Precio = @Precio,
                                Cantidad = @Cantidad,
                                Descripcion = @Descripcion
                          WHERE idProductos = @idProductos;";

            //Realizar la actualización en la base de datos
            using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        //Verificaciones de los datos
                        if (string.IsNullOrEmpty(txtProducto.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
                        {
                            MessageBox.Show("Por favor llene los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                        {
                            MessageBox.Show("Ingrese una cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tool.Show("Ingrese una cantidad", txtCantidad, 0, -20, 3000);
                            return;
                        }
                        else if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
                        {
                            MessageBox.Show("Ingrese un precio valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tool.Show("Ingrese un precio", cbxFormaPago, 0, -20, 3000);
                            return;
                        }
                        //si no hay errores en los datos asignar los parametros con los datos del form
                        else
                        {
                            command.Parameters.AddWithValue("@Nombre", txtProducto.Text);
                            command.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                            command.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                            command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                            command.Parameters.AddWithValue("@idProductos", cbxIdProducto.SelectedItem.ToString());
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
                            //Se deshabilita la edicion
                            EditProducto(false);

                            MessageBox.Show("Informacion de producto actualizado", "Operacion exitosa!");

                            //se limpian los campos y se deshabilita el boton cancelar
                            cbxIdProducto_SelectedIndexChanged(this, EventArgs.Empty);
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
        /// Evento del boton Ver todos que muestra un panel con un DataGridView con la informacion de todos los productos
        /// </summary>
        private void btnVerTodosI_Click(object sender, EventArgs e)
        {
            CargarInventario();
            btnVerTodosI.Visible = false;
            btnOcultar.Visible = true;
            paneldgvInventario.Dock = DockStyle.Fill;
            paneldgvInventario.Visible = true;
        }

        /// <summary>
        /// Metodo que carga los producto del inventario en el dgvInventario
        /// </summary>
        private void CargarInventario()
        {
            string queryInventario = @" SELECT idProductos, Nombre, Precio, Descripcion, Cantidad FROM productos;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(queryInventario, connection))
                    {
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dgvInventario.Rows.Clear();

                            List<Producto> productos = new List<Producto>();

                            while (reader.Read())
                            {
                                Producto producto = new Producto
                                {
                                    IdProductos = reader.GetInt32("idProductos"),
                                    Nombre = reader["Nombre"].ToString(),
                                    Precio = reader.GetDecimal("Precio"),
                                    Descripcion = reader["Descripcion"].ToString(),
                                    Cantidad = reader.GetInt32("Cantidad")
                                };

                                productos.Add(producto);

                                dgvInventario.Rows.Add(producto.IdProductos, producto.Nombre, producto.Precio, producto.Cantidad, producto.Descripcion);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion a base de datos " + ex.Message);
            }
        }

        /// <summary>
        /// Evento del boton Ocultar que oculta el panel de dgvInventario 
        /// </summary>
        private void btnOcultar_Click(object sender, EventArgs e)
        {
            paneldgvInventario.Visible = false;
            btnOcultar.Visible = false;
            btnVerTodosI.Visible = true;
        }
    }
}