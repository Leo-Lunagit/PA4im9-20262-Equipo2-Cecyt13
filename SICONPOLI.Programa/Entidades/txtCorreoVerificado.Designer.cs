namespace PA4IM9_20262_Equipo2.Vistas.PanelesRegistros
{
    partial class txtCorreoVerificado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtCorreoVerificado));
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(144)))), ((int)(((byte)(86)))));
            this.txtCorreo.Location = new System.Drawing.Point(3, 5);
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(177, 21);
            this.txtCorreo.TabIndex = 0;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtCorreoVerificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCorreo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "txtCorreoVerificado";
            this.Size = new System.Drawing.Size(213, 30);
            this.ParentChanged += new System.EventHandler(this.txtCorreoVerificado_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtCorreo;
    }
}
