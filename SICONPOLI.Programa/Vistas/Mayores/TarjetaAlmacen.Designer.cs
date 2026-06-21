namespace PA4IM9_20262_Equipo2.Vistas.Mayores
{
    partial class TarjetaAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarjetaAlmacen));
            this.upBar = new System.Windows.Forms.Panel();
            this.btnRegreso = new System.Windows.Forms.PictureBox();
            this.txtProducto = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblNoTarjeta = new System.Windows.Forms.Label();
            this.lblPunto = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.TablaProducto = new System.Windows.Forms.DataGridView();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegreso)).BeginInit();
            this.Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // upBar
            // 
            this.upBar.Controls.Add(this.btnRegreso);
            this.upBar.Controls.Add(this.txtProducto);
            this.upBar.Controls.Add(this.lblEmpresa);
            this.upBar.Controls.Add(this.lblNoTarjeta);
            this.upBar.Controls.Add(this.lblPunto);
            this.upBar.Controls.Add(this.lblNo);
            this.upBar.Controls.Add(this.lblTitulo);
            this.upBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.upBar.Location = new System.Drawing.Point(0, 0);
            this.upBar.Name = "upBar";
            this.upBar.Size = new System.Drawing.Size(967, 100);
            this.upBar.TabIndex = 0;
            // 
            // btnRegreso
            // 
            this.btnRegreso.Image = ((System.Drawing.Image)(resources.GetObject("btnRegreso.Image")));
            this.btnRegreso.Location = new System.Drawing.Point(885, 29);
            this.btnRegreso.Name = "btnRegreso";
            this.btnRegreso.Size = new System.Drawing.Size(50, 50);
            this.btnRegreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegreso.TabIndex = 16;
            this.btnRegreso.TabStop = false;
            this.btnRegreso.Click += new System.EventHandler(this.btnRegreso_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.AutoSize = true;
            this.txtProducto.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(105, 60);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(0, 18);
            this.txtProducto.TabIndex = 15;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(27, 61);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(77, 18);
            this.lblEmpresa.TabIndex = 14;
            this.lblEmpresa.Text = "Articulo :";
            // 
            // lblNoTarjeta
            // 
            this.lblNoTarjeta.AutoSize = true;
            this.lblNoTarjeta.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblNoTarjeta.Location = new System.Drawing.Point(814, 26);
            this.lblNoTarjeta.Name = "lblNoTarjeta";
            this.lblNoTarjeta.Size = new System.Drawing.Size(46, 24);
            this.lblNoTarjeta.TabIndex = 13;
            this.lblNoTarjeta.Text = "9999";
            // 
            // lblPunto
            // 
            this.lblPunto.AutoSize = true;
            this.lblPunto.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunto.Location = new System.Drawing.Point(792, 24);
            this.lblPunto.Name = "lblPunto";
            this.lblPunto.Size = new System.Drawing.Size(16, 22);
            this.lblPunto.TabIndex = 12;
            this.lblPunto.Text = ":";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Led Italic Font", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNo.Location = new System.Drawing.Point(755, 24);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(42, 26);
            this.lblNo.TabIndex = 11;
            this.lblNo.Text = "NO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Led Italic Font", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitulo.Location = new System.Drawing.Point(21, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 26);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "TARJETA DE ALMACEN";
            // 
            // Contenedor
            // 
            this.Contenedor.Controls.Add(this.TablaProducto);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 100);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(967, 472);
            this.Contenedor.TabIndex = 1;
            // 
            // TablaProducto
            // 
            this.TablaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folio,
            this.fecha,
            this.referencia,
            this.entradas,
            this.salidas,
            this.existencia,
            this.cUnitario,
            this.cMedio,
            this.cargos,
            this.abonos,
            this.saldo});
            this.TablaProducto.Location = new System.Drawing.Point(30, 20);
            this.TablaProducto.Name = "TablaProducto";
            this.TablaProducto.ReadOnly = true;
            this.TablaProducto.Size = new System.Drawing.Size(927, 432);
            this.TablaProducto.TabIndex = 0;
            // 
            // folio
            // 
            this.folio.HeaderText = "Folio";
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // referencia
            // 
            this.referencia.HeaderText = "Referencia";
            this.referencia.Name = "referencia";
            this.referencia.ReadOnly = true;
            // 
            // entradas
            // 
            this.entradas.HeaderText = "Entradas";
            this.entradas.Name = "entradas";
            this.entradas.ReadOnly = true;
            // 
            // salidas
            // 
            this.salidas.HeaderText = "Salidas";
            this.salidas.Name = "salidas";
            this.salidas.ReadOnly = true;
            // 
            // existencia
            // 
            this.existencia.HeaderText = "Existencia";
            this.existencia.Name = "existencia";
            this.existencia.ReadOnly = true;
            // 
            // cUnitario
            // 
            this.cUnitario.HeaderText = "C. Unitario";
            this.cUnitario.Name = "cUnitario";
            this.cUnitario.ReadOnly = true;
            // 
            // cMedio
            // 
            this.cMedio.HeaderText = "C. Medio";
            this.cMedio.Name = "cMedio";
            this.cMedio.ReadOnly = true;
            // 
            // cargos
            // 
            this.cargos.HeaderText = "Cargos";
            this.cargos.Name = "cargos";
            this.cargos.ReadOnly = true;
            // 
            // abonos
            // 
            this.abonos.HeaderText = "Abonos";
            this.abonos.Name = "abonos";
            this.abonos.ReadOnly = true;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // TarjetaAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 572);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.upBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TarjetaAlmacen";
            this.Text = "TarjetaAlmacen";
            this.upBar.ResumeLayout(false);
            this.upBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegreso)).EndInit();
            this.Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upBar;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label txtProducto;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblNoTarjeta;
        private System.Windows.Forms.Label lblPunto;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnRegreso;
        private System.Windows.Forms.DataGridView TablaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargos;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
    }
}