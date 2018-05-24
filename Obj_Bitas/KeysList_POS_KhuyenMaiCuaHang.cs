using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

//CreateTimes : 13/03/2017 13:59:53.PM

namespace Bitas
{
	public class KeysList_POS_KhuyenMaiCuaHang
	{
		private Guid ConvertGuid(string b)
		{
			Guid gu = Guid.Empty;
			string str = b;
			gu = new Guid(str);
			return gu;
		}
		//ListAll
		public List<Ob_POS_KhuyenMaiCuaHang> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMaiCuaHang> list = new List<Ob_POS_KhuyenMaiCuaHang>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhuyenMaiCuaHang, ID_KhuyenMai, ID_CuaHang From POS_KhuyenMaiCuaHang"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_KhuyenMaiCuaHang ob = new Ob_POS_KhuyenMaiCuaHang();
				if(reader[0] != DBNull.Value){ ob.ID_KHUYENMAICUAHANG = Convert.ToInt64(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[2]);}
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
		public List<Ob_POS_KhuyenMaiCuaHang> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMaiCuaHang> list = new List<Ob_POS_KhuyenMaiCuaHang>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_KhuyenMaiCuaHang ob = new Ob_POS_KhuyenMaiCuaHang();
				if(reader[0] != DBNull.Value){ ob.ID_KHUYENMAICUAHANG = Convert.ToInt64(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[2]);}
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
		public List<Ob_POS_KhuyenMaiCuaHang> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMaiCuaHang> list = new List<Ob_POS_KhuyenMaiCuaHang>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhuyenMaiCuaHang, ID_KhuyenMai, ID_CuaHang From POS_KhuyenMaiCuaHang Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_KhuyenMaiCuaHang ob = new Ob_POS_KhuyenMaiCuaHang();
				if(reader[0] != DBNull.Value){ ob.ID_KHUYENMAICUAHANG = Convert.ToInt64(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[2]);}
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
		public List<Ob_POS_KhuyenMaiCuaHang> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMaiCuaHang> list = new List<Ob_POS_KhuyenMaiCuaHang>();
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
				Ob_POS_KhuyenMaiCuaHang ob = new Ob_POS_KhuyenMaiCuaHang();
				if(reader[0] != DBNull.Value){ ob.ID_KHUYENMAICUAHANG = Convert.ToInt64(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[2]);}
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
		public Ob_POS_KhuyenMaiCuaHang _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_POS_KhuyenMaiCuaHang ob = new Ob_POS_KhuyenMaiCuaHang();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhuyenMaiCuaHang, ID_KhuyenMai, ID_CuaHang From POS_KhuyenMaiCuaHang Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_KHUYENMAICUAHANG = Convert.ToInt64(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[2]);}
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
		public bool _InsertOb(Ob_POS_KhuyenMaiCuaHang ob, SqlConnection conn)
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
				CommandText = @"Insert Into POS_KhuyenMaiCuaHang (ID_KhuyenMai, ID_CuaHang) Values(@ID_KhuyenMai, @ID_CuaHang)"
			};
			command.Parameters.Add("ID_KhuyenMai", SqlDbType.Int).Value = ob.ID_KHUYENMAI;
			command.Parameters.Add("ID_CuaHang", SqlDbType.Int).Value = ob.ID_CUAHANG;
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
		public int _InsertObGetId(Ob_POS_KhuyenMaiCuaHang ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into POS_KhuyenMaiCuaHang (ID_KhuyenMai, ID_CuaHang) Values(@ID_KhuyenMai, @ID_CuaHang)Select @@IDENTITY"
			};
			command.Parameters.Add("ID_KhuyenMai", SqlDbType.Int).Value = ob.ID_KHUYENMAI;
			command.Parameters.Add("ID_CuaHang", SqlDbType.Int).Value = ob.ID_CUAHANG;
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
		public bool _UpdateOb(Ob_POS_KhuyenMaiCuaHang ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update POS_KhuyenMaiCuaHang Set ID_KhuyenMai=@ID_KhuyenMai, ID_CuaHang=@ID_CuaHang Where ID_KhuyenMaiCuaHang=@ID_KhuyenMaiCuaHang"
			};
			command.Parameters.Add("ID_KhuyenMaiCuaHang", SqlDbType.BigInt).Value = ob.ID_KHUYENMAICUAHANG;
			command.Parameters.Add("ID_KhuyenMai", SqlDbType.Int).Value = ob.ID_KHUYENMAI;
			command.Parameters.Add("ID_CuaHang", SqlDbType.Int).Value = ob.ID_CUAHANG;
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
		public bool _DeleteOb(Ob_POS_KhuyenMaiCuaHang ob, SqlConnection conn)
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
				CommandText = @"Delete From POS_KhuyenMaiCuaHang Where ID_KhuyenMaiCuaHang=@ID_KhuyenMaiCuaHang"
			};
				command.Parameters.Add(new SqlParameter("ID_KhuyenMaiCuaHang", ob.ID_KHUYENMAICUAHANG));
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
				CommandText = "Delete From POS_KhuyenMaiCuaHang Where " + condition
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
				CommandText = "Select * From POS_KhuyenMaiCuaHang Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From POS_KhuyenMaiCuaHang"
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
				CommandText = "Select Count(" + nameColumn + ") From POS_KhuyenMaiCuaHang Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From POS_KhuyenMaiCuaHang"
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
					CommandText = "Select Min(" + nameColumn + ") From POS_KhuyenMaiCuaHang Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from POS_KhuyenMaiCuaHang"
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
					CommandText = "Select Max(" + nameColumn + ") From POS_KhuyenMaiCuaHang Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_KhuyenMaiCuaHang"
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_KhuyenMaiCuaHang Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From POS_KhuyenMaiCuaHang"
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

