using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<Student> listSinhVien = NhapDSSinhVien();
            Console.WriteLine("*** Xuat DS Sinh Vien");
            XuatDSSinhVien(listSinhVien);

            Console.WriteLine("*** Xuat DS Sinh Vien Khoa CNTT");
            DSSVCNTT(listSinhVien);
            Console.WriteLine("*** Xuat DS Sinh Vien Khoa CNTT có điểm trung bình nhỏ hơn 5");
            DSSVCNTTLONHON5(listSinhVien);
            Console.WriteLine("Xuất danh sách sinh viên có điểm trung bình cao nhất thuộc khoa CNTT");
            DSSVDIEMTBCAONHATCNTT(listSinhVien);

            List<Teacher> listGiaoVien = NhapDSGiaoVien();
            Console.WriteLine("*** Xuat DS Giao Vien");
            XuatDSGiaoVien(listGiaoVien);
            Console.WriteLine("*** Xuat DS Giao Vien có địa chỉ ở quận 9");
            DSGVQUAN9(listGiaoVien);

            Console.WriteLine("*** Xuat DS Giao Vien có mã CHN060286");
            GVTHEOMAGV(listGiaoVien);
            
            Console.ReadKey();
        }
        //Nhap DS Sinh Vien
        static List<Student> NhapDSSinhVien()
        {
            List<Student> listSinhVien = new List<Student>();
            Console.Write("Nhap tong so sinh vien N= ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ---Nhap danh sach sinh vien---");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhap sinh vien thu {i + 1}: ");
                Student sv = new Student();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            return listSinhVien;
        }
        //Nhap DS Giao Vien
        static List<Teacher> NhapDSGiaoVien()
        {
            List<Teacher> listGiaoVien = new List<Teacher>();
            Console.Write("Nhap tong so giao vien N= ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ---Nhap danh sach giao vien---");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhap giao vien thu {i + 1}: ");
                Teacher gv = new Teacher();
                gv.NhapGV();
                listGiaoVien.Add(gv);
            }
            return listGiaoVien;
        }
        private static void XuatDSSinhVien(List<Student> listSinhVien)
        {
            foreach (Student sv in listSinhVien)
            {
                sv.XuatSV();
            }
        }
        private static void XuatDSGiaoVien(List<Teacher> listGiaoVien)
        {
            foreach (Teacher sv in listGiaoVien)
            {
                sv.XuatGV();
            }
        }
        private static void DSSVCNTT(List<Student> listSinhVien)
        {
            List<Student> listSV = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            if (listSV.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien thuoc khoa CNTT");
            }
            else
            {
                XuatDSSinhVien(listSV);
            }
        }
        private static void DSSVCNTTLONHON5(List<Student> listSinhVien)
        {
            List<Student> listSV = listSinhVien.Where(p => p.Khoa == "CNTT" && p.DiemTB < 5).ToList();
            if (listSV.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien thuoc khoa CNTT co DTB >=5");
            }
            else
            {
                XuatDSSinhVien(listSV);
            }
        }
        private static void DSGVQUAN9(List<Teacher> listGiaoVien)
        {
            List<Teacher> listGV = listGiaoVien.Where(p => p.DiaChi == "Quận 9").ToList();
            if (listGV.Count == 0)
            {
                Console.WriteLine("Khong co giao vien ở quận 9");
            }
            else
            {
                XuatDSGiaoVien(listGV);
            }
        }
        private static void GVTHEOMAGV(List<Teacher> listGiaoVien)
        {
            List<Teacher> GVMa = listGiaoVien.Where(p => p.MaGV == "CHN060286").ToList();
            if (GVMa.Count != 0)
            {
                var GiangVienCoMa = GVMa.Where(sv => sv.MaGV == "CHN060286").ToList();
                XuatDSGiaoVien(GiangVienCoMa);
            }
            else
            {
                Console.WriteLine("Khong co giang vien co ma trung khop");
            }
        }
        private static void DSSVDIEMTBCAONHATCNTT(List<Student> listSinhVien)
        {
            List<Student> SvCNTT = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
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
    }
}
