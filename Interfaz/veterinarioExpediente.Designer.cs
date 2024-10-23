
namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    partial class veterinarioExpediente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlExpediente = new System.Windows.Forms.TabControl();
            this.tabDatosMascota = new System.Windows.Forms.TabPage();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtIdMascota = new System.Windows.Forms.TextBox();
            this.txtNomMascota = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblNomMascota = new System.Windows.Forms.Label();
            this.lblIdExpediente = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblIdMascota = new System.Windows.Forms.Label();
            this.txtIdExpediente = new System.Windows.Forms.TextBox();
            this.tabDatosDueno = new System.Windows.Forms.TabPage();
            this.lblNomDueno = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblIdDueno = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNomDueno = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtIdDueno = new System.Windows.Forms.TextBox();
            this.tabHistorialMedico = new System.Windows.Forms.TabPage();
            this.panelHM = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvHM = new System.Windows.Forms.DataGridView();
            this.IdCitaAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlExpediente.SuspendLayout();
            this.tabDatosMascota.SuspendLayout();
            this.tabDatosDueno.SuspendLayout();
            this.tabHistorialMedico.SuspendLayout();
            this.panelHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHM)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlExpediente
            // 
            this.tabControlExpediente.Controls.Add(this.tabDatosMascota);
            this.tabControlExpediente.Controls.Add(this.tabDatosDueno);
            this.tabControlExpediente.Controls.Add(this.tabHistorialMedico);
            this.tabControlExpediente.Location = new System.Drawing.Point(-3, -3);
            this.tabControlExpediente.Name = "tabControlExpediente";
            this.tabControlExpediente.SelectedIndex = 0;
            this.tabControlExpediente.Size = new System.Drawing.Size(894, 853);
            this.tabControlExpediente.TabIndex = 0;
            // 
            // tabDatosMascota
            // 
            this.tabDatosMascota.Controls.Add(this.txtFechaNacimiento);
            this.tabDatosMascota.Controls.Add(this.txtPeso);
            this.tabDatosMascota.Controls.Add(this.txtSexo);
            this.tabDatosMascota.Controls.Add(this.txtRaza);
            this.tabDatosMascota.Controls.Add(this.txtEspecie);
            this.tabDatosMascota.Controls.Add(this.txtIdMascota);
            this.tabDatosMascota.Controls.Add(this.txtNomMascota);
            this.tabDatosMascota.Controls.Add(this.lblEspecie);
            this.tabDatosMascota.Controls.Add(this.lblNomMascota);
            this.tabDatosMascota.Controls.Add(this.lblIdExpediente);
            this.tabDatosMascota.Controls.Add(this.lblFechaNacimiento);
            this.tabDatosMascota.Controls.Add(this.lblSexo);
            this.tabDatosMascota.Controls.Add(this.lblRaza);
            this.tabDatosMascota.Controls.Add(this.lblPeso);
            this.tabDatosMascota.Controls.Add(this.lblIdMascota);
            this.tabDatosMascota.Controls.Add(this.txtIdExpediente);
            this.tabDatosMascota.Location = new System.Drawing.Point(4, 22);
            this.tabDatosMascota.Name = "tabDatosMascota";
            this.tabDatosMascota.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosMascota.Size = new System.Drawing.Size(886, 827);
            this.tabDatosMascota.TabIndex = 0;
            this.tabDatosMascota.Text = "Datos Mascota";
            this.tabDatosMascota.UseVisualStyleBackColor = true;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(533, 257);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.ReadOnly = true;
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 22;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(378, 257);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 21;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(199, 257);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 20;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(36, 257);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.ReadOnly = true;
            this.txtRaza.Size = new System.Drawing.Size(100, 20);
            this.txtRaza.TabIndex = 19;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(533, 104);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtEspecie.TabIndex = 18;
            // 
            // txtIdMascota
            // 
            this.txtIdMascota.Location = new System.Drawing.Point(199, 104);
            this.txtIdMascota.Name = "txtIdMascota";
            this.txtIdMascota.ReadOnly = true;
            this.txtIdMascota.Size = new System.Drawing.Size(100, 20);
            this.txtIdMascota.TabIndex = 17;
            // 
            // txtNomMascota
            // 
            this.txtNomMascota.Location = new System.Drawing.Point(358, 104);
            this.txtNomMascota.Name = "txtNomMascota";
            this.txtNomMascota.ReadOnly = true;
            this.txtNomMascota.Size = new System.Drawing.Size(100, 20);
            this.txtNomMascota.TabIndex = 16;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(530, 66);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(89, 13);
            this.lblEspecie.TabIndex = 15;
            this.lblEspecie.Text = "Especie Mascota";
            // 
            // lblNomMascota
            // 
            this.lblNomMascota.AutoSize = true;
            this.lblNomMascota.Location = new System.Drawing.Point(355, 66);
            this.lblNomMascota.Name = "lblNomMascota";
            this.lblNomMascota.Size = new System.Drawing.Size(88, 13);
            this.lblNomMascota.TabIndex = 14;
            this.lblNomMascota.Text = "Nombre Mascota";
            // 
            // lblIdExpediente
            // 
            this.lblIdExpediente.AutoSize = true;
            this.lblIdExpediente.Location = new System.Drawing.Point(35, 65);
            this.lblIdExpediente.Name = "lblIdExpediente";
            this.lblIdExpediente.Size = new System.Drawing.Size(74, 13);
            this.lblIdExpediente.TabIndex = 13;
            this.lblIdExpediente.Text = "ID Expediente";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(530, 218);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 12;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(197, 218);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(36, 218);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(32, 13);
            this.lblRaza.TabIndex = 10;
            this.lblRaza.Text = "Raza";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(375, 218);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso";
            // 
            // lblIdMascota
            // 
            this.lblIdMascota.AutoSize = true;
            this.lblIdMascota.Location = new System.Drawing.Point(196, 65);
            this.lblIdMascota.Name = "lblIdMascota";
            this.lblIdMascota.Size = new System.Drawing.Size(62, 13);
            this.lblIdMascota.TabIndex = 8;
            this.lblIdMascota.Text = "ID Mascota";
            // 
            // txtIdExpediente
            // 
            this.txtIdExpediente.Location = new System.Drawing.Point(36, 104);
            this.txtIdExpediente.Name = "txtIdExpediente";
            this.txtIdExpediente.ReadOnly = true;
            this.txtIdExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtIdExpediente.TabIndex = 0;
            // 
            // tabDatosDueno
            // 
            this.tabDatosDueno.Controls.Add(this.lblNomDueno);
            this.tabDatosDueno.Controls.Add(this.lblTelefono);
            this.tabDatosDueno.Controls.Add(this.lblCorreo);
            this.tabDatosDueno.Controls.Add(this.lblDireccion);
            this.tabDatosDueno.Controls.Add(this.lblIdDueno);
            this.tabDatosDueno.Controls.Add(this.txtDireccion);
            this.tabDatosDueno.Controls.Add(this.txtCorreo);
            this.tabDatosDueno.Controls.Add(this.txtNomDueno);
            this.tabDatosDueno.Controls.Add(this.txtTelefono);
            this.tabDatosDueno.Controls.Add(this.txtIdDueno);
            this.tabDatosDueno.Location = new System.Drawing.Point(4, 22);
            this.tabDatosDueno.Name = "tabDatosDueno";
            this.tabDatosDueno.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosDueno.Size = new System.Drawing.Size(886, 827);
            this.tabDatosDueno.TabIndex = 1;
            this.tabDatosDueno.Text = "Datos Dueno";
            this.tabDatosDueno.UseVisualStyleBackColor = true;
            // 
            // lblNomDueno
            // 
            this.lblNomDueno.AutoSize = true;
            this.lblNomDueno.Location = new System.Drawing.Point(175, 59);
            this.lblNomDueno.Name = "lblNomDueno";
            this.lblNomDueno.Size = new System.Drawing.Size(79, 13);
            this.lblNomDueno.TabIndex = 28;
            this.lblNomDueno.Text = "Nombre Dueno";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(334, 59);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 27;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(497, 59);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 26;
            this.lblCorreo.Text = "Correo";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(657, 59);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 25;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblIdDueno
            // 
            this.lblIdDueno.AutoSize = true;
            this.lblIdDueno.Location = new System.Drawing.Point(15, 59);
            this.lblIdDueno.Name = "lblIdDueno";
            this.lblIdDueno.Size = new System.Drawing.Size(53, 13);
            this.lblIdDueno.TabIndex = 24;
            this.lblIdDueno.Text = "ID Dueno";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(660, 110);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 23;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(500, 110);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 22;
            // 
            // txtNomDueno
            // 
            this.txtNomDueno.Location = new System.Drawing.Point(178, 110);
            this.txtNomDueno.Name = "txtNomDueno";
            this.txtNomDueno.ReadOnly = true;
            this.txtNomDueno.Size = new System.Drawing.Size(100, 20);
            this.txtNomDueno.TabIndex = 21;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(337, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 20;
            // 
            // txtIdDueno
            // 
            this.txtIdDueno.Location = new System.Drawing.Point(15, 110);
            this.txtIdDueno.Name = "txtIdDueno";
            this.txtIdDueno.ReadOnly = true;
            this.txtIdDueno.Size = new System.Drawing.Size(100, 20);
            this.txtIdDueno.TabIndex = 19;
            // 
            // tabHistorialMedico
            // 
            this.tabHistorialMedico.Controls.Add(this.panelHM);
            this.tabHistorialMedico.Location = new System.Drawing.Point(4, 22);
            this.tabHistorialMedico.Name = "tabHistorialMedico";
            this.tabHistorialMedico.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorialMedico.Size = new System.Drawing.Size(886, 827);
            this.tabHistorialMedico.TabIndex = 2;
            this.tabHistorialMedico.Text = "Historial Medico";
            this.tabHistorialMedico.UseVisualStyleBackColor = true;
            // 
            // panelHM
            // 
            this.panelHM.AutoScroll = true;
            this.panelHM.Controls.Add(this.dateTimePicker1);
            this.panelHM.Controls.Add(this.dgvHM);
            this.panelHM.Controls.Add(this.label3);
            this.panelHM.Controls.Add(this.label1);
            this.panelHM.Controls.Add(this.label2);
            this.panelHM.Location = new System.Drawing.Point(0, 0);
            this.panelHM.Name = "panelHM";
            this.panelHM.Size = new System.Drawing.Size(887, 797);
            this.panelHM.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dgvHM
            // 
            this.dgvHM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCitaAnterior,
            this.MotivoConsulta,
            this.Sintomas,
            this.ExamenFisico,
            this.Diagnostico,
            this.Tratamiento,
            this.Medicamentos,
            this.Notas});
            this.dgvHM.Location = new System.Drawing.Point(12, 203);
            this.dgvHM.Name = "dgvHM";
            this.dgvHM.Size = new System.Drawing.Size(848, 161);
            this.dgvHM.TabIndex = 3;
            // 
            // IdCitaAnterior
            // 
            this.IdCitaAnterior.HeaderText = "ID Cita Anterior";
            this.IdCitaAnterior.Name = "IdCitaAnterior";
            // 
            // MotivoConsulta
            // 
            this.MotivoConsulta.HeaderText = "Motivo Consulta";
            this.MotivoConsulta.Name = "MotivoConsulta";
            // 
            // Sintomas
            // 
            this.Sintomas.HeaderText = "Sintomas";
            this.Sintomas.Name = "Sintomas";
            // 
            // ExamenFisico
            // 
            this.ExamenFisico.HeaderText = "Examen Fisico";
            this.ExamenFisico.Name = "ExamenFisico";
            // 
            // Diagnostico
            // 
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Traramiento";
            this.Tratamiento.Name = "Tratamiento";
            // 
            // Medicamentos
            // 
            this.Medicamentos.HeaderText = "Medicamentos";
            this.Medicamentos.Name = "Medicamentos";
            // 
            // Notas
            // 
            this.Notas.HeaderText = "Notas";
            this.Notas.Name = "Notas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // veterinarioExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 862);
            this.Controls.Add(this.tabControlExpediente);
            this.Name = "veterinarioExpediente";
            this.Text = "veterinarioExpediente";
            this.tabControlExpediente.ResumeLayout(false);
            this.tabDatosMascota.ResumeLayout(false);
            this.tabDatosMascota.PerformLayout();
            this.tabDatosDueno.ResumeLayout(false);
            this.tabDatosDueno.PerformLayout();
            this.tabHistorialMedico.ResumeLayout(false);
            this.panelHM.ResumeLayout(false);
            this.panelHM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlExpediente;
        private System.Windows.Forms.TabPage tabDatosMascota;
        private System.Windows.Forms.TabPage tabDatosDueno;
        private System.Windows.Forms.TabPage tabHistorialMedico;
        private System.Windows.Forms.TextBox txtIdExpediente;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblNomMascota;
        private System.Windows.Forms.Label lblIdExpediente;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblIdMascota;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtIdMascota;
        private System.Windows.Forms.TextBox txtNomMascota;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNomDueno;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtIdDueno;
        private System.Windows.Forms.Label lblNomDueno;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblIdDueno;
        private System.Windows.Forms.Panel panelHM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHM;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCitaAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenFisico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
    }
}