using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:37:52.AM

namespace Bitas
{
	public class Ob_DM_LoaiHang
	{
		private int id_loaihang;
		private string maloaihang;
		private string tenloaihang;
		private int idx;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_LOAIHANG{ get { return id_loaihang; } set { id_loaihang = value; }}
		public string MALOAIHANG{ get { return maloaihang; } set { maloaihang = value; }}
		public string TENLOAIHANG{ get { return tenloaihang; } set { tenloaihang = value; }}
		public int IDX{ get { return idx; } set { idx = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_LoaiHang()
		{
			id_loaihang = 0;
			maloaihang = "";
			tenloaihang = "";
			idx = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_LoaiHang( int new_id_loaihang, string new_maloaihang, string new_tenloaihang, int new_idx, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_loaihang = new_id_loaihang;
			maloaihang = new_maloaihang;
			tenloaihang = new_tenloaihang;
			idx = new_idx;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_LoaiHang(Ob_DM_LoaiHang newOb)
		{
			id_loaihang = newOb.ID_LOAIHANG;
			maloaihang = newOb.MALOAIHANG;
			tenloaihang = newOb.TENLOAIHANG;
			idx = newOb.IDX;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
