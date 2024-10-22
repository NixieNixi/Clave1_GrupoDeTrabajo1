
namespace Dueño
{
    partial class MenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarD = new System.Windows.Forms.Button();
            this.btnIniciarSesionD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCerrarD
            // 
            this.btnCerrarD.Location = new System.Drawing.Point(147, 175);
            this.btnCerrarD.Name = "btnCerrarD";
            this.btnCerrarD.Size = new System.Drawing.Size(154, 53);
            this.btnCerrarD.TabIndex = 1;
            this.btnCerrarD.Text = "Cerrar";
            this.btnCerrarD.UseVisualStyleBackColor = true;
            // 
            // btnIniciarSesionD
            // 
            this.btnIniciarSesionD.Location = new System.Drawing.Point(335, 175);
            this.btnIniciarSesionD.Name = "btnIniciarSesionD";
            this.btnIniciarSesionD.Size = new System.Drawing.Size(154, 53);
            this.btnIniciarSesionD.TabIndex = 2;
            this.btnIniciarSesionD.Text = "Iniciar Seción";
            this.btnIniciarSesionD.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciarSesionD);
            this.Controls.Add(this.btnCerrarD);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarD;
        private System.Windows.Forms.Button btnIniciarSesionD;
    }
}

