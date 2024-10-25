
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuarioD
            // 
            this.txtUsuarioD.Location = new System.Drawing.Point(345, 133);
            this.txtUsuarioD.Name = "txtUsuarioD";
            this.txtUsuarioD.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioD.TabIndex = 2;
            // 
            // txtContraD
            // 
            this.txtContraD.Location = new System.Drawing.Point(345, 165);
            this.txtContraD.Name = "txtContraD";
            this.txtContraD.Size = new System.Drawing.Size(100, 20);
            this.txtContraD.TabIndex = 3;
            // 
            // btnIniciarD
            // 
            this.btnIniciarD.Location = new System.Drawing.Point(468, 229);
            this.btnIniciarD.Name = "btnIniciarD";
            this.btnIniciarD.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarD.TabIndex = 4;
            this.btnIniciarD.Text = "Iniciar";
            this.btnIniciarD.UseVisualStyleBackColor = true;
            this.btnIniciarD.Click += new System.EventHandler(this.btnIniciarD_Click);
            // 
            // btnVolverD
            // 
            this.btnVolverD.Location = new System.Drawing.Point(232, 228);
            this.btnVolverD.Name = "btnVolverD";
            this.btnVolverD.Size = new System.Drawing.Size(75, 23);
            this.btnVolverD.TabIndex = 5;
            this.btnVolverD.Text = "Volver";
            this.btnVolverD.UseVisualStyleBackColor = true;
            this.btnVolverD.Click += new System.EventHandler(this.btnVolverD_Click);
            // 
            // IniciarSesionDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverD);
            this.Controls.Add(this.btnIniciarD);
            this.Controls.Add(this.txtContraD);
            this.Controls.Add(this.txtUsuarioD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IniciarSesionDueño";
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
    }
}