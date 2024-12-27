using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Models
{
    public class LopHP
    {
        [DisplayName("Mã lớp")]
        public String? maLopHP { get; set; }
        [DisplayName("Tên lớp")]
        public String? tenLopHP { get; set; }
        [DisplayName("Môn học")]
        public String? monHoc { get; set; }
        [DisplayName("Học kì")]
        public String? hocKy { get; set; }
        [DisplayName("Khoa")]
        public String? khoa { get; set; }
        [DisplayName("Lớp quản lí")]
        public String? lopQL { get; set; }
    }
}
