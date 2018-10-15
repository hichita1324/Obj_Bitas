using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 21/08/2018 10:24:04.AM

namespace Bitas
{
	public class Ob_POS_KetCa
	{
		private int id_ca;
		private int id_cuahang;
		private DateTime giovaoca;
		private DateTime gioketca;
		private int ca;
		private double sodudau;
		public int ID_CA{ get { return id_ca; } set { id_ca = value; }}
		public int ID_CUAHANG{ get { return id_cuahang; } set { id_cuahang = value; }}
		public DateTime GIOVAOCA{ get { return giovaoca; } set { giovaoca = value; }}
		public DateTime GIOKETCA{ get { return gioketca; } set { gioketca = value; }}
		public int CA{ get { return ca; } set { ca = value; }}
		public double SODUDAU{ get { return sodudau; } set { sodudau = value; }}

		public Ob_POS_KetCa()
		{
			id_ca = 0;
			id_cuahang = 0;
			giovaoca = DateTime.MinValue;
			gioketca = DateTime.MinValue;
			ca = 0;
			sodudau = 0;
		}

		public Ob_POS_KetCa( int new_id_ca, int new_id_cuahang, DateTime new_giovaoca, DateTime new_gioketca, int new_ca, double new_sodudau)	
		{
			id_ca = new_id_ca;
			id_cuahang = new_id_cuahang;
			giovaoca = new_giovaoca;
			gioketca = new_gioketca;
			ca = new_ca;
			sodudau = new_sodudau;
		}

		public Ob_POS_KetCa(Ob_POS_KetCa newOb)
		{
			id_ca = newOb.ID_CA;
			id_cuahang = newOb.ID_CUAHANG;
			giovaoca = newOb.GIOVAOCA;
			gioketca = newOb.GIOKETCA;
			ca = newOb.CA;
			sodudau = newOb.SODUDAU;
		}

	}
}
