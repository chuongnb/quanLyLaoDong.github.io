namespace QLLaoDong
{
    partial class frmQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanVien));
            this.radPhongBan = new System.Windows.Forms.RadioButton();
            this.lvvDanhSach = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtLienHe = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboCongTrinh = new System.Windows.Forms.ComboBox();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.radCongTrinh = new System.Windows.Forms.RadioButton();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.btnThemPB = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPhongBan
            // 
            this.radPhongBan.AutoSize = true;
            this.radPhongBan.Location = new System.Drawing.Point(40, 33);
            this.radPhongBan.Name = "radPhongBan";
            this.radPhongBan.Size = new System.Drawing.Size(130, 29);
            this.radPhongBan.TabIndex = 12;
            this.radPhongBan.Text = "Phòng Ban";
            this.radPhongBan.UseVisualStyleBackColor = true;
            this.radPhongBan.CheckedChanged += new System.EventHandler(this.radPhongBan_CheckedChanged);
            // 
            // lvvDanhSach
            // 
            this.lvvDanhSach.Location = new System.Drawing.Point(10, 63);
            this.lvvDanhSach.Name = "lvvDanhSach";
            this.lvvDanhSach.Size = new System.Drawing.Size(842, 391);
            this.lvvDanhSach.TabIndex = 20;
            this.lvvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lvvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lvvDanhSach_SelectedIndexChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(307, 192);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(58, 29);
            this.radNu.TabIndex = 2;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.radNu_CheckedChanged);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(192, 194);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(74, 29);
            this.radNam.TabIndex = 2;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNu_CheckedChanged);
            // 
            // txtLienHe
            // 
            this.txtLienHe.Location = new System.Drawing.Point(192, 241);
            this.txtLienHe.Name = "txtLienHe";
            this.txtLienHe.Size = new System.Drawing.Size(274, 30);
            this.txtLienHe.TabIndex = 1;
            this.txtLienHe.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(192, 141);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(274, 30);
            this.txtNgaySinh.TabIndex = 1;
            this.txtNgaySinh.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboCongTrinh);
            this.groupBox2.Controls.Add(this.cboPhongBan);
            this.groupBox2.Controls.Add(this.radPhongBan);
            this.groupBox2.Controls.Add(this.radCongTrinh);
            this.groupBox2.Controls.Add(this.btnThemCT);
            this.groupBox2.Controls.Add(this.btnThemPB);
            this.groupBox2.Location = new System.Drawing.Point(10, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 187);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc theo";
            // 
            // cboCongTrinh
            // 
            this.cboCongTrinh.FormattingEnabled = true;
            this.cboCongTrinh.Location = new System.Drawing.Point(296, 65);
            this.cboCongTrinh.Name = "cboCongTrinh";
            this.cboCongTrinh.Size = new System.Drawing.Size(218, 33);
            this.cboCongTrinh.TabIndex = 18;
            this.cboCongTrinh.SelectedIndexChanged += new System.EventHandler(this.cboCT_SelectedIndexChanged);
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(40, 68);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(218, 33);
            this.cboPhongBan.TabIndex = 13;
            this.cboPhongBan.SelectedIndexChanged += new System.EventHandler(this.cboPhongBan_SelectedIndexChanged);
            // 
            // radCongTrinh
            // 
            this.radCongTrinh.AutoSize = true;
            this.radCongTrinh.Checked = true;
            this.radCongTrinh.Location = new System.Drawing.Point(296, 30);
            this.radCongTrinh.Name = "radCongTrinh";
            this.radCongTrinh.Size = new System.Drawing.Size(123, 29);
            this.radCongTrinh.TabIndex = 10;
            this.radCongTrinh.TabStop = true;
            this.radCongTrinh.Text = "Công trình";
            this.radCongTrinh.UseVisualStyleBackColor = true;
            this.radCongTrinh.CheckedChanged += new System.EventHandler(this.radPhongBan_CheckedChanged);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCT.Location = new System.Drawing.Point(296, 120);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(218, 50);
            this.btnThemCT.TabIndex = 17;
            this.btnThemCT.Text = "Thêm công trình";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnThemPB
            // 
            this.btnThemPB.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPB.Image")));
            this.btnThemPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPB.Location = new System.Drawing.Point(40, 120);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(218, 50);
            this.btnThemPB.TabIndex = 17;
            this.btnThemPB.Text = "Thêm phòng ban";
            this.btnThemPB.UseVisualStyleBackColor = true;
            this.btnThemPB.Click += new System.EventHandler(this.btnThemPB_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(192, 50);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(274, 30);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(192, 94);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(274, 30);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(42, 339);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(138, 25);
            this.lable.TabIndex = 0;
            this.lable.Text = "Mã phòng ban";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã công trình";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1168, 483);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 50);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1026, 483);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(127, 50);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.txtMaPB);
            this.groupBox1.Controls.Add(this.txtMaCT);
            this.groupBox1.Controls.Add(this.txtLienHe);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lable);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(858, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 401);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(192, 334);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(274, 30);
            this.txtMaPB.TabIndex = 1;
            this.txtMaPB.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(192, 287);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(274, 30);
            this.txtMaCT.TabIndex = 1;
            this.txtMaCT.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Liên hệ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(878, 483);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 50);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(712, 483);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 50);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1350, 48);
            this.label10.TabIndex = 22;
            this.label10.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 672);
            this.Controls.Add(this.lvvDanhSach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radPhongBan;
        private System.Windows.Forms.ListView lvvDanhSach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtLienHe;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.RadioButton radCongTrinh;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCongTrinh;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtMaCT;
    }
}