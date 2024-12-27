using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiSinhVien.Models;

namespace QuanLiSinhVien.Forms.GiangVien
{
    public partial class DSSVLopGiangDay : Form
    {
        public DSSVLopGiangDay(List<SVLopHP> dssv)
        {
            InitializeComponent();
            dataGridView1.DataSource = dssv;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
