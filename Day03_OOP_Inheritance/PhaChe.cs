using System;

namespace Day03_OOP_Inheritance
{
    public class PhaChe : NhanVien
    {
        public string CaLamViec { get; set; }

        public PhaChe(string ma, string ten, double luong, string ca) 
            : base(ma, ten, luong)
        {
            CaLamViec = ca;
        }

        public void PhaDoUong()
        {
            Console.WriteLine($"{HoTen} đang pha cà phê ở ca {CaLamViec}.");
        }
    }
}