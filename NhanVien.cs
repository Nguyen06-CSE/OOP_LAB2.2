using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi
{
    internal class NhanVien
    {
        public string MaNhanVien;
        public string HoTen;
        public string DiaChi;
        public string SoDienThoai;
        public KhuVuc KhuVucLamViec; // Mối quan hệ 1-1 với KhuVuc

        public NhanVien(string maNhanVien, string hoTen, string diaChi, string soDienThoai, KhuVuc khuVuc)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            KhuVucLamViec = khuVuc;
            khuVuc.ThemNhanVien(this); // this ở đây là NhanVien khi ta khơir tạo 
        }
    }
}
