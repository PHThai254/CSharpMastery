using System;
using System.Collections.Generic;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// 1. KHAI BÁO BIẾN & LIST
string tenQuan = "Thái Coffee";
double quyCuaKhach = 100000; // Cho khách nhiều tiền hơn chút để mua được nhiều món :D

// [YÊU CẦU 2]: Biến VIP
bool isVip = true; // Giả sử khách này là VIP

// [YÊU CẦU 1]: Thêm 2 món mới vào List
List<string> menuTen = new List<string>() { "Cà phê đen", "Bạc xỉu", "Trà đào", "Sinh tố bơ", "Nước cam" };
List<double> menuGia = new List<double>() { 20000, 25000, 35000, 45000, 30000 };

Console.WriteLine($"Chào mừng đến với {tenQuan}!");
if (isVip) Console.WriteLine("(Bạn là khách VIP: Được giảm giá 10%)");

// [YÊU CẦU 3]: Vòng lặp while để mua liên tục
while (true)
{
    Console.WriteLine("------------------------------");
    Console.WriteLine($"Số dư hiện tại: {quyCuaKhach} VNĐ");
    Console.WriteLine("DANH SÁCH ĐỒ UỐNG (Chọn 0 để Thoát):");

    // In menu
    for (int i = 0; i < menuTen.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {menuTen[i]} - {menuGia[i]} VNĐ");
    }

    // Nhập lựa chọn
    Console.Write("\nChọn món (nhập số): ");
    string input = Console.ReadLine() ?? "";

    // Kiểm tra nếu khách muốn thoát
    if (input == "0")
    {
        Console.WriteLine("Cảm ơn bạn đã ghé thăm. Hẹn gặp lại!");
        break; // Lệnh này phá vỡ vòng lặp while, thoát chương trình
    }

    // Xử lý mua hàng
    try
    {
        int luaChon = int.Parse(input) - 1;

        if (luaChon >= 0 && luaChon < menuTen.Count)
        {
            string tenMon = menuTen[luaChon];
            double giaGoc = menuGia[luaChon];
            double giaPhaiTra = giaGoc;

            // [YÊU CẦU 2]: Tính toán giảm giá VIP
            if (isVip == true)
            {
                giaPhaiTra = giaGoc * 0.9; // Nhân 0.9 tương đương giảm 10%
            }

            Console.WriteLine($"-> Bạn chọn: {tenMon}");
            if (isVip) Console.WriteLine($"-> Giá gốc: {giaGoc}, Giá VIP: {giaPhaiTra}");

            // Kiểm tra tiền
            if (quyCuaKhach >= giaPhaiTra)
            {
                quyCuaKhach -= giaPhaiTra;
                Console.WriteLine($"=> Mua thành công! Chúc ngon miệng.");
            }
            else
            {
                Console.WriteLine("=> Rất tiếc, bạn không đủ tiền!");
            }
        }
        else
        {
            Console.WriteLine("=> Lựa chọn không tồn tại!");
        }
    }
    catch
    {
        // Bắt lỗi nếu người dùng nhập chữ cái thay vì số
        Console.WriteLine("=> Vui lòng chỉ nhập con số!");
    }

    // Kiểm tra xem còn tiền để mua tiếp không (Optional)
    if (quyCuaKhach <= 0)
    {
        Console.WriteLine("\nBạn đã hết sạch tiền. Tạm biệt!");
        break;
    }

} // Kết thúc vòng while

Console.ReadKey();
