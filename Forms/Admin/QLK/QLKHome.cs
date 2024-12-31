using QuanLiSinhVien.Database;
using QuanLiSinhVien.Models;

namespace QuanLiSinhVien.Forms.Admin.QLK
{
    public partial class QLKHome : Form
    {
        private QuanLyHocSinhContext db;
        private List<DsKhoa> dsKhoa;
        public QLKHome()
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            updateDSK();
        }

        public void updateDSK()
        {
            dsKhoa = db.Khoas.Select(x => new DsKhoa
            {
                MaK = x.MaK,
                TenK = x.TenK
            }).ToList();
            
            dataGridView1.DataSource = dsKhoa;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void add_Click(object sender, EventArgs e)
        {
            QLKAdd add = new QLKAdd(this);
            add.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var maK = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var qlmhDetail = new QLKDetail(this, maK);
            qlmhDetail.Show();
        }
    }
}
