using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_2
{
    internal class Program
    {
        private static List<SinhVien> NhapDSSinhVien()
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            Console.Write("Nhap tong so sinh vien N= ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ---Nhap danh sach sinh vien---");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhap sinh vien thu {i + 1}: ");
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            return listSinhVien;
        }

        private static void XuatDSSinhVien(List<SinhVien> listSinhVien)
        {
            foreach (SinhVien sv in listSinhVien)
            {
                sv.XuatSV();
            }
        }

        private static void DSSVCNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT1 = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT1.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien khoa CNTT");
            }
            else
            {
                XuatDSSinhVien(listCNTT1);
            }
        }

        private static void DSSVLONHON5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5).ToList();
            if (listSV.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien co diem >= 5");
            }
            else
            {
                XuatDSSinhVien(listSV);
            }
        }

        private static void DSSVSapXep(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.OrderBy(p => p.DiemTB).ToList();
            XuatDSSinhVien(listSV);
        }

        private static void DSSVLONHON5CNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5 && p.Khoa == "CNTT").ToList();
            if (listSV.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien co diem >= 5 thuoc khoa CNTT");
            }
            else
            {
                XuatDSSinhVien(listSV);
            }
        }

        private static void DSSVDIEMTBCAONHATCNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> SvCNTT = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            if (SvCNTT.Count != 0)
            {
                double DiemCaoNhat = SvCNTT.Max(p => p.DiemTB);
                var sinhVienDiemCaoNhat = SvCNTT.Where(sv => sv.DiemTB == DiemCaoNhat).ToList();
                XuatDSSinhVien(sinhVienDiemCaoNhat);
            }
            else
            {
                Console.WriteLine("Khong co sinh vien co diem cao nhat thuoc khoa CNTT");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<SinhVien> listSinhVien = NhapDSSinhVien();
            Console.WriteLine("Xuất danh sách sinh viên");
            XuatDSSinhVien(listSinhVien);
            Console.WriteLine("Xuất danh sách sinh viên khoa công nghệ thông tin");
            DSSVCNTT(listSinhVien);
            Console.WriteLine("Xuất danh sách sinh viên có điểm trung bình lớn hơn 5");
            DSSVLONHON5(listSinhVien);
            Console.WriteLine("Danh sách sinh viên sau khi đã sắp xếp");
            DSSVSapXep(listSinhVien);
            Console.WriteLine("Xuất danh sách sinh viên có điểm trung bình lớn hơn 5 thuộc khoa CNTT");
            DSSVLONHON5CNTT(listSinhVien);
            Console.WriteLine("Xuất danh sách sinh viên có điểm trung bình cao nhất thuộc khoa CNTT");
            DSSVDIEMTBCAONHATCNTT(listSinhVien);

            Console.ReadKey();
        }
    }
    
}
