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
    public partial class ComprarProductos : Form
    {
        public ComprarProductos()
        {
            InitializeComponent();
        }

        private void btnVolverMenuDueno_Click(object sender, EventArgs e)
        {
            MenuDueno menuDueno = new MenuDueno();
            this.Hide();
            menuDueno.ShowDialog();
        }
    }
}
