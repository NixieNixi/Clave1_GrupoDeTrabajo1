
namespace Clave1_GrupoDeTrabajo1
{
    partial class LoginVeterinario
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
            this.btnIngresoVete = new System.Windows.Forms.Button();
            this.btnLoginContVete = new System.Windows.Forms.TextBox();
            this.btnLoginNomVete = new System.Windows.Forms.TextBox();
            this.lblContLoginVete = new System.Windows.Forms.Label();
            this.lblNomLoginVete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(148, 235);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresoVete
            // 
            this.btnIngresoVete.Location = new System.Drawing.Point(148, 186);
            this.btnIngresoVete.Name = "btnIngresoVete";
            this.btnIngresoVete.Size = new System.Drawing.Size(75, 23);
            this.btnIngresoVete.TabIndex = 16;
            this.btnIngresoVete.Text = "Ingresar";
            this.btnIngresoVete.UseVisualStyleBackColor = true;
            this.btnIngresoVete.Click += new System.EventHandler(this.btnIngresoVete_Click);
            // 
            // btnLoginContVete
            // 
            this.btnLoginContVete.Location = new System.Drawing.Point(160, 114);
            this.btnLoginContVete.Name = "btnLoginContVete";
            this.btnLoginContVete.Size = new System.Drawing.Size(100, 20);
            this.btnLoginContVete.TabIndex = 15;
            // 
            // btnLoginNomVete
            // 
            this.btnLoginNomVete.Location = new System.Drawing.Point(160, 47);
            this.btnLoginNomVete.Name = "btnLoginNomVete";
            this.btnLoginNomVete.Size = new System.Drawing.Size(100, 20);
            this.btnLoginNomVete.TabIndex = 14;
            // 
            // lblContLoginVete
            // 
            this.lblContLoginVete.AutoSize = true;
            this.lblContLoginVete.Location = new System.Drawing.Point(71, 103);
            this.lblContLoginVete.Name = "lblContLoginVete";
            this.lblContLoginVete.Size = new System.Drawing.Size(61, 13);
            this.lblContLoginVete.TabIndex = 13;
            this.lblContLoginVete.Text = "Contrasena";
            // 
            // lblNomLoginVete
            // 
            this.lblNomLoginVete.AutoSize = true;
            this.lblNomLoginVete.Location = new System.Drawing.Point(68, 55);
            this.lblNomLoginVete.Name = "lblNomLoginVete";
            this.lblNomLoginVete.Size = new System.Drawing.Size(44, 13);
            this.lblNomLoginVete.TabIndex = 12;
            this.lblNomLoginVete.Text = "Nombre";
            // 
            // LoginVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 377);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresoVete);
            this.Controls.Add(this.btnLoginContVete);
            this.Controls.Add(this.btnLoginNomVete);
            this.Controls.Add(this.lblContLoginVete);
            this.Controls.Add(this.lblNomLoginVete);
            this.Name = "LoginVeterinario";
            this.Text = "LoginVeterinario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresoVete;
        private System.Windows.Forms.TextBox btnLoginContVete;
        private System.Windows.Forms.TextBox btnLoginNomVete;
        private System.Windows.Forms.Label lblContLoginVete;
        private System.Windows.Forms.Label lblNomLoginVete;
    }
}