using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//CreateTimes : 06/04/2016 08:31:07.AM

namespace Bitas
{
	public class main_Bitas
	{
        public static KeysList_DM_BangGia keys_DM_BangGia = new KeysList_DM_BangGia();
        public static KeysList_DM_BoSuuTap keys_DM_BoSuuTap = new KeysList_DM_BoSuuTap();
        public static KeysList_DM_ChietKhau keys_DM_ChietKhau = new KeysList_DM_ChietKhau();
        public static KeysList_DM_ChiNhanh keys_DM_ChiNhanh = new KeysList_DM_ChiNhanh();
        public static KeysList_DM_ChucNang keys_DM_ChucNang = new KeysList_DM_ChucNang();
        public static KeysList_DM_ChungLoai keys_DM_ChungLoai = new KeysList_DM_ChungLoai();
        public static KeysList_DM_DoiTuong keys_DM_DoiTuong = new KeysList_DM_DoiTuong();
        public static KeysList_DM_DongSP keys_DM_DongSP = new KeysList_DM_DongSP();
        public static KeysList_DM_DonViTien keys_DM_DonViTien = new KeysList_DM_DonViTien();
        public static KeysList_DM_DonViTinh keys_DM_DonViTinh = new KeysList_DM_DonViTinh();
        public static KeysList_DM_DuLieu keys_DM_DuLieu = new KeysList_DM_DuLieu();
        public static KeysList_DM_KhachHang keys_DM_KhachHang = new KeysList_DM_KhachHang();
        public static KeysList_DM_Kho keys_DM_Kho = new KeysList_DM_Kho();
        public static KeysList_DM_KhuVuc keys_DM_KhuVuc = new KeysList_DM_KhuVuc();
        public static KeysList_DM_LoaiCK keys_DM_LoaiCK = new KeysList_DM_LoaiCK();
        public static KeysList_DM_LoaiHang keys_DM_LoaiHang = new KeysList_DM_LoaiHang();
        public static KeysList_DM_LoaiKH keys_DM_LoaiKH = new KeysList_DM_LoaiKH();
        public static KeysList_DM_Mau keys_DM_Mau = new KeysList_DM_Mau();
        public static KeysList_DM_NhaCungCap keys_DM_NhaCungCap = new KeysList_DM_NhaCungCap();
        public static KeysList_DM_NhomSize_H keys_DM_NhomSize_H = new KeysList_DM_NhomSize_H();
        public static KeysList_DM_NhomSize_L keys_DM_NhomSize_L = new KeysList_DM_NhomSize_L();
        public static KeysList_DM_SanPham keys_DM_SanPham = new KeysList_DM_SanPham();
        public static KeysList_DM_TinhTP keys_DM_TinhTP = new KeysList_DM_TinhTP();
        public static KeysList_HT_DuLieuChucNang keys_HT_DuLieuChucNang = new KeysList_HT_DuLieuChucNang();
        public static KeysList_HT_LichSuDangNhap keys_HT_LichSuDangNhap = new KeysList_HT_LichSuDangNhap();
        public static KeysList_HT_NguoiDung keys_HT_NguoiDung = new KeysList_HT_NguoiDung();
        public static KeysList_HT_NhomNguoiDung keys_HT_NhomNguoiDung = new KeysList_HT_NhomNguoiDung();
        public static KeysList_HT_PhanQuyenDuLieu keys_HT_PhanQuyenDuLieu = new KeysList_HT_PhanQuyenDuLieu();
        public static KeysList_HT_PhienBan keys_HT_PhienBan = new KeysList_HT_PhienBan();
        public static KeysList_HT_KeyAPI keys_HT_KeyAPI = new KeysList_HT_KeyAPI();
        public static KeysList_SP_BangGia keys_SP_BangGia = new KeysList_SP_BangGia();
        public static KeysList_SP_Barcode keys_SP_Barcode = new KeysList_SP_Barcode();
        public static KeysList_SP_HinhAnh keys_SP_HinhAnh = new KeysList_SP_HinhAnh();
        public static KeysList_Phanquyen keys_Phanquyen = new KeysList_Phanquyen();
        public static KeysList_DM_HeThong keys_DM_HeThong = new KeysList_DM_HeThong();
        public static KeysList_HT_TruSo keys_HT_TruSo = new KeysList_HT_TruSo();
        public static KeysList_POS_DM_CuaHang keys_POS_DM_CuaHang = new KeysList_POS_DM_CuaHang();
        public static KeysList_POS_BanHang_H keys_POS_BanHang_H = new KeysList_POS_BanHang_H();
        public static KeysList_POS_BanHang_L keys_POS_BanHang_L = new KeysList_POS_BanHang_L();
        public static KeysList_POS_NhapHang_H keys_POS_NhapHang_H = new KeysList_POS_NhapHang_H();
        public static KeysList_POS_NhapHang_L keys_POS_NhapHang_L = new KeysList_POS_NhapHang_L();
        public static KeysList_POS_KhuyenMaiDoiTuong keys_POS_KhuyenMaiDoiTuong = new KeysList_POS_KhuyenMaiDoiTuong();
        public static KeysList_POS_KhuyenMaiLoaiHang keys_POS_KhuyenMaiLoaiHang = new KeysList_POS_KhuyenMaiLoaiHang();
        public static KeysList_POS_KhuyenMai keys_POS_KhuyenMai = new KeysList_POS_KhuyenMai();
        public static KeysList_POS_KhuyenMaiCuaHang keys_POS_KhuyenMaiCuaHang = new KeysList_POS_KhuyenMaiCuaHang();
        public static KeysList_POS_KhuyenMaiKhoangGiaHoaDon keys_POS_KhuyenMaiKhoangGiaHoaDon = new KeysList_POS_KhuyenMaiKhoangGiaHoaDon();
        public static KeysList_POS_KhuyenMaiKhoangGiaSanPham keys_POS_KhuyenMaiKhoangGiaSanPham = new KeysList_POS_KhuyenMaiKhoangGiaSanPham();
        public static KeysList_HT_NguoiDung_CuaHang keys_HT_NguoiDung_CuaHang = new KeysList_HT_NguoiDung_CuaHang();
        public static KeysList_POS_DM_KhachHang keys_POS_DM_KhachHang = new KeysList_POS_DM_KhachHang();
        public static KeysList_POS_KiemKe_H keys_POS_KiemKe_H = new KeysList_POS_KiemKe_H();
        public static KeysList_POS_KiemKe_L keys_POS_KiemKe_L = new KeysList_POS_KiemKe_L();
        public static SQLServer SQL = new SQLServer();
        public static Multi Multi = new Multi();
	}
}

