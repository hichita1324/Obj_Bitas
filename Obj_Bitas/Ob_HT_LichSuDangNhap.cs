using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:44:30.AM

namespace Bitas
{
	public class Ob_HT_LichSuDangNhap
	{
		private int id_lichsu;
		private string taikhoan;
		private DateTime landangnhapcuoi;
		private string tenmay;
		private string diachimac;
		private string diachiip;
		public int ID_LICHSU{ get { return id_lichsu; } set { id_lichsu = value; }}
		public string TAIKHOAN{ get { return taikhoan; } set { taikhoan = value; }}
		public DateTime LANDANGNHAPCUOI{ get { return landangnhapcuoi; } set { landangnhapcuoi = value; }}
		public string TENMAY{ get { return tenmay; } set { tenmay = value; }}
		public string DIACHIMAC{ get { return diachimac; } set { diachimac = value; }}
		public string DIACHIIP{ get { return diachiip; } set { diachiip = value; }}

		public Ob_HT_LichSuDangNhap()
		{
			id_lichsu = 0;
			taikhoan = "";
			landangnhapcuoi = DateTime.MinValue;
			tenmay = "";
			diachimac = "";
			diachiip = "";
		}

		public Ob_HT_LichSuDangNhap( int new_id_lichsu, string new_taikhoan, DateTime new_landangnhapcuoi, string new_tenmay, string new_diachimac, string new_diachiip)	
		{
			id_lichsu = new_id_lichsu;
			taikhoan = new_taikhoan;
			landangnhapcuoi = new_landangnhapcuoi;
			tenmay = new_tenmay;
			diachimac = new_diachimac;
			diachiip = new_diachiip;
		}

		public Ob_HT_LichSuDangNhap(Ob_HT_LichSuDangNhap newOb)
		{
			id_lichsu = newOb.ID_LICHSU;
			taikhoan = newOb.TAIKHOAN;
			landangnhapcuoi = newOb.LANDANGNHAPCUOI;
			tenmay = newOb.TENMAY;
			diachimac = newOb.DIACHIMAC;
			diachiip = newOb.DIACHIIP;
		}

	}
}
