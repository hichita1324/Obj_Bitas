using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 13/09/2018 07:40:23.AM

namespace Bitas
{
	public class Ob_POS_DM_CuaHang
	{
		private int id_cuahang;
		private string macuahang;
		private string tencuahang;
		private int pos;
		private int id_kho;
		private string diachi;
		private string dienthoai;
		private int id_cuahangtruong;
		private bool ketca;
		public int ID_CUAHANG{ get { return id_cuahang; } set { id_cuahang = value; }}
		public string MACUAHANG{ get { return macuahang; } set { macuahang = value; }}
		public string TENCUAHANG{ get { return tencuahang; } set { tencuahang = value; }}
		public int POS{ get { return pos; } set { pos = value; }}
		public int ID_KHO{ get { return id_kho; } set { id_kho = value; }}
		public string DIACHI{ get { return diachi; } set { diachi = value; }}
		public string DIENTHOAI{ get { return dienthoai; } set { dienthoai = value; }}
		public int ID_CUAHANGTRUONG{ get { return id_cuahangtruong; } set { id_cuahangtruong = value; }}
		public bool KETCA{ get { return ketca; } set { ketca = value; }}

		public Ob_POS_DM_CuaHang()
		{
			id_cuahang = 0;
			macuahang = "";
			tencuahang = "";
			pos = 0;
			id_kho = 0;
			diachi = "";
			dienthoai = "";
			id_cuahangtruong = 0;
			ketca = false;
		}

		public Ob_POS_DM_CuaHang( int new_id_cuahang, string new_macuahang, string new_tencuahang, int new_pos, int new_id_kho, string new_diachi, string new_dienthoai, int new_id_cuahangtruong, bool new_ketca)	
		{
			id_cuahang = new_id_cuahang;
			macuahang = new_macuahang;
			tencuahang = new_tencuahang;
			pos = new_pos;
			id_kho = new_id_kho;
			diachi = new_diachi;
			dienthoai = new_dienthoai;
			id_cuahangtruong = new_id_cuahangtruong;
			ketca = new_ketca;
		}

		public Ob_POS_DM_CuaHang(Ob_POS_DM_CuaHang newOb)
		{
			id_cuahang = newOb.ID_CUAHANG;
			macuahang = newOb.MACUAHANG;
			tencuahang = newOb.TENCUAHANG;
			pos = newOb.POS;
			id_kho = newOb.ID_KHO;
			diachi = newOb.DIACHI;
			dienthoai = newOb.DIENTHOAI;
			id_cuahangtruong = newOb.ID_CUAHANGTRUONG;
			ketca = newOb.KETCA;
		}

	}
}
