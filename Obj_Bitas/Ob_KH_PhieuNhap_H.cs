using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 22/04/2016 14:13:18.PM

namespace Bitas
{
	public class Ob_KH_PhieuNhap_H
	{
		private string id_phieunhap_h;
		private string maphieunhap;
		private DateTime ngaynhap;
		private int id_nhacungcap;
		private int id_kho;
		private int tongsoluong;
		private double tongtien;
		private double pt_thuegtgt;
		private double tienthuegtgt;
		private double tienthanhtoan;
		private string ghichu;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_PHIEUNHAP_H{ get { return id_phieunhap_h; } set { id_phieunhap_h = value; }}
		public string MAPHIEUNHAP{ get { return maphieunhap; } set { maphieunhap = value; }}
		public DateTime NGAYNHAP{ get { return ngaynhap; } set { ngaynhap = value; }}
		public int ID_NHACUNGCAP{ get { return id_nhacungcap; } set { id_nhacungcap = value; }}
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public int TONGSOLUONG{ get { return tongsoluong; } set { tongsoluong = value; }}
		public double TONGTIEN{ get { return tongtien; } set { tongtien = value; }}
		public double PT_THUEGTGT{ get { return pt_thuegtgt; } set { pt_thuegtgt = value; }}
		public double TIENTHUEGTGT{ get { return tienthuegtgt; } set { tienthuegtgt = value; }}
		public double TIENTHANHTOAN{ get { return tienthanhtoan; } set { tienthanhtoan = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_PhieuNhap_H()
		{
			id_phieunhap_h = "";
			maphieunhap = "";
			ngaynhap = DateTime.MinValue;
			id_nhacungcap = 0;
			id_kho = 0;
			tongsoluong = 0;
			tongtien = 0;
			pt_thuegtgt = 0;
			tienthuegtgt = 0;
			tienthanhtoan = 0;
			ghichu = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_PhieuNhap_H( string new_id_phieunhap_h, string new_maphieunhap, DateTime new_ngaynhap, int new_id_nhacungcap, int new_id_kho, int new_tongsoluong, double new_tongtien, double new_pt_thuegtgt, double new_tienthuegtgt, double new_tienthanhtoan, string new_ghichu, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_phieunhap_h = new_id_phieunhap_h;
			maphieunhap = new_maphieunhap;
			ngaynhap = new_ngaynhap;
			id_nhacungcap = new_id_nhacungcap;
			id_kho = new_id_kho;
			tongsoluong = new_tongsoluong;
			tongtien = new_tongtien;
			pt_thuegtgt = new_pt_thuegtgt;
			tienthuegtgt = new_tienthuegtgt;
			tienthanhtoan = new_tienthanhtoan;
			ghichu = new_ghichu;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_PhieuNhap_H(Ob_KH_PhieuNhap_H newOb)
		{
			id_phieunhap_h = newOb.ID_PHIEUNHAP_H;
			maphieunhap = newOb.MAPHIEUNHAP;
			ngaynhap = newOb.NGAYNHAP;
			id_nhacungcap = newOb.ID_NHACUNGCAP;
			id_kho = newOb.ID_KHO;
			tongsoluong = newOb.TONGSOLUONG;
			tongtien = newOb.TONGTIEN;
			pt_thuegtgt = newOb.PT_THUEGTGT;
			tienthuegtgt = newOb.TIENTHUEGTGT;
			tienthanhtoan = newOb.TIENTHANHTOAN;
			ghichu = newOb.GHICHU;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
