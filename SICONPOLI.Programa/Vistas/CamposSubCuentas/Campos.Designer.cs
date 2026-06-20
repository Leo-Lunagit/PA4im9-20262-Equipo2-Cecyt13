namespace PA4IM9_20262_Equipo2.Vistas.CamposSubCuentas
{
    partial class Campos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Campos));
            this.lblNoItem = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbNombreItem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoItem
            // 
            this.lblNoItem.AutoSize = true;
            this.lblNoItem.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoItem.Location = new System.Drawing.Point(0, 9);
            this.lblNoItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoItem.Name = "lblNoItem";
            this.lblNoItem.Size = new System.Drawing.Size(20, 25);
            this.lblNoItem.TabIndex = 6;
            this.lblNoItem.Text = "0";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(306, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(25, 25);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtMonto.Location = new System.Drawing.Point(212, 9);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(89, 25);
            this.txtMonto.TabIndex = 4;
            this.txtMonto.TabStop = false;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
            // 
            // cmbNombreItem
            // 
            this.cmbNombreItem.BackColor = System.Drawing.Color.Snow;
            this.cmbNombreItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreItem.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.cmbNombreItem.FormattingEnabled = true;
            this.cmbNombreItem.Items.AddRange(new object[] {
            "Laptops",
            "Monitor",
            "PCs",
            "Dispositivos portatiles"});
            this.cmbNombreItem.Location = new System.Drawing.Point(25, 9);
            this.cmbNombreItem.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNombreItem.Name = "cmbNombreItem";
            this.cmbNombreItem.Size = new System.Drawing.Size(176, 26);
            this.cmbNombreItem.TabIndex = 1;
            // 
            // Campos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblNoItem);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cmbNombreItem);
            this.Name = "Campos";
            this.Size = new System.Drawing.Size(331, 43);
            this.ParentChanged += new System.EventHandler(this.Campos_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNoItem;
        protected System.Windows.Forms.PictureBox btnEliminar;
        public System.Windows.Forms.TextBox txtMonto;
        public System.Windows.Forms.ComboBox cmbNombreItem;
    }
}
