﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_GrupoDeTrabajo1
{
    public partial class LoginVeterinario : Form
    {
        public LoginVeterinario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresoVete_Click(object sender, EventArgs e)
        {
            MenuVeterinario menuVeterinario = new MenuVeterinario();
            menuVeterinario.ShowDialog();
            this.Hide();
        }
    }
}
