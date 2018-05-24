using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:44:12.AM

namespace Bitas
{
	public class Ob_DM_SanPham
	{
		private int id_sanpham;
		private string masanpham;
		private string tensanpham;
		private string mota;
		private int id_donvitinh;
		private int id_doituong;
		private int id_dongsp;
		private int id_loaihang;
		private int id_nhacungcap;
		private int id_bosuutap;
		private bool trangthai;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_SANPHAM{ get { return id_sanpham; } set { id_sanpham = value; }}
		public string MASANPHAM{ get { return masanpham; } set { masanpham = value; }}
		public string TENSANPHAM{ get { return tensanpham; } set { tensanpham = value; }}
		public string MOTA{ get { return mota; } set { mota = value; }}
		public int ID_DONVITINH{ get { return id_donvitinh; } set { id_donvitinh = value; }}
		public int ID_DOITUONG{ get { return id_doituong; } set { id_doituong = value; }}
		public int ID_DONGSP{ get { return id_dongsp; } set { id_dongsp = value; }}
		public int ID_LOAIHANG{ get { return id_loaihang; } set { id_loaihang = value; }}
		public int ID_NHACUNGCAP{ get { return id_nhacungcap; } set { id_nhacungcap = value; }}
		public int ID_BOSUUTAP{ get { return id_bosuutap; } set { id_bosuutap = value; }}
		public bool TRANGTHAI{ get { return trangthai; } set { trangthai = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_SanPham()
		{
			id_sanpham = 0;
			masanpham = "";
			tensanpham = "";
			mota = "";
			id_donvitinh = 0;
			id_doituong = 0;
			id_dongsp = 0;
			id_loaihang = 0;
			id_nhacungcap = 0;
			id_bosuutap = 0;
			trangthai = false;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_SanPham( int new_id_sanpham, string new_masanpham, string new_tensanpham, string new_mota, int new_id_donvitinh, int new_id_doituong, int new_id_dongsp, int new_id_loaihang, int new_id_nhacungcap, int new_id_bosuutap, bool new_trangthai, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_sanpham = new_id_sanpham;
			masanpham = new_masanpham;
			tensanpham = new_tensanpham;
			mota = new_mota;
			id_donvitinh = new_id_donvitinh;
			id_doituong = new_id_doituong;
			id_dongsp = new_id_dongsp;
			id_loaihang = new_id_loaihang;
			id_nhacungcap = new_id_nhacungcap;
			id_bosuutap = new_id_bosuutap;
			trangthai = new_trangthai;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_SanPham(Ob_DM_SanPham newOb)
		{
			id_sanpham = newOb.ID_SANPHAM;
			masanpham = newOb.MASANPHAM;
			tensanpham = newOb.TENSANPHAM;
			mota = newOb.MOTA;
			id_donvitinh = newOb.ID_DONVITINH;
			id_doituong = newOb.ID_DOITUONG;
			id_dongsp = newOb.ID_DONGSP;
			id_loaihang = newOb.ID_LOAIHANG;
			id_nhacungcap = newOb.ID_NHACUNGCAP;
			id_bosuutap = newOb.ID_BOSUUTAP;
			trangthai = newOb.TRANGTHAI;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
