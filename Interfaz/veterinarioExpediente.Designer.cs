
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
            this.tabDatosDueno = new System.Windows.Forms.TabPage();
            this.tabHistorialMedico = new System.Windows.Forms.TabPage();
            this.txtIdExpediente = new System.Windows.Forms.TextBox();
            this.lblIdMascota = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblIdExpediente = new System.Windows.Forms.Label();
            this.lblNomMascota = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.txtNomMascota = new System.Windows.Forms.TextBox();
            this.txtIdMascota = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.tabControlExpediente.SuspendLayout();
            this.tabDatosMascota.SuspendLayout();
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
            this.tabControlExpediente.Size = new System.Drawing.Size(790, 439);
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
            this.tabDatosMascota.Size = new System.Drawing.Size(782, 413);
            this.tabDatosMascota.TabIndex = 0;
            this.tabDatosMascota.Text = "Datos Mascota";
            this.tabDatosMascota.UseVisualStyleBackColor = true;
            // 
            // tabDatosDueno
            // 
            this.tabDatosDueno.Location = new System.Drawing.Point(4, 22);
            this.tabDatosDueno.Name = "tabDatosDueno";
            this.tabDatosDueno.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosDueno.Size = new System.Drawing.Size(782, 413);
            this.tabDatosDueno.TabIndex = 1;
            this.tabDatosDueno.Text = "Datos Dueno";
            this.tabDatosDueno.UseVisualStyleBackColor = true;
            // 
            // tabHistorialMedico
            // 
            this.tabHistorialMedico.Location = new System.Drawing.Point(4, 22);
            this.tabHistorialMedico.Name = "tabHistorialMedico";
            this.tabHistorialMedico.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorialMedico.Size = new System.Drawing.Size(782, 413);
            this.tabHistorialMedico.TabIndex = 2;
            this.tabHistorialMedico.Text = "Historial Medico";
            this.tabHistorialMedico.UseVisualStyleBackColor = true;
            // 
            // txtIdExpediente
            // 
            this.txtIdExpediente.Location = new System.Drawing.Point(36, 104);
            this.txtIdExpediente.Name = "txtIdExpediente";
            this.txtIdExpediente.ReadOnly = true;
            this.txtIdExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtIdExpediente.TabIndex = 0;
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
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(375, 218);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso";
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
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(197, 218);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo";
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
            // lblIdExpediente
            // 
            this.lblIdExpediente.AutoSize = true;
            this.lblIdExpediente.Location = new System.Drawing.Point(35, 65);
            this.lblIdExpediente.Name = "lblIdExpediente";
            this.lblIdExpediente.Size = new System.Drawing.Size(74, 13);
            this.lblIdExpediente.TabIndex = 13;
            this.lblIdExpediente.Text = "ID Expediente";
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
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(530, 66);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(89, 13);
            this.lblEspecie.TabIndex = 15;
            this.lblEspecie.Text = "Especie Mascota";
            // 
            // txtNomMascota
            // 
            this.txtNomMascota.Location = new System.Drawing.Point(358, 104);
            this.txtNomMascota.Name = "txtNomMascota";
            this.txtNomMascota.ReadOnly = true;
            this.txtNomMascota.Size = new System.Drawing.Size(100, 20);
            this.txtNomMascota.TabIndex = 16;
            // 
            // txtIdMascota
            // 
            this.txtIdMascota.Location = new System.Drawing.Point(199, 104);
            this.txtIdMascota.Name = "txtIdMascota";
            this.txtIdMascota.ReadOnly = true;
            this.txtIdMascota.Size = new System.Drawing.Size(100, 20);
            this.txtIdMascota.TabIndex = 17;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(533, 104);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtEspecie.TabIndex = 18;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(36, 257);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.ReadOnly = true;
            this.txtRaza.Size = new System.Drawing.Size(100, 20);
            this.txtRaza.TabIndex = 19;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(199, 257);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 20;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(378, 257);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 21;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(533, 257);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.ReadOnly = true;
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 22;
            // 
            // veterinarioExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 448);
            this.Controls.Add(this.tabControlExpediente);
            this.Name = "veterinarioExpediente";
            this.Text = "veterinarioExpediente";
            this.tabControlExpediente.ResumeLayout(false);
            this.tabDatosMascota.ResumeLayout(false);
            this.tabDatosMascota.PerformLayout();
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
    }
}