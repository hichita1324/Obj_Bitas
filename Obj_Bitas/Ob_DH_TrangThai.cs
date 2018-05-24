using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 20/08/2016 10:22:49.AM

namespace Bitas
{
	public class Ob_DH_TrangThai
	{
		private int id_trangthai;
		private string tentrangthai;
		public int ID_TRANGTHAI{ get { return id_trangthai; } set { id_trangthai = value; }}
		public string TENTRANGTHAI{ get { return tentrangthai; } set { tentrangthai = value; }}

		public Ob_DH_TrangThai()
		{
			id_trangthai = 0;
			tentrangthai = "";
		}

		public Ob_DH_TrangThai( int new_id_trangthai, string new_tentrangthai)	
		{
			id_trangthai = new_id_trangthai;
			tentrangthai = new_tentrangthai;
		}

		public Ob_DH_TrangThai(Ob_DH_TrangThai newOb)
		{
			id_trangthai = newOb.ID_TRANGTHAI;
			tentrangthai = newOb.TENTRANGTHAI;
		}

	}
}
