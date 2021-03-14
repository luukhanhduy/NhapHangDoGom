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
using System.IO;

namespace QuanLyNhapHangDoGom
{
    public partial class FormMatHang : Form

    {
        string idNv = "";
        string nameNv = "";
        string idPhieuNhap = "";

        public FormMatHang(string id, string name)
        {
            this.idNv = id;
            this.nameNv = name;
            InitializeComponent();
        }
        private string link = @"Data Source=DESKTOP-M1J9ULL\SQLEXPRESS;Initial Catalog=QLNHDQ;Integrated Security=True";

        private void FormMatHang_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = conn;
                    comm.CommandText = "select sTenDanhMucSanPham as name from tbl_DanhMucSanPham";
                    comm.CommandType = CommandType.Text;
                    SqlDataReader dr = comm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            data.Add(dr["name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtDMSP.AutoCompleteCustomSource = data;
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
                    comm.CommandText = "sp_SanPham";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comm);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    conn.Close();
                    dataGridViewSanPham.DataSource = dataTable;
                    this.dataGridViewSanPham.Columns["sAnh"].Visible = false;
                    this.dataGridViewSanPham.Columns["idDanhMucSanPham"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dataGridViewSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private bool checkA = false, checkF = false;
        //private object dataGridView1;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkA == false)
            {
                checkA = true;

                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                txtTensp.Enabled = true;
                txtMoTa.Enabled = true;
                txtGia.Enabled = true;
                txtSoLuong.Enabled = true;
                txtDMSP.Enabled = true;
                txtDonViTinh.Enabled = true;

                txtTensp.Text = string.Empty;
                txtMoTa.Text = string.Empty;
                txtGia.Text = string.Empty;
                txtSoLuong.Text = string.Empty;
                txtDMSP.Text = string.Empty;
                txtDonViTinh.Text = string.Empty;

                txtTensp.Focus();
            }
            else
            {
                txtMasp.Enabled = false;
                try
                {
                    string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    if (!File.Exists(path + "\\image\\" + filename))
                    {
                        System.IO.File.Copy(openFileDialog1.FileName, path + "\\image\\" + filename);
                    }
                    using (SqlConnection conn = new SqlConnection(link))
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand();
                        comm.CommandText = "sp_ThemSp3";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Connection = conn;
                        comm.Parameters.AddWithValue("@sTenSanPham", txtTensp.Text);
                        comm.Parameters.AddWithValue("@sMoTa", txtMoTa.Text);
                        comm.Parameters.AddWithValue("@fGiaBan", float.Parse(txtGia.Text));
                        comm.Parameters.AddWithValue("@iSoLuong", int.Parse(txtSoLuong.Text));
                        comm.Parameters.AddWithValue("@sDonViTinh", txtDonViTinh.Text);
                        comm.Parameters.AddWithValue("@sTenDanhMucSanPham", txtDMSP.Text);
                        //comm.Parameters.AddWithValue("@sTenDanhMucSanPham", );
                        comm.Parameters.AddWithValue("@sAnh", path + "\\image\\" + filename);
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
        private void reset()
        {
            txtMasp.Enabled = false;
            txtTensp.Enabled = false;
            txtMoTa.Enabled = false;
            txtGia.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDMSP.Enabled = false;
            txtDonViTinh.Enabled = false;
            dataGridViewSanPham.Enabled = true;
            loadform();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnReset.Enabled = true;
            checkA = false;
            btnSua.Enabled = true;
            checkF = false;
            txtTimKiem.Text = "Tìm Kiếm Theo Mã Sản Phẩm";
            txtTensp.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkF == false)
            {
                checkF = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                txtGia.Enabled = true;
                txtSoLuong.Enabled = true;
                txtTensp.Enabled = true;
                txtMoTa.Enabled = true;
                txtDMSP.Enabled = true;
                txtDonViTinh.Enabled = true;
                //txtMasp = 
            }
            else
            {
                txtMasp.Enabled = false;
                try
                {
                    string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    if (!File.Exists(path + "\\image\\" + filename))
                    {
                        System.IO.File.Copy(openFileDialog1.FileName, path + "\\image\\" + filename);
                    }
                    using (SqlConnection conn = new SqlConnection(link))
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand();
                        comm.CommandText = "sp_UpdateSp1";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Connection = conn;
                        comm.Parameters.AddWithValue("@idSanPham", int.Parse(txtMasp.Text));
                        comm.Parameters.AddWithValue("@fGiaBan", float.Parse(txtGia.Text));
                        comm.Parameters.AddWithValue("@iSoLuong", int.Parse(txtSoLuong.Text));
                        comm.Parameters.AddWithValue("@sTenSp", txtTensp.Text);
                        comm.Parameters.AddWithValue("@sMota", txtMoTa.Text);
                        comm.Parameters.AddWithValue("@tendmsp", txtDMSP.Text);
                        comm.Parameters.AddWithValue("@sAnh", path + "\\image\\" + filename);
                        int ire = comm.ExecuteNonQuery();
                        if (ire < 1)
                        {
                            MessageBox.Show("Sửa thông tin sản phẩm không thành công");
                            reset();
                            checkF = false;
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin sản phẩm thành công");
                            reset();
                            checkF = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa sản phẩm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(link))
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand();
                        comm.CommandText = "sp_XoaSp";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Connection = conn;
                        comm.Parameters.AddWithValue("@idSanPham", int.Parse(txtMasp.Text));
                        int ire = comm.ExecuteNonQuery();
                        if (ire < 1)
                        {
                            MessageBox.Show("Xóa sản phẩm không thành công");
                            reset();
                        }
                        else
                        {
                            MessageBox.Show("Xóa sản phẩm thành công");
                            reset();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không xóa sản phẩm");
            }

        }

        private void dataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewSanPham.Rows[e.RowIndex];
                txtMasp.Text = row.Cells[0].Value.ToString();
                txtTensp.Text = row.Cells[1].Value.ToString();
                txtMoTa.Text = row.Cells[2].Value.ToString();
                txtGia.Text = row.Cells[3].Value.ToString();
                txtSoLuong.Text = row.Cells[4].Value.ToString();
                txtDMSP.Text = row.Cells[7].Value.ToString();
                txtDonViTinh.Text = row.Cells[5].Value.ToString();
                pictureBox1.Image = new Bitmap(row.Cells[7].Value.ToString());
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                /*if (row.Cells[7].Value.ToString() == "" || row.Cells[7].Value.ToString() == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    pictureBox1.Image = new Bitmap(row.Cells[7].Value.ToString());
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }*/
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FormPhieuNhap formPhieuNhap = new FormPhieuNhap(idNv, nameNv);
            formPhieuNhap.Show();
        }

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCTPhieuNhap formCTPhieuNhap = new FormCTPhieuNhap(idNv, nameNv, idPhieuNhap);
            formCTPhieuNhap.Show();
        }

        private void danhMucSanPhamtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhMucSP formDanhMucSP = new FormDanhMucSP();
            formDanhMucSP.Show();
        }

        /*private void txtTim_Enter(object sender, EventArgs e)
        {

        }*/

        private void timKiem()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "sp_ChonSP";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.AddWithValue("@idSanPham", int.Parse(txtTimKiem.Text));
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comm);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    conn.Close();
                    dataGridViewSanPham.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm Kiếm Theo Mã Sản Phẩm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm Kiếm";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                timKiem();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select image to be upload.";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                    pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormThongKe formThongKe = new FormThongKe();
            formThongKe.Show();
        }

        /*private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }*/

        private void dataGridViewSanPham_RowStateChanged_1(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridViewSanPham.SelectedRows.Count != 0)
            {
                txtMasp.Text = dataGridViewSanPham.SelectedRows[0].Cells[1].Value.ToString();
                txtTensp.Text = dataGridViewSanPham.SelectedRows[0].Cells[2].Value.ToString();
                txtMoTa.Text = dataGridViewSanPham.SelectedRows[0].Cells[3].Value.ToString();
                txtGia.Text = dataGridViewSanPham.SelectedRows[0].Cells[4].Value.ToString();
                txtSoLuong.Text = dataGridViewSanPham.SelectedRows[0].Cells[5].Value.ToString();
                txtDMSP.Text = dataGridViewSanPham.SelectedRows[0].Cells[8].Value.ToString();
                txtDonViTinh.Text = dataGridViewSanPham.SelectedRows[0].Cells[6].Value.ToString();
                if (dataGridViewSanPham.SelectedRows[0].Cells[7].Value.ToString() == "" || dataGridViewSanPham.SelectedRows[0].Cells[7].Value.ToString() == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    pictureBox1.Image = new Bitmap(dataGridViewSanPham.SelectedRows[0].Cells[7].Value.ToString());
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
