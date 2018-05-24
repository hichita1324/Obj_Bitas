using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 15/10/2016 11:14:02.AM

namespace Bitas
{
	public class Ob_KH_PhieuYC_H
	{
		private string id_phieuyc_h;
		private string maphieuyc;
		private string id_donhang_h;
		private DateTime ngaytao;
		private DateTime ngaydn;
		private string id_khachhang;
		private int id_kho;
		private double congnothucte;
		private long tongsoluong;
		private double tongthanhtien;
		private string ghichu;
		private bool khoa;
		private bool hoanthanh;
		private int id_trangthai;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		private DateTime timedoichieu;
		private DateTime timeduyet;
		public string ID_PHIEUYC_H{ get { return id_phieuyc_h; } set { id_phieuyc_h = value; }}
		public string MAPHIEUYC{ get { return maphieuyc; } set { maphieuyc = value; }}
		public string ID_DONHANG_H{ get { return id_donhang_h; } set { id_donhang_h = value; }}
		public DateTime NGAYTAO{ get { return ngaytao; } set { ngaytao = value; }}
		public DateTime NGAYDN{ get { return ngaydn; } set { ngaydn = value; }}
		public string ID_KHACHHANG{ get { return id_khachhang; } set { id_khachhang = value; }}
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public double CONGNOTHUCTE{ get { return congnothucte; } set { congnothucte = value; }}
		public long TONGSOLUONG{ get { return tongsoluong; } set { tongsoluong = value; }}
		public double TONGTHANHTIEN{ get { return tongthanhtien; } set { tongthanhtien = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public bool KHOA{ get { return khoa; } set { khoa = value; }}
		public bool HOANTHANH{ get { return hoanthanh; } set { hoanthanh = value; }}
		public int ID_TRANGTHAI{ get { return id_trangthai; } set { id_trangthai = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}
		public DateTime TIMEDOICHIEU{ get { return timedoichieu; } set { timedoichieu = value; }}
		public DateTime TIMEDUYET{ get { return timeduyet; } set { timeduyet = value; }}

		public Ob_KH_PhieuYC_H()
		{
			id_phieuyc_h = "";
			maphieuyc = "";
			id_donhang_h = "";
			ngaytao = DateTime.MinValue;
			ngaydn = DateTime.MinValue;
			id_khachhang = "";
			id_kho = 0;
			congnothucte = 0;
			tongthanhtien = 0;
			ghichu = "";
			khoa = false;
			hoanthanh = false;
			id_trangthai = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
			timedoichieu = DateTime.MinValue;
			timeduyet = DateTime.MinValue;
		}

		public Ob_KH_PhieuYC_H( string new_id_phieuyc_h, string new_maphieuyc, string new_id_donhang_h, DateTime new_ngaytao, DateTime new_ngaydn, string new_id_khachhang, int new_id_kho, double new_congnothucte, long new_tongsoluong, double new_tongthanhtien, string new_ghichu, bool new_khoa, bool new_hoanthanh, int new_id_trangthai, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby, DateTime new_timedoichieu, DateTime new_timeduyet)	
		{
			id_phieuyc_h = new_id_phieuyc_h;
			maphieuyc = new_maphieuyc;
			id_donhang_h = new_id_donhang_h;
			ngaytao = new_ngaytao;
			ngaydn = new_ngaydn;
			id_khachhang = new_id_khachhang;
			id_kho = new_id_kho;
			congnothucte = new_congnothucte;
			tongsoluong = new_tongsoluong;
			tongthanhtien = new_tongthanhtien;
			ghichu = new_ghichu;
			khoa = new_khoa;
			hoanthanh = new_hoanthanh;
			id_trangthai = new_id_trangthai;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
			timedoichieu = new_timedoichieu;
			timeduyet = new_timeduyet;
		}

		public Ob_KH_PhieuYC_H(Ob_KH_PhieuYC_H newOb)
		{
			id_phieuyc_h = newOb.ID_PHIEUYC_H;
			maphieuyc = newOb.MAPHIEUYC;
			id_donhang_h = newOb.ID_DONHANG_H;
			ngaytao = newOb.NGAYTAO;
			ngaydn = newOb.NGAYDN;
			id_khachhang = newOb.ID_KHACHHANG;
			id_kho = newOb.ID_KHO;
			congnothucte = newOb.CONGNOTHUCTE;
			tongsoluong = newOb.TONGSOLUONG;
			tongthanhtien = newOb.TONGTHANHTIEN;
			ghichu = newOb.GHICHU;
			khoa = newOb.KHOA;
			hoanthanh = newOb.HOANTHANH;
			id_trangthai = newOb.ID_TRANGTHAI;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
			timedoichieu = newOb.TIMEDOICHIEU;
			timeduyet = newOb.TIMEDUYET;
		}

	}
}
