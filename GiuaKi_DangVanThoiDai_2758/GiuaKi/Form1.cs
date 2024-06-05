using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiuaKi
{
    public partial class Form1 : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadMon()
        {
            string sql = "Select * from SanPham1";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into SanPham1 values (N'" + txt_MaMon.Text + "',N'" + txt_TenMon.Text + "',N'" + cb_TenDanhMuc.SelectedValue + "','" + txt_GiaTien.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm Món thành công");
            else MessageBox.Show("Thêm Món thất bại");
            LoadMon();
        }

        //Load TenDanhMuc lên
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMon();
            string sql = "Select * from DanhMuc";
            cb_TenDanhMuc.DataSource = lopchung.LoadDL(sql);
            cb_TenDanhMuc.DisplayMember = "TenDanhMuc";
            cb_TenDanhMuc.ValueMember = "MaDanhMuc";
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete SanPham1 where MaMon = N'" + txt_MaMon.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xoá Món thành công");
            else MessageBox.Show("Xoá Món thất bại");
            LoadMon();
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update SanPham1 set TenMon = N'" + txt_TenMon.Text + "', GiaTien = N'" + txt_GiaTien.Text + "', MaDanhMuc = '" + cb_TenDanhMuc.SelectedValue + "' where MaMon = N'" + txt_MaMon.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật Món thành công");
            else MessageBox.Show("Cập nhật Món thất bại");
            LoadMon();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaMon.Text = dataGridView1.CurrentRow.Cells["MaMon"].Value.ToString();
            txt_TenMon.Text = dataGridView1.CurrentRow.Cells["TenMon"].Value.ToString();
            cb_TenDanhMuc.SelectedValue = dataGridView1.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
            txt_GiaTien.Text = dataGridView1.CurrentRow.Cells["GiaTien"].Value.ToString();
            LoadMon();
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_SoLuong.Text, out int soLuong))
            {
                if (decimal.TryParse(txt_GiaTien.Text, out decimal giaTien))
                {
                    decimal tongTien = soLuong * giaTien;
                    txt_TinhTien.Text = tongTien.ToString();
                }
                else
                {
                    MessageBox.Show("Giá tiền không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
