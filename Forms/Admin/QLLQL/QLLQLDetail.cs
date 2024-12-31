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
    public partial class QLLQLDetail : Form
    {
        private List<Khoa> dsKhoa;
        private QuanLyHocSinhContext db;
        private QLLQLHome home;
        private String ml;
        public QLLQLDetail(QLLQLHome _home, String ml)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            var lql = db.LopQuanLies.FirstOrDefault(x => x.MaLopQl == ml);
            var dsGv = db.GiangViens.ToList();
            dsKhoa = db.Khoas.ToList();
            home = _home;
            this.ml = ml;
            masv.Text = lql.MaLopQl;
            tensv.Text = lql.TenLop;

            var gv = dsGv.FirstOrDefault(x => x.MaGv == lql.MaGv).MaGv;
            
            cbGV.DataSource = dsGv;
            cbGV.DisplayMember = "tenGv";
            cbGV.ValueMember = "maGv";
            cbGV.SelectedValue = gv;
            
            cbK.DataSource = dsKhoa;
            cbK.DisplayMember = "TenK";
            cbK.ValueMember = "MaK";
            cbK.SelectedValue = dsKhoa.FirstOrDefault(x => x.MaK == lql.MaKhoa).MaK;
        }

        private void update_Click(object sender, EventArgs e)
        {
            var lop = db.LopQuanLies.FirstOrDefault(x => x.MaLopQl == ml);
            lop.TenLop = tensv.Text;
            lop.MaGv = cbGV.SelectedValue.ToString();
            lop.MaKhoa = cbK.SelectedValue.ToString();
            db.LopQuanLies.Update(lop);
            Thread.Sleep(1000);
            db.SaveChanges();
            Thread.Sleep(1000);
            home.updateDSLQL();
            Close();
        }
    }
}
