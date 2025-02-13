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
        public List<MatHang> LoaiHang;

        public KhuVuc(string maKhuVuc, string tenKhuVuc, MatHang matHang)
        {
            MaKhuVuc = maKhuVuc;
            TenKhuVuc = tenKhuVuc;
            DanhSachNhanVien = new List<NhanVien>();
            LoaiHang = new List<MatHang>();
            ThemMatHang(matHang);
        }

        public void ThemNhanVien(NhanVien nv)
        {
            DanhSachNhanVien.Add(nv);
        }

        public void ThemMatHang(MatHang mh)
        {
            LoaiHang.Add(mh);
        }

        public void XuatLoatHangChuyenBan()
        {
            Console.WriteLine($"cac mat hang thuoc mot loai hang ma khu vuc {this.TenKhuVuc} chuyen ban la:");
            foreach(var i in LoaiHang)
            {
                i.XuatMatHang();
            }
        }

    }
}
