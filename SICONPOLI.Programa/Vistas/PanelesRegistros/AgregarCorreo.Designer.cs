namespace PA4IM9_20262_Equipo2.Vistas.PanelesRegistros
{
    partial class AgregarCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCorreo));
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAgregarCorreo = new System.Windows.Forms.PictureBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.Correos = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCorreo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(12, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(168, 28);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAgregarCorreo
            // 
            this.btnAgregarCorreo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCorreo.Image")));
            this.btnAgregarCorreo.Location = new System.Drawing.Point(192, 7);
            this.btnAgregarCorreo.Name = "btnAgregarCorreo";
            this.btnAgregarCorreo.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarCorreo.TabIndex = 1;
            this.btnAgregarCorreo.TabStop = false;
            this.btnAgregarCorreo.Click += new System.EventHandler(this.btnAgregarCorreo_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(105, 117);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Correos
            // 
            this.Correos.AutoScroll = true;
            this.Correos.Location = new System.Drawing.Point(17, 46);
            this.Correos.Name = "Correos";
            this.Correos.Size = new System.Drawing.Size(235, 65);
            this.Correos.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AgregarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 146);
            this.Controls.Add(this.Correos);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarCorreo);
            this.Controls.Add(this.lblMensaje);
            this.Name = "AgregarCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Correo.";
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCorreo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox btnAgregarCorreo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.FlowLayoutPanel Correos;
        private System.Windows.Forms.Button button1;
    }
}