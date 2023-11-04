using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_1
{
    internal class Program
    {
static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhap tong so sinh vien N= ");
            int N = Convert.ToInt32(Console.ReadLine());
            SinhVien[] arrSinhVien = new SinhVien[N];
            Console.WriteLine("\n ===Nhap danh sach sinh vien===");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}: ", i + 1);
                arrSinhVien[i] = new SinhVien();
                arrSinhVien[i].NhapSV();
            }
            Console.WriteLine("\n ===Xuat danh sach sinh vien===");
            foreach(SinhVien sv in arrSinhVien)
            {
                sv.XuatSV();
            }
            Console.ReadKey();
        }
    }
}
