using QuanLiSinhVien.Forms;
using QuanLiSinhVien.Forms.GiangVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiSinhVien.Database;

namespace QuanLiSinhVien
{
    public partial class Form1 : Form
    {
        QuanLyHocSinhContext db;
        public Form1()
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTbox.Text;
            String password = passwordTbox.Text;
            try
            {
                TaiKhoan? taiKhoan = db.TaiKhoans.FirstOrDefault(x => x.TenDangNhap == username && x.MatKhau == password);
                var vaiTro = db.VaiTros.FirstOrDefault(x => x.MaVt == taiKhoan.MaVt);
                if(vaiTro.TenVt == "Giảng viên")
                {
                    GiangVien? giangVien = db.GiangViens.FirstOrDefault(x => x.MaTk == taiKhoan.MaTk);
                    GiangVienHome giangVienHome = new GiangVienHome(giangVien);
                    giangVienHome.Show();
                    //Hide();
                }

                else if(vaiTro.TenVt == "Sinh viên")
                {
                    SinhVien? sinhVien = db.SinhViens.FirstOrDefault(x => x.MaTk == taiKhoan.MaTk);
                    SinhVienHome sinhVienHome = new SinhVienHome(sinhVien);
                    sinhVienHome.Show();
                    //Hide();
                }

            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
