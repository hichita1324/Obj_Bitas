using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//CreateTimes : 06/04/2016 08:31:16.AM

namespace Bitas
{
	public class KeysList_DA_ChietKhau_Footer
	{
		//ListAll
		public List<Ob_DA_ChietKhau_Footer> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DA_ChietKhau_Footer> list = new List<Ob_DA_ChietKhau_Footer>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID, PlanCode, InvNO, ID_ChietKhau, ValueTotal, Note, cDate, uDate From DA_ChietKhau_Footer"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DA_ChietKhau_Footer ob = new Ob_DA_ChietKhau_Footer();
				if(reader[0] != DBNull.Value){ ob.ID = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.PLANCODE = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.INVNO = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CHIETKHAU = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.VALUETOTAL = Convert.ToDecimal(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.NOTE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.CDATE = Convert.ToDateTime(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.UDATE = Convert.ToDateTime(reader[7]);}
				list.Add(ob);
			}
			command.Dispose();
			command = null;
			reader.Dispose();
			reader = null;
			conn.Close();
			return list;
		}
		//ListAll
		public List<Ob_DA_ChietKhau_Footer> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DA_ChietKhau_Footer> list = new List<Ob_DA_ChietKhau_Footer>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DA_ChietKhau_Footer ob = new Ob_DA_ChietKhau_Footer();
				if(reader[0] != DBNull.Value){ ob.ID = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.PLANCODE = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.INVNO = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CHIETKHAU = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.VALUETOTAL = Convert.ToDecimal(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.NOTE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.CDATE = Convert.ToDateTime(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.UDATE = Convert.ToDateTime(reader[7]);}
				list.Add(ob);
			}
			command.Dispose();
			command = null;
			reader.Dispose();
			reader = null;
			conn.Close();
			return list;
		}
		//ListWhere
		public List<Ob_DA_ChietKhau_Footer> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DA_ChietKhau_Footer> list = new List<Ob_DA_ChietKhau_Footer>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID, PlanCode, InvNO, ID_ChietKhau, ValueTotal, Note, cDate, uDate From DA_ChietKhau_Footer Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DA_ChietKhau_Footer ob = new Ob_DA_ChietKhau_Footer();
				if(reader[0] != DBNull.Value){ ob.ID = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.PLANCODE = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.INVNO = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CHIETKHAU = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.VALUETOTAL = Convert.ToDecimal(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.NOTE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.CDATE = Convert.ToDateTime(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.UDATE = Convert.ToDateTime(reader[7]);}
				list.Add(ob);
			}
			command.Dispose();
			command = null;
			reader.Dispose();
			reader = null;
			conn.Close();
			return list;
		}
		//ListWhere_sp
		public List<Ob_DA_ChietKhau_Footer> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DA_ChietKhau_Footer> list = new List<Ob_DA_ChietKhau_Footer>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			command.Parameters.AddRange(ArrayParameter);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DA_ChietKhau_Footer ob = new Ob_DA_ChietKhau_Footer();
				if(reader[0] != DBNull.Value){ ob.ID = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.PLANCODE = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.INVNO = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CHIETKHAU = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.VALUETOTAL = Convert.ToDecimal(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.NOTE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.CDATE = Convert.ToDateTime(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.UDATE = Convert.ToDateTime(reader[7]);}
				list.Add(ob);
			}
			command.Dispose();
			command = null;
			reader.Dispose();
			reader = null;
			conn.Close();
			return list;
		}
		//GetObWhere
		public Ob_DA_ChietKhau_Footer _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_DA_ChietKhau_Footer ob = new Ob_DA_ChietKhau_Footer();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID, PlanCode, InvNO, ID_ChietKhau, ValueTotal, Note, cDate, uDate From DA_ChietKhau_Footer Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.PLANCODE = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.INVNO = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CHIETKHAU = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.VALUETOTAL = Convert.ToDecimal(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.NOTE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.CDATE = Convert.ToDateTime(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.UDATE = Convert.ToDateTime(reader[7]);}
			}
			if (num == 0)
			{
				command.Dispose();
				command = null;
				reader.Dispose();
				reader = null;
				conn.Close();
				return null;
			}
			command.Dispose();
			command = null;
			reader.Dispose();
			reader = null;
			conn.Close();
			return ob;
		}
		//Insert ob
		public bool _InsertOb(Ob_DA_ChietKhau_Footer ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into DA_ChietKhau_Footer (PlanCode, InvNO, ID_ChietKhau, ValueTotal, Note, cDate, uDate) Values(@PlanCode, @InvNO, @ID_ChietKhau, @ValueTotal, @Note, @cDate, @uDate)"
			};
			if (ob.PLANCODE.Trim() == "")
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value = ob.PLANCODE;
			if (ob.INVNO.Trim() == "")
				command.Parameters.Add("InvNO", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("InvNO", SqlDbType.NVarChar).Value = ob.INVNO;
			command.Parameters.Add("ID_ChietKhau", SqlDbType.Int).Value = ob.ID_CHIETKHAU;
			command.Parameters.Add("ValueTotal", SqlDbType.Decimal).Value = ob.VALUETOTAL;
			if (ob.NOTE.Trim() == "")
				command.Parameters.Add("Note", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Note", SqlDbType.NVarChar).Value = ob.NOTE;
			if (ob.CDATE == DateTime.MinValue)
				command.Parameters.Add("cDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("cDate", SqlDbType.DateTime).Value = ob.CDATE;
			if (ob.UDATE == DateTime.MinValue)
				command.Parameters.Add("uDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("uDate", SqlDbType.DateTime).Value = ob.UDATE;
			try
			{
				command.ExecuteNonQuery();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Không thể thêm dữ liệu. \r\n" + exception.Message, "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				command.Dispose();
				command = null;
				conn.Close();
				return false;
			}
			command.Dispose();
			command = null;
			conn.Close();
			return true;
		}
		//InsertobGetId
		public int _InsertObGetId(Ob_DA_ChietKhau_Footer ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into DA_ChietKhau_Footer (PlanCode, InvNO, ID_ChietKhau, ValueTotal, Note, cDate, uDate) Values(@PlanCode, @InvNO, @ID_ChietKhau, @ValueTotal, @Note, @cDate, @uDate)Select @@IDENTITY"
			};
			if (ob.PLANCODE.Trim() == "")
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value = ob.PLANCODE;
			if (ob.INVNO.Trim() == "")
				command.Parameters.Add("InvNO", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("InvNO", SqlDbType.NVarChar).Value = ob.INVNO;
			command.Parameters.Add("ID_ChietKhau", SqlDbType.Int).Value = ob.ID_CHIETKHAU;
			command.Parameters.Add("ValueTotal", SqlDbType.Decimal).Value = ob.VALUETOTAL;
			if (ob.NOTE.Trim() == "")
				command.Parameters.Add("Note", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Note", SqlDbType.NVarChar).Value = ob.NOTE;
			if (ob.CDATE == DateTime.MinValue)
				command.Parameters.Add("cDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("cDate", SqlDbType.DateTime).Value = ob.CDATE;
			if (ob.UDATE == DateTime.MinValue)
				command.Parameters.Add("uDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("uDate", SqlDbType.DateTime).Value = ob.UDATE;
			try
			{
				 num = Convert.ToInt32(command.ExecuteScalar());
			}
			catch (Exception exception)
			{
				MessageBox.Show("Không thể thêm dữ liệu. \r\n" + exception.Message, "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				command.Dispose();
				command = null;
				conn.Close();
				return num;
			}
			command.Dispose();
			command = null;
			conn.Close();
			}
			return num;
		}
		//UpdateOb ob
		public bool _UpdateOb(Ob_DA_ChietKhau_Footer ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update DA_ChietKhau_Footer Set PlanCode=@PlanCode, InvNO=@InvNO, ID_ChietKhau=@ID_ChietKhau, ValueTotal=@ValueTotal, Note=@Note, cDate=@cDate, uDate=@uDate Where ID=@ID"
			};
			command.Parameters.Add("ID", SqlDbType.BigInt).Value = ob.ID;
			if (ob.PLANCODE.Trim() == "")
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value = ob.PLANCODE;
			if (ob.INVNO.Trim() == "")
				command.Parameters.Add("InvNO", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("InvNO", SqlDbType.NVarChar).Value = ob.INVNO;
			command.Parameters.Add("ID_ChietKhau", SqlDbType.Int).Value = ob.ID_CHIETKHAU;
			command.Parameters.Add("ValueTotal", SqlDbType.Decimal).Value = ob.VALUETOTAL;
			if (ob.NOTE.Trim() == "")
				command.Parameters.Add("Note", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Note", SqlDbType.NVarChar).Value = ob.NOTE;
			if (ob.CDATE == DateTime.MinValue)
				command.Parameters.Add("cDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("cDate", SqlDbType.DateTime).Value = ob.CDATE;
			if (ob.UDATE == DateTime.MinValue)
				command.Parameters.Add("uDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("uDate", SqlDbType.DateTime).Value = ob.UDATE;
			try
			{
				command.ExecuteNonQuery();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Không thể cập nhật dữ liệu. \r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				command.Dispose();
				command = null;
				conn.Close();
				return false;
			}
			if (command.ExecuteNonQuery() == 0)
			{
				MessageBox.Show("Không thể cập nhật dữ liệu. \r\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				command.Dispose();
				command = null;
				conn.Close();
				return false;
			}
			command.Dispose();
			command = null;
			conn.Close();
			return true;
		}
		//DeleteOB
		public bool _DeleteOb(Ob_DA_ChietKhau_Footer ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Delete From DA_ChietKhau_Footer Where ID=@ID"
			};
				command.Parameters.Add(new SqlParameter("ID", ob.ID));
			try
			{
				command.ExecuteNonQuery();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Không thể xóa dữ liệu. \r\n" + exception.Message, "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				command.Dispose();
				command = null;
				conn.Close();
				return false;
			}
			command.Dispose();
			command = null;
			conn.Close();
			return true;
		}
		//DeleteWhere
		public bool _DeleteWhere(string condition, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = "Delete From DA_ChietKhau_Footer Where " + condition
			};
			try
			{
				command.ExecuteNonQuery();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Không thể xóa dữ liệu. \r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				command.Dispose();
				command = null;
				conn.Close();
				return false;
			}
			command.Dispose();
			command = null;
			conn.Close();
			return true;
		}
		//Checkwhere
		public bool _CheckWhere(string condition, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = "Select * From DA_ChietKhau_Footer Where " + condition
			};
			try
			{
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read() == true)
				{
					command.Dispose();
					command = null;
					reader.Dispose();
					reader = null;
					conn.Close();
					return true;
				}
				else
				{
					command.Dispose();
					command = null;
					reader.Dispose();
					reader = null;
					conn.Close();
					return false;
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Không thể kiểm tra. \r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				command.Dispose();
				command = null;
				conn.Close();
				return false;
			}
		}
		//Count
		public double _Count(string nameColumn, SqlConnection conn)
		{
			double num = 0;
			if (conn.ConnectionString == "")
			{
				MessageBox.Show("Không thể kết nối cở sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return num;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = "Select Count(" + nameColumn + ") From DA_ChietKhau_Footer"
			};
			try
			{
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					num = Convert.ToDouble(reader[0]);
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Không thể Count. \r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				command.Dispose();
				command = null;
				conn.Close();
				return num;
			}
			command.Dispose();
			command = null;
			conn.Close();
			return num;
		}
		//CountWhere
		public double _CountWhere(string nameColumn, string keyword, SqlConnection conn)
		{
			double num = 0;
			if (conn.ConnectionString == "")
			{
				MessageBox.Show("Không thể kết nối cở sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return num;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = "Select Count(" + nameColumn + ") From DA_ChietKhau_Footer Where " + keyword +""
			};
			try
			{
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					num = Convert.ToDouble(reader[0]);
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Không thể Count. \r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				command.Dispose();
				command = null;
				conn.Close();
				return num;
			}
			command.Dispose();
			command = null;
			conn.Close();
			return num;
		}
		//Min
		public double _Min(string nameColumn, SqlConnection conn)
		{
			double num = 0;
			if (this._Count(nameColumn,conn) != 0)
			{
				if (conn.ConnectionString == "")
				{
					MessageBox.Show("Không thể kết nối cở sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return num;
				}
				conn.Open();
				SqlCommand command = new SqlCommand
				{
					Connection = conn,
					CommandType = CommandType.Text,
					CommandText = "Select Min(" + nameColumn + ") From DA_ChietKhau_Footer"
				};
				try
				{
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						num = Convert.ToDouble(reader[0]);
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show("Không thể lấy giá trị nhỏ nhất. \r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					command.Dispose();
					command = null;
					conn.Close();
					return num;
				}
				command.Dispose();
				command = null;
				conn.Close();
			}
			return num;
		}
		//MinWhere
		public double _MinWhere(string nameColumn, string keyword, SqlConnection conn)
		{
			double num = 0;
			if (this._Count(nameColumn,conn) != 0)
			{
				if (conn.ConnectionString == "")
				{
					MessageBox.Show("Không thể kết nối cở sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return num;
				}
				conn.Open();
				SqlCommand command = new SqlCommand
				{
					Connection = conn,
					CommandType = CommandType.Text,
					CommandText = "Select Min(" + nameColumn + ") From DA_ChietKhau_Footer Where " + keyword +""
				};
				try
				{
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						num = Convert.ToDouble(reader[0]);
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show("Không thể lấy giá trị nhỏ nhất. \r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					command.Dispose();
					command = null;
					conn.Close();
					return num;
				}
				command.Dispose();
				command = null;
				conn.Close();
			}
			return num;
		}
		//Max
		public double _Max(string nameColumn, SqlConnection conn)
		{
			double num = 0;
			if (this._Count(nameColumn,conn) != 0)
			{
				if (conn.ConnectionString == "")
				{
					MessageBox.Show("Không thể kết nối cở sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return num;
				}
				conn.Open();
				SqlCommand command = new SqlCommand
				{
					Connection = conn,
					CommandType = CommandType.Text,
					CommandText = "Select max(" + nameColumn + ") from DA_ChietKhau_Footer"
				};
				try
				{
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						num = Convert.ToDouble(reader[0]);
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show("Không thể lấy giá trị lớn nhất. \r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					command.Dispose();
					command = null;
					conn.Close();
					return num;
				}
				command.Dispose();
				command = null;
				conn.Close();
			}
			return num;
		}
		//MaxWhere
		public double _MaxWhere(string nameColumn, string keyword, SqlConnection conn)
		{
			double num = 0;
			if (this._Count(nameColumn,conn) != 0)
			{
				if (conn.ConnectionString == "")
				{
					MessageBox.Show("Không thể kết nối cở sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return num;
				}
				conn.Open();
				SqlCommand command = new SqlCommand
				{
					Connection = conn,
					CommandType = CommandType.Text,
					CommandText = "Select Max(" + nameColumn + ") From DA_ChietKhau_Footer Where " + keyword +""
				};
				try
				{
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						num = Convert.ToDouble(reader[0]);
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show("Không thể lấy giá trị lớn nhất. \r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					command.Dispose();
					command = null;
					conn.Close();
					return num;
				}
				command.Dispose();
				command = null;
				conn.Close();
			}
			return num;
		}
		//Sum
		public double _Sum(string nameColumn, SqlConnection conn)
		{
			double num = 0;
			if (this._Count(nameColumn,conn) != 0)
			{
				if (conn.ConnectionString == "")
				{
					MessageBox.Show("Không thể kết nối cở sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return num;
				}
				conn.Open();
				SqlCommand command = new SqlCommand
				{
					Connection = conn,
					CommandType = CommandType.Text,
					CommandText = "Select Sum(" + nameColumn + ") From DA_ChietKhau_Footer"
				};
				try
				{
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						num = Convert.ToDouble(reader[0]);
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show("Không thể lấy tính tổng. \r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					command.Dispose();
					command = null;
					conn.Close();
					return num;
				}
				command.Dispose();
				command = null;
				conn.Close();
			}
			return num;
		}
		//SumWhere
		public double _SumWhere(string nameColumn, string keyword, SqlConnection conn)
		{
			double num = 0;
			if (this._Count(nameColumn,conn) != 0)
			{
				if (conn.ConnectionString == "")
				{
					MessageBox.Show("Không thể kết nối cở sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return num;
				}
				conn.Open();
				SqlCommand command = new SqlCommand
				{
					Connection = conn,
					CommandType = CommandType.Text,
					CommandText = "Select Sum(" + nameColumn + ") From DA_ChietKhau_Footer Where " + keyword +""
				};
				try
				{
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						num = Convert.ToDouble(reader[0]);
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show("Không thể lấy tính tổng. \r\n" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					command.Dispose();
					command = null;
					conn.Close();
					return num;
				}
				command.Dispose();
				command = null;
				conn.Close();
			}
			return num;
		}
		//CreateID
		public string _CreateID(string ColumnName, string Character, SqlConnection conn)
		{
			string Id = "";
			double count;
			if (conn.ConnectionString != "")
			{
				conn.Open();
				SqlCommand command = new SqlCommand
				{
					Connection = conn,
					CommandType = CommandType.Text,
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From DA_ChietKhau_Footer"
				};
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					if (reader[0].ToString() != "")
					{
						count = Convert.ToDouble(reader[0].ToString()) + 1;
						Id = Character + "-" + count.ToString("0000000000");
					}
				}
				command.Dispose();
				command = null;
				reader.Dispose();
				reader = null;
				conn.Close();
			}
			return Id;
		}
	}
}

