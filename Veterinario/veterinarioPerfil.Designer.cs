
namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    partial class veterinarioPerfil
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
            this.btnConsultarExpediente = new System.Windows.Forms.Button();
            this.btnCita = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConsultarVacunas = new System.Windows.Forms.Button();
            this.gbVeterinarioPerfil = new System.Windows.Forms.GroupBox();
            this.lblUserVeterinario = new System.Windows.Forms.Label();
            this.lblNombreVeterinario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbVeterinarioPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultarExpediente
            // 
            this.btnConsultarExpediente.Location = new System.Drawing.Point(56, 335);
            this.btnConsultarExpediente.Name = "btnConsultarExpediente";
            this.btnConsultarExpediente.Size = new System.Drawing.Size(129, 39);
            this.btnConsultarExpediente.TabIndex = 0;
            this.btnConsultarExpediente.Text = "Consultar Expediente";
            this.btnConsultarExpediente.UseVisualStyleBackColor = true;
            this.btnConsultarExpediente.Click += new System.EventHandler(this.btnConsultarExpediente_Click);
            // 
            // btnCita
            // 
            this.btnCita.Location = new System.Drawing.Point(393, 335);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(75, 39);
            this.btnCita.TabIndex = 1;
            this.btnCita.Text = "Cita";
            this.btnCita.UseVisualStyleBackColor = true;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(526, 335);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(78, 39);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConsultarVacunas
            // 
            this.btnConsultarVacunas.Location = new System.Drawing.Point(220, 335);
            this.btnConsultarVacunas.Name = "btnConsultarVacunas";
            this.btnConsultarVacunas.Size = new System.Drawing.Size(129, 39);
            this.btnConsultarVacunas.TabIndex = 2;
            this.btnConsultarVacunas.Text = "Consultar Vacuna";
            this.btnConsultarVacunas.UseVisualStyleBackColor = true;
            this.btnConsultarVacunas.Click += new System.EventHandler(this.btnConsultarVacunas_Click);
            // 
            // gbVeterinarioPerfil
            // 
            this.gbVeterinarioPerfil.Controls.Add(this.lblUserVeterinario);
            this.gbVeterinarioPerfil.Controls.Add(this.lblNombreVeterinario);
            this.gbVeterinarioPerfil.Location = new System.Drawing.Point(153, 137);
            this.gbVeterinarioPerfil.Name = "gbVeterinarioPerfil";
            this.gbVeterinarioPerfil.Size = new System.Drawing.Size(420, 100);
            this.gbVeterinarioPerfil.TabIndex = 4;
            this.gbVeterinarioPerfil.TabStop = false;
            this.gbVeterinarioPerfil.Text = "Veterinario Perfil";
            // 
            // lblUserVeterinario
            // 
            this.lblUserVeterinario.AutoSize = true;
            this.lblUserVeterinario.Location = new System.Drawing.Point(239, 50);
            this.lblUserVeterinario.Name = "lblUserVeterinario";
            this.lblUserVeterinario.Size = new System.Drawing.Size(96, 13);
            this.lblUserVeterinario.TabIndex = 1;
            this.lblUserVeterinario.Text = "Usuario Veterinario";
            // 
            // lblNombreVeterinario
            // 
            this.lblNombreVeterinario.AutoSize = true;
            this.lblNombreVeterinario.Location = new System.Drawing.Point(50, 50);
            this.lblNombreVeterinario.Name = "lblNombreVeterinario";
            this.lblNombreVeterinario.Size = new System.Drawing.Size(97, 13);
            this.lblNombreVeterinario.TabIndex = 0;
            this.lblNombreVeterinario.Text = "Nombre Veterinario";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-8, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 74);
            this.panel1.TabIndex = 5;
            // 
            // veterinarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbVeterinarioPerfil);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConsultarVacunas);
            this.Controls.Add(this.btnCita);
            this.Controls.Add(this.btnConsultarExpediente);
            this.Name = "veterinarioPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil Veterinario";
            this.Load += new System.EventHandler(this.veterinarioPerfil_Load);
            this.gbVeterinarioPerfil.ResumeLayout(false);
            this.gbVeterinarioPerfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarExpediente;
        private System.Windows.Forms.Button btnCita;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConsultarVacunas;
        private System.Windows.Forms.GroupBox gbVeterinarioPerfil;
        private System.Windows.Forms.Label lblUserVeterinario;
        private System.Windows.Forms.Label lblNombreVeterinario;
        private System.Windows.Forms.Panel panel1;
    }
}