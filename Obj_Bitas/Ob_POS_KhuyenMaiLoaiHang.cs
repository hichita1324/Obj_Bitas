using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 07/03/2017 11:28:15.AM

namespace Bitas
{
	public class Ob_POS_KhuyenMaiLoaiHang
	{
		private long id_khuyenmailoaihang;
		private int id_khuyenmai;
		private int id_loaihang;
		public long ID_KHUYENMAILOAIHANG{ get { return id_khuyenmailoaihang; } set { id_khuyenmailoaihang = value; }}
		public int ID_KHUYENMAI{ get { return id_khuyenmai; } set { id_khuyenmai = value; }}
		public int ID_LOAIHANG{ get { return id_loaihang; } set { id_loaihang = value; }}

		public Ob_POS_KhuyenMaiLoaiHang()
		{
			id_khuyenmai = 0;
			id_loaihang = 0;
		}

		public Ob_POS_KhuyenMaiLoaiHang( long new_id_khuyenmailoaihang, int new_id_khuyenmai, int new_id_loaihang)	
		{
			id_khuyenmailoaihang = new_id_khuyenmailoaihang;
			id_khuyenmai = new_id_khuyenmai;
			id_loaihang = new_id_loaihang;
		}

		public Ob_POS_KhuyenMaiLoaiHang(Ob_POS_KhuyenMaiLoaiHang newOb)
		{
			id_khuyenmailoaihang = newOb.ID_KHUYENMAILOAIHANG;
			id_khuyenmai = newOb.ID_KHUYENMAI;
			id_loaihang = newOb.ID_LOAIHANG;
		}

	}
}
