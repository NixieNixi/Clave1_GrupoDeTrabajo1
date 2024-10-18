using Clave1_GrupoDeTrabajo1.Login;
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

//CanelaFeliz 14/10/24

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
   
        // Este método abre el formulario donde el dueño de la mascota inicia sesión.
        // El dueño podrá programar, modificar o cancelar citas, además de realizar compras de productos.
        private void btnIngresoDueno_Click_1(object sender, EventArgs e)
        {
            // Aquí se implementará la apertura del formulario donde el dueño realizará su login.
            // Rol: Dueño de la Mascota
            // Responsabilidad: Programar, cancelar o modificar citas y realizar compras.
            LoginDueno loginDueno = new LoginDueno();
            loginDueno.ShowDialog();
        }

        //Metodo para cerrar el form
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui se mostrara informacion tal como el horario de atencion, productos y servicios disponibles");
        }

        //Metodo que abre el form donde se decide el tipo de usuario administrativo que desea entrar al sistema
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //Llamara al formulario donde se podra elegir a uno de los usuarios de la administracion de la veterinaria (Veterinario o Administrador del sistema)
            LoginAdminSelec LoginAdminSelec = new LoginAdminSelec();
            LoginAdminSelec.ShowDialog();
        }
    }
}
