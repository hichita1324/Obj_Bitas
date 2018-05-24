using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 18/05/2018 15:18:08.PM

namespace Bitas
{
	public class Ob_POS_BanHang_L
	{
		private string id_phieubanhang_l;
		private string id_phieubanhang_h;
		private long id_barcode;
		private string masanpham;
		private string tenmau;
		private string size;
		private double dongia;
		private int soluong;
		private bool nguyengia;
		private double ptgiamgia;
		private double giamgiapt;
		private double giamgiacodinh;
		private double thanhtien;
		private double thucthu;
		private DateTime createdtime;
		private string createdby;
		private DateTime modifiedtime;
		private string modifiedby;
		public string ID_PHIEUBANHANG_L{ get { return id_phieubanhang_l; } set { id_phieubanhang_l = value; }}
		public string ID_PHIEUBANHANG_H{ get { return id_phieubanhang_h; } set { id_phieubanhang_h = value; }}
		public long ID_BARCODE{ get { return id_barcode; } set { id_barcode = value; }}
		public string MASANPHAM{ get { return masanpham; } set { masanpham = value; }}
		public string TENMAU{ get { return tenmau; } set { tenmau = value; }}
		public string SIZE{ get { return size; } set { size = value; }}
		public double DONGIA{ get { return dongia; } set { dongia = value; }}
		public int SOLUONG{ get { return soluong; } set { soluong = value; }}
		public bool NGUYENGIA{ get { return nguyengia; } set { nguyengia = value; }}
		public double PTGIAMGIA{ get { return ptgiamgia; } set { ptgiamgia = value; }}
		public double GIAMGIAPT{ get { return giamgiapt; } set { giamgiapt = value; }}
		public double GIAMGIACODINH{ get { return giamgiacodinh; } set { giamgiacodinh = value; }}
		public double THANHTIEN{ get { return thanhtien; } set { thanhtien = value; }}
		public double THUCTHU{ get { return thucthu; } set { thucthu = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}

		public Ob_POS_BanHang_L()
		{
			id_phieubanhang_l = "";
			id_phieubanhang_h = "";
			masanpham = "";
			tenmau = "";
			size = "";
			dongia = 0;
			soluong = 0;
			nguyengia = false;
			giamgiapt = 0;
			giamgiacodinh = 0;
			thanhtien = 0;
			thucthu = 0;
			createdtime = DateTime.MinValue;
			createdby = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
		}

		public Ob_POS_BanHang_L( string new_id_phieubanhang_l, string new_id_phieubanhang_h, long new_id_barcode, string new_masanpham, string new_tenmau, string new_size, double new_dongia, int new_soluong, bool new_nguyengia, double new_ptgiamgia, double new_giamgiapt, double new_giamgiacodinh, double new_thanhtien, double new_thucthu, DateTime new_createdtime, string new_createdby, DateTime new_modifiedtime, string new_modifiedby)	
		{
			id_phieubanhang_l = new_id_phieubanhang_l;
			id_phieubanhang_h = new_id_phieubanhang_h;
			id_barcode = new_id_barcode;
			masanpham = new_masanpham;
			tenmau = new_tenmau;
			size = new_size;
			dongia = new_dongia;
			soluong = new_soluong;
			nguyengia = new_nguyengia;
			ptgiamgia = new_ptgiamgia;
			giamgiapt = new_giamgiapt;
			giamgiacodinh = new_giamgiacodinh;
			thanhtien = new_thanhtien;
			thucthu = new_thucthu;
			createdtime = new_createdtime;
			createdby = new_createdby;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
		}

		public Ob_POS_BanHang_L(Ob_POS_BanHang_L newOb)
		{
			id_phieubanhang_l = newOb.ID_PHIEUBANHANG_L;
			id_phieubanhang_h = newOb.ID_PHIEUBANHANG_H;
			id_barcode = newOb.ID_BARCODE;
			masanpham = newOb.MASANPHAM;
			tenmau = newOb.TENMAU;
			size = newOb.SIZE;
			dongia = newOb.DONGIA;
			soluong = newOb.SOLUONG;
			nguyengia = newOb.NGUYENGIA;
			ptgiamgia = newOb.PTGIAMGIA;
			giamgiapt = newOb.GIAMGIAPT;
			giamgiacodinh = newOb.GIAMGIACODINH;
			thanhtien = newOb.THANHTIEN;
			thucthu = newOb.THUCTHU;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
		}

	}
}
