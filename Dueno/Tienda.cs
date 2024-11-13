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
    ///Autor: NixieNixi
    ///Descripcion:
    ///Se agregarons los metodos que hacen funcional la tienda, y validaciones.
    ///</remarks>
    public partial class Tienda : Form
    {
        
        private List<Producto> productos = new List<Producto>();
        private CarritoCompras carrito;
        
        
            private int IdUsuario;  

            
            public Tienda(int idUsuario)
            {
                InitializeComponent();
                IdUsuario = idUsuario;   
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
                    // Agregar al carrito y mostrar carrito actualizado
                    carrito.AgregarProducto(productoSeleccionado);
                    MostrarCarrito(); // Aquí actualizamos el carrito y el total

                    // Actualizamos la cantidad disponible en el producto
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
            this.Hide();
            perfil.ShowDialog();
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
                // Obtener el producto seleccionado
                var productoSeleccionado = productos[e.RowIndex];

                // Verificar que el producto esté disponible
                if (productoSeleccionado.Cantidad > 0)
                {
                    // Agregar el producto al carrito
                    carrito.AgregarProducto(productoSeleccionado);

                    // Mostrar el carrito actualizado
                    MostrarCarrito();
                }
                else
                {
                    MessageBox.Show("Producto no disponible.");
                }
            }
        }


        /// <summary>
        /// Metodo que muestra en el data grid, los productos que el dueno elejio
        /// </summary>
        private void MostrarCarrito()
        {
            dgvCarritoCompras.Rows.Clear();

           
            decimal total = 0;

            
            foreach (var producto in carrito.ProductosSeleccionados)
            {
                
                dgvCarritoCompras.Rows.Add(
                    producto.IdProductos,
                    producto.Nombre,
                    producto.Precio,
                    producto.CantidadSeleccionada,
                    producto.Precio * producto.CantidadSeleccionada 
                );

              
                total += producto.Precio * producto.CantidadSeleccionada;
            }

            
            lblMostrarTotalCompra.Text = "Total: $" + total.ToString("F2");
        }


        private void ProcesarPago()
        {
            try
            {
                decimal totalPago = carrito.CalcularTotal(); // Calculamos el total de la compra

                // Insertar el pago en la base de datos (solo la tabla pagos)
                string queryPago = "INSERT INTO pagos (IdUsuario, Fecha, Estado, Total, TipoPago, TipoServicio) VALUES (@IdUsuario, @Fecha, @Estado, @Total, @TipoPago, @TipoServicio)";
                using (MySqlConnection conexion = new MySqlConnection(MenuPrincipal.connectionString))
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand(queryPago, conexion);
                    cmd.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Estado", "Pendiente");
                    cmd.Parameters.AddWithValue("@Total", totalPago);
                    cmd.Parameters.AddWithValue("@TipoPago", "Sin pagar");
                    cmd.Parameters.AddWithValue("@TipoServicio", "Producto");

                    cmd.ExecuteNonQuery(); 
                }

                foreach (var producto in carrito.ProductosSeleccionados)
                {
                    string queryActualizarCantidad = "UPDATE productos SET Cantidad = Cantidad - @CantidadComprada WHERE idProductos = @IdProducto";
                    using (MySqlConnection conexion = new MySqlConnection(MenuPrincipal.connectionString))
                    {
                        conexion.Open();
                        MySqlCommand cmdActualizar = new MySqlCommand(queryActualizarCantidad, conexion);
                        cmdActualizar.Parameters.AddWithValue("@CantidadComprada", producto.CantidadSeleccionada);
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
            ProcesarPago();
        }


        public int ObtenerUltimoIdPago()
        {
            int idPago = 0;
            string query = "SELECT LAST_INSERT_ID()"; 
            using (MySqlConnection conexion = new MySqlConnection(MenuPrincipal.connectionString))
            {
                conexion.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    idPago = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return idPago;
        }

        private void btnCanceD_Click(object sender, EventArgs e)
        {
            if (dgvCarritoCompras.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCarritoCompras.SelectedRows[0];

               
                int idProducto = Convert.ToInt32(selectedRow.Cells["IdProductoCarrito"].Value);

                var productoParaCancelar = carrito.ProductosSeleccionados.FirstOrDefault(p => p.IdProductos == idProducto);

                if (productoParaCancelar != null)
                {
                    // Remover el producto del carrito
                    carrito.ProductosSeleccionados.Remove(productoParaCancelar);

                    // Remover la fila seleccionada del DataGridView
                    dgvCarritoCompras.Rows.Remove(selectedRow);

                    // Recalcular el total del carrito
                    MostrarCarrito();

                    MessageBox.Show("Producto cancelado con éxito.");
                }
                else
                {
                    MessageBox.Show("Producto no encontrado en el carrito.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para cancelar.");
            }
        }

        private void Tienda_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Al presionar X en la ventana, finalizara la ejecucion total del progrma
            Application.Exit();
        }
    }

}

