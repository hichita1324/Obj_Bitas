using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/07/2018 16:23:23.PM

namespace Bitas
{
	public class Ob_POS_KiemKe_H
	{
		private string id_kiemke_h;
		private string makiemke;
		private int id_kho;
		private DateTime tungay;
		private DateTime denngay;
		private string ghichu;
		private int soluong;
		private bool dieuchinh;
		private DateTime createdtime;
		private string createdby;
		private DateTime modifiedtime;
		private string modifiedby;
		public string ID_KIEMKE_H{ get { return id_kiemke_h; } set { id_kiemke_h = value; }}
		public string MAKIEMKE{ get { return makiemke; } set { makiemke = value; }}
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public DateTime TUNGAY{ get { return tungay; } set { tungay = value; }}
		public DateTime DENNGAY{ get { return denngay; } set { denngay = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public int SOLUONG{ get { return soluong; } set { soluong = value; }}
		public bool DIEUCHINH{ get { return dieuchinh; } set { dieuchinh = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}

		public Ob_POS_KiemKe_H()
		{
			id_kiemke_h = "";
			makiemke = "";
			id_kho = 0;
			tungay = DateTime.MinValue;
			denngay = DateTime.MinValue;
			ghichu = "";
			soluong = 0;
			dieuchinh = false;
			createdtime = DateTime.MinValue;
			createdby = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
		}

		public Ob_POS_KiemKe_H( string new_id_kiemke_h, string new_makiemke, int new_id_kho, DateTime new_tungay, DateTime new_denngay, string new_ghichu, int new_soluong, bool new_dieuchinh, DateTime new_createdtime, string new_createdby, DateTime new_modifiedtime, string new_modifiedby)	
		{
			id_kiemke_h = new_id_kiemke_h;
			makiemke = new_makiemke;
			id_kho = new_id_kho;
			tungay = new_tungay;
			denngay = new_denngay;
			ghichu = new_ghichu;
			soluong = new_soluong;
			dieuchinh = new_dieuchinh;
			createdtime = new_createdtime;
			createdby = new_createdby;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
		}

		public Ob_POS_KiemKe_H(Ob_POS_KiemKe_H newOb)
		{
			id_kiemke_h = newOb.ID_KIEMKE_H;
			makiemke = newOb.MAKIEMKE;
			id_kho = newOb.ID_KHO;
			tungay = newOb.TUNGAY;
			denngay = newOb.DENNGAY;
			ghichu = newOb.GHICHU;
			soluong = newOb.SOLUONG;
			dieuchinh = newOb.DIEUCHINH;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
		}

	}
}
