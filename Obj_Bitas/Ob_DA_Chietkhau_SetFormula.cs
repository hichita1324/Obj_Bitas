using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 06/04/2016 08:31:20.AM

namespace Bitas
{
	public class Ob_DA_Chietkhau_SetFormula
	{
		private int id;
		private string plancode;
		private int stt;
		private int id_chietkhau;
		private double pt;
		private string inputformula;
		private string stringfunction;
		private bool visible;
		private DateTime modifiedtime;
		private string modifiedby;
		private DateTime createdtime;
		private string createddate;
		public int ID{ get { return id; } set { id = value; }}
		public string PLANCODE{ get { return plancode; } set { plancode = value; }}
		public int STT{ get { return stt; } set { stt = value; }}
		public int ID_CHIETKHAU{ get { return id_chietkhau; } set { id_chietkhau = value; }}
		public double PT{ get { return pt; } set { pt = value; }}
		public string INPUTFORMULA{ get { return inputformula; } set { inputformula = value; }}
		public string STRINGFUNCTION{ get { return stringfunction; } set { stringfunction = value; }}
		public bool VISIBLE{ get { return visible; } set { visible = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDDATE{ get { return createddate; } set { createddate = value; }}

		public Ob_DA_Chietkhau_SetFormula()
		{
			id = 0;
			plancode = "";
			stt = 0;
			id_chietkhau = 0;
			pt = 0;
			inputformula = "";
			stringfunction = "";
			visible = false;
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
			createdtime = DateTime.MinValue;
			createddate = "";
		}

		public Ob_DA_Chietkhau_SetFormula( int new_id, string new_plancode, int new_stt, int new_id_chietkhau, double new_pt, string new_inputformula, string new_stringfunction, bool new_visible, DateTime new_modifiedtime, string new_modifiedby, DateTime new_createdtime, string new_createddate)	
		{
			id = new_id;
			plancode = new_plancode;
			stt = new_stt;
			id_chietkhau = new_id_chietkhau;
			pt = new_pt;
			inputformula = new_inputformula;
			stringfunction = new_stringfunction;
			visible = new_visible;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
			createdtime = new_createdtime;
			createddate = new_createddate;
		}

		public Ob_DA_Chietkhau_SetFormula(Ob_DA_Chietkhau_SetFormula newOb)
		{
			id = newOb.ID;
			plancode = newOb.PLANCODE;
			stt = newOb.STT;
			id_chietkhau = newOb.ID_CHIETKHAU;
			pt = newOb.PT;
			inputformula = newOb.INPUTFORMULA;
			stringfunction = newOb.STRINGFUNCTION;
			visible = newOb.VISIBLE;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
			createdtime = newOb.CREATEDTIME;
			createddate = newOb.CREATEDDATE;
		}

	}
}
