namespace PA4IM9_20262_Equipo2.Vistas.CamposSubCuentas
{
    partial class CamposProducto
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
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtCostoUni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoItem
            // 
            this.lblNoItem.Text = "1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(451, 9);
            // 
            // cmbNombreItem
            // 
            this.cmbNombreItem.Location = new System.Drawing.Point(82, 9);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(357, 9);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.nudCantidad.Location = new System.Drawing.Point(25, 9);
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
            this.nudCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudCantidad.Size = new System.Drawing.Size(48, 25);
            this.nudCantidad.TabIndex = 2;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // txtCostoUni
            // 
            this.txtCostoUni.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtCostoUni.Location = new System.Drawing.Point(270, 9);
            this.txtCostoUni.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostoUni.Name = "txtCostoUni";
            this.txtCostoUni.Size = new System.Drawing.Size(75, 25);
            this.txtCostoUni.TabIndex = 3;
            this.txtCostoUni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostoUni.TextChanged += new System.EventHandler(this.txtCostoUni_TextChanged);
            this.txtCostoUni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUni_KeyPress);
            // 
            // CamposProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.txtCostoUni);
            this.Controls.Add(this.nudCantidad);
            this.MaximumSize = new System.Drawing.Size(476, 43);
            this.Name = "CamposProducto";
            this.Size = new System.Drawing.Size(476, 43);
            this.Controls.SetChildIndex(this.cmbNombreItem, 0);
            this.Controls.SetChildIndex(this.txtMonto, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.lblNoItem, 0);
            this.Controls.SetChildIndex(this.nudCantidad, 0);
            this.Controls.SetChildIndex(this.txtCostoUni, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown nudCantidad;
        public System.Windows.Forms.TextBox txtCostoUni;
    }
}
