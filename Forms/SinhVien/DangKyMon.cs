using QuanLiSinhVien.Database;
using QuanLiSinhVien.Models;

namespace QuanLiSinhVien.Forms.SinhVien
{
    public partial class DangKyMon : Form
    {
        private String masv;
        private QuanLyHocSinhContext db;
        public DangKyMon(Database.SinhVien sinhvien)
        {
            InitializeComponent();
            this.masv = sinhvien.MaSv;
            var maKhoa = sinhvien.MaKhoa;
            db = new QuanLyHocSinhContext();

            var dsChuaDk = db.LopHocPhans
                .GroupJoin(
                    db.DangKyHocPhans,
                    lhp => lhp.MaLopHp,               // Khóa bên trái
                    dkhp => dkhp.MaLopHp,             // Khóa bên phải
                    (lhp, dkhps) => new               // Kết quả sau khi GroupJoin
                    {
                        maLHP = lhp.MaLopHp,
                        tenLHP = lhp.TenLop,
                        maK = lhp.MaKhoa,
                        maMH = lhp.MaMh,
                        SinhVienDangKy = dkhps        // Nhóm sinh viên đăng ký
                    }
                )
                .SelectMany(
                    result => result.SinhVienDangKy.DefaultIfEmpty(), // Bảo đảm LEFT JOIN (khi không có sinh viên nào)
                    (result, dkhp) => new                             // Kết hợp với từng phần tử trong nhóm
                    {
                        maLHP = result.maLHP,
                        maSv = dkhp.MaSv, // Có thể null nếu không có sinh viên
                        maK = result.maK,
                        maMH = result.maMH,
                        tenLHP = result.tenLHP,
                    }
                )
                .Join(db.MonHocs, lhp => lhp.maMH, mh => mh.MaMh, (lhp, mh) => new RegisterSubject
                {
                    maSv = lhp.maSv,
                    maK = lhp.maK,
                    tenMonHoc = mh.TenMh,
                    maLHP = lhp.maLHP,
                    tenLHP = lhp.tenLHP
                })
                .Where(x => x.maSv != masv && x.maK == maKhoa).AsEnumerable().DistinctBy(x => x.maLHP)
                .ToList();

            try
            {
                var sv = db.DangKyHocPhans.Where(x => x.MaSv == masv).ToList();
                if (sv != null)
                {
                    foreach (var item in sv)
                    {
                        var duplicate = dsChuaDk.Find(x => x.maLHP == item.MaLopHp);
                        if (duplicate != null)
                        {
                            dsChuaDk.Remove(duplicate);
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                //kk
            }

            this.dsChuaDk.DataSource = dsChuaDk;
            this.dsChuaDk.Update();
            this.dsChuaDk.Refresh();

            var dsDaDk = db.LopHocPhans.Join(db.DangKyHocPhans, lhp => lhp.MaLopHp, dkhp => dkhp.MaLopHp, (lhp, dkhp) =>
                new
                {
                    maLHP = lhp.MaLopHp,
                    tenLHP = lhp.TenLop,
                    maK = lhp.MaKhoa,
                    maMH = lhp.MaMh,
                    maSV = dkhp.MaSv,
                })
                .Join(db.MonHocs, x => x.maMH, mh => mh.MaMh, (lhp, mh) => new RegisterSubject
                {
                    maLHP = lhp.maLHP,
                    tenLHP = lhp.tenLHP,
                    maK = lhp.maK,
                    tenMonHoc = mh.TenMh,
                    maSv = lhp.maSV,
                }).Where(x => x.maSv == masv && x.maK == maKhoa).ToList();

            this.dsDaDk.DataSource = dsDaDk;
            this.dsDaDk.Update();
            this.dsDaDk.Refresh();
        }

        private void dsChuaDk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maLHP = dsChuaDk.Rows[e.RowIndex].Cells[0].Value.ToString();
            string caption = "Đăng ký lớp học phần";
            string text= "Bạn có muốn đăng ký lớp học phần " + dsChuaDk.Rows[e.RowIndex].Cells[1].Value + " ?";
            if (ShowConfirmDialog(text, caption))
            {
                db.DangKyHocPhans.Add(new DangKyHocPhan
                {
                    MaSv = masv,
                    MaLopHp = maLHP
                });
                db.SaveChanges();
                dsDaDk.Rows.Add(dsChuaDk.Rows[e.RowIndex]);
                dsChuaDk.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dsDaDk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string caption = "Đăng ký lớp học phần";
            string text= "Bạn có muốn đăng ký lớp học phần";
            ShowConfirmDialog(text, caption);
        }
        
        private bool ShowConfirmDialog(string text, string caption)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                text, // Nội dung thông báo
                caption, // Tiêu đề
                MessageBoxButtons.YesNo, // Các nút Yes và No
                MessageBoxIcon.Question // Biểu tượng dấu hỏi
            );

            // Xử lý kết quả
            if (result == DialogResult.Yes)
            {
               return true;
            }
            return false;
        }

    }
}
