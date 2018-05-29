using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//CreateTimes : 28/05/2018 10:27:13.AM

namespace Bitas
{
	public class Ob_POS_DM_KhachHang
	{
		private string id_khachhang;
		private string tenkhachhang;
		private string sodienthoai;
		private DateTime ngaysinh;
		private int gioitinh;
		private string diachi;
		private DateTime createdtime;
		private string createdby;
		private DateTime modifiedtime;
		private string modifiedby;
		public string ID_KHACHHANG{ get { return id_khachhang; } set { id_khachhang = value; }}
		public string TENKHACHHANG{ get { return tenkhachhang; } set { tenkhachhang = value; }}
		public string SODIENTHOAI{ get { return sodienthoai; } set { sodienthoai = value; }}
		public DateTime NGAYSINH{ get { return ngaysinh; } set { ngaysinh = value; }}
		public int GIOITINH{ get { return gioitinh; } set { gioitinh = value; }}
		public string DIACHI{ get { return diachi; } set { diachi = value; }}
		public DateTime CREATEDTIME{ get { return createdtime; } set { createdtime = value; }}
		public string CREATEDBY{ get { return createdby; } set { createdby = value; }}
		public DateTime MODIFIEDTIME{ get { return modifiedtime; } set { modifiedtime = value; }}
		public string MODIFIEDBY{ get { return modifiedby; } set { modifiedby = value; }}

		public Ob_POS_DM_KhachHang()
		{
			id_khachhang = "";
			tenkhachhang = "";
			sodienthoai = "";
			ngaysinh = DateTime.MinValue;
			gioitinh = 0;
			diachi = "";
			createdtime = DateTime.MinValue;
			createdby = "";
			modifiedtime = DateTime.MinValue;
			modifiedby = "";
		}

		public Ob_POS_DM_KhachHang( string new_id_khachhang, string new_tenkhachhang, string new_sodienthoai, DateTime new_ngaysinh, int new_gioitinh, string new_diachi, DateTime new_createdtime, string new_createdby, DateTime new_modifiedtime, string new_modifiedby)	
		{
			id_khachhang = new_id_khachhang;
			tenkhachhang = new_tenkhachhang;
			sodienthoai = new_sodienthoai;
			ngaysinh = new_ngaysinh;
			gioitinh = new_gioitinh;
			diachi = new_diachi;
			createdtime = new_createdtime;
			createdby = new_createdby;
			modifiedtime = new_modifiedtime;
			modifiedby = new_modifiedby;
		}

		public Ob_POS_DM_KhachHang(Ob_POS_DM_KhachHang newOb)
		{
			id_khachhang = newOb.ID_KHACHHANG;
			tenkhachhang = newOb.TENKHACHHANG;
			sodienthoai = newOb.SODIENTHOAI;
			ngaysinh = newOb.NGAYSINH;
			gioitinh = newOb.GIOITINH;
			diachi = newOb.DIACHI;
			createdtime = newOb.CREATEDTIME;
			createdby = newOb.CREATEDBY;
			modifiedtime = newOb.MODIFIEDTIME;
			modifiedby = newOb.MODIFIEDBY;
		}

	}
}
