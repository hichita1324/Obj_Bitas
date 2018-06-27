using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

//CreateTimes : 27/06/2018 10:32:01.AM

namespace Bitas
{
	public class KeysList_POS_NhapHang_H
	{
		private Guid ConvertGuid(string b)
		{
			Guid gu = Guid.Empty;
			string str = b;
			gu = new Guid(str);
			return gu;
		}
		//ListAll
		public List<Ob_POS_NhapHang_H> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_NhapHang_H> list = new List<Ob_POS_NhapHang_H>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_PhieuNhapHang_H, MaPhieuNhapHang, ID_Kiemke, ID_CuaHang, ID_Kho, ID_KhoXuat, ID_KhachHang, ID_NhaCungCap, ID_LoaiNhap, NgayNhapHang, GhiChu, SoLuong, ThanhTien, ID_TrangThaiPhieu, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_NhapHang_H"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_NhapHang_H ob = new Ob_POS_NhapHang_H();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUNHAPHANG_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUNHAPHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_KIEMKE = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.ID_KHOXUAT = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_NHACUNGCAP = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.ID_LOAINHAP = Convert.ToInt32(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.NGAYNHAPHANG = Convert.ToDateTime(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.THANHTIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.ID_TRANGTHAIPHIEU = Convert.ToInt32(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[16]);}
				if(reader[17] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[17]);}
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
		public List<Ob_POS_NhapHang_H> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_NhapHang_H> list = new List<Ob_POS_NhapHang_H>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_NhapHang_H ob = new Ob_POS_NhapHang_H();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUNHAPHANG_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUNHAPHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_KIEMKE = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.ID_KHOXUAT = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_NHACUNGCAP = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.ID_LOAINHAP = Convert.ToInt32(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.NGAYNHAPHANG = Convert.ToDateTime(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.THANHTIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.ID_TRANGTHAIPHIEU = Convert.ToInt32(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[16]);}
				if(reader[17] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[17]);}
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
		public List<Ob_POS_NhapHang_H> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_NhapHang_H> list = new List<Ob_POS_NhapHang_H>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_PhieuNhapHang_H, MaPhieuNhapHang, ID_Kiemke, ID_CuaHang, ID_Kho, ID_KhoXuat, ID_KhachHang, ID_NhaCungCap, ID_LoaiNhap, NgayNhapHang, GhiChu, SoLuong, ThanhTien, ID_TrangThaiPhieu, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_NhapHang_H Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_NhapHang_H ob = new Ob_POS_NhapHang_H();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUNHAPHANG_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUNHAPHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_KIEMKE = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.ID_KHOXUAT = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_NHACUNGCAP = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.ID_LOAINHAP = Convert.ToInt32(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.NGAYNHAPHANG = Convert.ToDateTime(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.THANHTIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.ID_TRANGTHAIPHIEU = Convert.ToInt32(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[16]);}
				if(reader[17] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[17]);}
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
		public List<Ob_POS_NhapHang_H> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_NhapHang_H> list = new List<Ob_POS_NhapHang_H>();
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
				Ob_POS_NhapHang_H ob = new Ob_POS_NhapHang_H();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUNHAPHANG_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUNHAPHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_KIEMKE = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.ID_KHOXUAT = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_NHACUNGCAP = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.ID_LOAINHAP = Convert.ToInt32(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.NGAYNHAPHANG = Convert.ToDateTime(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.THANHTIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.ID_TRANGTHAIPHIEU = Convert.ToInt32(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[16]);}
				if(reader[17] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[17]);}
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
		public Ob_POS_NhapHang_H _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_POS_NhapHang_H ob = new Ob_POS_NhapHang_H();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_PhieuNhapHang_H, MaPhieuNhapHang, ID_Kiemke, ID_CuaHang, ID_Kho, ID_KhoXuat, ID_KhachHang, ID_NhaCungCap, ID_LoaiNhap, NgayNhapHang, GhiChu, SoLuong, ThanhTien, ID_TrangThaiPhieu, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_NhapHang_H Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUNHAPHANG_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUNHAPHANG = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_KIEMKE = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CUAHANG = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.ID_KHOXUAT = Convert.ToInt32(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.ID_NHACUNGCAP = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.ID_LOAINHAP = Convert.ToInt32(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.NGAYNHAPHANG = Convert.ToDateTime(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.THANHTIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.ID_TRANGTHAIPHIEU = Convert.ToInt32(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[16]);}
				if(reader[17] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[17]);}
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
		public bool _InsertOb(Ob_POS_NhapHang_H ob, SqlConnection conn)
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
				CommandText = @"Insert Into POS_NhapHang_H (ID_PhieuNhapHang_H, MaPhieuNhapHang, ID_Kiemke, ID_CuaHang, ID_Kho, ID_KhoXuat, ID_KhachHang, ID_NhaCungCap, ID_LoaiNhap, NgayNhapHang, GhiChu, SoLuong, ThanhTien, ID_TrangThaiPhieu, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy) Values(@ID_PhieuNhapHang_H, @MaPhieuNhapHang, @ID_Kiemke, @ID_CuaHang, @ID_Kho, @ID_KhoXuat, @ID_KhachHang, @ID_NhaCungCap, @ID_LoaiNhap, @NgayNhapHang, @GhiChu, @SoLuong, @ThanhTien, @ID_TrangThaiPhieu, @CreatedTime, @CreatedBy, @ModifiedTime, @ModifiedBy)"
			};
			command.Parameters.Add("ID_PhieuNhapHang_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUNHAPHANG_H);
			if (ob.MAPHIEUNHAPHANG.Trim() == "")
				command.Parameters.Add("MaPhieuNhapHang", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaPhieuNhapHang", SqlDbType.VarChar).Value = ob.MAPHIEUNHAPHANG;
			command.Parameters.Add("ID_Kiemke", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KIEMKE);
			command.Parameters.Add("ID_CuaHang", SqlDbType.Int).Value = ob.ID_CUAHANG;
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			command.Parameters.Add("ID_KhoXuat", SqlDbType.Int).Value = ob.ID_KHOXUAT;
			command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KHACHHANG);
			command.Parameters.Add("ID_NhaCungCap", SqlDbType.Int).Value = ob.ID_NHACUNGCAP;
			command.Parameters.Add("ID_LoaiNhap", SqlDbType.Int).Value = ob.ID_LOAINHAP;
			if (ob.NGAYNHAPHANG == DateTime.MinValue)
				command.Parameters.Add("NgayNhapHang", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayNhapHang", SqlDbType.DateTime).Value = ob.NGAYNHAPHANG;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			command.Parameters.Add("SoLuong", SqlDbType.Int).Value = ob.SOLUONG;
			command.Parameters.Add("ThanhTien", SqlDbType.Money).Value = ob.THANHTIEN;
			command.Parameters.Add("ID_TrangThaiPhieu", SqlDbType.Int).Value = ob.ID_TRANGTHAIPHIEU;
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
		public int _InsertObGetId(Ob_POS_NhapHang_H ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into POS_NhapHang_H (ID_PhieuNhapHang_H, MaPhieuNhapHang, ID_Kiemke, ID_CuaHang, ID_Kho, ID_KhoXuat, ID_KhachHang, ID_NhaCungCap, ID_LoaiNhap, NgayNhapHang, GhiChu, SoLuong, ThanhTien, ID_TrangThaiPhieu, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy) Values(@ID_PhieuNhapHang_H, @MaPhieuNhapHang, @ID_Kiemke, @ID_CuaHang, @ID_Kho, @ID_KhoXuat, @ID_KhachHang, @ID_NhaCungCap, @ID_LoaiNhap, @NgayNhapHang, @GhiChu, @SoLuong, @ThanhTien, @ID_TrangThaiPhieu, @CreatedTime, @CreatedBy, @ModifiedTime, @ModifiedBy)Select @@IDENTITY"
			};
			command.Parameters.Add("ID_PhieuNhapHang_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUNHAPHANG_H);
			if (ob.MAPHIEUNHAPHANG.Trim() == "")
				command.Parameters.Add("MaPhieuNhapHang", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaPhieuNhapHang", SqlDbType.VarChar).Value = ob.MAPHIEUNHAPHANG;
			command.Parameters.Add("ID_Kiemke", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KIEMKE);
			command.Parameters.Add("ID_CuaHang", SqlDbType.Int).Value = ob.ID_CUAHANG;
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			command.Parameters.Add("ID_KhoXuat", SqlDbType.Int).Value = ob.ID_KHOXUAT;
			command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KHACHHANG);
			command.Parameters.Add("ID_NhaCungCap", SqlDbType.Int).Value = ob.ID_NHACUNGCAP;
			command.Parameters.Add("ID_LoaiNhap", SqlDbType.Int).Value = ob.ID_LOAINHAP;
			if (ob.NGAYNHAPHANG == DateTime.MinValue)
				command.Parameters.Add("NgayNhapHang", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayNhapHang", SqlDbType.DateTime).Value = ob.NGAYNHAPHANG;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			command.Parameters.Add("SoLuong", SqlDbType.Int).Value = ob.SOLUONG;
			command.Parameters.Add("ThanhTien", SqlDbType.Money).Value = ob.THANHTIEN;
			command.Parameters.Add("ID_TrangThaiPhieu", SqlDbType.Int).Value = ob.ID_TRANGTHAIPHIEU;
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
		public bool _UpdateOb(Ob_POS_NhapHang_H ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update POS_NhapHang_H Set MaPhieuNhapHang=@MaPhieuNhapHang, ID_Kiemke=@ID_Kiemke, ID_CuaHang=@ID_CuaHang, ID_Kho=@ID_Kho, ID_KhoXuat=@ID_KhoXuat, ID_KhachHang=@ID_KhachHang, ID_NhaCungCap=@ID_NhaCungCap, ID_LoaiNhap=@ID_LoaiNhap, NgayNhapHang=@NgayNhapHang, GhiChu=@GhiChu, SoLuong=@SoLuong, ThanhTien=@ThanhTien, ID_TrangThaiPhieu=@ID_TrangThaiPhieu, CreatedTime=@CreatedTime, CreatedBy=@CreatedBy, ModifiedTime=@ModifiedTime, ModifiedBy=@ModifiedBy Where ID_PhieuNhapHang_H=@ID_PhieuNhapHang_H"
			};
			command.Parameters.Add("ID_PhieuNhapHang_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUNHAPHANG_H);
			if (ob.MAPHIEUNHAPHANG.Trim() == "")
				command.Parameters.Add("MaPhieuNhapHang", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaPhieuNhapHang", SqlDbType.VarChar).Value = ob.MAPHIEUNHAPHANG;
			command.Parameters.Add("ID_Kiemke", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KIEMKE);
			command.Parameters.Add("ID_CuaHang", SqlDbType.Int).Value = ob.ID_CUAHANG;
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			command.Parameters.Add("ID_KhoXuat", SqlDbType.Int).Value = ob.ID_KHOXUAT;
			command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KHACHHANG);
			command.Parameters.Add("ID_NhaCungCap", SqlDbType.Int).Value = ob.ID_NHACUNGCAP;
			command.Parameters.Add("ID_LoaiNhap", SqlDbType.Int).Value = ob.ID_LOAINHAP;
			if (ob.NGAYNHAPHANG == DateTime.MinValue)
				command.Parameters.Add("NgayNhapHang", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayNhapHang", SqlDbType.DateTime).Value = ob.NGAYNHAPHANG;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			command.Parameters.Add("SoLuong", SqlDbType.Int).Value = ob.SOLUONG;
			command.Parameters.Add("ThanhTien", SqlDbType.Money).Value = ob.THANHTIEN;
			command.Parameters.Add("ID_TrangThaiPhieu", SqlDbType.Int).Value = ob.ID_TRANGTHAIPHIEU;
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
		public bool _DeleteOb(Ob_POS_NhapHang_H ob, SqlConnection conn)
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
				CommandText = @"Delete From POS_NhapHang_H Where ID_PhieuNhapHang_H=@ID_PhieuNhapHang_H"
			};
				command.Parameters.Add(new SqlParameter("ID_PhieuNhapHang_H", ob.ID_PHIEUNHAPHANG_H));
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
				CommandText = "Delete From POS_NhapHang_H Where " + condition
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
				CommandText = "Select * From POS_NhapHang_H Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From POS_NhapHang_H"
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
				CommandText = "Select Count(" + nameColumn + ") From POS_NhapHang_H Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From POS_NhapHang_H"
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
					CommandText = "Select Min(" + nameColumn + ") From POS_NhapHang_H Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from POS_NhapHang_H"
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
					CommandText = "Select Max(" + nameColumn + ") From POS_NhapHang_H Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_NhapHang_H"
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_NhapHang_H Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From POS_NhapHang_H"
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

