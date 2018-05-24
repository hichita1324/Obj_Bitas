using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 22/04/2016 14:13:22.PM

namespace Bitas
{
	public class Ob_KH_PhieuNhap_L
	{
		private string id_phieunhap_l;
		private string id_phieunhap_h;
		private int id_barcode;
		private string masanpham;
		private string tenmau;
		private string size;
		private int soluongnhap;
		private double dongia;
		private double thanhtien;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_PHIEUNHAP_L{ get { return id_phieunhap_l; } set { id_phieunhap_l = value; }}
		public string ID_PHIEUNHAP_H{ get { return id_phieunhap_h; } set { id_phieunhap_h = value; }}
		public int ID_BARCODE{ get { return id_barcode; } set { id_barcode = value; }}
		public string MASANPHAM{ get { return masanpham; } set { masanpham = value; }}
		public string TENMAU{ get { return tenmau; } set { tenmau = value; }}
		public string SIZE{ get { return size; } set { size = value; }}
		public int SOLUONGNHAP{ get { return soluongnhap; } set { soluongnhap = value; }}
		public double DONGIA{ get { return dongia; } set { dongia = value; }}
		public double THANHTIEN{ get { return thanhtien; } set { thanhtien = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_PhieuNhap_L()
		{
			id_phieunhap_l = "";
			id_phieunhap_h = "";
			id_barcode = 0;
			masanpham = "";
			tenmau = "";
			size = "";
			soluongnhap = 0;
			dongia = 0;
			thanhtien = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_PhieuNhap_L( string new_id_phieunhap_l, string new_id_phieunhap_h, int new_id_barcode, string new_masanpham, string new_tenmau, string new_size, int new_soluongnhap, double new_dongia, double new_thanhtien, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_phieunhap_l = new_id_phieunhap_l;
			id_phieunhap_h = new_id_phieunhap_h;
			id_barcode = new_id_barcode;
			masanpham = new_masanpham;
			tenmau = new_tenmau;
			size = new_size;
			soluongnhap = new_soluongnhap;
			dongia = new_dongia;
			thanhtien = new_thanhtien;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_PhieuNhap_L(Ob_KH_PhieuNhap_L newOb)
		{
			id_phieunhap_l = newOb.ID_PHIEUNHAP_L;
			id_phieunhap_h = newOb.ID_PHIEUNHAP_H;
			id_barcode = newOb.ID_BARCODE;
			masanpham = newOb.MASANPHAM;
			tenmau = newOb.TENMAU;
			size = newOb.SIZE;
			soluongnhap = newOb.SOLUONGNHAP;
			dongia = newOb.DONGIA;
			thanhtien = newOb.THANHTIEN;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
