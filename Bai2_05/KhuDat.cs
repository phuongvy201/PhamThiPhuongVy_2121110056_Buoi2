using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_05
{
    internal class KhuDat 
    {
        public string DiaDiem { get; set; }
        public double GiaBan { get; set; }
        public double DienTich { get; set; }

        public KhuDat(string diaDiem, double giaBan, double dienTich)
        {
            DiaDiem = diaDiem;
            GiaBan = giaBan;
            DienTich = dienTich;
        }
        public void NhapKhuDat()
        {
            Console.Write("Nhập Địa Điểm: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhập Giá Bán (VND): ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhập Diện Tích (m2): ");
            DienTich = double.Parse(Console.ReadLine());
        }

        public void XuatKhuDat()
        {
            Console.WriteLine("Địa Điểm: {0}", DiaDiem);
            Console.WriteLine("Giá Bán: {0}", GiaBan);
            Console.WriteLine("Diện Tích: {0} m2", DienTich);
        }
    }
}
