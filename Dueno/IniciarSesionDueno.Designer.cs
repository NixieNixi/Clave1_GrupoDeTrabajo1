
namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    partial class IniciarSesionDueno
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioD = new System.Windows.Forms.TextBox();
            this.txtContraD = new System.Windows.Forms.TextBox();
            this.btnIniciarD = new System.Windows.Forms.Button();
            this.btnVolverD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(355, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(355, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuarioD
            // 
            this.txtUsuarioD.Location = new System.Drawing.Point(435, 184);
            this.txtUsuarioD.Name = "txtUsuarioD";
            this.txtUsuarioD.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioD.TabIndex = 2;
            // 
            // txtContraD
            // 
            this.txtContraD.Location = new System.Drawing.Point(435, 216);
            this.txtContraD.Name = "txtContraD";
            this.txtContraD.Size = new System.Drawing.Size(100, 20);
            this.txtContraD.TabIndex = 3;
            // 
            // btnIniciarD
            // 
            this.btnIniciarD.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnIniciarD.ForeColor = System.Drawing.Color.White;
            this.btnIniciarD.Location = new System.Drawing.Point(558, 280);
            this.btnIniciarD.Name = "btnIniciarD";
            this.btnIniciarD.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarD.TabIndex = 4;
            this.btnIniciarD.Text = "Iniciar";
            this.btnIniciarD.UseVisualStyleBackColor = false;
            this.btnIniciarD.Click += new System.EventHandler(this.btnIniciarD_Click);
            // 
            // btnVolverD
            // 
            this.btnVolverD.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVolverD.ForeColor = System.Drawing.Color.White;
            this.btnVolverD.Location = new System.Drawing.Point(322, 279);
            this.btnVolverD.Name = "btnVolverD";
            this.btnVolverD.Size = new System.Drawing.Size(75, 23);
            this.btnVolverD.TabIndex = 5;
            this.btnVolverD.Text = "Volver";
            this.btnVolverD.UseVisualStyleBackColor = false;
            this.btnVolverD.Click += new System.EventHandler(this.btnVolverD_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Location = new System.Drawing.Point(-9, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 381);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Location = new System.Drawing.Point(-8, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 84);
            this.panel2.TabIndex = 7;
            // 
            // IniciarSesionDueno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolverD);
            this.Controls.Add(this.btnIniciarD);
            this.Controls.Add(this.txtContraD);
            this.Controls.Add(this.txtUsuarioD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IniciarSesionDueno";
            this.Text = "IniciarSesionDueño";
            this.Load += new System.EventHandler(this.IniciarSesionDueño_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioD;
        private System.Windows.Forms.TextBox txtContraD;
        private System.Windows.Forms.Button btnIniciarD;
        private System.Windows.Forms.Button btnVolverD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}