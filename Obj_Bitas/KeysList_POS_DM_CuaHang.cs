using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

//CreateTimes : 18/05/2018 15:16:27.PM

namespace Bitas
{
	public class KeysList_POS_DM_CuaHang
	{
		private Guid ConvertGuid(string b)
		{
			Guid gu = Guid.Empty;
			string str = b;
			gu = new Guid(str);
			return gu;
		}
		//ListAll
		public List<Ob_POS_DM_CuaHang> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_DM_CuaHang> list = new List<Ob_POS_DM_CuaHang>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_CuaHang, MaCuaHang, TenCuaHang, POS, ID_Kho, DiaChi, DienThoai From POS_DM_CuaHang"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_DM_CuaHang ob = new Ob_POS_DM_CuaHang();
				if(reader[0] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MACUAHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENCUAHANG = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.POS = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[6]);}
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
		public List<Ob_POS_DM_CuaHang> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_DM_CuaHang> list = new List<Ob_POS_DM_CuaHang>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_DM_CuaHang ob = new Ob_POS_DM_CuaHang();
				if(reader[0] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MACUAHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENCUAHANG = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.POS = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[6]);}
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
		public List<Ob_POS_DM_CuaHang> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_DM_CuaHang> list = new List<Ob_POS_DM_CuaHang>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_CuaHang, MaCuaHang, TenCuaHang, POS, ID_Kho, DiaChi, DienThoai From POS_DM_CuaHang Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_DM_CuaHang ob = new Ob_POS_DM_CuaHang();
				if(reader[0] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MACUAHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENCUAHANG = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.POS = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[6]);}
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
		public List<Ob_POS_DM_CuaHang> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_DM_CuaHang> list = new List<Ob_POS_DM_CuaHang>();
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
				Ob_POS_DM_CuaHang ob = new Ob_POS_DM_CuaHang();
				if(reader[0] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MACUAHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENCUAHANG = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.POS = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[6]);}
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
		public Ob_POS_DM_CuaHang _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_POS_DM_CuaHang ob = new Ob_POS_DM_CuaHang();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_CuaHang, MaCuaHang, TenCuaHang, POS, ID_Kho, DiaChi, DienThoai From POS_DM_CuaHang Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MACUAHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENCUAHANG = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.POS = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[6]);}
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
		public bool _InsertOb(Ob_POS_DM_CuaHang ob, SqlConnection conn)
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
				CommandText = @"Insert Into POS_DM_CuaHang (MaCuaHang, TenCuaHang, POS, ID_Kho, DiaChi, DienThoai) Values(@MaCuaHang, @TenCuaHang, @POS, @ID_Kho, @DiaChi, @DienThoai)"
			};
			if (ob.MACUAHANG.Trim() == "")
				command.Parameters.Add("MaCuaHang", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaCuaHang", SqlDbType.VarChar).Value = ob.MACUAHANG;
			if (ob.TENCUAHANG.Trim() == "")
				command.Parameters.Add("TenCuaHang", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenCuaHang", SqlDbType.NVarChar).Value = ob.TENCUAHANG;
			command.Parameters.Add("POS", SqlDbType.Int).Value = ob.POS;
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			if (ob.DIENTHOAI.Trim() == "")
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = ob.DIENTHOAI;
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
		public int _InsertObGetId(Ob_POS_DM_CuaHang ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into POS_DM_CuaHang (MaCuaHang, TenCuaHang, POS, ID_Kho, DiaChi, DienThoai) Values(@MaCuaHang, @TenCuaHang, @POS, @ID_Kho, @DiaChi, @DienThoai)Select @@IDENTITY"
			};
			if (ob.MACUAHANG.Trim() == "")
				command.Parameters.Add("MaCuaHang", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaCuaHang", SqlDbType.VarChar).Value = ob.MACUAHANG;
			if (ob.TENCUAHANG.Trim() == "")
				command.Parameters.Add("TenCuaHang", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenCuaHang", SqlDbType.NVarChar).Value = ob.TENCUAHANG;
			command.Parameters.Add("POS", SqlDbType.Int).Value = ob.POS;
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			if (ob.DIENTHOAI.Trim() == "")
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = ob.DIENTHOAI;
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
		public bool _UpdateOb(Ob_POS_DM_CuaHang ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update POS_DM_CuaHang Set MaCuaHang=@MaCuaHang, TenCuaHang=@TenCuaHang, POS=@POS, ID_Kho=@ID_Kho, DiaChi=@DiaChi, DienThoai=@DienThoai Where ID_CuaHang=@ID_CuaHang"
			};
			command.Parameters.Add("ID_CuaHang", SqlDbType.Int).Value = ob.ID_CUAHANG;
			if (ob.MACUAHANG.Trim() == "")
				command.Parameters.Add("MaCuaHang", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaCuaHang", SqlDbType.VarChar).Value = ob.MACUAHANG;
			if (ob.TENCUAHANG.Trim() == "")
				command.Parameters.Add("TenCuaHang", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenCuaHang", SqlDbType.NVarChar).Value = ob.TENCUAHANG;
			command.Parameters.Add("POS", SqlDbType.Int).Value = ob.POS;
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			if (ob.DIENTHOAI.Trim() == "")
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = ob.DIENTHOAI;
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
		public bool _DeleteOb(Ob_POS_DM_CuaHang ob, SqlConnection conn)
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
				CommandText = @"Delete From POS_DM_CuaHang Where ID_CuaHang=@ID_CuaHang"
			};
				command.Parameters.Add(new SqlParameter("ID_CuaHang", ob.ID_CUAHANG));
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
				CommandText = "Delete From POS_DM_CuaHang Where " + condition
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
				CommandText = "Select * From POS_DM_CuaHang Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From POS_DM_CuaHang"
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
				CommandText = "Select Count(" + nameColumn + ") From POS_DM_CuaHang Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From POS_DM_CuaHang"
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
					CommandText = "Select Min(" + nameColumn + ") From POS_DM_CuaHang Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from POS_DM_CuaHang"
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
					CommandText = "Select Max(" + nameColumn + ") From POS_DM_CuaHang Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_DM_CuaHang"
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_DM_CuaHang Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From POS_DM_CuaHang"
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

