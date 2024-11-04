using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_GrupoDeTrabajo1.Clases
{
    class Cita
    {

        public int IdCita { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }

        public Cita(int idCita, DateTime fecha, string motivo, string sintomas, string diagnostico, string tratamiento)
        {
            IdCita = idCita;
            Fecha = fecha;
            Motivo = motivo;
            Sintomas = sintomas;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
        }

    }
}
