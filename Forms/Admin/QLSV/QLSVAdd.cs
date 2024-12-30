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
    public partial class QLSVAdd : Form
    {
        private QuanLyHocSinhContext db;
        private ComboBox cbKhoa;
        private QLSVHome home;
        public QLSVAdd(ComboBox _cbKhoa, QLSVHome _home)
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
            db.SinhViens.Add(new Database.SinhVien
            {
                MaSv = masv.Text,
                TenSv = tensv.Text,
                NgaySinh = DateOnly.FromDateTime(ngaysinh.Value),
                DienThoai = dienthoai.Text,
                Email = email.Text,
                GioiTinh = gt,
                PhuHuynhSdt = sdtphuhuynh.Text,
                MaKhoa = khoa.SelectedValue.ToString(),
                MaLopQl = lql.SelectedValue.ToString(),
            });
            db.SaveChanges();
            Thread.Sleep(1000);
            home.updateDSSV();
            Thread.Sleep(1000);
            cbKhoa.SelectedValue = khoa.SelectedValue;
            Close();
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
