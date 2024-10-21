
namespace Clave1_GrupoDeTrabajo1
{
    partial class Login
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
            this.btnDueño = new System.Windows.Forms.Button();
            this.btnVeterinario = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDueño
            // 
            this.btnDueño.Location = new System.Drawing.Point(55, 75);
            this.btnDueño.Name = "btnDueño";
            this.btnDueño.Size = new System.Drawing.Size(75, 23);
            this.btnDueño.TabIndex = 0;
            this.btnDueño.Text = "Dueño";
            this.btnDueño.UseVisualStyleBackColor = true;
            this.btnDueño.Click += new System.EventHandler(this.btnDueño_Click);
            // 
            // btnVeterinario
            // 
            this.btnVeterinario.Location = new System.Drawing.Point(55, 124);
            this.btnVeterinario.Name = "btnVeterinario";
            this.btnVeterinario.Size = new System.Drawing.Size(75, 23);
            this.btnVeterinario.TabIndex = 0;
            this.btnVeterinario.Text = "Veterinario";
            this.btnVeterinario.UseVisualStyleBackColor = true;
            this.btnVeterinario.Click += new System.EventHandler(this.btnVeterinario_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(55, 185);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(211, 124);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 366);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnVeterinario);
            this.Controls.Add(this.btnDueño);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDueño;
        private System.Windows.Forms.Button btnVeterinario;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSalir;
    }
}