using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:45:34.AM

namespace Bitas
{
	public class Ob_SP_BangGia
	{
		private int id_banggia;
		private int id_barcode;
		private DateTime ngaybatdau;
		private double dongia;
		private bool giamgia;
		private DateTime createdtime;
		private string createdby;
		private DateTime modifiedtime;
		private string modifiedby;
		public int ID_BANGGIA{ get { return id_banggia; } set { id_banggia = value; }}
		public int ID_BARCODE{ get { return id_barcode; } set { id_barcode = value; }}
		public DateTime NGAYBATDAU{ get { return ngaybatdau; } set { ngaybatdau = value; }}
		public double DONGIA{ get { return dongia; } set { dongia = value; }}
		public bool GIAMGIA{ get { return giamgia; } set { giamgia = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}

		public Ob_SP_BangGia()
		{
			id_banggia = 0;
			id_barcode = 0;
			ngaybatdau = DateTime.MinValue;
			dongia = 0;
			giamgia = false;
			createdtime = DateTime.MinValue;
			createdby = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
		}

		public Ob_SP_BangGia( int new_id_banggia, int new_id_barcode, DateTime new_ngaybatdau, double new_dongia, bool new_giamgia, DateTime new_createdtime, string new_createdby, DateTime new_modifiedtime, string new_modifiedby)	
		{
			id_banggia = new_id_banggia;
			id_barcode = new_id_barcode;
			ngaybatdau = new_ngaybatdau;
			dongia = new_dongia;
			giamgia = new_giamgia;
			createdtime = new_createdtime;
			createdby = new_createdby;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
		}

		public Ob_SP_BangGia(Ob_SP_BangGia newOb)
		{
			id_banggia = newOb.ID_BANGGIA;
			id_barcode = newOb.ID_BARCODE;
			ngaybatdau = newOb.NGAYBATDAU;
			dongia = newOb.DONGIA;
			giamgia = newOb.GIAMGIA;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
		}

	}
}
