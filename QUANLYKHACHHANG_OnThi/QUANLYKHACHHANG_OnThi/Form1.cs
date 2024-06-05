using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHHANG_OnThi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dSKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DanhSachKhachHang"] == null)
            {
                frm_DanhSachKhachHang sv = new frm_DanhSachKhachHang();
                sv.MdiParent = this;
                sv.Show();
            }
            else
            {
                Application.OpenForms["frm_DanhSachKhachHang"].Activate();
            }
        }
    }
}
