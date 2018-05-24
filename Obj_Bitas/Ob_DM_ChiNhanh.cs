using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:36:48.AM

namespace Bitas
{
	public class Ob_DM_ChiNhanh
	{
		private int id_chinhanh;
		private string machinhanh;
		private string tenchinhanh;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_CHINHANH{ get { return id_chinhanh; } set { id_chinhanh = value; }}
		public string MACHINHANH{ get { return machinhanh; } set { machinhanh = value; }}
		public string TENCHINHANH{ get { return tenchinhanh; } set { tenchinhanh = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_ChiNhanh()
		{
			id_chinhanh = 0;
			machinhanh = "";
			tenchinhanh = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_ChiNhanh( int new_id_chinhanh, string new_machinhanh, string new_tenchinhanh, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_chinhanh = new_id_chinhanh;
			machinhanh = new_machinhanh;
			tenchinhanh = new_tenchinhanh;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_ChiNhanh(Ob_DM_ChiNhanh newOb)
		{
			id_chinhanh = newOb.ID_CHINHANH;
			machinhanh = newOb.MACHINHANH;
			tenchinhanh = newOb.TENCHINHANH;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
