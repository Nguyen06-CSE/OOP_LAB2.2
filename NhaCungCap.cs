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
        public string MST;
        public string DiaChi;
        public List<long> SDT;
        public string Mail;
        public List<MatHang> DanhSachMatHang;

        public NhaCungCap(string maNCC, string tenCongTy, string mst, string diaChi, long sdt, string mail)
        {
            MaNCC = maNCC;
            TenCongTy = tenCongTy;
            MST = mst;
            DiaChi = diaChi;
            List<long> SDT = new List<long>();
            SDT.Add(sdt);
            Mail = mail;
            DanhSachMatHang = new List<MatHang>();
        }

        public NhaCungCap(string maNCC, string tenCongTy, string mst, string diaChi, List<long> sdt, string mail)
        {
            MaNCC = maNCC;
            TenCongTy = tenCongTy;
            MST = mst;
            SDT = new List<long>();
            Mail = mail;
            DanhSachMatHang = new List<MatHang>();
        }


        public void ThemMatHang(MatHang matHang)
        {
            DanhSachMatHang.Add(matHang);
            matHang.ThemNhaCungCap(this);
        }


        public void XuatNhaCungCap()
        {
            Console.WriteLine($"{MaNCC} \t {TenCongTy} \t"); 
        }
    }
}
