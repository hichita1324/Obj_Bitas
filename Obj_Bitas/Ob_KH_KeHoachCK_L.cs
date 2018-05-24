using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 06/04/2016 08:28:58.AM

namespace Bitas
{
	public class Ob_KH_KeHoachCK_L
	{
		private int id_kehoach;
		private int id_chietkhau;
		private int dong;
		private string loaick;
		private string tenfunction;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_KEHOACH{ get { return id_kehoach; } set { id_kehoach = value; }}
		public int ID_CHIETKHAU{ get { return id_chietkhau; } set { id_chietkhau = value; }}
		public int DONG{ get { return dong; } set { dong = value; }}
		public string LOAICK{ get { return loaick; } set { loaick = value; }}
		public string TENFUNCTION{ get { return tenfunction; } set { tenfunction = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_KeHoachCK_L()
		{
			id_kehoach = 0;
			id_chietkhau = 0;
			dong = 0;
			loaick = "";
			tenfunction = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_KeHoachCK_L( int new_id_kehoach, int new_id_chietkhau, int new_dong, string new_loaick, string new_tenfunction, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_kehoach = new_id_kehoach;
			id_chietkhau = new_id_chietkhau;
			dong = new_dong;
			loaick = new_loaick;
			tenfunction = new_tenfunction;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_KeHoachCK_L(Ob_KH_KeHoachCK_L newOb)
		{
			id_kehoach = newOb.ID_KEHOACH;
			id_chietkhau = newOb.ID_CHIETKHAU;
			dong = newOb.DONG;
			loaick = newOb.LOAICK;
			tenfunction = newOb.TENFUNCTION;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
