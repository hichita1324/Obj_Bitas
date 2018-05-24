using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 04/04/2016 10:44:52.AM

namespace Bitas
{
	public class Ob_HT_PhanQuyenDuLieu
	{
		private int id_nhomnd;
		private int id_chucnang;
		private string tenbang;
		private string mota;
		private bool xem;
		private bool themmoi;
		private bool sua;
		private bool xoa;
		private bool xuatbaocao;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createdby;
		public int ID_NHOMND{ get { return id_nhomnd; } set { id_nhomnd = value; }}
		public int ID_CHUCNANG{ get { return id_chucnang; } set { id_chucnang = value; }}
		public string TENBANG{ get { return tenbang; } set { tenbang = value; }}
		public string MOTA{ get { return mota; } set { mota = value; }}
		public bool XEM{ get { return xem; } set { xem = value; }}
		public bool THEMMOI{ get { return themmoi; } set { themmoi = value; }}
		public bool SUA{ get { return sua; } set { sua = value; }}
		public bool XOA{ get { return xoa; } set { xoa = value; }}
		public bool XUATBAOCAO{ get { return xuatbaocao; } set { xuatbaocao = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}

		public Ob_HT_PhanQuyenDuLieu()
		{
			id_nhomnd = 0;
			id_chucnang = 0;
			tenbang = "";
			mota = "";
			xem = false;
			themmoi = false;
			sua = false;
			xoa = false;
			xuatbaocao = false;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createdby = "";
		}

		public Ob_HT_PhanQuyenDuLieu( int new_id_nhomnd, int new_id_chucnang, string new_tenbang, string new_mota, bool new_xem, bool new_themmoi, bool new_sua, bool new_xoa, bool new_xuatbaocao, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createdby)	
		{
			id_nhomnd = new_id_nhomnd;
			id_chucnang = new_id_chucnang;
			tenbang = new_tenbang;
			mota = new_mota;
			xem = new_xem;
			themmoi = new_themmoi;
			sua = new_sua;
			xoa = new_xoa;
			xuatbaocao = new_xuatbaocao;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createdby = new_createdby;
		}

		public Ob_HT_PhanQuyenDuLieu(Ob_HT_PhanQuyenDuLieu newOb)
		{
			id_nhomnd = newOb.ID_NHOMND;
			id_chucnang = newOb.ID_CHUCNANG;
			tenbang = newOb.TENBANG;
			mota = newOb.MOTA;
			xem = newOb.XEM;
			themmoi = newOb.THEMMOI;
			sua = newOb.SUA;
			xoa = newOb.XOA;
			xuatbaocao = newOb.XUATBAOCAO;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
		}

	}
}
