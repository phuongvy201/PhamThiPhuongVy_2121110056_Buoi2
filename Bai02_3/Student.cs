using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_3
{
    internal class Student : Person
    {
        public string MaSV;
        public double DiemTB;
        public string Khoa;
        public Student() { }
        public Student(string maSV, double diemTB, string khoa)
        {
            MaSV = maSV;
            DiemTB = diemTB;
            Khoa = khoa;
        }
        public void NhapSV()
        {
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap CMND: ");
            CMND = Console.ReadLine();
            Console.Write("Nhap DiaChi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap DiemTB: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV: {0} \t Hoten: {1} \t DiemTB: {2} \t Khoa: {3} \t CMND: {4} \t DiaChi: {5}", MaSV, HoTen, DiemTB, Khoa, CMND, DiaChi);
        }
    }
}
