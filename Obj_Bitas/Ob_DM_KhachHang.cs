using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 28/07/2016 11:49:10.AM

namespace Bitas
{
	public class Ob_DM_KhachHang
	{
		private string id_khachhang;
		private string makhachhang;
		private string sodaily;
		private string tenkhachhang;
		private string dienthoai;
		private string didong;
		private string diachi;
		private int id_tinhtp;
		private int id_khuvuc;
		private int id_loaikh;
		private double pt_cklhkd;
		private int phihotro;
		private string masothue;
		private string email;
		private string nguoilienhe;
		private double notoida;
		private string ghichu;
		private bool khachsi;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public string ID_KHACHHANG{ get { return id_khachhang; } set { id_khachhang = value; }}
		public string MAKHACHHANG{ get { return makhachhang; } set { makhachhang = value; }}
		public string SODAILY{ get { return sodaily; } set { sodaily = value; }}
		public string TENKHACHHANG{ get { return tenkhachhang; } set { tenkhachhang = value; }}
		public string DIENTHOAI{ get { return dienthoai; } set { dienthoai = value; }}
		public string DIDONG{ get { return didong; } set { didong = value; }}
		public string DIACHI{ get { return diachi; } set { diachi = value; }}
		public int ID_TINHTP{ get { return id_tinhtp; } set { id_tinhtp = value; }}
		public int ID_KHUVUC{ get { return id_khuvuc; } set { id_khuvuc = value; }}
		public int ID_LOAIKH{ get { return id_loaikh; } set { id_loaikh = value; }}
		public double PT_CKLHKD{ get { return pt_cklhkd; } set { pt_cklhkd = value; }}
		public int PHIHOTRO{ get { return phihotro; } set { phihotro = value; }}
		public string MASOTHUE{ get { return masothue; } set { masothue = value; }}
		public string EMAIL{ get { return email; } set { email = value; }}
		public string NGUOILIENHE{ get { return nguoilienhe; } set { nguoilienhe = value; }}
		public double NOTOIDA{ get { return notoida; } set { notoida = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public bool KHACHSI{ get { return khachsi; } set { khachsi = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_KhachHang()
		{
			id_khachhang = "";
			makhachhang = "";
			sodaily = "";
			tenkhachhang = "";
			dienthoai = "";
			didong = "";
			diachi = "";
			id_tinhtp = 0;
			id_khuvuc = 0;
			id_loaikh = 0;
			phihotro = 0;
			masothue = "";
			email = "";
			nguoilienhe = "";
			notoida = 0;
			ghichu = "";
			khachsi = false;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_KhachHang( string new_id_khachhang, string new_makhachhang, string new_sodaily, string new_tenkhachhang, string new_dienthoai, string new_didong, string new_diachi, int new_id_tinhtp, int new_id_khuvuc, int new_id_loaikh, double new_pt_cklhkd, int new_phihotro, string new_masothue, string new_email, string new_nguoilienhe, double new_notoida, string new_ghichu, bool new_khachsi, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_khachhang = new_id_khachhang;
			makhachhang = new_makhachhang;
			sodaily = new_sodaily;
			tenkhachhang = new_tenkhachhang;
			dienthoai = new_dienthoai;
			didong = new_didong;
			diachi = new_diachi;
			id_tinhtp = new_id_tinhtp;
			id_khuvuc = new_id_khuvuc;
			id_loaikh = new_id_loaikh;
			pt_cklhkd = new_pt_cklhkd;
			phihotro = new_phihotro;
			masothue = new_masothue;
			email = new_email;
			nguoilienhe = new_nguoilienhe;
			notoida = new_notoida;
			ghichu = new_ghichu;
			khachsi = new_khachsi;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_KhachHang(Ob_DM_KhachHang newOb)
		{
			id_khachhang = newOb.ID_KHACHHANG;
			makhachhang = newOb.MAKHACHHANG;
			sodaily = newOb.SODAILY;
			tenkhachhang = newOb.TENKHACHHANG;
			dienthoai = newOb.DIENTHOAI;
			didong = newOb.DIDONG;
			diachi = newOb.DIACHI;
			id_tinhtp = newOb.ID_TINHTP;
			id_khuvuc = newOb.ID_KHUVUC;
			id_loaikh = newOb.ID_LOAIKH;
			pt_cklhkd = newOb.PT_CKLHKD;
			phihotro = newOb.PHIHOTRO;
			masothue = newOb.MASOTHUE;
			email = newOb.EMAIL;
			nguoilienhe = newOb.NGUOILIENHE;
			notoida = newOb.NOTOIDA;
			ghichu = newOb.GHICHU;
			khachsi = newOb.KHACHSI;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
