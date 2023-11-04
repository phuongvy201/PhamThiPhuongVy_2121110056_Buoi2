using Bai2_05;
using System;

internal class NhaPho : KhuDat
{
    public int NamXayDung { get; set; }
    public int SoTang { get; set; }


    public NhaPho(string diaDiem, double giaBan, double dienTich, int namXayDung, int soTang)
        : base(diaDiem, giaBan, dienTich)
    {
        NamXayDung = namXayDung;
        SoTang = soTang;
    }

    public void NhapNhaPho()
    {
        NhapKhuDat(); // Gọi phương thức nhập từ lớp cha (KhuDat)
        Console.Write("Nhập Năm Xây Dựng: ");
        NamXayDung = int.Parse(Console.ReadLine());
        Console.Write("Nhập Số Tầng: ");
        SoTang = int.Parse(Console.ReadLine());
    }

    public void XuatNhaPho()
    {
        XuatKhuDat(); // Gọi phương thức xuất từ lớp cha (KhuDat)
        Console.WriteLine("Năm Xây Dựng: {0}", NamXayDung);
        Console.WriteLine("Số Tầng: {0}", SoTang);
    }
}
