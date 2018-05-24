using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 19/10/2016 11:37:59.AM

namespace Bitas
{
	public class Ob_KH_PhieuXuat_H
	{
		private string id_phieuxuat_h;
		private string maphieuxuat;
		private string id_phieuyc_h;
		private int id_loaixuat;
		private DateTime ngayxuat;
		private int id_kho;
		private int id_khoden;
		private string id_khachhang;
		private double congnothucte;
		private int tongsoluong;
		private double tongtien;
		private double phihotro;
		private double pt_cklhkd;
		private double cklhkd;
		private double cpvanchuyen;
		private double trucoc;
		private string ghichu;
		private bool khoa;
		private int id_trangthai;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_PHIEUXUAT_H{ get { return id_phieuxuat_h; } set { id_phieuxuat_h = value; }}
		public string MAPHIEUXUAT{ get { return maphieuxuat; } set { maphieuxuat = value; }}
		public string ID_PHIEUYC_H{ get { return id_phieuyc_h; } set { id_phieuyc_h = value; }}
		public int ID_LOAIXUAT{ get { return id_loaixuat; } set { id_loaixuat = value; }}
		public DateTime NGAYXUAT{ get { return ngayxuat; } set { ngayxuat = value; }}
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public int ID_KHODEN{ get { return id_khoden; } set { id_khoden = value; }}
		public string ID_KHACHHANG{ get { return id_khachhang; } set { id_khachhang = value; }}
		public double CONGNOTHUCTE{ get { return congnothucte; } set { congnothucte = value; }}
		public int TONGSOLUONG{ get { return tongsoluong; } set { tongsoluong = value; }}
		public double TONGTIEN{ get { return tongtien; } set { tongtien = value; }}
		public double PHIHOTRO{ get { return phihotro; } set { phihotro = value; }}
		public double PT_CKLHKD{ get { return pt_cklhkd; } set { pt_cklhkd = value; }}
		public double CKLHKD{ get { return cklhkd; } set { cklhkd = value; }}
		public double CPVANCHUYEN{ get { return cpvanchuyen; } set { cpvanchuyen = value; }}
		public double TRUCOC{ get { return trucoc; } set { trucoc = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public bool KHOA{ get { return khoa; } set { khoa = value; }}
		public int ID_TRANGTHAI{ get { return id_trangthai; } set { id_trangthai = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_PhieuXuat_H()
		{
			id_phieuxuat_h = "";
			maphieuxuat = "";
			id_phieuyc_h = "";
			id_loaixuat = 0;
			ngayxuat = DateTime.MinValue;
			id_kho = 0;
			id_khoden = 0;
			id_khachhang = "";
			congnothucte = 0;
			tongsoluong = 0;
			tongtien = 0;
			phihotro = 0;
			cklhkd = 0;
			cpvanchuyen = 0;
			trucoc = 0;
			ghichu = "";
			khoa = false;
			id_trangthai = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_PhieuXuat_H( string new_id_phieuxuat_h, string new_maphieuxuat, string new_id_phieuyc_h, int new_id_loaixuat, DateTime new_ngayxuat, int new_id_kho, int new_id_khoden, string new_id_khachhang, double new_congnothucte, int new_tongsoluong, double new_tongtien, double new_phihotro, double new_pt_cklhkd, double new_cklhkd, double new_cpvanchuyen, double new_trucoc, string new_ghichu, bool new_khoa, int new_id_trangthai, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_phieuxuat_h = new_id_phieuxuat_h;
			maphieuxuat = new_maphieuxuat;
			id_phieuyc_h = new_id_phieuyc_h;
			id_loaixuat = new_id_loaixuat;
			ngayxuat = new_ngayxuat;
			id_kho = new_id_kho;
			id_khoden = new_id_khoden;
			id_khachhang = new_id_khachhang;
			congnothucte = new_congnothucte;
			tongsoluong = new_tongsoluong;
			tongtien = new_tongtien;
			phihotro = new_phihotro;
			pt_cklhkd = new_pt_cklhkd;
			cklhkd = new_cklhkd;
			cpvanchuyen = new_cpvanchuyen;
			trucoc = new_trucoc;
			ghichu = new_ghichu;
			khoa = new_khoa;
			id_trangthai = new_id_trangthai;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_PhieuXuat_H(Ob_KH_PhieuXuat_H newOb)
		{
			id_phieuxuat_h = newOb.ID_PHIEUXUAT_H;
			maphieuxuat = newOb.MAPHIEUXUAT;
			id_phieuyc_h = newOb.ID_PHIEUYC_H;
			id_loaixuat = newOb.ID_LOAIXUAT;
			ngayxuat = newOb.NGAYXUAT;
			id_kho = newOb.ID_KHO;
			id_khoden = newOb.ID_KHODEN;
			id_khachhang = newOb.ID_KHACHHANG;
			congnothucte = newOb.CONGNOTHUCTE;
			tongsoluong = newOb.TONGSOLUONG;
			tongtien = newOb.TONGTIEN;
			phihotro = newOb.PHIHOTRO;
			pt_cklhkd = newOb.PT_CKLHKD;
			cklhkd = newOb.CKLHKD;
			cpvanchuyen = newOb.CPVANCHUYEN;
			trucoc = newOb.TRUCOC;
			ghichu = newOb.GHICHU;
			khoa = newOb.KHOA;
			id_trangthai = newOb.ID_TRANGTHAI;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
