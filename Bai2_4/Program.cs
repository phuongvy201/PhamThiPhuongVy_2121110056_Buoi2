using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            List<KhuDat> danhSachKhuDat = NhapDSKhuDat();

            Console.WriteLine("Xuất danh sách khu đất:");
            XuatDSKhuDat(danhSachKhuDat);

            double donGiaTrungBinh = TinhDonGiaTrungBinhDienTichLonHon1000m2(danhSachKhuDat);
            Console.WriteLine("Đơn giá trung bình 1m2 cho khu đất có diện tích > 1000m2: {0}", donGiaTrungBinh);



            XuatKhuDatGiaDuoi1TyDienTichLonHon60m2(danhSachKhuDat);

            XuatKhuDatTheoDienTichTangDan(danhSachKhuDat);
            Console.ReadKey();
        }
        static List<KhuDat> NhapDSKhuDat()
        {
            List<KhuDat> listKhuDat = new List<KhuDat>();
            Console.Write("Nhap tong so khu dat N= ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ---Nhap danh sach khu dat---");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhap khu dat thu {i + 1}: ");
                KhuDat khuDat = new KhuDat();
                khuDat.NhapKhuDat();
                listKhuDat.Add(khuDat);
            }
            return listKhuDat;
        }

        static void XuatDSKhuDat(List<KhuDat> listKhuDat)
        {
            Console.WriteLine("\nDanh sach khu dat:");
            foreach (var khuDat in listKhuDat)
            {
                khuDat.XuatKhuDat();
            }
        }
        static double TinhDonGiaTrungBinhDienTichLonHon1000m2(List<KhuDat> danhSachKhuDat)
        {
            var khuDatLonHon1000m2 = danhSachKhuDat.Where(k => k.DienTich > 1000).ToList();
            if (khuDatLonHon1000m2.Count > 0)
            {
                double tongGia = khuDatLonHon1000m2.Sum(k => k.GiaBan);
                double tongDienTich = khuDatLonHon1000m2.Sum(k => k.DienTich);
                return tongGia / tongDienTich;
            }
            return 0;
        }


        static void XuatKhuDatGiaDuoi1TyDienTichLonHon60m2(List<KhuDat> danhSachKhuDat)
        {
            var khuDatLoc = danhSachKhuDat.Where(k => k.GiaBan < 1000000000 && k.DienTich >= 60).ToList();
            Console.WriteLine("\nDanh sách khu đất có giá bán dưới 1 tỷ và diện tích >= 60m2:");
            foreach (var khuDat in khuDatLoc)
            {
                khuDat.XuatKhuDat();
            }
        }


        static void XuatKhuDatTheoDienTichTangDan(List<KhuDat> danhSachKhuDat)
        {
            var khuDatSapXep = danhSachKhuDat.OrderBy(k => k.DienTich).ToList();
            Console.WriteLine("\nDanh sách khu đất theo diện tích tăng dần:");
            foreach (var khuDat in khuDatSapXep)
            {
                khuDat.XuatKhuDat();
            }
        }

    }
}
