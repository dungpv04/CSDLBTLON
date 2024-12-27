using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class GiangVien
{
    public string MaGv { get; set; } = null!;

    public string TenGv { get; set; } = null!;

    public DateOnly? NgaySinh { get; set; }

    public string? DienThoai { get; set; }

    public string? Email { get; set; }

    public bool? GioiTinh { get; set; }

    public string? MaK { get; set; }

    public string? MaTk { get; set; }

    public virtual ICollection<LopHocPhan> LopHocPhans { get; set; } = new List<LopHocPhan>();

    public virtual ICollection<LopQuanLy> LopQuanLies { get; set; } = new List<LopQuanLy>();

    public virtual Khoa? MaKNavigation { get; set; }

    public virtual TaiKhoan? MaTkNavigation { get; set; }
}
