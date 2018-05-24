using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

//CreateTimes : 18/05/2018 15:18:09.PM

namespace Bitas
{
	public class KeysList_POS_BanHang_L
	{
		private Guid ConvertGuid(string b)
		{
			Guid gu = Guid.Empty;
			string str = b;
			gu = new Guid(str);
			return gu;
		}
		//ListAll
		public List<Ob_POS_BanHang_L> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_BanHang_L> list = new List<Ob_POS_BanHang_L>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_PhieuBanHang_L, ID_PhieuBanHang_H, ID_Barcode, MaSanPham, TenMau, Size, DonGia, SoLuong, NguyenGia, PTGiamGia, GiamGiaPT, GiamGiaCoDinh, ThanhTien, ThucThu, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_BanHang_L"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_BanHang_L ob = new Ob_POS_BanHang_L();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUBANHANG_L = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_PHIEUBANHANG_H = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_BARCODE = Convert.ToInt64(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.MASANPHAM = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TENMAU = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.SIZE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DONGIA = Convert.ToDouble(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.NGUYENGIA = Convert.ToBoolean(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.PTGIAMGIA = Convert.ToDouble(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.GIAMGIACODINH = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.THANHTIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.THUCTHU = Convert.ToDouble(reader[13]);}
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
		public List<Ob_POS_BanHang_L> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_BanHang_L> list = new List<Ob_POS_BanHang_L>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_BanHang_L ob = new Ob_POS_BanHang_L();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUBANHANG_L = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_PHIEUBANHANG_H = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_BARCODE = Convert.ToInt64(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.MASANPHAM = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TENMAU = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.SIZE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DONGIA = Convert.ToDouble(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.NGUYENGIA = Convert.ToBoolean(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.PTGIAMGIA = Convert.ToDouble(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.GIAMGIACODINH = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.THANHTIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.THUCTHU = Convert.ToDouble(reader[13]);}
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
		public List<Ob_POS_BanHang_L> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_BanHang_L> list = new List<Ob_POS_BanHang_L>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_PhieuBanHang_L, ID_PhieuBanHang_H, ID_Barcode, MaSanPham, TenMau, Size, DonGia, SoLuong, NguyenGia, PTGiamGia, GiamGiaPT, GiamGiaCoDinh, ThanhTien, ThucThu, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_BanHang_L Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_BanHang_L ob = new Ob_POS_BanHang_L();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUBANHANG_L = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_PHIEUBANHANG_H = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_BARCODE = Convert.ToInt64(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.MASANPHAM = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TENMAU = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.SIZE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DONGIA = Convert.ToDouble(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.NGUYENGIA = Convert.ToBoolean(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.PTGIAMGIA = Convert.ToDouble(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.GIAMGIACODINH = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.THANHTIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.THUCTHU = Convert.ToDouble(reader[13]);}
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
		public List<Ob_POS_BanHang_L> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_BanHang_L> list = new List<Ob_POS_BanHang_L>();
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
				Ob_POS_BanHang_L ob = new Ob_POS_BanHang_L();
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUBANHANG_L = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_PHIEUBANHANG_H = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_BARCODE = Convert.ToInt64(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.MASANPHAM = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TENMAU = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.SIZE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DONGIA = Convert.ToDouble(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.NGUYENGIA = Convert.ToBoolean(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.PTGIAMGIA = Convert.ToDouble(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.GIAMGIACODINH = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.THANHTIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.THUCTHU = Convert.ToDouble(reader[13]);}
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
		public Ob_POS_BanHang_L _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_POS_BanHang_L ob = new Ob_POS_BanHang_L();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_PhieuBanHang_L, ID_PhieuBanHang_H, ID_Barcode, MaSanPham, TenMau, Size, DonGia, SoLuong, NguyenGia, PTGiamGia, GiamGiaPT, GiamGiaCoDinh, ThanhTien, ThucThu, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_BanHang_L Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_PHIEUBANHANG_L = Convert.ToString(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_PHIEUBANHANG_H = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.ID_BARCODE = Convert.ToInt64(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.MASANPHAM = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TENMAU = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.SIZE = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.DONGIA = Convert.ToDouble(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.NGUYENGIA = Convert.ToBoolean(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.PTGIAMGIA = Convert.ToDouble(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.GIAMGIACODINH = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.THANHTIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.THUCTHU = Convert.ToDouble(reader[13]);}
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
		public bool _InsertOb(Ob_POS_BanHang_L ob, SqlConnection conn)
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
				CommandText = @"Insert Into POS_BanHang_L (ID_PhieuBanHang_L, ID_PhieuBanHang_H, ID_Barcode, MaSanPham, TenMau, Size, DonGia, SoLuong, NguyenGia, PTGiamGia, GiamGiaPT, GiamGiaCoDinh, ThanhTien, ThucThu, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy) Values(@ID_PhieuBanHang_L, @ID_PhieuBanHang_H, @ID_Barcode, @MaSanPham, @TenMau, @Size, @DonGia, @SoLuong, @NguyenGia, @PTGiamGia, @GiamGiaPT, @GiamGiaCoDinh, @ThanhTien, @ThucThu, @CreatedTime, @CreatedBy, @ModifiedTime, @ModifiedBy)"
			};
			command.Parameters.Add("ID_PhieuBanHang_L", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUBANHANG_L);
			command.Parameters.Add("ID_PhieuBanHang_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUBANHANG_H);
			command.Parameters.Add("ID_Barcode", SqlDbType.BigInt).Value = ob.ID_BARCODE;
			if (ob.MASANPHAM.Trim() == "")
				command.Parameters.Add("MaSanPham", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaSanPham", SqlDbType.VarChar).Value = ob.MASANPHAM;
			if (ob.TENMAU.Trim() == "")
				command.Parameters.Add("TenMau", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenMau", SqlDbType.NVarChar).Value = ob.TENMAU;
			if (ob.SIZE.Trim() == "")
				command.Parameters.Add("Size", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Size", SqlDbType.VarChar).Value = ob.SIZE;
			command.Parameters.Add("DonGia", SqlDbType.Money).Value = ob.DONGIA;
			command.Parameters.Add("SoLuong", SqlDbType.Int).Value = ob.SOLUONG;
			command.Parameters.Add("NguyenGia", SqlDbType.Bit).Value = ob.NGUYENGIA;
			command.Parameters.Add("PTGiamGia", SqlDbType.Float).Value = ob.PTGIAMGIA;
			command.Parameters.Add("GiamGiaPT", SqlDbType.Money).Value = ob.GIAMGIAPT;
			command.Parameters.Add("GiamGiaCoDinh", SqlDbType.Money).Value = ob.GIAMGIACODINH;
			command.Parameters.Add("ThanhTien", SqlDbType.Money).Value = ob.THANHTIEN;
			command.Parameters.Add("ThucThu", SqlDbType.Money).Value = ob.THUCTHU;
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
		public int _InsertObGetId(Ob_POS_BanHang_L ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into POS_BanHang_L (ID_PhieuBanHang_L, ID_PhieuBanHang_H, ID_Barcode, MaSanPham, TenMau, Size, DonGia, SoLuong, NguyenGia, PTGiamGia, GiamGiaPT, GiamGiaCoDinh, ThanhTien, ThucThu, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy) Values(@ID_PhieuBanHang_L, @ID_PhieuBanHang_H, @ID_Barcode, @MaSanPham, @TenMau, @Size, @DonGia, @SoLuong, @NguyenGia, @PTGiamGia, @GiamGiaPT, @GiamGiaCoDinh, @ThanhTien, @ThucThu, @CreatedTime, @CreatedBy, @ModifiedTime, @ModifiedBy)Select @@IDENTITY"
			};
			command.Parameters.Add("ID_PhieuBanHang_L", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUBANHANG_L);
			command.Parameters.Add("ID_PhieuBanHang_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUBANHANG_H);
			command.Parameters.Add("ID_Barcode", SqlDbType.BigInt).Value = ob.ID_BARCODE;
			if (ob.MASANPHAM.Trim() == "")
				command.Parameters.Add("MaSanPham", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaSanPham", SqlDbType.VarChar).Value = ob.MASANPHAM;
			if (ob.TENMAU.Trim() == "")
				command.Parameters.Add("TenMau", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenMau", SqlDbType.NVarChar).Value = ob.TENMAU;
			if (ob.SIZE.Trim() == "")
				command.Parameters.Add("Size", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Size", SqlDbType.VarChar).Value = ob.SIZE;
			command.Parameters.Add("DonGia", SqlDbType.Money).Value = ob.DONGIA;
			command.Parameters.Add("SoLuong", SqlDbType.Int).Value = ob.SOLUONG;
			command.Parameters.Add("NguyenGia", SqlDbType.Bit).Value = ob.NGUYENGIA;
			command.Parameters.Add("PTGiamGia", SqlDbType.Float).Value = ob.PTGIAMGIA;
			command.Parameters.Add("GiamGiaPT", SqlDbType.Money).Value = ob.GIAMGIAPT;
			command.Parameters.Add("GiamGiaCoDinh", SqlDbType.Money).Value = ob.GIAMGIACODINH;
			command.Parameters.Add("ThanhTien", SqlDbType.Money).Value = ob.THANHTIEN;
			command.Parameters.Add("ThucThu", SqlDbType.Money).Value = ob.THUCTHU;
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
		public bool _UpdateOb(Ob_POS_BanHang_L ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update POS_BanHang_L Set ID_PhieuBanHang_H=@ID_PhieuBanHang_H, ID_Barcode=@ID_Barcode, MaSanPham=@MaSanPham, TenMau=@TenMau, Size=@Size, DonGia=@DonGia, SoLuong=@SoLuong, NguyenGia=@NguyenGia, PTGiamGia=@PTGiamGia, GiamGiaPT=@GiamGiaPT, GiamGiaCoDinh=@GiamGiaCoDinh, ThanhTien=@ThanhTien, ThucThu=@ThucThu, CreatedTime=@CreatedTime, CreatedBy=@CreatedBy, ModifiedTime=@ModifiedTime, ModifiedBy=@ModifiedBy Where ID_PhieuBanHang_L=@ID_PhieuBanHang_L"
			};
			command.Parameters.Add("ID_PhieuBanHang_L", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUBANHANG_L);
			command.Parameters.Add("ID_PhieuBanHang_H", SqlDbType.UniqueIdentifier).Value = new SqlGuid(ob.ID_PHIEUBANHANG_H);
			command.Parameters.Add("ID_Barcode", SqlDbType.BigInt).Value = ob.ID_BARCODE;
			if (ob.MASANPHAM.Trim() == "")
				command.Parameters.Add("MaSanPham", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaSanPham", SqlDbType.VarChar).Value = ob.MASANPHAM;
			if (ob.TENMAU.Trim() == "")
				command.Parameters.Add("TenMau", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenMau", SqlDbType.NVarChar).Value = ob.TENMAU;
			if (ob.SIZE.Trim() == "")
				command.Parameters.Add("Size", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("Size", SqlDbType.VarChar).Value = ob.SIZE;
			command.Parameters.Add("DonGia", SqlDbType.Money).Value = ob.DONGIA;
			command.Parameters.Add("SoLuong", SqlDbType.Int).Value = ob.SOLUONG;
			command.Parameters.Add("NguyenGia", SqlDbType.Bit).Value = ob.NGUYENGIA;
			command.Parameters.Add("PTGiamGia", SqlDbType.Float).Value = ob.PTGIAMGIA;
			command.Parameters.Add("GiamGiaPT", SqlDbType.Money).Value = ob.GIAMGIAPT;
			command.Parameters.Add("GiamGiaCoDinh", SqlDbType.Money).Value = ob.GIAMGIACODINH;
			command.Parameters.Add("ThanhTien", SqlDbType.Money).Value = ob.THANHTIEN;
			command.Parameters.Add("ThucThu", SqlDbType.Money).Value = ob.THUCTHU;
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
		public bool _DeleteOb(Ob_POS_BanHang_L ob, SqlConnection conn)
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
				CommandText = @"Delete From POS_BanHang_L Where ID_PhieuBanHang_L=@ID_PhieuBanHang_L"
			};
				command.Parameters.Add(new SqlParameter("ID_PhieuBanHang_L", ob.ID_PHIEUBANHANG_L));
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
				CommandText = "Delete From POS_BanHang_L Where " + condition
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
				CommandText = "Select * From POS_BanHang_L Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From POS_BanHang_L"
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
				CommandText = "Select Count(" + nameColumn + ") From POS_BanHang_L Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From POS_BanHang_L"
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
					CommandText = "Select Min(" + nameColumn + ") From POS_BanHang_L Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from POS_BanHang_L"
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
					CommandText = "Select Max(" + nameColumn + ") From POS_BanHang_L Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_BanHang_L"
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_BanHang_L Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From POS_BanHang_L"
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

