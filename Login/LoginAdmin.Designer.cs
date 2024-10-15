
namespace Clave1_GrupoDeTrabajo1
{
    partial class LoginAdmin
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
            this.btnIngresoAdmin = new System.Windows.Forms.Button();
            this.txtLoginContAdmin = new System.Windows.Forms.TextBox();
            this.txtLoginNomAdmin = new System.Windows.Forms.TextBox();
            this.lblLoginContAdmin = new System.Windows.Forms.Label();
            this.lblLoginNomAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(137, 229);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresoAdmin
            // 
            this.btnIngresoAdmin.Location = new System.Drawing.Point(137, 180);
            this.btnIngresoAdmin.Name = "btnIngresoAdmin";
            this.btnIngresoAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnIngresoAdmin.TabIndex = 22;
            this.btnIngresoAdmin.Text = "Ingresar";
            this.btnIngresoAdmin.UseVisualStyleBackColor = true;
            this.btnIngresoAdmin.Click += new System.EventHandler(this.btnIngresoAdmin_Click);
            // 
            // txtLoginContAdmin
            // 
            this.txtLoginContAdmin.Location = new System.Drawing.Point(149, 108);
            this.txtLoginContAdmin.Name = "txtLoginContAdmin";
            this.txtLoginContAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtLoginContAdmin.TabIndex = 21;
            // 
            // txtLoginNomAdmin
            // 
            this.txtLoginNomAdmin.Location = new System.Drawing.Point(149, 41);
            this.txtLoginNomAdmin.Name = "txtLoginNomAdmin";
            this.txtLoginNomAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtLoginNomAdmin.TabIndex = 20;
            // 
            // lblLoginContAdmin
            // 
            this.lblLoginContAdmin.AutoSize = true;
            this.lblLoginContAdmin.Location = new System.Drawing.Point(60, 97);
            this.lblLoginContAdmin.Name = "lblLoginContAdmin";
            this.lblLoginContAdmin.Size = new System.Drawing.Size(61, 13);
            this.lblLoginContAdmin.TabIndex = 19;
            this.lblLoginContAdmin.Text = "Contrasena";
            // 
            // lblLoginNomAdmin
            // 
            this.lblLoginNomAdmin.AutoSize = true;
            this.lblLoginNomAdmin.Location = new System.Drawing.Point(57, 49);
            this.lblLoginNomAdmin.Name = "lblLoginNomAdmin";
            this.lblLoginNomAdmin.Size = new System.Drawing.Size(44, 13);
            this.lblLoginNomAdmin.TabIndex = 18;
            this.lblLoginNomAdmin.Text = "Nombre";
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 355);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresoAdmin);
            this.Controls.Add(this.txtLoginContAdmin);
            this.Controls.Add(this.txtLoginNomAdmin);
            this.Controls.Add(this.lblLoginContAdmin);
            this.Controls.Add(this.lblLoginNomAdmin);
            this.Name = "LoginAdmin";
            this.Text = "LoginAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresoAdmin;
        private System.Windows.Forms.TextBox txtLoginContAdmin;
        private System.Windows.Forms.TextBox txtLoginNomAdmin;
        private System.Windows.Forms.Label lblLoginContAdmin;
        private System.Windows.Forms.Label lblLoginNomAdmin;
    }
}