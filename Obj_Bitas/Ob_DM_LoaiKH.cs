using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 14/04/2016 15:52:12.PM

namespace Bitas
{
	public class Ob_DM_LoaiKH
	{
		private int id_loaikh;
		private string maloaikh;
		private string tenloaikh;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_LOAIKH{ get { return id_loaikh; } set { id_loaikh = value; }}
		public string MALOAIKH{ get { return maloaikh; } set { maloaikh = value; }}
		public string TENLOAIKH{ get { return tenloaikh; } set { tenloaikh = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_LoaiKH()
		{
			id_loaikh = 0;
			maloaikh = "";
			tenloaikh = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_LoaiKH( int new_id_loaikh, string new_maloaikh, string new_tenloaikh, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_loaikh = new_id_loaikh;
			maloaikh = new_maloaikh;
			tenloaikh = new_tenloaikh;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_LoaiKH(Ob_DM_LoaiKH newOb)
		{
			id_loaikh = newOb.ID_LOAIKH;
			maloaikh = newOb.MALOAIKH;
			tenloaikh = newOb.TENLOAIKH;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
