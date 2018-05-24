using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 10/11/2016 15:30:14.PM

namespace Bitas
{
	public class Ob_DH_DonHang_L
	{
		private string id_donhang_l;
		private string id_donhang_h;
		private long id_barcode;
		private string masanpham;
		private string tenmau;
		private string size;
		private long soluongdat;
		private double dongia;
		private double thanhtien;
		private double ptchietkhau;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_DONHANG_L{ get { return id_donhang_l; } set { id_donhang_l = value; }}
		public string ID_DONHANG_H{ get { return id_donhang_h; } set { id_donhang_h = value; }}
		public long ID_BARCODE{ get { return id_barcode; } set { id_barcode = value; }}
		public string MASANPHAM{ get { return masanpham; } set { masanpham = value; }}
		public string TENMAU{ get { return tenmau; } set { tenmau = value; }}
		public string SIZE{ get { return size; } set { size = value; }}
		public long SOLUONGDAT{ get { return soluongdat; } set { soluongdat = value; }}
		public double DONGIA{ get { return dongia; } set { dongia = value; }}
		public double THANHTIEN{ get { return thanhtien; } set { thanhtien = value; }}
		public double PTCHIETKHAU{ get { return ptchietkhau; } set { ptchietkhau = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DH_DonHang_L()
		{
			id_donhang_l = "";
			id_donhang_h = "";
			masanpham = "";
			tenmau = "";
			size = "";
			dongia = 0;
			thanhtien = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DH_DonHang_L( string new_id_donhang_l, string new_id_donhang_h, long new_id_barcode, string new_masanpham, string new_tenmau, string new_size, long new_soluongdat, double new_dongia, double new_thanhtien, double new_ptchietkhau, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_donhang_l = new_id_donhang_l;
			id_donhang_h = new_id_donhang_h;
			id_barcode = new_id_barcode;
			masanpham = new_masanpham;
			tenmau = new_tenmau;
			size = new_size;
			soluongdat = new_soluongdat;
			dongia = new_dongia;
			thanhtien = new_thanhtien;
			ptchietkhau = new_ptchietkhau;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DH_DonHang_L(Ob_DH_DonHang_L newOb)
		{
			id_donhang_l = newOb.ID_DONHANG_L;
			id_donhang_h = newOb.ID_DONHANG_H;
			id_barcode = newOb.ID_BARCODE;
			masanpham = newOb.MASANPHAM;
			tenmau = newOb.TENMAU;
			size = newOb.SIZE;
			soluongdat = newOb.SOLUONGDAT;
			dongia = newOb.DONGIA;
			thanhtien = newOb.THANHTIEN;
			ptchietkhau = newOb.PTCHIETKHAU;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
