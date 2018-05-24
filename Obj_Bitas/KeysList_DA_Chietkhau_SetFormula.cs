using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//CreateTimes : 06/04/2016 08:31:21.AM

namespace Bitas
{
	public class KeysList_DA_Chietkhau_SetFormula
	{
		//ListAll
		public List<Ob_DA_Chietkhau_SetFormula> _ListAll(SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DA_Chietkhau_SetFormula> list = new List<Ob_DA_Chietkhau_SetFormula>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID, PlanCode, STT, ID_ChietKhau, PT, InputFormula, stringFunction, visible, ModifiedTime, ModifiedBy, CreatedTime, CreatedDate From DA_Chietkhau_SetFormula"
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DA_Chietkhau_SetFormula ob = new Ob_DA_Chietkhau_SetFormula();
				if(reader[0] != DBNull.Value){ ob.ID = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.PLANCODE = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.STT = Convert.ToInt32(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CHIETKHAU = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.PT = Convert.ToDouble(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.INPUTFORMULA = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.STRINGFUNCTION = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.VISIBLE = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.CREATEDDATE = Convert.ToString(reader[11]);}
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
		public List<Ob_DA_Chietkhau_SetFormula> _ListAll_sp(string StoredName, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DA_Chietkhau_SetFormula> list = new List<Ob_DA_Chietkhau_SetFormula>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = StoredName
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DA_Chietkhau_SetFormula ob = new Ob_DA_Chietkhau_SetFormula();
				if(reader[0] != DBNull.Value){ ob.ID = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.PLANCODE = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.STT = Convert.ToInt32(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CHIETKHAU = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.PT = Convert.ToDouble(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.INPUTFORMULA = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.STRINGFUNCTION = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.VISIBLE = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.CREATEDDATE = Convert.ToString(reader[11]);}
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
		public List<Ob_DA_Chietkhau_SetFormula> _ListWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DA_Chietkhau_SetFormula> list = new List<Ob_DA_Chietkhau_SetFormula>();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID, PlanCode, STT, ID_ChietKhau, PT, InputFormula, stringFunction, visible, ModifiedTime, ModifiedBy, CreatedTime, CreatedDate From DA_Chietkhau_SetFormula Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Ob_DA_Chietkhau_SetFormula ob = new Ob_DA_Chietkhau_SetFormula();
				if(reader[0] != DBNull.Value){ ob.ID = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.PLANCODE = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.STT = Convert.ToInt32(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CHIETKHAU = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.PT = Convert.ToDouble(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.INPUTFORMULA = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.STRINGFUNCTION = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.VISIBLE = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.CREATEDDATE = Convert.ToString(reader[11]);}
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
		public List<Ob_DA_Chietkhau_SetFormula> _ListWhere_sp(string StoredName, SqlParameter[] ArrayParameter, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			List<Ob_DA_Chietkhau_SetFormula> list = new List<Ob_DA_Chietkhau_SetFormula>();
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
				Ob_DA_Chietkhau_SetFormula ob = new Ob_DA_Chietkhau_SetFormula();
				if(reader[0] != DBNull.Value){ ob.ID = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.PLANCODE = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.STT = Convert.ToInt32(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CHIETKHAU = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.PT = Convert.ToDouble(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.INPUTFORMULA = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.STRINGFUNCTION = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.VISIBLE = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.CREATEDDATE = Convert.ToString(reader[11]);}
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
		public Ob_DA_Chietkhau_SetFormula _GetObWhere(string keyword, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return null;
			}
			conn.Open();
			Ob_DA_Chietkhau_SetFormula ob = new Ob_DA_Chietkhau_SetFormula();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Select ID, PlanCode, STT, ID_ChietKhau, PT, InputFormula, stringFunction, visible, ModifiedTime, ModifiedBy, CreatedTime, CreatedDate From DA_Chietkhau_SetFormula Where "+ keyword +""
			};
			SqlDataReader reader = command.ExecuteReader();
			int num = 0;
			while (reader.Read())
			{
				num++;
				if(reader[0] != DBNull.Value){ ob.ID = Convert.ToInt32(reader[0]);}
				if(reader[1] != DBNull.Value){ ob.PLANCODE = Convert.ToString(reader[1]);}
				if(reader[2] != DBNull.Value){ ob.STT = Convert.ToInt32(reader[2]);}
				if(reader[3] != DBNull.Value){ ob.ID_CHIETKHAU = Convert.ToInt32(reader[3]);}
				if(reader[4] != DBNull.Value){ ob.PT = Convert.ToDouble(reader[4]);}
				if(reader[5] != DBNull.Value){ ob.INPUTFORMULA = Convert.ToString(reader[5]);}
				if(reader[6] != DBNull.Value){ ob.STRINGFUNCTION = Convert.ToString(reader[6]);}
				if(reader[7] != DBNull.Value){ ob.VISIBLE = Convert.ToBoolean(reader[7]);}
				if(reader[8] != DBNull.Value){ ob.MODIFIEDTIME = Convert.ToDateTime(reader[8]);}
				if(reader[9] != DBNull.Value){ ob.MODIFIEDBY = Convert.ToString(reader[9]);}
				if(reader[10] != DBNull.Value){ ob.CREATEDTIME = Convert.ToDateTime(reader[10]);}
				if(reader[11] != DBNull.Value){ ob.CREATEDDATE = Convert.ToString(reader[11]);}
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
		public bool _InsertOb(Ob_DA_Chietkhau_SetFormula ob, SqlConnection conn)
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
				CommandText = @"Insert Into DA_Chietkhau_SetFormula (PlanCode, STT, ID_ChietKhau, PT, InputFormula, stringFunction, visible, ModifiedTime, ModifiedBy, CreatedTime, CreatedDate) Values(@PlanCode, @STT, @ID_ChietKhau, @PT, @InputFormula, @stringFunction, @visible, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedDate)"
			};
			if (ob.PLANCODE.Trim() == "")
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value = ob.PLANCODE;
			command.Parameters.Add("STT", SqlDbType.Int).Value = ob.STT;
			command.Parameters.Add("ID_ChietKhau", SqlDbType.Int).Value = ob.ID_CHIETKHAU;
			command.Parameters.Add("PT", SqlDbType.Money).Value = ob.PT;
			if (ob.INPUTFORMULA.Trim() == "")
				command.Parameters.Add("InputFormula", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("InputFormula", SqlDbType.VarChar).Value = ob.INPUTFORMULA;
			if (ob.STRINGFUNCTION.Trim() == "")
				command.Parameters.Add("stringFunction", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("stringFunction", SqlDbType.VarChar).Value = ob.STRINGFUNCTION;
			command.Parameters.Add("visible", SqlDbType.Bit).Value = ob.VISIBLE;
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
			if (ob.CREATEDDATE.Trim() == "")
				command.Parameters.Add("CreatedDate", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("CreatedDate", SqlDbType.VarChar).Value = ob.CREATEDDATE;
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
		public int _InsertObGetId(Ob_DA_Chietkhau_SetFormula ob, SqlConnection conn)
		{
			int num = 0;
			if (conn.ConnectionString != "")
			{
			conn.Open();
			SqlCommand command = new SqlCommand
			{
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Insert Into DA_Chietkhau_SetFormula (PlanCode, STT, ID_ChietKhau, PT, InputFormula, stringFunction, visible, ModifiedTime, ModifiedBy, CreatedTime, CreatedDate) Values(@PlanCode, @STT, @ID_ChietKhau, @PT, @InputFormula, @stringFunction, @visible, @ModifiedTime, @ModifiedBy, @CreatedTime, @CreatedDate)Select @@IDENTITY"
			};
			if (ob.PLANCODE.Trim() == "")
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value = ob.PLANCODE;
			command.Parameters.Add("STT", SqlDbType.Int).Value = ob.STT;
			command.Parameters.Add("ID_ChietKhau", SqlDbType.Int).Value = ob.ID_CHIETKHAU;
			command.Parameters.Add("PT", SqlDbType.Money).Value = ob.PT;
			if (ob.INPUTFORMULA.Trim() == "")
				command.Parameters.Add("InputFormula", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("InputFormula", SqlDbType.VarChar).Value = ob.INPUTFORMULA;
			if (ob.STRINGFUNCTION.Trim() == "")
				command.Parameters.Add("stringFunction", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("stringFunction", SqlDbType.VarChar).Value = ob.STRINGFUNCTION;
			command.Parameters.Add("visible", SqlDbType.Bit).Value = ob.VISIBLE;
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
			if (ob.CREATEDDATE.Trim() == "")
				command.Parameters.Add("CreatedDate", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("CreatedDate", SqlDbType.VarChar).Value = ob.CREATEDDATE;
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
		public bool _UpdateOb(Ob_DA_Chietkhau_SetFormula ob, SqlConnection conn)
		{
			if (conn.ConnectionString == "")
			{
				return false;
			}
			conn.Open();
			SqlCommand command = new SqlCommand {
				Connection = conn,
				CommandType = CommandType.Text,
				CommandText = @"Update DA_Chietkhau_SetFormula Set PlanCode=@PlanCode, STT=@STT, ID_ChietKhau=@ID_ChietKhau, PT=@PT, InputFormula=@InputFormula, stringFunction=@stringFunction, visible=@visible, ModifiedTime=@ModifiedTime, ModifiedBy=@ModifiedBy, CreatedTime=@CreatedTime, CreatedDate=@CreatedDate Where ID=@ID"
			};
			command.Parameters.Add("ID", SqlDbType.Int).Value = ob.ID;
			if (ob.PLANCODE.Trim() == "")
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("PlanCode", SqlDbType.NVarChar).Value = ob.PLANCODE;
			command.Parameters.Add("STT", SqlDbType.Int).Value = ob.STT;
			command.Parameters.Add("ID_ChietKhau", SqlDbType.Int).Value = ob.ID_CHIETKHAU;
			command.Parameters.Add("PT", SqlDbType.Money).Value = ob.PT;
			if (ob.INPUTFORMULA.Trim() == "")
				command.Parameters.Add("InputFormula", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("InputFormula", SqlDbType.VarChar).Value = ob.INPUTFORMULA;
			if (ob.STRINGFUNCTION.Trim() == "")
				command.Parameters.Add("stringFunction", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("stringFunction", SqlDbType.VarChar).Value = ob.STRINGFUNCTION;
			command.Parameters.Add("visible", SqlDbType.Bit).Value = ob.VISIBLE;
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
			if (ob.CREATEDDATE.Trim() == "")
				command.Parameters.Add("CreatedDate", SqlDbType.VarChar).Value  = DBNull.Value;
			else
				command.Parameters.Add("CreatedDate", SqlDbType.VarChar).Value = ob.CREATEDDATE;
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
		public bool _DeleteOb(Ob_DA_Chietkhau_SetFormula ob, SqlConnection conn)
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
				CommandText = @"Delete From DA_Chietkhau_SetFormula Where ID=@ID"
			};
				command.Parameters.Add(new SqlParameter("ID", ob.ID));
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
				CommandText = "Delete From DA_Chietkhau_SetFormula Where " + condition
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
				CommandText = "Select * From DA_Chietkhau_SetFormula Where " + condition
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
				CommandText = "Select Count(" + nameColumn + ") From DA_Chietkhau_SetFormula"
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
				CommandText = "Select Count(" + nameColumn + ") From DA_Chietkhau_SetFormula Where " + keyword +""
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
					CommandText = "Select Min(" + nameColumn + ") From DA_Chietkhau_SetFormula"
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
					CommandText = "Select Min(" + nameColumn + ") From DA_Chietkhau_SetFormula Where " + keyword +""
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
					CommandText = "Select max(" + nameColumn + ") from DA_Chietkhau_SetFormula"
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
					CommandText = "Select Max(" + nameColumn + ") From DA_Chietkhau_SetFormula Where " + keyword +""
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
					CommandText = "Select Sum(" + nameColumn + ") From DA_Chietkhau_SetFormula"
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
					CommandText = "Select Sum(" + nameColumn + ") From DA_Chietkhau_SetFormula Where " + keyword +""
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
					CommandText = "Select isnull(max(cast(substring(" + ColumnName + ",5,10) as decimal)),0) From DA_Chietkhau_SetFormula"
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

