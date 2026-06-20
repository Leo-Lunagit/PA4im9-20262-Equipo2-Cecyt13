namespace PA4IM9_20262_Equipo2.Vistas.Catalogos
{
    partial class TarjetaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarjetaProducto));
            this.lblproducto = new System.Windows.Forms.Label();
            this.lblcostopromedio = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.ptrImagen = new System.Windows.Forms.PictureBox();
            this.lblNoTarjeta = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblCU = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblproducto
            // 
            this.lblproducto.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducto.Location = new System.Drawing.Point(15, 166);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(174, 50);
            this.lblproducto.TabIndex = 5;
            this.lblproducto.Text = "Producto";
            this.lblproducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblcostopromedio
            // 
            this.lblcostopromedio.AutoSize = true;
            this.lblcostopromedio.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostopromedio.Location = new System.Drawing.Point(45, 206);
            this.lblcostopromedio.Margin = new System.Windows.Forms.Padding(0);
            this.lblcostopromedio.Name = "lblcostopromedio";
            this.lblcostopromedio.Size = new System.Drawing.Size(59, 15);
            this.lblcostopromedio.TabIndex = 6;
            this.lblcostopromedio.Text = "$999.99";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(145, 206);
            this.lblcantidad.Margin = new System.Windows.Forms.Padding(0);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(49, 15);
            this.lblcantidad.TabIndex = 7;
            this.lblcantidad.Text = "999KG";
            // 
            // ptrImagen
            // 
            this.ptrImagen.Image = ((System.Drawing.Image)(resources.GetObject("ptrImagen.Image")));
            this.ptrImagen.Location = new System.Drawing.Point(9, 30);
            this.ptrImagen.Name = "ptrImagen";
            this.ptrImagen.Size = new System.Drawing.Size(186, 126);
            this.ptrImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrImagen.TabIndex = 1;
            this.ptrImagen.TabStop = false;
            this.ptrImagen.Click += new System.EventHandler(this.Click_EntrarProducto);
            // 
            // lblNoTarjeta
            // 
            this.lblNoTarjeta.AutoSize = true;
            this.lblNoTarjeta.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTarjeta.Location = new System.Drawing.Point(100, 8);
            this.lblNoTarjeta.Name = "lblNoTarjeta";
            this.lblNoTarjeta.Size = new System.Drawing.Size(14, 15);
            this.lblNoTarjeta.TabIndex = 8;
            this.lblNoTarjeta.Text = "9";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(90, 8);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(14, 15);
            this.lblNo.TabIndex = 9;
            this.lblNo.Text = "#";
            // 
            // lblCU
            // 
            this.lblCU.AutoSize = true;
            this.lblCU.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCU.Location = new System.Drawing.Point(10, 206);
            this.lblCU.Margin = new System.Windows.Forms.Padding(0);
            this.lblCU.Name = "lblCU";
            this.lblCU.Size = new System.Drawing.Size(39, 15);
            this.lblCU.TabIndex = 10;
            this.lblCU.Text = "C/u :";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(106, 206);
            this.lblStock.Margin = new System.Windows.Forms.Padding(0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(44, 15);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Stock:";
            // 
            // TarjetaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblCU);
            this.Controls.Add(this.lblcostopromedio);
            this.Controls.Add(this.lblNoTarjeta);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.ptrImagen);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.Name = "TarjetaProducto";
            this.Size = new System.Drawing.Size(204, 246);
            this.Click += new System.EventHandler(this.Click_EntrarProducto);
            ((System.ComponentModel.ISupportInitialize)(this.ptrImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptrImagen;
        private System.Windows.Forms.Label lblcostopromedio;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblNoTarjeta;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.Label lblCU;
        private System.Windows.Forms.Label lblStock;
    }
}
