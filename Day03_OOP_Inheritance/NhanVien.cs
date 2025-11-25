using System;

namespace Day03_OOP_Inheritance
{
    // --- CLASS CHA (BASE CLASS) ---
    public class NhanVien
    {
        // 1. ĐÓNG GÓI (Encapsulation)
        // Dữ liệu nhạy cảm (Lương) để private -> Không ai được sửa bậy bên ngoài
        private double _luongCoBan;

        // Các thông tin chung (public)
        public string MaNV {get; set; }
        public string HoTen {get; set; }

        public NhanVien(string ma, string ten, double luong)
        {
            MaNV = ma;
            HoTen = ten;
            // Kiểm tra logic ngay khi tạo
            if (luong < 0)
            {
                _luongCoBan = 0;
                Console.WriteLine("Lương không thể âm! Đã gán về 0.");
            }
            else
            {
                _luongCoBan = luong;
            }
        }

        // Phương thức Getter để lớp con lấy được lương (vì _luongCoBan là private)
        // Hoặc có thể dùng 'protected' cho biến _luongCoBan
        public double GetLuong()
        {
            return _luongCoBan;
        }

        // Phương thức chung cho mọi nhân viên
        public virtual void ChamCong() // 'virtual' cho phép lớp con ghi đè (sẽ học kỹ ở bài đa hình) 
        {
            Console.WriteLine($"{HoTen} đang chấm công vân tây.");
        } 
    }
}