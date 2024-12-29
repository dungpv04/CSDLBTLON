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
using QuanLiSinhVien.Models;

namespace QuanLiSinhVien.Forms.GiangVien
{
    public partial class DSSVLopGiangDay : Form
    {
        private QuanLyHocSinhContext db;
        private String maLHP;
        public DSSVLopGiangDay(String maLHP)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            this.maLHP = maLHP;
            dataGridView1.DataSource = updateDSSV();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var chamDiem = new ChamDiem(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView1, maLHP);
            chamDiem.Show();
        }

        private List<SVLopHP> updateDSSV()
        {
            db = new QuanLyHocSinhContext();
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
