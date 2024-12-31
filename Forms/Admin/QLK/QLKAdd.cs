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
    public partial class QLKAdd : Form
    {
        private QuanLyHocSinhContext db;
        private QLKHome home;
        public QLKAdd(QLKHome _home)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            this.home = _home;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            db.Khoas.Add(new Database.Khoa
            {
                MaK = masv.Text,
                TenK = tensv.Text,
            });
            db.SaveChanges();
            Thread.Sleep(1000);
            home.updateDSK();
            Thread.Sleep(1000);
            Close();
        }
    }
}
