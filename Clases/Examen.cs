﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_GrupoDeTrabajo1.Clases
{
    public class Examen
    {
        public int IdExamen { get; set; }
        public int IdMascota { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Motivo { get; set; }
        public string Materiales { get; set; }
        public Examen() { }
        public Examen(int idExamen, int idMascota, string tipo,
            string descripcion, string motivo, string materiales)
        {
            IdExamen = idExamen;
            IdMascota = idMascota;
            Tipo = tipo;
            Descripcion = descripcion;
            Motivo = motivo;
            Materiales = materiales;
        }

    }

}