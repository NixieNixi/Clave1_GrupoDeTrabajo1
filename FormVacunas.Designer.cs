
namespace Clave1_GrupoDeTrabajo1
{
    partial class formVacunas
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
            this.btnIrVeteVac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIrVeteVac
            // 
            this.btnIrVeteVac.Location = new System.Drawing.Point(271, 12);
            this.btnIrVeteVac.Name = "btnIrVeteVac";
            this.btnIrVeteVac.Size = new System.Drawing.Size(75, 50);
            this.btnIrVeteVac.TabIndex = 1;
            this.btnIrVeteVac.Text = "Ir a Menu Veterinario";
            this.btnIrVeteVac.UseVisualStyleBackColor = true;
            this.btnIrVeteVac.Click += new System.EventHandler(this.btnIrVeteVac_Click);
            // 
            // formVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 294);
            this.Controls.Add(this.btnIrVeteVac);
            this.Name = "formVacunas";
            this.Text = "Historial de Vacunas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIrVeteVac;
    }
}