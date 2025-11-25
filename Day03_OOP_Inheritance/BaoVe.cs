using System;

namespace Day03_OOP_Inheritance
{
    public class BaoVe : NhanVien
    {
        public string KhuVucTruc { get; set; }

        public BaoVe(string ma, string ten, double luong, string khuvuc) : base(ma, ten, luong)
        {
            KhuVucTruc = khuvuc;
        }

        public void TrongXe()
        {
            Console.WriteLine($"{HoTen} đang trông xe tại khu vực {KhuVucTruc}. An ninh đảm bảo!");
        }
    }
}