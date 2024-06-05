
namespace QUANLYKHACHHANG_OnThi
{
    partial class frm_DanhSachKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.dataGridView_DanhSach = new System.Windows.Forms.DataGridView();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.cb_LoaiKhach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Khách Hàng";
            // 
            // txt_IdKhachHang
            // 
            this.txt_IdKhachHang.Location = new System.Drawing.Point(367, 55);
            this.txt_IdKhachHang.Name = "txt_IdKhachHang";
            this.txt_IdKhachHang.Size = new System.Drawing.Size(375, 22);
            this.txt_IdKhachHang.TabIndex = 1;
            this.txt_IdKhachHang.TextChanged += new System.EventHandler(this.txt_IdKhachHang_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Sinh";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(367, 150);
            this.dtp_NgaySinh.MaxDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(375, 22);
            this.dtp_NgaySinh.TabIndex = 7;
            this.dtp_NgaySinh.Value = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.dtp_NgaySinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loại Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "DANH SÁCH KHÁCH HÀNG";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa Chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(367, 226);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(375, 83);
            this.txt_DiaChi.TabIndex = 12;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(53, 346);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 42);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(241, 346);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 42);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(459, 346);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 42);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(667, 346);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(98, 42);
            this.btn_Dong.TabIndex = 16;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // dataGridView_DanhSach
            // 
            this.dataGridView_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhSach.Location = new System.Drawing.Point(53, 415);
            this.dataGridView_DanhSach.Name = "dataGridView_DanhSach";
            this.dataGridView_DanhSach.RowHeadersWidth = 51;
            this.dataGridView_DanhSach.RowTemplate.Height = 24;
            this.dataGridView_DanhSach.Size = new System.Drawing.Size(712, 150);
            this.dataGridView_DanhSach.TabIndex = 17;
            this.dataGridView_DanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DanhSach_CellContentClick);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(367, 99);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(375, 22);
            this.txt_HoTen.TabIndex = 18;
            // 
            // cb_LoaiKhach
            // 
            this.cb_LoaiKhach.FormattingEnabled = true;
            this.cb_LoaiKhach.Location = new System.Drawing.Point(367, 189);
            this.cb_LoaiKhach.Name = "cb_LoaiKhach";
            this.cb_LoaiKhach.Size = new System.Drawing.Size(375, 24);
            this.cb_LoaiKhach.TabIndex = 19;
            // 
            // frm_DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 592);
            this.Controls.Add(this.cb_LoaiKhach);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.dataGridView_DanhSach);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_IdKhachHang);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "frm_DanhSachKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.DanhSachKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.DataGridView dataGridView_DanhSach;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.ComboBox cb_LoaiKhach;
    }
}