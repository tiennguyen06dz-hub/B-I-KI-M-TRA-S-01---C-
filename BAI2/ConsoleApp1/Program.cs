using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        QuanLyPhuongTien ql = new QuanLyPhuongTien();

        Console.WriteLine("=== TC01: VALIDATION NAM SAN XUAT ===");

        try
        {
            OTo otoLoi = new OTo(
                "OT001",
                "Toyota",
                1850,
                1000000000m,
                5,
                2.0
            );
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("\n=== TC02: TINH GIA LAN BANH O TO ===");

        OTo oto = new OTo(
            "OT002",
            "Toyota",
            2024,
            1000000000m,
            5,
            2.0
        );

        Console.WriteLine($"Giá lăn bánh: {oto.TinhGiaLanBanh():N0} VNĐ");

        Console.WriteLine("\n=== TC03: TINH GIA LAN BANH XE MAY ===");

        XeMay xemay = new XeMay(
            "XM001",
            "Honda",
            2024,
            50000000m,
            150
        );

        Console.WriteLine($"Giá lăn bánh: {xemay.TinhGiaLanBanh():N0} VNĐ");

        Console.WriteLine("\n=== TC04: DA HINH LIST<PHUONGTIEN> ===");

        ql.AddPhuongTien(oto);
        ql.AddPhuongTien(xemay);

        List<PhuongTien> danhSach = new List<PhuongTien>();
        danhSach.Add(oto);
        danhSach.Add(xemay);

        foreach (PhuongTien pt in danhSach)
        {
            Console.WriteLine(pt.GetInfo());
            Console.WriteLine($"Giá lăn bánh: {pt.TinhGiaLanBanh():N0} VNĐ");
        }

        Console.WriteLine("\n=== TC05: TIM GIA LAN BANH MAX ===");

        PhuongTien max = ql.FindMaxGiaLanBanh();

        Console.WriteLine(max.GetInfo());
        Console.WriteLine($"Giá lăn bánh cao nhất: {max.TinhGiaLanBanh():N0} VNĐ");
    }
}