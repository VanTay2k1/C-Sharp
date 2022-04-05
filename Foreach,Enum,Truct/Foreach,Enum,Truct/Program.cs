using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Enum_Truct
{
    class Program
    {
        enum dienSinhVien
        {
            hoNgheo,
            hoCanNgheo,
            binhThuong,
        }
        struct SinhVien
        {
            public int MaSV_150;
            public string HoTen_150;
            public double DiemToan_150;
            public double DiemLy_150;
            public double DiemVan_150;
            public int dienSinhVien_150;
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ma SV: ");
            SV.MaSV_150 = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HoTen_150 = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan_150 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy_150 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan_150 = Double.Parse(Console.ReadLine());
            Console.WriteLine(" Dien Sinh Vien: 0:hoCanNgheo, 1:hoNgheo, 2:binhThuong ");
            SV.dienSinhVien_150 = int.Parse(Console.ReadLine());
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.MaSV_150);
            Console.WriteLine(" Ho ten: " + SV.HoTen_150);
            Console.WriteLine(" Diem toan: " + SV.DiemToan_150);
            Console.WriteLine(" Diem ly: " + SV.DiemLy_150);
            Console.WriteLine(" Diem van: " + SV.DiemVan_150);
            if (SV.dienSinhVien_150 == (int)dienSinhVien.hoNgheo)
            {
                Console.WriteLine(" Thuoc dien: Ho Ngheo");
            }
            else if (SV.dienSinhVien_150 == (int)dienSinhVien.hoCanNgheo)
            {
                Console.WriteLine(" Thuoc dien: Ho Can Ngheo");
            }
            else
            {
                Console.WriteLine(" Thuoc dien: Binh Thuong");
            }
        }

        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan_150 + SV.DiemLy_150 + SV.DiemVan_150) / 3;
        }

        static void Main(string[] args)
        {


            int n_150;
            do
            {
                Console.Write("Nhap SL sinh vien: ");
                n_150 = int.Parse(Console.ReadLine());
            } while (n_150 <= 0);
            SinhVien[] sv150 = new SinhVien[n_150];
            for (int i = 0; i < n_150; i++)
            {
                Console.Write("Nhap vao SV[{0}]: \n", i + 1);
                NhapThongTinSinhVien(out sv150[i]);
            }

            Console.WriteLine("DANH SACH DUYEN SINH VIEN: ");
            int d = 0;
            foreach (SinhVien sv in sv150)
            {
                Console.WriteLine("\nSinh vien thu {0}: \n", d + 1);
                XuatThongTinSinhVien(sv);
                d++;
            }


            string searchSV_150;
            Console.Write("\nNhap vao ten sv can tim kiem: ");
            searchSV_150 = Console.ReadLine();
            foreach (SinhVien sv in sv150)
            {
                if (sv.HoTen_150 == searchSV_150)
                {
                    Console.WriteLine("Diem TB cua sinh vien {0} la: {1} ", searchSV_150, DiemTBSinhVien(sv));
                }
            }
            Console.ReadKey();
        }
    }
}
