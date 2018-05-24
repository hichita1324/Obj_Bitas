using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:37:17.AM

namespace Bitas
{
	public class Ob_DM_DonViTien
	{
		private int id_donvitien;
		private string madonvitien;
		private string donvitien;
		private bool trangthai;
		private DateTime createddate;
		private string createdby;
		private DateTime modifieddate;
		private string modifiedby;
		public int ID_DONVITIEN{ get { return id_donvitien; } set { id_donvitien = value; }}
		public string MADONVITIEN{ get { return madonvitien; } set { madonvitien = value; }}
		public string DONVITIEN{ get { return donvitien; } set { donvitien = value; }}
		public bool TRANGTHAI{ get { return trangthai; } set { trangthai = value; }}
		public DateTime CREATEDDATE{ get { return createddate; } set { createddate = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}
		public DateTime MODIFIEDDATE{ get { return modifieddate; } set { modifieddate = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}

		public Ob_DM_DonViTien()
		{
			id_donvitien = 0;
			madonvitien = "";
			donvitien = "";
			trangthai = false;
			createddate = DateTime.MinValue;
			createdby = "";
			modifieddate = DateTime.MinValue;
			modifiedby = "";
		}

		public Ob_DM_DonViTien( int new_id_donvitien, string new_madonvitien, string new_donvitien, bool new_trangthai, DateTime new_createddate, string new_createdby, DateTime new_modifieddate, string new_modifiedby)	
		{
			id_donvitien = new_id_donvitien;
			madonvitien = new_madonvitien;
			donvitien = new_donvitien;
			trangthai = new_trangthai;
			createddate = new_createddate;
			createdby = new_createdby;
			modifieddate = new_modifieddate;
			modifiedby = new_modifiedby;
		}

		public Ob_DM_DonViTien(Ob_DM_DonViTien newOb)
		{
			id_donvitien = newOb.ID_DONVITIEN;
			madonvitien = newOb.MADONVITIEN;
			donvitien = newOb.DONVITIEN;
			trangthai = newOb.TRANGTHAI;
			createddate = newOb.CREATEDDATE;
			createdby = newOb.CREATEDBY;
			modifieddate = newOb.MODIFIEDDATE;
			modifiedby = newOb.MODIFIEDBY;
		}

	}
}
