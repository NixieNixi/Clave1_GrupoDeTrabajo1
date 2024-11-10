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
        private void btnInventario_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
            panelBtnUsuarios.Visible = false;
            panelBtnUsuarios.Dock = DockStyle.None;
            panelCitas.Visible = false;
            panelCitas.Dock = DockStyle.None;
            panelBtnCitas.Visible = false;
            panelBtnCitas.Dock = DockStyle.None;
            panelPagos.Visible = false;
            panelPagos.Dock = DockStyle.None;
            panelBtnPagos.Visible = false;
            panelBtnPagos.Dock = DockStyle.None;
            panelBtnMascota.Visible = false;
            panelBtnMascota.Dock = DockStyle.Bottom;
            panelMascotas.Visible = false;
            panelMascotas.Dock = DockStyle.Fill;

            panelBtnInventario.Dock = DockStyle.Bottom;
            panelBtnInventario.Visible = true;
            panelInventario.Dock = DockStyle.Fill;
            panelInventario.Visible = true;

            ActualizarRegistrosDueno();
        }
    }
}
