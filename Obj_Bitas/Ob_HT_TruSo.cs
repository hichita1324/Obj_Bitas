using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 28/07/2016 11:18:02.AM

namespace Bitas
{
	public class Ob_HT_TruSo
	{
		private int id_truso;
		private string matruso;
		private string tentruso;
		private string capcha;
		private int bac;
		private int vitri;
		private int id_donvi;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_TRUSO{ get { return id_truso; } set { id_truso = value; }}
		public string MATRUSO{ get { return matruso; } set { matruso = value; }}
		public string TENTRUSO{ get { return tentruso; } set { tentruso = value; }}
		public string CAPCHA{ get { return capcha; } set { capcha = value; }}
		public int BAC{ get { return bac; } set { bac = value; }}
		public int VITRI{ get { return vitri; } set { vitri = value; }}
		public int ID_DONVI{ get { return id_donvi; } set { id_donvi = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_HT_TruSo()
		{
			id_truso = 0;
			matruso = "";
			tentruso = "";
			capcha = "";
			bac = 0;
			vitri = 0;
			id_donvi = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_HT_TruSo( int new_id_truso, string new_matruso, string new_tentruso, string new_capcha, int new_bac, int new_vitri, int new_id_donvi, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_truso = new_id_truso;
			matruso = new_matruso;
			tentruso = new_tentruso;
			capcha = new_capcha;
			bac = new_bac;
			vitri = new_vitri;
			id_donvi = new_id_donvi;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_HT_TruSo(Ob_HT_TruSo newOb)
		{
			id_truso = newOb.ID_TRUSO;
			matruso = newOb.MATRUSO;
			tentruso = newOb.TENTRUSO;
			capcha = newOb.CAPCHA;
			bac = newOb.BAC;
			vitri = newOb.VITRI;
			id_donvi = newOb.ID_DONVI;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
