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

        public NhaCungCap(string maNCC, string tenCongTy, string mst, string diaChi, List<long> sdt, string mail)
        {
            MaNCC = maNCC;
            TenCongTy = tenCongTy;
            MST = mst;
            DiaChi = diaChi;
            SDT = sdt;
            Mail = mail;
            DanhSachMatHang = new List<MatHang>();
        }

        public NhaCungCap(string maNCC, string tenCongTy, string mst, string diaChi, List<long> sdt, string mail, MatHang danhSachMatHang)
        {
            MaNCC = maNCC;
            TenCongTy = tenCongTy;
            MST = mst;
            DiaChi = diaChi;
            SDT = sdt;
            Mail = mail;
            DanhSachMatHang = new List<MatHang> { danhSachMatHang };
        }

        public NhaCungCap(string maNCC, string tenCongTy, string mst, string diaChi, long sdt, string mail, MatHang danhSachMatHang)
        {
            MaNCC = maNCC;
            TenCongTy = tenCongTy;
            MST = mst;
            DiaChi = diaChi;
            SDT = new List<long> { sdt }; // Sửa lỗi
            Mail = mail;
            DanhSachMatHang = new List<MatHang> { danhSachMatHang };
        }

        public void ThemMatHang(MatHang matHang)
        {
            if (!DanhSachMatHang.Contains(matHang))
            {
                DanhSachMatHang.Add(matHang);
            }
        }

        public void XuatNhaCungCap()
        {
            Console.WriteLine($"{MaNCC} \t {TenCongTy} \t"); 
        }

        public void XuatCacMatHangMaNhaCungUngCungCap()
        {
            Console.WriteLine($"Nha Cung Ung {this.TenCongTy} Se Cung Ung Cac Mat Hang: ");
            if (DanhSachMatHang.Count == 0)
            {
                Console.WriteLine("Nha Cung Cap Ko Co Danh Sach Mat Hang!!!");
            }
            else
            {
                foreach (var i in DanhSachMatHang)
                {
                    Console.WriteLine(i.TenMatHang);
                }
            }
        }
    }
}
