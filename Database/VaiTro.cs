using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class VaiTro
{
    public string MaVt { get; set; } = null!;

    public string TenVt { get; set; } = null!;

    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
}
