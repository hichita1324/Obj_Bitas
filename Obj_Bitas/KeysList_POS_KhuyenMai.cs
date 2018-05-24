using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

//CreateTimes : 20/12/2017 10:37:35.AM

namespace Bitas
{
	public class KeysList_POS_KhuyenMai
	{
		private Guid ConvertGuid(string b)
		{
			Guid gu = Guid.Empty;
			string str = b;
			gu = new Guid(str);
			return gu;
		}
		//ListAll
		public List<Ob_POS_KhuyenMai> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMai> list = new List<Ob_POS_KhuyenMai>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhuyenMai, MaKhuyenMai, TenKhuyenMai, NgayBatDau, NgayKetThuc, KichHoat, StoredKhuyenMai, NguyenGia, GiamGia, GiamGiaTheoHoaDon, VatPhamTheoHoaDon, GiamGiaPT, GiamGiaTien, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_KhuyenMai"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_KhuyenMai ob = new Ob_POS_KhuyenMai();
				if(reader[0] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAKHUYENMAI = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENKHUYENMAI = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.NGAYBATDAU = Convert.ToDateTime(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.NGAYKETTHUC = Convert.ToDateTime(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.KICHHOAT = Convert.ToBoolean(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.STOREDKHUYENMAI = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.NGUYENGIA = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.GIAMGIA = Convert.ToBoolean(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.GIAMGIATHEOHOADON = Convert.ToInt32(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.VATPHAMTHEOHOADON = Convert.ToInt32(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.GIAMGIATIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[16]);}
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
		public List<Ob_POS_KhuyenMai> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMai> list = new List<Ob_POS_KhuyenMai>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_KhuyenMai ob = new Ob_POS_KhuyenMai();
				if(reader[0] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAKHUYENMAI = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENKHUYENMAI = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.NGAYBATDAU = Convert.ToDateTime(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.NGAYKETTHUC = Convert.ToDateTime(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.KICHHOAT = Convert.ToBoolean(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.STOREDKHUYENMAI = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.NGUYENGIA = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.GIAMGIA = Convert.ToBoolean(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.GIAMGIATHEOHOADON = Convert.ToInt32(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.VATPHAMTHEOHOADON = Convert.ToInt32(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.GIAMGIATIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[16]);}
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
		public List<Ob_POS_KhuyenMai> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMai> list = new List<Ob_POS_KhuyenMai>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhuyenMai, MaKhuyenMai, TenKhuyenMai, NgayBatDau, NgayKetThuc, KichHoat, StoredKhuyenMai, NguyenGia, GiamGia, GiamGiaTheoHoaDon, VatPhamTheoHoaDon, GiamGiaPT, GiamGiaTien, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_KhuyenMai Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_KhuyenMai ob = new Ob_POS_KhuyenMai();
				if(reader[0] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAKHUYENMAI = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENKHUYENMAI = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.NGAYBATDAU = Convert.ToDateTime(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.NGAYKETTHUC = Convert.ToDateTime(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.KICHHOAT = Convert.ToBoolean(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.STOREDKHUYENMAI = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.NGUYENGIA = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.GIAMGIA = Convert.ToBoolean(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.GIAMGIATHEOHOADON = Convert.ToInt32(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.VATPHAMTHEOHOADON = Convert.ToInt32(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.GIAMGIATIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[16]);}
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
		public List<Ob_POS_KhuyenMai> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMai> list = new List<Ob_POS_KhuyenMai>();
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
				Ob_POS_KhuyenMai ob = new Ob_POS_KhuyenMai();
				if(reader[0] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAKHUYENMAI = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENKHUYENMAI = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.NGAYBATDAU = Convert.ToDateTime(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.NGAYKETTHUC = Convert.ToDateTime(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.KICHHOAT = Convert.ToBoolean(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.STOREDKHUYENMAI = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.NGUYENGIA = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.GIAMGIA = Convert.ToBoolean(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.GIAMGIATHEOHOADON = Convert.ToInt32(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.VATPHAMTHEOHOADON = Convert.ToInt32(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.GIAMGIATIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[16]);}
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
		public Ob_POS_KhuyenMai _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_POS_KhuyenMai ob = new Ob_POS_KhuyenMai();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhuyenMai, MaKhuyenMai, TenKhuyenMai, NgayBatDau, NgayKetThuc, KichHoat, StoredKhuyenMai, NguyenGia, GiamGia, GiamGiaTheoHoaDon, VatPhamTheoHoaDon, GiamGiaPT, GiamGiaTien, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy From POS_KhuyenMai Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MAKHUYENMAI = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENKHUYENMAI = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.NGAYBATDAU = Convert.ToDateTime(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.NGAYKETTHUC = Convert.ToDateTime(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.KICHHOAT = Convert.ToBoolean(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.STOREDKHUYENMAI = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.NGUYENGIA = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.GIAMGIA = Convert.ToBoolean(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.GIAMGIATHEOHOADON = Convert.ToInt32(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.VATPHAMTHEOHOADON = Convert.ToInt32(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[11]);}
				if(reader[12] != DBNull.Value){ ob.GIAMGIATIEN = Convert.ToDouble(reader[12]);}
				if(reader[13] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[13]);}
				if(reader[14] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[14]);}
				if(reader[15] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[15]);}
				if(reader[16] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[16]);}
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
		public bool _InsertOb(Ob_POS_KhuyenMai ob, SqlConnection conn)
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
				CommandText = @"Insert Into POS_KhuyenMai (MaKhuyenMai, TenKhuyenMai, NgayBatDau, NgayKetThuc, KichHoat, StoredKhuyenMai, NguyenGia, GiamGia, GiamGiaTheoHoaDon, VatPhamTheoHoaDon, GiamGiaPT, GiamGiaTien, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy) Values(@MaKhuyenMai, @TenKhuyenMai, @NgayBatDau, @NgayKetThuc, @KichHoat, @StoredKhuyenMai, @NguyenGia, @GiamGia, @GiamGiaTheoHoaDon, @VatPhamTheoHoaDon, @GiamGiaPT, @GiamGiaTien, @CreatedTime, @CreatedBy, @ModifiedTime, @ModifiedBy)"
			};
			if (ob.MAKHUYENMAI.Trim() == "")
				command.Parameters.Add("MaKhuyenMai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaKhuyenMai", SqlDbType.VarChar).Value = ob.MAKHUYENMAI;
			if (ob.TENKHUYENMAI.Trim() == "")
				command.Parameters.Add("TenKhuyenMai", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenKhuyenMai", SqlDbType.NVarChar).Value = ob.TENKHUYENMAI;
			if (ob.NGAYBATDAU == DateTime.MinValue)
				command.Parameters.Add("NgayBatDau", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayBatDau", SqlDbType.DateTime).Value = ob.NGAYBATDAU;
			if (ob.NGAYKETTHUC == DateTime.MinValue)
				command.Parameters.Add("NgayKetThuc", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayKetThuc", SqlDbType.DateTime).Value = ob.NGAYKETTHUC;
			command.Parameters.Add("KichHoat", SqlDbType.Bit).Value = ob.KICHHOAT;
			if (ob.STOREDKHUYENMAI.Trim() == "")
				command.Parameters.Add("StoredKhuyenMai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("StoredKhuyenMai", SqlDbType.VarChar).Value = ob.STOREDKHUYENMAI;
			command.Parameters.Add("NguyenGia", SqlDbType.Bit).Value = ob.NGUYENGIA;
			command.Parameters.Add("GiamGia", SqlDbType.Bit).Value = ob.GIAMGIA;
			command.Parameters.Add("GiamGiaTheoHoaDon", SqlDbType.Int).Value = ob.GIAMGIATHEOHOADON;
			command.Parameters.Add("VatPhamTheoHoaDon", SqlDbType.Int).Value = ob.VATPHAMTHEOHOADON;
			command.Parameters.Add("GiamGiaPT", SqlDbType.Float).Value = ob.GIAMGIAPT;
			command.Parameters.Add("GiamGiaTien", SqlDbType.Money).Value = ob.GIAMGIATIEN;
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
		public int _InsertObGetId(Ob_POS_KhuyenMai ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into POS_KhuyenMai (MaKhuyenMai, TenKhuyenMai, NgayBatDau, NgayKetThuc, KichHoat, StoredKhuyenMai, NguyenGia, GiamGia, GiamGiaTheoHoaDon, VatPhamTheoHoaDon, GiamGiaPT, GiamGiaTien, CreatedTime, CreatedBy, ModifiedTime, ModifiedBy) Values(@MaKhuyenMai, @TenKhuyenMai, @NgayBatDau, @NgayKetThuc, @KichHoat, @StoredKhuyenMai, @NguyenGia, @GiamGia, @GiamGiaTheoHoaDon, @VatPhamTheoHoaDon, @GiamGiaPT, @GiamGiaTien, @CreatedTime, @CreatedBy, @ModifiedTime, @ModifiedBy)Select @@IDENTITY"
			};
			if (ob.MAKHUYENMAI.Trim() == "")
				command.Parameters.Add("MaKhuyenMai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaKhuyenMai", SqlDbType.VarChar).Value = ob.MAKHUYENMAI;
			if (ob.TENKHUYENMAI.Trim() == "")
				command.Parameters.Add("TenKhuyenMai", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenKhuyenMai", SqlDbType.NVarChar).Value = ob.TENKHUYENMAI;
			if (ob.NGAYBATDAU == DateTime.MinValue)
				command.Parameters.Add("NgayBatDau", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayBatDau", SqlDbType.DateTime).Value = ob.NGAYBATDAU;
			if (ob.NGAYKETTHUC == DateTime.MinValue)
				command.Parameters.Add("NgayKetThuc", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayKetThuc", SqlDbType.DateTime).Value = ob.NGAYKETTHUC;
			command.Parameters.Add("KichHoat", SqlDbType.Bit).Value = ob.KICHHOAT;
			if (ob.STOREDKHUYENMAI.Trim() == "")
				command.Parameters.Add("StoredKhuyenMai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("StoredKhuyenMai", SqlDbType.VarChar).Value = ob.STOREDKHUYENMAI;
			command.Parameters.Add("NguyenGia", SqlDbType.Bit).Value = ob.NGUYENGIA;
			command.Parameters.Add("GiamGia", SqlDbType.Bit).Value = ob.GIAMGIA;
			command.Parameters.Add("GiamGiaTheoHoaDon", SqlDbType.Int).Value = ob.GIAMGIATHEOHOADON;
			command.Parameters.Add("VatPhamTheoHoaDon", SqlDbType.Int).Value = ob.VATPHAMTHEOHOADON;
			command.Parameters.Add("GiamGiaPT", SqlDbType.Float).Value = ob.GIAMGIAPT;
			command.Parameters.Add("GiamGiaTien", SqlDbType.Money).Value = ob.GIAMGIATIEN;
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
		public bool _UpdateOb(Ob_POS_KhuyenMai ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update POS_KhuyenMai Set MaKhuyenMai=@MaKhuyenMai, TenKhuyenMai=@TenKhuyenMai, NgayBatDau=@NgayBatDau, NgayKetThuc=@NgayKetThuc, KichHoat=@KichHoat, StoredKhuyenMai=@StoredKhuyenMai, NguyenGia=@NguyenGia, GiamGia=@GiamGia, GiamGiaTheoHoaDon=@GiamGiaTheoHoaDon, VatPhamTheoHoaDon=@VatPhamTheoHoaDon, GiamGiaPT=@GiamGiaPT, GiamGiaTien=@GiamGiaTien, CreatedTime=@CreatedTime, CreatedBy=@CreatedBy, ModifiedTime=@ModifiedTime, ModifiedBy=@ModifiedBy Where ID_KhuyenMai=@ID_KhuyenMai"
			};
			command.Parameters.Add("ID_KhuyenMai", SqlDbType.Int).Value = ob.ID_KHUYENMAI;
			if (ob.MAKHUYENMAI.Trim() == "")
				command.Parameters.Add("MaKhuyenMai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaKhuyenMai", SqlDbType.VarChar).Value = ob.MAKHUYENMAI;
			if (ob.TENKHUYENMAI.Trim() == "")
				command.Parameters.Add("TenKhuyenMai", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenKhuyenMai", SqlDbType.NVarChar).Value = ob.TENKHUYENMAI;
			if (ob.NGAYBATDAU == DateTime.MinValue)
				command.Parameters.Add("NgayBatDau", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayBatDau", SqlDbType.DateTime).Value = ob.NGAYBATDAU;
			if (ob.NGAYKETTHUC == DateTime.MinValue)
				command.Parameters.Add("NgayKetThuc", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("NgayKetThuc", SqlDbType.DateTime).Value = ob.NGAYKETTHUC;
			command.Parameters.Add("KichHoat", SqlDbType.Bit).Value = ob.KICHHOAT;
			if (ob.STOREDKHUYENMAI.Trim() == "")
				command.Parameters.Add("StoredKhuyenMai", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("StoredKhuyenMai", SqlDbType.VarChar).Value = ob.STOREDKHUYENMAI;
			command.Parameters.Add("NguyenGia", SqlDbType.Bit).Value = ob.NGUYENGIA;
			command.Parameters.Add("GiamGia", SqlDbType.Bit).Value = ob.GIAMGIA;
			command.Parameters.Add("GiamGiaTheoHoaDon", SqlDbType.Int).Value = ob.GIAMGIATHEOHOADON;
			command.Parameters.Add("VatPhamTheoHoaDon", SqlDbType.Int).Value = ob.VATPHAMTHEOHOADON;
			command.Parameters.Add("GiamGiaPT", SqlDbType.Float).Value = ob.GIAMGIAPT;
			command.Parameters.Add("GiamGiaTien", SqlDbType.Money).Value = ob.GIAMGIATIEN;
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
		public bool _DeleteOb(Ob_POS_KhuyenMai ob, SqlConnection conn)
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
				CommandText = @"Delete From POS_KhuyenMai Where ID_KhuyenMai=@ID_KhuyenMai"
			};
				command.Parameters.Add(new SqlParameter("ID_KhuyenMai", ob.ID_KHUYENMAI));
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
				CommandText = "Delete From POS_KhuyenMai Where " + condition
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
				CommandText = "Select * From POS_KhuyenMai Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From POS_KhuyenMai"
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
				CommandText = "Select Count(" + nameColumn + ") From POS_KhuyenMai Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From POS_KhuyenMai"
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
					CommandText = "Select Min(" + nameColumn + ") From POS_KhuyenMai Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from POS_KhuyenMai"
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
					CommandText = "Select Max(" + nameColumn + ") From POS_KhuyenMai Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_KhuyenMai"
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_KhuyenMai Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From POS_KhuyenMai"
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

