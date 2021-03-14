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
    public partial class FormCTPhieuNhap : Form
    {
        string idNv = "";
        string nameNv = "";
        string idPhieu = "";
        public FormCTPhieuNhap(string idNv, string nameNv, string idPhieu)
        {
            idNv = this.idNv;
            nameNv = this.nameNv;
            idPhieu = this.idPhieu;
            InitializeComponent();
        }
        private string link = @"Data Source=DESKTOP-M1J9ULL\SQLEXPRESS;Initial Catalog=QLNHDQ;Integrated Security=True";
        public void loadform()
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "sp_CTPhieuNhap";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comm);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    conn.Close();
                    dataGridViewCTPhieuNhap.DataSource = dataTable;
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
            txtMasp.Text = idPhieu; 
            loadform();
        }

        private void FormCTPhieuNhap_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "sp_ThemCTPhieuNhap";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.AddWithValue("@idChiTietPhieuNhap", int.Parse(txtMaCT.Text));
                    comm.Parameters.AddWithValue("@idPhieuNhap", int.Parse(txtMasp.Text));
                    comm.Parameters.AddWithValue("@idSanPham", int.Parse(txtMasp.Text));
                    comm.Parameters.AddWithValue("@idPhieuNhap", int.Parse(txtMasp.Text));
                    comm.Parameters.AddWithValue("@idPhieuNhap", int.Parse(txtMasp.Text));
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
        }
    }
}
