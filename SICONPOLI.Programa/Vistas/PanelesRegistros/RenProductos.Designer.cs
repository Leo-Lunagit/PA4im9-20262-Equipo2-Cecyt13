namespace PA4IM9_20262_Equipo2.Vistas.PanelesRegistros
{
    partial class RenProductos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMonto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.AutoSize = true;
            this.txtMonto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(255, 6);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(0);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(81, 18);
            this.txtMonto.TabIndex = 11;
            this.txtMonto.Text = "$999,999.99";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(208, 6);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(0);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(47, 18);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.Text = "99.999";
            // 
            // txtProducto
            // 
            this.txtProducto.AutoSize = true;
            this.txtProducto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(5, 6);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(0);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(73, 18);
            this.txtProducto.TabIndex = 12;
            this.txtProducto.Text = "{Producto}";
            // 
            // RenProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtCantidad);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(336, 30);
            this.MinimumSize = new System.Drawing.Size(336, 30);
            this.Name = "RenProductos";
            this.Size = new System.Drawing.Size(336, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMonto;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.Label txtProducto;
    }
}
