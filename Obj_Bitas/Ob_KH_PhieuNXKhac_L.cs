using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 08/07/2016 09:18:00.AM

namespace Bitas
{
	public class Ob_KH_PhieuNXKhac_L
	{
		private string id_nxkhac_l;
		private string id_nxkhac_h;
		private long id_barcode;
		private string masanpham;
		private string tenmau;
		private string size;
		private int soluong;
		private decimal dongia;
		private decimal thanhtien;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_NXKHAC_L{ get { return id_nxkhac_l; } set { id_nxkhac_l = value; }}
		public string ID_NXKHAC_H{ get { return id_nxkhac_h; } set { id_nxkhac_h = value; }}
		public long ID_BARCODE{ get { return id_barcode; } set { id_barcode = value; }}
		public string MASANPHAM{ get { return masanpham; } set { masanpham = value; }}
		public string TENMAU{ get { return tenmau; } set { tenmau = value; }}
		public string SIZE{ get { return size; } set { size = value; }}
		public int SOLUONG{ get { return soluong; } set { soluong = value; }}
		public decimal DONGIA{ get { return dongia; } set { dongia = value; }}
		public decimal THANHTIEN{ get { return thanhtien; } set { thanhtien = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_PhieuNXKhac_L()
		{
			id_nxkhac_l = "";
			id_nxkhac_h = "";
			masanpham = "";
			tenmau = "";
			size = "";
			soluong = 0;
			dongia = 0;
			thanhtien = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_PhieuNXKhac_L(string new_id_nxkhac_l, string new_id_nxkhac_h, long new_id_barcode, string new_masanpham, string new_tenmau, string new_size, int new_soluong, decimal new_dongia, decimal new_thanhtien, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_nxkhac_l = new_id_nxkhac_l;
			id_nxkhac_h = new_id_nxkhac_h;
			id_barcode = new_id_barcode;
			masanpham = new_masanpham;
			tenmau = new_tenmau;
			size = new_size;
			soluong = new_soluong;
			dongia = new_dongia;
			thanhtien = new_thanhtien;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_PhieuNXKhac_L(Ob_KH_PhieuNXKhac_L newOb)
		{
			id_nxkhac_l = newOb.ID_NXKHAC_L;
			id_nxkhac_h = newOb.ID_NXKHAC_H;
			id_barcode = newOb.ID_BARCODE;
			masanpham = newOb.MASANPHAM;
			tenmau = newOb.TENMAU;
			size = newOb.SIZE;
			soluong = newOb.SOLUONG;
			dongia = newOb.DONGIA;
			thanhtien = newOb.THANHTIEN;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
