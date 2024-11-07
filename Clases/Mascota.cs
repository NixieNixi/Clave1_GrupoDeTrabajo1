using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_GrupoDeTrabajo1.Clases
{
    /// <summary>
    /// <summary>
    /// Autor: NixieNixi
    /// Fecha creacion: 03/11/2024
    /// Version: 
    /// Descripcion:Clase creada para el manejo de las mascotas
    /// /// </summary>



    class Mascota
    {

        public int IdMascota { get; set; }
        public string NombreMascota { get; set; }
        public string Especie { get; set; } 
        public string Raza { get; set; }
        public int Edad { get; set; }

        public string Sexo { get; set; }
        public List<Cita> Citas { get; set; } // Lista de citas medicas
        public List<Cirugia> Cirugia { get; set; } = new List<Cirugia>();
        public List<Vacuna> Vacuna { get; set; } = new List<Vacuna>();
        public List<Examen> Examene { get; set; } = new List<Examen>();
        

        // Constructor 
        public Mascota()
        {
            Citas = new List<Cita>(); // Inicializa la lista de citas
        }

        // Constructor para crear una nueva mascota
        public Mascota(string nombreMascota, string especie, string raza, int edad, string sexo)
        {
            NombreMascota = nombreMascota;
            Especie = especie;
            Raza = raza;
            Edad = edad;
            Sexo = sexo;
           
            Citas = new List<Cita>(); // Inicializa la lista de citas
        }

        /// <summary>
        /// Metodo para agregar una cita
        /// </summary>
        /// <param name="cita"></param>
        public void AgregarCita(Cita cita)
        {
            Citas.Add(cita);
        }

        /// <summary>
        /// Metodo para obtener información sobre la mascota
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{NombreMascota} - {Raza} - {Edad} años";
        }


    }
}
