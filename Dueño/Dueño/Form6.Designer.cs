
namespace Dueño
{
    partial class PerfiMascota
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
            this.lblNomMascotaD = new System.Windows.Forms.Label();
            this.lblEspMascotaD = new System.Windows.Forms.Label();
            this.lblEdadMascD = new System.Windows.Forms.Label();
            this.btnCitasD = new System.Windows.Forms.Button();
            this.btnVolverD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            // 
            // lblNomMascotaD
            // 
            this.lblNomMascotaD.AutoSize = true;
            this.lblNomMascotaD.Location = new System.Drawing.Point(213, 54);
            this.lblNomMascotaD.Name = "lblNomMascotaD";
            this.lblNomMascotaD.Size = new System.Drawing.Size(35, 13);
            this.lblNomMascotaD.TabIndex = 3;
            this.lblNomMascotaD.Text = "label4";
            // 
            // lblEspMascotaD
            // 
            this.lblEspMascotaD.AutoSize = true;
            this.lblEspMascotaD.Location = new System.Drawing.Point(216, 85);
            this.lblEspMascotaD.Name = "lblEspMascotaD";
            this.lblEspMascotaD.Size = new System.Drawing.Size(35, 13);
            this.lblEspMascotaD.TabIndex = 4;
            this.lblEspMascotaD.Text = "label5";
            // 
            // lblEdadMascD
            // 
            this.lblEdadMascD.AutoSize = true;
            this.lblEdadMascD.Location = new System.Drawing.Point(216, 122);
            this.lblEdadMascD.Name = "lblEdadMascD";
            this.lblEdadMascD.Size = new System.Drawing.Size(35, 13);
            this.lblEdadMascD.TabIndex = 5;
            this.lblEdadMascD.Text = "label6";
            // 
            // btnCitasD
            // 
            this.btnCitasD.Location = new System.Drawing.Point(89, 193);
            this.btnCitasD.Name = "btnCitasD";
            this.btnCitasD.Size = new System.Drawing.Size(75, 23);
            this.btnCitasD.TabIndex = 6;
            this.btnCitasD.Text = "Citas";
            this.btnCitasD.UseVisualStyleBackColor = true;
            // 
            // btnVolverD
            // 
            this.btnVolverD.Location = new System.Drawing.Point(203, 193);
            this.btnVolverD.Name = "btnVolverD";
            this.btnVolverD.Size = new System.Drawing.Size(75, 23);
            this.btnVolverD.TabIndex = 7;
            this.btnVolverD.Text = "Volver";
            this.btnVolverD.UseVisualStyleBackColor = true;
            // 
            // PerfiMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverD);
            this.Controls.Add(this.btnCitasD);
            this.Controls.Add(this.lblEdadMascD);
            this.Controls.Add(this.lblEspMascotaD);
            this.Controls.Add(this.lblNomMascotaD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PerfiMascota";
            this.Text = "PerfiMascota";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomMascotaD;
        private System.Windows.Forms.Label lblEspMascotaD;
        private System.Windows.Forms.Label lblEdadMascD;
        private System.Windows.Forms.Button btnCitasD;
        private System.Windows.Forms.Button btnVolverD;
    }
}