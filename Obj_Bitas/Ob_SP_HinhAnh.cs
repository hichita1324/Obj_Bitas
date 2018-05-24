using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:45:47.AM

namespace Bitas
{
	public class Ob_SP_HinhAnh
	{
		private int id_hinhanh;
		private int id_sanpham;
		private string tenhinh;
		private byte[] hinh;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_HINHANH{ get { return id_hinhanh; } set { id_hinhanh = value; }}
		public int ID_SANPHAM{ get { return id_sanpham; } set { id_sanpham = value; }}
		public string TENHINH{ get { return tenhinh; } set { tenhinh = value; }}
		public byte[] HINH{ get { return hinh; } set { hinh = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_SP_HinhAnh()
		{
			id_hinhanh = 0;
			id_sanpham = 0;
			tenhinh = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_SP_HinhAnh( int new_id_hinhanh, int new_id_sanpham, string new_tenhinh, byte[] new_hinh, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_hinhanh = new_id_hinhanh;
			id_sanpham = new_id_sanpham;
			tenhinh = new_tenhinh;
			hinh = new_hinh;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_SP_HinhAnh(Ob_SP_HinhAnh newOb)
		{
			id_hinhanh = newOb.ID_HINHANH;
			id_sanpham = newOb.ID_SANPHAM;
			tenhinh = newOb.TENHINH;
			hinh = newOb.HINH;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
