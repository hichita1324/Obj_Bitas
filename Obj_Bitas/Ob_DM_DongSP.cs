using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:37:12.AM

namespace Bitas
{
	public class Ob_DM_DongSP
	{
		private int id_dongsp;
		private string madongsp;
		private string tendongsp;
		private int id_chungloai;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_DONGSP{ get { return id_dongsp; } set { id_dongsp = value; }}
		public string MADONGSP{ get { return madongsp; } set { madongsp = value; }}
		public string TENDONGSP{ get { return tendongsp; } set { tendongsp = value; }}
		public int ID_CHUNGLOAI{ get { return id_chungloai; } set { id_chungloai = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_DongSP()
		{
			id_dongsp = 0;
			madongsp = "";
			tendongsp = "";
			id_chungloai = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_DongSP( int new_id_dongsp, string new_madongsp, string new_tendongsp, int new_id_chungloai, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_dongsp = new_id_dongsp;
			madongsp = new_madongsp;
			tendongsp = new_tendongsp;
			id_chungloai = new_id_chungloai;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_DongSP(Ob_DM_DongSP newOb)
		{
			id_dongsp = newOb.ID_DONGSP;
			madongsp = newOb.MADONGSP;
			tendongsp = newOb.TENDONGSP;
			id_chungloai = newOb.ID_CHUNGLOAI;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
