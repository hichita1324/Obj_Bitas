using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//CreateTimes : 04/04/2016 10:36:38.AM

namespace Bitas
{
	public class KeysList_DM_BangGia
	{
		//ListAll
		public List<Ob_DM_BangGia> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_BangGia> list = new List<Ob_DM_BangGia>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_BangGia, MaBangGia, TenBangGia, ID_DonViTien, TrangThai, ModifiedDate, ModifiedBy, CreatedDate, CreatedBy From DM_BangGia"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DM_BangGia ob = new Ob_DM_BangGia();
				if(reader[0] != DBNull.Value){ ob.ID_BANGGIA = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MABANGGIA = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENBANGGIA = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_DONVITIEN = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TRANGTHAI = Convert.ToBoolean(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.MODIFIEDDATE = Convert.ToDateTime(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.CREATEDDATE = Convert.ToDateTime(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[8]);}
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
		public List<Ob_DM_BangGia> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_BangGia> list = new List<Ob_DM_BangGia>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DM_BangGia ob = new Ob_DM_BangGia();
				if(reader[0] != DBNull.Value){ ob.ID_BANGGIA = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MABANGGIA = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENBANGGIA = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_DONVITIEN = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TRANGTHAI = Convert.ToBoolean(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.MODIFIEDDATE = Convert.ToDateTime(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.CREATEDDATE = Convert.ToDateTime(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[8]);}
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
		public List<Ob_DM_BangGia> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_BangGia> list = new List<Ob_DM_BangGia>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_BangGia, MaBangGia, TenBangGia, ID_DonViTien, TrangThai, ModifiedDate, ModifiedBy, CreatedDate, CreatedBy From DM_BangGia Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DM_BangGia ob = new Ob_DM_BangGia();
				if(reader[0] != DBNull.Value){ ob.ID_BANGGIA = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MABANGGIA = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENBANGGIA = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_DONVITIEN = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TRANGTHAI = Convert.ToBoolean(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.MODIFIEDDATE = Convert.ToDateTime(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.CREATEDDATE = Convert.ToDateTime(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[8]);}
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
		public List<Ob_DM_BangGia> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DM_BangGia> list = new List<Ob_DM_BangGia>();
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
				Ob_DM_BangGia ob = new Ob_DM_BangGia();
				if(reader[0] != DBNull.Value){ ob.ID_BANGGIA = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MABANGGIA = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENBANGGIA = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_DONVITIEN = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TRANGTHAI = Convert.ToBoolean(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.MODIFIEDDATE = Convert.ToDateTime(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.CREATEDDATE = Convert.ToDateTime(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[8]);}
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
		public Ob_DM_BangGia _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_DM_BangGia ob = new Ob_DM_BangGia();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID_BangGia, MaBangGia, TenBangGia, ID_DonViTien, TrangThai, ModifiedDate, ModifiedBy, CreatedDate, CreatedBy From DM_BangGia Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID_BANGGIA = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.MABANGGIA = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.TENBANGGIA = Convert.ToString(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_DONVITIEN = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.TRANGTHAI = Convert.ToBoolean(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.MODIFIEDDATE = Convert.ToDateTime(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.CREATEDDATE = Convert.ToDateTime(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.CREATEDBY = Convert.ToString(reader[8]);}
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
		public bool _InsertOb(Ob_DM_BangGia ob, SqlConnection conn)
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
				CommandText = @"Insert Into DM_BangGia (ID_BangGia, MaBangGia, TenBangGia, ID_DonViTien, TrangThai, ModifiedDate, ModifiedBy, CreatedDate, CreatedBy) Values(@ID_BangGia, @MaBangGia, @TenBangGia, @ID_DonViTien, @TrangThai, @ModifiedDate, @ModifiedBy, @CreatedDate, @CreatedBy)"
			};
			command.Parameters.Add("ID_BangGia", SqlDbType.Int).Value = ob.ID_BANGGIA;
			if (ob.MABANGGIA.Trim() == "")
				command.Parameters.Add("MaBangGia", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaBangGia", SqlDbType.VarChar).Value = ob.MABANGGIA;
			if (ob.TENBANGGIA.Trim() == "")
				command.Parameters.Add("TenBangGia", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenBangGia", SqlDbType.NVarChar).Value = ob.TENBANGGIA;
			command.Parameters.Add("ID_DonViTien", SqlDbType.Int).Value = ob.ID_DONVITIEN;
			command.Parameters.Add("TrangThai", SqlDbType.Bit).Value = ob.TRANGTHAI;
			if (ob.MODIFIEDDATE == DateTime.MinValue)
				command.Parameters.Add("ModifiedDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("ModifiedDate", SqlDbType.DateTime).Value = ob.MODIFIEDDATE;
			if (ob.MODIFIEDBY.Trim() == "")
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value = ob.MODIFIEDBY;
			if (ob.CREATEDDATE == DateTime.MinValue)
				command.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = ob.CREATEDDATE;
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
		public int _InsertObGetId(Ob_DM_BangGia ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into DM_BangGia (ID_BangGia, MaBangGia, TenBangGia, ID_DonViTien, TrangThai, ModifiedDate, ModifiedBy, CreatedDate, CreatedBy) Values(@ID_BangGia, @MaBangGia, @TenBangGia, @ID_DonViTien, @TrangThai, @ModifiedDate, @ModifiedBy, @CreatedDate, @CreatedBy)Select @@IDENTITY"
			};
			command.Parameters.Add("ID_BangGia", SqlDbType.Int).Value = ob.ID_BANGGIA;
			if (ob.MABANGGIA.Trim() == "")
				command.Parameters.Add("MaBangGia", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaBangGia", SqlDbType.VarChar).Value = ob.MABANGGIA;
			if (ob.TENBANGGIA.Trim() == "")
				command.Parameters.Add("TenBangGia", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenBangGia", SqlDbType.NVarChar).Value = ob.TENBANGGIA;
			command.Parameters.Add("ID_DonViTien", SqlDbType.Int).Value = ob.ID_DONVITIEN;
			command.Parameters.Add("TrangThai", SqlDbType.Bit).Value = ob.TRANGTHAI;
			if (ob.MODIFIEDDATE == DateTime.MinValue)
				command.Parameters.Add("ModifiedDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("ModifiedDate", SqlDbType.DateTime).Value = ob.MODIFIEDDATE;
			if (ob.MODIFIEDBY.Trim() == "")
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value = ob.MODIFIEDBY;
			if (ob.CREATEDDATE == DateTime.MinValue)
				command.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = ob.CREATEDDATE;
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
		public bool _UpdateOb(Ob_DM_BangGia ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update DM_BangGia Set MaBangGia=@MaBangGia, TenBangGia=@TenBangGia, ID_DonViTien=@ID_DonViTien, TrangThai=@TrangThai, ModifiedDate=@ModifiedDate, ModifiedBy=@ModifiedBy, CreatedDate=@CreatedDate, CreatedBy=@CreatedBy Where ID_BangGia=@ID_BangGia"
			};
			command.Parameters.Add("ID_BangGia", SqlDbType.Int).Value = ob.ID_BANGGIA;
			if (ob.MABANGGIA.Trim() == "")
				command.Parameters.Add("MaBangGia", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("MaBangGia", SqlDbType.VarChar).Value = ob.MABANGGIA;
			if (ob.TENBANGGIA.Trim() == "")
				command.Parameters.Add("TenBangGia", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("TenBangGia", SqlDbType.NVarChar).Value = ob.TENBANGGIA;
			command.Parameters.Add("ID_DonViTien", SqlDbType.Int).Value = ob.ID_DONVITIEN;
			command.Parameters.Add("TrangThai", SqlDbType.Bit).Value = ob.TRANGTHAI;
			if (ob.MODIFIEDDATE == DateTime.MinValue)
				command.Parameters.Add("ModifiedDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("ModifiedDate", SqlDbType.DateTime).Value = ob.MODIFIEDDATE;
			if (ob.MODIFIEDBY.Trim() == "")
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("ModifiedBy", SqlDbType.VarChar).Value = ob.MODIFIEDBY;
			if (ob.CREATEDDATE == DateTime.MinValue)
				command.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = DBNull.Value;
			else
				command.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = ob.CREATEDDATE;
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
		public bool _DeleteOb(Ob_DM_BangGia ob, SqlConnection conn)
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
				CommandText = @"Delete From DM_BangGia Where ID_BangGia=@ID_BangGia"
			};
				command.Parameters.Add(new SqlParameter("ID_BangGia", ob.ID_BANGGIA));
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
				CommandText = "Delete From DM_BangGia Where " + condition
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
				CommandText = "Select * From DM_BangGia Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From DM_BangGia"
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
				CommandText = "Select Count(" + nameColumn + ") From DM_BangGia Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From DM_BangGia"
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
					CommandText = "Select Min(" + nameColumn + ") From DM_BangGia Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from DM_BangGia"
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
					CommandText = "Select Max(" + nameColumn + ") From DM_BangGia Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From DM_BangGia"
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
					CommandText = "Select Sum(" + nameColumn + ") From DM_BangGia Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From DM_BangGia"
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

