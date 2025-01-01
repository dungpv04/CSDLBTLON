using System.ComponentModel;

namespace QuanLiSinhVien.Models;

public class LHPAdmin
{
    [DisplayName("Mã lớp")]
    public string maLop { get; set; }
    [DisplayName("Tên lớp")]
    public string tenLop { get; set; }
    [DisplayName("Môn học")]
    public string monHoc {get; set;}
    [DisplayName("Giảng viên")]
    public string gv { get; set; }
    [DisplayName("Khoa")]
    public string khoa { get; set; }
    [DisplayName("Lớp quản lí")]
    public string lopQL { get; set; }
    [DisplayName("Học kì")]
    public string hocKy { get; set; }
}