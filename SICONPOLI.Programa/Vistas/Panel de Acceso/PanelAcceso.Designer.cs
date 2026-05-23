namespace PA4IM9_20262_Equipo2
{
    partial class PanelAcceso
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAcerca = new System.Windows.Forms.Label();
            this.btnPriva = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.separador1 = new System.Windows.Forms.Label();
            this.separador2 = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Label();
            this.grpInicioS = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkBoxRecordar = new System.Windows.Forms.CheckBox();
            this.lblMensajes = new LabelVertical();
            this.grpInicioS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Harrington", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(29)))), ((int)(((byte)(70)))));
            this.lblTitulo.Location = new System.Drawing.Point(15, 76);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(393, 78);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SISTEMA CONTABLE EN \r\nEL POLITECNICO.";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAcerca
            // 
            this.btnAcerca.AutoSize = true;
            this.btnAcerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcerca.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.btnAcerca.Location = new System.Drawing.Point(26, 26);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(81, 29);
            this.btnAcerca.TabIndex = 1;
            this.btnAcerca.Text = "Acerca de";
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // btnPriva
            // 
            this.btnPriva.AutoSize = true;
            this.btnPriva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriva.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.btnPriva.Location = new System.Drawing.Point(135, 26);
            this.btnPriva.Name = "btnPriva";
            this.btnPriva.Size = new System.Drawing.Size(163, 29);
            this.btnPriva.TabIndex = 2;
            this.btnPriva.Text = "Politica de Privacidad";
            this.btnPriva.Click += new System.EventHandler(this.btnPriva_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.btnRegistrar.Location = new System.Drawing.Point(328, 26);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 29);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(48, 41);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(174, 22);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Nombre de Usuario :";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(48, 99);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(109, 22);
            this.lblContrasenia.TabIndex = 5;
            this.lblContrasenia.Text = "Contraseña :";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(29)))), ((int)(((byte)(70)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(72, 205);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(209, 39);
            this.btnAcceder.TabIndex = 6;
            this.btnAcceder.Text = "Iniciar Sesión";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnIniciarS_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.txtUsuario.Location = new System.Drawing.Point(76, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(282, 29);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.txtContrasenia.Location = new System.Drawing.Point(76, 124);
            this.txtContrasenia.MaxLength = 16;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(282, 29);
            this.txtContrasenia.TabIndex = 8;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // separador1
            // 
            this.separador1.AutoSize = true;
            this.separador1.Location = new System.Drawing.Point(111, 32);
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(10, 16);
            this.separador1.TabIndex = 9;
            this.separador1.Text = "|";
            // 
            // separador2
            // 
            this.separador2.AutoSize = true;
            this.separador2.Location = new System.Drawing.Point(305, 32);
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(10, 16);
            this.separador2.TabIndex = 10;
            this.separador2.Text = "|";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.AutoSize = true;
            this.btnRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuperar.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Location = new System.Drawing.Point(78, 247);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(195, 29);
            this.btnRecuperar.TabIndex = 11;
            this.btnRecuperar.Text = "¿Olvidaste tu contraseña?";
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // grpInicioS
            // 
            this.grpInicioS.Controls.Add(this.lblMensajes);
            this.grpInicioS.Controls.Add(this.lblUsuario);
            this.grpInicioS.Controls.Add(this.txtUsuario);
            this.grpInicioS.Controls.Add(this.lblNombre);
            this.grpInicioS.Controls.Add(this.txtNombre);
            this.grpInicioS.Controls.Add(this.chkBoxRecordar);
            this.grpInicioS.Controls.Add(this.lblContrasenia);
            this.grpInicioS.Controls.Add(this.btnRecuperar);
            this.grpInicioS.Controls.Add(this.btnAcceder);
            this.grpInicioS.Controls.Add(this.txtContrasenia);
            this.grpInicioS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpInicioS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpInicioS.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInicioS.Location = new System.Drawing.Point(42, 182);
            this.grpInicioS.Name = "grpInicioS";
            this.grpInicioS.Size = new System.Drawing.Size(380, 282);
            this.grpInicioS.TabIndex = 12;
            this.grpInicioS.TabStop = false;
            this.grpInicioS.Text = "Inciar seción en SICONPOLI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(48, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 22);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre :";
            this.lblNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.txtNombre.Location = new System.Drawing.Point(76, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(282, 29);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.Visible = false;
            // 
            // chkBoxRecordar
            // 
            this.chkBoxRecordar.AutoSize = true;
            this.chkBoxRecordar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBoxRecordar.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.chkBoxRecordar.Location = new System.Drawing.Point(52, 165);
            this.chkBoxRecordar.Name = "chkBoxRecordar";
            this.chkBoxRecordar.Size = new System.Drawing.Size(134, 26);
            this.chkBoxRecordar.TabIndex = 12;
            this.chkBoxRecordar.Text = "Recordarme.";
            this.chkBoxRecordar.UseVisualStyleBackColor = true;
            // 
            // lblMensajes
            // 
            this.lblMensajes.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajes.Font = new System.Drawing.Font("Dubai", 11F);
            this.lblMensajes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.lblMensajes.Location = new System.Drawing.Point(8, 54);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(38, 222);
            this.lblMensajes.TabIndex = 16;
            // 
            // PanelAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 473);
            this.Controls.Add(this.grpInicioS);
            this.Controls.Add(this.separador2);
            this.Controls.Add(this.separador1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnPriva);
            this.Controls.Add(this.btnAcerca);
            this.Controls.Add(this.lblTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximumSize = new System.Drawing.Size(470, 520);
            this.MinimumSize = new System.Drawing.Size(470, 520);
            this.Name = "PanelAcceso";
            this.Text = "Panel de Acceso.";
            this.grpInicioS.ResumeLayout(false);
            this.grpInicioS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label btnAcerca;
        private System.Windows.Forms.Label btnPriva;
        private System.Windows.Forms.Label btnRegistrar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label separador1;
        private System.Windows.Forms.Label separador2;
        private System.Windows.Forms.Label btnRecuperar;
        private System.Windows.Forms.GroupBox grpInicioS;
        private System.Windows.Forms.CheckBox chkBoxRecordar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private LabelVertical lblMensajes;
    }
}

