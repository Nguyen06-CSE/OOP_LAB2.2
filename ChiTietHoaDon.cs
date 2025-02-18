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
        public double ThanhTien => SoLuong * MatHang.DonGiaBan; // Tính thành tiền tự động

        public ChiTietHoaDon(MatHang matHang, int soLuong)
        {
            MatHang = matHang;
            SoLuong = soLuong;
        }

        public void XuatChiTietHoaDon()
        {
            Console.WriteLine($"{MatHang.TenMatHang,-20} | Gia: {MatHang.DonGiaBan,10:N0} VND | SL: {SoLuong,3} | Thanh Tien: {ThanhTien,15:N0} VND");

        }
    }
}
