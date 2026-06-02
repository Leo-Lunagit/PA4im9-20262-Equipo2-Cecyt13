namespace PA4IM9_20262_Equipo2.Vistas.PanelVentas
{
    partial class PanelVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelVentas));
            this.dgvSubcuentas = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCostoUnitario = new System.Windows.Forms.NumericUpDown();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.txtTotalProductos = new System.Windows.Forms.TextBox();
            this.lblTotaldeproductos = new System.Windows.Forms.Label();
            this.lblCostounitario = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblPreciofinal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubcuentas
            // 
            resources.ApplyResources(this.dgvSubcuentas, "dgvSubcuentas");
            this.dgvSubcuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubcuentas.Name = "dgvSubcuentas";
            // 
            // lblCantidad
            // 
            resources.ApplyResources(this.lblCantidad, "lblCantidad");
            this.lblCantidad.Name = "lblCantidad";
            // 
            // nudCostoUnitario
            // 
            resources.ApplyResources(this.nudCostoUnitario, "nudCostoUnitario");
            this.nudCostoUnitario.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudCostoUnitario.Name = "nudCostoUnitario";
            // 
            // txtProveedor
            // 
            resources.ApplyResources(this.txtProveedor, "txtProveedor");
            this.txtProveedor.Name = "txtProveedor";
            // 
            // btnRegistrar
            // 
            resources.ApplyResources(this.btnRegistrar, "btnRegistrar");
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtPrecioFinal
            // 
            resources.ApplyResources(this.txtPrecioFinal, "txtPrecioFinal");
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            // 
            // txtIVA
            // 
            resources.ApplyResources(this.txtIVA, "txtIVA");
            this.txtIVA.Name = "txtIVA";
            // 
            // nudCantidad
            // 
            resources.ApplyResources(this.nudCantidad, "nudCantidad");
            this.nudCantidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            // 
            // cmbProductos
            // 
            resources.ApplyResources(this.cmbProductos, "cmbProductos");
            this.cmbProductos.BackColor = System.Drawing.Color.Snow;
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Name = "cmbProductos";
            // 
            // txtTotalProductos
            // 
            resources.ApplyResources(this.txtTotalProductos, "txtTotalProductos");
            this.txtTotalProductos.Name = "txtTotalProductos";
            // 
            // lblTotaldeproductos
            // 
            resources.ApplyResources(this.lblTotaldeproductos, "lblTotaldeproductos");
            this.lblTotaldeproductos.Name = "lblTotaldeproductos";
            // 
            // lblCostounitario
            // 
            resources.ApplyResources(this.lblCostounitario, "lblCostounitario");
            this.lblCostounitario.Name = "lblCostounitario";
            // 
            // lblClientes
            // 
            resources.ApplyResources(this.lblClientes, "lblClientes");
            this.lblClientes.Name = "lblClientes";
            // 
            // lblPreciofinal
            // 
            resources.ApplyResources(this.lblPreciofinal, "lblPreciofinal");
            this.lblPreciofinal.Name = "lblPreciofinal";
            // 
            // lblIVA
            // 
            resources.ApplyResources(this.lblIVA, "lblIVA");
            this.lblIVA.Name = "lblIVA";
            // 
            // lblProductos
            // 
            resources.ApplyResources(this.lblProductos, "lblProductos");
            this.lblProductos.Name = "lblProductos";
            // 
            // PanelVentas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblPreciofinal);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblProductos);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelVentas";
            this.Load += new System.EventHandler(this.PanelVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubcuentas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCostoUnitario;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.TextBox txtTotalProductos;
        private System.Windows.Forms.Label lblTotaldeproductos;
        private System.Windows.Forms.Label lblCostounitario;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblPreciofinal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblProductos;
    }
}