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
        public double TongTien => TinhTongTien(); // Tính tổng tiền tự động

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

        private double TinhTongTien()
        {
            double tong = 0;
            foreach (var ct in DanhSachMatHang)
                tong += ct.ThanhTien;
            return tong;
        }


        public void XuatHoaDon()
        {
            Console.WriteLine("==================================================================================================================");
            Console.WriteLine($"{"Tong Hoa Don:",-15} {TinhTongTien(),15:N0} VND");
            Console.WriteLine($"{"So Hoa Don:",-15} {SoHoaDon,-10} {"Ngay Lap:",-10} {NgayLap:dd/MM/yyyy}");
            Console.WriteLine($"{"Nhan Vien:",-15} {NhanVienBanHang.HoTen,-20} {"Khach Hang:",-12} {KhachHangMua.HoTen,-20}");

        }
    }
}
