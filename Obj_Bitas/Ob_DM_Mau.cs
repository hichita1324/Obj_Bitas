using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:38:00.AM

namespace Bitas
{
	public class Ob_DM_Mau
	{
		private int id_mau;
		private string mamau;
		private string mamauen;
		private string tenmau;
		private string tentienganh;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_MAU{ get { return id_mau; } set { id_mau = value; }}
		public string MAMAU{ get { return mamau; } set { mamau = value; }}
		public string MAMAUEN{ get { return mamauen; } set { mamauen = value; }}
		public string TENMAU{ get { return tenmau; } set { tenmau = value; }}
		public string TENTIENGANH{ get { return tentienganh; } set { tentienganh = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_Mau()
		{
			id_mau = 0;
			mamau = "";
			mamauen = "";
			tenmau = "";
			tentienganh = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_Mau( int new_id_mau, string new_mamau, string new_mamauen, string new_tenmau, string new_tentienganh, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_mau = new_id_mau;
			mamau = new_mamau;
			mamauen = new_mamauen;
			tenmau = new_tenmau;
			tentienganh = new_tentienganh;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_Mau(Ob_DM_Mau newOb)
		{
			id_mau = newOb.ID_MAU;
			mamau = newOb.MAMAU;
			mamauen = newOb.MAMAUEN;
			tenmau = newOb.TENMAU;
			tentienganh = newOb.TENTIENGANH;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
