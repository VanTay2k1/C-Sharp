using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Enum_Truct
{
    class Program
    {
        struct SinhVien
        {
            public int msv;
            public string ten;
            public double DiemToan;
            public double DiemLy;
            public double DiemHoa;
            public double DiemTB;

        }
        public void NhapSinhVien()
        {
            
            SinhVien sv = new SinhVien();
            Console.Write("Nhap ma sinh vien: ");
            sv.msv = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap ten sinh vien: ");
            sv.ten = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap diem toan: ");
            sv.DiemToan = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem ly: ");
            sv.DiemLy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem hoa: ");
            sv.DiemHoa = Convert.ToDouble(Console.ReadLine());

            TinhDTB(sv);
        }
        private void TinhDTB(SinhVien sv)
        {
            double DiemTB = (sv.DiemToan + sv.DiemLy + sv.DiemHoa) / 3;
            sv.DiemTB = Math.Round(DiemTB, 2, MidpointRounding.AwayFromZero);
        }

        public void ShowSinhVien(List<SinhVien> listSV)
        {
            
            Console.WriteLine("{0, -5} {1, -20} {4, 5} {5, 5} {6, 5} {7, 10}",
                  "MSV", "Tên", "Toan", "Ly", "Hoa", "Diem TB");

            if (listSV != null && listSV.Count > 0)
            {
                foreach (SinhVien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {4, 5} {5, 5} {6, 5} {7, 10}",
                                      sv.msv, sv.ten, sv.DiemToan, sv.DiemLy, sv.DiemHoa,
                                      sv.DiemTB);
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
        }
    }
}
