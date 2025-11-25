using System;

namespace Day03_OOP_Inheritance
{
    // Kế thừa class NhanVien (vì cùng namespace nên nó tự hiểu, không cần using gì thêm)
    public class QuanLy : NhanVien
    {
        public double ThuongTrachNhiem { get; set; }

        public QuanLy(string ma, string ten, double luong, double thuong) 
            : base(ma, ten, luong) 
        {
            ThuongTrachNhiem = thuong;
        }

        public void HopGiaoBan()
        {
            Console.WriteLine($"Sếp {HoTen} đang chủ trì cuộc họp.");
        }
        
        public double TinhTongThuNhap()
        {
            return GetLuong() + ThuongTrachNhiem;
        }
    }
}