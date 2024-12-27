using System.ComponentModel;

namespace QuanLiSinhVien.Models;

public class MonHoc
{
    [DisplayName("Mã môn học")]
    public string? maMonHoc { get; set; }
    [DisplayName("Tên")]
    public string? tenMonHoc { get; set; }
    [DisplayName("Số tín chỉ")]
    public int? tinChi { get; set; }
    [DisplayName("Khoa")]
    public string? khoa { get; set; }
    [DisplayName("Học kì")]
    public string? hocKi { get; set; }
}