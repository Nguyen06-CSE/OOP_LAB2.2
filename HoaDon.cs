using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi
{
    internal class HoaDon
    {
        public string SoHoaDon;
        public DateTime NgayLap;
        public NhanVien NhanVienBanHang;
        public KhachHang KhachHangMua;
        public List<ChiTietHoaDon> DanhSachMatHang;
        public decimal TongTien => TinhTongTien(); // Tính tổng tiền tự động

        public HoaDon(string soHoaDon, DateTime ngayLap, NhanVien nhanVien, KhachHang khachHang)
        {
            SoHoaDon = soHoaDon;
            NgayLap = ngayLap;
            NhanVienBanHang = nhanVien;
            KhachHangMua = khachHang;
            DanhSachMatHang = new List<ChiTietHoaDon>();
        }

        public void ThemMatHang(MatHang matHang, int soLuong)
        {
            DanhSachMatHang.Add(new ChiTietHoaDon(matHang, soLuong));
        }

        private decimal TinhTongTien()
        {
            decimal tong = 0;
            foreach (var ct in DanhSachMatHang)
                tong += ct.ThanhTien;
            return tong;
        }


        public void XuatHoaDon()
        {
            Console.WriteLine($"Tong Hoa Don {TinhTongTien()} VND\n{SoHoaDon} {NgayLap} Nhan Vien: {NhanVienBanHang.HoTen} Khach Hang {KhachHangMua.HoTen}");
        }
    }
}
