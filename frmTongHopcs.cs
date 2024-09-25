using System;
using HoaProject;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator19;
using PTBac2;
using TachHoTen;

namespace Calculator___lv_Medium
{
    public partial class frmTongHop : Form
    {
        public frmTongHop()
        {
            InitializeComponent();
        }

        private void mnuTongHop_Calculator_Click(object sender, EventArgs e)
        {
            frmHoaCalculator form = new frmHoaCalculator();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuTongHop_PTB2_Click(object sender, EventArgs e)
        {
            frmPTBac2 form = new frmPTBac2();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuTongHop_TachHoTen_Click(object sender, EventArgs e)
        {
            frmTachHoTen form = new frmTachHoTen();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuTongHop_Calculator_Click_1(object sender, EventArgs e)
        {
            frmCalculator form = new frmCalculator();
            form.MdiParent = this;
            form.Show();
        }
    }
}
