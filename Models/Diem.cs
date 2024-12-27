using System.ComponentModel;

namespace QuanLiSinhVien.Models;

public class Diem
{
    [DisplayName("Môn học")]
    public string? monHoc { get; set; }
    [DisplayName("Lần thi")]
    public int? lanThi { get; set; }
    [DisplayName("Điểm quá trình")]
    public double? dqt { get; set; }
    [DisplayName("Điểm thi")]
    public double? diemThi { get; set; }
    [DisplayName("Điểm tổng kết")]
    public double? tongKet { get; set; }
}