using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

//CreateTimes : 27/07/2016 09:32:26.AM

namespace Bitas
{
	public class KeysList_HT_NguoiDung
	{
		private Guid ConvertGuid(string b)
		{
			Guid gu = Guid.Empty;
			string str = b;
			gu = new Guid(str);
			return gu;
		}
		//ListAll
		public List<Ob_HT_NguoiDung> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_NguoiDung> list = new List<Ob_HT_NguoiDung>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_NguoiDung, TaiKhoan, MatKhau, Ho, Ten, ID_NhomND, ID_ChiNhanh, ID_TruSo, Email, TrangThai, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From HT_NguoiDung"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_HT_NguoiDung ob = new Ob_HT_NguoiDung();
				if(reader[0] != DBNull.Value){ ob.ID_NGUOIDUNG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TAIKHOAN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.MATKHAU = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.HO = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TEN = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.ID_NHOMND = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_CHINHANH = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_TRUSO = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.EMAIL = Convert.ToString(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TRANGTHAI = Convert.ToBoolean(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[13]);}
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
		public List<Ob_HT_NguoiDung> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_NguoiDung> list = new List<Ob_HT_NguoiDung>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_HT_NguoiDung ob = new Ob_HT_NguoiDung();
				if(reader[0] != DBNull.Value){ ob.ID_NGUOIDUNG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TAIKHOAN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.MATKHAU = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.HO = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TEN = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.ID_NHOMND = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_CHINHANH = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_TRUSO = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.EMAIL = Convert.ToString(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TRANGTHAI = Convert.ToBoolean(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[13]);}
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
		public List<Ob_HT_NguoiDung> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_NguoiDung> list = new List<Ob_HT_NguoiDung>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_NguoiDung, TaiKhoan, MatKhau, Ho, Ten, ID_NhomND, ID_ChiNhanh, ID_TruSo, Email, TrangThai, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From HT_NguoiDung Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_HT_NguoiDung ob = new Ob_HT_NguoiDung();
				if(reader[0] != DBNull.Value){ ob.ID_NGUOIDUNG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TAIKHOAN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.MATKHAU = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.HO = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TEN = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.ID_NHOMND = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_CHINHANH = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_TRUSO = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.EMAIL = Convert.ToString(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TRANGTHAI = Convert.ToBoolean(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[13]);}
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
		public List<Ob_HT_NguoiDung> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_NguoiDung> list = new List<Ob_HT_NguoiDung>();
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
				Ob_HT_NguoiDung ob = new Ob_HT_NguoiDung();
				if(reader[0] != DBNull.Value){ ob.ID_NGUOIDUNG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TAIKHOAN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.MATKHAU = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.HO = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TEN = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.ID_NHOMND = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_CHINHANH = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_TRUSO = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.EMAIL = Convert.ToString(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TRANGTHAI = Convert.ToBoolean(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[13]);}
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
		public Ob_HT_NguoiDung _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_HT_NguoiDung ob = new Ob_HT_NguoiDung();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_NguoiDung, TaiKhoan, MatKhau, Ho, Ten, ID_NhomND, ID_ChiNhanh, ID_TruSo, Email, TrangThai, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From HT_NguoiDung Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_NGUOIDUNG = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TAIKHOAN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.MATKHAU = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.HO = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TEN = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.ID_NHOMND = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_CHINHANH = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_TRUSO = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.EMAIL = Convert.ToString(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TRANGTHAI = Convert.ToBoolean(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[13]);}
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
		public bool _InsertOb(Ob_HT_NguoiDung ob, SqlConnection conn)
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
				CommandText = @"Insert Into HT_NguoiDung (TaiKhoan, MatKhau, Ho, Ten, ID_NhomND, ID_ChiNhanh, ID_TruSo, Email, TrangThai, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy) Values(@TaiKhoan, @MatKhau, @Ho, @Ten, @ID_NhomND, @ID_ChiNhanh, @ID_TruSo, @Email, @TrangThai, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedBy)"
			};
			if (ob.TAIKHOAN.Trim() == "")
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value = ob.TAIKHOAN;
			if (ob.MATKHAU.Trim() == "")
				command.Parameters.Add("MatKhau", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MatKhau", SqlDbType.VarChar).Value = ob.MATKHAU;
			if (ob.HO.Trim() == "")
				command.Parameters.Add("Ho", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ho", SqlDbType.NVarChar).Value = ob.HO;
			if (ob.TEN.Trim() == "")
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value = ob.TEN;
			command.Parameters.Add("ID_NhomND", SqlDbType.Int).Value = ob.ID_NHOMND;
			command.Parameters.Add("ID_ChiNhanh", SqlDbType.Int).Value = ob.ID_CHINHANH;
			command.Parameters.Add("ID_TruSo", SqlDbType.Int).Value = ob.ID_TRUSO;
			if (ob.EMAIL.Trim() == "")
				command.Parameters.Add("Email", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Email", SqlDbType.VarChar).Value = ob.EMAIL;
			command.Parameters.Add("TrangThai", SqlDbType.Bit).Value = ob.TRANGTHAI;
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
		public int _InsertObGetId(Ob_HT_NguoiDung ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into HT_NguoiDung (TaiKhoan, MatKhau, Ho, Ten, ID_NhomND, ID_ChiNhanh, ID_TruSo, Email, TrangThai, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy) Values(@TaiKhoan, @MatKhau, @Ho, @Ten, @ID_NhomND, @ID_ChiNhanh, @ID_TruSo, @Email, @TrangThai, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedBy)Select @@IDENTITY"
			};
			if (ob.TAIKHOAN.Trim() == "")
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value = ob.TAIKHOAN;
			if (ob.MATKHAU.Trim() == "")
				command.Parameters.Add("MatKhau", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MatKhau", SqlDbType.VarChar).Value = ob.MATKHAU;
			if (ob.HO.Trim() == "")
				command.Parameters.Add("Ho", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ho", SqlDbType.NVarChar).Value = ob.HO;
			if (ob.TEN.Trim() == "")
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value = ob.TEN;
			command.Parameters.Add("ID_NhomND", SqlDbType.Int).Value = ob.ID_NHOMND;
			command.Parameters.Add("ID_ChiNhanh", SqlDbType.Int).Value = ob.ID_CHINHANH;
			command.Parameters.Add("ID_TruSo", SqlDbType.Int).Value = ob.ID_TRUSO;
			if (ob.EMAIL.Trim() == "")
				command.Parameters.Add("Email", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Email", SqlDbType.VarChar).Value = ob.EMAIL;
			command.Parameters.Add("TrangThai", SqlDbType.Bit).Value = ob.TRANGTHAI;
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
		public bool _UpdateOb(Ob_HT_NguoiDung ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update HT_NguoiDung Set TaiKhoan=@TaiKhoan, MatKhau=@MatKhau, Ho=@Ho, Ten=@Ten, ID_NhomND=@ID_NhomND, ID_ChiNhanh=@ID_ChiNhanh, ID_TruSo=@ID_TruSo, Email=@Email, TrangThai=@TrangThai, ModifiedTime=@ModifiedTime, ModifiedBy=@ModifiedBy, CreatedTime=@CreatedTime, CreatedBy=@CreatedBy Where ID_NguoiDung=@ID_NguoiDung"
			};
			command.Parameters.Add("ID_NguoiDung", SqlDbType.Int).Value = ob.ID_NGUOIDUNG;
			if (ob.TAIKHOAN.Trim() == "")
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value = ob.TAIKHOAN;
			if (ob.MATKHAU.Trim() == "")
				command.Parameters.Add("MatKhau", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MatKhau", SqlDbType.VarChar).Value = ob.MATKHAU;
			if (ob.HO.Trim() == "")
				command.Parameters.Add("Ho", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ho", SqlDbType.NVarChar).Value = ob.HO;
			if (ob.TEN.Trim() == "")
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Ten", SqlDbType.NVarChar).Value = ob.TEN;
			command.Parameters.Add("ID_NhomND", SqlDbType.Int).Value = ob.ID_NHOMND;
			command.Parameters.Add("ID_ChiNhanh", SqlDbType.Int).Value = ob.ID_CHINHANH;
			command.Parameters.Add("ID_TruSo", SqlDbType.Int).Value = ob.ID_TRUSO;
			if (ob.EMAIL.Trim() == "")
				command.Parameters.Add("Email", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Email", SqlDbType.VarChar).Value = ob.EMAIL;
			command.Parameters.Add("TrangThai", SqlDbType.Bit).Value = ob.TRANGTHAI;
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
		public bool _DeleteOb(Ob_HT_NguoiDung ob, SqlConnection conn)
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
				CommandText = @"Delete From HT_NguoiDung Where ID_NguoiDung=@ID_NguoiDung"
			};
				command.Parameters.Add(new SqlParameter("ID_NguoiDung", ob.ID_NGUOIDUNG));
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
				CommandText = "Delete From HT_NguoiDung Where " + condition
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
				CommandText = "Select * From HT_NguoiDung Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From HT_NguoiDung"
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
				CommandText = "Select Count(" + nameColumn + ") From HT_NguoiDung Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From HT_NguoiDung"
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
					CommandText = "Select Min(" + nameColumn + ") From HT_NguoiDung Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from HT_NguoiDung"
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
					CommandText = "Select Max(" + nameColumn + ") From HT_NguoiDung Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From HT_NguoiDung"
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
					CommandText = "Select Sum(" + nameColumn + ") From HT_NguoiDung Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From HT_NguoiDung"
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

