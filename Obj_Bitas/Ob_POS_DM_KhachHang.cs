using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/12/2017 16:42:51.PM

namespace Bitas
{
	public class Ob_POS_DM_KhachHang
	{
		private string id_khachhang;
		private string tenkhachhang;
		private string sodienthoai;
		private string diachi;
		private int id_loaikh;
		private int idx;
		private int diemtichluy;
		private bool active;
		private DateTime createdtime;
		private string createdby;
		private DateTime modifiedtime;
		private string modifiedby;
		public string ID_KHACHHANG{ get { return id_khachhang; } set { id_khachhang = value; }}
		public string TENKHACHHANG{ get { return tenkhachhang; } set { tenkhachhang = value; }}
		public string SODIENTHOAI{ get { return sodienthoai; } set { sodienthoai = value; }}
		public string DIACHI{ get { return diachi; } set { diachi = value; }}
		public int ID_LOAIKH{ get { return id_loaikh; } set { id_loaikh = value; }}
		public int IDX{ get { return idx; } set { idx = value; }}
		public int DIEMTICHLUY{ get { return diemtichluy; } set { diemtichluy = value; }}
		public bool ACTIVE{ get { return active; } set { active = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}

		public Ob_POS_DM_KhachHang()
		{
			id_khachhang = "";
			tenkhachhang = "";
			sodienthoai = "";
			diachi = "";
			id_loaikh = 0;
			idx = 0;
			diemtichluy = 0;
			active = false;
			createdtime = DateTime.MinValue;
			createdby = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
		}

		public Ob_POS_DM_KhachHang( string new_id_khachhang, string new_tenkhachhang, string new_sodienthoai, string new_diachi, int new_id_loaikh, int new_idx, int new_diemtichluy, bool new_active, DateTime new_createdtime, string new_createdby, DateTime new_modifiedtime, string new_modifiedby)	
		{
			id_khachhang = new_id_khachhang;
			tenkhachhang = new_tenkhachhang;
			sodienthoai = new_sodienthoai;
			diachi = new_diachi;
			id_loaikh = new_id_loaikh;
			idx = new_idx;
			diemtichluy = new_diemtichluy;
			active = new_active;
			createdtime = new_createdtime;
			createdby = new_createdby;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
		}

		public Ob_POS_DM_KhachHang(Ob_POS_DM_KhachHang newOb)
		{
			id_khachhang = newOb.ID_KHACHHANG;
			tenkhachhang = newOb.TENKHACHHANG;
			sodienthoai = newOb.SODIENTHOAI;
			diachi = newOb.DIACHI;
			id_loaikh = newOb.ID_LOAIKH;
			idx = newOb.IDX;
			diemtichluy = newOb.DIEMTICHLUY;
			active = newOb.ACTIVE;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
		}

	}
}
