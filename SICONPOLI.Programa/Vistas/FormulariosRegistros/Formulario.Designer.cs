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
            this.grpTitulares = new System.Windows.Forms.GroupBox();
            this.ContenedorTitulares = new System.Windows.Forms.Panel();
            this.lblNoTitulares = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblTitulares = new System.Windows.Forms.Label();
            this.grpRecursos = new System.Windows.Forms.GroupBox();
            this.txtSumaTotal = new System.Windows.Forms.TextBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.lblSumaTotal = new System.Windows.Forms.Label();
            this.ContenedorRecursos = new System.Windows.Forms.Panel();
            this.lblNoRecursos = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblIDMovimiento = new System.Windows.Forms.Label();
            this.lblRecursos = new System.Windows.Forms.Label();
            this.grpTitulares.SuspendLayout();
            this.grpRecursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTitulares
            // 
            this.grpTitulares.Controls.Add(this.ContenedorTitulares);
            this.grpTitulares.Controls.Add(this.lblNoTitulares);
            this.grpTitulares.Controls.Add(this.txtMontoTotal);
            this.grpTitulares.Controls.Add(this.lblMontoTotal);
            this.grpTitulares.Controls.Add(this.lblMonto);
            this.grpTitulares.Controls.Add(this.lblFactura);
            this.grpTitulares.Controls.Add(this.lblTitulares);
            this.grpTitulares.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Bold);
            this.grpTitulares.Location = new System.Drawing.Point(525, 18);
            this.grpTitulares.Name = "grpTitulares";
            this.grpTitulares.Size = new System.Drawing.Size(427, 230);
            this.grpTitulares.TabIndex = 48;
            this.grpTitulares.TabStop = false;
            this.grpTitulares.Text = "Titulares";
            // 
            // ContenedorTitulares
            // 
            this.ContenedorTitulares.AutoScroll = true;
            this.ContenedorTitulares.Location = new System.Drawing.Point(5, 56);
            this.ContenedorTitulares.Name = "ContenedorTitulares";
            this.ContenedorTitulares.Size = new System.Drawing.Size(417, 129);
            this.ContenedorTitulares.TabIndex = 80;
            // 
            // lblNoTitulares
            // 
            this.lblNoTitulares.AutoSize = true;
            this.lblNoTitulares.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTitulares.Location = new System.Drawing.Point(125, 28);
            this.lblNoTitulares.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoTitulares.Name = "lblNoTitulares";
            this.lblNoTitulares.Size = new System.Drawing.Size(20, 25);
            this.lblNoTitulares.TabIndex = 78;
            this.lblNoTitulares.Text = "1";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtMontoTotal.Location = new System.Drawing.Point(212, 195);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(102, 25);
            this.txtMontoTotal.TabIndex = 50;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(113, 195);
            this.lblMontoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(98, 25);
            this.lblMontoTotal.TabIndex = 49;
            this.lblMontoTotal.Text = "Monto Total :";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(306, 28);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(55, 25);
            this.lblMonto.TabIndex = 49;
            this.lblMonto.Text = "Monto";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(199, 28);
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
            this.grpRecursos.Controls.Add(this.txtSumaTotal);
            this.grpRecursos.Controls.Add(this.lblIVA);
            this.grpRecursos.Controls.Add(this.txtIVA);
            this.grpRecursos.Controls.Add(this.lblSumaTotal);
            this.grpRecursos.Controls.Add(this.ContenedorRecursos);
            this.grpRecursos.Controls.Add(this.lblNoRecursos);
            this.grpRecursos.Controls.Add(this.lblSuma);
            this.grpRecursos.Controls.Add(this.lblIDMovimiento);
            this.grpRecursos.Controls.Add(this.lblRecursos);
            this.grpRecursos.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Bold);
            this.grpRecursos.Location = new System.Drawing.Point(15, 18);
            this.grpRecursos.Name = "grpRecursos";
            this.grpRecursos.Size = new System.Drawing.Size(427, 230);
            this.grpRecursos.TabIndex = 81;
            this.grpRecursos.TabStop = false;
            this.grpRecursos.Text = "Recursos";
            // 
            // txtSumaTotal
            // 
            this.txtSumaTotal.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtSumaTotal.Location = new System.Drawing.Point(271, 195);
            this.txtSumaTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSumaTotal.Name = "txtSumaTotal";
            this.txtSumaTotal.ReadOnly = true;
            this.txtSumaTotal.Size = new System.Drawing.Size(122, 25);
            this.txtSumaTotal.TabIndex = 84;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(33, 195);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(42, 25);
            this.lblIVA.TabIndex = 81;
            this.lblIVA.Text = "IVA :";
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtIVA.Location = new System.Drawing.Point(73, 195);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(92, 25);
            this.txtIVA.TabIndex = 83;
            // 
            // lblSumaTotal
            // 
            this.lblSumaTotal.AutoSize = true;
            this.lblSumaTotal.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaTotal.Location = new System.Drawing.Point(175, 195);
            this.lblSumaTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumaTotal.Name = "lblSumaTotal";
            this.lblSumaTotal.Size = new System.Drawing.Size(93, 25);
            this.lblSumaTotal.TabIndex = 82;
            this.lblSumaTotal.Text = "Suma Total : ";
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
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grpRecursos);
            this.Controls.Add(this.grpTitulares);
            this.Name = "Formulario";
            this.Size = new System.Drawing.Size(967, 262);
            this.grpTitulares.ResumeLayout(false);
            this.grpTitulares.PerformLayout();
            this.grpRecursos.ResumeLayout(false);
            this.grpRecursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label lblMontoTotal;
        protected System.Windows.Forms.GroupBox grpTitulares;
        protected System.Windows.Forms.Label lblMonto;
        protected System.Windows.Forms.Label lblFactura;
        protected System.Windows.Forms.GroupBox grpRecursos;
        protected System.Windows.Forms.Label lblNoRecursos;
        protected System.Windows.Forms.Label lblSuma;
        protected System.Windows.Forms.Label lblIDMovimiento;
        protected System.Windows.Forms.Label lblRecursos;
        protected System.Windows.Forms.Label lblIVA;
        protected System.Windows.Forms.Label lblSumaTotal;
        public System.Windows.Forms.TextBox txtSumaTotal;
        public System.Windows.Forms.TextBox txtIVA;
        public System.Windows.Forms.Panel ContenedorTitulares;
        public System.Windows.Forms.Panel ContenedorRecursos;
        public System.Windows.Forms.Label lblNoTitulares;
        public System.Windows.Forms.Label lblTitulares;
    }
}
