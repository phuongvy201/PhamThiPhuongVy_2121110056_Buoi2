using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_4
{
    internal class KhuDat
    {
        public string DiaDiem { get; set; }
        public double GiaBan { get; set; }
        public double DienTich { get; set; }
        public void NhapKhuDat()
        {
            Console.Write("Nhap Dia Diem: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhap Gia Ban (VND): ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap Dien Tich (m2): ");
            DienTich = double.Parse(Console.ReadLine());
        }

        public void XuatKhuDat()
        {
            Console.WriteLine($"Địa Điểm: {DiaDiem}, Giá Bán: {GiaBan:C}, Diện Tích: {DienTich}m2");
        }
    }
}
