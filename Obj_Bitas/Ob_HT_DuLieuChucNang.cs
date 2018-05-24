using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:44:24.AM

namespace Bitas
{
	public class Ob_HT_DuLieuChucNang
	{
		private int id_chucnang;
		private string tenbang;
		private string mota;
		public int ID_CHUCNANG{ get { return id_chucnang; } set { id_chucnang = value; }}
		public string TENBANG{ get { return tenbang; } set { tenbang = value; }}
		public string MOTA{ get { return mota; } set { mota = value; }}

		public Ob_HT_DuLieuChucNang()
		{
			id_chucnang = 0;
			tenbang = "";
			mota = "";
		}

		public Ob_HT_DuLieuChucNang( int new_id_chucnang, string new_tenbang, string new_mota)	
		{
			id_chucnang = new_id_chucnang;
			tenbang = new_tenbang;
			mota = new_mota;
		}

		public Ob_HT_DuLieuChucNang(Ob_HT_DuLieuChucNang newOb)
		{
			id_chucnang = newOb.ID_CHUCNANG;
			tenbang = newOb.TENBANG;
			mota = newOb.MOTA;
		}

	}
}
