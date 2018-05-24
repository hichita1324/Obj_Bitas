using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 06/04/2016 08:28:38.AM

namespace Bitas
{
	public class Ob_DM_ChietKhau
	{
		private int id_chietkhau;
		private string machietkhau;
		private string tenchietkhau;
		public int ID_CHIETKHAU{ get { return id_chietkhau; } set { id_chietkhau = value; }}
		public string MACHIETKHAU{ get { return machietkhau; } set { machietkhau = value; }}
		public string TENCHIETKHAU{ get { return tenchietkhau; } set { tenchietkhau = value; }}

		public Ob_DM_ChietKhau()
		{
			id_chietkhau = 0;
			machietkhau = "";
			tenchietkhau = "";
		}

		public Ob_DM_ChietKhau( int new_id_chietkhau, string new_machietkhau, string new_tenchietkhau)	
		{
			id_chietkhau = new_id_chietkhau;
			machietkhau = new_machietkhau;
			tenchietkhau = new_tenchietkhau;
		}

		public Ob_DM_ChietKhau(Ob_DM_ChietKhau newOb)
		{
			id_chietkhau = newOb.ID_CHIETKHAU;
			machietkhau = newOb.MACHIETKHAU;
			tenchietkhau = newOb.TENCHIETKHAU;
		}

	}
}
