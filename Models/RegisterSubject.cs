using System.ComponentModel;

namespace QuanLiSinhVien.Models;

public class RegisterSubject
{
    [DisplayName("Mã lớp")]
    public string? maLHP { get; set; }
    [DisplayName("Tên lớp")]
    public string? tenLHP { get; set; }
    [Browsable(false)]
    [DisplayName("Mã môn học")]
    public string? maMonHoc { get; set; }
    [DisplayName("Tên môn học")]
    public string? tenMonHoc { get; set; }
    [Browsable(false)]
    public string? maK{ get; set; }
    [Browsable(false)]
    public string? maSv { get; set; }
}