using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Models
{
    public class Sinhvien
    {
        [DisplayName("Mã sinh viên")]
        public String? maSV { get; set; }

        [DisplayName("Họ tên")]
        public String? tenSv { get; set; }

        [DisplayName("Giới tính")]
        public String? gioiTinh { get; set; }

        [DisplayName("Ngày sinh")]
        public String? ngaySinh { get; set; }

        [DisplayName("Điện thoại")]
        public String? dienThoai { get; set; }

        [DisplayName("Email")]
        public String? email { get; set; }

        [DisplayName("Số điện thoại phụ huynh")]
        public String? sdtPhuHuynh { get; set; }

    }
}
