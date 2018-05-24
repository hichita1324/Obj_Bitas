using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 13/03/2017 13:59:52.PM

namespace Bitas
{
	public class Ob_POS_KhuyenMaiCuaHang
	{
		private long id_khuyenmaicuahang;
		private int id_khuyenmai;
		private int id_cuahang;
		public long ID_KHUYENMAICUAHANG{ get { return id_khuyenmaicuahang; } set { id_khuyenmaicuahang = value; }}
		public int ID_KHUYENMAI{ get { return id_khuyenmai; } set { id_khuyenmai = value; }}
		public int ID_CUAHANG{ get { return id_cuahang; } set { id_cuahang = value; }}

		public Ob_POS_KhuyenMaiCuaHang()
		{
			id_khuyenmai = 0;
			id_cuahang = 0;
		}

		public Ob_POS_KhuyenMaiCuaHang( long new_id_khuyenmaicuahang, int new_id_khuyenmai, int new_id_cuahang)	
		{
			id_khuyenmaicuahang = new_id_khuyenmaicuahang;
			id_khuyenmai = new_id_khuyenmai;
			id_cuahang = new_id_cuahang;
		}

		public Ob_POS_KhuyenMaiCuaHang(Ob_POS_KhuyenMaiCuaHang newOb)
		{
			id_khuyenmaicuahang = newOb.ID_KHUYENMAICUAHANG;
			id_khuyenmai = newOb.ID_KHUYENMAI;
			id_cuahang = newOb.ID_CUAHANG;
		}

	}
}
