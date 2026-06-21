namespace PA4IM9_20262_Equipo2.Vistas.Catalogos
{
    partial class TarjetaTitular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarjetaTitular));
            this.txtNoTarjeta = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.ptrImagen = new System.Windows.Forms.PictureBox();
            this.txtLimite = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblAdeudo = new System.Windows.Forms.Label();
            this.txtAdeudo = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoTarjeta
            // 
            this.txtNoTarjeta.AutoSize = true;
            this.txtNoTarjeta.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTarjeta.Location = new System.Drawing.Point(18, 5);
            this.txtNoTarjeta.Name = "txtNoTarjeta";
            this.txtNoTarjeta.Size = new System.Drawing.Size(14, 15);
            this.txtNoTarjeta.TabIndex = 11;
            this.txtNoTarjeta.Text = "9";
            this.txtNoTarjeta.Click += new System.EventHandler(this.TarjetaTitular_Click);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(8, 5);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(14, 15);
            this.lblNo.TabIndex = 12;
            this.lblNo.Text = "#";
            // 
            // ptrImagen
            // 
            this.ptrImagen.Image = ((System.Drawing.Image)(resources.GetObject("ptrImagen.Image")));
            this.ptrImagen.Location = new System.Drawing.Point(10, 20);
            this.ptrImagen.Name = "ptrImagen";
            this.ptrImagen.Size = new System.Drawing.Size(220, 127);
            this.ptrImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrImagen.TabIndex = 10;
            this.ptrImagen.TabStop = false;
            this.ptrImagen.Click += new System.EventHandler(this.TarjetaTitular_Click);
            // 
            // txtLimite
            // 
            this.txtLimite.AutoSize = true;
            this.txtLimite.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimite.Location = new System.Drawing.Point(330, 75);
            this.txtLimite.Margin = new System.Windows.Forms.Padding(0);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(87, 15);
            this.txtLimite.TabIndex = 15;
            this.txtLimite.Text = "$999,999.99";
            this.txtLimite.Click += new System.EventHandler(this.TarjetaTitular_Click);
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(241, 75);
            this.lblLimite.Margin = new System.Windows.Forms.Padding(0);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(55, 15);
            this.lblLimite.TabIndex = 17;
            this.lblLimite.Text = "Limite :";
            this.lblLimite.Click += new System.EventHandler(this.TarjetaTitular_Click);
            // 
            // lblAdeudo
            // 
            this.lblAdeudo.AutoSize = true;
            this.lblAdeudo.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdeudo.Location = new System.Drawing.Point(241, 55);
            this.lblAdeudo.Margin = new System.Windows.Forms.Padding(0);
            this.lblAdeudo.Name = "lblAdeudo";
            this.lblAdeudo.Size = new System.Drawing.Size(65, 15);
            this.lblAdeudo.TabIndex = 16;
            this.lblAdeudo.Text = "Adeudo :";
            this.lblAdeudo.Click += new System.EventHandler(this.TarjetaTitular_Click);
            // 
            // txtAdeudo
            // 
            this.txtAdeudo.AutoSize = true;
            this.txtAdeudo.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdeudo.Location = new System.Drawing.Point(330, 55);
            this.txtAdeudo.Margin = new System.Windows.Forms.Padding(0);
            this.txtAdeudo.Name = "txtAdeudo";
            this.txtAdeudo.Size = new System.Drawing.Size(87, 15);
            this.txtAdeudo.TabIndex = 14;
            this.txtAdeudo.Text = "$999,999.99";
            this.txtAdeudo.Click += new System.EventHandler(this.TarjetaTitular_Click);
            // 
            // txtTitular
            // 
            this.txtTitular.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitular.Location = new System.Drawing.Point(236, 15);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(174, 50);
            this.txtTitular.TabIndex = 13;
            this.txtTitular.Text = "Titular";
            this.txtTitular.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtTitular.Click += new System.EventHandler(this.TarjetaTitular_Click);
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(293, 95);
            this.lblContacto.Margin = new System.Windows.Forms.Padding(0);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(63, 15);
            this.lblContacto.TabIndex = 18;
            this.lblContacto.Text = "Contacto";
            this.lblContacto.Click += new System.EventHandler(this.TarjetaTitular_Click);
            // 
            // txtContacto
            // 
            this.txtContacto.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.Location = new System.Drawing.Point(241, 115);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(0);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(167, 32);
            this.txtContacto.TabIndex = 19;
            this.txtContacto.Text = "empresa@mail.www";
            this.txtContacto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtContacto.Click += new System.EventHandler(this.TarjetaTitular_Click);
            // 
            // TarjetaTitular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.lblAdeudo);
            this.Controls.Add(this.txtAdeudo);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtNoTarjeta);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.ptrImagen);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.Name = "TarjetaTitular";
            this.Size = new System.Drawing.Size(428, 152);
            this.Click += new System.EventHandler(this.TarjetaTitular_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptrImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNoTarjeta;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.PictureBox ptrImagen;
        private System.Windows.Forms.Label txtLimite;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblAdeudo;
        private System.Windows.Forms.Label txtAdeudo;
        private System.Windows.Forms.Label txtTitular;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label txtContacto;
    }
}
