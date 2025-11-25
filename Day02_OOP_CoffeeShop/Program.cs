using System;
using System.Collections.Generic;
using System.Text;

namespace Day02_OOP_CoffeeShop
{
    // --- ĐÂY LÀ BẢN VẼ (CLASS) ---
    class MonAn
    {
        // 1. Thuộc tính (Properties) - Đặc điểm của món ăn
        public string TenMon {get; set;}
        public double GiaTien {get; set;}

        public string MoTa {get; set;}

        // 2. Constructor (Hàm khởi tạo) - Cách tạo ra món ăn nhanh
        public MonAn(string ten, double gia, string moTa)
        {
            TenMon = ten;
            GiaTien = gia;
            MoTa = moTa;
        }

        // 3. Phương thức (Method) - Hành động của món ăn
        public void InThongTin()
        {
            // In ra đẹp mắt: "Cà phê đen ....... 20000 VND"
            Console.WriteLine($"{TenMon,-20} : {MoTa} - {GiaTien:N0} VND");
        }

        public double TinhGiaKhuyenMai(int phanTramGiam)
        {
            return GiaTien * (100 - phanTramGiam) / 100;
        }
    }

    // --- ĐÂY LÀ CHƯƠNG TRÌNH CHÍNH ---
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 1. Tạo Menu bằng Danh sách các Đối tượng (List of Objects)
            // Thay vì 2 List rời rạc, giờ ta chỉ cần 1 List chứa các "MonAn"
            List<MonAn> menu = new List<MonAn>();

            // 2. Thêm dữ liệu (Instantiate - Khởi tạo đối tượng)
            menu.Add(new MonAn("1.Cà phê đen", 20000, "Cà phê đen nguyên chất, đậm đà"));
            menu.Add(new MonAn("2.Bạc xỉu", 25000, "Cà phê sữa đá ngọt ngào"));
            menu.Add(new MonAn("3.Trà đào cam sả", 35000, "Trà đào tươi mát, hương cam sả thơm phức"));

            

            // 3. Hiển thị Menu (Dùng vòng lặp foreach cực gọn)
            Console.WriteLine("----- MENU QUÁN THÁI (OOP VERSION)-----");

            foreach (MonAn mon in menu)
            {
                mon.InThongTin(); // Gọi phương thức của chính đối tượng đó

            }

            // 4. Xử lý chọn món (Tương tác với Object)
            while (true)
            {
                Console.Write("\nChọn số thứ tự món: ");
                try
                {
                    int index = int.Parse(Console.ReadLine() ?? "") - 1;

                    if (index >= 0 && index < menu.Count)
                    {
                        // Lấy ra Đối tượng món ăn mà khách chọn
                        MonAn monDaChon = menu[index];

                        Console.WriteLine($"\n=> Bạn đã chọn: {monDaChon.TenMon}");
                        Console.WriteLine($"=> Mô tả: {monDaChon.MoTa}");
                        Console.WriteLine($"=> Giá gốc: {monDaChon.GiaTien:N0} VND");
                        Console.WriteLine($"=> Khuyến mãi 10% - Vui lòng thanh toán: {monDaChon.TinhGiaKhuyenMai(10)} VND");
                    }
                    else
                    {
                        Console.WriteLine("Món không tồn tại!");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Lỗi nhập liệu!");
                    break;
                }

                Console.ReadKey();
            }
        }
    }
}