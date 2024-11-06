using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_GrupoDeTrabajo1.Clases
{
    public class Vacuna
    {
        public int IdVacuna { get; set; }
        public int IdMascota { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Motivo { get; set; }
        public string Materiales { get; set; }

        public Vacuna() { }
        public Vacuna(int idVacuna, int idMascota, string tipo, 
            string descripcion, string motivo, string materiales)
        {
            IdVacuna = idVacuna;
            IdMascota = idMascota;
            Tipo = tipo;
            Descripcion = descripcion;
            Motivo = motivo;
            Materiales = materiales;
        }

    }

}
