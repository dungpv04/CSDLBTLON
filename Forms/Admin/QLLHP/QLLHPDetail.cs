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

namespace QuanLiSinhVien.Forms.Admin.QLLHP
{
    public partial class QLLHPDetail : Form
    {
        private QuanLyHocSinhContext db;
        private QLLHPHome home;
        private string maLHP;
        private LopHocPhan lhp;
        public QLLHPDetail(QLLHPHome _home, string _maLHP)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            home = _home;
            maLHP = _maLHP;
            lhp = db.LopHocPhans.FirstOrDefault(x => x.MaLopHp == maLHP);
            var dsK = db.Khoas.ToList();
            cbK.DataSource = dsK;
            cbK.ValueMember = "MaK";
            cbK.DisplayMember = "TenK";
            cbK.SelectedValue = lhp.MaKhoa;
            
            tenLop.Text = lhp.TenLop;
            maLop.Text = lhp.MaLopHp;
            
            var dsHK = db.HocKies.ToList();
            var dsMH = db.MonHocs.Where(x => x.MaK == cbK.SelectedValue.ToString()).ToList();
            var dsGV = db.GiangViens.Where(x => x.MaK == cbK.SelectedValue.ToString()).ToList();
            var dsLQL = db.LopQuanLies.Where(x => x.MaKhoa == cbK.SelectedValue.ToString()).ToList();
            
            cbHK.DataSource = dsHK;
            cbHK.ValueMember = "MaHk";
            cbHK.DisplayMember = "TenHk";
            cbHK.SelectedValue = lhp.MaHk;
            
            cbMH.DataSource = dsMH;
            cbMH.ValueMember = "MaMh";
            cbMH.DisplayMember = "TenMh";
            cbMH.SelectedValue = lhp.MaMh;

            cbGV.DataSource = dsGV;
            cbGV.ValueMember = "MaGv";
            cbGV.DisplayMember = "TenGv";
            cbGV.SelectedValue = lhp.MaGv;

            cbLQL.DataSource = dsLQL;
            cbLQL.ValueMember = "MaLopQl";
            cbLQL.DisplayMember = "TenLop";
            cbLQL.SelectedValue = lhp.MaLopQl;
        }

        private void cbK_SelectedValueChanged(object sender, EventArgs e)
        {
            var dsMH = db.MonHocs.Where(x => x.MaK == cbK.SelectedValue.ToString()).ToList();
            var dsGV = db.GiangViens.Where(x => x.MaK == cbK.SelectedValue.ToString()).ToList();
            var dsLQL = db.LopQuanLies.Where(x => x.MaKhoa == cbK.SelectedValue.ToString()).ToList();
            cbMH.DataSource = dsMH;
            cbMH.ValueMember = "MaMh";
            cbMH.DisplayMember = "TenMh";

            cbGV.DataSource = dsGV;
            cbGV.ValueMember = "MaGv";
            cbGV.DisplayMember = "TenGv";

            cbLQL.DataSource = dsLQL;
            cbLQL.ValueMember = "MaLopQl";
            cbLQL.DisplayMember = "TenLop";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa lớp học phần này ?", // Nội dung thông báo
                "Xóa lớp học phần", // Tiêu đề
                MessageBoxButtons.YesNo, // Các nút Yes và No
                MessageBoxIcon.Question // Biểu tượng dấu hỏi
            );
            if (result == DialogResult.Yes)
            {
                var diem = db.Diems.FirstOrDefault(x => x.MaLopHp == maLHP);
                if (diem != null)
                    db.Diems.Remove(diem);
                
                var dkhp = db.DangKyHocPhans.FirstOrDefault(x => x.MaLopHp == maLHP);
                if (dkhp != null)
                    db.DangKyHocPhans.Remove(dkhp);
                
                db.LopHocPhans.Remove(lhp);
                db.SaveChanges();
                Thread.Sleep(1000);
                home.updateDSLHP();
                Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            lhp.MaLopQl = cbLQL.SelectedValue.ToString();
            lhp.MaMh = cbMH.SelectedValue.ToString();
            lhp.MaGv = cbGV.SelectedValue.ToString();
            lhp.MaHk = cbHK.SelectedValue.ToString();
            lhp.TenLop = tenLop.Text;
            lhp.MaKhoa = cbK.SelectedValue.ToString();
            db.LopHocPhans.Update(lhp);
            db.SaveChanges();
            Thread.Sleep(1000);
            home.updateDSLHP();
            Close();
        }
    }
}
