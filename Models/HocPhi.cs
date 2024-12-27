using System.ComponentModel;

namespace QuanLiSinhVien.Models;

public class HocPhi
{
    [DisplayName("Mã môn học")]
    public string? maMH { get; set; }
    [DisplayName("Tên môn học")]
    public string? tenMH { get; set; }
    [DisplayName("Số tín chỉ")]
    public int? soTinChi { get; set; }
    [DisplayName("Học phí")]
    public decimal? hocPhi { get; set; }
}