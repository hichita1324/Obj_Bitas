using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 23/05/2018 23:53:20.PM

namespace Bitas
{
	public class Ob_POS_DM_PTTT
	{
		private int id_pttt;
		private string tenpttt;
		public int ID_PTTT{ get { return id_pttt; } set { id_pttt = value; }}
		public string TENPTTT{ get { return tenpttt; } set { tenpttt = value; }}

		public Ob_POS_DM_PTTT()
		{
			id_pttt = 0;
			tenpttt = "";
		}

		public Ob_POS_DM_PTTT( int new_id_pttt, string new_tenpttt)	
		{
			id_pttt = new_id_pttt;
			tenpttt = new_tenpttt;
		}

		public Ob_POS_DM_PTTT(Ob_POS_DM_PTTT newOb)
		{
			id_pttt = newOb.ID_PTTT;
			tenpttt = newOb.TENPTTT;
		}

	}
}
