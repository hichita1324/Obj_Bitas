using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 27/07/2016 09:32:25.AM

namespace Bitas
{
	public class Ob_HT_NguoiDung
	{
		private int id_nguoidung;
		private string taikhoan;
		private string matkhau;
		private string ho;
		private string ten;
		private int id_nhomnd;
		private int id_chinhanh;
		private int id_truso;
		private string email;
		private bool trangthai;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_NGUOIDUNG{ get { return id_nguoidung; } set { id_nguoidung = value; }}
		public string TAIKHOAN{ get { return taikhoan; } set { taikhoan = value; }}
		public string MATKHAU{ get { return matkhau; } set { matkhau = value; }}
		public string HO{ get { return ho; } set { ho = value; }}
		public string TEN{ get { return ten; } set { ten = value; }}
		public int ID_NHOMND{ get { return id_nhomnd; } set { id_nhomnd = value; }}
		public int ID_CHINHANH{ get { return id_chinhanh; } set { id_chinhanh = value; }}
		public int ID_TRUSO{ get { return id_truso; } set { id_truso = value; }}
		public string EMAIL{ get { return email; } set { email = value; }}
		public bool TRANGTHAI{ get { return trangthai; } set { trangthai = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_HT_NguoiDung()
		{
			id_nguoidung = 0;
			taikhoan = "";
			matkhau = "";
			ho = "";
			ten = "";
			id_nhomnd = 0;
			id_chinhanh = 0;
			id_truso = 0;
			email = "";
			trangthai = false;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_HT_NguoiDung( int new_id_nguoidung, string new_taikhoan, string new_matkhau, string new_ho, string new_ten, int new_id_nhomnd, int new_id_chinhanh, int new_id_truso, string new_email, bool new_trangthai, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_nguoidung = new_id_nguoidung;
			taikhoan = new_taikhoan;
			matkhau = new_matkhau;
			ho = new_ho;
			ten = new_ten;
			id_nhomnd = new_id_nhomnd;
			id_chinhanh = new_id_chinhanh;
			id_truso = new_id_truso;
			email = new_email;
			trangthai = new_trangthai;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_HT_NguoiDung(Ob_HT_NguoiDung newOb)
		{
			id_nguoidung = newOb.ID_NGUOIDUNG;
			taikhoan = newOb.TAIKHOAN;
			matkhau = newOb.MATKHAU;
			ho = newOb.HO;
			ten = newOb.TEN;
			id_nhomnd = newOb.ID_NHOMND;
			id_chinhanh = newOb.ID_CHINHANH;
			id_truso = newOb.ID_TRUSO;
			email = newOb.EMAIL;
			trangthai = newOb.TRANGTHAI;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
