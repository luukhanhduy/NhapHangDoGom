using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhapHangDoGom
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        //private string link = @"Data Source=DESKTOP-M1J9ULL\SQLEXPRESS;Initial Catalog=QLNHDQ;Integrated Security=True";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M1J9ULL\SQLEXPRESS;Initial Catalog=QLNHDQ;Integrated Security=True");
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "sp_DangNhap4";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.AddWithValue("@sUsername", txtTaiKhoan.Text);
                    comm.Parameters.AddWithValue("@sPassword", txtMatKhau.Text);
                    SqlDataReader dr = comm.ExecuteReader();
                    string idNv = "";
                    string nameNv = "";
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idNv = dr["idNhanVien"].ToString();
                            nameNv = dr["sTenNv"].ToString();
                        }
                        this.Hide();
                        MessageBox.Show("Đăng nhập thành công");
                        FormMatHang mathang = new FormMatHang(idNv, nameNv);
                        mathang.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                        txtTaiKhoan.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}
        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình??", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
