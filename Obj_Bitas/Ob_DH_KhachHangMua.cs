using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 12/08/2016 14:16:35.PM

namespace Bitas
{
	public class Ob_DH_KhachHangMua
	{
		private string id_khachhangmua;
		private int id_loaidh;
		private string id_khachhang;
		private int id_ban;
		private double muckhoan;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_KHACHHANGMUA{ get { return id_khachhangmua; } set { id_khachhangmua = value; }}
		public int ID_LOAIDH{ get { return id_loaidh; } set { id_loaidh = value; }}
		public string ID_KHACHHANG{ get { return id_khachhang; } set { id_khachhang = value; }}
		public int ID_BAN{ get { return id_ban; } set { id_ban = value; }}
		public double MUCKHOAN{ get { return muckhoan; } set { muckhoan = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DH_KhachHangMua()
		{
			id_khachhangmua = "";
			id_loaidh = 0;
			id_khachhang = "";
			id_ban = 0;
			muckhoan = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DH_KhachHangMua( string new_id_khachhangmua, int new_id_loaidh, string new_id_khachhang, int new_id_ban, double new_muckhoan, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_khachhangmua = new_id_khachhangmua;
			id_loaidh = new_id_loaidh;
			id_khachhang = new_id_khachhang;
			id_ban = new_id_ban;
			muckhoan = new_muckhoan;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DH_KhachHangMua(Ob_DH_KhachHangMua newOb)
		{
			id_khachhangmua = newOb.ID_KHACHHANGMUA;
			id_loaidh = newOb.ID_LOAIDH;
			id_khachhang = newOb.ID_KHACHHANG;
			id_ban = newOb.ID_BAN;
			muckhoan = newOb.MUCKHOAN;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
