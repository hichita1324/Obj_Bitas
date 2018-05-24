using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 20/12/2017 10:37:34.AM

namespace Bitas
{
	public class Ob_POS_KhuyenMai
	{
		private int id_khuyenmai;
		private string makhuyenmai;
		private string tenkhuyenmai;
		private DateTime ngaybatdau;
		private DateTime ngayketthuc;
		private bool kichhoat;
		private string storedkhuyenmai;
		private bool nguyengia;
		private bool giamgia;
		private int giamgiatheohoadon;
		private int vatphamtheohoadon;
		private double giamgiapt;
		private double giamgiatien;
		private DateTime createdtime;
		private string createdby;
		private DateTime modifiedtime;
		private string modifiedby;
		public int ID_KHUYENMAI{ get { return id_khuyenmai; } set { id_khuyenmai = value; }}
		public string MAKHUYENMAI{ get { return makhuyenmai; } set { makhuyenmai = value; }}
		public string TENKHUYENMAI{ get { return tenkhuyenmai; } set { tenkhuyenmai = value; }}
		public DateTime NGAYBATDAU{ get { return ngaybatdau; } set { ngaybatdau = value; }}
		public DateTime NGAYKETTHUC{ get { return ngayketthuc; } set { ngayketthuc = value; }}
		public bool KICHHOAT{ get { return kichhoat; } set { kichhoat = value; }}
		public string STOREDKHUYENMAI{ get { return storedkhuyenmai; } set { storedkhuyenmai = value; }}
		public bool NGUYENGIA{ get { return nguyengia; } set { nguyengia = value; }}
		public bool GIAMGIA{ get { return giamgia; } set { giamgia = value; }}
		public int GIAMGIATHEOHOADON{ get { return giamgiatheohoadon; } set { giamgiatheohoadon = value; }}
		public int VATPHAMTHEOHOADON{ get { return vatphamtheohoadon; } set { vatphamtheohoadon = value; }}
		public double GIAMGIAPT{ get { return giamgiapt; } set { giamgiapt = value; }}
		public double GIAMGIATIEN{ get { return giamgiatien; } set { giamgiatien = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}

		public Ob_POS_KhuyenMai()
		{
			id_khuyenmai = 0;
			makhuyenmai = "";
			tenkhuyenmai = "";
			ngaybatdau = DateTime.MinValue;
			ngayketthuc = DateTime.MinValue;
			kichhoat = false;
			storedkhuyenmai = "";
			nguyengia = false;
			giamgia = false;
			giamgiatheohoadon = 0;
			vatphamtheohoadon = 0;
			giamgiatien = 0;
			createdtime = DateTime.MinValue;
			createdby = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
		}

		public Ob_POS_KhuyenMai( int new_id_khuyenmai, string new_makhuyenmai, string new_tenkhuyenmai, DateTime new_ngaybatdau, DateTime new_ngayketthuc, bool new_kichhoat, string new_storedkhuyenmai, bool new_nguyengia, bool new_giamgia, int new_giamgiatheohoadon, int new_vatphamtheohoadon, double new_giamgiapt, double new_giamgiatien, DateTime new_createdtime, string new_createdby, DateTime new_modifiedtime, string new_modifiedby)	
		{
			id_khuyenmai = new_id_khuyenmai;
			makhuyenmai = new_makhuyenmai;
			tenkhuyenmai = new_tenkhuyenmai;
			ngaybatdau = new_ngaybatdau;
			ngayketthuc = new_ngayketthuc;
			kichhoat = new_kichhoat;
			storedkhuyenmai = new_storedkhuyenmai;
			nguyengia = new_nguyengia;
			giamgia = new_giamgia;
			giamgiatheohoadon = new_giamgiatheohoadon;
			vatphamtheohoadon = new_vatphamtheohoadon;
			giamgiapt = new_giamgiapt;
			giamgiatien = new_giamgiatien;
			createdtime = new_createdtime;
			createdby = new_createdby;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
		}

		public Ob_POS_KhuyenMai(Ob_POS_KhuyenMai newOb)
		{
			id_khuyenmai = newOb.ID_KHUYENMAI;
			makhuyenmai = newOb.MAKHUYENMAI;
			tenkhuyenmai = newOb.TENKHUYENMAI;
			ngaybatdau = newOb.NGAYBATDAU;
			ngayketthuc = newOb.NGAYKETTHUC;
			kichhoat = newOb.KICHHOAT;
			storedkhuyenmai = newOb.STOREDKHUYENMAI;
			nguyengia = newOb.NGUYENGIA;
			giamgia = newOb.GIAMGIA;
			giamgiatheohoadon = newOb.GIAMGIATHEOHOADON;
			vatphamtheohoadon = newOb.VATPHAMTHEOHOADON;
			giamgiapt = newOb.GIAMGIAPT;
			giamgiatien = newOb.GIAMGIATIEN;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
		}

	}
}
