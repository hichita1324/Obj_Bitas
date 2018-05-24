using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 25/07/2016 14:08:30.PM

namespace Bitas
{
	public class Ob_KH_PhieuDNXuat_H
	{
		private string id_phieudn_h;
		private string maphieudn;
		private string id_phieuyc_h;
		private int id_kho;
		private DateTime ngaytao;
		private DateTime ngayxuat;
		private string id_khachhang;
		private decimal congnothucte;
		private decimal tongtien;
		private int tongsoluong;
		private decimal phihotro;
		private double pt_cklhkd;
		private decimal cklhkd;
		private decimal cpvanchuyen;
		private bool trahang;
		private string ghichu;
		private bool khoa;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_PHIEUDN_H{ get { return id_phieudn_h; } set { id_phieudn_h = value; }}
		public string MAPHIEUDN{ get { return maphieudn; } set { maphieudn = value; }}
		public string ID_PHIEUYC_H{ get { return id_phieuyc_h; } set { id_phieuyc_h = value; }}
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public DateTime NGAYTAO{ get { return ngaytao; } set { ngaytao = value; }}
		public DateTime NGAYXUAT{ get { return ngayxuat; } set { ngayxuat = value; }}
		public string ID_KHACHHANG{ get { return id_khachhang; } set { id_khachhang = value; }}
		public decimal CONGNOTHUCTE{ get { return congnothucte; } set { congnothucte = value; }}
		public decimal TONGTIEN{ get { return tongtien; } set { tongtien = value; }}
		public int TONGSOLUONG{ get { return tongsoluong; } set { tongsoluong = value; }}
		public decimal PHIHOTRO{ get { return phihotro; } set { phihotro = value; }}
		public double PT_CKLHKD{ get { return pt_cklhkd; } set { pt_cklhkd = value; }}
		public decimal CKLHKD{ get { return cklhkd; } set { cklhkd = value; }}
		public decimal CPVANCHUYEN{ get { return cpvanchuyen; } set { cpvanchuyen = value; }}
		public bool TRAHANG{ get { return trahang; } set { trahang = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public bool KHOA{ get { return khoa; } set { khoa = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_PhieuDNXuat_H()
		{
			id_phieudn_h = "";
			maphieudn = "";
			id_phieuyc_h = "";
			id_kho = 0;
			ngaytao = DateTime.MinValue;
			ngayxuat = DateTime.MinValue;
			id_khachhang = "";
			congnothucte = 0;
			tongtien = 0;
			tongsoluong = 0;
			phihotro = 0;
			cklhkd = 0;
			cpvanchuyen = 0;
			trahang = false;
			ghichu = "";
			khoa = false;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_PhieuDNXuat_H(string new_id_phieudn_h, string new_maphieudn, string new_id_phieuyc_h, int new_id_kho, DateTime new_ngaytao, DateTime new_ngayxuat, string new_id_khachhang, decimal new_congnothucte, decimal new_tongtien, int new_tongsoluong, decimal new_phihotro, double new_pt_cklhkd, decimal new_cklhkd, decimal new_cpvanchuyen, bool new_trahang, string new_ghichu, bool new_khoa, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_phieudn_h = new_id_phieudn_h;
			maphieudn = new_maphieudn;
			id_phieuyc_h = new_id_phieuyc_h;
			id_kho = new_id_kho;
			ngaytao = new_ngaytao;
			ngayxuat = new_ngayxuat;
			id_khachhang = new_id_khachhang;
			congnothucte = new_congnothucte;
			tongtien = new_tongtien;
			tongsoluong = new_tongsoluong;
			phihotro = new_phihotro;
			pt_cklhkd = new_pt_cklhkd;
			cklhkd = new_cklhkd;
			cpvanchuyen = new_cpvanchuyen;
			trahang = new_trahang;
			ghichu = new_ghichu;
			khoa = new_khoa;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_PhieuDNXuat_H(Ob_KH_PhieuDNXuat_H newOb)
		{
			id_phieudn_h = newOb.ID_PHIEUDN_H;
			maphieudn = newOb.MAPHIEUDN;
			id_phieuyc_h = newOb.ID_PHIEUYC_H;
			id_kho = newOb.ID_KHO;
			ngaytao = newOb.NGAYTAO;
			ngayxuat = newOb.NGAYXUAT;
			id_khachhang = newOb.ID_KHACHHANG;
			congnothucte = newOb.CONGNOTHUCTE;
			tongtien = newOb.TONGTIEN;
			tongsoluong = newOb.TONGSOLUONG;
			phihotro = newOb.PHIHOTRO;
			pt_cklhkd = newOb.PT_CKLHKD;
			cklhkd = newOb.CKLHKD;
			cpvanchuyen = newOb.CPVANCHUYEN;
			trahang = newOb.TRAHANG;
			ghichu = newOb.GHICHU;
			khoa = newOb.KHOA;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
