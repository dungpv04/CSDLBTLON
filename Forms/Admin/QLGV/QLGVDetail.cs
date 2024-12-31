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
    public partial class QLGVDetail : Form
    {
        private Database.GiangVien giangvien;
        private QuanLyHocSinhContext db;
        private QLGVHome home;
        private ComboBox cbKhoa;
        public QLGVDetail(QLGVHome _home, String mgv, ComboBox _cbKhoa)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            giangvien = db.GiangViens.FirstOrDefault(x => x.MaGv == mgv);
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

            var dsgt = new List<GioiTinh>
            {
                new GioiTinh
                {
                    value = true,
                    name = "Nam"
                },
                new GioiTinh
                {
                    value = false,
                    name = "Nữ"
                }
            };
            gioitinh.DataSource = dsgt;
            gioitinh.ValueMember = "value";
            gioitinh.DisplayMember = "name";

            masv.Text = giangvien.MaGv;
            tensv.Text = giangvien.TenGv;
            ngaysinh.Value = DateTime.ParseExact(giangvien.NgaySinh.ToString(), "dd/MM/yyyy", null);
            dienthoai.Text = giangvien.DienThoai;
            email.Text = giangvien.Email;
            gioitinh.SelectedValue = giangvien.GioiTinh;
            khoa.SelectedValue = giangvien.MaK;
        }

        private void update_Click(object sender, EventArgs e)
        {
            var gt = gioitinh.SelectedValue.ToString() == "Nam";
            var sv = db.GiangViens.FirstOrDefault(x => x.MaGv == giangvien.MaGv);
            sv.TenGv = tensv.Text;
            sv.NgaySinh = DateOnly.FromDateTime(ngaysinh.Value);
            sv.DienThoai = dienthoai.Text;
            sv.Email = email.Text;
            sv.GioiTinh = gt;
            sv.MaK = khoa.SelectedValue.ToString();
            db.GiangViens.Update(giangvien);
            Thread.Sleep(1000);
            db.SaveChanges();
            Thread.Sleep(1000);
            home.updateDSGV();
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa giảng viên này ?", // Nội dung thông báo
                "Xóa giảng viên", // Tiêu đề
                MessageBoxButtons.YesNo, // Các nút Yes và No
                MessageBoxIcon.Question // Biểu tượng dấu hỏi
            );

            // Xử lý kết quả
            if (result == DialogResult.Yes)
            {
                db.GiangViens.Remove(db.GiangViens.FirstOrDefault(x => x.MaGv == giangvien.MaGv));
                db.SaveChanges();
                Thread.Sleep(1000);
                home.updateDSGV();
                Close();
            }
        }
    }
}
