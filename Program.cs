using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KhuVuc kv1 = new KhuVuc("KV01", "Khu Thực phẩm");
            NhanVien nv = new NhanVien("NV01", "Nguyễn Văn A", "Hà Nội", "0987654321", kv1);
            KhachHang kh = new KhachHang("KH01", "Trần Thị B", "Hồ Chí Minh");
            MatHang mh = new MatHang("MH01", "Bánh Oreo", 25000);
            NhaCungCap ncc = new NhaCungCap("NCC01", "Công ty ABC");
            ncc.ThemMatHang(mh);

            HoaDon hd = new HoaDon("HD001", DateTime.Now, nv, kh);
            hd.ThemMatHang(mh, 2);
            ChiTietHoaDon cthd = new ChiTietHoaDon(mh, 2);
            Console.WriteLine($"mat hang : {cthd.MatHang} \t so luong {cthd.SoLuong}");
            Console.WriteLine($"Tổng tiền hóa đơn: {hd.TongTien} VND");
        }
    }
}
