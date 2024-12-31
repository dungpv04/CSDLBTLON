using System.ComponentModel;

namespace QuanLiSinhVien.Models;

public class GiangVienAdmin
{
    [DisplayName("Mã giảng viên")]
    public string maGv { get; set; }
    [DisplayName("Tên")]
    public string tenGv { get; set; }
    [DisplayName("Ngày sinh")]
    public string ngaySinh { get; set; }
    [DisplayName("Điện thoại")]
    public string dienThoai { get; set; }
    [DisplayName("Email")]
    public string email { get; set; }
    [DisplayName("Giới tính")]
    public string gioiTinh { get; set; }
    [DisplayName("Khoa")]
    public string khoa { get; set; }
}