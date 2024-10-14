namespace De01
{
    partial class frmSinhvien
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.btnKLuu = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(100, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 39);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(494, 17);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 39);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(202, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 39);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(296, 17);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(418, 34);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(210, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(130, 31);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(203, 22);
            this.txtMaSV.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lớp Học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Sinh:";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(418, 82);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(210, 24);
            this.cboLop.TabIndex = 0;
            // 
            // btnKLuu
            // 
            this.btnKLuu.Location = new System.Drawing.Point(395, 17);
            this.btnKLuu.Name = "btnKLuu";
            this.btnKLuu.Size = new System.Drawing.Size(75, 39);
            this.btnKLuu.TabIndex = 4;
            this.btnKLuu.Text = "K.Lưu";
            this.btnKLuu.UseVisualStyleBackColor = true;
            this.btnKLuu.Click += new System.EventHandler(this.btnKLuu_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(166, 171);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 65);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(2, 196);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(158, 22);
            this.txtTim.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Location = new System.Drawing.Point(105, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHI TIẾT";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(130, 79);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(203, 22);
            this.dtNgaySinh.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Sinh Viên:";
            // 
            // dgvSV
            // 
            this.dgvSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvSV.Location = new System.Drawing.Point(65, 252);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.RowHeadersWidth = 51;
            this.dgvSV.RowTemplate.Height = 24;
            this.dgvSV.Size = new System.Drawing.Size(733, 300);
            this.dgvSV.TabIndex = 6;
            this.dgvSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Và Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lớp";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnKLuu);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Location = new System.Drawing.Point(263, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 74);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // frmSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 564);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSV);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmSinhvien";
            this.Text = "DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.frmSinhvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnKLuu;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
    }
}

