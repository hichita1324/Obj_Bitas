using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 22/07/2016 13:42:20.PM

namespace Bitas
{
	public class Ob_DM_HeThong
	{
		private int id_hethong;
		private string mota;
		private string tencongty;
		private string tenviettat;
		private string diachi;
		private string masothue;
		private byte[] logo;
		private string dienthoai;
		private string fax;
		public int ID_HETHONG{ get { return id_hethong; } set { id_hethong = value; }}
		public string MOTA{ get { return mota; } set { mota = value; }}
		public string TENCONGTY{ get { return tencongty; } set { tencongty = value; }}
		public string TENVIETTAT{ get { return tenviettat; } set { tenviettat = value; }}
		public string DIACHI{ get { return diachi; } set { diachi = value; }}
		public string MASOTHUE{ get { return masothue; } set { masothue = value; }}
		public byte[] LOGO{ get { return logo; } set { logo = value; }}
		public string DIENTHOAI{ get { return dienthoai; } set { dienthoai = value; }}
		public string FAX{ get { return fax; } set { fax = value; }}

		public Ob_DM_HeThong()
		{
			id_hethong = 0;
			mota = "";
			tencongty = "";
			tenviettat = "";
			diachi = "";
			masothue = "";
			dienthoai = "";
			fax = "";
		}

		public Ob_DM_HeThong( int new_id_hethong, string new_mota, string new_tencongty, string new_tenviettat, string new_diachi, string new_masothue, byte[] new_logo, string new_dienthoai, string new_fax)	
		{
			id_hethong = new_id_hethong;
			mota = new_mota;
			tencongty = new_tencongty;
			tenviettat = new_tenviettat;
			diachi = new_diachi;
			masothue = new_masothue;
			logo = new_logo;
			dienthoai = new_dienthoai;
			fax = new_fax;
		}

		public Ob_DM_HeThong(Ob_DM_HeThong newOb)
		{
			id_hethong = newOb.ID_HETHONG;
			mota = newOb.MOTA;
			tencongty = newOb.TENCONGTY;
			tenviettat = newOb.TENVIETTAT;
			diachi = newOb.DIACHI;
			masothue = newOb.MASOTHUE;
			logo = newOb.LOGO;
			dienthoai = newOb.DIENTHOAI;
			fax = newOb.FAX;
		}

	}
}
