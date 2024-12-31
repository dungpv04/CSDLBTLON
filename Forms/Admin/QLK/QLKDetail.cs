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

namespace QuanLiSinhVien.Forms.Admin.QLK
{
    public partial class QLKDetail : Form
    {
        private Database.Khoa khoa;
        private QuanLyHocSinhContext db;
        private QLKHome home;
        public QLKDetail(QLKHome _home, String mk)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            khoa = db.Khoas.FirstOrDefault(x => x.MaK == mk);
            home = _home;

            masv.Text = khoa.MaK;
            tensv.Text = khoa.TenK;
        }

        private void update_Click(object sender, EventArgs e)
        {
            var k = db.Khoas.FirstOrDefault(x => x.MaK == khoa.MaK);
            k.TenK = tensv.Text;
            db.Khoas.Update(k);
            Thread.Sleep(1000);
            db.SaveChanges();
            Thread.Sleep(1000);
            home.updateDSK();
            Close();
        }
    }
}
