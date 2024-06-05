using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GiuaKi
{
    class LOPDUNGCHUNG
    {
        string chuoikn = @"Data Source=LAPTOP-2UUVVHSE\SQLEXPRESS;Initial Catalog=QLCAFE;Integrated Security=True";
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(chuoikn);
        }
        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                // Xử lý ngoại lệ kết nối cơ sở dữ liệu (ví dụ: thông báo lỗi)
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                // Bạn có thể ném lại hoặc xử lý tùy theo yêu cầu của bạn
            }
            return dt;
        }
        public object LayGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
    }
}