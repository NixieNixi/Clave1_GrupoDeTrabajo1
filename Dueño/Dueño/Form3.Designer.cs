
namespace Dueño
{
    partial class Perfil
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNomD = new System.Windows.Forms.Label();
            this.lblUsuD = new System.Windows.Forms.Label();
            this.lblTelD = new System.Windows.Forms.Label();
            this.lblCorreoD = new System.Windows.Forms.Label();
            this.lblDireccD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dirección:";
            // 
            // lblNomD
            // 
            this.lblNomD.AutoSize = true;
            this.lblNomD.Location = new System.Drawing.Point(163, 62);
            this.lblNomD.Name = "lblNomD";
            this.lblNomD.Size = new System.Drawing.Size(35, 13);
            this.lblNomD.TabIndex = 5;
            this.lblNomD.Text = "label6";
            // 
            // lblUsuD
            // 
            this.lblUsuD.AutoSize = true;
            this.lblUsuD.Location = new System.Drawing.Point(163, 87);
            this.lblUsuD.Name = "lblUsuD";
            this.lblUsuD.Size = new System.Drawing.Size(35, 13);
            this.lblUsuD.TabIndex = 6;
            this.lblUsuD.Text = "label7";
            // 
            // lblTelD
            // 
            this.lblTelD.AutoSize = true;
            this.lblTelD.Location = new System.Drawing.Point(168, 115);
            this.lblTelD.Name = "lblTelD";
            this.lblTelD.Size = new System.Drawing.Size(35, 13);
            this.lblTelD.TabIndex = 7;
            this.lblTelD.Text = "label8";
            this.lblTelD.Click += new System.EventHandler(this.lblTelD_Click);
            // 
            // lblCorreoD
            // 
            this.lblCorreoD.AutoSize = true;
            this.lblCorreoD.Location = new System.Drawing.Point(168, 139);
            this.lblCorreoD.Name = "lblCorreoD";
            this.lblCorreoD.Size = new System.Drawing.Size(35, 13);
            this.lblCorreoD.TabIndex = 8;
            this.lblCorreoD.Text = "label9";
            // 
            // lblDireccD
            // 
            this.lblDireccD.AutoSize = true;
            this.lblDireccD.Location = new System.Drawing.Point(171, 162);
            this.lblDireccD.Name = "lblDireccD";
            this.lblDireccD.Size = new System.Drawing.Size(41, 13);
            this.lblDireccD.TabIndex = 9;
            this.lblDireccD.Text = "label10";
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDireccD);
            this.Controls.Add(this.lblCorreoD);
            this.Controls.Add(this.lblTelD);
            this.Controls.Add(this.lblUsuD);
            this.Controls.Add(this.lblNomD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNomD;
        private System.Windows.Forms.Label lblUsuD;
        private System.Windows.Forms.Label lblTelD;
        private System.Windows.Forms.Label lblCorreoD;
        private System.Windows.Forms.Label lblDireccD;
    }
}