using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi
{
    internal class LoaiHang
    {
        public string Ma;
        public string Ten;
        public List<MatHang> DanhSachMatHang;

        public LoaiHang (string ma, string ten, List<MatHang> danhSachMatHang)
        {
            Ma = ma;
            Ten = ten;
            DanhSachMatHang = danhSachMatHang;
        }

        public void XuatCacMatHangTrongLoaiHang()
        {
            Console.WriteLine($"Loai Hang {Ten} Voi Ma {Ma} Se Gom Cac Mat Hang: ");
            foreach(var i in  DanhSachMatHang)
            {
                Console.WriteLine(i.TenMatHang);
            }

        }

    }
}
