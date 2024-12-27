using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class VwDiemTrungBinhTheoKhoa
{
    public string MaK { get; set; } = null!;

    public string TenK { get; set; } = null!;

    public string MaHk { get; set; } = null!;

    public string TenHk { get; set; } = null!;

    public int? SoLuongSv { get; set; }

    public double? DiemTrungBinh { get; set; }
}
