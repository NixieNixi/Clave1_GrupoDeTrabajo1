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
        public string ExamenFisico { get; set; }
        public double Peso { get; set; }
        public string Medicamentos { get; set; }
        public string Notas { get; set; }


        public Cita() { }

        public Cita(int idCita,  string motivo, string sintomas, string diagnostico,
            string tratamiento, string examenFisico, string notas, string medicamentos)
        {
            IdCita = idCita;
            Motivo = motivo;
            Sintomas = sintomas;
            ExamenFisico = examenFisico;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            Medicamentos = medicamentos;
            Notas = notas;

        }

    }
}
