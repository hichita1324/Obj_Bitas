using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:44:56.AM

namespace Bitas
{
	public class Ob_HT_PhienBan
	{
		private string id_phienban;
		private string ten;
		private DateTime ngayphathanh;
		private string duongdan;
		private bool kichhoat;
		private string ghichu;
		public string ID_PHIENBAN{ get { return id_phienban; } set { id_phienban = value; }}
		public string TEN{ get { return ten; } set { ten = value; }}
		public DateTime NGAYPHATHANH{ get { return ngayphathanh; } set { ngayphathanh = value; }}
		public string DUONGDAN{ get { return duongdan; } set { duongdan = value; }}
		public bool KICHHOAT{ get { return kichhoat; } set { kichhoat = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}

		public Ob_HT_PhienBan()
		{
			id_phienban = "";
			ten = "";
			ngayphathanh = DateTime.MinValue;
			duongdan = "";
			kichhoat = false;
			ghichu = "";
		}

		public Ob_HT_PhienBan( string new_id_phienban, string new_ten, DateTime new_ngayphathanh, string new_duongdan, bool new_kichhoat, string new_ghichu)	
		{
			id_phienban = new_id_phienban;
			ten = new_ten;
			ngayphathanh = new_ngayphathanh;
			duongdan = new_duongdan;
			kichhoat = new_kichhoat;
			ghichu = new_ghichu;
		}

		public Ob_HT_PhienBan(Ob_HT_PhienBan newOb)
		{
			id_phienban = newOb.ID_PHIENBAN;
			ten = newOb.TEN;
			ngayphathanh = newOb.NGAYPHATHANH;
			duongdan = newOb.DUONGDAN;
			kichhoat = newOb.KICHHOAT;
			ghichu = newOb.GHICHU;
		}

	}
}
