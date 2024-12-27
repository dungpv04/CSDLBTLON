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

namespace QuanLiSinhVien.Forms.GiangVien
{
    public partial class DSSVLopQL : Form
    {
        public DSSVLopQL(List<Sinhvien> sinhViens)
        {
            InitializeComponent();
            dataGridView1.DataSource = sinhViens;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
