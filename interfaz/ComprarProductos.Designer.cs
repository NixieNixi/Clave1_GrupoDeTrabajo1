
namespace Clave1_GrupoDeTrabajo1
{
    partial class ComprarProductos
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
            this.btnVolverMenuDueno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolverMenuDueno
            // 
            this.btnVolverMenuDueno.Location = new System.Drawing.Point(628, 356);
            this.btnVolverMenuDueno.Name = "btnVolverMenuDueno";
            this.btnVolverMenuDueno.Size = new System.Drawing.Size(106, 42);
            this.btnVolverMenuDueno.TabIndex = 1;
            this.btnVolverMenuDueno.Text = "Volver Menu Dueno";
            this.btnVolverMenuDueno.UseVisualStyleBackColor = true;
            this.btnVolverMenuDueno.Click += new System.EventHandler(this.btnVolverMenuDueno_Click);
            // 
            // ComprarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverMenuDueno);
            this.Name = "ComprarProductos";
            this.Text = "ComprarProductos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolverMenuDueno;
    }
}