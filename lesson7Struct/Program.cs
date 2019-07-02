using System;
using System.Text;

struct SinhVien
{
    public int MaSo;
    public string HoTen;
    public double DiemToan;
    public double DiemLy;
    public double DiemVan;
};

namespace lesson7Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Khai báo 1 kiểu dữ liệu SinhVien với các trường thông tin như đề bài.
             * Khai báo và khởi tạo 1 đối tượng SV1 kiểu SinhVien.
             */
            SinhVien SV1 = new SinhVien();
            Console.WriteLine(" Nhap thong tin sinh vien: ");
            /*
             * Đây là hàm hỗ trợ nhập thông tin sinh viên.
             * Sử dụng từ khoá out để có thể cập nhật giá trị nhập được ra biến SV1 bên ngoài 
             * khi kết thúc gọi hàm (có thể xem lại bài Hàm trong C#).
             */
            NhapThongTinSinhVien(out SV1);
            Console.WriteLine("*********");
            Console.WriteLine(" Thong tin sinh vien vua nhap la: ");
            XuatThongTinSinhVien(SV1);
            Console.WriteLine(" Diem TB cua sinh vien la: " + DiemTBSinhVien(SV1));

            Console.ReadLine();
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ma so sinh vien: ");
            SV.MaSo = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HoTen = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan = Double.Parse(Console.ReadLine());
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.MaSo);
            Console.WriteLine(" Ho ten: " + SV.HoTen);
            Console.WriteLine(" Diem toan: " + SV.DiemToan);
            Console.WriteLine(" Diem ly: " + SV.DiemLy);
            Console.WriteLine(" Diem van: " + SV.DiemVan);
        }

        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan + SV.DiemLy + SV.DiemVan) / 3;
        }

    }
}
