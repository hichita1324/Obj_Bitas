using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 13/09/2018 07:41:16.AM

namespace Bitas
{
	public class Ob_POS_TonKhoKetChuyen
	{
		private string id_ketchuyen;
		private int id_kho;
		private long id_barcode;
		private DateTime ngayketchuyen;
		private long slton;
		private double thanhtien;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_KETCHUYEN{ get { return id_ketchuyen; } set { id_ketchuyen = value; }}
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public long ID_BARCODE{ get { return id_barcode; } set { id_barcode = value; }}
		public DateTime NGAYKETCHUYEN{ get { return ngayketchuyen; } set { ngayketchuyen = value; }}
		public long SLTON{ get { return slton; } set { slton = value; }}
		public double THANHTIEN{ get { return thanhtien; } set { thanhtien = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_POS_TonKhoKetChuyen()
		{
			id_ketchuyen = "";
			id_kho = 0;
			ngayketchuyen = DateTime.MinValue;
			thanhtien = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_POS_TonKhoKetChuyen( string new_id_ketchuyen, int new_id_kho, long new_id_barcode, DateTime new_ngayketchuyen, long new_slton, double new_thanhtien, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_ketchuyen = new_id_ketchuyen;
			id_kho = new_id_kho;
			id_barcode = new_id_barcode;
			ngayketchuyen = new_ngayketchuyen;
			slton = new_slton;
			thanhtien = new_thanhtien;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_POS_TonKhoKetChuyen(Ob_POS_TonKhoKetChuyen newOb)
		{
			id_ketchuyen = newOb.ID_KETCHUYEN;
			id_kho = newOb.ID_KHO;
			id_barcode = newOb.ID_BARCODE;
			ngayketchuyen = newOb.NGAYKETCHUYEN;
			slton = newOb.SLTON;
			thanhtien = newOb.THANHTIEN;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
