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
    public partial class HocPhi : Form
    {
        public HocPhi(List<Models.HocPhi> lstHocPhi)
        {
            InitializeComponent();
            dataGridView1.DataSource = lstHocPhi;
            dataGridView1.Update();
            dataGridView1.Refresh();
            var currency = " VNĐ";
            tongHP.Text = lstHocPhi.Sum(x => x.hocPhi) + currency;
        }
    }
}
