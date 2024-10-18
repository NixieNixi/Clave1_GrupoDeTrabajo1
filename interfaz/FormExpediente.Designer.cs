
namespace Clave1_GrupoDeTrabajo1
{
    partial class formExpediente
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
            this.btnIrVeteExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIrVeteExp
            // 
            this.btnIrVeteExp.Location = new System.Drawing.Point(275, 13);
            this.btnIrVeteExp.Name = "btnIrVeteExp";
            this.btnIrVeteExp.Size = new System.Drawing.Size(75, 53);
            this.btnIrVeteExp.TabIndex = 0;
            this.btnIrVeteExp.Text = "Ir a Menu Veterinario";
            this.btnIrVeteExp.UseVisualStyleBackColor = true;
            this.btnIrVeteExp.Click += new System.EventHandler(this.btnIrVeteExp_Click);
            // 
            // formExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 308);
            this.Controls.Add(this.btnIrVeteExp);
            this.Name = "formExpediente";
            this.Text = "Expediente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIrVeteExp;
    }
}