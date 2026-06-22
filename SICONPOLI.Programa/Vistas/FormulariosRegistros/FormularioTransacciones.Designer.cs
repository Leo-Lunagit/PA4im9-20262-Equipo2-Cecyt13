namespace PA4IM9_20262_Equipo2.Vistas.FormulariosRegistros
{
    partial class FormularioTransacciones
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
            this.grpTitulares.SuspendLayout();
            this.grpRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRecursos
            // 
            this.grpRecursos.Text = "Bancos";
            // 
            // lblNoRecursos
            // 
            this.lblNoRecursos.Location = new System.Drawing.Point(115, 28);
            // 
            // lblIDMovimiento
            // 
            this.lblIDMovimiento.Location = new System.Drawing.Point(189, 28);
            this.lblIDMovimiento.Size = new System.Drawing.Size(89, 25);
            this.lblIDMovimiento.Text = "Movimiento";
            // 
            // lblRecursos
            // 
            this.lblRecursos.Size = new System.Drawing.Size(58, 25);
            this.lblRecursos.Text = "Bancos";
            // 
            // txtTitular
            // 
            this.txtTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // FormularioTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FormularioTransacciones";
            this.grpTitulares.ResumeLayout(false);
            this.grpTitulares.PerformLayout();
            this.grpRecursos.ResumeLayout(false);
            this.grpRecursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
