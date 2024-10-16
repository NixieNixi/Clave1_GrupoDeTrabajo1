
namespace Clave1_GrupoDeTrabajo1
{
    partial class MenuVeterinario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbVacunas = new System.Windows.Forms.RadioButton();
            this.rdbExpediente = new System.Windows.Forms.RadioButton();
            this.BtnMenuVeteIr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbExpediente);
            this.groupBox1.Controls.Add(this.rdbVacunas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Tipo de Registro";
            // 
            // rdbVacunas
            // 
            this.rdbVacunas.AutoSize = true;
            this.rdbVacunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVacunas.Location = new System.Drawing.Point(7, 35);
            this.rdbVacunas.Name = "rdbVacunas";
            this.rdbVacunas.Size = new System.Drawing.Size(67, 17);
            this.rdbVacunas.TabIndex = 0;
            this.rdbVacunas.TabStop = true;
            this.rdbVacunas.Text = "Vacunas";
            this.rdbVacunas.UseVisualStyleBackColor = true;
            // 
            // rdbExpediente
            // 
            this.rdbExpediente.AutoSize = true;
            this.rdbExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExpediente.Location = new System.Drawing.Point(6, 68);
            this.rdbExpediente.Name = "rdbExpediente";
            this.rdbExpediente.Size = new System.Drawing.Size(112, 17);
            this.rdbExpediente.TabIndex = 1;
            this.rdbExpediente.TabStop = true;
            this.rdbExpediente.Text = "Expediente Clinico";
            this.rdbExpediente.UseVisualStyleBackColor = true;
            // 
            // BtnMenuVeteIr
            // 
            this.BtnMenuVeteIr.Location = new System.Drawing.Point(20, 119);
            this.BtnMenuVeteIr.Name = "BtnMenuVeteIr";
            this.BtnMenuVeteIr.Size = new System.Drawing.Size(75, 23);
            this.BtnMenuVeteIr.TabIndex = 2;
            this.BtnMenuVeteIr.Text = "Ir";
            this.BtnMenuVeteIr.UseVisualStyleBackColor = true;
            // 
            // MenuVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 162);
            this.Controls.Add(this.BtnMenuVeteIr);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuVeterinario";
            this.Text = "MenuVeterinario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbExpediente;
        private System.Windows.Forms.RadioButton rdbVacunas;
        private System.Windows.Forms.Button BtnMenuVeteIr;
    }
}