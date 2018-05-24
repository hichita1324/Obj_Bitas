using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 27/07/2016 11:49:55.AM

namespace Bitas
{
	public class Ob_DH_LoaiDH
	{
		private int id_loaidh;
		private string maloaidh;
		private string tenloaidh;
		private bool hopdong;
		private string tenmua;
		private int id_banggia;
		private bool active;
		public int ID_LOAIDH{ get { return id_loaidh; } set { id_loaidh = value; }}
		public string MALOAIDH{ get { return maloaidh; } set { maloaidh = value; }}
		public string TENLOAIDH{ get { return tenloaidh; } set { tenloaidh = value; }}
		public bool HOPDONG{ get { return hopdong; } set { hopdong = value; }}
		public string TENMUA{ get { return tenmua; } set { tenmua = value; }}
		public int ID_BANGGIA{ get { return id_banggia; } set { id_banggia = value; }}
		public bool ACTIVE{ get { return active; } set { active = value; }}

		public Ob_DH_LoaiDH()
		{
			id_loaidh = 0;
			maloaidh = "";
			tenloaidh = "";
			hopdong = false;
			tenmua = "";
			id_banggia = 0;
			active = false;
		}

		public Ob_DH_LoaiDH( int new_id_loaidh, string new_maloaidh, string new_tenloaidh, bool new_hopdong, string new_tenmua, int new_id_banggia, bool new_active)	
		{
			id_loaidh = new_id_loaidh;
			maloaidh = new_maloaidh;
			tenloaidh = new_tenloaidh;
			hopdong = new_hopdong;
			tenmua = new_tenmua;
			id_banggia = new_id_banggia;
			active = new_active;
		}

		public Ob_DH_LoaiDH(Ob_DH_LoaiDH newOb)
		{
			id_loaidh = newOb.ID_LOAIDH;
			maloaidh = newOb.MALOAIDH;
			tenloaidh = newOb.TENLOAIDH;
			hopdong = newOb.HOPDONG;
			tenmua = newOb.TENMUA;
			id_banggia = newOb.ID_BANGGIA;
			active = newOb.ACTIVE;
		}

	}
}
