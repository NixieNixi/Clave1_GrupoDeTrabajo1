using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_GrupoDeTrabajo1.Clases
{
    class CarritoCompras
    {

        public List<Producto> ProductosSeleccionados { get; set; }

        public CarritoCompras()
        {
            ProductosSeleccionados = new List<Producto>();
        }
        public void AgregarProducto(Producto producto)
        {
            // Verificar si el producto ya está en el carrito
            var productoExistente = ProductosSeleccionados.FirstOrDefault(p => p.IdProductos == producto.IdProductos);

            if (productoExistente != null)
            {
                // Si el producto ya está en el carrito, aumentamos la cantidad
                productoExistente.CantidadSeleccionada++;
            }
            else
            {
                // Si el producto no está en el carrito, lo agregamos con cantidad 1
                producto.CantidadSeleccionada = 1;
                ProductosSeleccionados.Add(producto);
            }
        }

        public decimal CalcularTotal()
        {
            // Calcular el total de la compra
            decimal total = 0;
            foreach (var producto in ProductosSeleccionados)
            {
                total += producto.Precio * producto.CantidadSeleccionada;
            }
            return total;
        }

        public void VaciarCarrito()
        {
            // Vaciar el carrito
            ProductosSeleccionados.Clear();
        }

    }
}
