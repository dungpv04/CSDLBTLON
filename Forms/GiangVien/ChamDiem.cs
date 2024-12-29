using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiSinhVien.Database;
using QuanLiSinhVien.Models;

namespace QuanLiSinhVien.Forms.GiangVien
{
    public partial class ChamDiem : Form
    {
        private String maSV;
        private readonly QuanLyHocSinhContext db;
        private DataGridView dssv;
        private String maLHP;
        public ChamDiem(String masv, DataGridView dssv, String maLHP)
        {
            InitializeComponent();
            this.maSV = masv;
            this.dssv = dssv;
            this.maLHP = maLHP;
            db = new QuanLyHocSinhContext();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (dqt.Text == String.Empty || dt.Text == String.Empty)
            {
                warning.Text = "Vui lòng nhập đủ đầu điểm";
                warning.Visible = true;
            }
            else
            {
                try
                {
                    warning.Visible = false;
                    var diemQT = Convert.ToDouble(dqt.Text);
                    var diemThi = Convert.ToDouble(dt.Text);
                    if ((diemQT < 0 || diemQT > 10) || (diemThi < 0 || diemThi > 10))
                    {
                        warning.Visible = true;
                        warning.Text = "Điểm phải nằm trong khoảng từ 0 - 10";
                    }
                    else
                    {
                        warning.Visible = false;
                        updateDiem(diemQT, diemThi);
                        Close();
                    }
                }
                catch (FormatException)
                {
                    warning.Visible = true;
                    warning.Text = "Điểm không hợp lệ";
                }
            }
        }

        private void updateDiem(double diemQT, double diemThi)
        {
            var diem = db.Diems.FirstOrDefault(x => x.MaSv == maSV);
            diem.DiemQt = diemQT;
            diem.DiemThi = diemThi;
            diem.TongKet = (diemQT + diemThi) / 2;
            db.Diems.Update(diem);
            db.SaveChangesAsync();
            Thread.Sleep(1500);
            dssv.DataSource = updateDSSV();
            dssv.Update();
            dssv.Refresh();
        }
        
        private List<SVLopHP> updateDSSV()
        {
            var dssv = db.LopHocPhans.Where(x => x.MaLopHp == maLHP)
                .Join(db.DangKyHocPhans, lhp => lhp.MaLopHp, dkhp => dkhp.MaLopHp, (lhp, dkhp) => new
                {
                    maSV = dkhp.MaSv
                }).Join(db.SinhViens, dkhp => dkhp.maSV, sv => sv.MaSv, (dkhp, sv) => new
                {
                    maSv = sv.MaSv,
                    tenSv = sv.TenSv,
                    lopQL = db.LopHocPhans.FirstOrDefault(x => x.MaLopQl == sv.MaLopQl).TenLop
                })
                .Join(db.Diems, sv => sv.maSv, d => d.MaSv, (sv, d) => new SVLopHP
                {
                    maSV = sv.maSv,
                    tenSV = sv.tenSv,
                    lopQL = sv.lopQL,
                    dqt = d.DiemQt,
                    diemThi = d.DiemThi,
                    tongKet = d.TongKet,
                }).ToList();
            return dssv;
        }
    }
}
