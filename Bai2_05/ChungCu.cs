using Bai2_05;
using System;

internal class ChungCu : KhuDat
{
    public int Tang { get; set; }

    public ChungCu(string diaDiem, double giaBan, double dienTich, int tang)
        : base(diaDiem, giaBan, dienTich)
    {
        Tang = tang;
    }

    public void NhapChungCu()
    {
        NhapKhuDat(); 
        Console.Write("Nhập Tầng: ");
        Tang = int.Parse(Console.ReadLine());
    }

    public void XuatChungCu()
    {
        XuatKhuDat();
        Console.WriteLine("Tầng: {0}", Tang);
    }
}
