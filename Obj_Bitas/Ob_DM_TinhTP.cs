using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:44:19.AM

namespace Bitas
{
	public class Ob_DM_TinhTP
	{
		private int id_tinhtp;
		private string matinhtp;
		private string tentinhtp;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_TINHTP{ get { return id_tinhtp; } set { id_tinhtp = value; }}
		public string MATINHTP{ get { return matinhtp; } set { matinhtp = value; }}
		public string TENTINHTP{ get { return tentinhtp; } set { tentinhtp = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_TinhTP()
		{
			id_tinhtp = 0;
			matinhtp = "";
			tentinhtp = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_TinhTP( int new_id_tinhtp, string new_matinhtp, string new_tentinhtp, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_tinhtp = new_id_tinhtp;
			matinhtp = new_matinhtp;
			tentinhtp = new_tentinhtp;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_TinhTP(Ob_DM_TinhTP newOb)
		{
			id_tinhtp = newOb.ID_TINHTP;
			matinhtp = newOb.MATINHTP;
			tentinhtp = newOb.TENTINHTP;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
