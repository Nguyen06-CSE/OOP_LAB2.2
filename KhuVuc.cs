using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi
{
    internal class KhuVuc
    {
        public string MaKhuVuc;
        public string TenKhuVuc;
        public List<NhanVien> DanhSachNhanVien;

        public KhuVuc(string maKhuVuc, string tenKhuVuc)
        {
            MaKhuVuc = maKhuVuc;
            TenKhuVuc = tenKhuVuc;
            DanhSachNhanVien = new List<NhanVien>();
        }

        public void ThemNhanVien(NhanVien nv)
        {
            DanhSachNhanVien.Add(nv);
        }
    }
}
