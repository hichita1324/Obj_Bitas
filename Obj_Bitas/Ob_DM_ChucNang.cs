using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:37:00.AM

namespace Bitas
{
	public class Ob_DM_ChucNang
	{
		private int id_chucnang;
		private string machucnang;
		private string tenchucnang;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_CHUCNANG{ get { return id_chucnang; } set { id_chucnang = value; }}
		public string MACHUCNANG{ get { return machucnang; } set { machucnang = value; }}
		public string TENCHUCNANG{ get { return tenchucnang; } set { tenchucnang = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_ChucNang()
		{
			id_chucnang = 0;
			machucnang = "";
			tenchucnang = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_ChucNang( int new_id_chucnang, string new_machucnang, string new_tenchucnang, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_chucnang = new_id_chucnang;
			machucnang = new_machucnang;
			tenchucnang = new_tenchucnang;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_ChucNang(Ob_DM_ChucNang newOb)
		{
			id_chucnang = newOb.ID_CHUCNANG;
			machucnang = newOb.MACHUCNANG;
			tenchucnang = newOb.TENCHUCNANG;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
