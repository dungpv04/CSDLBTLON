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

namespace QuanLiSinhVien.Forms.Admin.QLSV
{
    public partial class QLSVHome : Form
    {
        private QuanLyHocSinhContext db;
        private List<SinhvienAdmin> finalDssv;
        private List<DsKhoa> dsKhoa;
        public QLSVHome()
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
            updateDSSV();
        }

        public void updateDSSV()
        {
            var makhoa = khoa.SelectedValue.ToString();
            var dssv = new List<Database.SinhVien>();
            if (!makhoa.Equals("All"))
            {
                dssv = db.SinhViens.AsNoTracking().Where(x => x.MaKhoa == makhoa).ToList();
            }
            else dssv = db.SinhViens.AsNoTracking().ToList();
            finalDssv = new List<SinhvienAdmin>();
            var lopQL = db.LopQuanLies.ToList();
            foreach (var sv in dssv)
            {
                var gioiTinh = "";
                if (sv.GioiTinh == true)
                    gioiTinh = "Nam";
                else gioiTinh = "Nữ";
                finalDssv.Add(new SinhvienAdmin
                {
                    maSV = sv.MaSv,
                    tenSv = sv.TenSv,
                    gioiTinh = gioiTinh,
                    dienThoai = sv.DienThoai,
                    sdtPhuHuynh = sv.PhuHuynhSdt,
                    email = sv.Email,
                    lql = lopQL.FirstOrDefault(x => x.MaLopQl == sv.MaLopQl).MaLopQl,
                    khoa = dsKhoa.FirstOrDefault(x => x.MaK == sv.MaKhoa).TenK,
                    ngaySinh = sv.NgaySinh.ToString(),
                });
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = finalDssv;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void add_Click(object sender, EventArgs e)
        {
            QLSVAdd add = new QLSVAdd(khoa, this);
            add.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var masv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var qlsvDetail = new QLSVDetail(this, masv, khoa);
            qlsvDetail.Show();
        }
    }
}
