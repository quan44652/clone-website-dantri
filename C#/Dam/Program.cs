using System;

namespace Dam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;
            QuanLyDongVat quanLyDongVat = new QuanLyDongVat();
            while (n != 0)
            {
                Console.WriteLine("======================================");
                Console.WriteLine("+  1. Nhap danh sach doi tuong.      +");
                Console.WriteLine("+  2. Xuat danh sach doi tuong       +");
                Console.WriteLine("+  3. Tim theo ten                   +");
                Console.WriteLine("+  4. Tim theo khoang can nang       +");
                Console.WriteLine("+  5. Ke Thua                        +");
                Console.WriteLine("+  0. Thoat                          +");
                Console.WriteLine("======================================");
                try
                {
                    Console.Write("Nhap lua chon cua ban: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch{}
                switch (n)
                {
                    case 0:
                        Console.WriteLine("Dan da thoat chuong trinh!");
                        break;
                    case 1:
                        quanLyDongVat.nhapDanhSachDoiTuong();
                        break;
                    case 2:
                        Console.WriteLine("Danh sach doi tuong: ");
                        quanLyDongVat.xuatDanhSachDoiTuong();
                        break;
                    case 3:
                        string ten;
                        Console.Write("Nhap ten can tim: ");
                        ten = Console.ReadLine();
                        quanLyDongVat.timTheoTen(ten);
                        break;
                    case 4:
                        int canNang;
                        Console.Write("Nhap can nang can tim: ");
                        canNang = Convert.ToInt32(Console.ReadLine());
                        quanLyDongVat.timTheoCanNang(canNang);
                        break;
                    case 5:
                        string tenThuCung, maThuCung;
                        int canNangThuCung, gioiTinhThuCung;
                        Console.Write("Ma thu cung: ");
                        maThuCung = Console.ReadLine();
                        Console.Write("Ten: ");
                        tenThuCung = Console.ReadLine();
                        Console.Write("Can nang: ");
                        canNangThuCung = Convert.ToInt32(Console.ReadLine());
                        Console.Write("GioiTinh (1 - Duc || 2 - Cai): ");
                        gioiTinhThuCung = Convert.ToInt32(Console.ReadLine());
                        ThuCung thuCung = new ThuCung(tenThuCung, canNangThuCung, gioiTinhThuCung, maThuCung);
                        thuCung.inThongTin();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                }
            }
            
        }
    }
}
