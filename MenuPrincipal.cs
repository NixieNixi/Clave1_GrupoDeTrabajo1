﻿using System;
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
        // Conexión a la base de datos. Asegúrate de que el usuario y la contraseña coincidan
        // con los datos de acceso a tu servidor MySQL. Si tu configuración es distinta,
        // reemplaza 'root' por tu usuario y 'MIMAMAMEMIMA' por tu contraseña.
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
            //MessageBox.Show("Aqui se mostrara informacion tal como el horario de atencion, productos y servicios disponibles");
                        MessageBox.Show(
                "Costos de los servicios:\n" +
                "- Consulta: $8\n" +
                "- Vacuna: $5\n" +
                "- Examen: $15\n" +
                "- Cirugía: $30\n\n" +
                "Productos disponibles:\n" +
                "- Comida para perros\n" +
                "- Comida para gatos\n" +
                "- Snacks y golosinas\n\n" +
                "Horario de atención:\n" +
                "De Lunes a Domingo: 8:00 a.m. a 4:00 p.m.\n" ,
                "Información de Citas y Horarios",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        //Metodo para abrir la ventana de Login
        private void btnIngresoDueno_Click(object sender, EventArgs e)
        {
            //Llamara al formulario donde se podra elegir a uno de los usuarios de la administracion de la veterinaria (Veterinario o Administrador del sistema)
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
