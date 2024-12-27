using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class VwTyLeDauRotTheoMonHoc
{
    public string MaMh { get; set; } = null!;

    public string TenMh { get; set; } = null!;

    public string MaHk { get; set; } = null!;

    public string TenHk { get; set; } = null!;

    public int? TongSoSv { get; set; }

    public int? SoSvdau { get; set; }

    public int? SoSvrot { get; set; }

    public double? TyLeDau { get; set; }
}
