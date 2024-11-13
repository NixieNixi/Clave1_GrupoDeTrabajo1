
namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    partial class Tienda
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
            this.btnComprarProducto = new System.Windows.Forms.Button();
            this.btnCanceD = new System.Windows.Forms.Button();
            this.btnVolD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinCompra = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMostrarTotalCompra = new System.Windows.Forms.Label();
            this.dgvCarritoCompras = new System.Windows.Forms.DataGridView();
            this.IdProductoCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProductoCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProductoCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.gbxProductoDisponible = new System.Windows.Forms.GroupBox();
            this.gbxMostrarSeleccion = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCompras)).BeginInit();
            this.gbxProductoDisponible.SuspendLayout();
            this.gbxMostrarSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComprarProducto
            // 
            this.btnComprarProducto.Location = new System.Drawing.Point(235, 14);
            this.btnComprarProducto.Name = "btnComprarProducto";
            this.btnComprarProducto.Size = new System.Drawing.Size(125, 23);
            this.btnComprarProducto.TabIndex = 3;
            this.btnComprarProducto.Text = "Comprar Producto";
            this.btnComprarProducto.UseVisualStyleBackColor = true;
            this.btnComprarProducto.Click += new System.EventHandler(this.btnComprarD_Click);
            // 
            // btnCanceD
            // 
            this.btnCanceD.Location = new System.Drawing.Point(436, 14);
            this.btnCanceD.Name = "btnCanceD";
            this.btnCanceD.Size = new System.Drawing.Size(124, 23);
            this.btnCanceD.TabIndex = 7;
            this.btnCanceD.Text = "Cancelar Producto";
            this.btnCanceD.UseVisualStyleBackColor = true;
            this.btnCanceD.Click += new System.EventHandler(this.btnCanceD_Click);
            // 
            // btnVolD
            // 
            this.btnVolD.Location = new System.Drawing.Point(28, 14);
            this.btnVolD.Name = "btnVolD";
            this.btnVolD.Size = new System.Drawing.Size(98, 23);
            this.btnVolD.TabIndex = 8;
            this.btnVolD.Text = "Volver al Perfil";
            this.btnVolD.UseVisualStyleBackColor = true;
            this.btnVolD.Click += new System.EventHandler(this.btnVolD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 78);
            this.panel2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(39, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "> Perfil del Dueño";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Veterinaria Cat-Dog";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dueño";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnFinCompra);
            this.panel1.Controls.Add(this.btnComprarProducto);
            this.panel1.Controls.Add(this.btnVolD);
            this.panel1.Controls.Add(this.btnCanceD);
            this.panel1.Location = new System.Drawing.Point(-2, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 54);
            this.panel1.TabIndex = 16;
            // 
            // btnFinCompra
            // 
            this.btnFinCompra.Location = new System.Drawing.Point(664, 14);
            this.btnFinCompra.Name = "btnFinCompra";
            this.btnFinCompra.Size = new System.Drawing.Size(122, 23);
            this.btnFinCompra.TabIndex = 9;
            this.btnFinCompra.Text = "Finalizar Compra";
            this.btnFinCompra.UseVisualStyleBackColor = true;
            this.btnFinCompra.Click += new System.EventHandler(this.btnFinCompra_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.PrecioProducto,
            this.DescripcionProducto,
            this.CantidadDisponible});
            this.dgvProductos.Location = new System.Drawing.Point(6, 19);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(802, 185);
            this.dgvProductos.TabIndex = 17;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "ID Producto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.HeaderText = "Precio Producto";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.HeaderText = "Descripcion Producto";
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.ReadOnly = true;
            // 
            // CantidadDisponible
            // 
            this.CantidadDisponible.HeaderText = "Cantidad Disponible";
            this.CantidadDisponible.Name = "CantidadDisponible";
            this.CantidadDisponible.ReadOnly = true;
            // 
            // lblMostrarTotalCompra
            // 
            this.lblMostrarTotalCompra.AutoSize = true;
            this.lblMostrarTotalCompra.Location = new System.Drawing.Point(120, 164);
            this.lblMostrarTotalCompra.Name = "lblMostrarTotalCompra";
            this.lblMostrarTotalCompra.Size = new System.Drawing.Size(31, 13);
            this.lblMostrarTotalCompra.TabIndex = 18;
            this.lblMostrarTotalCompra.Text = "Total";
            // 
            // dgvCarritoCompras
            // 
            this.dgvCarritoCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarritoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarritoCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProductoCarrito,
            this.NombreProductoCarrito,
            this.PrecioProductoCarrito,
            this.CantidadSeleccionada});
            this.dgvCarritoCompras.Location = new System.Drawing.Point(6, 19);
            this.dgvCarritoCompras.Name = "dgvCarritoCompras";
            this.dgvCarritoCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarritoCompras.Size = new System.Drawing.Size(802, 126);
            this.dgvCarritoCompras.TabIndex = 19;
            // 
            // IdProductoCarrito
            // 
            this.IdProductoCarrito.HeaderText = "ID Producto";
            this.IdProductoCarrito.Name = "IdProductoCarrito";
            this.IdProductoCarrito.ReadOnly = true;
            // 
            // NombreProductoCarrito
            // 
            this.NombreProductoCarrito.HeaderText = "Nombre Producto";
            this.NombreProductoCarrito.Name = "NombreProductoCarrito";
            this.NombreProductoCarrito.ReadOnly = true;
            // 
            // PrecioProductoCarrito
            // 
            this.PrecioProductoCarrito.HeaderText = "Precio Producto";
            this.PrecioProductoCarrito.Name = "PrecioProductoCarrito";
            this.PrecioProductoCarrito.ReadOnly = true;
            // 
            // CantidadSeleccionada
            // 
            this.CantidadSeleccionada.HeaderText = "Cantidad Seleccionada";
            this.CantidadSeleccionada.Name = "CantidadSeleccionada";
            this.CantidadSeleccionada.ReadOnly = true;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Location = new System.Drawing.Point(25, 164);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(73, 13);
            this.lblTotalCompra.TabIndex = 20;
            this.lblTotalCompra.Text = "Total Compra:";
            // 
            // gbxProductoDisponible
            // 
            this.gbxProductoDisponible.Controls.Add(this.dgvProductos);
            this.gbxProductoDisponible.Location = new System.Drawing.Point(12, 106);
            this.gbxProductoDisponible.Name = "gbxProductoDisponible";
            this.gbxProductoDisponible.Size = new System.Drawing.Size(814, 210);
            this.gbxProductoDisponible.TabIndex = 22;
            this.gbxProductoDisponible.TabStop = false;
            this.gbxProductoDisponible.Text = "Productos Disponibles";
            // 
            // gbxMostrarSeleccion
            // 
            this.gbxMostrarSeleccion.Controls.Add(this.dgvCarritoCompras);
            this.gbxMostrarSeleccion.Controls.Add(this.lblTotalCompra);
            this.gbxMostrarSeleccion.Controls.Add(this.lblMostrarTotalCompra);
            this.gbxMostrarSeleccion.Location = new System.Drawing.Point(12, 334);
            this.gbxMostrarSeleccion.Name = "gbxMostrarSeleccion";
            this.gbxMostrarSeleccion.Size = new System.Drawing.Size(814, 209);
            this.gbxMostrarSeleccion.TabIndex = 23;
            this.gbxMostrarSeleccion.TabStop = false;
            this.gbxMostrarSeleccion.Text = "Productos en el Carrito";
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(824, 602);
            this.Controls.Add(this.gbxMostrarSeleccion);
            this.Controls.Add(this.gbxProductoDisponible);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Tienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCompras)).EndInit();
            this.gbxProductoDisponible.ResumeLayout(false);
            this.gbxMostrarSeleccion.ResumeLayout(false);
            this.gbxMostrarSeleccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnComprarProducto;
        private System.Windows.Forms.Button btnCanceD;
        private System.Windows.Forms.Button btnVolD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblMostrarTotalCompra;
        private System.Windows.Forms.DataGridView dgvCarritoCompras;
        private System.Windows.Forms.Button btnFinCompra;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDisponible;
        private System.Windows.Forms.GroupBox gbxProductoDisponible;
        private System.Windows.Forms.GroupBox gbxMostrarSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductoCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProductoCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProductoCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadSeleccionada;
    }
}