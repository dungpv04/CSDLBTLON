using System;
using System.Collections.Generic;

namespace QuanLiSinhVien.Database;

public partial class Khoa
{
    public string MaK { get; set; } = null!;

    public string TenK { get; set; } = null!;

    public virtual ICollection<GiangVien> GiangViens { get; set; } = new List<GiangVien>();

    public virtual ICollection<LopHocPhan> LopHocPhans { get; set; } = new List<LopHocPhan>();

    public virtual ICollection<LopQuanLy> LopQuanLies { get; set; } = new List<LopQuanLy>();

    public virtual ICollection<MonHoc> MonHocs { get; set; } = new List<MonHoc>();

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
