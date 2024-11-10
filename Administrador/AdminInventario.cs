using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Clave1_GrupoDeTrabajo1.Clases;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    public partial class AdminInventario : Form
    {
        public AdminInventario()
        {
            InitializeComponent();
            CargarInventario();
            

        }

        /// <summary>
        /// Metodo que carga los producto del inventario en el dgvInventario
        /// </summary>
        private void CargarInventario()
        {
            
                        string queryInventario = @"
                    SELECT 
                        idProductos, 
                        Nombre, 
                        Precio, 
                        Descripcion, 
                        Cantidad 
                    FROM 
                        productos;";

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

                                dgvInventario.Rows.Add(
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brou, da error por; " + ex.Message);
            }
        }




    }
}
