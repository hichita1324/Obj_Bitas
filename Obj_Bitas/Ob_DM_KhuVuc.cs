using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:37:47.AM

namespace Bitas
{
	public class Ob_DM_KhuVuc
	{
		private int id_khuvuc;
		private string makhuvuc;
		private string tenkhuvuc;
		private int id_chinhanh;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_KHUVUC{ get { return id_khuvuc; } set { id_khuvuc = value; }}
		public string MAKHUVUC{ get { return makhuvuc; } set { makhuvuc = value; }}
		public string TENKHUVUC{ get { return tenkhuvuc; } set { tenkhuvuc = value; }}
		public int ID_CHINHANH{ get { return id_chinhanh; } set { id_chinhanh = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_KhuVuc()
		{
			id_khuvuc = 0;
			makhuvuc = "";
			tenkhuvuc = "";
			id_chinhanh = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_KhuVuc( int new_id_khuvuc, string new_makhuvuc, string new_tenkhuvuc, int new_id_chinhanh, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_khuvuc = new_id_khuvuc;
			makhuvuc = new_makhuvuc;
			tenkhuvuc = new_tenkhuvuc;
			id_chinhanh = new_id_chinhanh;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_KhuVuc(Ob_DM_KhuVuc newOb)
		{
			id_khuvuc = newOb.ID_KHUVUC;
			makhuvuc = newOb.MAKHUVUC;
			tenkhuvuc = newOb.TENKHUVUC;
			id_chinhanh = newOb.ID_CHINHANH;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
