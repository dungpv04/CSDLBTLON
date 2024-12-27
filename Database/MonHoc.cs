using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class MonHoc
{
    public string MaMh { get; set; } = null!;

    public string TenMh { get; set; } = null!;

    public int? TinChi { get; set; }

    public string? MaK { get; set; }

    public int? HocKy { get; set; }

    public virtual ICollection<Diem> Diems { get; set; } = new List<Diem>();

    public virtual ICollection<HocPhi> HocPhis { get; set; } = new List<HocPhi>();

    public virtual ICollection<LopHocPhan> LopHocPhans { get; set; } = new List<LopHocPhan>();

    public virtual Khoa? MaKNavigation { get; set; }
}
