using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mool
{
	public partial class Insert : Form
	{
		public Insert()
		{
			InitializeComponent();
		}
		
		private void Insertar_Load(object sender, EventArgs e)
		{
			InitializeDefaultValues();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO Empleado({0}) VALUES({1})";
			string[] field ={
								"Nombre", "ApellidoPaterno", "ApellidoMaterno", "Direccion", "Trabajo", "Periodo", "Sueldo", "RFC", "IMSS",
								"Deposito", "Prestaciones", "CURP",	"Sexo", "Id_Departamento", "FechaAlta", "FechaBaja"
							};

			List<SqlParameter> parameter = new List<SqlParameter>();

			if(isValidField())
			{
				parameter.Add(new SqlParameter("@" + txtNombre.Name, txtNombre.Text.ToUpper()));
				parameter.Add(new SqlParameter("@" + txtPaterno.Name, txtPaterno.Text.ToUpper()));
				parameter.Add(new SqlParameter("@" + txtMaterno.Name, txtMaterno.Text.ToUpper()));
				parameter.Add(new SqlParameter("@" + txtDireccion.Name, txtDireccion.Text.ToUpper()));
				parameter.Add(new SqlParameter("@" + txtTrabajo.Name, txtTrabajo.Text.ToUpper()));
				parameter.Add(new SqlParameter("@" + txtPeriodo.Name, txtPeriodo.Text));
				parameter.Add(new SqlParameter("@" + txtSueldo.Name, txtSueldo.Text));
				parameter.Add(new SqlParameter("@" + txtRFC.Name, txtRFC.Text));
				parameter.Add(new SqlParameter("@" + txtIMSS.Name, txtIMSS.Text));
				parameter.Add(new SqlParameter("@" + txtDeposito.Name, txtDeposito.Text));
				parameter.Add(new SqlParameter("@" + txtPrestaciones.Name, txtPrestaciones.Text));
				parameter.Add(new SqlParameter("@" + txtCURP.Name, txtCURP.Text));
				parameter.Add(new SqlParameter("@" + cbxSexo.Name, cbxSexo.SelectedValue));
				parameter.Add(new SqlParameter("@" + cbxDepartamento.Name, cbxDepartamento.SelectedValue));
				parameter.Add(new SqlParameter("@" + dtpAlta.Name, dtpAlta.Value.ToString("yyyy-MM-dd")));
				parameter.Add(new SqlParameter("@" + dtpBaja.Name, dtpBaja.Value.ToString("yyyy-MM-dd")));

				query = string.Format(query, string.Join(",", field), string.Join(",", parameter.Select(p => p.ParameterName)));
				InsertData(query, parameter.ToArray());
			}
		}

		private void InsertData(string query, SqlParameter[] parameter)
		{
			DataObject dao = new DataObject();

			if(dao.Insert(query, parameter) > 0)
			{
				MessageBox.Show("Usuario guardado con exito");
			}
		}
		private bool isValidField()
		{
			bool isValid = true;

			if(string.IsNullOrEmpty(txtNombre.Text))
			{
				isValid = false;
				MessageBox.Show("Campo \"Nombre\" es requerido");
			}

			return isValid;
		}

		private void InitializeDefaultValues()
		{
			DataObject dao = new DataObject();
			List<KeyValuePair<string, string>> items = new List<KeyValuePair<string, string>>();
			
			items.Add(new KeyValuePair<string, string>("M", "Hombre"));
			items.Add(new KeyValuePair<string, string>("F", "Mujer"));

			cbxSexo.DataSource = items;
			cbxSexo.DisplayMember = "Value";
			cbxSexo.ValueMember = "Key";

			cbxSexo.SelectedIndex = 0;

			dao.Select("SELECT Id_Departamento, Descripcion FROM Departamento", "Departamento");
			cbxDepartamento.DataSource = dao.data.Tables["Departamento"];
			cbxDepartamento.DisplayMember = "Descripcion";
			cbxDepartamento.ValueMember = "Id_Departamento";
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}