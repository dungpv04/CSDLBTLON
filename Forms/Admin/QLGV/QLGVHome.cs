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

namespace QuanLiSinhVien.Forms.Admin.QLGV
{
    public partial class QLGVHome : Form
    {
        private QuanLyHocSinhContext db;
        private List<GiangVienAdmin> finalDssv;
        private List<DsKhoa> dsKhoa;
        public QLGVHome()
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
            updateDSGV();
        }

        public void updateDSGV()
        {
            var makhoa = khoa.SelectedValue.ToString();
            var dsgv = new List<Database.GiangVien>();
            if (!makhoa.Equals("All"))
            {
                dsgv = db.GiangViens.AsNoTracking().Where(x => x.MaK == makhoa).ToList();
            }
            else dsgv = db.GiangViens.AsNoTracking().ToList();
            finalDssv = new List<GiangVienAdmin>();
            var lopQL = db.LopQuanLies.ToList();
            foreach (var gv in dsgv)
            {
                var gioiTinh = "";
                if (gv.GioiTinh == true)
                    gioiTinh = "Nam";
                else gioiTinh = "Nữ";
                finalDssv.Add(new GiangVienAdmin
                {
                    maGv = gv.MaGv,
                    tenGv = gv.TenGv,
                    gioiTinh = gioiTinh,
                    dienThoai = gv.DienThoai,
                    email = gv.Email,
                    khoa = dsKhoa.FirstOrDefault(x => x.MaK == gv.MaK).TenK,
                    ngaySinh = gv.NgaySinh.ToString(),
                });
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = finalDssv;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void add_Click(object sender, EventArgs e)
        {
            QLGVAdd add = new QLGVAdd(khoa, this);
            add.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var magv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var qlgvDetail = new QLGVDetail(this, magv, khoa);
            qlgvDetail.Show();
        }
    }
}
