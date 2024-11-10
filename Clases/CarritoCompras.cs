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
            ProductosSeleccionados.Add(producto);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var producto in ProductosSeleccionados)
            {
                total += producto.Precio;
            }
            return total;
        }

        public void VaciarCarrito()
        {
            ProductosSeleccionados.Clear();
        }

    }
}
