using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:37:22.AM

namespace Bitas
{
	public class Ob_DM_DonViTinh
	{
		private int id_donvitinh;
		private string madonvitinh;
		private string mota;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_DONVITINH{ get { return id_donvitinh; } set { id_donvitinh = value; }}
		public string MADONVITINH{ get { return madonvitinh; } set { madonvitinh = value; }}
		public string MOTA{ get { return mota; } set { mota = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_DonViTinh()
		{
			id_donvitinh = 0;
			madonvitinh = "";
			mota = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_DonViTinh( int new_id_donvitinh, string new_madonvitinh, string new_mota, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_donvitinh = new_id_donvitinh;
			madonvitinh = new_madonvitinh;
			mota = new_mota;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_DonViTinh(Ob_DM_DonViTinh newOb)
		{
			id_donvitinh = newOb.ID_DONVITINH;
			madonvitinh = newOb.MADONVITINH;
			mota = newOb.MOTA;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
