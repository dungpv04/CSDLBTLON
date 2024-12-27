using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class LopHocPhan
{
    public string MaLopHp { get; set; } = null!;

    public string? MaLopQl { get; set; }

    public string MaMh { get; set; } = null!;

    public string? MaGv { get; set; }

    public string MaHk { get; set; } = null!;

    public string TenLop { get; set; } = null!;

    public string? MaKhoa { get; set; }

    public virtual ICollection<DangKyHocPhan> DangKyHocPhans { get; set; } = new List<DangKyHocPhan>();

    public virtual ICollection<Diem> Diems { get; set; } = new List<Diem>();

    public virtual GiangVien? MaGvNavigation { get; set; }

    public virtual HocKy MaHkNavigation { get; set; } = null!;

    public virtual Khoa? MaKhoaNavigation { get; set; }

    public virtual LopQuanLy? MaLopQlNavigation { get; set; }

    public virtual MonHoc MaMhNavigation { get; set; } = null!;
}
