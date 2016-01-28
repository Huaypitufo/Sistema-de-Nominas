namespace Mool
{
	partial class Insert
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
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtSueldo = new System.Windows.Forms.TextBox();
			this.txtPeriodo = new System.Windows.Forms.TextBox();
			this.txtIMSS = new System.Windows.Forms.TextBox();
			this.txtRFC = new System.Windows.Forms.TextBox();
			this.txtTrabajo = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblTrabajo = new System.Windows.Forms.Label();
			this.lblDepartamento = new System.Windows.Forms.Label();
			this.lblSueldo = new System.Windows.Forms.Label();
			this.lblRFC = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblPeriodo = new System.Windows.Forms.Label();
			this.cbxDepartamento = new System.Windows.Forms.ComboBox();
			this.lblIMSS = new System.Windows.Forms.Label();
			this.lblMaterno = new System.Windows.Forms.Label();
			this.lblPaterno = new System.Windows.Forms.Label();
			this.txtPaterno = new System.Windows.Forms.TextBox();
			this.txtMaterno = new System.Windows.Forms.TextBox();
			this.txtDeposito = new System.Windows.Forms.TextBox();
			this.lblPrestaciones = new System.Windows.Forms.Label();
			this.txtPrestaciones = new System.Windows.Forms.TextBox();
			this.lblDeposito = new System.Windows.Forms.Label();
			this.lblCURP = new System.Windows.Forms.Label();
			this.txtCURP = new System.Windows.Forms.TextBox();
			this.lblSexo = new System.Windows.Forms.Label();
			this.cbxSexo = new System.Windows.Forms.ComboBox();
			this.lblAlta = new System.Windows.Forms.Label();
			this.dtpAlta = new System.Windows.Forms.DateTimePicker();
			this.lblBaja = new System.Windows.Forms.Label();
			this.dtpBaja = new System.Windows.Forms.DateTimePicker();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(139, 22);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(133, 20);
			this.txtNombre.TabIndex = 0;
			// 
			// txtSueldo
			// 
			this.txtSueldo.Location = new System.Drawing.Point(187, 295);
			this.txtSueldo.Name = "txtSueldo";
			this.txtSueldo.Size = new System.Drawing.Size(85, 20);
			this.txtSueldo.TabIndex = 1;
			this.txtSueldo.Text = "0";
			// 
			// txtPeriodo
			// 
			this.txtPeriodo.Location = new System.Drawing.Point(85, 295);
			this.txtPeriodo.Name = "txtPeriodo";
			this.txtPeriodo.Size = new System.Drawing.Size(45, 20);
			this.txtPeriodo.TabIndex = 2;
			this.txtPeriodo.Text = "0";
			// 
			// txtIMSS
			// 
			this.txtIMSS.Location = new System.Drawing.Point(139, 360);
			this.txtIMSS.Name = "txtIMSS";
			this.txtIMSS.Size = new System.Drawing.Size(133, 20);
			this.txtIMSS.TabIndex = 3;
			// 
			// txtRFC
			// 
			this.txtRFC.Location = new System.Drawing.Point(139, 329);
			this.txtRFC.Name = "txtRFC";
			this.txtRFC.Size = new System.Drawing.Size(133, 20);
			this.txtRFC.TabIndex = 4;
			// 
			// txtTrabajo
			// 
			this.txtTrabajo.Location = new System.Drawing.Point(139, 240);
			this.txtTrabajo.Name = "txtTrabajo";
			this.txtTrabajo.Size = new System.Drawing.Size(133, 20);
			this.txtTrabajo.TabIndex = 5;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(15, 153);
			this.txtDireccion.Multiline = true;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(257, 73);
			this.txtDireccion.TabIndex = 6;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(411, 392);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 7;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(12, 137);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(55, 13);
			this.lblDireccion.TabIndex = 10;
			this.lblDireccion.Text = "Dirección:";
			// 
			// lblTrabajo
			// 
			this.lblTrabajo.AutoSize = true;
			this.lblTrabajo.Location = new System.Drawing.Point(12, 240);
			this.lblTrabajo.Name = "lblTrabajo";
			this.lblTrabajo.Size = new System.Drawing.Size(46, 13);
			this.lblTrabajo.TabIndex = 11;
			this.lblTrabajo.Text = "Trabajo:";
			// 
			// lblDepartamento
			// 
			this.lblDepartamento.AutoSize = true;
			this.lblDepartamento.Location = new System.Drawing.Point(12, 268);
			this.lblDepartamento.Name = "lblDepartamento";
			this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
			this.lblDepartamento.TabIndex = 12;
			this.lblDepartamento.Text = "Departamento:";
			// 
			// lblSueldo
			// 
			this.lblSueldo.AutoSize = true;
			this.lblSueldo.Location = new System.Drawing.Point(136, 299);
			this.lblSueldo.Name = "lblSueldo";
			this.lblSueldo.Size = new System.Drawing.Size(43, 13);
			this.lblSueldo.TabIndex = 14;
			this.lblSueldo.Text = "Sueldo:";
			// 
			// lblRFC
			// 
			this.lblRFC.AutoSize = true;
			this.lblRFC.Location = new System.Drawing.Point(12, 332);
			this.lblRFC.Name = "lblRFC";
			this.lblRFC.Size = new System.Drawing.Size(31, 13);
			this.lblRFC.TabIndex = 15;
			this.lblRFC.Text = "RFC:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(12, 22);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(47, 13);
			this.lblNombre.TabIndex = 16;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblPeriodo
			// 
			this.lblPeriodo.AutoSize = true;
			this.lblPeriodo.Location = new System.Drawing.Point(12, 299);
			this.lblPeriodo.Name = "lblPeriodo";
			this.lblPeriodo.Size = new System.Drawing.Size(46, 13);
			this.lblPeriodo.TabIndex = 13;
			this.lblPeriodo.Text = "Periodo:";
			// 
			// cbxDepartamento
			// 
			this.cbxDepartamento.FormattingEnabled = true;
			this.cbxDepartamento.Location = new System.Drawing.Point(107, 268);
			this.cbxDepartamento.Name = "cbxDepartamento";
			this.cbxDepartamento.Size = new System.Drawing.Size(165, 21);
			this.cbxDepartamento.TabIndex = 17;
			// 
			// lblIMSS
			// 
			this.lblIMSS.AutoSize = true;
			this.lblIMSS.Location = new System.Drawing.Point(12, 363);
			this.lblIMSS.Name = "lblIMSS";
			this.lblIMSS.Size = new System.Drawing.Size(36, 13);
			this.lblIMSS.TabIndex = 18;
			this.lblIMSS.Text = "IMSS:";
			// 
			// lblMaterno
			// 
			this.lblMaterno.AutoSize = true;
			this.lblMaterno.Location = new System.Drawing.Point(12, 78);
			this.lblMaterno.Name = "lblMaterno";
			this.lblMaterno.Size = new System.Drawing.Size(89, 13);
			this.lblMaterno.TabIndex = 22;
			this.lblMaterno.Text = "Apellido Materno:";
			// 
			// lblPaterno
			// 
			this.lblPaterno.AutoSize = true;
			this.lblPaterno.Location = new System.Drawing.Point(12, 51);
			this.lblPaterno.Name = "lblPaterno";
			this.lblPaterno.Size = new System.Drawing.Size(87, 13);
			this.lblPaterno.TabIndex = 21;
			this.lblPaterno.Text = "Apellido Paterno:";
			// 
			// txtPaterno
			// 
			this.txtPaterno.Location = new System.Drawing.Point(139, 48);
			this.txtPaterno.Name = "txtPaterno";
			this.txtPaterno.Size = new System.Drawing.Size(133, 20);
			this.txtPaterno.TabIndex = 20;
			// 
			// txtMaterno
			// 
			this.txtMaterno.Location = new System.Drawing.Point(139, 75);
			this.txtMaterno.Name = "txtMaterno";
			this.txtMaterno.Size = new System.Drawing.Size(133, 20);
			this.txtMaterno.TabIndex = 19;
			// 
			// txtDeposito
			// 
			this.txtDeposito.Location = new System.Drawing.Point(380, 19);
			this.txtDeposito.Name = "txtDeposito";
			this.txtDeposito.Size = new System.Drawing.Size(45, 20);
			this.txtDeposito.TabIndex = 24;
			this.txtDeposito.Text = "0";
			// 
			// lblPrestaciones
			// 
			this.lblPrestaciones.AutoSize = true;
			this.lblPrestaciones.Location = new System.Drawing.Point(431, 22);
			this.lblPrestaciones.Name = "lblPrestaciones";
			this.lblPrestaciones.Size = new System.Drawing.Size(71, 13);
			this.lblPrestaciones.TabIndex = 25;
			this.lblPrestaciones.Text = "Prestaciones:";
			// 
			// txtPrestaciones
			// 
			this.txtPrestaciones.Location = new System.Drawing.Point(508, 19);
			this.txtPrestaciones.Name = "txtPrestaciones";
			this.txtPrestaciones.Size = new System.Drawing.Size(59, 20);
			this.txtPrestaciones.TabIndex = 26;
			this.txtPrestaciones.Text = "0";
			// 
			// lblDeposito
			// 
			this.lblDeposito.AutoSize = true;
			this.lblDeposito.Location = new System.Drawing.Point(307, 22);
			this.lblDeposito.Name = "lblDeposito";
			this.lblDeposito.Size = new System.Drawing.Size(52, 13);
			this.lblDeposito.TabIndex = 23;
			this.lblDeposito.Text = "Deposito:";
			// 
			// lblCURP
			// 
			this.lblCURP.AutoSize = true;
			this.lblCURP.Location = new System.Drawing.Point(307, 54);
			this.lblCURP.Name = "lblCURP";
			this.lblCURP.Size = new System.Drawing.Size(40, 13);
			this.lblCURP.TabIndex = 27;
			this.lblCURP.Text = "CURP:";
			// 
			// txtCURP
			// 
			this.txtCURP.Location = new System.Drawing.Point(434, 51);
			this.txtCURP.Name = "txtCURP";
			this.txtCURP.Size = new System.Drawing.Size(133, 20);
			this.txtCURP.TabIndex = 28;
			// 
			// lblSexo
			// 
			this.lblSexo.AutoSize = true;
			this.lblSexo.Location = new System.Drawing.Point(12, 108);
			this.lblSexo.Name = "lblSexo";
			this.lblSexo.Size = new System.Drawing.Size(34, 13);
			this.lblSexo.TabIndex = 29;
			this.lblSexo.Text = "Sexo:";
			// 
			// cbxSexo
			// 
			this.cbxSexo.FormattingEnabled = true;
			this.cbxSexo.Location = new System.Drawing.Point(213, 108);
			this.cbxSexo.Name = "cbxSexo";
			this.cbxSexo.Size = new System.Drawing.Size(59, 21);
			this.cbxSexo.TabIndex = 30;
			// 
			// lblAlta
			// 
			this.lblAlta.AutoSize = true;
			this.lblAlta.Location = new System.Drawing.Point(307, 89);
			this.lblAlta.Name = "lblAlta";
			this.lblAlta.Size = new System.Drawing.Size(61, 13);
			this.lblAlta.TabIndex = 31;
			this.lblAlta.Text = "Fecha Alta:";
			// 
			// dtpAlta
			// 
			this.dtpAlta.Location = new System.Drawing.Point(371, 87);
			this.dtpAlta.Name = "dtpAlta";
			this.dtpAlta.Size = new System.Drawing.Size(196, 20);
			this.dtpAlta.TabIndex = 32;
			// 
			// lblBaja
			// 
			this.lblBaja.AutoSize = true;
			this.lblBaja.Location = new System.Drawing.Point(307, 125);
			this.lblBaja.Name = "lblBaja";
			this.lblBaja.Size = new System.Drawing.Size(64, 13);
			this.lblBaja.TabIndex = 33;
			this.lblBaja.Text = "Fecha Baja:";
			// 
			// dtpBaja
			// 
			this.dtpBaja.Location = new System.Drawing.Point(371, 120);
			this.dtpBaja.Name = "dtpBaja";
			this.dtpBaja.Size = new System.Drawing.Size(196, 20);
			this.dtpBaja.TabIndex = 34;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(492, 392);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 40;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// Insert
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 427);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.dtpBaja);
			this.Controls.Add(this.lblBaja);
			this.Controls.Add(this.dtpAlta);
			this.Controls.Add(this.lblAlta);
			this.Controls.Add(this.cbxSexo);
			this.Controls.Add(this.lblSexo);
			this.Controls.Add(this.txtCURP);
			this.Controls.Add(this.lblCURP);
			this.Controls.Add(this.txtPrestaciones);
			this.Controls.Add(this.lblPrestaciones);
			this.Controls.Add(this.txtDeposito);
			this.Controls.Add(this.lblDeposito);
			this.Controls.Add(this.lblMaterno);
			this.Controls.Add(this.lblPaterno);
			this.Controls.Add(this.txtPaterno);
			this.Controls.Add(this.txtMaterno);
			this.Controls.Add(this.lblIMSS);
			this.Controls.Add(this.cbxDepartamento);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblRFC);
			this.Controls.Add(this.lblSueldo);
			this.Controls.Add(this.lblPeriodo);
			this.Controls.Add(this.lblDepartamento);
			this.Controls.Add(this.lblTrabajo);
			this.Controls.Add(this.lblDireccion);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtTrabajo);
			this.Controls.Add(this.txtRFC);
			this.Controls.Add(this.txtIMSS);
			this.Controls.Add(this.txtPeriodo);
			this.Controls.Add(this.txtSueldo);
			this.Controls.Add(this.txtNombre);
			this.Name = "Insert";
			this.Text = "Registro de Empleado";
			this.Load += new System.EventHandler(this.Insertar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtSueldo;
		private System.Windows.Forms.TextBox txtPeriodo;
		private System.Windows.Forms.TextBox txtIMSS;
		private System.Windows.Forms.TextBox txtRFC;
		private System.Windows.Forms.TextBox txtTrabajo;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.Label lblTrabajo;
		private System.Windows.Forms.Label lblDepartamento;
		private System.Windows.Forms.Label lblSueldo;
		private System.Windows.Forms.Label lblRFC;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblPeriodo;
		private System.Windows.Forms.ComboBox cbxDepartamento;
		private System.Windows.Forms.Label lblIMSS;
		private System.Windows.Forms.Label lblMaterno;
		private System.Windows.Forms.Label lblPaterno;
		private System.Windows.Forms.TextBox txtPaterno;
		private System.Windows.Forms.TextBox txtMaterno;
		private System.Windows.Forms.TextBox txtDeposito;
		private System.Windows.Forms.Label lblPrestaciones;
		private System.Windows.Forms.TextBox txtPrestaciones;
		private System.Windows.Forms.Label lblDeposito;
		private System.Windows.Forms.Label lblCURP;
		private System.Windows.Forms.TextBox txtCURP;
		private System.Windows.Forms.Label lblSexo;
		private System.Windows.Forms.ComboBox cbxSexo;
		private System.Windows.Forms.Label lblAlta;
		private System.Windows.Forms.DateTimePicker dtpAlta;
		private System.Windows.Forms.Label lblBaja;
		private System.Windows.Forms.DateTimePicker dtpBaja;
		private System.Windows.Forms.Button btnCerrar;

	}
}