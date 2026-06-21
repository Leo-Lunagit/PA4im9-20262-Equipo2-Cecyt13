namespace PA4IM9_20262_Equipo2.Vistas.PanelVentas
{
    partial class PanelRegistros
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
            this.TablaMovimientos = new System.Windows.Forms.DataGridView();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.btnIntercalar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panFormularios = new System.Windows.Forms.Panel();
            this.panMovimientos = new System.Windows.Forms.Panel();
            this.cmbOpcionesConcepto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMovimientos)).BeginInit();
            this.panMovimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaMovimientos
            // 
            this.TablaMovimientos.AllowUserToAddRows = false;
            this.TablaMovimientos.AllowUserToDeleteRows = false;
            this.TablaMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folio,
            this.fecha,
            this.accion,
            this.titular,
            this.factura,
            this.total,
            this.usuario});
            this.TablaMovimientos.Location = new System.Drawing.Point(20, 100);
            this.TablaMovimientos.Margin = new System.Windows.Forms.Padding(4);
            this.TablaMovimientos.Name = "TablaMovimientos";
            this.TablaMovimientos.ReadOnly = true;
            this.TablaMovimientos.RowHeadersWidth = 51;
            this.TablaMovimientos.Size = new System.Drawing.Size(920, 200);
            this.TablaMovimientos.TabIndex = 40;
            // 
            // folio
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.folio.DefaultCellStyle = dataGridViewCellStyle1;
            this.folio.HeaderText = "Folio";
            this.folio.MinimumWidth = 6;
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            // 
            // fecha
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecha.HeaderText = "Fecha y Hora";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // accion
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.accion.DefaultCellStyle = dataGridViewCellStyle3;
            this.accion.HeaderText = "Acción";
            this.accion.MinimumWidth = 6;
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
            // 
            // titular
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.titular.DefaultCellStyle = dataGridViewCellStyle4;
            this.titular.HeaderText = "Titular";
            this.titular.MinimumWidth = 6;
            this.titular.Name = "titular";
            this.titular.ReadOnly = true;
            // 
            // factura
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.factura.DefaultCellStyle = dataGridViewCellStyle5;
            this.factura.HeaderText = "Factura";
            this.factura.MinimumWidth = 6;
            this.factura.Name = "factura";
            this.factura.ReadOnly = true;
            // 
            // total
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.total.DefaultCellStyle = dataGridViewCellStyle6;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // usuario
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.usuario.DefaultCellStyle = dataGridViewCellStyle7;
            this.usuario.HeaderText = "Registrado por:";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRegistrar.Location = new System.Drawing.Point(815, 55);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 35);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtFolio
            // 
            this.txtFolio.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtFolio.Location = new System.Drawing.Point(140, 14);
            this.txtFolio.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.ReadOnly = true;
            this.txtFolio.Size = new System.Drawing.Size(102, 25);
            this.txtFolio.TabIndex = 43;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(91, 14);
            this.lblFolio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(53, 25);
            this.lblFolio.TabIndex = 44;
            this.lblFolio.Text = "Folio : ";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(389, 14);
            this.lblConcepto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(94, 25);
            this.lblConcepto.TabIndex = 45;
            this.lblConcepto.Text = "Descripción :";
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.SystemColors.Window;
            this.txtConcepto.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtConcepto.Location = new System.Drawing.Point(483, 14);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.Size = new System.Drawing.Size(388, 25);
            this.txtConcepto.TabIndex = 45;
            // 
            // btnIntercalar
            // 
            this.btnIntercalar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIntercalar.Location = new System.Drawing.Point(40, 55);
            this.btnIntercalar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIntercalar.Name = "btnIntercalar";
            this.btnIntercalar.Size = new System.Drawing.Size(112, 35);
            this.btnIntercalar.TabIndex = 43;
            this.btnIntercalar.Text = "COBRAR";
            this.btnIntercalar.UseVisualStyleBackColor = true;
            this.btnIntercalar.Click += new System.EventHandler(this.btnIntercalar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnModificar.Location = new System.Drawing.Point(688, 55);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 35);
            this.btnModificar.TabIndex = 44;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panFormularios
            // 
            this.panFormularios.BackColor = System.Drawing.Color.Transparent;
            this.panFormularios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panFormularios.Location = new System.Drawing.Point(0, 0);
            this.panFormularios.Margin = new System.Windows.Forms.Padding(2);
            this.panFormularios.Name = "panFormularios";
            this.panFormularios.Size = new System.Drawing.Size(967, 262);
            this.panFormularios.TabIndex = 45;
            // 
            // panMovimientos
            // 
            this.panMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.panMovimientos.Controls.Add(this.btnIntercalar);
            this.panMovimientos.Controls.Add(this.txtFolio);
            this.panMovimientos.Controls.Add(this.TablaMovimientos);
            this.panMovimientos.Controls.Add(this.btnRegistrar);
            this.panMovimientos.Controls.Add(this.lblFolio);
            this.panMovimientos.Controls.Add(this.btnModificar);
            this.panMovimientos.Controls.Add(this.txtConcepto);
            this.panMovimientos.Controls.Add(this.lblConcepto);
            this.panMovimientos.Controls.Add(this.cmbOpcionesConcepto);
            this.panMovimientos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panMovimientos.Location = new System.Drawing.Point(0, 262);
            this.panMovimientos.Margin = new System.Windows.Forms.Padding(2);
            this.panMovimientos.Name = "panMovimientos";
            this.panMovimientos.Size = new System.Drawing.Size(967, 310);
            this.panMovimientos.TabIndex = 46;
            // 
            // cmbOpcionesConcepto
            // 
            this.cmbOpcionesConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesConcepto.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.cmbOpcionesConcepto.FormattingEnabled = true;
            this.cmbOpcionesConcepto.Items.AddRange(new object[] {
            "Por Defecto",
            "Personalizada"});
            this.cmbOpcionesConcepto.Location = new System.Drawing.Point(483, 14);
            this.cmbOpcionesConcepto.Name = "cmbOpcionesConcepto";
            this.cmbOpcionesConcepto.Size = new System.Drawing.Size(405, 26);
            this.cmbOpcionesConcepto.TabIndex = 46;
            this.cmbOpcionesConcepto.SelectedIndexChanged += new System.EventHandler(this.cmbOpcionesConcepto_SelectedIndexChanged);
            // 
            // PanelRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 572);
            this.Controls.Add(this.panFormularios);
            this.Controls.Add(this.panMovimientos);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelRegistros";
            this.Text = "pan";
            ((System.ComponentModel.ISupportInitialize)(this.TablaMovimientos)).EndInit();
            this.panMovimientos.ResumeLayout(false);
            this.panMovimientos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaMovimientos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Button btnIntercalar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panFormularios;
        private System.Windows.Forms.Panel panMovimientos;
        private System.Windows.Forms.ComboBox cmbOpcionesConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    }
}