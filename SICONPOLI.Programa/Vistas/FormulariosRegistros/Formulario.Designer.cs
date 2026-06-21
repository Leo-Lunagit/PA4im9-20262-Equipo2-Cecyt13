namespace PA4IM9_20262_Equipo2.Vistas.FormulariosRegistros
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.grpTitulares = new System.Windows.Forms.GroupBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblTitulares = new System.Windows.Forms.Label();
            this.grpRecursos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.ContenedorRecursos = new System.Windows.Forms.Panel();
            this.lblNoRecursos = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblIDMovimiento = new System.Windows.Forms.Label();
            this.lblRecursos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.grpTitulares.SuspendLayout();
            this.grpRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTitulares
            // 
            this.grpTitulares.Controls.Add(this.txtFactura);
            this.grpTitulares.Controls.Add(this.txtTitular);
            this.grpTitulares.Controls.Add(this.txtMontoTotal);
            this.grpTitulares.Controls.Add(this.lblMontoTotal);
            this.grpTitulares.Controls.Add(this.lblFactura);
            this.grpTitulares.Controls.Add(this.lblTitulares);
            this.grpTitulares.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Bold);
            this.grpTitulares.Location = new System.Drawing.Point(563, 68);
            this.grpTitulares.Name = "grpTitulares";
            this.grpTitulares.Size = new System.Drawing.Size(318, 126);
            this.grpTitulares.TabIndex = 48;
            this.grpTitulares.TabStop = false;
            this.grpTitulares.Text = "Titulares";
            // 
            // txtFactura
            // 
            this.txtFactura.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtFactura.Location = new System.Drawing.Point(201, 56);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(102, 25);
            this.txtFactura.TabIndex = 52;
            // 
            // txtTitular
            // 
            this.txtTitular.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtTitular.Location = new System.Drawing.Point(15, 56);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(176, 25);
            this.txtTitular.TabIndex = 51;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtMontoTotal.Location = new System.Drawing.Point(163, 91);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(102, 25);
            this.txtMontoTotal.TabIndex = 50;
            this.txtMontoTotal.Text = "$0.00";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(64, 91);
            this.lblMontoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(98, 25);
            this.lblMontoTotal.TabIndex = 49;
            this.lblMontoTotal.Text = "Monto Total :";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(221, 28);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(61, 25);
            this.lblFactura.TabIndex = 46;
            this.lblFactura.Text = "Factura";
            // 
            // lblTitulares
            // 
            this.lblTitulares.AutoSize = true;
            this.lblTitulares.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulares.Location = new System.Drawing.Point(62, 28);
            this.lblTitulares.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulares.Name = "lblTitulares";
            this.lblTitulares.Size = new System.Drawing.Size(70, 25);
            this.lblTitulares.TabIndex = 28;
            this.lblTitulares.Text = "Titulares";
            // 
            // grpRecursos
            // 
            this.grpRecursos.Controls.Add(this.btnAgregar);
            this.grpRecursos.Controls.Add(this.txtSubTotal);
            this.grpRecursos.Controls.Add(this.lblIVA);
            this.grpRecursos.Controls.Add(this.txtIVA);
            this.grpRecursos.Controls.Add(this.lblSubTotal);
            this.grpRecursos.Controls.Add(this.ContenedorRecursos);
            this.grpRecursos.Controls.Add(this.lblNoRecursos);
            this.grpRecursos.Controls.Add(this.lblSuma);
            this.grpRecursos.Controls.Add(this.lblIDMovimiento);
            this.grpRecursos.Controls.Add(this.lblRecursos);
            this.grpRecursos.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Bold);
            this.grpRecursos.Location = new System.Drawing.Point(86, 18);
            this.grpRecursos.Name = "grpRecursos";
            this.grpRecursos.Size = new System.Drawing.Size(427, 230);
            this.grpRecursos.TabIndex = 81;
            this.grpRecursos.TabStop = false;
            this.grpRecursos.Text = "Recursos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(145, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(25, 25);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 85;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtSubTotal.Location = new System.Drawing.Point(257, 195);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(122, 25);
            this.txtSubTotal.TabIndex = 84;
            this.txtSubTotal.Text = "$0.00";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(39, 195);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(42, 25);
            this.lblIVA.TabIndex = 81;
            this.lblIVA.Text = "IVA :";
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtIVA.Location = new System.Drawing.Point(79, 195);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(92, 25);
            this.txtIVA.TabIndex = 83;
            this.txtIVA.Text = "$0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(181, 195);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(76, 25);
            this.lblSubTotal.TabIndex = 82;
            this.lblSubTotal.Text = "SubTotal :";
            // 
            // ContenedorRecursos
            // 
            this.ContenedorRecursos.AutoScroll = true;
            this.ContenedorRecursos.Location = new System.Drawing.Point(5, 56);
            this.ContenedorRecursos.Name = "ContenedorRecursos";
            this.ContenedorRecursos.Size = new System.Drawing.Size(417, 129);
            this.ContenedorRecursos.TabIndex = 80;
            // 
            // lblNoRecursos
            // 
            this.lblNoRecursos.AutoSize = true;
            this.lblNoRecursos.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRecursos.Location = new System.Drawing.Point(125, 28);
            this.lblNoRecursos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoRecursos.Name = "lblNoRecursos";
            this.lblNoRecursos.Size = new System.Drawing.Size(20, 25);
            this.lblNoRecursos.TabIndex = 78;
            this.lblNoRecursos.Text = "1";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(306, 28);
            this.lblSuma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(47, 25);
            this.lblSuma.TabIndex = 49;
            this.lblSuma.Text = "Suma";
            // 
            // lblIDMovimiento
            // 
            this.lblIDMovimiento.AutoSize = true;
            this.lblIDMovimiento.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMovimiento.Location = new System.Drawing.Point(199, 28);
            this.lblIDMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDMovimiento.Name = "lblIDMovimiento";
            this.lblIDMovimiento.Size = new System.Drawing.Size(94, 25);
            this.lblIDMovimiento.TabIndex = 46;
            this.lblIDMovimiento.Text = "Identificador";
            // 
            // lblRecursos
            // 
            this.lblRecursos.AutoSize = true;
            this.lblRecursos.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecursos.Location = new System.Drawing.Point(62, 28);
            this.lblRecursos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecursos.Name = "lblRecursos";
            this.lblRecursos.Size = new System.Drawing.Size(71, 25);
            this.lblRecursos.TabIndex = 28;
            this.lblRecursos.Text = "Recursos";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(899, 18);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 82;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpRecursos);
            this.Controls.Add(this.grpTitulares);
            this.Name = "Formulario";
            this.Size = new System.Drawing.Size(967, 262);
            this.grpTitulares.ResumeLayout(false);
            this.grpTitulares.PerformLayout();
            this.grpRecursos.ResumeLayout(false);
            this.grpRecursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label lblMontoTotal;
        protected System.Windows.Forms.GroupBox grpTitulares;
        protected System.Windows.Forms.Label lblFactura;
        protected System.Windows.Forms.GroupBox grpRecursos;
        protected System.Windows.Forms.Label lblNoRecursos;
        protected System.Windows.Forms.Label lblSuma;
        protected System.Windows.Forms.Label lblIDMovimiento;
        protected System.Windows.Forms.Label lblRecursos;
        protected System.Windows.Forms.Label lblIVA;
        protected System.Windows.Forms.Label lblSubTotal;
        public System.Windows.Forms.TextBox txtSubTotal;
        public System.Windows.Forms.TextBox txtIVA;
        public System.Windows.Forms.Panel ContenedorRecursos;
        public System.Windows.Forms.Label lblTitulares;
        public System.Windows.Forms.TextBox txtFactura;
        public System.Windows.Forms.TextBox txtTitular;
        protected System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}
