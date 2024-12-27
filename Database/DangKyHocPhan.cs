using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class DangKyHocPhan
{
    public string MaSv { get; set; } = null!;

    public string MaLopHp { get; set; } = null!;

    public DateOnly? NgayDangKy { get; set; }

    public virtual LopHocPhan MaLopHpNavigation { get; set; } = null!;

    public virtual SinhVien MaSvNavigation { get; set; } = null!;
}
