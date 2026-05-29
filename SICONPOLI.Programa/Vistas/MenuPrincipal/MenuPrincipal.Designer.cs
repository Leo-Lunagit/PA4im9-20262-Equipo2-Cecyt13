namespace PA4IM9_20262_Equipo2.Vistas.Panel_Principal
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.BarraLateral = new System.Windows.Forms.Panel();
            this.btnSucursales = new System.Windows.Forms.Button();
            this.imgListBotones = new System.Windows.Forms.ImageList(this.components);
            this.iconoMarca = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnProvedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSalidas = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panOpciones = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.imgListDesplegables = new System.Windows.Forms.ImageList(this.components);
            this.btnUsuario = new System.Windows.Forms.Button();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.panInstitucion = new System.Windows.Forms.Panel();
            this.lblLaTecnica = new System.Windows.Forms.Label();
            this.lblCecyt = new System.Windows.Forms.Label();
            this.lblIPN = new System.Windows.Forms.Label();
            this.lblRFM = new System.Windows.Forms.Label();
            this.linea1 = new System.Windows.Forms.Panel();
            this.LogoIPN = new System.Windows.Forms.PictureBox();
            this.LogoAniIPN = new System.Windows.Forms.PictureBox();
            this.LogoAniCecyt = new System.Windows.Forms.PictureBox();
            this.logoCecyt = new System.Windows.Forms.PictureBox();
            this.BarraLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMarca)).BeginInit();
            this.panel5.SuspendLayout();
            this.panOpciones.SuspendLayout();
            this.panInstitucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoAniIPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoAniCecyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoCecyt)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraLateral
            // 
            this.BarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(29)))), ((int)(((byte)(70)))));
            this.BarraLateral.Controls.Add(this.btnSucursales);
            this.BarraLateral.Controls.Add(this.iconoMarca);
            this.BarraLateral.Controls.Add(this.panel5);
            this.BarraLateral.Controls.Add(this.btnAlmacen);
            this.BarraLateral.Controls.Add(this.btnProvedores);
            this.BarraLateral.Controls.Add(this.btnClientes);
            this.BarraLateral.Controls.Add(this.btnSalidas);
            this.BarraLateral.Controls.Add(this.btnEntradas);
            this.BarraLateral.Controls.Add(this.btnHome);
            this.BarraLateral.Controls.Add(this.panOpciones);
            this.BarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraLateral.Location = new System.Drawing.Point(0, 0);
            this.BarraLateral.Name = "BarraLateral";
            this.BarraLateral.Size = new System.Drawing.Size(250, 803);
            this.BarraLateral.TabIndex = 1;
            // 
            // btnSucursales
            // 
            this.btnSucursales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSucursales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSucursales.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucursales.ForeColor = System.Drawing.Color.Black;
            this.btnSucursales.ImageIndex = 6;
            this.btnSucursales.ImageList = this.imgListBotones;
            this.btnSucursales.Location = new System.Drawing.Point(3, 544);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Size = new System.Drawing.Size(241, 46);
            this.btnSucursales.TabIndex = 10;
            this.btnSucursales.Text = "Sucursales";
            this.btnSucursales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSucursales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSucursales.UseVisualStyleBackColor = true;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
            // 
            // imgListBotones
            // 
            this.imgListBotones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListBotones.ImageStream")));
            this.imgListBotones.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListBotones.Images.SetKeyName(0, "home.png");
            this.imgListBotones.Images.SetKeyName(1, "compras.png");
            this.imgListBotones.Images.SetKeyName(2, "ventas.png");
            this.imgListBotones.Images.SetKeyName(3, "clientes.png");
            this.imgListBotones.Images.SetKeyName(4, "provedores.png");
            this.imgListBotones.Images.SetKeyName(5, "inventario.png");
            this.imgListBotones.Images.SetKeyName(6, "sucursales.png");
            this.imgListBotones.Images.SetKeyName(7, "opsiones.png");
            // 
            // iconoMarca
            // 
            this.iconoMarca.Image = ((System.Drawing.Image)(resources.GetObject("iconoMarca.Image")));
            this.iconoMarca.Location = new System.Drawing.Point(1, 7);
            this.iconoMarca.Name = "iconoMarca";
            this.iconoMarca.Size = new System.Drawing.Size(247, 191);
            this.iconoMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMarca.TabIndex = 0;
            this.iconoMarca.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnOpciones);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 742);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 61);
            this.panel5.TabIndex = 8;
            // 
            // btnOpciones
            // 
            this.btnOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpciones.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpciones.ForeColor = System.Drawing.Color.Black;
            this.btnOpciones.ImageIndex = 7;
            this.btnOpciones.ImageList = this.imgListBotones;
            this.btnOpciones.Location = new System.Drawing.Point(3, 3);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(241, 46);
            this.btnOpciones.TabIndex = 9;
            this.btnOpciones.Text = "Opciónes";
            this.btnOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpciones.UseVisualStyleBackColor = true;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            this.btnOpciones.MouseLeave += new System.EventHandler(this.btnOpciones_MouseLeave);
            this.btnOpciones.MouseHover += new System.EventHandler(this.btnOpciones_MouseHover);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlmacen.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.ForeColor = System.Drawing.Color.Black;
            this.btnAlmacen.ImageIndex = 5;
            this.btnAlmacen.ImageList = this.imgListBotones;
            this.btnAlmacen.Location = new System.Drawing.Point(3, 492);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(241, 46);
            this.btnAlmacen.TabIndex = 5;
            this.btnAlmacen.Text = "Almacén";
            this.btnAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnProvedores
            // 
            this.btnProvedores.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnProvedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProvedores.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvedores.ForeColor = System.Drawing.Color.Black;
            this.btnProvedores.ImageIndex = 4;
            this.btnProvedores.ImageList = this.imgListBotones;
            this.btnProvedores.Location = new System.Drawing.Point(3, 440);
            this.btnProvedores.Name = "btnProvedores";
            this.btnProvedores.Size = new System.Drawing.Size(241, 46);
            this.btnProvedores.TabIndex = 4;
            this.btnProvedores.Text = "Proveedores";
            this.btnProvedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProvedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProvedores.UseVisualStyleBackColor = true;
            this.btnProvedores.Click += new System.EventHandler(this.btnProvedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.ImageIndex = 3;
            this.btnClientes.ImageList = this.imgListBotones;
            this.btnClientes.Location = new System.Drawing.Point(3, 388);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(241, 46);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSalidas
            // 
            this.btnSalidas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSalidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalidas.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidas.ForeColor = System.Drawing.Color.Black;
            this.btnSalidas.ImageIndex = 2;
            this.btnSalidas.ImageList = this.imgListBotones;
            this.btnSalidas.Location = new System.Drawing.Point(3, 336);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Size = new System.Drawing.Size(241, 46);
            this.btnSalidas.TabIndex = 2;
            this.btnSalidas.Text = "Salidas";
            this.btnSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalidas.UseVisualStyleBackColor = true;
            this.btnSalidas.Click += new System.EventHandler(this.btnSalidas_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntradas.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.ForeColor = System.Drawing.Color.Black;
            this.btnEntradas.ImageIndex = 1;
            this.btnEntradas.ImageList = this.imgListBotones;
            this.btnEntradas.Location = new System.Drawing.Point(3, 284);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(241, 46);
            this.btnEntradas.TabIndex = 1;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntradas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.ImageIndex = 0;
            this.btnHome.ImageList = this.imgListBotones;
            this.btnHome.Location = new System.Drawing.Point(3, 232);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(241, 46);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panOpciones
            // 
            this.panOpciones.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panOpciones.Controls.Add(this.btnConfig);
            this.panOpciones.Controls.Add(this.btnUsuario);
            this.panOpciones.Location = new System.Drawing.Point(81, 659);
            this.panOpciones.Name = "panOpciones";
            this.panOpciones.Size = new System.Drawing.Size(163, 90);
            this.panOpciones.TabIndex = 11;
            this.panOpciones.Visible = false;
            this.panOpciones.MouseLeave += new System.EventHandler(this.panOpciones_MouseLeave);
            this.panOpciones.MouseHover += new System.EventHandler(this.panOpciones_MouseHover);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.ImageIndex = 0;
            this.btnConfig.ImageList = this.imgListDesplegables;
            this.btnConfig.Location = new System.Drawing.Point(10, 45);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(150, 36);
            this.btnConfig.TabIndex = 9;
            this.btnConfig.Text = "Settings";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // imgListDesplegables
            // 
            this.imgListDesplegables.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListDesplegables.ImageStream")));
            this.imgListDesplegables.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListDesplegables.Images.SetKeyName(0, "configuracion.png");
            this.imgListDesplegables.Images.SetKeyName(1, "usuario.png");
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.ImageIndex = 1;
            this.btnUsuario.ImageList = this.imgListDesplegables;
            this.btnUsuario.Location = new System.Drawing.Point(10, 6);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(150, 36);
            this.btnUsuario.TabIndex = 6;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.White;
            this.Contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Contenedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.Contenedor.Location = new System.Drawing.Point(250, 96);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1082, 707);
            this.Contenedor.TabIndex = 3;
            // 
            // panInstitucion
            // 
            this.panInstitucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(29)))), ((int)(((byte)(70)))));
            this.panInstitucion.Controls.Add(this.lblLaTecnica);
            this.panInstitucion.Controls.Add(this.lblCecyt);
            this.panInstitucion.Controls.Add(this.lblIPN);
            this.panInstitucion.Controls.Add(this.lblRFM);
            this.panInstitucion.Controls.Add(this.linea1);
            this.panInstitucion.Controls.Add(this.LogoIPN);
            this.panInstitucion.Controls.Add(this.LogoAniIPN);
            this.panInstitucion.Controls.Add(this.LogoAniCecyt);
            this.panInstitucion.Controls.Add(this.logoCecyt);
            this.panInstitucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panInstitucion.Location = new System.Drawing.Point(250, 0);
            this.panInstitucion.Margin = new System.Windows.Forms.Padding(4);
            this.panInstitucion.Name = "panInstitucion";
            this.panInstitucion.Size = new System.Drawing.Size(1082, 98);
            this.panInstitucion.TabIndex = 14;
            // 
            // lblLaTecnica
            // 
            this.lblLaTecnica.AutoSize = true;
            this.lblLaTecnica.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaTecnica.ForeColor = System.Drawing.Color.White;
            this.lblLaTecnica.Location = new System.Drawing.Point(641, 50);
            this.lblLaTecnica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaTecnica.Name = "lblLaTecnica";
            this.lblLaTecnica.Size = new System.Drawing.Size(275, 22);
            this.lblLaTecnica.TabIndex = 8;
            this.lblLaTecnica.Text = "\"La Técnica al Servicio de la Patria\"";
            // 
            // lblCecyt
            // 
            this.lblCecyt.Font = new System.Drawing.Font("Microsoft Tai Le", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblCecyt.ForeColor = System.Drawing.Color.White;
            this.lblCecyt.Location = new System.Drawing.Point(136, 11);
            this.lblCecyt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCecyt.Name = "lblCecyt";
            this.lblCecyt.Size = new System.Drawing.Size(257, 50);
            this.lblCecyt.TabIndex = 5;
            this.lblCecyt.Text = "Centro de Estudios Cientificos y Tecnologicos No. 13";
            this.lblCecyt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIPN
            // 
            this.lblIPN.AutoSize = true;
            this.lblIPN.Font = new System.Drawing.Font("Microsoft Tai Le", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblIPN.ForeColor = System.Drawing.Color.White;
            this.lblIPN.Location = new System.Drawing.Point(637, 27);
            this.lblIPN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPN.Name = "lblIPN";
            this.lblIPN.Size = new System.Drawing.Size(262, 23);
            this.lblIPN.TabIndex = 7;
            this.lblIPN.Text = "Instituto Politecnico Nacional";
            // 
            // lblRFM
            // 
            this.lblRFM.AutoSize = true;
            this.lblRFM.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFM.ForeColor = System.Drawing.Color.White;
            this.lblRFM.Location = new System.Drawing.Point(165, 60);
            this.lblRFM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRFM.Name = "lblRFM";
            this.lblRFM.Size = new System.Drawing.Size(189, 22);
            this.lblRFM.TabIndex = 6;
            this.lblRFM.Text = "\"Ricardo Flores Magón\"";
            // 
            // linea1
            // 
            this.linea1.BackColor = System.Drawing.Color.Black;
            this.linea1.Location = new System.Drawing.Point(521, 6);
            this.linea1.Margin = new System.Windows.Forms.Padding(4);
            this.linea1.Name = "linea1";
            this.linea1.Size = new System.Drawing.Size(1, 89);
            this.linea1.TabIndex = 4;
            // 
            // LogoIPN
            // 
            this.LogoIPN.Image = ((System.Drawing.Image)(resources.GetObject("LogoIPN.Image")));
            this.LogoIPN.Location = new System.Drawing.Point(917, 10);
            this.LogoIPN.Margin = new System.Windows.Forms.Padding(4);
            this.LogoIPN.Name = "LogoIPN";
            this.LogoIPN.Size = new System.Drawing.Size(85, 79);
            this.LogoIPN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoIPN.TabIndex = 3;
            this.LogoIPN.TabStop = false;
            // 
            // LogoAniIPN
            // 
            this.LogoAniIPN.Image = ((System.Drawing.Image)(resources.GetObject("LogoAniIPN.Image")));
            this.LogoAniIPN.Location = new System.Drawing.Point(544, 10);
            this.LogoAniIPN.Margin = new System.Windows.Forms.Padding(4);
            this.LogoAniIPN.Name = "LogoAniIPN";
            this.LogoAniIPN.Size = new System.Drawing.Size(85, 79);
            this.LogoAniIPN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoAniIPN.TabIndex = 2;
            this.LogoAniIPN.TabStop = false;
            // 
            // LogoAniCecyt
            // 
            this.LogoAniCecyt.Image = ((System.Drawing.Image)(resources.GetObject("LogoAniCecyt.Image")));
            this.LogoAniCecyt.Location = new System.Drawing.Point(415, 10);
            this.LogoAniCecyt.Margin = new System.Windows.Forms.Padding(4);
            this.LogoAniCecyt.Name = "LogoAniCecyt";
            this.LogoAniCecyt.Size = new System.Drawing.Size(85, 79);
            this.LogoAniCecyt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoAniCecyt.TabIndex = 1;
            this.LogoAniCecyt.TabStop = false;
            // 
            // logoCecyt
            // 
            this.logoCecyt.Image = ((System.Drawing.Image)(resources.GetObject("logoCecyt.Image")));
            this.logoCecyt.Location = new System.Drawing.Point(43, 10);
            this.logoCecyt.Margin = new System.Windows.Forms.Padding(4);
            this.logoCecyt.Name = "logoCecyt";
            this.logoCecyt.Size = new System.Drawing.Size(85, 79);
            this.logoCecyt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoCecyt.TabIndex = 0;
            this.logoCecyt.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 803);
            this.Controls.Add(this.panInstitucion);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.BarraLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuPrincipal";
            this.Text = "SIRETECH Poli.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.BarraLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoMarca)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panOpciones.ResumeLayout(false);
            this.panInstitucion.ResumeLayout(false);
            this.panInstitucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoAniIPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoAniCecyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoCecyt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraLateral;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnProvedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSalidas;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.PictureBox iconoMarca;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnSucursales;
        private System.Windows.Forms.ImageList imgListBotones;
        private System.Windows.Forms.ImageList imgListDesplegables;
        private System.Windows.Forms.Panel panOpciones;
        private System.Windows.Forms.Panel panInstitucion;
        private System.Windows.Forms.Label lblLaTecnica;
        private System.Windows.Forms.Label lblCecyt;
        private System.Windows.Forms.Label lblIPN;
        private System.Windows.Forms.Label lblRFM;
        private System.Windows.Forms.Panel linea1;
        private System.Windows.Forms.PictureBox LogoIPN;
        private System.Windows.Forms.PictureBox LogoAniIPN;
        private System.Windows.Forms.PictureBox LogoAniCecyt;
        private System.Windows.Forms.PictureBox logoCecyt;
    }
}