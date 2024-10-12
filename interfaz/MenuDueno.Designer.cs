
namespace Clave1_GrupoDeTrabajo1
{
    partial class MenuDueno
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
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnVerCitas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Location = new System.Drawing.Point(45, 283);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(76, 45);
            this.btnAgendarCita.TabIndex = 0;
            this.btnAgendarCita.Text = "Agendar Cita";
            this.btnAgendarCita.UseVisualStyleBackColor = true;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnVerCitas
            // 
            this.btnVerCitas.Location = new System.Drawing.Point(157, 283);
            this.btnVerCitas.Name = "btnVerCitas";
            this.btnVerCitas.Size = new System.Drawing.Size(76, 45);
            this.btnVerCitas.TabIndex = 1;
            this.btnVerCitas.Text = "Ver Citas";
            this.btnVerCitas.UseVisualStyleBackColor = true;
            this.btnVerCitas.Click += new System.EventHandler(this.btnVerCitas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(379, 283);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 45);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(270, 283);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 45);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar Productos";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // MenuDueno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 405);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerCitas);
            this.Controls.Add(this.btnAgendarCita);
            this.Name = "MenuDueno";
            this.Text = "MenuDueno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnVerCitas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnComprar;
    }
}