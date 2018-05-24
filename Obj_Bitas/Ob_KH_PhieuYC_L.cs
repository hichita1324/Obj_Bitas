using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 14/10/2016 16:01:01.PM

namespace Bitas
{
	public class Ob_KH_PhieuYC_L
	{
		private string id_phieuyc_l;
		private string id_phieuyc_h;
		private long id_barcode;
		private string masanpham;
		private string tenmau;
		private string size;
		private int soluong;
		private int soluongdn;
		private double dongia;
		private double thanhtien;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_PHIEUYC_L{ get { return id_phieuyc_l; } set { id_phieuyc_l = value; }}
		public string ID_PHIEUYC_H{ get { return id_phieuyc_h; } set { id_phieuyc_h = value; }}
		public long ID_BARCODE{ get { return id_barcode; } set { id_barcode = value; }}
		public string MASANPHAM{ get { return masanpham; } set { masanpham = value; }}
		public string TENMAU{ get { return tenmau; } set { tenmau = value; }}
		public string SIZE{ get { return size; } set { size = value; }}
		public int SOLUONG{ get { return soluong; } set { soluong = value; }}
		public int SOLUONGDN{ get { return soluongdn; } set { soluongdn = value; }}
		public double DONGIA{ get { return dongia; } set { dongia = value; }}
		public double THANHTIEN{ get { return thanhtien; } set { thanhtien = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_PhieuYC_L()
		{
			id_phieuyc_l = "";
			id_phieuyc_h = "";
			masanpham = "";
			tenmau = "";
			size = "";
			soluong = 0;
			soluongdn = 0;
			dongia = 0;
			thanhtien = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_PhieuYC_L( string new_id_phieuyc_l, string new_id_phieuyc_h, long new_id_barcode, string new_masanpham, string new_tenmau, string new_size, int new_soluong, int new_soluongdn, double new_dongia, double new_thanhtien, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_phieuyc_l = new_id_phieuyc_l;
			id_phieuyc_h = new_id_phieuyc_h;
			id_barcode = new_id_barcode;
			masanpham = new_masanpham;
			tenmau = new_tenmau;
			size = new_size;
			soluong = new_soluong;
			soluongdn = new_soluongdn;
			dongia = new_dongia;
			thanhtien = new_thanhtien;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_PhieuYC_L(Ob_KH_PhieuYC_L newOb)
		{
			id_phieuyc_l = newOb.ID_PHIEUYC_L;
			id_phieuyc_h = newOb.ID_PHIEUYC_H;
			id_barcode = newOb.ID_BARCODE;
			masanpham = newOb.MASANPHAM;
			tenmau = newOb.TENMAU;
			size = newOb.SIZE;
			soluong = newOb.SOLUONG;
			soluongdn = newOb.SOLUONGDN;
			dongia = newOb.DONGIA;
			thanhtien = newOb.THANHTIEN;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
