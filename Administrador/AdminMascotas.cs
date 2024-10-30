using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    //Clase parcial que se encarga de las funciones de Administracion de mascotas
    public partial class AdministradorPerfil
    {
        private void btnMascotas_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
            panelBtnUsuarios.Visible = false;
            panelBtnUsuarios.Dock = DockStyle.None;

            panelBtnMascota.Dock = DockStyle.Bottom;
            panelBtnMascota.Visible = true;
            panelMascotas.Dock = DockStyle.Fill;
            panelMascotas.Visible = true;
        }

        private void cbxIdUsuarioMascota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxIdMascotaMascota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
