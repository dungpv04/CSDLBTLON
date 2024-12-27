using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class Diem
{
    public string MaSv { get; set; } = null!;

    public string? MaLopHp { get; set; }

    public string MaMh { get; set; } = null!;

    public int LanThi { get; set; }

    public double? DiemQt { get; set; }

    public double? DiemThi { get; set; }

    public double? TongKet { get; set; }

    public virtual LopHocPhan? MaLopHpNavigation { get; set; }

    public virtual MonHoc MaMhNavigation { get; set; } = null!;

    public virtual SinhVien MaSvNavigation { get; set; } = null!;
}
