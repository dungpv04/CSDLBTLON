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
    public partial class QLMHDetail : Form
    {
        private Database.MonHoc monHoc;
        private QuanLyHocSinhContext db;
        private QLMHHome home;
        private ComboBox cbKhoa;
        public QLMHDetail(QLMHHome _home, String mmh, ComboBox _cbKhoa)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            monHoc = db.MonHocs.FirstOrDefault(x => x.MaMh == mmh);
            home = _home;
            this.cbKhoa = _cbKhoa;
            var dsKhoa = db.Khoas.Select(x => new DsKhoa
            {
                MaK = x.MaK,
                TenK = x.TenK,
            }).ToList();
            khoa.DataSource = dsKhoa;
            khoa.ValueMember = "MaK";
            khoa.DisplayMember = "TenK";

            var dshk = new List<HocKyAdmin>
            {
                new HocKyAdmin
                {
                    maHK = 1,
                    tenHK = 1,
                },
                new HocKyAdmin
                {
                    maHK = 2,
                    tenHK = 2,
                }
            };
            gioitinh.DataSource = dshk;
            gioitinh.ValueMember = "maHK";
            gioitinh.DisplayMember = "tenHK";

            masv.Text = monHoc.MaMh;
            tensv.Text = monHoc.TenMh;
            tc.Text = monHoc.TinChi.ToString();
            gioitinh.SelectedValue = monHoc.HocKy;
            khoa.SelectedValue = monHoc.MaK;
        }

        private void update_Click(object sender, EventArgs e)
        {
            var hk = Convert.ToInt32(gioitinh.SelectedValue);
            var mh = db.MonHocs.FirstOrDefault(x => x.MaMh == monHoc.MaMh);
            mh.TenMh = tensv.Text;
            mh.TinChi = Convert.ToInt32(tc.Text);
            mh.HocKy = hk;
            mh.MaK = khoa.SelectedValue.ToString();
            db.MonHocs.Update(mh);
            Thread.Sleep(1000);
            db.SaveChanges();
            Thread.Sleep(1000);
            home.updateDSMH();
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa môn học này ?", // Nội dung thông báo
                "Xóa môc học", // Tiêu đề
                MessageBoxButtons.YesNo, // Các nút Yes và No
                MessageBoxIcon.Question // Biểu tượng dấu hỏi
            );

            // Xử lý kết quả
            if (result == DialogResult.Yes)
            {
                db.MonHocs.Remove(db.MonHocs.FirstOrDefault(x => x.MaMh == monHoc.MaMh));
                db.SaveChanges();
                Thread.Sleep(1000);
                home.updateDSMH();
                Close();
            }
        }
    }
}
