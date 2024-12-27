using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class VwThongKeSinhVienTheoHocKy
{
    public string MaHocKy { get; set; } = null!;

    public string TenHocKy { get; set; } = null!;

    public int? SoLuongSinhVien { get; set; }
}
