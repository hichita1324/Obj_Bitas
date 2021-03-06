using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

//CreateTimes : 17/03/2017 15:36:06.PM

namespace Bitas
{
	public class KeysList_POS_KhuyenMaiKhoangGiaSanPham
	{
		private Guid ConvertGuid(string b)
		{
			Guid gu = Guid.Empty;
			string str = b;
			gu = new Guid(str);
			return gu;
		}
		//ListAll
		public List<Ob_POS_KhuyenMaiKhoangGiaSanPham> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMaiKhoangGiaSanPham> list = new List<Ob_POS_KhuyenMaiKhoangGiaSanPham>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhoangGia, ID_KhuyenMai, TuGiaTri, DenGiaTri, GiamGiaPT, GiamGiaTien, ID_SanPham, SoLuong, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From POS_KhuyenMaiKhoangGiaSanPham"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_KhuyenMaiKhoangGiaSanPham ob = new Ob_POS_KhuyenMaiKhoangGiaSanPham();
				if(reader[0] != DBNull.Value){ ob.ID_KHOANGGIA = Convert.ToInt64(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TUGIATRI = Convert.ToDouble(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DENGIATRI = Convert.ToDouble(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GIAMGIATIEN = Convert.ToDouble(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_SANPHAM = Convert.ToInt64(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[11]);}
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
		public List<Ob_POS_KhuyenMaiKhoangGiaSanPham> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMaiKhoangGiaSanPham> list = new List<Ob_POS_KhuyenMaiKhoangGiaSanPham>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_KhuyenMaiKhoangGiaSanPham ob = new Ob_POS_KhuyenMaiKhoangGiaSanPham();
				if(reader[0] != DBNull.Value){ ob.ID_KHOANGGIA = Convert.ToInt64(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TUGIATRI = Convert.ToDouble(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DENGIATRI = Convert.ToDouble(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GIAMGIATIEN = Convert.ToDouble(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_SANPHAM = Convert.ToInt64(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[11]);}
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
		public List<Ob_POS_KhuyenMaiKhoangGiaSanPham> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMaiKhoangGiaSanPham> list = new List<Ob_POS_KhuyenMaiKhoangGiaSanPham>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhoangGia, ID_KhuyenMai, TuGiaTri, DenGiaTri, GiamGiaPT, GiamGiaTien, ID_SanPham, SoLuong, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From POS_KhuyenMaiKhoangGiaSanPham Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_POS_KhuyenMaiKhoangGiaSanPham ob = new Ob_POS_KhuyenMaiKhoangGiaSanPham();
				if(reader[0] != DBNull.Value){ ob.ID_KHOANGGIA = Convert.ToInt64(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TUGIATRI = Convert.ToDouble(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DENGIATRI = Convert.ToDouble(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GIAMGIATIEN = Convert.ToDouble(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_SANPHAM = Convert.ToInt64(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[11]);}
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
		public List<Ob_POS_KhuyenMaiKhoangGiaSanPham> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_POS_KhuyenMaiKhoangGiaSanPham> list = new List<Ob_POS_KhuyenMaiKhoangGiaSanPham>();
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
				Ob_POS_KhuyenMaiKhoangGiaSanPham ob = new Ob_POS_KhuyenMaiKhoangGiaSanPham();
				if(reader[0] != DBNull.Value){ ob.ID_KHOANGGIA = Convert.ToInt64(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TUGIATRI = Convert.ToDouble(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DENGIATRI = Convert.ToDouble(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GIAMGIATIEN = Convert.ToDouble(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_SANPHAM = Convert.ToInt64(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[11]);}
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
		public Ob_POS_KhuyenMaiKhoangGiaSanPham _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_POS_KhuyenMaiKhoangGiaSanPham ob = new Ob_POS_KhuyenMaiKhoangGiaSanPham();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_KhoangGia, ID_KhuyenMai, TuGiaTri, DenGiaTri, GiamGiaPT, GiamGiaTien, ID_SanPham, SoLuong, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy From POS_KhuyenMaiKhoangGiaSanPham Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_KHOANGGIA = Convert.ToInt64(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.ID_KHUYENMAI = Convert.ToInt32(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TUGIATRI = Convert.ToDouble(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.DENGIATRI = Convert.ToDouble(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.GIAMGIAPT = Convert.ToDouble(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.GIAMGIATIEN = Convert.ToDouble(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.ID_SANPHAM = Convert.ToInt64(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.SOLUONG = Convert.ToInt32(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[11]);}
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
		public bool _InsertOb(Ob_POS_KhuyenMaiKhoangGiaSanPham ob, SqlConnection conn)
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
				CommandText = @"Insert Into POS_KhuyenMaiKhoangGiaSanPham (ID_KhoangGia, ID_KhuyenMai, TuGiaTri, DenGiaTri, GiamGiaPT, GiamGiaTien, ID_SanPham, SoLuong, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy) Values(@ID_KhoangGia, @ID_KhuyenMai, @TuGiaTri, @DenGiaTri, @GiamGiaPT, @GiamGiaTien, @ID_SanPham, @SoLuong, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedBy)"
			};
			command.Parameters.Add("ID_KhoangGia", SqlDbType.BigInt).Value = ob.ID_KHOANGGIA;
			command.Parameters.Add("ID_KhuyenMai", SqlDbType.Int).Value = ob.ID_KHUYENMAI;
			command.Parameters.Add("TuGiaTri", SqlDbType.Money).Value = ob.TUGIATRI;
			command.Parameters.Add("DenGiaTri", SqlDbType.Money).Value = ob.DENGIATRI;
			command.Parameters.Add("GiamGiaPT", SqlDbType.Float).Value = ob.GIAMGIAPT;
			command.Parameters.Add("GiamGiaTien", SqlDbType.Money).Value = ob.GIAMGIATIEN;
			command.Parameters.Add("ID_SanPham", SqlDbType.BigInt).Value = ob.ID_SANPHAM;
			command.Parameters.Add("SoLuong", SqlDbType.Int).Value = ob.SOLUONG;
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
		public int _InsertObGetId(Ob_POS_KhuyenMaiKhoangGiaSanPham ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into POS_KhuyenMaiKhoangGiaSanPham (ID_KhoangGia, ID_KhuyenMai, TuGiaTri, DenGiaTri, GiamGiaPT, GiamGiaTien, ID_SanPham, SoLuong, ModifiedTime, ModifiedBy, CreatedTime, CreatedBy) Values(@ID_KhoangGia, @ID_KhuyenMai, @TuGiaTri, @DenGiaTri, @GiamGiaPT, @GiamGiaTien, @ID_SanPham, @SoLuong, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedBy)Select @@IDENTITY"
			};
			command.Parameters.Add("ID_KhoangGia", SqlDbType.BigInt).Value = ob.ID_KHOANGGIA;
			command.Parameters.Add("ID_KhuyenMai", SqlDbType.Int).Value = ob.ID_KHUYENMAI;
			command.Parameters.Add("TuGiaTri", SqlDbType.Money).Value = ob.TUGIATRI;
			command.Parameters.Add("DenGiaTri", SqlDbType.Money).Value = ob.DENGIATRI;
			command.Parameters.Add("GiamGiaPT", SqlDbType.Float).Value = ob.GIAMGIAPT;
			command.Parameters.Add("GiamGiaTien", SqlDbType.Money).Value = ob.GIAMGIATIEN;
			command.Parameters.Add("ID_SanPham", SqlDbType.BigInt).Value = ob.ID_SANPHAM;
			command.Parameters.Add("SoLuong", SqlDbType.Int).Value = ob.SOLUONG;
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
		public bool _UpdateOb(Ob_POS_KhuyenMaiKhoangGiaSanPham ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update POS_KhuyenMaiKhoangGiaSanPham Set ID_KhuyenMai=@ID_KhuyenMai, TuGiaTri=@TuGiaTri, DenGiaTri=@DenGiaTri, GiamGiaPT=@GiamGiaPT, GiamGiaTien=@GiamGiaTien, ID_SanPham=@ID_SanPham, SoLuong=@SoLuong, ModifiedTime=@ModifiedTime, ModifiedBy=@ModifiedBy, CreatedTime=@CreatedTime, CreatedBy=@CreatedBy Where ID_KhoangGia=@ID_KhoangGia"
			};
			command.Parameters.Add("ID_KhoangGia", SqlDbType.BigInt).Value = ob.ID_KHOANGGIA;
			command.Parameters.Add("ID_KhuyenMai", SqlDbType.Int).Value = ob.ID_KHUYENMAI;
			command.Parameters.Add("TuGiaTri", SqlDbType.Money).Value = ob.TUGIATRI;
			command.Parameters.Add("DenGiaTri", SqlDbType.Money).Value = ob.DENGIATRI;
			command.Parameters.Add("GiamGiaPT", SqlDbType.Float).Value = ob.GIAMGIAPT;
			command.Parameters.Add("GiamGiaTien", SqlDbType.Money).Value = ob.GIAMGIATIEN;
			command.Parameters.Add("ID_SanPham", SqlDbType.BigInt).Value = ob.ID_SANPHAM;
			command.Parameters.Add("SoLuong", SqlDbType.Int).Value = ob.SOLUONG;
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
		public bool _DeleteOb(Ob_POS_KhuyenMaiKhoangGiaSanPham ob, SqlConnection conn)
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
				CommandText = @"Delete From POS_KhuyenMaiKhoangGiaSanPham Where ID_KhoangGia=@ID_KhoangGia"
			};
				command.Parameters.Add(new SqlParameter("ID_KhoangGia", ob.ID_KHOANGGIA));
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
				CommandText = "Delete From POS_KhuyenMaiKhoangGiaSanPham Where " + condition
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
				CommandText = "Select * From POS_KhuyenMaiKhoangGiaSanPham Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From POS_KhuyenMaiKhoangGiaSanPham"
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
				CommandText = "Select Count(" + nameColumn + ") From POS_KhuyenMaiKhoangGiaSanPham Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From POS_KhuyenMaiKhoangGiaSanPham"
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
					CommandText = "Select Min(" + nameColumn + ") From POS_KhuyenMaiKhoangGiaSanPham Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from POS_KhuyenMaiKhoangGiaSanPham"
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
					CommandText = "Select Max(" + nameColumn + ") From POS_KhuyenMaiKhoangGiaSanPham Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_KhuyenMaiKhoangGiaSanPham"
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
					CommandText = "Select Sum(" + nameColumn + ") From POS_KhuyenMaiKhoangGiaSanPham Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From POS_KhuyenMaiKhoangGiaSanPham"
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

