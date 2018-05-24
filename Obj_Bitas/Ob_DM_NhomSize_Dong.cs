using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 24/03/2016 17:01:38.PM

namespace Bitas
{
	public class Ob_DM_NhomSize_Dong
	{
		private int id_nhomsize;
		private int dong;
		private string sizemin;
		private string sizemax;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_NHOMSIZE{ get { return id_nhomsize; } set { id_nhomsize = value; }}
		public int DONG{ get { return dong; } set { dong = value; }}
		public string SIZEMIN{ get { return sizemin; } set { sizemin = value; }}
		public string SIZEMAX{ get { return sizemax; } set { sizemax = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_NhomSize_Dong()
		{
			id_nhomsize = 0;
			dong = 0;
			sizemin = "";
			sizemax = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_NhomSize_Dong( int new_id_nhomsize, int new_dong, string new_sizemin, string new_sizemax, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_nhomsize = new_id_nhomsize;
			dong = new_dong;
			sizemin = new_sizemin;
			sizemax = new_sizemax;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_NhomSize_Dong(Ob_DM_NhomSize_Dong newOb)
		{
			id_nhomsize = newOb.ID_NHOMSIZE;
			dong = newOb.DONG;
			sizemin = newOb.SIZEMIN;
			sizemax = newOb.SIZEMAX;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
