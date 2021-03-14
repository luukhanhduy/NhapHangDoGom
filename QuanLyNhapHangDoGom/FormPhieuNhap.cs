using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhapHangDoGom
{
    public partial class FormPhieuNhap : Form
    {
        string idNv = "";
        string nameNv = "";
       
        public FormPhieuNhap(string id, string nameNv)
        {
            this.idNv = id;
            this.nameNv = nameNv;
            InitializeComponent();
        }
        private string link = @"Data Source=DESKTOP-M1J9ULL\SQLEXPRESS;Initial Catalog=QLNHDQ;Integrated Security=True";

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            reset();
        }
        public void loadform()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "sp_PhieuNhap";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comm);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    conn.Close();
                    dataGridViewPhieuNhap.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkA = false, checkF = false;
        private void reset()
        {
            txtMaPN.Enabled = false;
            DateTime now = DateTime.Now;
            txtNgayLap.Text = now.ToString();
            txtMaNv.Text = idNv;
            txtTenNv.Text = nameNv;
            loadform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    string idPhieuNhap ="";
                    conn.Open();
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "sp_ThemPhieuNhap1";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.AddWithValue("@idPhieuNhap", int.Parse(txtMaPN.Text));
                    comm.Parameters.AddWithValue("@sNgayNhap", txtNgayLap.Text);
                    comm.Parameters.AddWithValue("@idNhanVien", int.Parse(txtMaNv.Text));
                    comm.Parameters.AddWithValue("@sTenNv", txtTenNv.Text);
                    SqlDataReader dr = comm.ExecuteReader();
                    
                    int ire = comm.ExecuteNonQuery();
                    if (ire < 1)
                    {
                        MessageBox.Show("Thêm mới thất bại");
                        reset();
                        checkA = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thành công");
                        reset();
                        checkA = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormCTPhieuNhap formCTPhieuNhap = new FormCTPhieuNhap(idNv, nameNv, idPhieuNhap);
            formCTPhieuNhap.Show();
        }
    }
}
