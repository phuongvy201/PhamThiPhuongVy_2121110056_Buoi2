using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_2
{
    internal class SinhVien
    {
        public string MaSV;
        public string HoTen;
        public double DiemTB;
        public string Khoa;
        public SinhVien() { }
        public SinhVien(string masv, string hoten, double diemtb, string khoa)
        {
            this.MaSV = masv;
            this.HoTen = hoten;
            this.DiemTB = diemtb;
            this.Khoa = khoa;
        }
        public void NhapSV()
        {
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap DiemTB: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV: {0} \t Hoten: {1} \t DiemTB: {2} \t Khoa: {3}", MaSV, HoTen, DiemTB, Khoa);
        }
    }
}
