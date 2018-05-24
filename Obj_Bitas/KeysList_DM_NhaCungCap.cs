using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//CreateTimes : 04/04/2016 10:43:55.AM

namespace Bitas
{
	public class KeysList_DM_NhaCungCap
	{
		//ListAll
		public List<Ob_DM_NhaCungCap> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_NhaCungCap> list = new List<Ob_DM_NhaCungCap>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_NhaCungCap, MaNhaCungCap, TenNhaCungCap, DienThoai, DiDong, Fax, DiaChi, NguoiLienHe, Email, MaSoThue, GhiChu, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From DM_NhaCungCap"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DM_NhaCungCap ob = new Ob_DM_NhaCungCap();
				if(reader[0] != DBNull.Value){ ob.ID_NHACUNGCAP = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MANHACUNGCAP = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENNHACUNGCAP = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIDONG = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.FAX = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.NGUOILIENHE = Convert.ToString(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.EMAIL = Convert.ToString(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MASOTHUE = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[14]);}
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
		public List<Ob_DM_NhaCungCap> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_NhaCungCap> list = new List<Ob_DM_NhaCungCap>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DM_NhaCungCap ob = new Ob_DM_NhaCungCap();
				if(reader[0] != DBNull.Value){ ob.ID_NHACUNGCAP = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MANHACUNGCAP = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENNHACUNGCAP = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIDONG = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.FAX = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.NGUOILIENHE = Convert.ToString(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.EMAIL = Convert.ToString(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MASOTHUE = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[14]);}
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
		public List<Ob_DM_NhaCungCap> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_NhaCungCap> list = new List<Ob_DM_NhaCungCap>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_NhaCungCap, MaNhaCungCap, TenNhaCungCap, DienThoai, DiDong, Fax, DiaChi, NguoiLienHe, Email, MaSoThue, GhiChu, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From DM_NhaCungCap Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DM_NhaCungCap ob = new Ob_DM_NhaCungCap();
				if(reader[0] != DBNull.Value){ ob.ID_NHACUNGCAP = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MANHACUNGCAP = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENNHACUNGCAP = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIDONG = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.FAX = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.NGUOILIENHE = Convert.ToString(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.EMAIL = Convert.ToString(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MASOTHUE = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[14]);}
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
		public List<Ob_DM_NhaCungCap> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_NhaCungCap> list = new List<Ob_DM_NhaCungCap>();
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
				Ob_DM_NhaCungCap ob = new Ob_DM_NhaCungCap();
				if(reader[0] != DBNull.Value){ ob.ID_NHACUNGCAP = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MANHACUNGCAP = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENNHACUNGCAP = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIDONG = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.FAX = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.NGUOILIENHE = Convert.ToString(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.EMAIL = Convert.ToString(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MASOTHUE = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[14]);}
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
		public Ob_DM_NhaCungCap _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_DM_NhaCungCap ob = new Ob_DM_NhaCungCap();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_NhaCungCap, MaNhaCungCap, TenNhaCungCap, DienThoai, DiDong, Fax, DiaChi, NguoiLienHe, Email, MaSoThue, GhiChu, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From DM_NhaCungCap Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_NHACUNGCAP = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MANHACUNGCAP = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENNHACUNGCAP = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DIENTHOAI = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIDONG = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.FAX = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DIACHI = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.NGUOILIENHE = Convert.ToString(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.EMAIL = Convert.ToString(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MASOTHUE = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[14]);}
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
		public bool _InsertOb(Ob_DM_NhaCungCap ob, SqlConnection conn)
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
				CommandText = @"Insert Into DM_NhaCungCap (MaNhaCungCap, TenNhaCungCap, DienThoai, DiDong, Fax, DiaChi, NguoiLienHe, Email, MaSoThue, GhiChu, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy) Values(@MaNhaCungCap, @TenNhaCungCap, @DienThoai, @DiDong, @Fax, @DiaChi, @NguoiLienHe, @Email, @MaSoThue, @GhiChu, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedBy)"
			};
			if (ob.MANHACUNGCAP.Trim() == "")
				command.Parameters.Add("MaNhaCungCap", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaNhaCungCap", SqlDbType.VarChar).Value = ob.MANHACUNGCAP;
			if (ob.TENNHACUNGCAP.Trim() == "")
				command.Parameters.Add("TenNhaCungCap", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenNhaCungCap", SqlDbType.NVarChar).Value = ob.TENNHACUNGCAP;
			if (ob.DIENTHOAI.Trim() == "")
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = ob.DIENTHOAI;
			if (ob.DIDONG.Trim() == "")
				command.Parameters.Add("DiDong", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiDong", SqlDbType.VarChar).Value = ob.DIDONG;
			if (ob.FAX.Trim() == "")
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value = ob.FAX;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			if (ob.NGUOILIENHE.Trim() == "")
				command.Parameters.Add("NguoiLienHe", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("NguoiLienHe", SqlDbType.NVarChar).Value = ob.NGUOILIENHE;
			if (ob.EMAIL.Trim() == "")
				command.Parameters.Add("Email", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Email", SqlDbType.VarChar).Value = ob.EMAIL;
			if (ob.MASOTHUE.Trim() == "")
				command.Parameters.Add("MaSoThue", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaSoThue", SqlDbType.NVarChar).Value = ob.MASOTHUE;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			if (ob.MODIFIEDTIME == DateTime.MinValue)
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = ob.MODIFIEDTIME;
			if (ob.MODIFIEDBY.Trim() == "")
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value = ob.MODIFIEDBY;
			if (ob.CREATEDTIME == DateTime.MinValue)
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = ob.CREATEDTIME;
			if (ob.CREATEDBY.Trim() == "")
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value = ob.CREATEDBY;
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
		public int _InsertObGetId(Ob_DM_NhaCungCap ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into DM_NhaCungCap (MaNhaCungCap, TenNhaCungCap, DienThoai, DiDong, Fax, DiaChi, NguoiLienHe, Email, MaSoThue, GhiChu, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy) Values(@MaNhaCungCap, @TenNhaCungCap, @DienThoai, @DiDong, @Fax, @DiaChi, @NguoiLienHe, @Email, @MaSoThue, @GhiChu, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedBy)Select @@IDENTITY"
			};
			if (ob.MANHACUNGCAP.Trim() == "")
				command.Parameters.Add("MaNhaCungCap", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaNhaCungCap", SqlDbType.VarChar).Value = ob.MANHACUNGCAP;
			if (ob.TENNHACUNGCAP.Trim() == "")
				command.Parameters.Add("TenNhaCungCap", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenNhaCungCap", SqlDbType.NVarChar).Value = ob.TENNHACUNGCAP;
			if (ob.DIENTHOAI.Trim() == "")
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = ob.DIENTHOAI;
			if (ob.DIDONG.Trim() == "")
				command.Parameters.Add("DiDong", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiDong", SqlDbType.VarChar).Value = ob.DIDONG;
			if (ob.FAX.Trim() == "")
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value = ob.FAX;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			if (ob.NGUOILIENHE.Trim() == "")
				command.Parameters.Add("NguoiLienHe", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("NguoiLienHe", SqlDbType.NVarChar).Value = ob.NGUOILIENHE;
			if (ob.EMAIL.Trim() == "")
				command.Parameters.Add("Email", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Email", SqlDbType.VarChar).Value = ob.EMAIL;
			if (ob.MASOTHUE.Trim() == "")
				command.Parameters.Add("MaSoThue", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaSoThue", SqlDbType.NVarChar).Value = ob.MASOTHUE;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			if (ob.MODIFIEDTIME == DateTime.MinValue)
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = ob.MODIFIEDTIME;
			if (ob.MODIFIEDBY.Trim() == "")
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value = ob.MODIFIEDBY;
			if (ob.CREATEDTIME == DateTime.MinValue)
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = ob.CREATEDTIME;
			if (ob.CREATEDBY.Trim() == "")
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value = ob.CREATEDBY;
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
		public bool _UpdateOb(Ob_DM_NhaCungCap ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update DM_NhaCungCap Set MaNhaCungCap=@MaNhaCungCap, TenNhaCungCap=@TenNhaCungCap, DienThoai=@DienThoai, DiDong=@DiDong, Fax=@Fax, DiaChi=@DiaChi, NguoiLienHe=@NguoiLienHe, Email=@Email, MaSoThue=@MaSoThue, GhiChu=@GhiChu, ModifiedTime=@ModifiedTime, ModifiedBy=@ModifiedBy, CreatedTime=@CreatedTime, CreatedBy=@CreatedBy Where ID_NhaCungCap=@ID_NhaCungCap"
			};
			command.Parameters.Add("ID_NhaCungCap", SqlDbType.Int).Value = ob.ID_NHACUNGCAP;
			if (ob.MANHACUNGCAP.Trim() == "")
				command.Parameters.Add("MaNhaCungCap", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaNhaCungCap", SqlDbType.VarChar).Value = ob.MANHACUNGCAP;
			if (ob.TENNHACUNGCAP.Trim() == "")
				command.Parameters.Add("TenNhaCungCap", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenNhaCungCap", SqlDbType.NVarChar).Value = ob.TENNHACUNGCAP;
			if (ob.DIENTHOAI.Trim() == "")
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = ob.DIENTHOAI;
			if (ob.DIDONG.Trim() == "")
				command.Parameters.Add("DiDong", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiDong", SqlDbType.VarChar).Value = ob.DIDONG;
			if (ob.FAX.Trim() == "")
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Fax", SqlDbType.VarChar).Value = ob.FAX;
			if (ob.DIACHI.Trim() == "")
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = ob.DIACHI;
			if (ob.NGUOILIENHE.Trim() == "")
				command.Parameters.Add("NguoiLienHe", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("NguoiLienHe", SqlDbType.NVarChar).Value = ob.NGUOILIENHE;
			if (ob.EMAIL.Trim() == "")
				command.Parameters.Add("Email", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Email", SqlDbType.VarChar).Value = ob.EMAIL;
			if (ob.MASOTHUE.Trim() == "")
				command.Parameters.Add("MaSoThue", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaSoThue", SqlDbType.NVarChar).Value = ob.MASOTHUE;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			if (ob.MODIFIEDTIME == DateTime.MinValue)
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("ModifiedTime", SqlDbType.DateTime).Value = ob.MODIFIEDTIME;
			if (ob.MODIFIEDBY.Trim() == "")
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value = ob.MODIFIEDBY;
			if (ob.CREATEDTIME == DateTime.MinValue)
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("CreatedTime", SqlDbType.DateTime).Value = ob.CREATEDTIME;
			if (ob.CREATEDBY.Trim() == "")
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value = ob.CREATEDBY;
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
		public bool _DeleteOb(Ob_DM_NhaCungCap ob, SqlConnection conn)
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
				CommandText = @"Delete From DM_NhaCungCap Where ID_NhaCungCap=@ID_NhaCungCap"
			};
				command.Parameters.Add(new SqlParameter("ID_NhaCungCap", ob.ID_NHACUNGCAP));
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
				CommandText = "Delete From DM_NhaCungCap Where " + condition
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
				CommandText = "Select * From DM_NhaCungCap Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From DM_NhaCungCap"
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
				CommandText = "Select Count(" + nameColumn + ") From DM_NhaCungCap Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From DM_NhaCungCap"
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
					CommandText = "Select Min(" + nameColumn + ") From DM_NhaCungCap Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from DM_NhaCungCap"
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
					CommandText = "Select Max(" + nameColumn + ") From DM_NhaCungCap Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From DM_NhaCungCap"
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
					CommandText = "Select Sum(" + nameColumn + ") From DM_NhaCungCap Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From DM_NhaCungCap"
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

