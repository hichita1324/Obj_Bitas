using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:36:43.AM

namespace Bitas
{
	public class Ob_DM_BoSuuTap
	{
		private int id_bosuutap;
		private string mabosuutap;
		private string tenbosuutap;
		private string nam;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_BOSUUTAP{ get { return id_bosuutap; } set { id_bosuutap = value; }}
		public string MABOSUUTAP{ get { return mabosuutap; } set { mabosuutap = value; }}
		public string TENBOSUUTAP{ get { return tenbosuutap; } set { tenbosuutap = value; }}
		public string NAM{ get { return nam; } set { nam = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_BoSuuTap()
		{
			id_bosuutap = 0;
			mabosuutap = "";
			tenbosuutap = "";
			nam = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_BoSuuTap( int new_id_bosuutap, string new_mabosuutap, string new_tenbosuutap, string new_nam, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_bosuutap = new_id_bosuutap;
			mabosuutap = new_mabosuutap;
			tenbosuutap = new_tenbosuutap;
			nam = new_nam;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_BoSuuTap(Ob_DM_BoSuuTap newOb)
		{
			id_bosuutap = newOb.ID_BOSUUTAP;
			mabosuutap = newOb.MABOSUUTAP;
			tenbosuutap = newOb.TENBOSUUTAP;
			nam = newOb.NAM;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
