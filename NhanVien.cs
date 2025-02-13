using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi
{
    internal class NhanVien
    {
        public string HoTen;
        public string NgaySinh;
        public string DiaChi;
        public long SoDienThoai;
        public string NgayVaoLamViec;
        public long CMND;
        public KhuVuc KhuVucLamViec; // Mối quan hệ 1-1 với KhuVuc

        public NhanVien(string hoTen, string ngaySinh, string diaChi, long soDienThoai, string ngayVaoLamViec, long cmnd, KhuVuc khuVuc)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            NgayVaoLamViec = ngayVaoLamViec;
            CMND = cmnd;
            KhuVucLamViec = khuVuc;
            khuVuc.ThemNhanVien(this); // this ở đây là NhanVien khi ta khơir tạo 
        }
    }
}
