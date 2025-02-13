using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi
{
    internal class NhaCungCap
    {
        public string MaNCC;
        public string TenCongTy;
        public List<MatHang> DanhSachMatHang;

        public NhaCungCap(string maNCC, string tenCongTy)
        {
            MaNCC = maNCC;
            TenCongTy = tenCongTy;
            DanhSachMatHang = new List<MatHang>();
        }

        public void ThemMatHang(MatHang matHang)
        {
            DanhSachMatHang.Add(matHang);
            matHang.ThemNhaCungCap(this);
        }
    }
}
