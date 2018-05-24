using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:37:07.AM

namespace Bitas
{
	public class Ob_DM_DoiTuong
	{
		private int id_doituong;
		private string madoituong;
		private string tendoituong;
		private int idx;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_DOITUONG{ get { return id_doituong; } set { id_doituong = value; }}
		public string MADOITUONG{ get { return madoituong; } set { madoituong = value; }}
		public string TENDOITUONG{ get { return tendoituong; } set { tendoituong = value; }}
		public int IDX{ get { return idx; } set { idx = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_DoiTuong()
		{
			id_doituong = 0;
			madoituong = "";
			tendoituong = "";
			idx = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_DoiTuong( int new_id_doituong, string new_madoituong, string new_tendoituong, int new_idx, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_doituong = new_id_doituong;
			madoituong = new_madoituong;
			tendoituong = new_tendoituong;
			idx = new_idx;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_DoiTuong(Ob_DM_DoiTuong newOb)
		{
			id_doituong = newOb.ID_DOITUONG;
			madoituong = newOb.MADOITUONG;
			tendoituong = newOb.TENDOITUONG;
			idx = newOb.IDX;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
