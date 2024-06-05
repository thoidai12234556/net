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
    public partial class frm_DanhSachKhachHang : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_DanhSachKhachHang()
        {
            InitializeComponent();
        }

        //Load LoaiKhachHang lên
        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            loadKhachHang();
            string sql = "Select * from LOAIKHACH";
            cb_LoaiKhach.DataSource = lopchung.LoadDL(sql);
            cb_LoaiKhach.DisplayMember = "LOAIKHACH";
            cb_LoaiKhach.ValueMember = "IDLOAIKHACH";
        }

        public void loadKhachHang()
        {
            string sql = "Select * from KHACHHANG";
            dataGridView_DanhSach.DataSource = lopchung.LoadDL(sql);
        }
        

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KHACHHANG values (N'" + txt_IdKhachHang.Text + "', '" + dtp_NgaySinh.Value.ToString("yyyy-MM-dd") + "' ,N'" + txt_HoTen.Text + "', N'" + txt_DiaChi.Text + "' ,N'" + cb_LoaiKhach.SelectedValue + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm Khách thành công");
            else MessageBox.Show("Thêm Khách thất bại");
            loadKhachHang();
        }
        
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete KHACHHANG where IDKHACHHANG = N'" + txt_IdKhachHang.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xoá Khách thành công");
            else MessageBox.Show("Xoá Khách thất bại");
            loadKhachHang();
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update KHACHHANG set NGAYSINH = '" + dtp_NgaySinh.Value.ToString("yyyy-MM-dd") +
             "', HOTEN = N'" + txt_HoTen.Text + "', DIACHI = N'" + txt_DiaChi.Text + "', IDLOAIKHACH = '" + cb_LoaiKhach.SelectedValue + "' where IDKHACHHANG = N'" + txt_IdKhachHang.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật Khách thành công");
            else MessageBox.Show("Cập nhật Khách thất bại");
            loadKhachHang();
        }

        private void dataGridView_DanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdKhachHang.Text = dataGridView_DanhSach.CurrentRow.Cells["IDKHACHHANG"].Value.ToString();
            txt_HoTen.Text = dataGridView_DanhSach.CurrentRow.Cells["HOTEN"].Value.ToString();
            //Ngày sinh
            dtp_NgaySinh.Value = Convert.ToDateTime(dataGridView_DanhSach.CurrentRow.Cells["NGAYSINH"].Value);
            cb_LoaiKhach.SelectedValue = dataGridView_DanhSach.CurrentRow.Cells["IDLOAIKHACH"].Value.ToString();
            txt_DiaChi.Text = dataGridView_DanhSach.CurrentRow.Cells["DIACHI"].Value.ToString();
            loadKhachHang();
        }
        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không ?", "Cảnh Báo!", MessageBoxButtons.YesNo);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
















        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_IdKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
