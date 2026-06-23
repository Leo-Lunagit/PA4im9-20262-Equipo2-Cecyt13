namespace PA4IM9_20262_Equipo2.Vistas.PanelesRegistros
{
    partial class AgregarTitular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTitular));
            this.Contenedor = new System.Windows.Forms.Panel();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.chkImagen = new System.Windows.Forms.CheckBox();
            this.txtLinkImagen = new System.Windows.Forms.TextBox();
            this.chkTelefono = new System.Windows.Forms.CheckBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.chkCorreo = new System.Windows.Forms.CheckBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.chkDireccion = new System.Windows.Forms.CheckBox();
            this.chkCredito = new System.Windows.Forms.CheckBox();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCreditos = new System.Windows.Forms.ComboBox();
            this.lblLorem = new System.Windows.Forms.Label();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Contenedor.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Controls.Add(this.grpDatos);
            this.Contenedor.Controls.Add(this.lblLorem);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 66);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(374, 375);
            this.Contenedor.TabIndex = 3;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.chkImagen);
            this.grpDatos.Controls.Add(this.txtLinkImagen);
            this.grpDatos.Controls.Add(this.chkTelefono);
            this.grpDatos.Controls.Add(this.txtTelefono);
            this.grpDatos.Controls.Add(this.chkCorreo);
            this.grpDatos.Controls.Add(this.txtCorreo);
            this.grpDatos.Controls.Add(this.chkDireccion);
            this.grpDatos.Controls.Add(this.chkCredito);
            this.grpDatos.Controls.Add(this.chkNombre);
            this.grpDatos.Controls.Add(this.btnRegistrar);
            this.grpDatos.Controls.Add(this.txtCredito);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.cmbCreditos);
            this.grpDatos.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(88)))), ((int)(((byte)(77)))));
            this.grpDatos.Location = new System.Drawing.Point(16, 58);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(342, 299);
            this.grpDatos.TabIndex = 3;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Rellena los datos";
            // 
            // chkImagen
            // 
            this.chkImagen.AutoSize = true;
            this.chkImagen.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.chkImagen.Location = new System.Drawing.Point(20, 214);
            this.chkImagen.Name = "chkImagen";
            this.chkImagen.Size = new System.Drawing.Size(136, 22);
            this.chkImagen.TabIndex = 17;
            this.chkImagen.Text = "Link de Imagen:";
            this.chkImagen.UseVisualStyleBackColor = true;
            // 
            // txtLinkImagen
            // 
            this.txtLinkImagen.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(144)))), ((int)(((byte)(86)))));
            this.txtLinkImagen.Location = new System.Drawing.Point(155, 214);
            this.txtLinkImagen.Margin = new System.Windows.Forms.Padding(2);
            this.txtLinkImagen.MaxLength = 40;
            this.txtLinkImagen.Name = "txtLinkImagen";
            this.txtLinkImagen.Size = new System.Drawing.Size(167, 25);
            this.txtLinkImagen.TabIndex = 16;
            this.txtLinkImagen.Text = "Enlace a Logotipo";
            this.txtLinkImagen.Enter += new System.EventHandler(this.txtImagen_Enter);
            this.txtLinkImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // chkTelefono
            // 
            this.chkTelefono.AutoSize = true;
            this.chkTelefono.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.chkTelefono.Location = new System.Drawing.Point(20, 177);
            this.chkTelefono.Name = "chkTelefono";
            this.chkTelefono.Size = new System.Drawing.Size(87, 22);
            this.chkTelefono.TabIndex = 15;
            this.chkTelefono.Text = "Telefono:";
            this.chkTelefono.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(144)))), ((int)(((byte)(86)))));
            this.txtTelefono.Location = new System.Drawing.Point(110, 177);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.MaxLength = 40;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(212, 25);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // chkCorreo
            // 
            this.chkCorreo.AutoSize = true;
            this.chkCorreo.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.chkCorreo.Location = new System.Drawing.Point(20, 140);
            this.chkCorreo.Name = "chkCorreo";
            this.chkCorreo.Size = new System.Drawing.Size(77, 22);
            this.chkCorreo.TabIndex = 13;
            this.chkCorreo.Text = "Correo :";
            this.chkCorreo.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(144)))), ((int)(((byte)(86)))));
            this.txtCorreo.Location = new System.Drawing.Point(110, 140);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.MaxLength = 40;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(212, 25);
            this.txtCorreo.TabIndex = 12;
            this.txtCorreo.Text = "Email";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // chkDireccion
            // 
            this.chkDireccion.AutoSize = true;
            this.chkDireccion.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.chkDireccion.Location = new System.Drawing.Point(19, 103);
            this.chkDireccion.Name = "chkDireccion";
            this.chkDireccion.Size = new System.Drawing.Size(93, 22);
            this.chkDireccion.TabIndex = 11;
            this.chkDireccion.Text = "Direccion:";
            this.chkDireccion.UseVisualStyleBackColor = true;
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.chkCredito.Location = new System.Drawing.Point(20, 66);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(82, 22);
            this.chkCredito.TabIndex = 10;
            this.chkCredito.Text = "Credito :";
            this.chkCredito.UseVisualStyleBackColor = true;
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Checked = true;
            this.chkNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNombre.Enabled = false;
            this.chkNombre.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.chkNombre.Location = new System.Drawing.Point(20, 31);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(86, 22);
            this.chkNombre.TabIndex = 9;
            this.chkNombre.Text = "Nombre :";
            this.chkNombre.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(144)))), ((int)(((byte)(86)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(93, 254);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(157, 32);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Guardar Titular";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCredito
            // 
            this.txtCredito.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(144)))), ((int)(((byte)(86)))));
            this.txtCredito.Location = new System.Drawing.Point(110, 66);
            this.txtCredito.Margin = new System.Windows.Forms.Padding(2);
            this.txtCredito.MaxLength = 60;
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(195, 25);
            this.txtCredito.TabIndex = 6;
            this.txtCredito.Text = "Credito";
            this.txtCredito.Enter += new System.EventHandler(this.txtCredito_Enter);
            this.txtCredito.Leave += new System.EventHandler(this.txtCredito_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(144)))), ((int)(((byte)(86)))));
            this.txtNombre.Location = new System.Drawing.Point(110, 29);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(212, 25);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(144)))), ((int)(((byte)(86)))));
            this.txtDireccion.Location = new System.Drawing.Point(111, 103);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.MaxLength = 40;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(212, 25);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.Text = "Direccion";
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // cmbCreditos
            // 
            this.cmbCreditos.FormattingEnabled = true;
            this.cmbCreditos.Items.AddRange(new object[] {
            "Sin Credito",
            "Sin Limite",
            "Monto"});
            this.cmbCreditos.Location = new System.Drawing.Point(110, 66);
            this.cmbCreditos.Name = "cmbCreditos";
            this.cmbCreditos.Size = new System.Drawing.Size(212, 25);
            this.cmbCreditos.TabIndex = 18;
            this.cmbCreditos.SelectedIndexChanged += new System.EventHandler(this.cmbCreditos_SelectedIndexChanged);
            // 
            // lblLorem
            // 
            this.lblLorem.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLorem.Location = new System.Drawing.Point(12, 20);
            this.lblLorem.Name = "lblLorem";
            this.lblLorem.Size = new System.Drawing.Size(359, 35);
            this.lblLorem.TabIndex = 0;
            this.lblLorem.Text = "!Genial, mas gente se une al hermoso mundo del reciclaje¡ Contacta con el itular " +
    "para obtener la siguiente información.";
            this.lblLorem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(185)))));
            this.BarraSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BarraSuperior.BackgroundImage")));
            this.BarraSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(374, 66);
            this.BarraSuperior.TabIndex = 2;
            // 
            // AgregarTitular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 441);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.BarraSuperior);
            this.Name = "AgregarTitular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarTitular";
            this.Contenedor.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLorem;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.CheckBox chkTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.CheckBox chkCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.CheckBox chkDireccion;
        private System.Windows.Forms.CheckBox chkCredito;
        private System.Windows.Forms.CheckBox chkImagen;
        private System.Windows.Forms.TextBox txtLinkImagen;
        private System.Windows.Forms.ComboBox cmbCreditos;
    }
}