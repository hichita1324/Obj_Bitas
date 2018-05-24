using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:36:37.AM

namespace Bitas
{
	public class Ob_DM_BangGia
	{
		private int id_banggia;
		private string mabanggia;
		private string tenbanggia;
		private int id_donvitien;
		private bool trangthai;
		private DateTime modifieddate;
		private string modifiedby;
		private DateTime createddate;
		private string createdby;
		public int ID_BANGGIA{ get { return id_banggia; } set { id_banggia = value; }}
		public string MABANGGIA{ get { return mabanggia; } set { mabanggia = value; }}
		public string TENBANGGIA{ get { return tenbanggia; } set { tenbanggia = value; }}
		public int ID_DONVITIEN{ get { return id_donvitien; } set { id_donvitien = value; }}
		public bool TRANGTHAI{ get { return trangthai; } set { trangthai = value; }}
		public DateTime MODIFIEDDATE{ get { return modifieddate; } set { modifieddate = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDDATE{ get { return createddate; } set { createddate = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_BangGia()
		{
			id_banggia = 0;
			mabanggia = "";
			tenbanggia = "";
			id_donvitien = 0;
			trangthai = false;
			modifieddate = DateTime.MinValue;
			modifiedby = "";
			createddate = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_BangGia( int new_id_banggia, string new_mabanggia, string new_tenbanggia, int new_id_donvitien, bool new_trangthai, DateTime new_modifieddate, string new_modifiedby, DateTime new_createddate, string new_createdby)	
		{
			id_banggia = new_id_banggia;
			mabanggia = new_mabanggia;
			tenbanggia = new_tenbanggia;
			id_donvitien = new_id_donvitien;
			trangthai = new_trangthai;
			modifieddate = new_modifieddate;
			modifiedby = new_modifiedby;
			createddate = new_createddate;
			createdby = new_createdby;
		}

		public Ob_DM_BangGia(Ob_DM_BangGia newOb)
		{
			id_banggia = newOb.ID_BANGGIA;
			mabanggia = newOb.MABANGGIA;
			tenbanggia = newOb.TENBANGGIA;
			id_donvitien = newOb.ID_DONVITIEN;
			trangthai = newOb.TRANGTHAI;
			modifieddate = newOb.MODIFIEDDATE;
			modifiedby = newOb.MODIFIEDBY;
			createddate = newOb.CREATEDDATE;
			createdby = newOb.CREATEDBY;
		}

	}
}
