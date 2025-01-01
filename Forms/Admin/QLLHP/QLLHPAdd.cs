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
    public partial class QLLHPAdd : Form
    {
        private QuanLyHocSinhContext db;
        private QLLHPHome home;
        public QLLHPAdd(QLLHPHome _home)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            home = _home;
            var dsK = db.Khoas.ToList();
            var dsHK = db.HocKies.ToList();

            cbK.DataSource = dsK;
            cbK.ValueMember = "MaK";
            cbK.DisplayMember = "TenK";
            cbK.SelectedIndex = 0;

            cbHK.DataSource = dsHK;
            cbHK.ValueMember = "MaHk";
            cbHK.DisplayMember = "TenHk";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            db.LopHocPhans.Add(new LopHocPhan
            {
                MaLopHp = maLop.Text,
                MaLopQl = cbLQL.SelectedValue.ToString(),
                MaMh = cbMH.SelectedValue.ToString(),
                MaGv = cbGV.SelectedValue.ToString(),
                MaHk = cbHK.SelectedValue.ToString(),
                TenLop = tenLop.Text,
                MaKhoa = cbK.SelectedValue.ToString(),
            });
            db.SaveChanges();
            Thread.Sleep(1000);
            home.updateDSLHP();
            this.Close();
        }

        private void cbK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
    }
}
