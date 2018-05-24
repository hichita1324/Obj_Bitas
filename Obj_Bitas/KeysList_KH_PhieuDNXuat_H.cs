using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

//CreateTimes : 25/07/2016 14:08:31.PM

namespace Bitas
{
	public class KeysList_KH_PhieuDNXuat_H
	{
		//ListAll
		public List<Ob_KH_PhieuDNXuat_H> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_KH_PhieuDNXuat_H> list = new List<Ob_KH_PhieuDNXuat_H>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_PhieuDN_H, MaPhieuDN, ID_PhieuYC_H, ID_Kho, NgayTao, NgayXuat, ID_KhachHang, CongNoThucTe, TongTien, TongSoLuong, PhiHoTro, PT_CKLHKD, CKLHKD, CPVanChuyen, TraHang, GhiChu, Khoa, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From KH_PhieuDNXuat_H"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_KH_PhieuDNXuat_H ob = new Ob_KH_PhieuDNXuat_H();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUDN_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUDN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_PHIEUYC_H = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.NGAYTAO = Convert.ToDateTime(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.NGAYXUAT = Convert.ToDateTime(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.CONGNOTHUCTE = Convert.ToDecimal(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.TONGTIEN = Convert.ToDecimal(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TONGSOLUONG = Convert.ToInt32(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.PHIHOTRO = Convert.ToDecimal(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.PT_CKLHKD = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.CKLHKD = Convert.ToDecimal(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CPVANCHUYEN = Convert.ToDecimal(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.TRAHANG = Convert.ToBoolean(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.KHOA = Convert.ToBoolean(reader[16]);}
				if(reader[17] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[17]);}
				if(reader[18] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[18]);}
				if(reader[19] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[19]);}
				if(reader[20] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[20]);}
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
		public List<Ob_KH_PhieuDNXuat_H> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_KH_PhieuDNXuat_H> list = new List<Ob_KH_PhieuDNXuat_H>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_KH_PhieuDNXuat_H ob = new Ob_KH_PhieuDNXuat_H();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUDN_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUDN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_PHIEUYC_H = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.NGAYTAO = Convert.ToDateTime(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.NGAYXUAT = Convert.ToDateTime(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.CONGNOTHUCTE = Convert.ToDecimal(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.TONGTIEN = Convert.ToDecimal(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TONGSOLUONG = Convert.ToInt32(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.PHIHOTRO = Convert.ToDecimal(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.PT_CKLHKD = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.CKLHKD = Convert.ToDecimal(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CPVANCHUYEN = Convert.ToDecimal(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.TRAHANG = Convert.ToBoolean(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.KHOA = Convert.ToBoolean(reader[16]);}
				if(reader[17] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[17]);}
				if(reader[18] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[18]);}
				if(reader[19] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[19]);}
				if(reader[20] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[20]);}
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
		public List<Ob_KH_PhieuDNXuat_H> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_KH_PhieuDNXuat_H> list = new List<Ob_KH_PhieuDNXuat_H>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_PhieuDN_H, MaPhieuDN, ID_PhieuYC_H, ID_Kho, NgayTao, NgayXuat, ID_KhachHang, CongNoThucTe, TongTien, TongSoLuong, PhiHoTro, PT_CKLHKD, CKLHKD, CPVanChuyen, TraHang, GhiChu, Khoa, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From KH_PhieuDNXuat_H Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_KH_PhieuDNXuat_H ob = new Ob_KH_PhieuDNXuat_H();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUDN_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUDN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_PHIEUYC_H = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.NGAYTAO = Convert.ToDateTime(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.NGAYXUAT = Convert.ToDateTime(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.CONGNOTHUCTE = Convert.ToDecimal(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.TONGTIEN = Convert.ToDecimal(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TONGSOLUONG = Convert.ToInt32(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.PHIHOTRO = Convert.ToDecimal(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.PT_CKLHKD = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.CKLHKD = Convert.ToDecimal(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CPVANCHUYEN = Convert.ToDecimal(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.TRAHANG = Convert.ToBoolean(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.KHOA = Convert.ToBoolean(reader[16]);}
				if(reader[17] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[17]);}
				if(reader[18] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[18]);}
				if(reader[19] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[19]);}
				if(reader[20] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[20]);}
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
		public List<Ob_KH_PhieuDNXuat_H> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_KH_PhieuDNXuat_H> list = new List<Ob_KH_PhieuDNXuat_H>();
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
				Ob_KH_PhieuDNXuat_H ob = new Ob_KH_PhieuDNXuat_H();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUDN_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUDN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_PHIEUYC_H = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.NGAYTAO = Convert.ToDateTime(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.NGAYXUAT = Convert.ToDateTime(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.CONGNOTHUCTE = Convert.ToDecimal(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.TONGTIEN = Convert.ToDecimal(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TONGSOLUONG = Convert.ToInt32(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.PHIHOTRO = Convert.ToDecimal(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.PT_CKLHKD = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.CKLHKD = Convert.ToDecimal(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CPVANCHUYEN = Convert.ToDecimal(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.TRAHANG = Convert.ToBoolean(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.KHOA = Convert.ToBoolean(reader[16]);}
				if(reader[17] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[17]);}
				if(reader[18] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[18]);}
				if(reader[19] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[19]);}
				if(reader[20] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[20]);}
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
		public Ob_KH_PhieuDNXuat_H _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_KH_PhieuDNXuat_H ob = new Ob_KH_PhieuDNXuat_H();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_PhieuDN_H, MaPhieuDN, ID_PhieuYC_H, ID_Kho, NgayTao, NgayXuat, ID_KhachHang, CongNoThucTe, TongTien, TongSoLuong, PhiHoTro, PT_CKLHKD, CKLHKD, CPVanChuyen, TraHang, GhiChu, Khoa, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From KH_PhieuDNXuat_H Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUDN_H = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAPHIEUDN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_PHIEUYC_H = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_KHO = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.NGAYTAO = Convert.ToDateTime(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.NGAYXUAT = Convert.ToDateTime(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_KHACHHANG = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.CONGNOTHUCTE = Convert.ToDecimal(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.TONGTIEN = Convert.ToDecimal(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.TONGSOLUONG = Convert.ToInt32(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.PHIHOTRO = Convert.ToDecimal(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.PT_CKLHKD = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.CKLHKD = Convert.ToDecimal(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CPVANCHUYEN = Convert.ToDecimal(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.TRAHANG = Convert.ToBoolean(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.GHICHU = Convert.ToString(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.KHOA = Convert.ToBoolean(reader[16]);}
				if(reader[17] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[17]);}
				if(reader[18] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[18]);}
				if(reader[19] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[19]);}
				if(reader[20] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[20]);}
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
		public bool _InsertOb(Ob_KH_PhieuDNXuat_H ob, SqlConnection conn)
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
				CommandText = @"Insert Into KH_PhieuDNXuat_H (ID_PhieuDN_H, MaPhieuDN, ID_PhieuYC_H, ID_Kho, NgayTao, NgayXuat, ID_KhachHang, CongNoThucTe, TongTien, TongSoLuong, PhiHoTro, PT_CKLHKD, CKLHKD, CPVanChuyen, TraHang, GhiChu, Khoa, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy) Values(@ID_PhieuDN_H, @MaPhieuDN, @ID_PhieuYC_H, @ID_Kho, @NgayTao, @NgayXuat, @ID_KhachHang, @CongNoThucTe, @TongTien, @TongSoLuong, @PhiHoTro, @PT_CKLHKD, @CKLHKD, @CPVanChuyen, @TraHang, @GhiChu, @Khoa, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedBy)"
			};
			if (ob.ID_PHIEUDN_H.Trim() == "")
				command.Parameters.Add("ID_PhieuDN_H", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_PhieuDN_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUDN_H);
			if (ob.MAPHIEUDN.Trim() == "")
				command.Parameters.Add("MaPhieuDN", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaPhieuDN", SqlDbType.VarChar).Value = ob.MAPHIEUDN;
			if (ob.ID_PHIEUYC_H.Trim() == "")
				command.Parameters.Add("ID_PhieuYC_H", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_PhieuYC_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUYC_H);
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			if (ob.NGAYTAO == DateTime.MinValue)
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = ob.NGAYTAO;
			if (ob.NGAYXUAT == DateTime.MinValue)
				command.Parameters.Add("NgayXuat", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayXuat", SqlDbType.DateTime).Value = ob.NGAYXUAT;
			if (ob.ID_KHACHHANG.Trim() == "")
				command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KHACHHANG);
			command.Parameters.Add("CongNoThucTe", SqlDbType.Money).Value = ob.CONGNOTHUCTE;
			command.Parameters.Add("TongTien", SqlDbType.Money).Value = ob.TONGTIEN;
			command.Parameters.Add("TongSoLuong", SqlDbType.Int).Value = ob.TONGSOLUONG;
			command.Parameters.Add("PhiHoTro", SqlDbType.Money).Value = ob.PHIHOTRO;
			command.Parameters.Add("PT_CKLHKD", SqlDbType.Float).Value = ob.PT_CKLHKD;
			command.Parameters.Add("CKLHKD", SqlDbType.Money).Value = ob.CKLHKD;
			command.Parameters.Add("CPVanChuyen", SqlDbType.Money).Value = ob.CPVANCHUYEN;
			command.Parameters.Add("TraHang", SqlDbType.Bit).Value = ob.TRAHANG;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			command.Parameters.Add("Khoa", SqlDbType.Bit).Value = ob.KHOA;
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
		public int _InsertObGetId(Ob_KH_PhieuDNXuat_H ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into KH_PhieuDNXuat_H (ID_PhieuDN_H, MaPhieuDN, ID_PhieuYC_H, ID_Kho, NgayTao, NgayXuat, ID_KhachHang, CongNoThucTe, TongTien, TongSoLuong, PhiHoTro, PT_CKLHKD, CKLHKD, CPVanChuyen, TraHang, GhiChu, Khoa, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy) Values(@ID_PhieuDN_H, @MaPhieuDN, @ID_PhieuYC_H, @ID_Kho, @NgayTao, @NgayXuat, @ID_KhachHang, @CongNoThucTe, @TongTien, @TongSoLuong, @PhiHoTro, @PT_CKLHKD, @CKLHKD, @CPVanChuyen, @TraHang, @GhiChu, @Khoa, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedBy)Select @@IDENTITY"
			};
			if (ob.ID_PHIEUDN_H.Trim() == "")
				command.Parameters.Add("ID_PhieuDN_H", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_PhieuDN_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUDN_H);
			if (ob.MAPHIEUDN.Trim() == "")
				command.Parameters.Add("MaPhieuDN", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaPhieuDN", SqlDbType.VarChar).Value = ob.MAPHIEUDN;
			if (ob.ID_PHIEUYC_H.Trim() == "")
				command.Parameters.Add("ID_PhieuYC_H", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_PhieuYC_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUYC_H);
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			if (ob.NGAYTAO == DateTime.MinValue)
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = ob.NGAYTAO;
			if (ob.NGAYXUAT == DateTime.MinValue)
				command.Parameters.Add("NgayXuat", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayXuat", SqlDbType.DateTime).Value = ob.NGAYXUAT;
			if (ob.ID_KHACHHANG.Trim() == "")
				command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KHACHHANG);
			command.Parameters.Add("CongNoThucTe", SqlDbType.Money).Value = ob.CONGNOTHUCTE;
			command.Parameters.Add("TongTien", SqlDbType.Money).Value = ob.TONGTIEN;
			command.Parameters.Add("TongSoLuong", SqlDbType.Int).Value = ob.TONGSOLUONG;
			command.Parameters.Add("PhiHoTro", SqlDbType.Money).Value = ob.PHIHOTRO;
			command.Parameters.Add("PT_CKLHKD", SqlDbType.Float).Value = ob.PT_CKLHKD;
			command.Parameters.Add("CKLHKD", SqlDbType.Money).Value = ob.CKLHKD;
			command.Parameters.Add("CPVanChuyen", SqlDbType.Money).Value = ob.CPVANCHUYEN;
			command.Parameters.Add("TraHang", SqlDbType.Bit).Value = ob.TRAHANG;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			command.Parameters.Add("Khoa", SqlDbType.Bit).Value = ob.KHOA;
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
		public bool _UpdateOb(Ob_KH_PhieuDNXuat_H ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update KH_PhieuDNXuat_H Set ID_PhieuDN_H=@ID_PhieuDN_H, MaPhieuDN=@MaPhieuDN, ID_PhieuYC_H=@ID_PhieuYC_H, ID_Kho=@ID_Kho, NgayTao=@NgayTao, NgayXuat=@NgayXuat, ID_KhachHang=@ID_KhachHang, CongNoThucTe=@CongNoThucTe, TongTien=@TongTien, TongSoLuong=@TongSoLuong, PhiHoTro=@PhiHoTro, PT_CKLHKD=@PT_CKLHKD, CKLHKD=@CKLHKD, CPVanChuyen=@CPVanChuyen, TraHang=@TraHang, GhiChu=@GhiChu, Khoa=@Khoa, ModifiedTime=@ModifiedTime, ModifiedBy=@ModifiedBy, CreatedTime=@CreatedTime, CreatedBy=@CreatedBy Where ID_PhieuDN_H=@ID_PhieuDN_H"
			};
			if (ob.ID_PHIEUDN_H.Trim() == "")
				command.Parameters.Add("ID_PhieuDN_H", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_PhieuDN_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUDN_H);
			if (ob.MAPHIEUDN.Trim() == "")
				command.Parameters.Add("MaPhieuDN", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaPhieuDN", SqlDbType.VarChar).Value = ob.MAPHIEUDN;
			if (ob.ID_PHIEUYC_H.Trim() == "")
				command.Parameters.Add("ID_PhieuYC_H", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_PhieuYC_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUYC_H);
			command.Parameters.Add("ID_Kho", SqlDbType.Int).Value = ob.ID_KHO;
			if (ob.NGAYTAO == DateTime.MinValue)
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayTao", SqlDbType.DateTime).Value = ob.NGAYTAO;
			if (ob.NGAYXUAT == DateTime.MinValue)
				command.Parameters.Add("NgayXuat", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayXuat", SqlDbType.DateTime).Value = ob.NGAYXUAT;
			if (ob.ID_KHACHHANG.Trim() == "")
				command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
			else
				command.Parameters.Add("ID_KhachHang", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_KHACHHANG);
			command.Parameters.Add("CongNoThucTe", SqlDbType.Money).Value = ob.CONGNOTHUCTE;
			command.Parameters.Add("TongTien", SqlDbType.Money).Value = ob.TONGTIEN;
			command.Parameters.Add("TongSoLuong", SqlDbType.Int).Value = ob.TONGSOLUONG;
			command.Parameters.Add("PhiHoTro", SqlDbType.Money).Value = ob.PHIHOTRO;
			command.Parameters.Add("PT_CKLHKD", SqlDbType.Float).Value = ob.PT_CKLHKD;
			command.Parameters.Add("CKLHKD", SqlDbType.Money).Value = ob.CKLHKD;
			command.Parameters.Add("CPVanChuyen", SqlDbType.Money).Value = ob.CPVANCHUYEN;
			command.Parameters.Add("TraHang", SqlDbType.Bit).Value = ob.TRAHANG;
			if (ob.GHICHU.Trim() == "")
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ob.GHICHU;
			command.Parameters.Add("Khoa", SqlDbType.Bit).Value = ob.KHOA;
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
		public bool _DeleteOb(Ob_KH_PhieuDNXuat_H ob, SqlConnection conn)
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
				CommandText = @"Delete From KH_PhieuDNXuat_H Where ID_PhieuDN_H=@ID_PhieuDN_H"
			};
				command.Parameters.Add(new SqlParameter("ID_PhieuDN_H", ob.ID_PHIEUDN_H));
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
				CommandText = "Delete From KH_PhieuDNXuat_H Where " + condition
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
				CommandText = "Select * From KH_PhieuDNXuat_H Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From KH_PhieuDNXuat_H"
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
				CommandText = "Select Count(" + nameColumn + ") From KH_PhieuDNXuat_H Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From KH_PhieuDNXuat_H"
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
					CommandText = "Select Min(" + nameColumn + ") From KH_PhieuDNXuat_H Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from KH_PhieuDNXuat_H"
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
					CommandText = "Select Max(" + nameColumn + ") From KH_PhieuDNXuat_H Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From KH_PhieuDNXuat_H"
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
					CommandText = "Select Sum(" + nameColumn + ") From KH_PhieuDNXuat_H Where " + keyword +""
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

