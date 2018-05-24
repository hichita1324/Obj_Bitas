using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Bitas
{
    public class KeysList_Phanquyen
    {
        public Ob_Phanquyen _CheckQuyen(string Taikhoan, string Tenbang, SqlConnection conn)
        {
            if(conn.State != ConnectionState.Open)
                conn.Open();
            Ob_Phanquyen ob = new Ob_Phanquyen();
            SqlCommand command = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = @"SELECT MoTa,Xem,ThemMoi,Sua,Xoa,XuatBaoCao
                           FROM HT_PhanQuyenDuLieu a join HT_NguoiDung b on a.ID_NhomND = b.ID_NhomND
                           WHERE TaiKhoan = '" + Taikhoan + "' and TenBang = '"+ Tenbang +"'"
            };
            SqlDataReader reader = command.ExecuteReader();
            int num = 0;
            while (reader.Read())
            {
                num++;
                if (reader[0] != DBNull.Value) { ob.MOTA = Convert.ToString(reader[0]); }
                if (reader[1] != DBNull.Value) { ob.XEM = Convert.ToBoolean(reader[1]); }
                if (reader[2] != DBNull.Value) { ob.THEMMOI = Convert.ToBoolean(reader[2]); }
                if (reader[3] != DBNull.Value) { ob.SUA = Convert.ToBoolean(reader[3]); }
                if (reader[4] != DBNull.Value) { ob.XOA = Convert.ToBoolean(reader[4]); }
                if (reader[5] != DBNull.Value) { ob.XUATBAOCAO = Convert.ToBoolean(reader[5]); }
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
    }
}
