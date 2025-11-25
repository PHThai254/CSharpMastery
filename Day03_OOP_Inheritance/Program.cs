using System;
using System.Text;

namespace Day03_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("--- QUẢN LÝ NHÂN SỰ (SPLIT FILES) ---");

            // 1. Khởi tạo các nhân viên cụ thể
            QuanLy sepTung = new QuanLy("QL01", "Nguyễn Thanh Tùng", 20000000, 5000000);
            PhaChe banMai = new PhaChe("PC01", "Trần Thị Mai", 8000000, "Sáng");
            // Tạo thêm bác bảo vệ
            BaoVe bacBa = new BaoVe("BV01", "Nguyễn Văn Ba", 6000000, "Cổng chính");
            
            // 2. TẠO DANH SÁCH TỔNG HỢP (List<NhanVien>)
            // Điều kỳ diệu: List này khai báo là chứa 'NhanVien', 
            // nhưng nó chứa được cả QuanLy, PhaChe, BaoVe vì họ ĐỀU LÀ NHÂN VIÊN.
            List<NhanVien> dsNhanVien = new List<NhanVien>();

            dsNhanVien.Add(sepTung);
            dsNhanVien.Add(banMai);
            dsNhanVien.Add(bacBa);

            // Hoặc bạn có thể add trực tiếp: 
            // dsNhanVien.Add(new BaoVe("BV02", "Chú Tư", 6000000, "Nhà xe"));

            // 3. DUYỆT DANH SÁCH (Foreach)
            Console.WriteLine("\n--- DANH SÁCH NHÂN SỰ TOÀN CÔNG TY ---");
            Console.WriteLine($"{"Mã NV", -10} | {"Họ Tên", -20} | {"Lương CB", -15}");
            Console.WriteLine(new string('-', 50));

            foreach (NhanVien nv in dsNhanVien)
            {
                // Ở đây biến 'nv' đại diện cho NhanVien nói chung.
                // Ta chỉ truy cập được các thuộc tính CỦA CHA (MaNV, HoTen, GetLuong).
                // Ta KHÔNG THỂ gọi nv.PhaDoUong() hay nv.TrongXe() ở đây (vì máy tính chỉ biết đây là NhanVien).
                Console.WriteLine($"{nv.MaNV, -10} | {nv.HoTen, -20} | {nv.GetLuong():N0} VNĐ");
            }
            Console.ReadLine();
        }
    }
}
