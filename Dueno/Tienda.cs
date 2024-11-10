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
    /// <summary>
    /// Autor: NixieNixi
    /// Fecha Creacion: 10/11/2024
    /// 
    /// </summary>

    ///<remarks>
    ///
    ///</remarks>
    public partial class Tienda : Form
    {
        // Lista para almacenar los productos
        private List<Producto> productos = new List<Producto>();
        private CarritoCompras carrito;

        public Tienda()
        {
            InitializeComponent();
            CargarProductos();
            carrito = new CarritoCompras();
        }

        // Método para cargar productos desde la base de datos
        private void CargarProductos()
        {
            string query = "SELECT idProductos, Nombre, Precio, Descripcion, Cantidad FROM productos";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(MenuPrincipal.connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpia los productos antes de agregar nuevos
                        dgvProductos.Rows.Clear();

                        // Itera a través de los productos en la base de datos
                        while (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                IdProductos = reader.GetInt32("idProductos"),
                                Nombre = reader.GetString("Nombre"),
                                Precio = reader.GetDecimal("Precio"),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString("Descripcion"),
                                Cantidad = reader.GetInt32("Cantidad")
                            };

                            productos.Add(producto);

                            // Agrega el producto al DataGridView
                            dgvProductos.Rows.Add(
                                producto.IdProductos,
                                producto.Nombre,
                                producto.Precio,
                                producto.Descripcion,
                                producto.Cantidad
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        // Evento para el botón "Comprar"
        private void btnComprarD_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un producto
            if (dgvProductos.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["IdProducto"].Value);
                Producto productoSeleccionado = productos.Find(p => p.IdProductos == idProducto);

                if (productoSeleccionado != null && productoSeleccionado.Cantidad > 0)
                {
                    // Mostrar el total
                    decimal totalCompra = productoSeleccionado.Precio;
                    lblTotal.Text = "Total: $" + totalCompra.ToString("F2");

                    // Actualizar la cantidad disponible del producto
                    productoSeleccionado.Cantidad -= 1;

                    // Actualizar el DataGridView
                    dgvProductos.SelectedRows[0].Cells["CantidadDisponible"].Value = productoSeleccionado.Cantidad;
                }
                else
                {
                    MessageBox.Show("Producto no disponible o no seleccionado.");
                }
            }
        }

        // Evento para el botón "Volver a Perfil"
        private void btnVolD_Click(object sender, EventArgs e)
        {
            // Regresar al formulario del perfil del dueño
            PerfilDueno perfil = new PerfilDueno();
            perfil.ShowDialog();
            this.Close();  // Cierra el formulario actual
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se haga clic en los encabezados
            {
                // Obtener el producto de la fila seleccionada
                var productoSeleccionado = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                // Agregar el producto al carrito
                carrito.AgregarProducto(productoSeleccionado);

                // Mostrar los productos seleccionados en un DataGridView o en un Label (opcional)
                MostrarCarrito();
            }
        }

        /// <summary>
        /// Metodo que muestra en el data grid, los productos que el dueno elejio
        /// </summary>
        private void MostrarCarrito()
        {
            dgvCarritoCompras.Rows.Clear();

            foreach (var producto in carrito.ProductosSeleccionados)
            {
                dgvCarritoCompras.Rows.Add(producto.IdProductos, producto.Nombre, producto.Precio);
            }

            lblTotal.Text = "Total: $" + carrito.CalcularTotal().ToString("F2");
        }

        private void ProcesarPago()
        {
            try
            {
                // Crear el pago
                decimal totalPago = carrito.CalcularTotal();
                DateTime fechaPago = DateTime.Now;  // Fecha actual del pago
                string tipoPago = "Efectivo";  // Aquí puedes permitir que el usuario elija el tipo de pago

                // Suponiendo que tienes el ID del usuario en alguna variable
                int idUsuario = 1;  // Aquí va el ID del dueño que realiza el pago

                // Insertar el pago en la base de datos
                string queryPago = "INSERT INTO pagos (Total, Fecha, TipoPago, IdUsuario) VALUES (@Total, @Fecha, @TipoPago, @IdUsuario)";
                using (MySqlConnection conexion = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand(queryPago, conexion);
                    cmd.Parameters.AddWithValue("@Total", totalPago);
                    cmd.Parameters.AddWithValue("@Fecha", fechaPago);
                    cmd.Parameters.AddWithValue("@TipoPago", tipoPago);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    cmd.ExecuteNonQuery();
                }

                // Obtener el ID del pago recién creado (si se necesita)
                int idPago = ObtenerUltimoIdPago();  // Debes crear esta función que obtiene el ID del último pago insertado

                // Asociar los productos comprados al pago
                foreach (var producto in carrito.ProductosSeleccionados)
                {
                    string queryDetallePago = "INSERT INTO detalle_pagos (IdPago, IdProducto, Cantidad, PrecioUnitario) VALUES (@IdPago, @IdProducto, @Cantidad, @PrecioUnitario)";
                    using (MySqlConnection conexion = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        conexion.Open();
                        MySqlCommand cmdDetalle = new MySqlCommand(queryDetallePago, conexion);
                        cmdDetalle.Parameters.AddWithValue("@IdPago", idPago);
                        cmdDetalle.Parameters.AddWithValue("@IdProducto", producto.IdProductos);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", 1);  
                        cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", producto.Precio);

                        cmdDetalle.ExecuteNonQuery();
                    }

                   
                    string queryActualizarCantidad = "UPDATE productos SET Cantidad = Cantidad - 1 WHERE IdProductos = @IdProducto";
                    using (MySqlConnection conexion = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        conexion.Open();
                        MySqlCommand cmdActualizar = new MySqlCommand(queryActualizarCantidad, conexion);
                        cmdActualizar.Parameters.AddWithValue("@IdProducto", producto.IdProductos);

                        cmdActualizar.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pago procesado con éxito.");
                carrito.VaciarCarrito();  
                MostrarCarrito();  

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el pago: " + ex.Message);
            }
        }

        private void btnFinCompra_Click(object sender, EventArgs e)
        {
            //ProcesarPago();
        }


        private int ObtenerUltimoIdPago()
        {
            int ultimoId = 0;

            try
            {
                
                string query = "SELECT MAX(IdPago) FROM pagos";

                using (MySqlConnection conexion = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != DBNull.Value)
                    {
                        ultimoId = Convert.ToInt32(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el último ID de pago: " + ex.Message);
            }

            return ultimoId;
        }


    }
}
