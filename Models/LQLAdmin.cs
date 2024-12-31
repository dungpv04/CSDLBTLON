using System.ComponentModel;

namespace QuanLiSinhVien.Models;

public class LQLAdmin
{
    [DisplayName("Mã lớp")]
    public string maLQL { get; set; }
    [DisplayName("Tên lớp")]
    public string tenLQL { get; set; }
    [DisplayName("GVCN")]
    public string gv { get; set; }
    [DisplayName("Khoa")]
    public string khoa { get; set; }
}