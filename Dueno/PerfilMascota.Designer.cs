
namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    partial class PerfilMascota
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
            this.lblIDMascD = new System.Windows.Forms.Label();
            this.lblNomMascD = new System.Windows.Forms.Label();
            this.lblEspeMascD = new System.Windows.Forms.Label();
            this.lblEdadMascD = new System.Windows.Forms.Label();
            this.btnCitasMascD = new System.Windows.Forms.Button();
            this.btnVolverD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Mascota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad:";
            // 
            // lblIDMascD
            // 
            this.lblIDMascD.AutoSize = true;
            this.lblIDMascD.Location = new System.Drawing.Point(151, 40);
            this.lblIDMascD.Name = "lblIDMascD";
            this.lblIDMascD.Size = new System.Drawing.Size(35, 13);
            this.lblIDMascD.TabIndex = 6;
            this.lblIDMascD.Text = "label5";
            // 
            // lblNomMascD
            // 
            this.lblNomMascD.AutoSize = true;
            this.lblNomMascD.Location = new System.Drawing.Point(151, 79);
            this.lblNomMascD.Name = "lblNomMascD";
            this.lblNomMascD.Size = new System.Drawing.Size(35, 13);
            this.lblNomMascD.TabIndex = 5;
            this.lblNomMascD.Text = "label6";
            // 
            // lblEspeMascD
            // 
            this.lblEspeMascD.AutoSize = true;
            this.lblEspeMascD.Location = new System.Drawing.Point(151, 119);
            this.lblEspeMascD.Name = "lblEspeMascD";
            this.lblEspeMascD.Size = new System.Drawing.Size(35, 13);
            this.lblEspeMascD.TabIndex = 4;
            this.lblEspeMascD.Text = "label7";
            // 
            // lblEdadMascD
            // 
            this.lblEdadMascD.AutoSize = true;
            this.lblEdadMascD.Location = new System.Drawing.Point(151, 153);
            this.lblEdadMascD.Name = "lblEdadMascD";
            this.lblEdadMascD.Size = new System.Drawing.Size(35, 13);
            this.lblEdadMascD.TabIndex = 7;
            this.lblEdadMascD.Text = "label8";
            // 
            // btnCitasMascD
            // 
            this.btnCitasMascD.Location = new System.Drawing.Point(385, 79);
            this.btnCitasMascD.Name = "btnCitasMascD";
            this.btnCitasMascD.Size = new System.Drawing.Size(130, 23);
            this.btnCitasMascD.TabIndex = 9;
            this.btnCitasMascD.Text = "Citas Mascota";
            this.btnCitasMascD.UseVisualStyleBackColor = true;
            this.btnCitasMascD.Click += new System.EventHandler(this.btnCitasMascD_Click);
            // 
            // btnVolverD
            // 
            this.btnVolverD.Location = new System.Drawing.Point(385, 108);
            this.btnVolverD.Name = "btnVolverD";
            this.btnVolverD.Size = new System.Drawing.Size(130, 23);
            this.btnVolverD.TabIndex = 10;
            this.btnVolverD.Text = "Volver";
            this.btnVolverD.UseVisualStyleBackColor = true;
            this.btnVolverD.Click += new System.EventHandler(this.btnVolverD_Click);
            // 
            // PerfilMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverD);
            this.Controls.Add(this.btnCitasMascD);
            this.Controls.Add(this.lblEdadMascD);
            this.Controls.Add(this.lblIDMascD);
            this.Controls.Add(this.lblNomMascD);
            this.Controls.Add(this.lblEspeMascD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PerfilMascota";
            this.Text = "PerfilMascota";
            this.Load += new System.EventHandler(this.PerfilMascota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIDMascD;
        private System.Windows.Forms.Label lblNomMascD;
        private System.Windows.Forms.Label lblEspeMascD;
        private System.Windows.Forms.Label lblEdadMascD;
        private System.Windows.Forms.Button btnCitasMascD;
        private System.Windows.Forms.Button btnVolverD;
    }
}