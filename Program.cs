using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khoi tao mat hang voi phuong thuc 1
            MatHang mh = new MatHang("MH01", "Bánh Oreo", 25000);


            //khoi tao nha cung cap
            NhaCungCap ncc = new NhaCungCap("NCC001", "Cong Ty ABC", "123456789", "Ha Noi", new List<long> { 0123456789, 0987654321 }, "abc@gmail.com");
            NhaCungCap ncc1 = new NhaCungCap("NCC002", "Cong Ty XYZ", "987654321", "Ho Chi Minh", 0356789123, "xyz@yahoo.com");
            NhaCungCap ncc2 = new NhaCungCap("NCC003", "Cong Ty DEF", "564738291", "Da Nang", new List<long> { 0765432198, 0246574839 }, "def@outlook.com");
            NhaCungCap ncc3 = new NhaCungCap("NCC004", "Cong Ty LMN", "432187654", "Can Tho", 0556677889, "lmn@company.com");
            NhaCungCap ncc4 = new NhaCungCap("NCC005", "Cong Ty PQR", "192837465", "Hai Phong", new List<long> { 0192837465, 0273648596 }, "pqr@business.com");


            //them mat hang cho nha cung cap
            ncc.ThemMatHang(mh);


            //khoi tao mat hang voi phuong thuc 2
            MatHang mh1 = new MatHang("MH02", "Bánh Que", 45000, ncc1);
            MatHang mh2 = new MatHang("MH03", "Noi Chien Khong Dau", 99000, ncc2);
            MatHang mh3 = new MatHang("MH04", "Ca Hoi Hoang", 1000000, ncc);
            MatHang mh4 = new MatHang("MH05", "Nuoc Mam", 115000, ncc);

            //them nha cung cap cho cac mat hang
            mh.ThemNhaCungCap(ncc4);

            //xuat danh sach cac nha cung cap cua mat hang nay
            //mh.XuatCacNhaCungUng();


            //khoi tao khu vuc
            KhuVuc kv = new KhuVuc("KV01", "Khu Thuc Pham", mh);
            KhuVuc kv1 = new KhuVuc("KV002", "Khu Do Gia Dung", mh2);
            KhuVuc kv2 = new KhuVuc("KV003", "Khu Do Tuoi", mh3);
            KhuVuc kv3 = new KhuVuc("KV004", "Khu Banh Keo", mh4);
            KhuVuc kv4 = new KhuVuc("KV005", "Khu Gia Vi", mh2);

            //them cac mat hang cho khu vuc
            kv1.ThemMatHang(mh1);
            kv1.ThemMatHang(mh2);
            kv1.ThemMatHang(mh3);
            kv1.ThemMatHang(mh4);

            //xuat cac loai hang hoa cua khu vuc hien tai
            //kv1.XuatLoatHangChuyenBan();


            //khoi tao nhan vien
            NhanVien nv = new NhanVien("Nguyen Van A", "01/01/1990", "Ha Noi", 0123456789, "10/10/2015", 123456789, kv);
            NhanVien nv1 = new NhanVien("Tran Thi B", "15/05/1985", "Hai Phong", 0987654321, "05/06/2017", 987654321, kv);
            NhanVien nv2 = new NhanVien("Le Van C", "22/08/1992", "Da Nang", 0345678912, "20/09/2018", 345678912, kv4);
            NhanVien nv3 = new NhanVien("Pham Hong D", "10/12/1988", "Can Tho", 0765432198, "15/04/2016", 765432198, kv2);
            NhanVien nv4 = new NhanVien("Do Minh E", "30/03/1995", "Ho Chi Minh", 0234567891, "01/01/2020", 234567891, kv);

            //khoi tao khach hang
            KhachHang kh = new KhachHang("KH01", "Trần Thị B", "Hồ Chí Minh");

            //khoi tao hoa don
            HoaDon hd = new HoaDon("HD001", DateTime.Now, nv, kh);

            //them mat hang cho hoa don
            hd.ThemMatHang(mh, 2);
            hd.ThemMatHang(mh1, 2);
            hd.ThemMatHang(mh2, 3);
            hd.ThemMatHang(mh3, 1);
            hd.ThemMatHang(mh4, 10);

            //khoi tao chi tiet hoa don
            ChiTietHoaDon cthd = new ChiTietHoaDon(mh, 2);
            ChiTietHoaDon cthd1 = new ChiTietHoaDon(mh1, 2);
            ChiTietHoaDon cthd2 = new ChiTietHoaDon(mh2, 3);
            ChiTietHoaDon cthd3 = new ChiTietHoaDon(mh3, 1);
            ChiTietHoaDon cthd4 = new ChiTietHoaDon(mh4, 10);

            //xuat cac hang hoa cua nguoi mua ra hoa don voi so luong
            cthd.XuatChiTietHoaDon();
            cthd1.XuatChiTietHoaDon();
            cthd2.XuatChiTietHoaDon();
            cthd3.XuatChiTietHoaDon();
            cthd4.XuatChiTietHoaDon();
            //in ra so tien cua tong cac hang hoa ma nguoi dung da mua
            hd.XuatHoaDon();
        }
    }
}
