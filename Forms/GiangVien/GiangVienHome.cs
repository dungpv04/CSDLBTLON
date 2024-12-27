using QuanLiSinhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using QuanLiSinhVien.Database;
using Microsoft.EntityFrameworkCore;

namespace QuanLiSinhVien.Forms.GiangVien
{
    public partial class GiangVienHome : Form
    {
        private readonly QuanLyHocSinhContext db;
        Database.GiangVien giangVien;
        public GiangVienHome(Database.GiangVien giangVien)
        {
            InitializeComponent();
            this.giangVien = giangVien;
            db = new QuanLyHocSinhContext();
        }

        private void userInforBtn_Click(object sender, EventArgs e)
        {
            string tenGV = giangVien.TenGv; // Tên giảng viên
            DateOnly? ngaySinh = giangVien.NgaySinh; // Ngày sinh
            string? dienThoai = giangVien.DienThoai; // Điện thoại
            string? email = giangVien.Email; // Email
            bool? gioiTinh = giangVien.GioiTinh; // 1: Nam, 0: Nữ

            string khoa = ""; // Mã khoa
            try
            {
                khoa = db.Khoas.FirstOrDefault(x => x.MaK == giangVien.MaK).TenK;
            }
            catch (InvalidOperationException)
            {
                khoa = "Không xác định";
            }
            string gioiTinhText = "";
            if (gioiTinh == true)
            {
                gioiTinhText = "Nam";
            }
            else
            {
                gioiTinhText = "Nữ";
            }

            string message = $"Thông tin giảng viên:\n" +
                 $"- Tên GV: {tenGV}\n" +
                 $"- Ngày sinh: {ngaySinh:dd/MM/yyyy}\n" +
                 $"- Điện thoại: {dienThoai}\n" +
                 $"- Email: {email}\n" +
                 $"- Giới tính: {gioiTinhText}\n" +
                 $"- Khoa: {khoa}\n";

            MessageBox.Show(message, "Thông tin giảng viên");
        }

        private void seeAllSubClassBtn_Click(object sender, EventArgs e)
        {
            try
            { 
                var dsLopHP = db.LopHocPhans.Where(x => x.MaGv == giangVien.MaGv).Select(x => new LopHP
                {
                    tenLopHP = x.TenLop,
                    maLopHP = x.MaLopHp,
                    monHoc = db.MonHocs.FirstOrDefault(mh => mh.MaMh == x.MaMh).TenMh,
                    khoa = db.Khoas.FirstOrDefault(k => k.MaK == x.MaKhoa).TenK,
                    hocKy = db.HocKies.FirstOrDefault(hk => hk.MaHk == x.MaHk).TenHk,
                    lopQL = db.LopQuanLies.FirstOrDefault(lql => lql.MaLopQl == x.MaLopQl).TenLop,
                }).ToList();

                LopGiangDay dSSVLopGiangDay = new LopGiangDay(dsLopHP);
                dSSVLopGiangDay.Show();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Danh sách trống");
            }
        }

        private void showRegisteredSubjectsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var malopQL = db.LopQuanLies.FirstOrDefault(x => x.MaGv == giangVien.MaGv).MaLopQl;
                var dssvLopQL = db.SinhViens.Where(x => x.MaLopQl == malopQL).Select(x => new Sinhvien
                {
                    maSV = x.MaSv,
                    tenSv = x.TenSv,
                    gioiTinh = x.GioiTinh == true ? "Nam" : "Nữ",
                    ngaySinh = x.NgaySinh.ToString(),
                    dienThoai = x.DienThoai,
                    email = x.Email,
                    sdtPhuHuynh = x.PhuHuynhSdt
                }).ToList();

                DSSVLopQL dSSVLopQL = new DSSVLopQL(dssvLopQL);
                dSSVLopQL.Show();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Danh sách trống");
            }

        }
    }
}
