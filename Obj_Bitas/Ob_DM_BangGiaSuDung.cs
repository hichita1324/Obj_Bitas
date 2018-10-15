using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 13/09/2018 07:22:36.AM

namespace Bitas
{
	public class Ob_DM_BangGiaSuDung
	{
		private int id_banggiasudung;
		private string mota;
		private int id_kho;
		private int id_banggia;
		private bool cogiarieng;
		public int ID_BANGGIASUDUNG{ get { return id_banggiasudung; } set { id_banggiasudung = value; }}
		public string MOTA{ get { return mota; } set { mota = value; }}
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public int ID_BANGGIA{ get { return id_banggia; } set { id_banggia = value; }}
		public bool COGIARIENG{ get { return cogiarieng; } set { cogiarieng = value; }}

		public Ob_DM_BangGiaSuDung()
		{
			id_banggiasudung = 0;
			mota = "";
			id_kho = 0;
			id_banggia = 0;
			cogiarieng = false;
		}

		public Ob_DM_BangGiaSuDung( int new_id_banggiasudung, string new_mota, int new_id_kho, int new_id_banggia, bool new_cogiarieng)	
		{
			id_banggiasudung = new_id_banggiasudung;
			mota = new_mota;
			id_kho = new_id_kho;
			id_banggia = new_id_banggia;
			cogiarieng = new_cogiarieng;
		}

		public Ob_DM_BangGiaSuDung(Ob_DM_BangGiaSuDung newOb)
		{
			id_banggiasudung = newOb.ID_BANGGIASUDUNG;
			mota = newOb.MOTA;
			id_kho = newOb.ID_KHO;
			id_banggia = newOb.ID_BANGGIA;
			cogiarieng = newOb.COGIARIENG;
		}

	}
}
