using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 13/06/2018 11:48:36.AM

namespace Bitas
{
	public class Ob_POS_BanHang_H
	{
		private string id_phieubanhang_h;
		private string maphieubanhang;
		private int id_cuahang;
		private int id_kho;
		private int id_nhacc;
		private string id_khachhang;
		private int id_loaixuat;
		private DateTime ngaybanhang;
		private string ghichu;
		private double ptgiamgia;
		private double giamgiapt;
		private double giamgiacodinh;
		private int soluong;
		private double thanhtien;
		private double thucthu;
		private double tienvourcher;
		private double tongthanhtoan;
		private string makhuyenmai;
		private int id_trangthaiphieu;
		private int id_pttt;
		private double tienkhachtra;
		private DateTime createdtime;
		private string createdby;
		private DateTime modifiedtime;
		private string modifiedby;
		public string ID_PHIEUBANHANG_H{ get { return id_phieubanhang_h; } set { id_phieubanhang_h = value; }}
		public string MAPHIEUBANHANG{ get { return maphieubanhang; } set { maphieubanhang = value; }}
		public int ID_CUAHANG{ get { return id_cuahang; } set { id_cuahang = value; }}
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public int ID_NHACC{ get { return id_nhacc; } set { id_nhacc = value; }}
		public string ID_KHACHHANG{ get { return id_khachhang; } set { id_khachhang = value; }}
		public int ID_LOAIXUAT{ get { return id_loaixuat; } set { id_loaixuat = value; }}
		public DateTime NGAYBANHANG{ get { return ngaybanhang; } set { ngaybanhang = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public double PTGIAMGIA{ get { return ptgiamgia; } set { ptgiamgia = value; }}
		public double GIAMGIAPT{ get { return giamgiapt; } set { giamgiapt = value; }}
		public double GIAMGIACODINH{ get { return giamgiacodinh; } set { giamgiacodinh = value; }}
		public int SOLUONG{ get { return soluong; } set { soluong = value; }}
		public double THANHTIEN{ get { return thanhtien; } set { thanhtien = value; }}
		public double THUCTHU{ get { return thucthu; } set { thucthu = value; }}
		public double TIENVOURCHER{ get { return tienvourcher; } set { tienvourcher = value; }}
		public double TONGTHANHTOAN{ get { return tongthanhtoan; } set { tongthanhtoan = value; }}
		public string MAKHUYENMAI{ get { return makhuyenmai; } set { makhuyenmai = value; }}
		public int ID_TRANGTHAIPHIEU{ get { return id_trangthaiphieu; } set { id_trangthaiphieu = value; }}
		public int ID_PTTT{ get { return id_pttt; } set { id_pttt = value; }}
		public double TIENKHACHTRA{ get { return tienkhachtra; } set { tienkhachtra = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}

		public Ob_POS_BanHang_H()
		{
			id_phieubanhang_h = "";
			maphieubanhang = "";
			id_cuahang = 0;
			id_kho = 0;
			id_nhacc = 0;
			id_khachhang = "";
			id_loaixuat = 0;
			ngaybanhang = DateTime.MinValue;
			ghichu = "";
			giamgiapt = 0;
			giamgiacodinh = 0;
			soluong = 0;
			thanhtien = 0;
			thucthu = 0;
			tienvourcher = 0;
			tongthanhtoan = 0;
			makhuyenmai = "";
			id_trangthaiphieu = 0;
			id_pttt = 0;
			tienkhachtra = 0;
			createdtime = DateTime.MinValue;
			createdby = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
		}

		public Ob_POS_BanHang_H( string new_id_phieubanhang_h, string new_maphieubanhang, int new_id_cuahang, int new_id_kho, int new_id_nhacc, string new_id_khachhang, int new_id_loaixuat, DateTime new_ngaybanhang, string new_ghichu, double new_ptgiamgia, double new_giamgiapt, double new_giamgiacodinh, int new_soluong, double new_thanhtien, double new_thucthu, double new_tienvourcher, double new_tongthanhtoan, string new_makhuyenmai, int new_id_trangthaiphieu, int new_id_pttt, double new_tienkhachtra, DateTime new_createdtime, string new_createdby, DateTime new_modifiedtime, string new_modifiedby)	
		{
			id_phieubanhang_h = new_id_phieubanhang_h;
			maphieubanhang = new_maphieubanhang;
			id_cuahang = new_id_cuahang;
			id_kho = new_id_kho;
			id_nhacc = new_id_nhacc;
			id_khachhang = new_id_khachhang;
			id_loaixuat = new_id_loaixuat;
			ngaybanhang = new_ngaybanhang;
			ghichu = new_ghichu;
			ptgiamgia = new_ptgiamgia;
			giamgiapt = new_giamgiapt;
			giamgiacodinh = new_giamgiacodinh;
			soluong = new_soluong;
			thanhtien = new_thanhtien;
			thucthu = new_thucthu;
			tienvourcher = new_tienvourcher;
			tongthanhtoan = new_tongthanhtoan;
			makhuyenmai = new_makhuyenmai;
			id_trangthaiphieu = new_id_trangthaiphieu;
			id_pttt = new_id_pttt;
			tienkhachtra = new_tienkhachtra;
			createdtime = new_createdtime;
			createdby = new_createdby;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
		}

		public Ob_POS_BanHang_H(Ob_POS_BanHang_H newOb)
		{
			id_phieubanhang_h = newOb.ID_PHIEUBANHANG_H;
			maphieubanhang = newOb.MAPHIEUBANHANG;
			id_cuahang = newOb.ID_CUAHANG;
			id_kho = newOb.ID_KHO;
			id_nhacc = newOb.ID_NHACC;
			id_khachhang = newOb.ID_KHACHHANG;
			id_loaixuat = newOb.ID_LOAIXUAT;
			ngaybanhang = newOb.NGAYBANHANG;
			ghichu = newOb.GHICHU;
			ptgiamgia = newOb.PTGIAMGIA;
			giamgiapt = newOb.GIAMGIAPT;
			giamgiacodinh = newOb.GIAMGIACODINH;
			soluong = newOb.SOLUONG;
			thanhtien = newOb.THANHTIEN;
			thucthu = newOb.THUCTHU;
			tienvourcher = newOb.TIENVOURCHER;
			tongthanhtoan = newOb.TONGTHANHTOAN;
			makhuyenmai = newOb.MAKHUYENMAI;
			id_trangthaiphieu = newOb.ID_TRANGTHAIPHIEU;
			id_pttt = newOb.ID_PTTT;
			tienkhachtra = newOb.TIENKHACHTRA;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
		}

	}
}
