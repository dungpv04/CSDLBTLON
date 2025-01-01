using System.Collections;
using Microsoft.EntityFrameworkCore;
using QuanLiSinhVien.Database;
using QuanLiSinhVien.Models;

namespace QuanLiSinhVien.Forms.Admin.QLLQL
{
    public partial class QLLQLHome : Form
    {
        private QuanLyHocSinhContext db;
        private List<DsKhoa> dsKhoa;
        public QLLQLHome()
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            dsKhoa = db.Khoas.Select( x=> new DsKhoa
            {
                MaK = x.MaK,
                TenK = x.TenK,
            }).ToList();
            dsKhoa.Add(new DsKhoa
            {
                MaK = "All",
                TenK = "Tất cả",
            });
            khoa.DataSource = dsKhoa;
            khoa.ValueMember = "MaK";
            khoa.DisplayMember = "TenK";
            khoa.SelectedValue = "All";
            updateDSLQL();
        }

        private void add_Click(object sender, EventArgs e)
        {
            QLLQLAdd add = new QLLQLAdd(this);
            add.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var mal = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var qlmhDetail = new QLLQLDetail(this, mal);
            qlmhDetail.Show();
        }

        private void khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDSLQL();
        }

        public void updateDSLQL()
        {
            List<LopQuanLy> dslql;
            if (khoa.SelectedValue.ToString() == "All")
                dslql = db.LopQuanLies.AsNoTracking().ToList();
            else
                dslql = db.LopQuanLies.Where(x => x.MaKhoa == khoa.SelectedValue.ToString()).AsNoTracking().ToList();
            var dsGV = db.GiangViens.ToList();
            List<LQLAdmin> finalDS = new List<LQLAdmin>();
            foreach (var lql in dslql)
            {
                finalDS.Add(new LQLAdmin
                {
                    maLQL = lql.MaLopQl,
                    tenLQL = lql.TenLop,
                    gv = dsGV.FirstOrDefault(x => x.MaGv == lql.MaGv).TenGv,
                    khoa = dsKhoa.FirstOrDefault(x => x.MaK == lql.MaKhoa).TenK
                });
            }
            dataGridView1.DataSource = finalDS;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
