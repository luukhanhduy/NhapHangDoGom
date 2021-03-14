namespace QuanLyNhapHangDoGom
{
    partial class FormPhieuNhap
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
            this.txtTenNv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPhieuNhap = new System.Windows.Forms.DataGridView();
            this.idPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtTenNv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMaNv);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập";
            // 
            // txtTenNv
            // 
            this.txtTenNv.Location = new System.Drawing.Point(122, 107);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(184, 20);
            this.txtTenNv.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên nhân viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMaNv
            // 
            this.txtMaNv.Location = new System.Drawing.Point(122, 76);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(184, 20);
            this.txtMaNv.TabIndex = 6;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(122, 50);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(184, 20);
            this.txtNgayLap.TabIndex = 5;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(122, 22);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(184, 20);
            this.txtMaPN.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // dataGridViewPhieuNhap
            // 
            this.dataGridViewPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPhieuNhap,
            this.sNgayNhap,
            this.idNhanVien,
            this.sTenNv});
            this.dataGridViewPhieuNhap.Location = new System.Drawing.Point(431, 58);
            this.dataGridViewPhieuNhap.Name = "dataGridViewPhieuNhap";
            this.dataGridViewPhieuNhap.Size = new System.Drawing.Size(812, 475);
            this.dataGridViewPhieuNhap.TabIndex = 1;
            // 
            // idPhieuNhap
            // 
            this.idPhieuNhap.DataPropertyName = "idPhieuNhap";
            this.idPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.idPhieuNhap.Name = "idPhieuNhap";
            // 
            // sNgayNhap
            // 
            this.sNgayNhap.DataPropertyName = "sNgayNhap";
            this.sNgayNhap.HeaderText = "Ngày lập";
            this.sNgayNhap.Name = "sNgayNhap";
            // 
            // idNhanVien
            // 
            this.idNhanVien.DataPropertyName = "idNhanVien";
            this.idNhanVien.HeaderText = "Mã nhân viên";
            this.idNhanVien.Name = "idNhanVien";
            // 
            // sTenNv
            // 
            this.sTenNv.DataPropertyName = "sTenNv";
            this.sTenNv.HeaderText = "Tên nhân viên";
            this.sTenNv.Name = "sTenNv";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(431, 32);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(184, 20);
            this.txtTimKiem.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Xem Chi Tiết";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 564);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dataGridViewPhieuNhap);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPhieuNhap";
            this.Text = "Phiếu Nhập";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.DataGridView dataGridViewPhieuNhap;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNv;
        private System.Windows.Forms.Button button2;
    }
}