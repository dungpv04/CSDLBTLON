using QuanLiSinhVien.Models;
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

namespace QuanLiSinhVien.Forms.GiangVien
{
    public partial class LopGiangDay : Form
    {
        private readonly QuanLyHocSinhContext db;
        public LopGiangDay(List<LopHP> lopHP)
        {
            InitializeComponent();
            db = new QuanLyHocSinhContext();
            dataGridView1.DataSource = lopHP;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                var maLHP = row.Cells[0].Value.ToString();
                
                
                DSSVLopGiangDay dss = new DSSVLopGiangDay(maLHP);
                dss.Show();
            }
        }
    }
}
