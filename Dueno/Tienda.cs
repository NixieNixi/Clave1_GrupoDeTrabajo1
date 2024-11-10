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
        
        private List<Producto> productos = new List<Producto>();
        private CarritoCompras carrito;

        public Tienda()
        {
            InitializeComponent();
            CargarProductos();
            carrito = new CarritoCompras();
        }

        
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
                        
                        dgvProductos.Rows.Clear();

                       
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

        
        private void btnComprarD_Click(object sender, EventArgs e)
        {
            
            if (dgvProductos.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["IdProducto"].Value);
                Producto productoSeleccionado = productos.Find(p => p.IdProductos == idProducto);

                if (productoSeleccionado != null && productoSeleccionado.Cantidad > 0)
                {
                    
                    decimal totalCompra = productoSeleccionado.Precio;
                    lblTotal.Text = "Total: $" + totalCompra.ToString("F2");

                    
                    productoSeleccionado.Cantidad -= 1;

                    
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
            
            PerfilDueno perfil = new PerfilDueno();
            perfil.ShowDialog();
            this.Close();  
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                
                var productoSeleccionado = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                // Agregar el producto al carrito
                carrito.AgregarProducto(productoSeleccionado);

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
                
                decimal totalPago = carrito.CalcularTotal();
                DateTime fechaPago = DateTime.Now;  
                string tipoPago = "Efectivo"; 

                
                int idUsuario = 1;  

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

                
                int idPago = ObtenerUltimoIdPago();  

               
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
