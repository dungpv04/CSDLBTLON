using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class LopQuanLy
{
    public string MaLopQl { get; set; } = null!;

    public string TenLop { get; set; } = null!;

    public string? MaGv { get; set; }

    public string? MaKhoa { get; set; }

    public virtual ICollection<LopHocPhan> LopHocPhans { get; set; } = new List<LopHocPhan>();

    public virtual GiangVien? MaGvNavigation { get; set; }

    public virtual Khoa? MaKhoaNavigation { get; set; }

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
