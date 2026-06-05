namespace PA4IM9_20262_Equipo2.Vistas.PanelVentas
{
    partial class Panel_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSubcuentas = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCostoUnitario = new System.Windows.Forms.NumericUpDown();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lblCostounitario = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblPreciofinal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSubcuentas
            // 
            this.dgvSubcuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubcuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.productos,
            this.totalProductos,
            this.iva,
            this.total,
            this.usuario,
            this.folio});
            this.dgvSubcuentas.Location = new System.Drawing.Point(25, 317);
            this.dgvSubcuentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSubcuentas.Name = "dgvSubcuentas";
            this.dgvSubcuentas.RowHeadersWidth = 51;
            this.dgvSubcuentas.Size = new System.Drawing.Size(958, 206);
            this.dgvSubcuentas.TabIndex = 40;
            // 
            // fecha
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.fecha.HeaderText = "Fecha y Hora";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 210;
            // 
            // productos
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.productos.DefaultCellStyle = dataGridViewCellStyle2;
            this.productos.HeaderText = "Productos";
            this.productos.MinimumWidth = 6;
            this.productos.Name = "productos";
            this.productos.Width = 128;
            // 
            // totalProductos
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.totalProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalProductos.HeaderText = "Subtotal";
            this.totalProductos.MinimumWidth = 6;
            this.totalProductos.Name = "totalProductos";
            this.totalProductos.Width = 128;
            // 
            // iva
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.iva.DefaultCellStyle = dataGridViewCellStyle4;
            this.iva.HeaderText = "IVA";
            this.iva.MinimumWidth = 6;
            this.iva.Name = "iva";
            this.iva.Width = 80;
            // 
            // total
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.total.DefaultCellStyle = dataGridViewCellStyle5;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 128;
            // 
            // usuario
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.usuario.DefaultCellStyle = dataGridViewCellStyle6;
            this.usuario.HeaderText = "Usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.Width = 118;
            // 
            // folio
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.folio.DefaultCellStyle = dataGridViewCellStyle7;
            this.folio.HeaderText = "Folio";
            this.folio.MinimumWidth = 6;
            this.folio.Name = "folio";
            this.folio.Width = 115;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCantidad.Location = new System.Drawing.Point(287, 16);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(85, 21);
            this.lblCantidad.TabIndex = 39;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCostoUnitario
            // 
            this.nudCostoUnitario.DecimalPlaces = 2;
            this.nudCostoUnitario.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nudCostoUnitario.Location = new System.Drawing.Point(406, 56);
            this.nudCostoUnitario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nudCostoUnitario.Size = new System.Drawing.Size(80, 27);
            this.nudCostoUnitario.TabIndex = 38;
            this.nudCostoUnitario.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtCliente.Location = new System.Drawing.Point(10, 54);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(144, 27);
            this.txtCliente.TabIndex = 37;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRegistrar.Location = new System.Drawing.Point(396, 241);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 43);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Enabled = false;
            this.txtPrecioFinal.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPrecioFinal.Location = new System.Drawing.Point(649, 55);
            this.txtPrecioFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(102, 27);
            this.txtPrecioFinal.TabIndex = 35;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtIVA.Location = new System.Drawing.Point(520, 57);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(102, 27);
            this.txtIVA.TabIndex = 34;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nudCantidad.Location = new System.Drawing.Point(308, 56);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nudCantidad.Size = new System.Drawing.Size(48, 27);
            this.nudCantidad.TabIndex = 33;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbProductos
            // 
            this.cmbProductos.BackColor = System.Drawing.Color.Snow;
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Items.AddRange(new object[] {
            "Laptops",
            "Monitor",
            "PCs",
            "Dispositivos portatiles"});
            this.cmbProductos.Location = new System.Drawing.Point(15, 56);
            this.cmbProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(259, 29);
            this.cmbProductos.TabIndex = 32;
            // 
            // lblCostounitario
            // 
            this.lblCostounitario.AutoSize = true;
            this.lblCostounitario.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCostounitario.Location = new System.Drawing.Point(393, 16);
            this.lblCostounitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostounitario.Name = "lblCostounitario";
            this.lblCostounitario.Size = new System.Drawing.Size(121, 21);
            this.lblCostounitario.TabIndex = 29;
            this.lblCostounitario.Text = "Precio Unitario";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblClientes.Location = new System.Drawing.Point(48, 19);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(65, 21);
            this.lblClientes.TabIndex = 28;
            this.lblClientes.Text = "Cliente";
            // 
            // lblPreciofinal
            // 
            this.lblPreciofinal.AutoSize = true;
            this.lblPreciofinal.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPreciofinal.Location = new System.Drawing.Point(652, 19);
            this.lblPreciofinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreciofinal.Name = "lblPreciofinal";
            this.lblPreciofinal.Size = new System.Drawing.Size(99, 21);
            this.lblPreciofinal.TabIndex = 27;
            this.lblPreciofinal.Text = "Precio Final";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblIVA.Location = new System.Drawing.Point(555, 19);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(37, 21);
            this.lblIVA.TabIndex = 26;
            this.lblIVA.Text = "IVA";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblProductos.Location = new System.Drawing.Point(111, 16);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(87, 21);
            this.lblProductos.TabIndex = 25;
            this.lblProductos.Text = "Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Controls.Add(this.lblProductos);
            this.groupBox1.Controls.Add(this.cmbProductos);
            this.groupBox1.Controls.Add(this.nudCostoUnitario);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(this.lblCostounitario);
            this.groupBox1.Controls.Add(this.txtPrecioFinal);
            this.groupBox1.Controls.Add(this.lblIVA);
            this.groupBox1.Controls.Add(this.txtIVA);
            this.groupBox1.Controls.Add(this.lblPreciofinal);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(22, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 188);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(11, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Concepto:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.SystemColors.Window;
            this.txtConcepto.Enabled = false;
            this.txtConcepto.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtConcepto.Location = new System.Drawing.Point(109, 127);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.Size = new System.Drawing.Size(529, 27);
            this.txtConcepto.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFolio);
            this.groupBox2.Controls.Add(this.lblClientes);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(823, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 188);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(60, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Folio";
            // 
            // txtFolio
            // 
            this.txtFolio.Enabled = false;
            this.txtFolio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtFolio.Location = new System.Drawing.Point(31, 142);
            this.txtFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(102, 27);
            this.txtFolio.TabIndex = 43;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnConfirmar.Location = new System.Drawing.Point(540, 241);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 43);
            this.btnConfirmar.TabIndex = 43;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Panel_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1020, 536);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSubcuentas);
            this.Controls.Add(this.btnRegistrar);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel_Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubcuentas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCostoUnitario;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblCostounitario;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblPreciofinal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
    }
}