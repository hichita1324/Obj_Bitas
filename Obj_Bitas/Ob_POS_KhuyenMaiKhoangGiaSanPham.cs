using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 17/03/2017 15:36:06.PM

namespace Bitas
{
	public class Ob_POS_KhuyenMaiKhoangGiaSanPham
	{
		private long id_khoanggia;
		private int id_khuyenmai;
		private double tugiatri;
		private double dengiatri;
		private double giamgiapt;
		private double giamgiatien;
		private long id_sanpham;
		private int soluong;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public long ID_KHOANGGIA{ get { return id_khoanggia; } set { id_khoanggia = value; }}
		public int ID_KHUYENMAI{ get { return id_khuyenmai; } set { id_khuyenmai = value; }}
		public double TUGIATRI{ get { return tugiatri; } set { tugiatri = value; }}
		public double DENGIATRI{ get { return dengiatri; } set { dengiatri = value; }}
		public double GIAMGIAPT{ get { return giamgiapt; } set { giamgiapt = value; }}
		public double GIAMGIATIEN{ get { return giamgiatien; } set { giamgiatien = value; }}
		public long ID_SANPHAM{ get { return id_sanpham; } set { id_sanpham = value; }}
		public int SOLUONG{ get { return soluong; } set { soluong = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_POS_KhuyenMaiKhoangGiaSanPham()
		{
			id_khuyenmai = 0;
			tugiatri = 0;
			dengiatri = 0;
			giamgiatien = 0;
			soluong = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_POS_KhuyenMaiKhoangGiaSanPham( long new_id_khoanggia, int new_id_khuyenmai, double new_tugiatri, double new_dengiatri, double new_giamgiapt, double new_giamgiatien, long new_id_sanpham, int new_soluong, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_khoanggia = new_id_khoanggia;
			id_khuyenmai = new_id_khuyenmai;
			tugiatri = new_tugiatri;
			dengiatri = new_dengiatri;
			giamgiapt = new_giamgiapt;
			giamgiatien = new_giamgiatien;
			id_sanpham = new_id_sanpham;
			soluong = new_soluong;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_POS_KhuyenMaiKhoangGiaSanPham(Ob_POS_KhuyenMaiKhoangGiaSanPham newOb)
		{
			id_khoanggia = newOb.ID_KHOANGGIA;
			id_khuyenmai = newOb.ID_KHUYENMAI;
			tugiatri = newOb.TUGIATRI;
			dengiatri = newOb.DENGIATRI;
			giamgiapt = newOb.GIAMGIAPT;
			giamgiatien = newOb.GIAMGIATIEN;
			id_sanpham = newOb.ID_SANPHAM;
			soluong = newOb.SOLUONG;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
