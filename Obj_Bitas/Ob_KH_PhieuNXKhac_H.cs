using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 12/07/2016 14:13:44.PM

namespace Bitas
{
	public class Ob_KH_PhieuNXKhac_H
	{
		private string id_nx_khac_h;
		private string maphieunxkhac;
		private DateTime ngaytao;
		private int id_kho;
		private int id_nguoidung;
		private string ghichu;
		private int id_nhaptu;
		private int id_loainx;
		private int tongsoluong;
		private decimal tongtien;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_NX_KHAC_H{ get { return id_nx_khac_h; } set { id_nx_khac_h = value; }}
		public string MAPHIEUNXKHAC{ get { return maphieunxkhac; } set { maphieunxkhac = value; }}
		public DateTime NGAYTAO{ get { return ngaytao; } set { ngaytao = value; }}
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public int ID_NGUOIDUNG{ get { return id_nguoidung; } set { id_nguoidung = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public int ID_NHAPTU{ get { return id_nhaptu; } set { id_nhaptu = value; }}
		public int ID_LOAINX{ get { return id_loainx; } set { id_loainx = value; }}
		public int TONGSOLUONG{ get { return tongsoluong; } set { tongsoluong = value; }}
		public decimal TONGTIEN{ get { return tongtien; } set { tongtien = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_PhieuNXKhac_H()
		{
			id_nx_khac_h = "";
			maphieunxkhac = "";
			ngaytao = DateTime.MinValue;
			id_kho = 0;
			id_nguoidung = 0;
			ghichu = "";
			id_nhaptu = 0;
			id_loainx = 0;
			tongsoluong = 0;
			tongtien = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_PhieuNXKhac_H(string new_id_nx_khac_h, string new_maphieunxkhac, DateTime new_ngaytao, int new_id_kho, int new_id_nguoidung, string new_ghichu, int new_id_nhaptu, int new_id_loainx, int new_tongsoluong, decimal new_tongtien, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_nx_khac_h = new_id_nx_khac_h;
			maphieunxkhac = new_maphieunxkhac;
			ngaytao = new_ngaytao;
			id_kho = new_id_kho;
			id_nguoidung = new_id_nguoidung;
			ghichu = new_ghichu;
			id_nhaptu = new_id_nhaptu;
			id_loainx = new_id_loainx;
			tongsoluong = new_tongsoluong;
			tongtien = new_tongtien;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_PhieuNXKhac_H(Ob_KH_PhieuNXKhac_H newOb)
		{
			id_nx_khac_h = newOb.ID_NX_KHAC_H;
			maphieunxkhac = newOb.MAPHIEUNXKHAC;
			ngaytao = newOb.NGAYTAO;
			id_kho = newOb.ID_KHO;
			id_nguoidung = newOb.ID_NGUOIDUNG;
			ghichu = newOb.GHICHU;
			id_nhaptu = newOb.ID_NHAPTU;
			id_loainx = newOb.ID_LOAINX;
			tongsoluong = newOb.TONGSOLUONG;
			tongtien = newOb.TONGTIEN;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
