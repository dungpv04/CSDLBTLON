using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class SinhVien
{
    public string MaSv { get; set; } = null!;

    public string TenSv { get; set; } = null!;

    public DateOnly? NgaySinh { get; set; }

    public string? DienThoai { get; set; }

    public string? Email { get; set; }

    public bool? GioiTinh { get; set; }

    public string? PhuHuynhSdt { get; set; }

    public string? MaLopQl { get; set; }

    public string? MaTk { get; set; }

    public string? MaKhoa { get; set; }

    public virtual ICollection<DangKyHocPhan> DangKyHocPhans { get; set; } = new List<DangKyHocPhan>();

    public virtual ICollection<Diem> Diems { get; set; } = new List<Diem>();

    public virtual Khoa? MaKhoaNavigation { get; set; }

    public virtual LopQuanLy? MaLopQlNavigation { get; set; }

    public virtual TaiKhoan? MaTkNavigation { get; set; }
}
