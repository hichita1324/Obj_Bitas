using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 13/05/2016 15:29:54.PM

namespace Bitas
{
	public class Ob_KH_PhieuDN_L
	{
		private string id_phieudn_l;
		private string id_phieudn_h;
		private long id_barcode;
		private string masanpham;
		private string tenmau;
		private string size;
		private int soluongdk;
		private decimal dongia;
		private decimal thanhtien;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_PHIEUDN_L{ get { return id_phieudn_l; } set { id_phieudn_l = value; }}
		public string ID_PHIEUDN_H{ get { return id_phieudn_h; } set { id_phieudn_h = value; }}
		public long ID_BARCODE{ get { return id_barcode; } set { id_barcode = value; }}
		public string MASANPHAM{ get { return masanpham; } set { masanpham = value; }}
		public string TENMAU{ get { return tenmau; } set { tenmau = value; }}
		public string SIZE{ get { return size; } set { size = value; }}
		public int SOLUONGDK{ get { return soluongdk; } set { soluongdk = value; }}
		public decimal DONGIA{ get { return dongia; } set { dongia = value; }}
		public decimal THANHTIEN{ get { return thanhtien; } set { thanhtien = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_PhieuDN_L()
		{
			id_phieudn_l = "";
			id_phieudn_h = "";
			masanpham = "";
			tenmau = "";
			size = "";
			soluongdk = 0;
			dongia = 0;
			dongia = 0;
			thanhtien = 0;
			thanhtien = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_PhieuDN_L( string new_id_phieudn_l, string new_id_phieudn_h, long new_id_barcode, string new_masanpham, string new_tenmau, string new_size, int new_soluongdk, decimal new_dongia, decimal new_thanhtien, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_phieudn_l = new_id_phieudn_l;
			id_phieudn_h = new_id_phieudn_h;
			id_barcode = new_id_barcode;
			masanpham = new_masanpham;
			tenmau = new_tenmau;
			size = new_size;
			soluongdk = new_soluongdk;
			dongia = new_dongia;
			thanhtien = new_thanhtien;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_PhieuDN_L(Ob_KH_PhieuDN_L newOb)
		{
			id_phieudn_l = newOb.ID_PHIEUDN_L;
			id_phieudn_h = newOb.ID_PHIEUDN_H;
			id_barcode = newOb.ID_BARCODE;
			masanpham = newOb.MASANPHAM;
			tenmau = newOb.TENMAU;
			size = newOb.SIZE;
			soluongdk = newOb.SOLUONGDK;
			dongia = newOb.DONGIA;
			thanhtien = newOb.THANHTIEN;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
