using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// Programador: Equipo de Desarrollo (NixieNixi,RaRMustis,CanelaFeliz,3smer4ld4)
// Proyecto: Sistema para Veterinaria "Cat-Dog"
// Fecha de Diseño: Octubre de 2024

namespace Clave1_GrupoDeTrabajo1
{ 
    
    //Formulario Principal de la Aplicacion.
    public partial class Form1 : Form
    {
        //Constructor del formulario principal.
        public Form1()
        {
            // Inicialización de los componentes visuales del formulario
            InitializeComponent();
        }

        // Este método debería abrir el formulario donde el veterinario podrá iniciar sesión.
        // El veterinario tiene permisos para registrar, consultas y administrar el cuadro clínico de las mascotas.
        private void btnIngresoVete_Click(object sender, EventArgs e)
        {
            // Aquí se implementará la apertura del formulario donde el veterinario realizará su login.
            // Rol: Veterinario
            // Responsabilidad: Registrar consultas, manejar cuadro clínico y administrar vacunas.
            LoginVeterinario loginVeterinario = new LoginVeterinario();
            loginVeterinario.ShowDialog();


        }

        // Este método debería abrir el formulario donde el administrador del sistema inicia sesión.
        // El administrador podrá gestionar las citas, productos, y pagos de la veterinaria.
        private void btnIngresoAdmin_Click(object sender, EventArgs e)
        {
            // Aquí se implementará la apertura del formulario donde el administrador realizará su login.
            // Rol: Administrador
            // Responsabilidad: Gestionar citas, modificar registros, y controlar los pagos.
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.ShowDialog();
        }

        // Este método debería abrir el formulario donde el dueño de la mascota inicia sesión.
        // El dueño podrá programar, modificar o cancelar citas, además de realizar compras de productos.
        private void btnIngresoDueno_Click(object sender, EventArgs e)
        {
            // Aquí se implementará la apertura del formulario donde el dueño realizará su login.
            // Rol: Dueño de la Mascota
            // Responsabilidad: Programar, cancelar o modificar citas y realizar compras.
            LoginDueno loginDueno = new LoginDueno();
            loginDueno.ShowDialog();

        }

        //Metodo para cerrar el form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            //Creacion del objeto inicio de la clase inicioSesion(CanelaFeliz)
            //inicioSesion inicio = new inicioSesion();
            //se usa la propiedad ShowDialog del objeto creado para abrir el nuevo form
            // inicio.ShowDialog();
        }
    }
}
