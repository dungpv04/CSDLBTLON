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

namespace QuanLiSinhVien.Forms.SinhVien
{
    public partial class DSLopDaDangKy : Form
    {
        public DSLopDaDangKy(List<LopHP> lopHps)
        {
            InitializeComponent();
            dataGridView1.DataSource = lopHps;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
