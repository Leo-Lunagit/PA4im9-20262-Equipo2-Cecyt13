namespace PA4IM9_20262_Equipo2.Vistas.FormulariosRegistros
{
    partial class FormularioFacturaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioFacturaciones));
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpTitulares.SuspendLayout();
            this.grpRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRecursos
            // 
            this.grpRecursos.Controls.Add(this.pictureBox1);
            this.grpRecursos.Controls.Add(this.lblCantidad);
            this.grpRecursos.Location = new System.Drawing.Point(50, 18);
            this.grpRecursos.Size = new System.Drawing.Size(500, 230);
            this.grpRecursos.Text = "Productos";
            this.grpRecursos.Controls.SetChildIndex(this.lblCantidad, 0);
            this.grpRecursos.Controls.SetChildIndex(this.pictureBox1, 0);
            this.grpRecursos.Controls.SetChildIndex(this.btnAgregar, 0);
            this.grpRecursos.Controls.SetChildIndex(this.lblRecursos, 0);
            this.grpRecursos.Controls.SetChildIndex(this.lblIDMovimiento, 0);
            this.grpRecursos.Controls.SetChildIndex(this.lblSuma, 0);
            this.grpRecursos.Controls.SetChildIndex(this.lblNoRecursos, 0);
            this.grpRecursos.Controls.SetChildIndex(this.ContenedorRecursos, 0);
            this.grpRecursos.Controls.SetChildIndex(this.lblSubTotal, 0);
            this.grpRecursos.Controls.SetChildIndex(this.txtIVA, 0);
            this.grpRecursos.Controls.SetChildIndex(this.lblIVA, 0);
            this.grpRecursos.Controls.SetChildIndex(this.txtSubTotal, 0);
            // 
            // lblNoRecursos
            // 
            this.lblNoRecursos.Location = new System.Drawing.Point(192, 28);
            // 
            // lblSuma
            // 
            this.lblSuma.Location = new System.Drawing.Point(384, 28);
            this.lblSuma.Size = new System.Drawing.Size(50, 25);
            this.lblSuma.Text = "Costo";
            // 
            // lblIDMovimiento
            // 
            this.lblIDMovimiento.Location = new System.Drawing.Point(261, 28);
            this.lblIDMovimiento.Size = new System.Drawing.Size(104, 25);
            this.lblIDMovimiento.Text = "Costo por Kilo";
            // 
            // lblRecursos
            // 
            this.lblRecursos.Location = new System.Drawing.Point(112, 28);
            this.lblRecursos.Size = new System.Drawing.Size(79, 25);
            this.lblRecursos.Text = "Productos";
            // 
            // lblIVA
            // 
            this.lblIVA.Location = new System.Drawing.Point(70, 195);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Location = new System.Drawing.Point(212, 195);
            this.lblSubTotal.Size = new System.Drawing.Size(96, 25);
            this.lblSubTotal.Text = "Costo Total : ";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(308, 195);
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(110, 195);
            // 
            // ContenedorRecursos
            // 
            this.ContenedorRecursos.Size = new System.Drawing.Size(492, 129);
            // 
            // cmbFacturas
            // 
            this.cmbFacturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacturas.Items.AddRange(new object[] {
            "Automatica",
            "Manual"});
            this.cmbFacturas.SelectedIndexChanged += new System.EventHandler(this.cmbFacturas_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(34, 28);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 25);
            this.lblCantidad.TabIndex = 85;
            this.lblCantidad.Text = "Peso Kg";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormularioFacturaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FormularioFacturaciones";
            this.grpTitulares.ResumeLayout(false);
            this.grpTitulares.PerformLayout();
            this.grpRecursos.ResumeLayout(false);
            this.grpRecursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        protected System.Windows.Forms.PictureBox pictureBox1;
    }
}
