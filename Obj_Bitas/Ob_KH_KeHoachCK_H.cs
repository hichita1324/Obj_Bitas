using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 06/04/2016 08:28:54.AM

namespace Bitas
{
	public class Ob_KH_KeHoachCK_H
	{
		private int idkehoach;
		private string makehoach;
		private string tenkehoach;
		public int IDKEHOACH{ get { return idkehoach; } set { idkehoach = value; }}
		public string MAKEHOACH{ get { return makehoach; } set { makehoach = value; }}
		public string TENKEHOACH{ get { return tenkehoach; } set { tenkehoach = value; }}

		public Ob_KH_KeHoachCK_H()
		{
			idkehoach = 0;
			makehoach = "";
			tenkehoach = "";
		}

		public Ob_KH_KeHoachCK_H( int new_idkehoach, string new_makehoach, string new_tenkehoach)	
		{
			idkehoach = new_idkehoach;
			makehoach = new_makehoach;
			tenkehoach = new_tenkehoach;
		}

		public Ob_KH_KeHoachCK_H(Ob_KH_KeHoachCK_H newOb)
		{
			idkehoach = newOb.IDKEHOACH;
			makehoach = newOb.MAKEHOACH;
			tenkehoach = newOb.TENKEHOACH;
		}

	}
}
