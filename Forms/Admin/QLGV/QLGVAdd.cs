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

namespace QuanLiSinhVien.Forms.Admin.QLGV
{
    public partial class QLGVAdd : Form
    {
        private QuanLyHocSinhContext db;
        private ComboBox cbKhoa;
        private QLGVHome home;
        public QLGVAdd(ComboBox _cbKhoa, QLGVHome _home)
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

            var dsgt = new List<String>
            {
                "Nam", "Nữ"
            };
            gioitinh.DataSource = dsgt;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var gt = gioitinh.SelectedValue.ToString() == "Nam";
            db.GiangViens.Add(new Database.GiangVien
            {
                MaGv = masv.Text,
                TenGv = tensv.Text,
                NgaySinh = DateOnly.FromDateTime(ngaysinh.Value),
                DienThoai = dienthoai.Text,
                Email = email.Text,
                GioiTinh = gt,
                MaK = khoa.SelectedValue.ToString()
            });
            db.SaveChanges();
            Thread.Sleep(1000);
            home.updateDSGV();
            Thread.Sleep(1000);
            cbKhoa.SelectedValue = khoa.SelectedValue;
            Close();
        }
    }
}
