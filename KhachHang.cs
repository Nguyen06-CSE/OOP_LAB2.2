using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi
{
    internal class KhachHang
    {
        public string MaKhachHang;
        public string HoTen;
        public string DiaChi;

        public KhachHang(string maKhachHang, string hoTen, string diaChi)
        {
            MaKhachHang = maKhachHang;
            HoTen = hoTen;
            DiaChi = diaChi;
        }
    }
}
