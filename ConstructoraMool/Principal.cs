using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Mool
{
    public partial class Principal : Form
    {
		public Principal()
		{
			InitializeComponent();
		}

		private void Principal_Load(object sender, EventArgs e)
		{
			DisplayGridData();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			Insert insertScreen;

			insertScreen = new Insert();
			insertScreen.FormClosed += RefreshScreen;
			insertScreen.Show();
		}
		
		private void btnEditar_Click(object sender, EventArgs e)
		{
			Update updateScreen;
			DataTable dataToEdit;

			dataToEdit = dGVEmpleados.SelectedRows.Cast<DataGridViewRow>()
							.Select(row => ((DataRowView)row.DataBoundItem).Row)
							.CopyToDataTable();

			updateScreen = new Update(dataToEdit);
			updateScreen.FormClosed += RefreshScreen;
			updateScreen.Show();
		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			string selectedIds, query;
			const string deleteTemplate = "DELETE Empleado WHERE Id_Empleado IN ({0})";
			DataObject dao;
			List<SqlParameter> parameters;
			DialogResult answer;

			answer = MessageBox.Show("¿Esta seguro que quiere borrar?", "Borrar", MessageBoxButtons.YesNo);

			if(answer == DialogResult.Yes)
			{
				parameters = dGVEmpleados.Rows.Cast<DataGridViewRow>()
					.Where(row=>(bool)row.Cells["IsSelected"].Value)
					.Select(row => new SqlParameter("@idEmpleado" + row.Index, row.Cells["ID_Empleado"].Value))
					.ToList<SqlParameter>();
				
				selectedIds = String.Join(",", parameters.Select(p => p.ParameterName));
				query = string.Format(deleteTemplate, selectedIds.TrimEnd(','));

				dao = new DataObject();
				dao.Delete(query, parameters.ToArray());
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			
		}

		private void RefreshScreen(object sender, FormClosedEventArgs e)
		{
			DisplayGridData();
		}

		private void DisplayGridData()
		{
			string query, fields;
			const string selectTemplate = "SELECT {0} FROM Empleado";
			DataObject dao;

			fields = @"Id_Empleado, Id_Departamento, CAST(0 AS BIT) AS IsSelected, Nombre, ApellidoPaterno, ApellidoMaterno, Sexo, Direccion, Trabajo,
						ISNULL((SELECT Departamento.Descripcion FROM Departamento WHERE Empleado.Id_Departamento = Departamento.Id_Departamento), 0) AS Departamento,
						Periodo, Sueldo, Deposito, Prestaciones, RFC, IMSS, CURP, FechaAlta, FechaBaja";

			query = string.Format(selectTemplate, fields);
			dao = new DataObject();
			dao.Select(query, "Empleado");

			dGVEmpleados.DataSource = dao.data.Tables["Empleado"];
			SetDataGridViewSettings();
		}

		private void SetDataGridViewSettings()
		{
			foreach(DataGridViewColumn column in dGVEmpleados.Columns)
			{
				column.ReadOnly = true;

				switch(column.Name)
				{
					case "Id_Empleado":
					case "Id_Departamento":
						column.Visible = false;
						break;
					case "ApellidoPaterno":
						column.HeaderText = "Apellido Paterno";
						column.Width = 110;
						break;
					case "ApellidoMaterno":
						column.HeaderText = "Apellido Materno";
						column.Width = 110;
						break;
					case "FechaAlta":
						column.HeaderText = "Fecha Alta";
						break;
					case "FechaBaja":
						column.HeaderText = "Fecha Baja";
						break;
					case "IsSelected":
						column.HeaderText = "";
						column.ReadOnly = false;
						break;
				}
			}
		}

		private void btnReportes_Click(object sender, EventArgs e)
		{
			DataTable datatoReport;
			Reports report;

			datatoReport = dGVEmpleados.Rows.Cast<DataGridViewRow>()
				.Where(row => (bool)row.Cells["IsSelected"].Value)
				.Select(row => ((DataRowView)row.DataBoundItem).Row).CopyToDataTable();

			report = new Reports();
			report.SetParameter("Data", datatoReport);

			report.Show();
		}

		private void btnReportManager_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Proximamente");
		}
	}
}