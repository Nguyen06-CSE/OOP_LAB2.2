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

        
        //phuong thuc khoi tao 1 (khong can khai bao nha cung cap)
        public MatHang(string maMatHang, string tenMatHang, decimal donGiaBan)
        {
            MaMatHang = maMatHang;
            TenMatHang = tenMatHang;
            DonGiaBan = donGiaBan;
            DanhSachNhaCungCap = new List<NhaCungCap>();
        }


        //phuong thuc khoi tao 2 (can khai bao nha cung cap)
        public MatHang(string maMatHang, string tenMatHang, decimal donGiaBan, NhaCungCap cungCap)
        {
            MaMatHang = maMatHang;
            TenMatHang = tenMatHang;
            DonGiaBan = donGiaBan;
            DanhSachNhaCungCap = new List<NhaCungCap>();
            ThemNhaCungCap(cungCap);
        }

        public void ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (!DanhSachNhaCungCap.Contains(nhaCungCap))
                DanhSachNhaCungCap.Add(nhaCungCap);
        }

        public void XuatMatHang()
        {
            Console.WriteLine($"{MaMatHang} \t {TenMatHang} \t {DonGiaBan} ");
        }

        public void XuatCacNhaCungUng()
        {
            if(DanhSachNhaCungCap.Count == 0)
            {
                Console.WriteLine("danh sach nhu cung ung rong!!!");
            }
            else
            {
                Console.WriteLine($"mat hang {TenMatHang} duoc cung cap boi cac nha cung cap duoi day: ");
                foreach (var i in DanhSachNhaCungCap)
                {
                    i.XuatNhaCungCap();
                }
            }
            
        }
    }
}
