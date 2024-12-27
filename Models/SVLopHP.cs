using System.ComponentModel;

namespace QuanLiSinhVien.Models;

public class SVLopHP
{
    [DisplayName("Mã SV")]
    public string? maSV { get; set; }
    [DisplayName("Họ tên")]
    public string? tenSV { get; set; }
    [DisplayName("Lớp")]
    public string lopQL { get; set; }
    [DisplayName("Điểm quá trình")]
    public double? dqt { get; set; }
    [DisplayName("Điểm thi")]
    public double? diemThi { get; set; }
    [DisplayName("Điểm tổng kết")]
    public double? tongKet { get; set; }
}