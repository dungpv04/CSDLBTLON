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
    public partial class ChuongTrinhDaoTao : Form
    {
        public ChuongTrinhDaoTao(List<Models.MonHoc> monHoc)
        {
            InitializeComponent();
            dataGridView1.DataSource = monHoc;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
