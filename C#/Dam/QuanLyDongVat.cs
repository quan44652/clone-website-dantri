using System;
using System.Collections.Generic;
using System.Text;

namespace Dam
{
    class QuanLyDongVat
    {
        List<DongVat> danhSachDoiTuong = new List<DongVat>();
        public List<DongVat> nhapDanhSachDoiTuong()
        {
            bool isContinue = true;
            string ten;
            int canNang, gioiTinh;
            while (isContinue)
            {
                Console.Write("Ten: ");
                ten = Console.ReadLine();
                Console.Write("Can nang: ");
                canNang = Convert.ToInt32(Console.ReadLine());
                Console.Write("GioiTing (1 - Duc || 2 - Cai): ");
                gioiTinh = Convert.ToInt32(Console.ReadLine());
                DongVat dongVat = new DongVat(ten, canNang, gioiTinh);
                dongVat.inThongTin();
                danhSachDoiTuong.Add(dongVat);
                Console.Write("Ban co muon nhap tiep khong (0 - Khong || 1 - Co)? ");
                isContinue = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            }
            return danhSachDoiTuong;
        }

        public void xuatDanhSachDoiTuong()
        {
            inDanhSachDoiTuong(danhSachDoiTuong);
        }

        public void timTheoTen(string _ten)
        {
            var doiTuong = danhSachDoiTuong.FindAll(item => item.getTen().Contains(_ten));
            if (doiTuong.Count == 0)
            {
                Console.WriteLine("Khong tim thay doi tuong");
            }else
            {
                Console.WriteLine("Doi tuong can tim:");
                inDanhSachDoiTuong(doiTuong);
            }
        }

        public void timTheoCanNang(int _canNang)
        {
            var doiTuong = danhSachDoiTuong.FindAll(item => item.getCanNang() == _canNang);
            if (doiTuong.Count == 0)
            {
                Console.WriteLine("Khong tim thay doi tuong");
            }
            else
            {
                Console.WriteLine("Doi t1uong can tim:");
                inDanhSachDoiTuong(doiTuong);
            }
        }

        public void inDanhSachDoiTuong(List<DongVat> _danhSachDoiTuong)
        {
            for (int i = 0; i < _danhSachDoiTuong.Count; i++)
            {
                Console.WriteLine($"-----Doi tuong {i++}-----");
                _danhSachDoiTuong[i].inThongTin();
            }
        }
    }
}
