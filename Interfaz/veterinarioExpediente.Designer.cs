
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
            this.tabControlExpediente.SuspendLayout();
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
            // veterinarioExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 448);
            this.Controls.Add(this.tabControlExpediente);
            this.Name = "veterinarioExpediente";
            this.Text = "veterinarioExpediente";
            this.tabControlExpediente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlExpediente;
        private System.Windows.Forms.TabPage tabDatosMascota;
        private System.Windows.Forms.TabPage tabDatosDueno;
        private System.Windows.Forms.TabPage tabHistorialMedico;
    }
}