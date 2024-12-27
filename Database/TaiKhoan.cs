using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class TaiKhoan
{
    public string MaTk { get; set; } = null!;

    public string TenDangNhap { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string? MaVt { get; set; }

    public virtual ICollection<GiangVien> GiangViens { get; set; } = new List<GiangVien>();

    public virtual VaiTro? MaVtNavigation { get; set; }

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
