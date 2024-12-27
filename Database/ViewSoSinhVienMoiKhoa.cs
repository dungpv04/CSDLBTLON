using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class ViewSoSinhVienMoiKhoa
{
    public string MaKhoa { get; set; } = null!;

    public string TenKhoa { get; set; } = null!;

    public int? SoLuongSinhVien { get; set; }
}
