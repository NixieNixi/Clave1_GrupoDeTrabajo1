
namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    partial class MenuPrincipalDueño
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
            this.btnCerrarD = new System.Windows.Forms.Button();
            this.btnIniciarSesionD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrarD
            // 
            this.btnCerrarD.Location = new System.Drawing.Point(194, 181);
            this.btnCerrarD.Name = "btnCerrarD";
            this.btnCerrarD.Size = new System.Drawing.Size(164, 59);
            this.btnCerrarD.TabIndex = 0;
            this.btnCerrarD.Text = "Cerrar";
            this.btnCerrarD.UseVisualStyleBackColor = true;
            // 
            // btnIniciarSesionD
            // 
            this.btnIniciarSesionD.Location = new System.Drawing.Point(396, 181);
            this.btnIniciarSesionD.Name = "btnIniciarSesionD";
            this.btnIniciarSesionD.Size = new System.Drawing.Size(164, 59);
            this.btnIniciarSesionD.TabIndex = 1;
            this.btnIniciarSesionD.Text = "Iniciar Sesión";
            this.btnIniciarSesionD.UseVisualStyleBackColor = true;
            this.btnIniciarSesionD.Click += new System.EventHandler(this.btnIniciarSesionD_Click);
            // 
            // MenuPrincipalDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciarSesionD);
            this.Controls.Add(this.btnCerrarD);
            this.Name = "MenuPrincipalDueño";
            this.Text = "MenuPrincipalDueño";
            this.Load += new System.EventHandler(this.MenuPrincipalDueño_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarD;
        private System.Windows.Forms.Button btnIniciarSesionD;
    }
}