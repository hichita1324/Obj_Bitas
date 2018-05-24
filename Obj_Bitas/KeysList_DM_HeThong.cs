using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

//CreateTimes : 22/07/2016 13:42:21.PM

namespace Bitas
{
	public class KeysList_DM_HeThong
	{
		private Guid ConvertGuid(string b)
		{
			Guid gu = Guid.Empty;
			string str = b;
			gu = new Guid(str);
			return gu;
		}
		//ListAll
		public List<Ob_DM_HeThong> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_HeThong> list = new List<Ob_DM_HeThong>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_HeThong, MoTa, TenCongTy, TenVietTat, DiaChi, MaSoThue, Logo, DienThoai, Fax From DM_HeThong"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DM_HeThong ob = new Ob_DM_HeThong();
				if(reader[0] != DBNull.Value){ ob.ID_HETHONG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MOTA = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENCONGTY = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.TENVIETTAT = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.MASOTHUE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.LOGO = (byte[])(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.FAX = Convert.ToString(reader[8]);}
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
		public List<Ob_DM_HeThong> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_HeThong> list = new List<Ob_DM_HeThong>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DM_HeThong ob = new Ob_DM_HeThong();
				if(reader[0] != DBNull.Value){ ob.ID_HETHONG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MOTA = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENCONGTY = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.TENVIETTAT = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.MASOTHUE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.LOGO = (byte[])(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.FAX = Convert.ToString(reader[8]);}
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
		public List<Ob_DM_HeThong> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_HeThong> list = new List<Ob_DM_HeThong>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_HeThong, MoTa, TenCongTy, TenVietTat, DiaChi, MaSoThue, Logo, DienThoai, Fax From DM_HeThong Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DM_HeThong ob = new Ob_DM_HeThong();
				if(reader[0] != DBNull.Value){ ob.ID_HETHONG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MOTA = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENCONGTY = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.TENVIETTAT = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.MASOTHUE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.LOGO = (byte[])(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.FAX = Convert.ToString(reader[8]);}
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
		public List<Ob_DM_HeThong> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_HeThong> list = new List<Ob_DM_HeThong>();
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
				Ob_DM_HeThong ob = new Ob_DM_HeThong();
				if(reader[0] != DBNull.Value){ ob.ID_HETHONG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MOTA = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENCONGTY = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.TENVIETTAT = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.MASOTHUE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.LOGO = (byte[])(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.FAX = Convert.ToString(reader[8]);}
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
		public Ob_DM_HeThong _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_DM_HeThong ob = new Ob_DM_HeThong();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_HeThong, MoTa, TenCongTy, TenVietTat, DiaChi, MaSoThue, Logo, DienThoai, Fax From DM_HeThong Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_HETHONG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MOTA = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENCONGTY = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.TENVIETTAT = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.MASOTHUE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.LOGO = (byte[])(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.FAX = Convert.ToString(reader[8]);}
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
		public bool _InsertOb(Ob_DM_HeThong ob, SqlConnection conn)
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
				CommandText = @"Insert Into DM_HeThong (MoTa, TenCongTy, TenVietTat, DiaChi, MaSoThue, Logo, DienThoai, Fax) Values(@MoTa, @TenCongTy, @TenVietTat, @DiaChi, @MaSoThue, @Logo, @DienThoai, @Fax)"
			};
			if (ob.MOTA.Trim() == "")
				command.Parameters.Add("MoTa", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MoTa", SqlDbType.NVarChar).Value = ob.MOTA;
			if (ob.TENCONGTY.Trim() == "")
				command.Parameters.Add("TenCongTy", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenCongTy", SqlDbType.NVarChar).Value = ob.TENCONGTY;
			if (ob.TENVIETTAT.Trim() == "")
				command.Parameters.Add("TenVietTat", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenVietTat", SqlDbType.NVarChar).Value = ob.TENVIETTAT;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			if (ob.MASOTHUE.Trim() == "")
				command.Parameters.Add("MaSoThue", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaSoThue", SqlDbType.VarChar).Value = ob.MASOTHUE;
			if (ob.LOGO == null)
				command.Parameters.Add("Logo", SqlDbType.Image).Value = DBNull.Value;
			else
				command.Parameters.Add("Logo", SqlDbType.Image).Value = ob.LOGO;
			if (ob.DIENTHOAI.Trim() == "")
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = ob.DIENTHOAI;
			if (ob.FAX.Trim() == "")
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value = ob.FAX;
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
		public int _InsertObGetId(Ob_DM_HeThong ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into DM_HeThong (MoTa, TenCongTy, TenVietTat, DiaChi, MaSoThue, Logo, DienThoai, Fax) Values(@MoTa, @TenCongTy, @TenVietTat, @DiaChi, @MaSoThue, @Logo, @DienThoai, @Fax)Select @@IDENTITY"
			};
			if (ob.MOTA.Trim() == "")
				command.Parameters.Add("MoTa", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MoTa", SqlDbType.NVarChar).Value = ob.MOTA;
			if (ob.TENCONGTY.Trim() == "")
				command.Parameters.Add("TenCongTy", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenCongTy", SqlDbType.NVarChar).Value = ob.TENCONGTY;
			if (ob.TENVIETTAT.Trim() == "")
				command.Parameters.Add("TenVietTat", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenVietTat", SqlDbType.NVarChar).Value = ob.TENVIETTAT;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			if (ob.MASOTHUE.Trim() == "")
				command.Parameters.Add("MaSoThue", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaSoThue", SqlDbType.VarChar).Value = ob.MASOTHUE;
			if (ob.LOGO == null)
				command.Parameters.Add("Logo", SqlDbType.Image).Value = DBNull.Value;
			else
				command.Parameters.Add("Logo", SqlDbType.Image).Value = ob.LOGO;
			if (ob.DIENTHOAI.Trim() == "")
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = ob.DIENTHOAI;
			if (ob.FAX.Trim() == "")
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value = ob.FAX;
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
		public bool _UpdateOb(Ob_DM_HeThong ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update DM_HeThong Set MoTa=@MoTa, TenCongTy=@TenCongTy, TenVietTat=@TenVietTat, DiaChi=@DiaChi, MaSoThue=@MaSoThue, Logo=@Logo, DienThoai=@DienThoai, Fax=@Fax Where ID_HeThong=@ID_HeThong"
			};
			command.Parameters.Add("ID_HeThong", SqlDbType.Int).Value = ob.ID_HETHONG;
			if (ob.MOTA.Trim() == "")
				command.Parameters.Add("MoTa", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MoTa", SqlDbType.NVarChar).Value = ob.MOTA;
			if (ob.TENCONGTY.Trim() == "")
				command.Parameters.Add("TenCongTy", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenCongTy", SqlDbType.NVarChar).Value = ob.TENCONGTY;
			if (ob.TENVIETTAT.Trim() == "")
				command.Parameters.Add("TenVietTat", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenVietTat", SqlDbType.NVarChar).Value = ob.TENVIETTAT;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			if (ob.MASOTHUE.Trim() == "")
				command.Parameters.Add("MaSoThue", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaSoThue", SqlDbType.VarChar).Value = ob.MASOTHUE;
			if (ob.LOGO == null)
				command.Parameters.Add("Logo", SqlDbType.Image).Value = DBNull.Value;
			else
				command.Parameters.Add("Logo", SqlDbType.Image).Value = ob.LOGO;
			if (ob.DIENTHOAI.Trim() == "")
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = ob.DIENTHOAI;
			if (ob.FAX.Trim() == "")
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value = ob.FAX;
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
		public bool _DeleteOb(Ob_DM_HeThong ob, SqlConnection conn)
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
				CommandText = @"Delete From DM_HeThong Where ID_HeThong=@ID_HeThong"
			};
				command.Parameters.Add(new SqlParameter("ID_HeThong", ob.ID_HETHONG));
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
				CommandText = "Delete From DM_HeThong Where " + condition
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
				CommandText = "Select * From DM_HeThong Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From DM_HeThong"
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
				CommandText = "Select Count(" + nameColumn + ") From DM_HeThong Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From DM_HeThong"
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
					CommandText = "Select Min(" + nameColumn + ") From DM_HeThong Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from DM_HeThong"
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
					CommandText = "Select Max(" + nameColumn + ") From DM_HeThong Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From DM_HeThong"
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
					CommandText = "Select Sum(" + nameColumn + ") From DM_HeThong Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From DM_HeThong"
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

