namespace Mool
{
	partial class Reports
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nSemana = new System.Windows.Forms.NumericUpDown();
			this.dtpPeriodoInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpPeriodoFinal = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.lblAviso = new System.Windows.Forms.Label();
			this.dgvSelected = new System.Windows.Forms.DataGridView();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nSemana)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Systema de Reporte de Nomina";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(506, 332);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cerrar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.nSemana);
			this.panel1.Controls.Add(this.dtpPeriodoInicio);
			this.panel1.Controls.Add(this.dtpPeriodoFinal);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lblAviso);
			this.panel1.Controls.Add(this.dgvSelected);
			this.panel1.Location = new System.Drawing.Point(12, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(569, 301);
			this.panel1.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(344, 17);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "a";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(117, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "del";
			// 
			// nSemana
			// 
			this.nSemana.Location = new System.Drawing.Point(144, 43);
			this.nSemana.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
			this.nSemana.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nSemana.Name = "nSemana";
			this.nSemana.Size = new System.Drawing.Size(34, 20);
			this.nSemana.TabIndex = 19;
			this.nSemana.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// dtpPeriodoInicio
			// 
			this.dtpPeriodoInicio.Location = new System.Drawing.Point(144, 11);
			this.dtpPeriodoInicio.Name = "dtpPeriodoInicio";
			this.dtpPeriodoInicio.Size = new System.Drawing.Size(194, 20);
			this.dtpPeriodoInicio.TabIndex = 18;
			// 
			// dtpPeriodoFinal
			// 
			this.dtpPeriodoFinal.Location = new System.Drawing.Point(363, 11);
			this.dtpPeriodoFinal.Name = "dtpPeriodoFinal";
			this.dtpPeriodoFinal.Size = new System.Drawing.Size(189, 20);
			this.dtpPeriodoFinal.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Semana: ";
			// 
			// lblAviso
			// 
			this.lblAviso.AutoSize = true;
			this.lblAviso.Location = new System.Drawing.Point(12, 17);
			this.lblAviso.Name = "lblAviso";
			this.lblAviso.Size = new System.Drawing.Size(104, 13);
			this.lblAviso.TabIndex = 10;
			this.lblAviso.Text = "Seleccione la fecha:";
			// 
			// dgvSelected
			// 
			this.dgvSelected.AllowUserToAddRows = false;
			this.dgvSelected.AllowUserToDeleteRows = false;
			this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSelected.Location = new System.Drawing.Point(15, 69);
			this.dgvSelected.Name = "dgvSelected";
			this.dgvSelected.Size = new System.Drawing.Size(537, 215);
			this.dgvSelected.TabIndex = 0;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(421, 332);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(79, 23);
			this.btnGuardar.TabIndex = 12;
			this.btnGuardar.Text = "Guadar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 358);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.label1);
			this.Name = "Reports";
			this.Text = "Reports";
			this.Load += new System.EventHandler(this.Reports_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nSemana)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvSelected;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblAviso;
		private System.Windows.Forms.DateTimePicker dtpPeriodoFinal;
		private System.Windows.Forms.DateTimePicker dtpPeriodoInicio;
		private System.Windows.Forms.NumericUpDown nSemana;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
	}
}