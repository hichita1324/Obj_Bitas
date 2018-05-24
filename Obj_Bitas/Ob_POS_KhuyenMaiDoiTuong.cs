using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 06/03/2017 15:00:23.PM

namespace Bitas
{
	public class Ob_POS_KhuyenMaiDoiTuong
	{
		private long id_khuyenmaidoituong;
		private int id_khuyenmai;
		private int id_doituong;
		public long ID_KHUYENMAIDOITUONG{ get { return id_khuyenmaidoituong; } set { id_khuyenmaidoituong = value; }}
		public int ID_KHUYENMAI{ get { return id_khuyenmai; } set { id_khuyenmai = value; }}
		public int ID_DOITUONG{ get { return id_doituong; } set { id_doituong = value; }}

		public Ob_POS_KhuyenMaiDoiTuong()
		{
			id_khuyenmai = 0;
			id_doituong = 0;
		}

		public Ob_POS_KhuyenMaiDoiTuong( long new_id_khuyenmaidoituong, int new_id_khuyenmai, int new_id_doituong)	
		{
			id_khuyenmaidoituong = new_id_khuyenmaidoituong;
			id_khuyenmai = new_id_khuyenmai;
			id_doituong = new_id_doituong;
		}

		public Ob_POS_KhuyenMaiDoiTuong(Ob_POS_KhuyenMaiDoiTuong newOb)
		{
			id_khuyenmaidoituong = newOb.ID_KHUYENMAIDOITUONG;
			id_khuyenmai = newOb.ID_KHUYENMAI;
			id_doituong = newOb.ID_DOITUONG;
		}

	}
}
