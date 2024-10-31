﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    public partial class AdministradorPerfil : Form
    {
        public AdministradorPerfil()
        {
            InitializeComponent();
        }

        //Metodo para cerrar el formulario mediante el boton btnCerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
        }

        //Metodo para mostrar el panel de citas
        private void btnCitas_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
        }

        //Metodo para mostrar el panel de inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
        }
    }
}
