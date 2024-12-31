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

namespace QuanLiSinhVien.Forms.Admin.QLMH
{
    public partial class QLMHAdd : Form
    {
        private QuanLyHocSinhContext db;
        private ComboBox cbKhoa;
        private QLMHHome home;
        public QLMHAdd(ComboBox _cbKhoa, QLMHHome _home)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            this.cbKhoa = _cbKhoa;
            this.home = _home;
            var dsKhoa = db.Khoas.Select(x => new DsKhoa
            {
                MaK = x.MaK,
                TenK = x.TenK,
            }).ToList();
            khoa.DataSource = dsKhoa;
            khoa.ValueMember = "MaK";
            khoa.DisplayMember = "TenK";

            var dshk = new List<int>
            {
                1, 2
            };
            gioitinh.DataSource = dshk;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var hk = gioitinh.SelectedValue;
            db.MonHocs.Add(new Database.MonHoc
            {
                MaMh = masv.Text,
                TenMh = tensv.Text,
                TinChi = Convert.ToInt32(dienthoai.Text),
                HocKy = Convert.ToInt32(hk),
                MaK = khoa.SelectedValue.ToString()
            });
            db.SaveChanges();
            Thread.Sleep(1000);
            home.updateDSMH();
            Thread.Sleep(1000);
            cbKhoa.SelectedValue = khoa.SelectedValue;
            Close();
        }
    }
}
