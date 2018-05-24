using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 23/11/2017 16:00:08.PM

namespace Bitas
{
	public class Ob_HT_NguoiDung_CuaHang
	{
		private int id_nguoidung;
		private int id_cuahang;
		public int ID_NGUOIDUNG{ get { return id_nguoidung; } set { id_nguoidung = value; }}
		public int ID_CUAHANG{ get { return id_cuahang; } set { id_cuahang = value; }}

		public Ob_HT_NguoiDung_CuaHang()
		{
			id_nguoidung = 0;
			id_cuahang = 0;
		}

		public Ob_HT_NguoiDung_CuaHang( int new_id_nguoidung, int new_id_cuahang)	
		{
			id_nguoidung = new_id_nguoidung;
			id_cuahang = new_id_cuahang;
		}

		public Ob_HT_NguoiDung_CuaHang(Ob_HT_NguoiDung_CuaHang newOb)
		{
			id_nguoidung = newOb.ID_NGUOIDUNG;
			id_cuahang = newOb.ID_CUAHANG;
		}

	}
}
