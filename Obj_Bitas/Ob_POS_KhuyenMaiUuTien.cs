using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 13/09/2018 07:22:57.AM

namespace Bitas
{
	public class Ob_POS_KhuyenMaiUuTien
	{
		private int id_cuahang;
		private string makhuyenmai;
		public int ID_CUAHANG{ get { return id_cuahang; } set { id_cuahang = value; }}
		public string MAKHUYENMAI{ get { return makhuyenmai; } set { makhuyenmai = value; }}

		public Ob_POS_KhuyenMaiUuTien()
		{
			id_cuahang = 0;
			makhuyenmai = "";
		}

		public Ob_POS_KhuyenMaiUuTien( int new_id_cuahang, string new_makhuyenmai)	
		{
			id_cuahang = new_id_cuahang;
			makhuyenmai = new_makhuyenmai;
		}

		public Ob_POS_KhuyenMaiUuTien(Ob_POS_KhuyenMaiUuTien newOb)
		{
			id_cuahang = newOb.ID_CUAHANG;
			makhuyenmai = newOb.MAKHUYENMAI;
		}

	}
}
