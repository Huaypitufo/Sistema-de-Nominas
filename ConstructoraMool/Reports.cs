using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Mool
{
	public partial class Reports : Page
	{
		private int _PayrollNumber = 0;
		private DataObject _DataObject;
		private DataTable _Employees, _PayrollCollection;

		public Reports()
		{
			InitializeComponent();
		}

		private void Reports_Load(object sender, EventArgs e)
		{
			_DataObject = new DataObject();
			SetDataToReport();
		}

		private void SetDataToReport()
		{
			string[] visibleColumns = { "Nombre", "Trabajo", "Sueldo", "HorasExtra" };
			BindingSource bindingSource;

			_Employees = new DataTable();
			_Employees.Columns.Add("HorasExtra", typeof(int));
			_Employees.Columns["HorasExtra"].DefaultValue = 0;
			_Employees.Merge(GetParameter<DataTable>("Data"));
			_Employees.PrimaryKey = new DataColumn[] { _Employees.Columns["id_empleado"] };

			if(_Employees.Rows.Count > 0)
			{
				bindingSource = new BindingSource();
				bindingSource.DataSource = _Employees;

				dgvSelected.DataSource = bindingSource;
				dgvSelected.Columns.Cast<DataGridViewColumn>()
					.All(column => { column.Visible = visibleColumns.Contains(column.Name); return true; });
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Int32.TryParse(DateTime.Now.ToString("yyyyMMddss"), out _PayrollNumber);

			if(_PayrollNumber > 0)
			{
				InsertPayrolls();

				if(_PayrollCollection.Rows.Count > 0)
				{
					CreateExcelFile();
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			int horasCount;
			bool isClosed = false;
			DialogResult answer;

			horasCount = _Employees.Select("HorasExtra > 0").Length;

			if(horasCount > 0)
			{
				answer = MessageBox.Show("¿Hay datos por no salvar, esta seguro que quiere regresar?", "Regresar", MessageBoxButtons.YesNo);
				isClosed = (answer == DialogResult.Yes);
			}

			if(horasCount == 0 || isClosed)
			{
				this.Close();
			}
		}

		private void InsertPayrolls()
		{
			int idPayroll;
			string insertQuery;
			List<int> idPayrolls = null;

			if(_Employees.Rows.Count > 0)
			{
				idPayrolls = new List<int>();

				foreach(DataRow row in _Employees.Rows)
				{
					insertQuery = "INSERT INTO Nomina(id_Empleado, Codigo, Semana, HorasExtra, FechaInicio, FechaFinal, Importe, Neto, Unidades)";
					insertQuery += " VALUES(@idEmpleado, @codigo, @semana, @horasExtra, @fechaInicio, @fechaFinal, @importe, @neto, @unidades)";

					idPayroll = _DataObject.Insert(insertQuery, new SqlParameter[] { });
					idPayrolls.Add(idPayroll);
				}

				_PayrollCollection = GetPayrollDataInserted(idPayrolls);
			}
		}

		private DataTable GetPayrollDataInserted(List<int> _idPayrolls)
		{
			DataTable payrollData = null;
			const string query = "SELECT * FROM Nomina WHERE id_nomina IN({0})";

			if(_idPayrolls.Count > 0)
			{
				_DataObject.Select(String.Format(query, String.Join(",", _idPayrolls)), "Payroll");

				if(_DataObject.data.Tables.Contains("Payroll") && _DataObject.data.Tables["Payroll"].Rows.Count > 0)
				{
					payrollData = _DataObject.data.Tables["Payroll"].Copy();
				}
			}

			return payrollData;
		}

		private void SetQueryParameters(DataRow _row)
		{
			_DataObject.Parameters.Add(new SqlParameter("@idEmpleado", _row["id_empleado"]));
			_DataObject.Parameters.Add(new SqlParameter("@codigo", _PayrollNumber));
			_DataObject.Parameters.Add(new SqlParameter("@semana", nSemana.Value));
			_DataObject.Parameters.Add(new SqlParameter("@horasExtra", _row["HorasExtra"]));
			_DataObject.Parameters.Add(new SqlParameter("@fechaInicio", dtpPeriodoInicio.Value.ToString("yyyy-MM-dd")));
			_DataObject.Parameters.Add(new SqlParameter("@fechaFinal", dtpPeriodoFinal.Value.ToString("yyyy-MM-dd")));
			_DataObject.Parameters.Add(new SqlParameter("@importe", 1));
			_DataObject.Parameters.Add(new SqlParameter("@neto", 1));
			_DataObject.Parameters.Add(new SqlParameter("@unidades", 1));
		}

		private void CreateExcelFile()
		{
			FileInfo excelFile;
			string fileName;

			if(!String.IsNullOrEmpty(ConfigurationManager.AppSettings["System\\Reports\\Excel"]))
			{
				fileName = ConfigurationManager.AppSettings["System\\Reports\\Excel"] + "\\" + _PayrollNumber + ".xlsx";
				excelFile = new FileInfo(fileName);

				try
				{
					GenerateExcelReport(excelFile);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		private void GenerateExcelReport(FileInfo _excelFile)
		{
			ExcelPackage package;
			ExcelWorksheet worksheet;

			if(_PayrollCollection.Rows.Count > 0)
			{
				package = new ExcelPackage(_excelFile);
				worksheet = package.Workbook.Worksheets.Add("MOOL" + _PayrollNumber);

				worksheet.Column(2).Width = 25;
				worksheet.Column(3).Width = 25;
				worksheet.Column(4).Width = 25;

				GenerateExcelData(worksheet);

				package.Save();
			}
		}

		private ExcelWorksheet GetReportTemplate()
		{
			FileInfo template;
			ExcelPackage package;

			template = new FileInfo(ConfigurationManager.AppSettings["System\\Reports\\Excel"] + "\\ReportTemplate.xlsx");
			package = new ExcelPackage(template);

			return package.Workbook.Worksheets.First();
		}

		private void GenerateExcelData(ExcelWorksheet _worksheet)
		{
			ExcelWorksheet template;
			string cellValue, cellAddress;
			int excelRow = -17;

			template = GetReportTemplate();
			_PayrollCollection.Merge(_Employees, false, MissingSchemaAction.AddWithKey);

			foreach(DataRow row in _PayrollCollection.Rows)
			{
				template.Cells["B1:D14"].Copy(_worksheet.Cells["B" + (excelRow += 18)]);

				foreach(DataColumn column in _PayrollCollection.Columns)
				{
					var currentCell = _worksheet.Cells
						.Where(cell =>
							cell.Value != null
							&& cell.Value.ToString().Contains("{" + column.ColumnName.ToLower() + "}")
							);

					if (currentCell.Count() > 0)
					{
						cellAddress = currentCell.First().Address;
						cellValue = _worksheet.Cells[cellAddress].Value.ToString().Replace("{" + column.ColumnName.ToLower() + "}", row[column.ColumnName].ToString());

						_worksheet.Cells[cellAddress].Value = cellValue;
					}
				}
			}
		}

		private string GetValueFromTemplate(string _key, object _value, ExcelWorksheet _template)
		{
			return "";
		}
	}
}