using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//CreateTimes : 04/04/2016 10:44:31.AM

namespace Bitas
{
	public class KeysList_HT_LichSuDangNhap
	{
		//ListAll
		public List<Ob_HT_LichSuDangNhap> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_LichSuDangNhap> list = new List<Ob_HT_LichSuDangNhap>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_LichSu, TaiKhoan, LanDangNhapCuoi, TenMay, DiaChiMAC, DiaChiIP From HT_LichSuDangNhap"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_HT_LichSuDangNhap ob = new Ob_HT_LichSuDangNhap();
				if(reader[0] != DBNull.Value){ ob.ID_LICHSU = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TAIKHOAN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.LANDANGNHAPCUOI = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.TENMAY = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIACHIMAC = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.DIACHIIP = Convert.ToString(reader[5]);}
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
		public List<Ob_HT_LichSuDangNhap> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_LichSuDangNhap> list = new List<Ob_HT_LichSuDangNhap>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_HT_LichSuDangNhap ob = new Ob_HT_LichSuDangNhap();
				if(reader[0] != DBNull.Value){ ob.ID_LICHSU = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TAIKHOAN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.LANDANGNHAPCUOI = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.TENMAY = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIACHIMAC = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.DIACHIIP = Convert.ToString(reader[5]);}
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
		public List<Ob_HT_LichSuDangNhap> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_LichSuDangNhap> list = new List<Ob_HT_LichSuDangNhap>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_LichSu, TaiKhoan, LanDangNhapCuoi, TenMay, DiaChiMAC, DiaChiIP From HT_LichSuDangNhap Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_HT_LichSuDangNhap ob = new Ob_HT_LichSuDangNhap();
				if(reader[0] != DBNull.Value){ ob.ID_LICHSU = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TAIKHOAN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.LANDANGNHAPCUOI = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.TENMAY = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIACHIMAC = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.DIACHIIP = Convert.ToString(reader[5]);}
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
		public List<Ob_HT_LichSuDangNhap> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_HT_LichSuDangNhap> list = new List<Ob_HT_LichSuDangNhap>();
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
				Ob_HT_LichSuDangNhap ob = new Ob_HT_LichSuDangNhap();
				if(reader[0] != DBNull.Value){ ob.ID_LICHSU = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TAIKHOAN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.LANDANGNHAPCUOI = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.TENMAY = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIACHIMAC = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.DIACHIIP = Convert.ToString(reader[5]);}
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
		public Ob_HT_LichSuDangNhap _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_HT_LichSuDangNhap ob = new Ob_HT_LichSuDangNhap();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_LichSu, TaiKhoan, LanDangNhapCuoi, TenMay, DiaChiMAC, DiaChiIP From HT_LichSuDangNhap Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_LICHSU = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.TAIKHOAN = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.LANDANGNHAPCUOI = Convert.ToDateTime(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.TENMAY = Convert.ToString(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.DIACHIMAC = Convert.ToString(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.DIACHIIP = Convert.ToString(reader[5]);}
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
		public bool _InsertOb(Ob_HT_LichSuDangNhap ob, SqlConnection conn)
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
				CommandText = @"Insert Into HT_LichSuDangNhap (TaiKhoan, LanDangNhapCuoi, TenMay, DiaChiMAC, DiaChiIP) Values(@TaiKhoan, @LanDangNhapCuoi, @TenMay, @DiaChiMAC, @DiaChiIP)"
			};
			if (ob.TAIKHOAN.Trim() == "")
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value = ob.TAIKHOAN;
			if (ob.LANDANGNHAPCUOI == DateTime.MinValue)
				command.Parameters.Add("LanDangNhapCuoi", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("LanDangNhapCuoi", SqlDbType.DateTime).Value = ob.LANDANGNHAPCUOI;
			if (ob.TENMAY.Trim() == "")
				command.Parameters.Add("TenMay", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenMay", SqlDbType.NVarChar).Value = ob.TENMAY;
			if (ob.DIACHIMAC.Trim() == "")
				command.Parameters.Add("DiaChiMAC", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChiMAC", SqlDbType.VarChar).Value = ob.DIACHIMAC;
			if (ob.DIACHIIP.Trim() == "")
				command.Parameters.Add("DiaChiIP", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChiIP", SqlDbType.VarChar).Value = ob.DIACHIIP;
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
		public int _InsertObGetId(Ob_HT_LichSuDangNhap ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into HT_LichSuDangNhap (TaiKhoan, LanDangNhapCuoi, TenMay, DiaChiMAC, DiaChiIP) Values(@TaiKhoan, @LanDangNhapCuoi, @TenMay, @DiaChiMAC, @DiaChiIP)Select @@IDENTITY"
			};
			if (ob.TAIKHOAN.Trim() == "")
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value = ob.TAIKHOAN;
			if (ob.LANDANGNHAPCUOI == DateTime.MinValue)
				command.Parameters.Add("LanDangNhapCuoi", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("LanDangNhapCuoi", SqlDbType.DateTime).Value = ob.LANDANGNHAPCUOI;
			if (ob.TENMAY.Trim() == "")
				command.Parameters.Add("TenMay", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenMay", SqlDbType.NVarChar).Value = ob.TENMAY;
			if (ob.DIACHIMAC.Trim() == "")
				command.Parameters.Add("DiaChiMAC", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChiMAC", SqlDbType.VarChar).Value = ob.DIACHIMAC;
			if (ob.DIACHIIP.Trim() == "")
				command.Parameters.Add("DiaChiIP", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChiIP", SqlDbType.VarChar).Value = ob.DIACHIIP;
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
		public bool _UpdateOb(Ob_HT_LichSuDangNhap ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update HT_LichSuDangNhap Set TaiKhoan=@TaiKhoan, LanDangNhapCuoi=@LanDangNhapCuoi, TenMay=@TenMay, DiaChiMAC=@DiaChiMAC, DiaChiIP=@DiaChiIP Where ID_LichSu=@ID_LichSu"
			};
			command.Parameters.Add("ID_LichSu", SqlDbType.BigInt).Value = ob.ID_LICHSU;
			if (ob.TAIKHOAN.Trim() == "")
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TaiKhoan", SqlDbType.VarChar).Value = ob.TAIKHOAN;
			if (ob.LANDANGNHAPCUOI == DateTime.MinValue)
				command.Parameters.Add("LanDangNhapCuoi", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("LanDangNhapCuoi", SqlDbType.DateTime).Value = ob.LANDANGNHAPCUOI;
			if (ob.TENMAY.Trim() == "")
				command.Parameters.Add("TenMay", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenMay", SqlDbType.NVarChar).Value = ob.TENMAY;
			if (ob.DIACHIMAC.Trim() == "")
				command.Parameters.Add("DiaChiMAC", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChiMAC", SqlDbType.VarChar).Value = ob.DIACHIMAC;
			if (ob.DIACHIIP.Trim() == "")
				command.Parameters.Add("DiaChiIP", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("DiaChiIP", SqlDbType.VarChar).Value = ob.DIACHIIP;
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
		public bool _DeleteOb(Ob_HT_LichSuDangNhap ob, SqlConnection conn)
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
				CommandText = @"Delete From HT_LichSuDangNhap Where ID_LichSu=@ID_LichSu"
			};
				command.Parameters.Add(new SqlParameter("ID_LichSu", ob.ID_LICHSU));
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
				CommandText = "Delete From HT_LichSuDangNhap Where " + condition
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
				CommandText = "Select * From HT_LichSuDangNhap Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From HT_LichSuDangNhap"
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
				CommandText = "Select Count(" + nameColumn + ") From HT_LichSuDangNhap Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From HT_LichSuDangNhap"
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
					CommandText = "Select Min(" + nameColumn + ") From HT_LichSuDangNhap Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from HT_LichSuDangNhap"
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
					CommandText = "Select Max(" + nameColumn + ") From HT_LichSuDangNhap Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From HT_LichSuDangNhap"
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
					CommandText = "Select Sum(" + nameColumn + ") From HT_LichSuDangNhap Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From HT_LichSuDangNhap"
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

