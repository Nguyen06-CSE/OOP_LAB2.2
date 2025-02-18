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
            //khoi tao mat hang voi phuong thuc 2
            MatHang mh1 = new MatHang("MH02", "Bánh Que", 45000);
            MatHang mh2 = new MatHang("MH03", "Noi Chien Khong Dau", 99000);
            MatHang mh3 = new MatHang("MH04", "Ca Hoi Hoang", 1000000);
            MatHang mh4 = new MatHang("MH05", "Nuoc Mam", 115000);

            //khoi tao nha cung cap
            NhaCungCap ncc = new NhaCungCap("NCC001", "Công Ty ABC", "123456789", "Hà Nội", new List<long> { 0123456789, 0987654321 }, "abc@gmail.com", mh1);
            NhaCungCap ncc1 = new NhaCungCap("NCC002", "Cong Ty XYZ", "987654321", "Ho Chi Minh", 0356789123, "xyz@yahoo.com", mh4);
            NhaCungCap ncc2 = new NhaCungCap("NCC003", "Cong Ty DEF", "564738291", "Da Nang", new List<long> { 0765432198, 0246574839 }, "def@outlook.com");




            //NhaCungCap ncc1 = new NhaCungCap("NCC002", "Cong Ty XYZ", "987654321", "Ho Chi Minh", 0356789123, "xyz@yahoo.com", mh4);
            //NhaCungCap ncc2 = new NhaCungCap("NCC003", "Cong Ty DEF", "564738291", "Da Nang", new List<long> { 0765432198, 0246574839 }, "def@outlook.com");
            NhaCungCap ncc3 = new NhaCungCap("NCC004", "Cong Ty LMN", "432187654", "Can Tho", 0556677889, "lmn@company.com", mh1);
            NhaCungCap ncc4 = new NhaCungCap("NCC005", "Cong Ty PQR", "192837465", "Hai Phong", new List<long> { 0192837465, 0273648596 }, "pqr@business.com");

        

            //ncc.XuatCacMatHangMaNhaCungUngCungCap();
            //ncc1.XuatCacMatHangMaNhaCungUngCungCap();
            //ncc2.XuatCacMatHangMaNhaCungUngCungCap();
            //ncc3.XuatCacMatHangMaNhaCungUngCungCap();
            //ncc4.XuatCacMatHangMaNhaCungUngCungCap();

            //xuat danh sach cac nha cung cap cua mat hang nay
            mh.XuatCacNhaCungUng();



            // Tạo danh sách mặt hàng giả định
            MatHang mh5 = new MatHang("MH001", "Dien Thoai", 10000000);
            MatHang mh6 = new MatHang("MH002", "Laptop", 20000000);
            MatHang mh7 = new MatHang("MH003", "TV", 15000000);
            MatHang mh8 = new MatHang("MH004", "May Lanh", 12000000);
            MatHang mh9 = new MatHang("MH005", "Tu Lanh", 18000000);
            MatHang mh10 = new MatHang("MH006", "Lo Vi Song", 3000000);
            MatHang mh11 = new MatHang("MH007", "May Giat", 7000000);
            MatHang mh12 = new MatHang("MH008", "Quat Dien", 800000);
            MatHang mh13 = new MatHang("MH009", "Den LED", 500000);
            MatHang mh14 = new MatHang("MH010", "Noi Com Dien", 1200000);

            // Khởi tạo các loại hàng hóa
            LoaiHang loai1 = new LoaiHang("LH001", "Dien Thoai & Laptop", new List<MatHang> { mh5, mh6 });
            LoaiHang loai2 = new LoaiHang("LH002", "Tivi & May Lanh", new List<MatHang> { mh7, mh8 });
            LoaiHang loai3 = new LoaiHang("LH003", "Tu Lanh & Lo Vi Song", new List<MatHang> { mh9, mh10 });
            LoaiHang loai4 = new LoaiHang("LH004", "May Giat & Quat", new List<MatHang> { mh11, mh12 });
            LoaiHang loai5 = new LoaiHang("LH005", "Den & Noi Com", new List<MatHang> { mh13, mh14 });


            //loai1.XuatCacMatHangTrongLoaiHang();
            //loai2.XuatCacMatHangTrongLoaiHang();
            //loai3.XuatCacMatHangTrongLoaiHang();
            //loai4.XuatCacMatHangTrongLoaiHang();
            //loai5.XuatCacMatHangTrongLoaiHang();



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
