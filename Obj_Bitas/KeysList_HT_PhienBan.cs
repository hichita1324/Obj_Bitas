using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//CreateTimes : 04/04/2016 10:44:57.AM

namespace Bitas
{
	public class KeysList_HT_PhienBan
	{
		//ListAll
		public List<Ob_HT_PhienBan> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_PhienBan> list = new List<Ob_HT_PhienBan>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_Phienban, Ten, Ngayphathanh, Duongdan, Kichhoat, Ghichu From HT_PhienBan"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_HT_PhienBan ob = new Ob_HT_PhienBan();
				if(reader[0] != DBNull.Value){ ob.ID_PHIENBAN = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TEN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.NGAYPHATHANH = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DUONGDAN = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.KICHHOAT = Convert.ToBoolean(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[5]);}
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
		public List<Ob_HT_PhienBan> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_PhienBan> list = new List<Ob_HT_PhienBan>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_HT_PhienBan ob = new Ob_HT_PhienBan();
				if(reader[0] != DBNull.Value){ ob.ID_PHIENBAN = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TEN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.NGAYPHATHANH = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DUONGDAN = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.KICHHOAT = Convert.ToBoolean(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[5]);}
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
		public List<Ob_HT_PhienBan> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_PhienBan> list = new List<Ob_HT_PhienBan>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_Phienban, Ten, Ngayphathanh, Duongdan, Kichhoat, Ghichu From HT_PhienBan Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_HT_PhienBan ob = new Ob_HT_PhienBan();
				if(reader[0] != DBNull.Value){ ob.ID_PHIENBAN = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TEN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.NGAYPHATHANH = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DUONGDAN = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.KICHHOAT = Convert.ToBoolean(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[5]);}
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
		public List<Ob_HT_PhienBan> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_PhienBan> list = new List<Ob_HT_PhienBan>();
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
				Ob_HT_PhienBan ob = new Ob_HT_PhienBan();
				if(reader[0] != DBNull.Value){ ob.ID_PHIENBAN = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TEN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.NGAYPHATHANH = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DUONGDAN = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.KICHHOAT = Convert.ToBoolean(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[5]);}
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
		public Ob_HT_PhienBan _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_HT_PhienBan ob = new Ob_HT_PhienBan();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_Phienban, Ten, Ngayphathanh, Duongdan, Kichhoat, Ghichu From HT_PhienBan Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_PHIENBAN = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TEN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.NGAYPHATHANH = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DUONGDAN = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.KICHHOAT = Convert.ToBoolean(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[5]);}
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
		public bool _InsertOb(Ob_HT_PhienBan ob, SqlConnection conn)
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
				CommandText = @"Insert Into HT_PhienBan (ID_Phienban, Ten, Ngayphathanh, Duongdan, Kichhoat, Ghichu) Values(@ID_Phienban, @Ten, @Ngayphathanh, @Duongdan, @Kichhoat, @Ghichu)"
			};
			if (ob.ID_PHIENBAN.Trim() == "")
				command.Parameters.Add("ID_Phienban", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ID_Phienban", SqlDbType.NVarChar).Value = ob.ID_PHIENBAN;
			if (ob.TEN.Trim() == "")
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value = ob.TEN;
			if (ob.NGAYPHATHANH == DateTime.MinValue)
				command.Parameters.Add("Ngayphathanh", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("Ngayphathanh", SqlDbType.DateTime).Value = ob.NGAYPHATHANH;
			if (ob.DUONGDAN.Trim() == "")
				command.Parameters.Add("Duongdan", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Duongdan", SqlDbType.NVarChar).Value = ob.DUONGDAN;
			command.Parameters.Add("Kichhoat", SqlDbType.Bit).Value = ob.KICHHOAT;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("Ghichu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ghichu", SqlDbType.NVarChar).Value = ob.GHICHU;
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
		public int _InsertObGetId(Ob_HT_PhienBan ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into HT_PhienBan (ID_Phienban, Ten, Ngayphathanh, Duongdan, Kichhoat, Ghichu) Values(@ID_Phienban, @Ten, @Ngayphathanh, @Duongdan, @Kichhoat, @Ghichu)Select @@IDENTITY"
			};
			if (ob.ID_PHIENBAN.Trim() == "")
				command.Parameters.Add("ID_Phienban", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ID_Phienban", SqlDbType.NVarChar).Value = ob.ID_PHIENBAN;
			if (ob.TEN.Trim() == "")
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value = ob.TEN;
			if (ob.NGAYPHATHANH == DateTime.MinValue)
				command.Parameters.Add("Ngayphathanh", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("Ngayphathanh", SqlDbType.DateTime).Value = ob.NGAYPHATHANH;
			if (ob.DUONGDAN.Trim() == "")
				command.Parameters.Add("Duongdan", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Duongdan", SqlDbType.NVarChar).Value = ob.DUONGDAN;
			command.Parameters.Add("Kichhoat", SqlDbType.Bit).Value = ob.KICHHOAT;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("Ghichu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ghichu", SqlDbType.NVarChar).Value = ob.GHICHU;
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
		public bool _UpdateOb(Ob_HT_PhienBan ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update HT_PhienBan Set Ten=@Ten, Ngayphathanh=@Ngayphathanh, Duongdan=@Duongdan, Kichhoat=@Kichhoat, Ghichu=@Ghichu Where ID_Phienban=@ID_Phienban"
			};
			if (ob.ID_PHIENBAN.Trim() == "")
				command.Parameters.Add("ID_Phienban", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ID_Phienban", SqlDbType.NVarChar).Value = ob.ID_PHIENBAN;
			if (ob.TEN.Trim() == "")
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value = ob.TEN;
			if (ob.NGAYPHATHANH == DateTime.MinValue)
				command.Parameters.Add("Ngayphathanh", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("Ngayphathanh", SqlDbType.DateTime).Value = ob.NGAYPHATHANH;
			if (ob.DUONGDAN.Trim() == "")
				command.Parameters.Add("Duongdan", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Duongdan", SqlDbType.NVarChar).Value = ob.DUONGDAN;
			command.Parameters.Add("Kichhoat", SqlDbType.Bit).Value = ob.KICHHOAT;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("Ghichu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ghichu", SqlDbType.NVarChar).Value = ob.GHICHU;
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
		public bool _DeleteOb(Ob_HT_PhienBan ob, SqlConnection conn)
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
				CommandText = @"Delete From HT_PhienBan Where ID_Phienban=@ID_Phienban"
			};
				command.Parameters.Add(new SqlParameter("ID_Phienban", ob.ID_PHIENBAN));
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
				CommandText = "Delete From HT_PhienBan Where " + condition
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
				CommandText = "Select * From HT_PhienBan Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From HT_PhienBan"
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
				CommandText = "Select Count(" + nameColumn + ") From HT_PhienBan Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From HT_PhienBan"
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
					CommandText = "Select Min(" + nameColumn + ") From HT_PhienBan Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from HT_PhienBan"
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
					CommandText = "Select Max(" + nameColumn + ") From HT_PhienBan Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From HT_PhienBan"
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
					CommandText = "Select Sum(" + nameColumn + ") From HT_PhienBan Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From HT_PhienBan"
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

