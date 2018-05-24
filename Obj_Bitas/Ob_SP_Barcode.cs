using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 13/04/2016 14:34:33.PM

namespace Bitas
{
	public class Ob_SP_Barcode
	{
		private long id_barcode;
		private string sku;
		private string barcode;
		private int id_sanpham;
		private string tusize;
		private string densize;
		private int id_nhomsize;
		private int id_mau;
		private string size;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public long ID_BARCODE{ get { return id_barcode; } set { id_barcode = value; }}
		public string SKU{ get { return sku; } set { sku = value; }}
		public string BARCODE{ get { return barcode; } set { barcode = value; }}
		public int ID_SANPHAM{ get { return id_sanpham; } set { id_sanpham = value; }}
		public string TUSIZE{ get { return tusize; } set { tusize = value; }}
		public string DENSIZE{ get { return densize; } set { densize = value; }}
		public int ID_NHOMSIZE{ get { return id_nhomsize; } set { id_nhomsize = value; }}
		public int ID_MAU{ get { return id_mau; } set { id_mau = value; }}
		public string SIZE{ get { return size; } set { size = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_SP_Barcode()
		{
			sku = "";
			barcode = "";
			id_sanpham = 0;
			tusize = "";
			densize = "";
			id_nhomsize = 0;
			id_mau = 0;
			size = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_SP_Barcode( long new_id_barcode, string new_sku, string new_barcode, int new_id_sanpham, string new_tusize, string new_densize, int new_id_nhomsize, int new_id_mau, string new_size, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_barcode = new_id_barcode;
			sku = new_sku;
			barcode = new_barcode;
			id_sanpham = new_id_sanpham;
			tusize = new_tusize;
			densize = new_densize;
			id_nhomsize = new_id_nhomsize;
			id_mau = new_id_mau;
			size = new_size;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_SP_Barcode(Ob_SP_Barcode newOb)
		{
			id_barcode = newOb.ID_BARCODE;
			sku = newOb.SKU;
			barcode = newOb.BARCODE;
			id_sanpham = newOb.ID_SANPHAM;
			tusize = newOb.TUSIZE;
			densize = newOb.DENSIZE;
			id_nhomsize = newOb.ID_NHOMSIZE;
			id_mau = newOb.ID_MAU;
			size = newOb.SIZE;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
