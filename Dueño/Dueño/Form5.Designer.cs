
namespace Dueño
{
    partial class Productos
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
            this.btnComprarD = new System.Windows.Forms.Button();
            this.chlsbxAliMascD = new System.Windows.Forms.CheckedListBox();
            this.nudCantidadAliD = new System.Windows.Forms.NumericUpDown();
            this.btnCanCompraD = new System.Windows.Forms.Button();
            this.chlstbxHigieneMascD = new System.Windows.Forms.CheckedListBox();
            this.chlstbxAcceMascD = new System.Windows.Forms.CheckedListBox();
            this.nudCantArtHigD = new System.Windows.Forms.NumericUpDown();
            this.nudCantAcceMascD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAliD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantArtHigD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantAcceMascD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Higiene";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Accesorio";
            // 
            // btnComprarD
            // 
            this.btnComprarD.Location = new System.Drawing.Point(244, 212);
            this.btnComprarD.Name = "btnComprarD";
            this.btnComprarD.Size = new System.Drawing.Size(75, 23);
            this.btnComprarD.TabIndex = 3;
            this.btnComprarD.Text = "Comprar";
            this.btnComprarD.UseVisualStyleBackColor = true;
            // 
            // chlsbxAliMascD
            // 
            this.chlsbxAliMascD.FormattingEnabled = true;
            this.chlsbxAliMascD.Location = new System.Drawing.Point(124, 76);
            this.chlsbxAliMascD.Name = "chlsbxAliMascD";
            this.chlsbxAliMascD.Size = new System.Drawing.Size(120, 49);
            this.chlsbxAliMascD.TabIndex = 4;
            // 
            // nudCantidadAliD
            // 
            this.nudCantidadAliD.Location = new System.Drawing.Point(124, 153);
            this.nudCantidadAliD.Name = "nudCantidadAliD";
            this.nudCantidadAliD.Size = new System.Drawing.Size(120, 20);
            this.nudCantidadAliD.TabIndex = 5;
            this.nudCantidadAliD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnCanCompraD
            // 
            this.btnCanCompraD.Location = new System.Drawing.Point(426, 212);
            this.btnCanCompraD.Name = "btnCanCompraD";
            this.btnCanCompraD.Size = new System.Drawing.Size(75, 23);
            this.btnCanCompraD.TabIndex = 6;
            this.btnCanCompraD.Text = "Cancelar";
            this.btnCanCompraD.UseVisualStyleBackColor = true;
            // 
            // chlstbxHigieneMascD
            // 
            this.chlstbxHigieneMascD.FormattingEnabled = true;
            this.chlstbxHigieneMascD.Location = new System.Drawing.Point(306, 76);
            this.chlstbxHigieneMascD.Name = "chlstbxHigieneMascD";
            this.chlstbxHigieneMascD.Size = new System.Drawing.Size(120, 49);
            this.chlstbxHigieneMascD.TabIndex = 7;
            // 
            // chlstbxAcceMascD
            // 
            this.chlstbxAcceMascD.FormattingEnabled = true;
            this.chlstbxAcceMascD.Location = new System.Drawing.Point(486, 76);
            this.chlstbxAcceMascD.Name = "chlstbxAcceMascD";
            this.chlstbxAcceMascD.Size = new System.Drawing.Size(120, 49);
            this.chlstbxAcceMascD.TabIndex = 8;
            // 
            // nudCantArtHigD
            // 
            this.nudCantArtHigD.Location = new System.Drawing.Point(306, 153);
            this.nudCantArtHigD.Name = "nudCantArtHigD";
            this.nudCantArtHigD.Size = new System.Drawing.Size(120, 20);
            this.nudCantArtHigD.TabIndex = 9;
            // 
            // nudCantAcceMascD
            // 
            this.nudCantAcceMascD.Location = new System.Drawing.Point(486, 153);
            this.nudCantAcceMascD.Name = "nudCantAcceMascD";
            this.nudCantAcceMascD.Size = new System.Drawing.Size(120, 20);
            this.nudCantAcceMascD.TabIndex = 10;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudCantAcceMascD);
            this.Controls.Add(this.nudCantArtHigD);
            this.Controls.Add(this.chlstbxAcceMascD);
            this.Controls.Add(this.chlstbxHigieneMascD);
            this.Controls.Add(this.btnCanCompraD);
            this.Controls.Add(this.nudCantidadAliD);
            this.Controls.Add(this.chlsbxAliMascD);
            this.Controls.Add(this.btnComprarD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAliD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantArtHigD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantAcceMascD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComprarD;
        private System.Windows.Forms.CheckedListBox chlsbxAliMascD;
        private System.Windows.Forms.NumericUpDown nudCantidadAliD;
        private System.Windows.Forms.Button btnCanCompraD;
        private System.Windows.Forms.CheckedListBox chlstbxHigieneMascD;
        private System.Windows.Forms.CheckedListBox chlstbxAcceMascD;
        private System.Windows.Forms.NumericUpDown nudCantArtHigD;
        private System.Windows.Forms.NumericUpDown nudCantAcceMascD;
    }
}