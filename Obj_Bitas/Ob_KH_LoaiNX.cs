using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 09/07/2016 11:30:07.AM

namespace Bitas
{
	public class Ob_KH_LoaiNX
	{
		private int id_loainx;
		private string maloainx;
		private string tenloainx;
		private string loai;
		private string ghichu;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_LOAINX{ get { return id_loainx; } set { id_loainx = value; }}
		public string MALOAINX{ get { return maloainx; } set { maloainx = value; }}
		public string TENLOAINX{ get { return tenloainx; } set { tenloainx = value; }}
		public string LOAI{ get { return loai; } set { loai = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_LoaiNX()
		{
			id_loainx = 0;
			maloainx = "";
			tenloainx = "";
			loai = "";
			ghichu = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_LoaiNX(int new_id_loainx, string new_maloainx, string new_tenloainx, string new_loai, string new_ghichu, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_loainx = new_id_loainx;
			maloainx = new_maloainx;
			tenloainx = new_tenloainx;
			loai = new_loai;
			ghichu = new_ghichu;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_LoaiNX(Ob_KH_LoaiNX newOb)
		{
			id_loainx = newOb.ID_LOAINX;
			maloainx = newOb.MALOAINX;
			tenloainx = newOb.TENLOAINX;
			loai = newOb.LOAI;
			ghichu = newOb.GHICHU;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
