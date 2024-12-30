using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiSinhVien.Forms.Admin.QLSV;

namespace QuanLiSinhVien.Forms.Admin
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void qlsv_Click(object sender, EventArgs e)
        {
            var qlsvHome = new QLSVHome();
            qlsvHome.Show();
        }

        private void qlgv_Click(object sender, EventArgs e)
        {

        }

        private void qlmh_Click(object sender, EventArgs e)
        {

        }

        private void qlk_Click(object sender, EventArgs e)
        {

        }

        private void qlLopQL_Click(object sender, EventArgs e)
        {

        }

        private void qlLHP_Click(object sender, EventArgs e)
        {

        }
    }
}
