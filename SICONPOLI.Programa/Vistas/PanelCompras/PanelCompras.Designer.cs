namespace PA4IM9_20262_Equipo2
{
    partial class Panel_de_compras
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
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblPreciofinal = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.lblCostounitario = new System.Windows.Forms.Label();
            this.lblTotaldeproductos = new System.Windows.Forms.Label();
            this.txtTotalProductos = new System.Windows.Forms.TextBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.nudCostoUnitario = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvSubcuentas = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(108, 9);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(106, 23);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(170, 195);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(45, 23);
            this.lblIVA.TabIndex = 1;
            this.lblIVA.Text = "IVA";
            // 
            // lblPreciofinal
            // 
            this.lblPreciofinal.AutoSize = true;
            this.lblPreciofinal.Location = new System.Drawing.Point(139, 262);
            this.lblPreciofinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreciofinal.Name = "lblPreciofinal";
            this.lblPreciofinal.Size = new System.Drawing.Size(122, 23);
            this.lblPreciofinal.TabIndex = 4;
            this.lblPreciofinal.Text = "Precio Final";
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Location = new System.Drawing.Point(590, 9);
            this.lblProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(131, 23);
            this.lblProveedores.TabIndex = 5;
            this.lblProveedores.Text = "Proveedores";
            // 
            // lblCostounitario
            // 
            this.lblCostounitario.AutoSize = true;
            this.lblCostounitario.Location = new System.Drawing.Point(400, 9);
            this.lblCostounitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostounitario.Name = "lblCostounitario";
            this.lblCostounitario.Size = new System.Drawing.Size(146, 23);
            this.lblCostounitario.TabIndex = 6;
            this.lblCostounitario.Text = "Costo Unitario";
            // 
            // lblTotaldeproductos
            // 
            this.lblTotaldeproductos.AutoSize = true;
            this.lblTotaldeproductos.Location = new System.Drawing.Point(139, 132);
            this.lblTotaldeproductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotaldeproductos.Name = "lblTotaldeproductos";
            this.lblTotaldeproductos.Size = new System.Drawing.Size(191, 23);
            this.lblTotaldeproductos.TabIndex = 8;
            this.lblTotaldeproductos.Text = "Total de productos";
            // 
            // txtTotalProductos
            // 
            this.txtTotalProductos.Enabled = false;
            this.txtTotalProductos.Location = new System.Drawing.Point(322, 129);
            this.txtTotalProductos.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalProductos.Name = "txtTotalProductos";
            this.txtTotalProductos.Size = new System.Drawing.Size(102, 32);
            this.txtTotalProductos.TabIndex = 10;
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Items.AddRange(new object[] {
            "Laptops",
            "Monitor",
            "PCs",
            "Dispositivos portatiles"});
            this.cmbProductos.Location = new System.Drawing.Point(24, 51);
            this.cmbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(259, 31);
            this.cmbProductos.TabIndex = 12;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(315, 51);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(48, 32);
            this.nudCantidad.TabIndex = 13;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(322, 195);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(102, 32);
            this.txtIVA.TabIndex = 16;
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Enabled = false;
            this.txtPrecioFinal.Location = new System.Drawing.Point(322, 256);
            this.txtPrecioFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(102, 32);
            this.txtPrecioFinal.TabIndex = 18;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(541, 189);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 38);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(541, 51);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(199, 32);
            this.txtProveedor.TabIndex = 20;
            // 
            // nudCostoUnitario
            // 
            this.nudCostoUnitario.DecimalPlaces = 2;
            this.nudCostoUnitario.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCostoUnitario.Location = new System.Drawing.Point(404, 51);
            this.nudCostoUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.nudCostoUnitario.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudCostoUnitario.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCostoUnitario.Name = "nudCostoUnitario";
            this.nudCostoUnitario.Size = new System.Drawing.Size(109, 32);
            this.nudCostoUnitario.TabIndex = 21;
            this.nudCostoUnitario.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(297, 9);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(101, 23);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgvSubcuentas
            // 
            this.dgvSubcuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubcuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubcuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.cantidad,
            this.costoUnitario,
            this.totalProductos,
            this.proveedor});
            this.dgvSubcuentas.Location = new System.Drawing.Point(65, 308);
            this.dgvSubcuentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSubcuentas.Name = "dgvSubcuentas";
            this.dgvSubcuentas.RowHeadersWidth = 51;
            this.dgvSubcuentas.Size = new System.Drawing.Size(693, 254);
            this.dgvSubcuentas.TabIndex = 24;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // costoUnitario
            // 
            this.costoUnitario.HeaderText = "Costo Unitario";
            this.costoUnitario.MinimumWidth = 6;
            this.costoUnitario.Name = "costoUnitario";
            this.costoUnitario.ReadOnly = true;
            // 
            // totalProductos
            // 
            this.totalProductos.HeaderText = "Subtotal";
            this.totalProductos.MinimumWidth = 6;
            this.totalProductos.Name = "totalProductos";
            this.totalProductos.ReadOnly = true;
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.MinimumWidth = 6;
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            // 
            // Panel_de_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(811, 575);
            this.Controls.Add(this.dgvSubcuentas);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.nudCostoUnitario);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtPrecioFinal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.txtTotalProductos);
            this.Controls.Add(this.lblTotaldeproductos);
            this.Controls.Add(this.lblCostounitario);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.lblPreciofinal);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblProductos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Panel_de_compras";
            this.Text = "Panel_de_compras";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblPreciofinal;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Label lblCostounitario;
        private System.Windows.Forms.Label lblTotaldeproductos;
        private System.Windows.Forms.TextBox txtTotalProductos;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.NumericUpDown nudCostoUnitario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgvSubcuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
    }
}