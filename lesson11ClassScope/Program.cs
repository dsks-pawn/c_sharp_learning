using System;

namespace lesson11ClassScope
{
    class SinhVien
    {
        private string MaSv;
        private string Hoten;
        private double DiemToan = 15;
        private double DiemVan = 5;

        public void inThongTinDiemTB()
        {
            double DTB = (DiemToan + DiemVan) / 2;
            Console.WriteLine("Sinh vien " + Hoten + " diem TB la " + DTB);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();
            SV1.inThongTinDiemTB();
        }
    }


}
