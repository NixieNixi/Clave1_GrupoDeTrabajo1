﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_GrupoDeTrabajo1.Clases
{
    /// <summary>
    /// Clase creada para manejar las cirugiar de la Mascota
    /// </summary>
    
        public class Cirugia
        {
            public int IdCirugia { get; set; }
            public int IdMascota { get; set; }
            public string Tipo { get; set; }
            public string Descripcion { get; set; }
            public string Motivo { get; set; }
            public string Materiales { get; set; }
        }


    
}
