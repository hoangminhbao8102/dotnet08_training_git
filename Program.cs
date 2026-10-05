using System.Text.Json;

NhanVien nv = new NhanVien();
Console.WriteLine($"Nhân viên: {JsonSerializer.Serialize(nv)}");