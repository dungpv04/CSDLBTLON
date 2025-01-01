using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLiSinhVien.Database;
using QuanLiSinhVien.Models;

namespace QuanLiSinhVien.Forms.Admin.QLLHP
{
    public partial class QLLHPHome : Form
    {
        private QuanLyHocSinhContext db;
        public QLLHPHome()
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            var dsKhoa = db.Khoas.Select(x => new DsKhoa
            {
                MaK = x.MaK,
                TenK = x.TenK
            }).ToList();
            dsKhoa.Add(new DsKhoa { MaK = "All", TenK = "Tất cả" });

            khoa.DataSource = dsKhoa;
            khoa.DisplayMember = "TenK";
            khoa.ValueMember = "MaK";
            khoa.SelectedValue = "All";
            lql.Enabled = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var add = new QLLHPAdd(this);
            add.Show();
        }

        private void khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (khoa.SelectedValue.ToString() == "All")
                lql.Enabled = false;
            else lql.Enabled = true;

            var dsLQL = db.LopQuanLies.Where(x => x.MaKhoa == khoa.SelectedValue.ToString()).Select(x => new DSLQL
            {
                Malop = x.MaLopQl,
                Tenlop = x.TenLop
            }).ToList();
            dsLQL.Add(new DSLQL { Malop = "All", Tenlop = "Tất cả" });
            lql.DataSource = dsLQL;
            lql.ValueMember = "Malop";
            lql.DisplayMember = "Tenlop";
            lql.SelectedValue = "All";
            updateDSLHP();
        }

        public void updateDSLHP()
        {
            List<LopHocPhan> dsLHP;
            if (khoa.SelectedValue.ToString() == "All")
            {
                dsLHP = db.LopHocPhans.AsNoTracking().ToList();
            }
            else
            {
                if (lql.SelectedValue.ToString() == "All")
                {
                    dsLHP = db.LopHocPhans.AsNoTracking().Where(x => x.MaKhoa == khoa.SelectedValue.ToString()).ToList();
                }
                else
                {
                    dsLHP = db.LopHocPhans.AsNoTracking().Where(x => x.MaKhoa == khoa.SelectedValue.ToString() && x.MaLopQl == lql.SelectedValue.ToString()).ToList();
                }
            }

            var dsMH = db.MonHocs.ToList();
            var dsGV = db.GiangViens.ToList();
            var dsLQL = db.LopQuanLies.ToList();
            var dsK = db.Khoas.ToList();
            var dsHK = db.HocKies.ToList();

            var final = dsLHP.Select(x => new LHPAdmin
            {
                maLop = x.MaLopHp,
                tenLop = x.TenLop,
                gv = dsGV.FirstOrDefault(y => y.MaGv == x.MaGv).TenGv,
                hocKy = dsHK.FirstOrDefault(y => y.MaHk == x.MaHk).TenHk,
                khoa = dsK.FirstOrDefault(y => y.MaK == x.MaKhoa).TenK,
                lopQL = dsLQL.FirstOrDefault(y => y.MaLopQl == x.MaLopQl).TenLop,
                monHoc = dsMH.FirstOrDefault(y => y.MaMh == x.MaMh).TenMh
            }).ToList();
            dataGridView1.DataSource = final;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void lql_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDSLHP();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var maLhp = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var lhpDetail = new QLLHPDetail(this, maLhp);
            lhpDetail.Show();
        }
    }
}
