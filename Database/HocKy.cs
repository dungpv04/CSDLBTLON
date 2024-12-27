using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class HocKy
{
    public string MaHk { get; set; } = null!;

    public string TenHk { get; set; } = null!;

    public DateOnly NgayBatDau { get; set; }

    public DateOnly NgayKetThuc { get; set; }

    public virtual ICollection<LopHocPhan> LopHocPhans { get; set; } = new List<LopHocPhan>();
}
