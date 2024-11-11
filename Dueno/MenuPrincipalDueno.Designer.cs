
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIniciarSesionD = new System.Windows.Forms.Button();
            this.btnCerrarD = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 84);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "> Menú Principal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Veterinaria Cat-Dog";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dueño";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.btnIniciarSesionD);
            this.panel1.Controls.Add(this.btnCerrarD);
            this.panel1.Location = new System.Drawing.Point(34, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 184);
            this.panel1.TabIndex = 9;
            // 
            // btnIniciarSesionD
            // 
            this.btnIniciarSesionD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIniciarSesionD.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesionD.Location = new System.Drawing.Point(242, 70);
            this.btnIniciarSesionD.Name = "btnIniciarSesionD";
            this.btnIniciarSesionD.Size = new System.Drawing.Size(102, 42);
            this.btnIniciarSesionD.TabIndex = 3;
            this.btnIniciarSesionD.Text = "Iniciar Sesión";
            this.btnIniciarSesionD.UseVisualStyleBackColor = false;
            // 
            // btnCerrarD
            // 
            this.btnCerrarD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCerrarD.ForeColor = System.Drawing.Color.White;
            this.btnCerrarD.Location = new System.Drawing.Point(77, 70);
            this.btnCerrarD.Name = "btnCerrarD";
            this.btnCerrarD.Size = new System.Drawing.Size(102, 42);
            this.btnCerrarD.TabIndex = 2;
            this.btnCerrarD.Text = "Cerrar";
            this.btnCerrarD.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipalDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(512, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MenuPrincipalDueño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalDueño";
            this.Load += new System.EventHandler(this.MenuPrincipalDueño_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciarSesionD;
        private System.Windows.Forms.Button btnCerrarD;
        private System.Windows.Forms.Label label1;
    }
}