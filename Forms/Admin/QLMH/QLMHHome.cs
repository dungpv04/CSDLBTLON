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
using MonHoc = QuanLiSinhVien.Database.MonHoc;

namespace QuanLiSinhVien.Forms.Admin.QLMH
{
    public partial class QLMHHome : Form
    {
        private QuanLyHocSinhContext db;
        private List<MonHocAdmin> finalDsmh;
        private List<DsKhoa> dsKhoa;
        public QLMHHome()
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            dsKhoa = db.Khoas.Select(x => new DsKhoa
            {
                MaK = x.MaK,
                TenK = x.TenK
            }).ToList();
            dsKhoa.Add(new DsKhoa { MaK = "All", TenK = "Tất cả" });
            khoa.DataSource = dsKhoa;
            khoa.ValueMember = "MaK";
            khoa.DisplayMember = "TenK";
            khoa.SelectedValue = "All";
        }

        private void khoa_SelectedValueChanged(object sender, EventArgs e)
        {
            updateDSMH();
        }

        public void updateDSMH()
        {
            var makhoa = khoa.SelectedValue.ToString();
            var dsmh = new List<Database.MonHoc>();
            if (!makhoa.Equals("All"))
            {
                dsmh = db.MonHocs.AsNoTracking().Where(x => x.MaK == makhoa).ToList();
            }
            else dsmh = db.MonHocs.AsNoTracking().ToList();
            finalDsmh = new List<MonHocAdmin>();
            foreach (var mh in dsmh)
            {
                finalDsmh.Add(new MonHocAdmin
                {
                    maMH = mh.MaMh,
                    tenMH = mh.TenMh,
                    soTC = mh.TinChi,
                    hocKy = mh.HocKy,
                    khoa = dsKhoa.FirstOrDefault(x => x.MaK == mh.MaK).TenK,
                });
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = finalDsmh;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void add_Click(object sender, EventArgs e)
        {
            QLMHAdd add = new QLMHAdd(khoa, this);
            add.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var mamh = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var qlmhDetail = new QLMHDetail(this, mamh, khoa);
            qlmhDetail.Show();
        }
    }
}
