using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:44:01.AM

namespace Bitas
{
	public class Ob_DM_NhomSize_H
	{
		private int id_nhomsize;
		private string manhomsize;
		private string sizemin;
		private string sizemax;
		private int idx;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_NHOMSIZE{ get { return id_nhomsize; } set { id_nhomsize = value; }}
		public string MANHOMSIZE{ get { return manhomsize; } set { manhomsize = value; }}
		public string SIZEMIN{ get { return sizemin; } set { sizemin = value; }}
		public string SIZEMAX{ get { return sizemax; } set { sizemax = value; }}
		public int IDX{ get { return idx; } set { idx = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_NhomSize_H()
		{
			id_nhomsize = 0;
			manhomsize = "";
			sizemin = "";
			sizemax = "";
			idx = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_NhomSize_H( int new_id_nhomsize, string new_manhomsize, string new_sizemin, string new_sizemax, int new_idx, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_nhomsize = new_id_nhomsize;
			manhomsize = new_manhomsize;
			sizemin = new_sizemin;
			sizemax = new_sizemax;
			idx = new_idx;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_NhomSize_H(Ob_DM_NhomSize_H newOb)
		{
			id_nhomsize = newOb.ID_NHOMSIZE;
			manhomsize = newOb.MANHOMSIZE;
			sizemin = newOb.SIZEMIN;
			sizemax = newOb.SIZEMAX;
			idx = newOb.IDX;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
