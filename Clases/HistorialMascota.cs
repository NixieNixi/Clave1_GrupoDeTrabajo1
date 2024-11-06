using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_GrupoDeTrabajo1.Clases
{
    class HistorialMascota
    {
        
            public string Cirugia { get; set; }
            public string Examen { get; set; }
            public string Alergia { get; set; }
            public string MedicamentoActual { get; set; }
            public string UltimaVacuna { get; set; }
            public DateTime FechaVacuna { get; set; }

            // Constructor
            public HistorialMascota(string cirugia, string examen, string alergia, string medicamentoActual, string ultimaVacuna, DateTime fechaVacuna)
            {
                Cirugia = cirugia;
                Examen = examen;
                Alergia = alergia;
                MedicamentoActual = medicamentoActual;
                UltimaVacuna = ultimaVacuna;
                FechaVacuna = fechaVacuna;
            }
        


    }
}
