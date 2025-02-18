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
        public double DonGiaBan;
        public List<NhaCungCap> DanhSachNhaCungCap;

        
        //phuong thuc khoi tao 1 (khong can khai bao nha cung cap)
        public MatHang(string maMatHang, string tenMatHang, double donGiaBan)
        {
            MaMatHang = maMatHang;
            TenMatHang = tenMatHang;
            DonGiaBan = donGiaBan;
            //DanhSachNhaCungCap = new List<NhaCungCap>();
        }


        //phuong thuc khoi tao 2 (can khai bao nha cung cap)
        //public MatHang(string maMatHang, string tenMatHang, double donGiaBan)
        //{
        //    MaMatHang = maMatHang;
        //    TenMatHang = tenMatHang;
        //    DonGiaBan = donGiaBan;
        //    //DanhSachNhaCungCap = new List<NhaCungCap>();
        //    //ThemNhaCungCap(cungCap);
        //}

        

        public void XuatMatHang()
        {
            Console.WriteLine($"{MaMatHang} \t {TenMatHang} \t {DonGiaBan} ");
        }

        public void XuatCacNhaCungUng()
        {
            if (DanhSachNhaCungCap == null || DanhSachNhaCungCap.Count == 0)
            {
                Console.WriteLine("Danh sách nhà cung ứng rỗng!");
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
