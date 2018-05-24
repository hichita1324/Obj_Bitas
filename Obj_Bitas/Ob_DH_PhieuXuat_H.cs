using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 01/10/2016 09:55:25.AM

namespace Bitas
{
	public class Ob_DH_PhieuXuat_H
	{
		private string id_phieuxuat_h;
		private string maphieuxuat;
		private string id_phieuyc_h;
		private DateTime ngaytao;
		private DateTime ngayxuat;
		private string id_khachhang;
		private double congnothucte;
		private int tongsoluong;
		private double tongtien;
		private double trucoc;
		private double tongtienthanhtoan;
		private string ghichu;
		private int id_trangthai;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_PHIEUXUAT_H{ get { return id_phieuxuat_h; } set { id_phieuxuat_h = value; }}
		public string MAPHIEUXUAT{ get { return maphieuxuat; } set { maphieuxuat = value; }}
		public string ID_PHIEUYC_H{ get { return id_phieuyc_h; } set { id_phieuyc_h = value; }}
		public DateTime NGAYTAO{ get { return ngaytao; } set { ngaytao = value; }}
		public DateTime NGAYXUAT{ get { return ngayxuat; } set { ngayxuat = value; }}
		public string ID_KHACHHANG{ get { return id_khachhang; } set { id_khachhang = value; }}
		public double CONGNOTHUCTE{ get { return congnothucte; } set { congnothucte = value; }}
		public int TONGSOLUONG{ get { return tongsoluong; } set { tongsoluong = value; }}
		public double TONGTIEN{ get { return tongtien; } set { tongtien = value; }}
		public double TRUCOC{ get { return trucoc; } set { trucoc = value; }}
		public double TONGTIENTHANHTOAN{ get { return tongtienthanhtoan; } set { tongtienthanhtoan = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public int ID_TRANGTHAI{ get { return id_trangthai; } set { id_trangthai = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DH_PhieuXuat_H()
		{
			id_phieuxuat_h = "";
			maphieuxuat = "";
			id_phieuyc_h = "";
			ngaytao = DateTime.MinValue;
			ngayxuat = DateTime.MinValue;
			id_khachhang = "";
			congnothucte = 0;
			tongsoluong = 0;
			tongtien = 0;
			trucoc = 0;
			tongtienthanhtoan = 0;
			ghichu = "";
			id_trangthai = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DH_PhieuXuat_H( string new_id_phieuxuat_h, string new_maphieuxuat, string new_id_phieuyc_h, DateTime new_ngaytao, DateTime new_ngayxuat, string new_id_khachhang, double new_congnothucte, int new_tongsoluong, double new_tongtien, double new_trucoc, double new_tongtienthanhtoan, string new_ghichu, int new_id_trangthai, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_phieuxuat_h = new_id_phieuxuat_h;
			maphieuxuat = new_maphieuxuat;
			id_phieuyc_h = new_id_phieuyc_h;
			ngaytao = new_ngaytao;
			ngayxuat = new_ngayxuat;
			id_khachhang = new_id_khachhang;
			congnothucte = new_congnothucte;
			tongsoluong = new_tongsoluong;
			tongtien = new_tongtien;
			trucoc = new_trucoc;
			tongtienthanhtoan = new_tongtienthanhtoan;
			ghichu = new_ghichu;
			id_trangthai = new_id_trangthai;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DH_PhieuXuat_H(Ob_DH_PhieuXuat_H newOb)
		{
			id_phieuxuat_h = newOb.ID_PHIEUXUAT_H;
			maphieuxuat = newOb.MAPHIEUXUAT;
			id_phieuyc_h = newOb.ID_PHIEUYC_H;
			ngaytao = newOb.NGAYTAO;
			ngayxuat = newOb.NGAYXUAT;
			id_khachhang = newOb.ID_KHACHHANG;
			congnothucte = newOb.CONGNOTHUCTE;
			tongsoluong = newOb.TONGSOLUONG;
			tongtien = newOb.TONGTIEN;
			trucoc = newOb.TRUCOC;
			tongtienthanhtoan = newOb.TONGTIENTHANHTOAN;
			ghichu = newOb.GHICHU;
			id_trangthai = newOb.ID_TRANGTHAI;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
