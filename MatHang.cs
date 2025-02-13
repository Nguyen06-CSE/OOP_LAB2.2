using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi
{
    internal class MatHang
    {
        public string MaMatHang;
        public string TenMatHang;
        public decimal DonGiaBan;
        public List<NhaCungCap> DanhSachNhaCungCap;

        public MatHang(string maMatHang, string tenMatHang, decimal donGiaBan)
        {
            MaMatHang = maMatHang;
            TenMatHang = tenMatHang;
            DonGiaBan = donGiaBan;
            DanhSachNhaCungCap = new List<NhaCungCap>();
        }

        public void ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (!DanhSachNhaCungCap.Contains(nhaCungCap))
                DanhSachNhaCungCap.Add(nhaCungCap);
        }
    }
}
