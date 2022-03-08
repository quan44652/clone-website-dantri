using System;
using System.Collections.Generic;
using System.Text;

namespace Dam
{
    class ThuCung : DongVat
    {
        private string maThuCung { set; get; }
        public ThuCung() { }
        public ThuCung(string _ten, int _canNang, int _gioiTinh, string _maThuCung) : base (_ten, _canNang, _gioiTinh)
        {
            maThuCung = _maThuCung;
        }
        public void tiengKeu(string _tiengKeu)
        {
            Console.WriteLine($"Tieng keu: {_tiengKeu}");
        }
    }
}
