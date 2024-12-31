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

namespace QuanLiSinhVien.Forms.Admin.QLLQL
{
    public partial class QLLQLAdd : Form
    {
        private QuanLyHocSinhContext db;
        private QLLQLHome home;
        public QLLQLAdd(QLLQLHome _home)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            this.home = _home;
            
            var dsGv = db.GiangViens.ToList();
            var dsKhoa = db.Khoas.ToList();
            
            cbGV.DataSource = dsGv;
            cbGV.DisplayMember = "TenGV";
            cbGV.ValueMember = "MaGV";
            
            cbK.DataSource = dsKhoa;
            cbK.DisplayMember = "TenK";
            cbK.ValueMember = "MaK";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            db.LopQuanLies.Add(new Database.LopQuanLy
            {
                MaLopQl = masv.Text,
                TenLop = tensv.Text,
                MaGv = cbGV.SelectedValue.ToString(),
                MaKhoa = cbK.SelectedValue.ToString(),
            });
            db.SaveChanges();
            Thread.Sleep(1000);
            home.updateDSLQL();
            Thread.Sleep(1000);
            Close();
        }
    }
}
