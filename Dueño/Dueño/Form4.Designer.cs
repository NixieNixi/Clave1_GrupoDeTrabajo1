
namespace Dueño
{
    partial class Acciones
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
            this.btnComprarD = new System.Windows.Forms.Button();
            this.btnPerfilMascotaD = new System.Windows.Forms.Button();
            this.btnCitaD = new System.Windows.Forms.Button();
            this.btnCerrarSesionD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComprarD
            // 
            this.btnComprarD.Location = new System.Drawing.Point(465, 105);
            this.btnComprarD.Name = "btnComprarD";
            this.btnComprarD.Size = new System.Drawing.Size(118, 23);
            this.btnComprarD.TabIndex = 0;
            this.btnComprarD.Text = "Comprar";
            this.btnComprarD.UseVisualStyleBackColor = true;
            // 
            // btnPerfilMascotaD
            // 
            this.btnPerfilMascotaD.Location = new System.Drawing.Point(202, 105);
            this.btnPerfilMascotaD.Name = "btnPerfilMascotaD";
            this.btnPerfilMascotaD.Size = new System.Drawing.Size(118, 23);
            this.btnPerfilMascotaD.TabIndex = 1;
            this.btnPerfilMascotaD.Text = "Perfil Mascota";
            this.btnPerfilMascotaD.UseVisualStyleBackColor = true;
            // 
            // btnCitaD
            // 
            this.btnCitaD.Location = new System.Drawing.Point(202, 150);
            this.btnCitaD.Name = "btnCitaD";
            this.btnCitaD.Size = new System.Drawing.Size(118, 23);
            this.btnCitaD.TabIndex = 2;
            this.btnCitaD.Text = "Cita";
            this.btnCitaD.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesionD
            // 
            this.btnCerrarSesionD.Location = new System.Drawing.Point(465, 150);
            this.btnCerrarSesionD.Name = "btnCerrarSesionD";
            this.btnCerrarSesionD.Size = new System.Drawing.Size(118, 23);
            this.btnCerrarSesionD.TabIndex = 3;
            this.btnCerrarSesionD.Text = "Cerrar Sesión";
            this.btnCerrarSesionD.UseVisualStyleBackColor = true;
            // 
            // Acciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarSesionD);
            this.Controls.Add(this.btnCitaD);
            this.Controls.Add(this.btnPerfilMascotaD);
            this.Controls.Add(this.btnComprarD);
            this.Name = "Acciones";
            this.Text = "Acciones";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComprarD;
        private System.Windows.Forms.Button btnPerfilMascotaD;
        private System.Windows.Forms.Button btnCitaD;
        private System.Windows.Forms.Button btnCerrarSesionD;
    }
}