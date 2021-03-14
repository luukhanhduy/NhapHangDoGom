namespace QuanLyNhapHangDoGom
{
    partial class FormCTPhieuNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCTPhieuNhap = new System.Windows.Forms.DataGridView();
            this.idChiTietPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.txtSoLuongNhap);
            this.groupBox1.Controls.Add(this.txtMasp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaCT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu nhập";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(259, 217);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(143, 217);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(115, 135);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(197, 20);
            this.txtGiaNhap.TabIndex = 9;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(115, 97);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(197, 20);
            this.txtSoLuongNhap.TabIndex = 8;
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(115, 61);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(197, 20);
            this.txtMasp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã sản phẩm";
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(115, 24);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(197, 20);
            this.txtMaCT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã CT phiếu nhập";
            // 
            // dataGridViewCTPhieuNhap
            // 
            this.dataGridViewCTPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTPhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCTPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idChiTietPhieuNhap,
            this.idPhieuNhap,
            this.idSanPham,
            this.iSoLuongNhap,
            this.fGiaNhap});
            this.dataGridViewCTPhieuNhap.Location = new System.Drawing.Point(426, 57);
            this.dataGridViewCTPhieuNhap.Name = "dataGridViewCTPhieuNhap";
            this.dataGridViewCTPhieuNhap.Size = new System.Drawing.Size(801, 480);
            this.dataGridViewCTPhieuNhap.TabIndex = 1;
            // 
            // idChiTietPhieuNhap
            // 
            this.idChiTietPhieuNhap.DataPropertyName = "idChiTietPhieuNhap";
            this.idChiTietPhieuNhap.HeaderText = "Mã CT phiếu nhập";
            this.idChiTietPhieuNhap.Name = "idChiTietPhieuNhap";
            // 
            // idPhieuNhap
            // 
            this.idPhieuNhap.DataPropertyName = "idPhieuNhap";
            this.idPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.idPhieuNhap.Name = "idPhieuNhap";
            // 
            // idSanPham
            // 
            this.idSanPham.DataPropertyName = "idSanPham";
            this.idSanPham.HeaderText = "Mã sản phẩm";
            this.idSanPham.Name = "idSanPham";
            // 
            // iSoLuongNhap
            // 
            this.iSoLuongNhap.DataPropertyName = "iSoLuongNhap";
            this.iSoLuongNhap.HeaderText = "Số lượng nhập";
            this.iSoLuongNhap.Name = "iSoLuongNhap";
            // 
            // fGiaNhap
            // 
            this.fGiaNhap.DataPropertyName = "fGiaNhap";
            this.fGiaNhap.HeaderText = "Giá nhập";
            this.fGiaNhap.Name = "fGiaNhap";
            // 
            // txtTimK
            // 
            this.txtTimK.Location = new System.Drawing.Point(426, 23);
            this.txtTimK.Name = "txtTimK";
            this.txtTimK.Size = new System.Drawing.Size(197, 20);
            this.txtTimK.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(115, 174);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(197, 20);
            this.txtMaPN.TabIndex = 14;
            // 
            // FormCTPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 565);
            this.Controls.Add(this.txtTimK);
            this.Controls.Add(this.dataGridViewCTPhieuNhap);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCTPhieuNhap";
            this.Text = "Chi Tiết Phiếu Nhập";
            this.Load += new System.EventHandler(this.FormCTPhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewCTPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChiTietPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGiaNhap;
        private System.Windows.Forms.TextBox txtTimK;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label2;
    }
}