using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:44:06.AM

namespace Bitas
{
	public class Ob_DM_NhomSize_L
	{
		private int id_nhomsize;
		private int dong;
		private string size;
		private int idx;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_NHOMSIZE{ get { return id_nhomsize; } set { id_nhomsize = value; }}
		public int DONG{ get { return dong; } set { dong = value; }}
		public string SIZE{ get { return size; } set { size = value; }}
		public int IDX{ get { return idx; } set { idx = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_NhomSize_L()
		{
			id_nhomsize = 0;
			dong = 0;
			size = "";
			idx = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_NhomSize_L( int new_id_nhomsize, int new_dong, string new_size, int new_idx, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_nhomsize = new_id_nhomsize;
			dong = new_dong;
			size = new_size;
			idx = new_idx;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_NhomSize_L(Ob_DM_NhomSize_L newOb)
		{
			id_nhomsize = newOb.ID_NHOMSIZE;
			dong = newOb.DONG;
			size = newOb.SIZE;
			idx = newOb.IDX;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
