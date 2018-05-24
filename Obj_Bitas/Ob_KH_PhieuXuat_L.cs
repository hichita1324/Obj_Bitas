using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 17/10/2016 10:42:47.AM

namespace Bitas
{
	public class Ob_KH_PhieuXuat_L
	{
		private string id_phieuxuat_l;
		private string id_phieuxuat_h;
		private long id_barcode;
		private string masanpham;
		private string tenmau;
		private string size;
		private long soluongxuat;
		private double dongia;
		private double thanhtien;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_PHIEUXUAT_L{ get { return id_phieuxuat_l; } set { id_phieuxuat_l = value; }}
		public string ID_PHIEUXUAT_H{ get { return id_phieuxuat_h; } set { id_phieuxuat_h = value; }}
		public long ID_BARCODE{ get { return id_barcode; } set { id_barcode = value; }}
		public string MASANPHAM{ get { return masanpham; } set { masanpham = value; }}
		public string TENMAU{ get { return tenmau; } set { tenmau = value; }}
		public string SIZE{ get { return size; } set { size = value; }}
		public long SOLUONGXUAT{ get { return soluongxuat; } set { soluongxuat = value; }}
		public double DONGIA{ get { return dongia; } set { dongia = value; }}
		public double THANHTIEN{ get { return thanhtien; } set { thanhtien = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_PhieuXuat_L()
		{
			id_phieuxuat_l = "";
			id_phieuxuat_h = "";
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

		public Ob_KH_PhieuXuat_L( string new_id_phieuxuat_l, string new_id_phieuxuat_h, long new_id_barcode, string new_masanpham, string new_tenmau, string new_size, long new_soluongxuat, double new_dongia, double new_thanhtien, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_phieuxuat_l = new_id_phieuxuat_l;
			id_phieuxuat_h = new_id_phieuxuat_h;
			id_barcode = new_id_barcode;
			masanpham = new_masanpham;
			tenmau = new_tenmau;
			size = new_size;
			soluongxuat = new_soluongxuat;
			dongia = new_dongia;
			thanhtien = new_thanhtien;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_PhieuXuat_L(Ob_KH_PhieuXuat_L newOb)
		{
			id_phieuxuat_l = newOb.ID_PHIEUXUAT_L;
			id_phieuxuat_h = newOb.ID_PHIEUXUAT_H;
			id_barcode = newOb.ID_BARCODE;
			masanpham = newOb.MASANPHAM;
			tenmau = newOb.TENMAU;
			size = newOb.SIZE;
			soluongxuat = newOb.SOLUONGXUAT;
			dongia = newOb.DONGIA;
			thanhtien = newOb.THANHTIEN;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
