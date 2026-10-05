using System.Text.Json;

NhanVien nv = new NhanVien();
Console.WriteLine($"Nhân viên: {JsonSerializer.Serialize(nv)}");

SanPham sp = new SanPham();
Console.WriteLine($"Sản phẩm: {JsonSerializer.Serialize(sp)}");

Console.WriteLine("Dev B ok");