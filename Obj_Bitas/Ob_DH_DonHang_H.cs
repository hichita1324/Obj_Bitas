using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 08/08/2016 15:09:17.PM

namespace Bitas
{
	public class Ob_DH_DonHang_H
	{
		private string id_donhang_h;
		private int madonhang;
		private DateTime ngaytao;
		private string id_khachhang;
		private int id_loaidh;
		private string ghichu;
		private DateTime ngaydatcoc;
		private double pt_datcoc;
		private double tiendatcoc;
		private int id_trangthai;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_DONHANG_H{ get { return id_donhang_h; } set { id_donhang_h = value; }}
		public int MADONHANG{ get { return madonhang; } set { madonhang = value; }}
		public DateTime NGAYTAO{ get { return ngaytao; } set { ngaytao = value; }}
		public string ID_KHACHHANG{ get { return id_khachhang; } set { id_khachhang = value; }}
		public int ID_LOAIDH{ get { return id_loaidh; } set { id_loaidh = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public DateTime NGAYDATCOC{ get { return ngaydatcoc; } set { ngaydatcoc = value; }}
		public double PT_DATCOC{ get { return pt_datcoc; } set { pt_datcoc = value; }}
		public double TIENDATCOC{ get { return tiendatcoc; } set { tiendatcoc = value; }}
		public int ID_TRANGTHAI{ get { return id_trangthai; } set { id_trangthai = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DH_DonHang_H()
		{
			id_donhang_h = "";
			madonhang = 0;
			ngaytao = DateTime.MinValue;
			id_khachhang = "";
			id_loaidh = 0;
			ghichu = "";
			ngaydatcoc = DateTime.MinValue;
			pt_datcoc = 0;
			tiendatcoc = 0;
			id_trangthai = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DH_DonHang_H( string new_id_donhang_h, int new_madonhang, DateTime new_ngaytao, string new_id_khachhang, int new_id_loaidh, string new_ghichu, DateTime new_ngaydatcoc, double new_pt_datcoc, double new_tiendatcoc, int new_id_trangthai, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_donhang_h = new_id_donhang_h;
			madonhang = new_madonhang;
			ngaytao = new_ngaytao;
			id_khachhang = new_id_khachhang;
			id_loaidh = new_id_loaidh;
			ghichu = new_ghichu;
			ngaydatcoc = new_ngaydatcoc;
			pt_datcoc = new_pt_datcoc;
			tiendatcoc = new_tiendatcoc;
			id_trangthai = new_id_trangthai;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DH_DonHang_H(Ob_DH_DonHang_H newOb)
		{
			id_donhang_h = newOb.ID_DONHANG_H;
			madonhang = newOb.MADONHANG;
			ngaytao = newOb.NGAYTAO;
			id_khachhang = newOb.ID_KHACHHANG;
			id_loaidh = newOb.ID_LOAIDH;
			ghichu = newOb.GHICHU;
			ngaydatcoc = newOb.NGAYDATCOC;
			pt_datcoc = newOb.PT_DATCOC;
			tiendatcoc = newOb.TIENDATCOC;
			id_trangthai = newOb.ID_TRANGTHAI;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
