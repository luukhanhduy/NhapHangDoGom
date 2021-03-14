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
    public partial class FormDanhMucSP : Form
    {
        private string link = @"Data Source=DESKTOP-M1J9ULL\SQLEXPRESS;Initial Catalog=QLNHDQ;Integrated Security=True";
        public FormDanhMucSP()
        {
            InitializeComponent();
        }

        private void FormDanhMucSP_Load(object sender, EventArgs e)
        {
            loadform();
        }

        public void loadform()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "sp_DMSP";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comm);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
