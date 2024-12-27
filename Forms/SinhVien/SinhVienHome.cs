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
using QuanLiSinhVien.Forms.SinhVien;
using QuanLiSinhVien.Models;
using HocPhi = QuanLiSinhVien.Forms.SinhVien.HocPhi;

namespace QuanLiSinhVien.Forms
{
    public partial class SinhVienHome : Form
    {
        private readonly QuanLyHocSinhContext db = new QuanLyHocSinhContext();
        private readonly Database.SinhVien sinhVien;
        public SinhVienHome(Database.SinhVien sinhVien)
        {
            InitializeComponent();
            this.sinhVien = sinhVien;
        }

        private void showRegisteredSubjectsBtn_Click(object sender, EventArgs e)
        {
            var dsLHP = db.SinhViens.Where(x => x.MaSv == sinhVien.MaSv).Join(db.DangKyHocPhans,
                sv => sv.MaSv, dkhp => dkhp.MaSv,
                (sv, dkhp) => new
                {
                    malop = dkhp.MaLopHp,
                    masv = sv.MaSv
                }).Join(db.LopHocPhans, dkhp => dkhp.malop, lhp => lhp.MaLopHp, (dkhp, lhp) => new LopHP
            {
                maLopHP = lhp.MaLopHp,
                tenLopHP = lhp.TenLop,
                hocKy = db.HocKies.FirstOrDefault(x => x.MaHk == lhp.MaHk).TenHk,
                khoa = db.Khoas.FirstOrDefault(x => x.MaK == lhp.MaKhoa).TenK,
                lopQL = db.LopQuanLies.FirstOrDefault(x => x.MaLopQl == lhp.MaLopQl).TenLop,
                monHoc = db.MonHocs.FirstOrDefault(x => x.MaMh == lhp.MaMh).TenMh,
            }).ToList();
            
            DSLopDaDangKy dsLopDaDangKy = new DSLopDaDangKy(dsLHP);
            dsLopDaDangKy.Show();
        }

        private void seeAllSubjectsBtn_Click(object sender, EventArgs e)
        {
            var dsMonHoc = db.MonHocs.Where(x => x.MaK == sinhVien.MaKhoa)
                .Select(x => new Models.MonHoc
            {
                maMonHoc = x.MaMh,
                tenMonHoc = x.TenMh,
                tinChi = x.TinChi,
                khoa = db.Khoas.FirstOrDefault(x => x.MaK == x.MaK).TenK,
                hocKi = db.HocKies.FirstOrDefault(x => x.MaHk == x.MaHk).TenHk
            }).ToList();
            
            ChuongTrinhDaoTao cTao = new ChuongTrinhDaoTao(dsMonHoc);
            cTao.Show();
        }

        private void showGradeBtn_Click(object sender, EventArgs e)
        {
            var diem = db.Diems.Where(x => x.MaSv == sinhVien.MaSv).Select(x => new Models.Diem
            {
                monHoc = db.MonHocs.FirstOrDefault(x => x.MaMh == x.MaMh).TenMh,
                lanThi = x.LanThi,
                diemThi = x.DiemThi,
                dqt = x.DiemQt,
                tongKet = x.TongKet,
            }).ToList();
            KetQuaHocTap ketQuaHocTap = new KetQuaHocTap(diem);
            ketQuaHocTap.Show();
        }

        private void showSchoolFeeBtn_Click(object sender, EventArgs e)
        {
            var hocPhi = db.SinhViens.Where(x => x.MaSv == sinhVien.MaSv)
                .Join(db.DangKyHocPhans, sv => sv.MaSv, dkhp => dkhp.MaSv, (sv, dkhp) => new
                {
                    maLopHP = dkhp.MaLopHp,
                })
                .Join(db.LopHocPhans, dkhp => dkhp.maLopHP, lhp => lhp.MaLopHp, (dkhp, lhp) => new
                {
                    maMh = lhp.MaMh,
                })
                .Join(db.HocPhis, lhp => lhp.maMh, hp => hp.MaMh, (lhp, hp) => new Models.HocPhi
                {
                    maMH = hp.MaMh,
                    tenMH = db.MonHocs.FirstOrDefault(x => x.MaMh == hp.MaMh).TenMh,
                    soTinChi = db.MonHocs.FirstOrDefault(x => x.MaMh == hp.MaMh).TinChi,
                    hocPhi = hp.GiaTien
                }).ToList();

            Forms.SinhVien.HocPhi hocPhiForm = new Forms.SinhVien.HocPhi(hocPhi);
            hocPhiForm.Show();
        }

        private void userInforBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var maSV = sinhVien.MaSv;
                var tenSV = sinhVien.TenSv;
                var ngaySinh = sinhVien.NgaySinh;
                var dienThoai = sinhVien.DienThoai;
                var email = sinhVien.Email;
                var gioiTinh = sinhVien.GioiTinh;
                var gioiTinhText = "";
                var khoa = db.Khoas.FirstOrDefault(x => x.MaK == sinhVien.MaKhoa).TenK;
                var sdtPH = sinhVien.PhuHuynhSdt;
                var lopQL = db.LopQuanLies.FirstOrDefault(x => x.MaLopQl == sinhVien.MaLopQl).TenLop;

                if (gioiTinh == true)
                    gioiTinhText = "Nam";
                else gioiTinhText = "Nữ";
            
                string message = $"Thông tin sinh viên:\n" +
                                 $"- Mã SV: {maSV} \n"+
                                 $"- Tên SV: {tenSV}\n" +
                                 $"- Ngày sinh: {ngaySinh:dd/MM/yyyy}\n" +
                                 $"- Điện thoại: {dienThoai}\n" +
                                 $"- Email: {email}\n" +
                                 $"- Giới tính: {gioiTinhText}\n" +
                                 $"- Khoa: {khoa}\n" +
                                 $"- Số điện thoại phụ huynh: {sdtPH}\n" + 
                                 $"- Lớp quản lí: {lopQL}\n";
                
                MessageBox.Show(message);
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("Không tìm thấy sinh viên");
            }
        }
    }
}
