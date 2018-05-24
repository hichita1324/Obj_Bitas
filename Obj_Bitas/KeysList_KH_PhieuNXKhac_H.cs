using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

//CreateTimes : 12/07/2016 14:13:45.PM

namespace Bitas
{
	public class KeysList_KH_PhieuNXKhac_H
	{
		//ListAll
		public List<Ob_KH_PhieuNXKhac_H> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_KH_PhieuNXKhac_H> list = new List<Ob_KH_PhieuNXKhac_H>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_NX_Khac_H, MaPhieuNXKhac, NgayTao, ID_Kho, ID_NguoiDung, GhiChu, ID_Nhaptu, ID_LoaiNX, TongSoLuong, TongTien, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From KH_PhieuNXKhac_H"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_KH_PhieuNXKhac_H ob = new Ob_KH_PhieuNXKhac_H();
				if(reader[0] != DBNull.Value){ ob.ID_NX_KHAC_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUNXKHAC = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.NGAYTAO = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_NGUOIDUNG = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_NHAPTU = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_LOAINX = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.TONGSOLUONG = Convert.ToInt32(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TONGTIEN = Convert.ToDecimal(reader[9]);}
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
		public List<Ob_KH_PhieuNXKhac_H> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_KH_PhieuNXKhac_H> list = new List<Ob_KH_PhieuNXKhac_H>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_KH_PhieuNXKhac_H ob = new Ob_KH_PhieuNXKhac_H();
				if(reader[0] != DBNull.Value){ ob.ID_NX_KHAC_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUNXKHAC = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.NGAYTAO = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_NGUOIDUNG = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_NHAPTU = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_LOAINX = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.TONGSOLUONG = Convert.ToInt32(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TONGTIEN = Convert.ToDecimal(reader[9]);}
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
		public List<Ob_KH_PhieuNXKhac_H> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_KH_PhieuNXKhac_H> list = new List<Ob_KH_PhieuNXKhac_H>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_NX_Khac_H, MaPhieuNXKhac, NgayTao, ID_Kho, ID_NguoiDung, GhiChu, ID_Nhaptu, ID_LoaiNX, TongSoLuong, TongTien, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From KH_PhieuNXKhac_H Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_KH_PhieuNXKhac_H ob = new Ob_KH_PhieuNXKhac_H();
				if(reader[0] != DBNull.Value){ ob.ID_NX_KHAC_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUNXKHAC = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.NGAYTAO = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_NGUOIDUNG = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_NHAPTU = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_LOAINX = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.TONGSOLUONG = Convert.ToInt32(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TONGTIEN = Convert.ToDecimal(reader[9]);}
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
		public List<Ob_KH_PhieuNXKhac_H> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_KH_PhieuNXKhac_H> list = new List<Ob_KH_PhieuNXKhac_H>();
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
				Ob_KH_PhieuNXKhac_H ob = new Ob_KH_PhieuNXKhac_H();
				if(reader[0] != DBNull.Value){ ob.ID_NX_KHAC_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUNXKHAC = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.NGAYTAO = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_NGUOIDUNG = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_NHAPTU = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_LOAINX = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.TONGSOLUONG = Convert.ToInt32(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TONGTIEN = Convert.ToDecimal(reader[9]);}
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
		public Ob_KH_PhieuNXKhac_H _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_KH_PhieuNXKhac_H ob = new Ob_KH_PhieuNXKhac_H();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_NX_Khac_H, MaPhieuNXKhac, NgayTao, ID_Kho, ID_NguoiDung, GhiChu, ID_Nhaptu, ID_LoaiNX, TongSoLuong, TongTien, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From KH_PhieuNXKhac_H Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_NX_KHAC_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUNXKHAC = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.NGAYTAO = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_NGUOIDUNG = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_NHAPTU = Convert.ToInt32(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_LOAINX = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.TONGSOLUONG = Convert.ToInt32(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TONGTIEN = Convert.ToDecimal(reader[9]);}
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
		public bool _InsertOb(Ob_KH_PhieuNXKhac_H ob, SqlConnection conn)
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
				CommandText = @"Insert Into KH_PhieuNXKhac_H (ID_NX_Khac_H, MaPhieuNXKhac, NgayTao, ID_Kho, ID_NguoiDung, GhiChu, ID_Nhaptu, ID_LoaiNX, TongSoLuong, TongTien, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy) Values(@ID_NX_Khac_H, @MaPhieuNXKhac, @NgayTao, @ID_Kho, @ID_NguoiDung, @GhiChu, @ID_Nhaptu, @ID_LoaiNX, @TongSoLuong, @TongTien, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedBy)"
			};
			if (ob.ID_NX_KHAC_H.Trim() == "")
				command.Parameters.Add("ID_NX_Khac_H", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_NX_Khac_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_NX_KHAC_H);
			if (ob.MAPHIEUNXKHAC.Trim() == "")
				command.Parameters.Add("MaPhieuNXKhac", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaPhieuNXKhac", SqlDbType.VarChar).Value = ob.MAPHIEUNXKHAC;
			if (ob.NGAYTAO == DateTime.MinValue)
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = ob.NGAYTAO;
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			command.Parameters.Add("ID_NguoiDung", SqlDbType.Int).Value = ob.ID_NGUOIDUNG;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			command.Parameters.Add("ID_Nhaptu", SqlDbType.Int).Value = ob.ID_NHAPTU;
			command.Parameters.Add("ID_LoaiNX", SqlDbType.Int).Value = ob.ID_LOAINX;
			command.Parameters.Add("TongSoLuong", SqlDbType.Int).Value = ob.TONGSOLUONG;
			command.Parameters.Add("TongTien", SqlDbType.Money).Value = ob.TONGTIEN;
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
		public int _InsertObGetId(Ob_KH_PhieuNXKhac_H ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into KH_PhieuNXKhac_H (ID_NX_Khac_H, MaPhieuNXKhac, NgayTao, ID_Kho, ID_NguoiDung, GhiChu, ID_Nhaptu, ID_LoaiNX, TongSoLuong, TongTien, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy) Values(@ID_NX_Khac_H, @MaPhieuNXKhac, @NgayTao, @ID_Kho, @ID_NguoiDung, @GhiChu, @ID_Nhaptu, @ID_LoaiNX, @TongSoLuong, @TongTien, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedBy)Select @@IDENTITY"
			};
			if (ob.ID_NX_KHAC_H.Trim() == "")
				command.Parameters.Add("ID_NX_Khac_H", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_NX_Khac_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_NX_KHAC_H);
			if (ob.MAPHIEUNXKHAC.Trim() == "")
				command.Parameters.Add("MaPhieuNXKhac", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaPhieuNXKhac", SqlDbType.VarChar).Value = ob.MAPHIEUNXKHAC;
			if (ob.NGAYTAO == DateTime.MinValue)
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = ob.NGAYTAO;
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			command.Parameters.Add("ID_NguoiDung", SqlDbType.Int).Value = ob.ID_NGUOIDUNG;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			command.Parameters.Add("ID_Nhaptu", SqlDbType.Int).Value = ob.ID_NHAPTU;
			command.Parameters.Add("ID_LoaiNX", SqlDbType.Int).Value = ob.ID_LOAINX;
			command.Parameters.Add("TongSoLuong", SqlDbType.Int).Value = ob.TONGSOLUONG;
			command.Parameters.Add("TongTien", SqlDbType.Money).Value = ob.TONGTIEN;
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
		public bool _UpdateOb(Ob_KH_PhieuNXKhac_H ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update KH_PhieuNXKhac_H Set ID_NX_Khac_H=@ID_NX_Khac_H, MaPhieuNXKhac=@MaPhieuNXKhac, NgayTao=@NgayTao, ID_Kho=@ID_Kho, ID_NguoiDung=@ID_NguoiDung, GhiChu=@GhiChu, ID_Nhaptu=@ID_Nhaptu, ID_LoaiNX=@ID_LoaiNX, TongSoLuong=@TongSoLuong, TongTien=@TongTien, ModifiedTime=@ModifiedTime, ModifiedBy=@ModifiedBy, CreatedTime=@CreatedTime, CreatedBy=@CreatedBy Where ID_NX_Khac_H=@ID_NX_Khac_H"
			};
			if (ob.ID_NX_KHAC_H.Trim() == "")
				command.Parameters.Add("ID_NX_Khac_H", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_NX_Khac_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_NX_KHAC_H);
			if (ob.MAPHIEUNXKHAC.Trim() == "")
				command.Parameters.Add("MaPhieuNXKhac", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaPhieuNXKhac", SqlDbType.VarChar).Value = ob.MAPHIEUNXKHAC;
			if (ob.NGAYTAO == DateTime.MinValue)
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = ob.NGAYTAO;
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			command.Parameters.Add("ID_NguoiDung", SqlDbType.Int).Value = ob.ID_NGUOIDUNG;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			command.Parameters.Add("ID_Nhaptu", SqlDbType.Int).Value = ob.ID_NHAPTU;
			command.Parameters.Add("ID_LoaiNX", SqlDbType.Int).Value = ob.ID_LOAINX;
			command.Parameters.Add("TongSoLuong", SqlDbType.Int).Value = ob.TONGSOLUONG;
			command.Parameters.Add("TongTien", SqlDbType.Money).Value = ob.TONGTIEN;
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
		public bool _DeleteOb(Ob_KH_PhieuNXKhac_H ob, SqlConnection conn)
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
				CommandText = @"Delete From KH_PhieuNXKhac_H Where ID_NX_Khac_H=@ID_NX_Khac_H"
			};
				command.Parameters.Add(new SqlParameter("ID_NX_Khac_H", ob.ID_NX_KHAC_H));
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
				CommandText = "Delete From KH_PhieuNXKhac_H Where " + condition
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
				CommandText = "Select * From KH_PhieuNXKhac_H Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From KH_PhieuNXKhac_H"
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
				CommandText = "Select Count(" + nameColumn + ") From KH_PhieuNXKhac_H Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From KH_PhieuNXKhac_H"
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
					CommandText = "Select Min(" + nameColumn + ") From KH_PhieuNXKhac_H Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from KH_PhieuNXKhac_H"
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
					CommandText = "Select Max(" + nameColumn + ") From KH_PhieuNXKhac_H Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From KH_PhieuNXKhac_H"
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
					CommandText = "Select Sum(" + nameColumn + ") From KH_PhieuNXKhac_H Where " + keyword +""
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
	}
}

