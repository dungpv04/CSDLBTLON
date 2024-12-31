using System.ComponentModel;

namespace QuanLiSinhVien.Models;

public class MonHocAdmin
{
    [DisplayName("Mã môn học")]
    public string maMH { get; set; }
    [DisplayName("Tên môn học")]
    public string tenMH { get; set; }
    [DisplayName("Số tín chỉ")]
    public int? soTC { get; set; }
    [DisplayName("Học kì")]
    public int? hocKy { get; set; }
    [DisplayName("Khoa")]
    public string khoa { get; set; }
}