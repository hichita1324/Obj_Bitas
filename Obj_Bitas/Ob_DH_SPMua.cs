using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 18/10/2016 15:58:18.PM

namespace Bitas
{
	public class Ob_DH_SPMua
	{
		private int id_sanpham;
		private int id_nhomgiaohang;
		public int ID_SANPHAM{ get { return id_sanpham; } set { id_sanpham = value; }}
		public int ID_NHOMGIAOHANG{ get { return id_nhomgiaohang; } set { id_nhomgiaohang = value; }}

		public Ob_DH_SPMua()
		{
			id_sanpham = 0;
			id_nhomgiaohang = 0;
		}

		public Ob_DH_SPMua( int new_id_sanpham, int new_id_nhomgiaohang)	
		{
			id_sanpham = new_id_sanpham;
			id_nhomgiaohang = new_id_nhomgiaohang;
		}

		public Ob_DH_SPMua(Ob_DH_SPMua newOb)
		{
			id_sanpham = newOb.ID_SANPHAM;
			id_nhomgiaohang = newOb.ID_NHOMGIAOHANG;
		}

	}
}
