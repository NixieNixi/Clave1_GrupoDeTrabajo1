
namespace Clave1_GrupoDeTrabajo1
{
    partial class LoginDueno
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresoDueno = new System.Windows.Forms.Button();
            this.btnLoginNomDueno = new System.Windows.Forms.TextBox();
            this.txtLoginNomDueno = new System.Windows.Forms.TextBox();
            this.lblLoginContDueno = new System.Windows.Forms.Label();
            this.lblLoginNomDueno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(161, 263);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresoDueno
            // 
            this.btnIngresoDueno.Location = new System.Drawing.Point(161, 214);
            this.btnIngresoDueno.Name = "btnIngresoDueno";
            this.btnIngresoDueno.Size = new System.Drawing.Size(75, 23);
            this.btnIngresoDueno.TabIndex = 10;
            this.btnIngresoDueno.Text = "Ingresar";
            this.btnIngresoDueno.UseVisualStyleBackColor = true;
            this.btnIngresoDueno.Click += new System.EventHandler(this.btnIngresoDueno_Click);
            // 
            // btnLoginNomDueno
            // 
            this.btnLoginNomDueno.Location = new System.Drawing.Point(173, 142);
            this.btnLoginNomDueno.Name = "btnLoginNomDueno";
            this.btnLoginNomDueno.Size = new System.Drawing.Size(100, 20);
            this.btnLoginNomDueno.TabIndex = 9;
            // 
            // txtLoginNomDueno
            // 
            this.txtLoginNomDueno.Location = new System.Drawing.Point(173, 75);
            this.txtLoginNomDueno.Name = "txtLoginNomDueno";
            this.txtLoginNomDueno.Size = new System.Drawing.Size(100, 20);
            this.txtLoginNomDueno.TabIndex = 8;
            // 
            // lblLoginContDueno
            // 
            this.lblLoginContDueno.AutoSize = true;
            this.lblLoginContDueno.Location = new System.Drawing.Point(84, 131);
            this.lblLoginContDueno.Name = "lblLoginContDueno";
            this.lblLoginContDueno.Size = new System.Drawing.Size(61, 13);
            this.lblLoginContDueno.TabIndex = 7;
            this.lblLoginContDueno.Text = "Contrasena";
            // 
            // lblLoginNomDueno
            // 
            this.lblLoginNomDueno.AutoSize = true;
            this.lblLoginNomDueno.Location = new System.Drawing.Point(81, 83);
            this.lblLoginNomDueno.Name = "lblLoginNomDueno";
            this.lblLoginNomDueno.Size = new System.Drawing.Size(44, 13);
            this.lblLoginNomDueno.TabIndex = 6;
            this.lblLoginNomDueno.Text = "Nombre";
            // 
            // LoginDueno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 359);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresoDueno);
            this.Controls.Add(this.btnLoginNomDueno);
            this.Controls.Add(this.txtLoginNomDueno);
            this.Controls.Add(this.lblLoginContDueno);
            this.Controls.Add(this.lblLoginNomDueno);
            this.Name = "LoginDueno";
            this.Text = "LoginDueno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresoDueno;
        private System.Windows.Forms.TextBox btnLoginNomDueno;
        private System.Windows.Forms.TextBox txtLoginNomDueno;
        private System.Windows.Forms.Label lblLoginContDueno;
        private System.Windows.Forms.Label lblLoginNomDueno;
    }
}