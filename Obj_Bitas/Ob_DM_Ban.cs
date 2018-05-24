using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 17/08/2016 15:44:36.PM

namespace Bitas
{
	public class Ob_DM_Ban
	{
		private int id_ban;
		private string maban;
		private string tenban;
		private bool active;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_BAN{ get { return id_ban; } set { id_ban = value; }}
		public string MABAN{ get { return maban; } set { maban = value; }}
		public string TENBAN{ get { return tenban; } set { tenban = value; }}
		public bool ACTIVE{ get { return active; } set { active = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_Ban()
		{
			id_ban = 0;
			maban = "";
			tenban = "";
			active = false;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_Ban( int new_id_ban, string new_maban, string new_tenban, bool new_active, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_ban = new_id_ban;
			maban = new_maban;
			tenban = new_tenban;
			active = new_active;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_Ban(Ob_DM_Ban newOb)
		{
			id_ban = newOb.ID_BAN;
			maban = newOb.MABAN;
			tenban = newOb.TENBAN;
			active = newOb.ACTIVE;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
