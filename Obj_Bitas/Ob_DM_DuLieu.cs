using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:37:27.AM

namespace Bitas
{
	public class Ob_DM_DuLieu
	{
		private int id_dulieu;
		private string tenbang;
		private string tencot;
		private string mota;
		public int ID_DULIEU{ get { return id_dulieu; } set { id_dulieu = value; }}
		public string TENBANG{ get { return tenbang; } set { tenbang = value; }}
		public string TENCOT{ get { return tencot; } set { tencot = value; }}
		public string MOTA{ get { return mota; } set { mota = value; }}

		public Ob_DM_DuLieu()
		{
			id_dulieu = 0;
			tenbang = "";
			tencot = "";
			mota = "";
		}

		public Ob_DM_DuLieu( int new_id_dulieu, string new_tenbang, string new_tencot, string new_mota)	
		{
			id_dulieu = new_id_dulieu;
			tenbang = new_tenbang;
			tencot = new_tencot;
			mota = new_mota;
		}

		public Ob_DM_DuLieu(Ob_DM_DuLieu newOb)
		{
			id_dulieu = newOb.ID_DULIEU;
			tenbang = newOb.TENBANG;
			tencot = newOb.TENCOT;
			mota = newOb.MOTA;
		}

	}
}
