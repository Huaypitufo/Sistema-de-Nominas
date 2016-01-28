using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace Mool
{
	class DataObject
	{
		private SqlConnection _Connection = null;
		private SqlCommand _SQLCommand = null;
		private SqlDataAdapter _Adapter = null;
		private List<SqlParameter> _Parameters;

		public List<SqlParameter> Parameters
		{
			get { return _Parameters; }
			set { _Parameters = value; }
		}

		public DataSet data = null;

		public DataObject()
		{
			_Connection = new SqlConnection();
			_Connection.ConnectionString = ConfigurationManager.AppSettings["System\\DB"];
			_Adapter = new SqlDataAdapter();
			_Parameters = new List<SqlParameter>();
			_Connection.Open();
		}

		public int Select(string query, string tableName)
		{
			return Select(query, tableName, null);
		}

		public int Select(string query, string tableName, params SqlParameter[] parameters)
		{
			int numberOfRecords = 0;

			data = new DataSet();
			_SQLCommand = new SqlCommand();

			if(!string.IsNullOrEmpty(query) && !string.IsNullOrEmpty(tableName))
			{
				_SQLCommand.Connection = _Connection;
				_SQLCommand.CommandText = query;

				if(parameters != null && parameters.Length > 0)
				{
					_SQLCommand.Parameters.AddRange(parameters);
				}
				
				_Adapter.SelectCommand = _SQLCommand;
				_Adapter.Fill(data, tableName);
				numberOfRecords = data.Tables[tableName].Rows.Count;
			}

			return numberOfRecords;
		}

		public int Insert(string query, params SqlParameter[] parameters)
		{
			int lastInsertedId = 0;
			const string completeQuery = "{0}; SELECT CAST(SCOPE_IDENTITY() AS INT)";

			_SQLCommand = new SqlCommand();

			if(!string.IsNullOrEmpty(query))
			{
				_SQLCommand.Connection = _Connection;
				_SQLCommand.CommandText = string.Format(completeQuery, query);

				if(_Parameters != null && _Parameters.Count > 0)
				{
					_SQLCommand.Parameters.AddRange(_Parameters.ToArray());
				}

				lastInsertedId = (int)_SQLCommand.ExecuteScalar();
			}

			return lastInsertedId;
		}

		public void Update(string query, params SqlParameter[] parameters)
		{
			_SQLCommand = new SqlCommand();
			if(!string.IsNullOrEmpty(query))
			{
				_SQLCommand.Connection = _Connection;
				_SQLCommand.CommandText = query;

				if(parameters.Length > 0)
				{
					_SQLCommand.Parameters.AddRange(parameters);
				}
				_SQLCommand.ExecuteNonQuery();
			}
		}

		public void Delete(string query, params SqlParameter[] parameters)
		{
			_SQLCommand = new SqlCommand();
			if(!string.IsNullOrEmpty(query))
			{
				_SQLCommand.Connection = _Connection;
				_SQLCommand.CommandText = query;

				if(parameters.Length > 0)
				{
					_SQLCommand.Parameters.AddRange(parameters);
				}
				_SQLCommand.ExecuteNonQuery();
			}
		}

		public void Close()
		{
			_Connection.Close();
		}

		/*La habilidad de soportar parametros (Crear atributo privado llamado Parameters y un nuevo metodo llamado Add())*/
		/*La habilidad de soportar transacciones (Crear tres metodos BeginTransaction(), Commit() y Rollback())*/
		/*Crear un manejador de errores*/
	}
}
