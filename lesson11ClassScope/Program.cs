using System;

namespace lesson11ClassScope
{
    class SinhVien
    {
        private string maSv;
        private string hoTen;
        double diemToan = 15;
        double diemVan = 5;

        private double diemLy = 2;

        public double HandlingDiemLy
        {
            get
            {
                return diemLy;
            }
            set
            {
                diemLy = value;
            }
        }

        public void inThongTinDiemTB()
        {
            double DTB = (diemToan + diemVan) / 2;
            Console.WriteLine("Sinh vien " + hoTen + " diem TB la " + DTB);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();
            SV1.inThongTinDiemTB();
            Console.WriteLine(SV1.HandlingDiemLy);
            SV1.HandlingDiemLy = 8;
        }
    }


}
