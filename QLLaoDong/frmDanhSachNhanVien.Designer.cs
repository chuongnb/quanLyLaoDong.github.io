namespace QLLaoDong
{
    partial class frmDanhSachNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachNhanVien));
            this.lvwDS = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTheoTen = new System.Windows.Forms.RadioButton();
            this.radTheoMaNV = new System.Windows.Forms.RadioButton();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radTimTen = new System.Windows.Forms.RadioButton();
            this.radTimMa = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwDS
            // 
            this.lvwDS.Location = new System.Drawing.Point(22, 62);
            this.lvwDS.Name = "lvwDS";
            this.lvwDS.Size = new System.Drawing.Size(1156, 307);
            this.lvwDS.TabIndex = 24;
            this.lvwDS.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 51);
            this.label1.TabIndex = 23;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Từ khóa";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(156, 73);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(215, 30);
            this.txtTuKhoa.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTheoTen);
            this.groupBox1.Controls.Add(this.radTheoMaNV);
            this.groupBox1.Controls.Add(this.btnTang);
            this.groupBox1.Controls.Add(this.btnGiam);
            this.groupBox1.Location = new System.Drawing.Point(10, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 142);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sắp xếp";
            // 
            // radTheoTen
            // 
            this.radTheoTen.AutoSize = true;
            this.radTheoTen.Location = new System.Drawing.Point(241, 41);
            this.radTheoTen.Name = "radTheoTen";
            this.radTheoTen.Size = new System.Drawing.Size(111, 29);
            this.radTheoTen.TabIndex = 19;
            this.radTheoTen.TabStop = true;
            this.radTheoTen.Text = "Theo tên";
            this.radTheoTen.UseVisualStyleBackColor = true;
            this.radTheoTen.CheckedChanged += new System.EventHandler(this.radTheoLH_CheckedChanged);
            // 
            // radTheoMaNV
            // 
            this.radTheoMaNV.AutoSize = true;
            this.radTheoMaNV.Location = new System.Drawing.Point(34, 41);
            this.radTheoMaNV.Name = "radTheoMaNV";
            this.radTheoMaNV.Size = new System.Drawing.Size(144, 29);
            this.radTheoMaNV.TabIndex = 19;
            this.radTheoMaNV.TabStop = true;
            this.radTheoMaNV.Text = "Theo mã NV";
            this.radTheoMaNV.UseVisualStyleBackColor = true;
            this.radTheoMaNV.CheckedChanged += new System.EventHandler(this.radTheoLH_CheckedChanged);
            // 
            // btnTang
            // 
            this.btnTang.Image = ((System.Drawing.Image)(resources.GetObject("btnTang.Image")));
            this.btnTang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTang.Location = new System.Drawing.Point(34, 73);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(125, 50);
            this.btnTang.TabIndex = 18;
            this.btnTang.Text = "Tăng";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Image = ((System.Drawing.Image)(resources.GetObject("btnGiam.Image")));
            this.btnGiam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiam.Location = new System.Drawing.Point(241, 73);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(132, 50);
            this.btnGiam.TabIndex = 18;
            this.btnGiam.Text = "Giảm";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.radTimTen);
            this.groupBox2.Controls.Add(this.radTimMa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTuKhoa);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(453, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 142);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(576, 53);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 50);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // radTimTen
            // 
            this.radTimTen.AutoSize = true;
            this.radTimTen.Location = new System.Drawing.Point(5, 79);
            this.radTimTen.Name = "radTimTen";
            this.radTimTen.Size = new System.Drawing.Size(111, 29);
            this.radTimTen.TabIndex = 21;
            this.radTimTen.TabStop = true;
            this.radTimTen.Text = "Theo tên";
            this.radTimTen.UseVisualStyleBackColor = true;
            this.radTimTen.CheckedChanged += new System.EventHandler(this.radTimMa_CheckedChanged);
            // 
            // radTimMa
            // 
            this.radTimMa.AutoSize = true;
            this.radTimMa.Location = new System.Drawing.Point(5, 44);
            this.radTimMa.Name = "radTimMa";
            this.radTimMa.Size = new System.Drawing.Size(111, 29);
            this.radTimMa.TabIndex = 21;
            this.radTimMa.TabStop = true;
            this.radTimMa.Text = "Theo mã";
            this.radTimMa.UseVisualStyleBackColor = true;
            this.radTimMa.CheckedChanged += new System.EventHandler(this.radTimMa_CheckedChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(387, 54);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(170, 50);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 538);
            this.Controls.Add(this.lvwDS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDanhSachNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhSachNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmDanhSachNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radTimTen;
        private System.Windows.Forms.RadioButton radTimMa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton radTheoMaNV;
        private System.Windows.Forms.RadioButton radTheoTen;
    }
}