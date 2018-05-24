using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:37:41.AM

namespace Bitas
{
	public class Ob_DM_Kho
	{
		private int id_kho;
		private string makho;
		private string tenkho;
		private int id_chinhanh;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public string MAKHO{ get { return makho; } set { makho = value; }}
		public string TENKHO{ get { return tenkho; } set { tenkho = value; }}
		public int ID_CHINHANH{ get { return id_chinhanh; } set { id_chinhanh = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_Kho()
		{
			id_kho = 0;
			makho = "";
			tenkho = "";
			id_chinhanh = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_Kho( int new_id_kho, string new_makho, string new_tenkho, int new_id_chinhanh, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_kho = new_id_kho;
			makho = new_makho;
			tenkho = new_tenkho;
			id_chinhanh = new_id_chinhanh;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_Kho(Ob_DM_Kho newOb)
		{
			id_kho = newOb.ID_KHO;
			makho = newOb.MAKHO;
			tenkho = newOb.TENKHO;
			id_chinhanh = newOb.ID_CHINHANH;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
