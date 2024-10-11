
namespace Clave1_GrupoDeTrabajo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIngresoVete = new System.Windows.Forms.Label();
            this.btnIngresoVete = new System.Windows.Forms.Button();
            this.lblIngresoAdmin = new System.Windows.Forms.Label();
            this.btnIngresoAdmin = new System.Windows.Forms.Button();
            this.lblIngresoDueno = new System.Windows.Forms.Label();
            this.btnIngresoDueno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(22, 38);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cerrar";
            // 
            // lblIngresoVete
            // 
            this.lblIngresoVete.AutoSize = true;
            this.lblIngresoVete.Location = new System.Drawing.Point(19, 248);
            this.lblIngresoVete.Name = "lblIngresoVete";
            this.lblIngresoVete.Size = new System.Drawing.Size(95, 13);
            this.lblIngresoVete.TabIndex = 3;
            this.lblIngresoVete.Text = "Ingreso Veterinario";
            // 
            // btnIngresoVete
            // 
            this.btnIngresoVete.Location = new System.Drawing.Point(29, 277);
            this.btnIngresoVete.Name = "btnIngresoVete";
            this.btnIngresoVete.Size = new System.Drawing.Size(75, 23);
            this.btnIngresoVete.TabIndex = 2;
            this.btnIngresoVete.Text = "Ingresar";
            this.btnIngresoVete.UseVisualStyleBackColor = true;
            this.btnIngresoVete.Click += new System.EventHandler(this.btnIngresoVete_Click);
            // 
            // lblIngresoAdmin
            // 
            this.lblIngresoAdmin.AutoSize = true;
            this.lblIngresoAdmin.Location = new System.Drawing.Point(173, 248);
            this.lblIngresoAdmin.Name = "lblIngresoAdmin";
            this.lblIngresoAdmin.Size = new System.Drawing.Size(108, 13);
            this.lblIngresoAdmin.TabIndex = 5;
            this.lblIngresoAdmin.Text = "Ingreso Administrador";
            // 
            // btnIngresoAdmin
            // 
            this.btnIngresoAdmin.Location = new System.Drawing.Point(183, 277);
            this.btnIngresoAdmin.Name = "btnIngresoAdmin";
            this.btnIngresoAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnIngresoAdmin.TabIndex = 4;
            this.btnIngresoAdmin.Text = "Ingresar";
            this.btnIngresoAdmin.UseVisualStyleBackColor = true;
            this.btnIngresoAdmin.Click += new System.EventHandler(this.btnIngresoAdmin_Click);
            // 
            // lblIngresoDueno
            // 
            this.lblIngresoDueno.AutoSize = true;
            this.lblIngresoDueno.Location = new System.Drawing.Point(317, 248);
            this.lblIngresoDueno.Name = "lblIngresoDueno";
            this.lblIngresoDueno.Size = new System.Drawing.Size(77, 13);
            this.lblIngresoDueno.TabIndex = 7;
            this.lblIngresoDueno.Text = "Ingreso Dueño";
            // 
            // btnIngresoDueno
            // 
            this.btnIngresoDueno.Location = new System.Drawing.Point(327, 277);
            this.btnIngresoDueno.Name = "btnIngresoDueno";
            this.btnIngresoDueno.Size = new System.Drawing.Size(75, 23);
            this.btnIngresoDueno.TabIndex = 6;
            this.btnIngresoDueno.Text = "Ingresar";
            this.btnIngresoDueno.UseVisualStyleBackColor = true;
            this.btnIngresoDueno.Click += new System.EventHandler(this.btnIngresoDueno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 333);
            this.Controls.Add(this.lblIngresoDueno);
            this.Controls.Add(this.btnIngresoDueno);
            this.Controls.Add(this.lblIngresoAdmin);
            this.Controls.Add(this.btnIngresoAdmin);
            this.Controls.Add(this.lblIngresoVete);
            this.Controls.Add(this.btnIngresoVete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Menu principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIngresoVete;
        private System.Windows.Forms.Button btnIngresoVete;
        private System.Windows.Forms.Label lblIngresoAdmin;
        private System.Windows.Forms.Button btnIngresoAdmin;
        private System.Windows.Forms.Label lblIngresoDueno;
        private System.Windows.Forms.Button btnIngresoDueno;
    }
}

