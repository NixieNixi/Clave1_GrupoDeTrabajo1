using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave1_GrupoDeTrabajo1.Administrador
{
    public partial class AdministradorPerfil
    {
        private void btnPagos_Click(object sender, EventArgs e)
        {
            //Se oculta el resto de los paneles
            panelMascotas.Visible = false;
            panelMascotas.Dock = DockStyle.None;
            panelBtnMascota.Visible = false;
            panelBtnMascota.Dock = DockStyle.None;
            panelCitas.Visible = false;
            panelCitas.Dock = DockStyle.None;
            panelBtnCitas.Visible = false;
            panelBtnCitas.Dock = DockStyle.None;
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
            panelBtnUsuarios.Visible = false;
            panelBtnUsuarios.Dock = DockStyle.None;

            //Se muestran los paneles de Usuario
            panelBtnPagos.Dock = DockStyle.Bottom;
            panelBtnPagos.Visible = true;
            panelPagos.Dock = DockStyle.Fill;
            panelPagos.Visible = true;
        }
    }
}
