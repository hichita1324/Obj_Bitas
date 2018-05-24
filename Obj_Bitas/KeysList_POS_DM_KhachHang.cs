using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

//CreateTimes : 04/12/2017 16:42:52.PM

namespace Bitas
{
	public class KeysList_POS_DM_KhachHang
	{
		private Guid ConvertGuid(string b)
		{
			Guid gu = Guid.Empty;
			string str = b;
			gu = new Guid(str);
			return gu;
		}
		//ListAll
		public List<Ob_POS_DM_KhachHang> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_DM_KhachHang> list = new List<Ob_POS_DM_KhachHang>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhachHang, TenKhachHang, SoDienThoai, DiaChi, ID_LoaiKH, idx, DiemTichLuy, Active, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_DM_KhachHang"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_DM_KhachHang ob = new Ob_POS_DM_KhachHang();
				if(reader[0] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TENKHACHHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.SODIENTHOAI = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_LOAIKH = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.IDX = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIEMTICHLUY = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ACTIVE = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[11]);}
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
		public List<Ob_POS_DM_KhachHang> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_DM_KhachHang> list = new List<Ob_POS_DM_KhachHang>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_DM_KhachHang ob = new Ob_POS_DM_KhachHang();
				if(reader[0] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TENKHACHHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.SODIENTHOAI = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_LOAIKH = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.IDX = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIEMTICHLUY = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ACTIVE = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[11]);}
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
		public List<Ob_POS_DM_KhachHang> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_DM_KhachHang> list = new List<Ob_POS_DM_KhachHang>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhachHang, TenKhachHang, SoDienThoai, DiaChi, ID_LoaiKH, idx, DiemTichLuy, Active, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_DM_KhachHang Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_DM_KhachHang ob = new Ob_POS_DM_KhachHang();
				if(reader[0] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TENKHACHHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.SODIENTHOAI = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_LOAIKH = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.IDX = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIEMTICHLUY = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ACTIVE = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[11]);}
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
		public List<Ob_POS_DM_KhachHang> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_DM_KhachHang> list = new List<Ob_POS_DM_KhachHang>();
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
				Ob_POS_DM_KhachHang ob = new Ob_POS_DM_KhachHang();
				if(reader[0] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TENKHACHHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.SODIENTHOAI = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_LOAIKH = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.IDX = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIEMTICHLUY = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ACTIVE = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[11]);}
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
		public Ob_POS_DM_KhachHang _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_POS_DM_KhachHang ob = new Ob_POS_DM_KhachHang();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhachHang, TenKhachHang, SoDienThoai, DiaChi, ID_LoaiKH, idx, DiemTichLuy, Active, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_DM_KhachHang Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TENKHACHHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.SODIENTHOAI = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_LOAIKH = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.IDX = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIEMTICHLUY = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ACTIVE = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[11]);}
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
		public bool _InsertOb(Ob_POS_DM_KhachHang ob, SqlConnection conn)
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
				CommandText = @"Insert Into POS_DM_KhachHang (TenKhachHang, SoDienThoai, DiaChi, ID_LoaiKH, DiemTichLuy, Active, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy) Values(@TenKhachHang, @SoDienThoai, @DiaChi, @ID_LoaiKH, @DiemTichLuy, @Active, @CreatedTime, @CreatedBy, @ModifiedTime, @ModifiedBy)"
			};
			//command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KHACHHANG);
			if (ob.TENKHACHHANG.Trim() == "")
				command.Parameters.Add("TenKhachHang", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenKhachHang", SqlDbType.NVarChar).Value = ob.TENKHACHHANG;
			if (ob.SODIENTHOAI.Trim() == "")
				command.Parameters.Add("SoDienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("SoDienThoai", SqlDbType.VarChar).Value = ob.SODIENTHOAI;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			command.Parameters.Add("ID_LoaiKH", SqlDbType.Int).Value = ob.ID_LOAIKH;
			command.Parameters.Add("idx", SqlDbType.Int).Value = ob.IDX;
			command.Parameters.Add("DiemTichLuy", SqlDbType.Int).Value = ob.DIEMTICHLUY;
			command.Parameters.Add("Active", SqlDbType.Bit).Value = ob.ACTIVE;
			if (ob.CREATEDTIME == DateTime.MinValue)
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = ob.CREATEDTIME;
			if (ob.CREATEDBY.Trim() == "")
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value = ob.CREATEDBY;
			if (ob.MODIFIEDTIME == DateTime.MinValue)
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = ob.MODIFIEDTIME;
			if (ob.MODIFIEDBY.Trim() == "")
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value = ob.MODIFIEDBY;
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
		public string _InsertObGetId(Ob_POS_DM_KhachHang ob, SqlConnection conn)
		{
			string num = "";
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
                CommandText = @"Insert Into POS_DM_KhachHang (TenKhachHang, SoDienThoai, DiaChi, ID_LoaiKH, TenKhachHang, SoDienThoai, DiaChi, ID_LoaiKH, idx, DiemTichLuy, Active, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy) OUTPUT INSERTED.ID_KhachHang Values(@TenKhachHang, @SoDienThoai, @DiaChi, @ID_LoaiKH, @TenKhachHang, @SoDienThoai, @DiaChi, @ID_LoaiKH, @idx, @DiemTichLuy, @Active, @CreatedTime, @CreatedBy, @ModifiedTime, @ModifiedBy) Select @@IDENTITY"
			};
			//command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KHACHHANG);
			if (ob.TENKHACHHANG.Trim() == "")
				command.Parameters.Add("TenKhachHang", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenKhachHang", SqlDbType.NVarChar).Value = ob.TENKHACHHANG;
			if (ob.SODIENTHOAI.Trim() == "")
				command.Parameters.Add("SoDienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("SoDienThoai", SqlDbType.VarChar).Value = ob.SODIENTHOAI;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			command.Parameters.Add("ID_LoaiKH", SqlDbType.Int).Value = ob.ID_LOAIKH;
			command.Parameters.Add("idx", SqlDbType.Int).Value = ob.IDX;
			command.Parameters.Add("DiemTichLuy", SqlDbType.Int).Value = ob.DIEMTICHLUY;
			command.Parameters.Add("Active", SqlDbType.Bit).Value = ob.ACTIVE;
			if (ob.CREATEDTIME == DateTime.MinValue)
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = ob.CREATEDTIME;
			if (ob.CREATEDBY.Trim() == "")
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value = ob.CREATEDBY;
			if (ob.MODIFIEDTIME == DateTime.MinValue)
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = ob.MODIFIEDTIME;
			if (ob.MODIFIEDBY.Trim() == "")
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value = ob.MODIFIEDBY;
			try
			{
				 num = command.ExecuteScalar().ToString();
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
		public bool _UpdateOb(Ob_POS_DM_KhachHang ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update POS_DM_KhachHang Set TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, DiaChi=@DiaChi, ID_LoaiKH=@ID_LoaiKH, idx=@idx, DiemTichLuy=@DiemTichLuy, Active=@Active, CreatedTime=@CreatedTime, CreatedBy=@CreatedBy, ModifiedTime=@ModifiedTime, ModifiedBy=@ModifiedBy Where ID_KhachHang=@ID_KhachHang"
			};
			command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KHACHHANG);
			if (ob.TENKHACHHANG.Trim() == "")
				command.Parameters.Add("TenKhachHang", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenKhachHang", SqlDbType.NVarChar).Value = ob.TENKHACHHANG;
			if (ob.SODIENTHOAI.Trim() == "")
				command.Parameters.Add("SoDienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("SoDienThoai", SqlDbType.VarChar).Value = ob.SODIENTHOAI;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			command.Parameters.Add("ID_LoaiKH", SqlDbType.Int).Value = ob.ID_LOAIKH;
			command.Parameters.Add("idx", SqlDbType.Int).Value = ob.IDX;
			command.Parameters.Add("DiemTichLuy", SqlDbType.Int).Value = ob.DIEMTICHLUY;
			command.Parameters.Add("Active", SqlDbType.Bit).Value = ob.ACTIVE;
			if (ob.CREATEDTIME == DateTime.MinValue)
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = ob.CREATEDTIME;
			if (ob.CREATEDBY.Trim() == "")
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value = ob.CREATEDBY;
			if (ob.MODIFIEDTIME == DateTime.MinValue)
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = ob.MODIFIEDTIME;
			if (ob.MODIFIEDBY.Trim() == "")
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value = ob.MODIFIEDBY;
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
		public bool _DeleteOb(Ob_POS_DM_KhachHang ob, SqlConnection conn)
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
				CommandText = @"Delete From POS_DM_KhachHang Where ID_KhachHang=@ID_KhachHang"
			};
				command.Parameters.Add(new SqlParameter("ID_KhachHang", ob.ID_KHACHHANG));
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
				CommandText = "Delete From POS_DM_KhachHang Where " + condition
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
				CommandText = "Select * From POS_DM_KhachHang Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From POS_DM_KhachHang"
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
				CommandText = "Select Count(" + nameColumn + ") From POS_DM_KhachHang Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From POS_DM_KhachHang"
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
					CommandText = "Select Min(" + nameColumn + ") From POS_DM_KhachHang Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from POS_DM_KhachHang"
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
					CommandText = "Select Max(" + nameColumn + ") From POS_DM_KhachHang Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_DM_KhachHang"
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_DM_KhachHang Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From POS_DM_KhachHang"
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

