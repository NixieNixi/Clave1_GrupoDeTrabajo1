using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_GrupoDeTrabajo1.Clases
{
    public class Pago
    {
        public int IdPago { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoPago { get; set; }  
        public int IdUsuario { get; set; }  
    }

}
