﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    public partial class PerfilMascota : Form
    {
        public PerfilMascota()
        {
            InitializeComponent();
        }

        private void PerfilMascota_Load(object sender, EventArgs e)
        {

        }

        private void btnCitasMascD_Click(object sender, EventArgs e)
        {
            CitaMascota Cita = new CitaMascota();
            Cita.ShowDialog();

        }

        private void btnVolverD_Click(object sender, EventArgs e)
        {
            PerfilDueño VolverVolver = new PerfilDueño();
            VolverVolver.ShowDialog();
        }
    }
}