using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_3
{
    internal class Teacher : Person
    {
        public string MaGV;
        public string Khoa;
        public string ChucVu;
        public Teacher() { }
        public Teacher(string maGV, string khoa, string chucVu)
        {
            this.MaGV = maGV;
            this.Khoa = khoa;
            this.ChucVu = chucVu;
        }
        public void NhapGV()
        {
            Console.Write("Nhap MaSV: ");
            MaGV = Console.ReadLine();
            Console.Write("Nhap CMND: ");
            CMND = Console.ReadLine();
            Console.Write("Nhap DiaChi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap ChucVu: ");
            ChucVu = Console.ReadLine();
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatGV()
        {
            Console.WriteLine("MaGV: {0} \t CMND: {1} \t DiaChi: {2} \t HoTen: {3} \t ChucVu: {4} \t Khoa: {5}", MaGV, CMND, DiaChi, HoTen, ChucVu, Khoa);
        }
    }
}
