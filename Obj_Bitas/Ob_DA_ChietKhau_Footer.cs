using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 06/04/2016 08:31:11.AM

namespace Bitas
{
	public class Ob_DA_ChietKhau_Footer
	{
		private int id;
		private string plancode;
		private string invno;
		private int id_chietkhau;
		private decimal valuetotal;
		private string note;
		private DateTime cdate;
		private DateTime udate;
		public int ID{ get { return id; } set { id = value; }}
		public string PLANCODE{ get { return plancode; } set { plancode = value; }}
		public string INVNO{ get { return invno; } set { invno = value; }}
		public int ID_CHIETKHAU{ get { return id_chietkhau; } set { id_chietkhau = value; }}
		public decimal VALUETOTAL{ get { return valuetotal; } set { valuetotal = value; }}
		public string NOTE{ get { return note; } set { note = value; }}
		public DateTime CDATE{ get { return cdate; } set { cdate = value; }}
		public DateTime UDATE{ get { return udate; } set { udate = value; }}

		public Ob_DA_ChietKhau_Footer()
		{
			id = 0;
			plancode = "";
			invno = "";
			id_chietkhau = 0;
			valuetotal = 0;
			note = "";
			cdate = DateTime.MinValue;
			udate = DateTime.MinValue;
		}

		public Ob_DA_ChietKhau_Footer( int new_id, string new_plancode, string new_invno, int new_id_chietkhau, decimal new_valuetotal, string new_note, DateTime new_cdate, DateTime new_udate)	
		{
			id = new_id;
			plancode = new_plancode;
			invno = new_invno;
			id_chietkhau = new_id_chietkhau;
			valuetotal = new_valuetotal;
			note = new_note;
			cdate = new_cdate;
			udate = new_udate;
		}

		public Ob_DA_ChietKhau_Footer(Ob_DA_ChietKhau_Footer newOb)
		{
			id = newOb.ID;
			plancode = newOb.PLANCODE;
			invno = newOb.INVNO;
			id_chietkhau = newOb.ID_CHIETKHAU;
			valuetotal = newOb.VALUETOTAL;
			note = newOb.NOTE;
			cdate = newOb.CDATE;
			udate = newOb.UDATE;
		}

	}
}
