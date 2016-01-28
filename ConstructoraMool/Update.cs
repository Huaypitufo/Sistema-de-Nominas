using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mool
{
	public partial class Update : Form
	{
		DataRow selectedRow = null;
		DataTable dataToEdit = null;
		
		public Update(DataTable dataToEdit)
		{
			InitializeComponent();
			this.dataToEdit = dataToEdit;
		}

		private void Update_Load(object sender, EventArgs e)
		{
			cbxEmployees.DataSource = dataToEdit;
			cbxEmployees.DisplayMember = "Nombre";
			cbxEmployees.ValueMember = "Id_Empleado";

			cbxEmployees_SelectionChangeCommitted(this, new EventArgs());
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			string query = "UPDATE Empleado SET {0} WHERE Id_Empleado = {1}", valuestoUpdate = "";
			string[] field ={
								"Nombre", "ApellidoPaterno", "ApellidoMaterno", "Direccion", "Trabajo", "Periodo", "Sueldo", "RFC", "IMSS",
								"Deposito", "Prestaciones", "CURP",	"Sexo", "Id_Departamento", "FechaAlta", "FechaBaja"
							};

			List<SqlParameter> parameter = new List<SqlParameter>();
			SqlParameter idEmpleado = null;

			if(isValidField())
			{
				idEmpleado = new SqlParameter("@idEmpleado", selectedRow["Id_Empleado"]);
				
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

				foreach(SqlParameter p in parameter)
				{
					valuestoUpdate += string.Format("{0} = {1},", field[parameter.IndexOf(p)], p.ParameterName);
				}

				parameter.Add(idEmpleado);

				query = string.Format(query, valuestoUpdate.TrimEnd(','), idEmpleado.ParameterName);
				UpdateData(query, parameter.ToArray());
			}
		}

		private void UpdateData(string query, SqlParameter[] parameter)
		{
			DataObject dao = new DataObject();
			dao.Update(query, parameter);
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

		private void SetDataToInputs()
		{
			txtNombre.Text = selectedRow["Nombre"].ToString();
			txtPaterno.Text = selectedRow["ApellidoPaterno"].ToString();
			txtMaterno.Text = selectedRow["ApellidoMaterno"].ToString();
			txtDireccion.Text = selectedRow["Direccion"].ToString();
			txtTrabajo.Text = selectedRow["Trabajo"].ToString();
			txtPeriodo.Text = selectedRow["Periodo"].ToString();
			txtSueldo.Text = selectedRow["Sueldo"].ToString();
			txtRFC.Text = selectedRow["RFC"].ToString();
			txtIMSS.Text = selectedRow["IMSS"].ToString();
			txtDeposito.Text = selectedRow["Deposito"].ToString();
			txtPrestaciones.Text = selectedRow["Prestaciones"].ToString();
			txtCURP.Text = selectedRow["CURP"].ToString();
			cbxSexo.SelectedIndex = (selectedRow["Sexo"].ToString() == "M") ? 0 : 1;
			cbxDepartamento.SelectedValue = (int)selectedRow["Id_Departamento"];
			dtpAlta.Value = DateTime.Parse(selectedRow["FechaAlta"].ToString());
			dtpBaja.Value = DateTime.Parse(selectedRow["FechaBaja"].ToString());
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

		private void cbxEmployees_SelectionChangeCommitted(object sender, EventArgs e)
		{
			selectedRow = dataToEdit.Select("Id_Empleado = " + cbxEmployees.SelectedValue)[0];

			InitializeDefaultValues();
			SetDataToInputs();
		}
	}
}