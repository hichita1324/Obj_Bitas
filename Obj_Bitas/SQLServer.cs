using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bitas
{
	public class SQLServer
	{
		//GetDataTable
		public DataTable _GetDataTable(string query, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
            if (conn.State != ConnectionState.Open)
			    conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = query
			};
			SqlDataReader reader = command.ExecuteReader();
			DataTable table = new DataTable();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				Type type = typeof(string);
				if (reader.GetDataTypeName(i) == "nvarchar")
				{
					type = typeof(string);
				}
				if (reader.GetDataTypeName(i) == "float" || reader.GetDataTypeName(i) == "money")
				{
					type = typeof(double);
				}
				if (reader.GetDataTypeName(i) == "bit")
				{
					type = typeof(bool);
				}
				if (reader.GetDataTypeName(i) == "datetime" || reader.GetDataTypeName(i) == "date")
				{
					type = typeof(DateTime);
				}
				if (reader.GetDataTypeName(i) == "image")
				{
					type = typeof(byte[]);
				}
				table.Columns.Add(reader.GetName(i), type);
			}
			while (reader.Read())
			{
				object[] values = new object[reader.FieldCount];;
				reader.GetValues(values);;
				table.Rows.Add(values);;
			}
			command.Dispose();
			command = null;
			reader.Dispose();
			reader = null;
			conn.Close();
			return table;
		}
		//GetListObject
		public DataTable _GetDataTable_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			DataTable table = new DataTable();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				Type type = typeof(string);
				if (reader.GetDataTypeName(i) == "nvarchar")
				{
					type = typeof(string);
				}
				if (reader.GetDataTypeName(i) == "float" || reader.GetDataTypeName(i) == "money")
				{
					type = typeof(double);
				}
				if (reader.GetDataTypeName(i) == "bit")
				{
					type = typeof(bool);
				}
				if (reader.GetDataTypeName(i) == "datetime" || reader.GetDataTypeName(i) == "date")
				{
					type = typeof(DateTime);
				}
				if (reader.GetDataTypeName(i) == "image")
				{
					type = typeof(byte[]);
				}
				table.Columns.Add(reader.GetName(i), type);
			}
			while (reader.Read())
			{
				object[] values = new object[reader.FieldCount];;
				reader.GetValues(values);;
				table.Rows.Add(values);;
			}
			command.Dispose();
			command = null;
			reader.Dispose();
			reader = null;
			conn.Close();
			return table;
		}
		//GetListObject
		public DataTable _GetDataTableWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			command.Parameters.AddRange(ArrayParameter);
			SqlDataReader reader = command.ExecuteReader();
			DataTable table = new DataTable();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				Type type = typeof(string);
				if (reader.GetDataTypeName(i) == "nvarchar")
				{
					type = typeof(string);
				}
				if (reader.GetDataTypeName(i) == "float" || reader.GetDataTypeName(i) == "money")
				{
					type = typeof(double);
				}
				if (reader.GetDataTypeName(i) == "bit")
				{
					type = typeof(bool);
				}
				if (reader.GetDataTypeName(i) == "datetime" || reader.GetDataTypeName(i) == "date")
				{
					type = typeof(DateTime);
				}
				if (reader.GetDataTypeName(i) == "image")
				{
					type = typeof(byte[]);
				}
				table.Columns.Add(reader.GetName(i), type);
			}
			while (reader.Read())
			{
				object[] values = new object[reader.FieldCount];;
				reader.GetValues(values);;
				table.Rows.Add(values);;
			}
			command.Dispose();
			command = null;
			reader.Dispose();
			reader = null;
			conn.Close();
			return table;
		}
		//GetListObject
		public List<object[]> _GetListObject(string query, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<object[]> list = new List<object[]>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = query
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				object[] values = new object[reader.FieldCount];
				reader.GetValues(values);
				list.Add(values);
			}
			command.Dispose();
			command = null;
			reader.Dispose();
			reader = null;
			conn.Close();
			return list;
		}
		//GetObject
		public object[] _GetObject(string query, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = query
			};
			SqlDataReader reader = command.ExecuteReader();
			object[] values = new object[reader.FieldCount];
			if (reader.Read())
			{
				reader.GetValues(values);
			}
			command.Dispose();
			command = null;
			reader.Dispose();
			reader = null;
			conn.Close();
			return values;
		}
		//SelectDataReader
		public SqlDataReader _SelectDataReader(string query, SqlConnection conn)
		{
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = query
			};
			return command.ExecuteReader();
		}
		//SelectDataSet 
		public DataSet _SelectDataSet(string query, SqlConnection conn)
		{
			if (conn.ConnectionString =="")
			{
				return null;
			}
			SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
			DataSet dataSet = new DataSet();
			try
			{
				adapter.Fill(dataSet);
			}
			catch (SqlException exception)
			{
				MessageBox.Show("Không thể truy vấn dữ liệu.\r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			conn.Close();
			return dataSet;
		}
		//GetDate
		public DateTime _GetDate(SqlConnection conn)
		{
			DateTime minValue = DateTime.MinValue;
			if (conn.ConnectionString != "")
			{
				conn.Open();
				SqlCommand command = new SqlCommand
				{
					Connection = conn,
					CommandType = CommandType.Text,
					CommandText = "SELECT GETDATE()"
				};
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					if (reader[0].ToString() != "")
					{
						minValue = Convert.ToDateTime(reader[0]);
					}
				}
				command.Dispose();
				command = null;
				reader.Dispose();
				reader = null;
				conn.Close();
			}
			return minValue;
		}
		////GetNewId
		public string _GetNewId(SqlConnection conn)
		{
			string NewId = "";
			if (conn.ConnectionString != "")
			{
				conn.Open();
				SqlCommand command = new SqlCommand
				{
					Connection = conn,
					CommandType = CommandType.Text,
					CommandText = "SELECT NEWID()"
				};
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					if (reader[0].ToString() != "")
					{
						NewId = reader[0].ToString();
					}
				}
				command.Dispose();
				command = null;
				reader.Dispose();
				reader = null;
				conn.Close();
			}
			return NewId;
		}
		public string _GetValue_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			string Values = "";
			if (conn.ConnectionString != "")
			{
				int num = -1;
				foreach (var item in ArrayParameter)
					num++;
				conn.Open();
				SqlCommand command = new SqlCommand
				{
					Connection = conn,
					CommandType = CommandType.StoredProcedure,
					CommandText = StoredName
				};
				command.Parameters.AddRange(ArrayParameter);
				ArrayParameter[num].Direction = ParameterDirection.Output;
				command.ExecuteNonQuery();
				Values = ArrayParameter[num].Value.ToString();
				command.Dispose();
				command = null;
				conn.Close();
			}
			return Values;
		}
		public double _Min_max_sum_count_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			double Values = 0;
			if (conn.ConnectionString != "")
			{
				int num = -1;
				foreach (var item in ArrayParameter)
					num++;
				conn.Open();
				SqlCommand command = new SqlCommand
				{
					Connection = conn,
					CommandType = CommandType.StoredProcedure,
					CommandText = StoredName
				};
				command.Parameters.AddRange(ArrayParameter);
				ArrayParameter[num].Direction = ParameterDirection.Output;
				command.ExecuteNonQuery();
				Values = Convert.ToDouble(ArrayParameter[num].Value.ToString());
				command.Dispose();
				command = null;
				conn.Close();
			}
			return Values;
		}
	}
}

