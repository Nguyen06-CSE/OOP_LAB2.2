using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi
{
    internal class ChiTietHoaDon
    {
        public MatHang MatHang;
        public int SoLuong;
        public decimal ThanhTien => SoLuong * MatHang.DonGiaBan; // Tính thành tiền tự động

        public ChiTietHoaDon(MatHang matHang, int soLuong)
        {
            MatHang = matHang;
            SoLuong = soLuong;
        }

        public void XuatChiTietHoaDon()
        {
            Console.WriteLine($"{MatHang.TenMatHang}\tco gia\t{MatHang.DonGiaBan}\tvoi so luong {SoLuong}\tthanh tien\t{ThanhTien}");
        }
    }
}
