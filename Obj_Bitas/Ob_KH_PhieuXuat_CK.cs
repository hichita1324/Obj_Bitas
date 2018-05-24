using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 20/06/2016 10:55:03.AM

namespace Bitas
{
	public class Ob_KH_PhieuXuat_CK
	{
		private string id_phieudn_h;
		private int dong;
		private int id_kehoach;
		private string maphieudn;
		private int id_chietkhau;
		private double pt_chietkhau;
		private double tienchietkhau;
		private double thanhtiencl;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_PHIEUDN_H{ get { return id_phieudn_h; } set { id_phieudn_h = value; }}
		public int DONG{ get { return dong; } set { dong = value; }}
		public int ID_KEHOACH{ get { return id_kehoach; } set { id_kehoach = value; }}
		public string MAPHIEUDN{ get { return maphieudn; } set { maphieudn = value; }}
		public int ID_CHIETKHAU{ get { return id_chietkhau; } set { id_chietkhau = value; }}
		public double PT_CHIETKHAU{ get { return pt_chietkhau; } set { pt_chietkhau = value; }}
		public double TIENCHIETKHAU{ get { return tienchietkhau; } set { tienchietkhau = value; }}
		public double THANHTIENCL{ get { return thanhtiencl; } set { thanhtiencl = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_KH_PhieuXuat_CK()
		{
			id_phieudn_h = "";
			dong = 0;
			id_kehoach = 0;
			maphieudn = "";
			id_chietkhau = 0;
			pt_chietkhau = 0;
			tienchietkhau = 0;
			thanhtiencl = 0;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_KH_PhieuXuat_CK( string new_id_phieudn_h, int new_dong, int new_id_kehoach, string new_maphieudn, int new_id_chietkhau, double new_pt_chietkhau, double new_tienchietkhau, double new_thanhtiencl, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_phieudn_h = new_id_phieudn_h;
			dong = new_dong;
			id_kehoach = new_id_kehoach;
			maphieudn = new_maphieudn;
			id_chietkhau = new_id_chietkhau;
			pt_chietkhau = new_pt_chietkhau;
			tienchietkhau = new_tienchietkhau;
			thanhtiencl = new_thanhtiencl;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_KH_PhieuXuat_CK(Ob_KH_PhieuXuat_CK newOb)
		{
			id_phieudn_h = newOb.ID_PHIEUDN_H;
			dong = newOb.DONG;
			id_kehoach = newOb.ID_KEHOACH;
			maphieudn = newOb.MAPHIEUDN;
			id_chietkhau = newOb.ID_CHIETKHAU;
			pt_chietkhau = newOb.PT_CHIETKHAU;
			tienchietkhau = newOb.TIENCHIETKHAU;
			thanhtiencl = newOb.THANHTIENCL;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
