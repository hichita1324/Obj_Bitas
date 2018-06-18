using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 18/06/2018 11:17:30.AM

namespace Bitas
{
	public class Ob_POS_NhapHang_H
	{
		private string id_phieunhaphang_h;
		private string maphieunhaphang;
		private int id_cuahang;
		private int id_kho;
		private int id_khoxuat;
		private string id_khachhang;
		private int id_nhacungcap;
		private int id_loainhap;
		private DateTime ngaynhaphang;
		private string ghichu;
		private int soluong;
		private double thanhtien;
		private int id_trangthaiphieu;
		private DateTime createdtime;
		private string createdby;
		private DateTime modifiedtime;
		private string modifiedby;
		public string ID_PHIEUNHAPHANG_H{ get { return id_phieunhaphang_h; } set { id_phieunhaphang_h = value; }}
		public string MAPHIEUNHAPHANG{ get { return maphieunhaphang; } set { maphieunhaphang = value; }}
		public int ID_CUAHANG{ get { return id_cuahang; } set { id_cuahang = value; }}
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public int ID_KHOXUAT{ get { return id_khoxuat; } set { id_khoxuat = value; }}
		public string ID_KHACHHANG{ get { return id_khachhang; } set { id_khachhang = value; }}
		public int ID_NHACUNGCAP{ get { return id_nhacungcap; } set { id_nhacungcap = value; }}
		public int ID_LOAINHAP{ get { return id_loainhap; } set { id_loainhap = value; }}
		public DateTime NGAYNHAPHANG{ get { return ngaynhaphang; } set { ngaynhaphang = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public int SOLUONG{ get { return soluong; } set { soluong = value; }}
		public double THANHTIEN{ get { return thanhtien; } set { thanhtien = value; }}
		public int ID_TRANGTHAIPHIEU{ get { return id_trangthaiphieu; } set { id_trangthaiphieu = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}

		public Ob_POS_NhapHang_H()
		{
			id_phieunhaphang_h = "";
			maphieunhaphang = "";
			id_cuahang = 0;
			id_kho = 0;
			id_khoxuat = 0;
			id_khachhang = "";
			id_nhacungcap = 0;
			id_loainhap = 0;
			ngaynhaphang = DateTime.MinValue;
			ghichu = "";
			soluong = 0;
			thanhtien = 0;
			id_trangthaiphieu = 0;
			createdtime = DateTime.MinValue;
			createdby = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
		}

		public Ob_POS_NhapHang_H( string new_id_phieunhaphang_h, string new_maphieunhaphang, int new_id_cuahang, int new_id_kho, int new_id_khoxuat, string new_id_khachhang, int new_id_nhacungcap, int new_id_loainhap, DateTime new_ngaynhaphang, string new_ghichu, int new_soluong, double new_thanhtien, int new_id_trangthaiphieu, DateTime new_createdtime, string new_createdby, DateTime new_modifiedtime, string new_modifiedby)	
		{
			id_phieunhaphang_h = new_id_phieunhaphang_h;
			maphieunhaphang = new_maphieunhaphang;
			id_cuahang = new_id_cuahang;
			id_kho = new_id_kho;
			id_khoxuat = new_id_khoxuat;
			id_khachhang = new_id_khachhang;
			id_nhacungcap = new_id_nhacungcap;
			id_loainhap = new_id_loainhap;
			ngaynhaphang = new_ngaynhaphang;
			ghichu = new_ghichu;
			soluong = new_soluong;
			thanhtien = new_thanhtien;
			id_trangthaiphieu = new_id_trangthaiphieu;
			createdtime = new_createdtime;
			createdby = new_createdby;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
		}

		public Ob_POS_NhapHang_H(Ob_POS_NhapHang_H newOb)
		{
			id_phieunhaphang_h = newOb.ID_PHIEUNHAPHANG_H;
			maphieunhaphang = newOb.MAPHIEUNHAPHANG;
			id_cuahang = newOb.ID_CUAHANG;
			id_kho = newOb.ID_KHO;
			id_khoxuat = newOb.ID_KHOXUAT;
			id_khachhang = newOb.ID_KHACHHANG;
			id_nhacungcap = newOb.ID_NHACUNGCAP;
			id_loainhap = newOb.ID_LOAINHAP;
			ngaynhaphang = newOb.NGAYNHAPHANG;
			ghichu = newOb.GHICHU;
			soluong = newOb.SOLUONG;
			thanhtien = newOb.THANHTIEN;
			id_trangthaiphieu = newOb.ID_TRANGTHAIPHIEU;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
		}

	}
}
