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
    public partial class MenuPrincipal : Form
    {
        /// <summary>
        /// Cadena de conexion a la base de datos.
        /// </summary>
        public const string connectionString = "Server=localhost;Database=clave1_grupodetrabajodb1; Uid =root;Pwd=MIMAMAMEMIMA;";

        //Constructor del formulario principal.
        public MenuPrincipal()
        {
            // Inicialización de los componentes visuales del formulario
            InitializeComponent();
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

        //Metodo para abrir la ventana de Login
        private void btnIngresoDueno_Click(object sender, EventArgs e)
        {
            //Llamara al formulario donde se podra elegir a uno de los usuarios de la administracion de la veterinaria (Veterinario o Administrador del sistema)
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
