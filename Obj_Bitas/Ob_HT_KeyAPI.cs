using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 14/10/2016 13:35:01.PM

namespace Bitas
{
	public class Ob_HT_KeyAPI
	{
		private int id_keyapi;
		private string makhoa;
		private string apikey;
		public int ID_KEYAPI{ get { return id_keyapi; } set { id_keyapi = value; }}
		public string MAKHOA{ get { return makhoa; } set { makhoa = value; }}
		public string APIKEY{ get { return apikey; } set { apikey = value; }}

		public Ob_HT_KeyAPI()
		{
			id_keyapi = 0;
			makhoa = "";
			apikey = "";
		}

		public Ob_HT_KeyAPI(int new_id_keyapi, string new_makhoa, string new_apikey)	
		{
			id_keyapi = new_id_keyapi;
			makhoa = new_makhoa;
			apikey = new_apikey;
		}

		public Ob_HT_KeyAPI(Ob_HT_KeyAPI newOb)
		{
			id_keyapi = newOb.ID_KEYAPI;
			makhoa = newOb.MAKHOA;
			apikey = newOb.APIKEY;
		}

	}
}
