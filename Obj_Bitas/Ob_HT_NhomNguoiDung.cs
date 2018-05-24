using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:44:44.AM

namespace Bitas
{
	public class Ob_HT_NhomNguoiDung
	{
		private int id_nhomnd;
		private string manhomnd;
		private string tennhomnd;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createby;
		public int ID_NHOMND{ get { return id_nhomnd; } set { id_nhomnd = value; }}
		public string MANHOMND{ get { return manhomnd; } set { manhomnd = value; }}
		public string TENNHOMND{ get { return tennhomnd; } set { tennhomnd = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEBY{ get { return createby; } set { createby = value; }}

		public Ob_HT_NhomNguoiDung()
		{
			id_nhomnd = 0;
			manhomnd = "";
			tennhomnd = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createby = "";
		}

		public Ob_HT_NhomNguoiDung( int new_id_nhomnd, string new_manhomnd, string new_tennhomnd, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createby)	
		{
			id_nhomnd = new_id_nhomnd;
			manhomnd = new_manhomnd;
			tennhomnd = new_tennhomnd;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createby = new_createby;
		}

		public Ob_HT_NhomNguoiDung(Ob_HT_NhomNguoiDung newOb)
		{
			id_nhomnd = newOb.ID_NHOMND;
			manhomnd = newOb.MANHOMND;
			tennhomnd = newOb.TENNHOMND;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createby = newOb.CREATEBY;
		}

	}
}
