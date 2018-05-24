using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:36:53.AM

namespace Bitas
{
	public class Ob_DM_ChungLoai
	{
		private int id_chungloai;
		private string machungloai;
		private string tenchungloai;
		private int idx;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_CHUNGLOAI{ get { return id_chungloai; } set { id_chungloai = value; }}
		public string MACHUNGLOAI{ get { return machungloai; } set { machungloai = value; }}
		public string TENCHUNGLOAI{ get { return tenchungloai; } set { tenchungloai = value; }}
		public int IDX{ get { return idx; } set { idx = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_ChungLoai()
		{
			id_chungloai = 0;
			machungloai = "";
			tenchungloai = "";
			idx = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_ChungLoai( int new_id_chungloai, string new_machungloai, string new_tenchungloai, int new_idx, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_chungloai = new_id_chungloai;
			machungloai = new_machungloai;
			tenchungloai = new_tenchungloai;
			idx = new_idx;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_ChungLoai(Ob_DM_ChungLoai newOb)
		{
			id_chungloai = newOb.ID_CHUNGLOAI;
			machungloai = newOb.MACHUNGLOAI;
			tenchungloai = newOb.TENCHUNGLOAI;
			idx = newOb.IDX;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
