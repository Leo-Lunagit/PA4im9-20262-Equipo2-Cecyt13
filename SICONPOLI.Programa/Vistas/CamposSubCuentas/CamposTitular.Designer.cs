namespace PA4IM9_20262_Equipo2.Vistas.CamposSubCuentas
{
    partial class CamposTitular
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
            this.txtFactura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoItem
            // 
            this.lblNoItem.Text = "1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(382, 9);
            // 
            // cmbNombreItem
            // 
            this.cmbNombreItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbNombreItem.Size = new System.Drawing.Size(150, 26);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(276, 9);
            this.txtMonto.ReadOnly = false;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtFactura
            // 
            this.txtFactura.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtFactura.Location = new System.Drawing.Point(183, 9);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(84, 25);
            this.txtFactura.TabIndex = 2;
            this.txtFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFactura_KeyPress);
            // 
            // CamposTitular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.txtFactura);
            this.Name = "CamposTitular";
            this.Size = new System.Drawing.Size(407, 43);
            this.Controls.SetChildIndex(this.txtFactura, 0);
            this.Controls.SetChildIndex(this.cmbNombreItem, 0);
            this.Controls.SetChildIndex(this.txtMonto, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.lblNoItem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtFactura;
    }
}
