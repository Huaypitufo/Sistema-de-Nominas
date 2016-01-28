namespace Mool
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnReportes = new System.Windows.Forms.Button();
			this.btnReportManager = new System.Windows.Forms.Button();
			this.dGVEmpleados = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVEmpleados)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(169, 17);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 23);
			this.btnBorrar.TabIndex = 2;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(88, 18);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 4;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(519, 19);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(208, 20);
			this.txtBuscar.TabIndex = 5;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnBuscar.Image = global::Mool.Properties.Resources.glyphicons_027_search;
			this.btnBuscar.Location = new System.Drawing.Point(733, 15);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(30, 27);
			this.btnBuscar.TabIndex = 6;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnNuevo.Location = new System.Drawing.Point(7, 18);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 1;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnReportes);
			this.groupBox1.Controls.Add(this.btnReportManager);
			this.groupBox1.Controls.Add(this.dGVEmpleados);
			this.groupBox1.Controls.Add(this.btnNuevo);
			this.groupBox1.Controls.Add(this.btnBorrar);
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Controls.Add(this.btnEditar);
			this.groupBox1.Controls.Add(this.txtBuscar);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(768, 336);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Constructora Mool - Sistema de Nominas";
			// 
			// btnReportes
			// 
			this.btnReportes.Location = new System.Drawing.Point(250, 18);
			this.btnReportes.Name = "btnReportes";
			this.btnReportes.Size = new System.Drawing.Size(75, 23);
			this.btnReportes.TabIndex = 8;
			this.btnReportes.Text = "Reporte";
			this.btnReportes.UseVisualStyleBackColor = true;
			this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
			// 
			// btnReportManager
			// 
			this.btnReportManager.Location = new System.Drawing.Point(331, 18);
			this.btnReportManager.Name = "btnReportManager";
			this.btnReportManager.Size = new System.Drawing.Size(75, 23);
			this.btnReportManager.TabIndex = 9;
			this.btnReportManager.Text = "Nominas";
			this.btnReportManager.UseVisualStyleBackColor = true;
			// 
			// dGVEmpleados
			// 
			this.dGVEmpleados.AllowUserToAddRows = false;
			this.dGVEmpleados.AllowUserToDeleteRows = false;
			this.dGVEmpleados.AllowUserToResizeRows = false;
			this.dGVEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVEmpleados.Location = new System.Drawing.Point(6, 48);
			this.dGVEmpleados.Name = "dGVEmpleados";
			this.dGVEmpleados.RowHeadersVisible = false;
			this.dGVEmpleados.Size = new System.Drawing.Size(756, 272);
			this.dGVEmpleados.TabIndex = 7;
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 355);
			this.Controls.Add(this.groupBox1);
			this.Name = "Principal";
			this.Text = "Constructora Mool - Control de Nominas";
			this.Load += new System.EventHandler(this.Principal_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVEmpleados)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dGVEmpleados;
		private System.Windows.Forms.Button btnReportes;
		private System.Windows.Forms.Button btnReportManager;

	}
}

