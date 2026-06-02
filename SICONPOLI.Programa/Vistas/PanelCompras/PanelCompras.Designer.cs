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
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(139, 9);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(87, 21);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(170, 195);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(37, 21);
            this.lblIVA.TabIndex = 1;
            this.lblIVA.Text = "IVA";
            // 
            // lblPreciofinal
            // 
            this.lblPreciofinal.AutoSize = true;
            this.lblPreciofinal.Location = new System.Drawing.Point(139, 262);
            this.lblPreciofinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreciofinal.Name = "lblPreciofinal";
            this.lblPreciofinal.Size = new System.Drawing.Size(99, 21);
            this.lblPreciofinal.TabIndex = 4;
            this.lblPreciofinal.Text = "Precio Final";
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Location = new System.Drawing.Point(537, 9);
            this.lblProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(106, 21);
            this.lblProveedores.TabIndex = 5;
            this.lblProveedores.Text = "Proveedores";
            // 
            // lblCostounitario
            // 
            this.lblCostounitario.AutoSize = true;
            this.lblCostounitario.Location = new System.Drawing.Point(379, 9);
            this.lblCostounitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostounitario.Name = "lblCostounitario";
            this.lblCostounitario.Size = new System.Drawing.Size(117, 21);
            this.lblCostounitario.TabIndex = 6;
            this.lblCostounitario.Text = "Costo Unitario";
            // 
            // lblTotaldeproductos
            // 
            this.lblTotaldeproductos.AutoSize = true;
            this.lblTotaldeproductos.Location = new System.Drawing.Point(139, 132);
            this.lblTotaldeproductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotaldeproductos.Name = "lblTotaldeproductos";
            this.lblTotaldeproductos.Size = new System.Drawing.Size(155, 21);
            this.lblTotaldeproductos.TabIndex = 8;
            this.lblTotaldeproductos.Text = "Total de productos";
            // 
            // txtTotalProductos
            // 
            this.txtTotalProductos.Enabled = false;
            this.txtTotalProductos.Location = new System.Drawing.Point(322, 129);
            this.txtTotalProductos.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalProductos.Name = "txtTotalProductos";
            this.txtTotalProductos.Size = new System.Drawing.Size(102, 27);
            this.txtTotalProductos.TabIndex = 10;
            this.txtTotalProductos.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(106, 51);
            this.cmbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(157, 29);
            this.cmbProductos.TabIndex = 12;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(291, 51);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(48, 27);
            this.nudCantidad.TabIndex = 13;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(322, 195);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(102, 27);
            this.txtIVA.TabIndex = 16;
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Enabled = false;
            this.txtPrecioFinal.Location = new System.Drawing.Point(322, 256);
            this.txtPrecioFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(102, 27);
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
            this.txtProveedor.Size = new System.Drawing.Size(148, 27);
            this.txtProveedor.TabIndex = 20;
            // 
            // nudCostoUnitario
            // 
            this.nudCostoUnitario.Location = new System.Drawing.Point(399, 53);
            this.nudCostoUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.nudCostoUnitario.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudCostoUnitario.Name = "nudCostoUnitario";
            this.nudCostoUnitario.Size = new System.Drawing.Size(80, 27);
            this.nudCostoUnitario.TabIndex = 21;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(273, 9);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(85, 21);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgvSubcuentas
            // 
            this.dgvSubcuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubcuentas.Location = new System.Drawing.Point(65, 308);
            this.dgvSubcuentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSubcuentas.Name = "dgvSubcuentas";
            this.dgvSubcuentas.RowHeadersWidth = 51;
            this.dgvSubcuentas.Size = new System.Drawing.Size(693, 254);
            this.dgvSubcuentas.TabIndex = 24;
            // 
            // Panel_de_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
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
            this.Load += new System.EventHandler(this.Panel_de_compras_Load);
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
    }
}