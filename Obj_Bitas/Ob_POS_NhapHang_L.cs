using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 18/06/2018 11:17:32.AM

namespace Bitas
{
	public class Ob_POS_NhapHang_L
	{
		private string id_phieunhaphang_l;
		private string id_phieunhaphang_h;
		private long id_barcode;
		private string masanpham;
		private string tenmau;
		private string size;
		private double dongia;
		private int soluong;
		private bool nguyengia;
		private double thanhtien;
		private DateTime createdtime;
		private string createdby;
		private DateTime modifiedtime;
		private string modifiedby;
		public string ID_PHIEUNHAPHANG_L{ get { return id_phieunhaphang_l; } set { id_phieunhaphang_l = value; }}
		public string ID_PHIEUNHAPHANG_H{ get { return id_phieunhaphang_h; } set { id_phieunhaphang_h = value; }}
		public long ID_BARCODE{ get { return id_barcode; } set { id_barcode = value; }}
		public string MASANPHAM{ get { return masanpham; } set { masanpham = value; }}
		public string TENMAU{ get { return tenmau; } set { tenmau = value; }}
		public string SIZE{ get { return size; } set { size = value; }}
		public double DONGIA{ get { return dongia; } set { dongia = value; }}
		public int SOLUONG{ get { return soluong; } set { soluong = value; }}
		public bool NGUYENGIA{ get { return nguyengia; } set { nguyengia = value; }}
		public double THANHTIEN{ get { return thanhtien; } set { thanhtien = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}

		public Ob_POS_NhapHang_L()
		{
			id_phieunhaphang_l = "";
			id_phieunhaphang_h = "";
			masanpham = "";
			tenmau = "";
			size = "";
			dongia = 0;
			soluong = 0;
			nguyengia = false;
			thanhtien = 0;
			createdtime = DateTime.MinValue;
			createdby = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
		}

		public Ob_POS_NhapHang_L( string new_id_phieunhaphang_l, string new_id_phieunhaphang_h, long new_id_barcode, string new_masanpham, string new_tenmau, string new_size, double new_dongia, int new_soluong, bool new_nguyengia, double new_thanhtien, DateTime new_createdtime, string new_createdby, DateTime new_modifiedtime, string new_modifiedby)	
		{
			id_phieunhaphang_l = new_id_phieunhaphang_l;
			id_phieunhaphang_h = new_id_phieunhaphang_h;
			id_barcode = new_id_barcode;
			masanpham = new_masanpham;
			tenmau = new_tenmau;
			size = new_size;
			dongia = new_dongia;
			soluong = new_soluong;
			nguyengia = new_nguyengia;
			thanhtien = new_thanhtien;
			createdtime = new_createdtime;
			createdby = new_createdby;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
		}

		public Ob_POS_NhapHang_L(Ob_POS_NhapHang_L newOb)
		{
			id_phieunhaphang_l = newOb.ID_PHIEUNHAPHANG_L;
			id_phieunhaphang_h = newOb.ID_PHIEUNHAPHANG_H;
			id_barcode = newOb.ID_BARCODE;
			masanpham = newOb.MASANPHAM;
			tenmau = newOb.TENMAU;
			size = newOb.SIZE;
			dongia = newOb.DONGIA;
			soluong = newOb.SOLUONG;
			nguyengia = newOb.NGUYENGIA;
			thanhtien = newOb.THANHTIEN;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
		}

	}
}
