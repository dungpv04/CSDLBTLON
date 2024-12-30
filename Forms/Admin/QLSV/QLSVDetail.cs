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

namespace QuanLiSinhVien.Forms.Admin.QLSV
{
    public partial class QLSVDetail : Form
    {
        private Database.SinhVien sinhvien;
        private QuanLyHocSinhContext db;
        private QLSVHome home;
        private ComboBox cbKhoa;
        public QLSVDetail(QLSVHome _home, String msv, ComboBox _cbKhoa)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            sinhvien = db.SinhViens.FirstOrDefault(x => x.MaSv == msv);
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

            masv.Text = sinhvien.MaSv;
            tensv.Text = sinhvien.TenSv;
            ngaysinh.Value = DateTime.ParseExact(sinhvien.NgaySinh.ToString(), "dd/MM/yyyy", null);
            dienthoai.Text = sinhvien.DienThoai;
            email.Text = sinhvien.Email;
            gioitinh.SelectedValue = sinhvien.GioiTinh;
            sdtphuhuynh.Text = sinhvien.PhuHuynhSdt;
            khoa.SelectedValue = sinhvien.MaKhoa;
            lql.SelectedValue = sinhvien.MaLopQl;
        }

        private void update_Click(object sender, EventArgs e)
        {
            var gt = gioitinh.SelectedValue.ToString() == "Nam";
            var sv = db.SinhViens.FirstOrDefault(x => x.MaSv == sinhvien.MaSv);
            sv.TenSv = tensv.Text;
            sv.NgaySinh = DateOnly.FromDateTime(ngaysinh.Value);
            sv.DienThoai = dienthoai.Text;
            sv.Email = email.Text;
            sv.GioiTinh = gt;
            sv.PhuHuynhSdt = sdtphuhuynh.Text;
            sv.MaKhoa = khoa.SelectedValue.ToString();
            sv.MaLopQl = lql.SelectedValue.ToString();
            db.SinhViens.Update(sinhvien);
            //Thread.Sleep(1000);
            db.SaveChangesAsync();
            //Thread.Sleep(1000);
            home.updateDSSV();
            //Thread.Sleep(1000);
            cbKhoa.SelectedValue = khoa.SelectedValue;
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này ?", // Nội dung thông báo
                "Xóa sinh viên", // Tiêu đề
                MessageBoxButtons.YesNo, // Các nút Yes và No
                MessageBoxIcon.Question // Biểu tượng dấu hỏi
            );

            // Xử lý kết quả
            if (result == DialogResult.Yes)
            {
                db.SinhViens.Remove(db.SinhViens.FirstOrDefault(x => x.MaSv == sinhvien.MaSv));
                db.SaveChanges();
                Thread.Sleep(1000);
                home.updateDSSV();
                Thread.Sleep(1000);
                cbKhoa.SelectedValue = khoa.SelectedValue;
                Close();
            }
        }

        private void khoa_SelectedValueChanged(object sender, EventArgs e)
        {
            var dslql = db.LopQuanLies.Where(x => x.MaKhoa == khoa.SelectedValue.ToString())
                .Select(x => new DSLQL
                {
                    Malop = x.MaLopQl,
                    Tenlop = x.TenLop
                }).ToList();
            lql.DataSource = dslql;
            lql.ValueMember = "Malop";
            lql.DisplayMember = "Tenlop";
        }
    }
}
