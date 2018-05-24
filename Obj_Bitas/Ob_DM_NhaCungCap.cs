using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:43:54.AM

namespace Bitas
{
	public class Ob_DM_NhaCungCap
	{
		private int id_nhacungcap;
		private string manhacungcap;
		private string tennhacungcap;
		private string dienthoai;
		private string didong;
		private string fax;
		private string diachi;
		private string nguoilienhe;
		private string email;
		private string masothue;
		private string ghichu;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_NHACUNGCAP{ get { return id_nhacungcap; } set { id_nhacungcap = value; }}
		public string MANHACUNGCAP{ get { return manhacungcap; } set { manhacungcap = value; }}
		public string TENNHACUNGCAP{ get { return tennhacungcap; } set { tennhacungcap = value; }}
		public string DIENTHOAI{ get { return dienthoai; } set { dienthoai = value; }}
		public string DIDONG{ get { return didong; } set { didong = value; }}
		public string FAX{ get { return fax; } set { fax = value; }}
		public string DIACHI{ get { return diachi; } set { diachi = value; }}
		public string NGUOILIENHE{ get { return nguoilienhe; } set { nguoilienhe = value; }}
		public string EMAIL{ get { return email; } set { email = value; }}
		public string MASOTHUE{ get { return masothue; } set { masothue = value; }}
		public string GHICHU{ get { return ghichu; } set { ghichu = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_DM_NhaCungCap()
		{
			id_nhacungcap = 0;
			manhacungcap = "";
			tennhacungcap = "";
			dienthoai = "";
			didong = "";
			fax = "";
			diachi = "";
			nguoilienhe = "";
			email = "";
			masothue = "";
			ghichu = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_DM_NhaCungCap( int new_id_nhacungcap, string new_manhacungcap, string new_tennhacungcap, string new_dienthoai, string new_didong, string new_fax, string new_diachi, string new_nguoilienhe, string new_email, string new_masothue, string new_ghichu, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_nhacungcap = new_id_nhacungcap;
			manhacungcap = new_manhacungcap;
			tennhacungcap = new_tennhacungcap;
			dienthoai = new_dienthoai;
			didong = new_didong;
			fax = new_fax;
			diachi = new_diachi;
			nguoilienhe = new_nguoilienhe;
			email = new_email;
			masothue = new_masothue;
			ghichu = new_ghichu;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_DM_NhaCungCap(Ob_DM_NhaCungCap newOb)
		{
			id_nhacungcap = newOb.ID_NHACUNGCAP;
			manhacungcap = newOb.MANHACUNGCAP;
			tennhacungcap = newOb.TENNHACUNGCAP;
			dienthoai = newOb.DIENTHOAI;
			didong = newOb.DIDONG;
			fax = newOb.FAX;
			diachi = newOb.DIACHI;
			nguoilienhe = newOb.NGUOILIENHE;
			email = newOb.EMAIL;
			masothue = newOb.MASOTHUE;
			ghichu = newOb.GHICHU;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
