using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 09/07/2016 10:11:44.AM

namespace Bitas
{
	public class Ob_KH_NhapTu
	{
		private int id_nhaptu;
		private string manhaptu;
		private string tennhaptu;
		private string ghichu;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_NHAPTU{ get { return id_nhaptu; } set { id_nhaptu = value; }}
		public string MANHAPTU{ get { return manhaptu; } set { manhaptu = value; }}
		public string TENNHAPTU{ get { return tennhaptu; } set { tennhaptu = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_NhapTu()
		{
			id_nhaptu = 0;
			manhaptu = "";
			tennhaptu = "";
			ghichu = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_NhapTu(int new_id_nhaptu, string new_manhaptu, string new_tennhaptu, string new_ghichu, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_nhaptu = new_id_nhaptu;
			manhaptu = new_manhaptu;
			tennhaptu = new_tennhaptu;
			ghichu = new_ghichu;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_NhapTu(Ob_KH_NhapTu newOb)
		{
			id_nhaptu = newOb.ID_NHAPTU;
			manhaptu = newOb.MANHAPTU;
			tennhaptu = newOb.TENNHAPTU;
			ghichu = newOb.GHICHU;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
