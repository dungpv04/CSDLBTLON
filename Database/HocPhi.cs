using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class HocPhi
{
    public string MaHp { get; set; } = null!;

    public string? MaMh { get; set; }

    public decimal GiaTien { get; set; }

    public virtual MonHoc? MaMhNavigation { get; set; }
}
