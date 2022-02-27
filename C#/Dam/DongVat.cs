using System;
using System.Collections.Generic;
using System.Text;

namespace Dam
{
    class DongVat
    {
        private string ten { get; set; }
        private int canNang { get; set; }
        private int gioiTinh { get; set; }

        public DongVat() { }
        public DongVat(string _ten, int _canNang, int _gioiTinh)
        {
            ten = _ten;
            canNang = _canNang;
            gioiTinh = _gioiTinh;
        }

        public void inThongTin()
        {
            Console.WriteLine($"Ten: {ten}\nCan nang: {canNang}\nGioi tinh: {gioiTinh}");
        }

        public void tiengKeu()
        {
            Console.WriteLine($"Tieng keu");
        }

        public string getTen()
        {
            return ten;
        }

        public int getCanNang()
        {
            return canNang;
        }
    }
}
