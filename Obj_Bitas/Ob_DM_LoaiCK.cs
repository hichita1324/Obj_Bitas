using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 06/04/2016 08:28:45.AM

namespace Bitas
{
	public class Ob_DM_LoaiCK
	{
		private string maloaick;
		private string mota;
		public string MALOAICK{ get { return maloaick; } set { maloaick = value; }}
		public string MOTA{ get { return mota; } set { mota = value; }}

		public Ob_DM_LoaiCK()
		{
			maloaick = "";
			mota = "";
		}

		public Ob_DM_LoaiCK( string new_maloaick, string new_mota)	
		{
			maloaick = new_maloaick;
			mota = new_mota;
		}

		public Ob_DM_LoaiCK(Ob_DM_LoaiCK newOb)
		{
			maloaick = newOb.MALOAICK;
			mota = newOb.MOTA;
		}

	}
}
