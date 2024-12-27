using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien.Forms.SinhVien
{
    public partial class KetQuaHocTap : Form
    {
        public KetQuaHocTap(List<Models.Diem> diem)
        {
            InitializeComponent();
            dataGridView1.DataSource = diem;
            dataGridView1.Update();
            dataGridView1.Refresh();

            var diemTB = diem.Average(x => x.tongKet);
            txtDTB.Text = diemTB.ToString();
        }
    }
}
