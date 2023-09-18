namespace QLLaoDong
{
    partial class frmThemCongTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemCongTrinh));
            this.lvwCT = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.txtDCCT = new System.Windows.Forms.TextBox();
            this.txtNgayCP = new System.Windows.Forms.TextBox();
            this.txtNgayKC = new System.Windows.Forms.TextBox();
            this.txtNgayHT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwCT
            // 
            this.lvwCT.Location = new System.Drawing.Point(12, 51);
            this.lvwCT.Name = "lvwCT";
            this.lvwCT.Size = new System.Drawing.Size(1063, 287);
            this.lvwCT.TabIndex = 0;
            this.lvwCT.UseCompatibleStateImageBehavior = false;
            this.lvwCT.SelectedIndexChanged += new System.EventHandler(this.lvwCT_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1084, 48);
            this.label10.TabIndex = 23;
            this.label10.Text = "THÊM CÔNG TRÌNH";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã công trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên công trình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Địa điểm CT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày cấp giấy phép";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ngày khởi công";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ngày hoàn thành";
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(260, 29);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(399, 30);
            this.txtMaCT.TabIndex = 25;
            this.txtMaCT.TextChanged += new System.EventHandler(this.txtMaCT_TextChanged);
            // 
            // txtTenCT
            // 
            this.txtTenCT.Location = new System.Drawing.Point(260, 65);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(399, 30);
            this.txtTenCT.TabIndex = 25;
            this.txtTenCT.TextChanged += new System.EventHandler(this.txtMaCT_TextChanged);
            // 
            // txtDCCT
            // 
            this.txtDCCT.Location = new System.Drawing.Point(260, 103);
            this.txtDCCT.Name = "txtDCCT";
            this.txtDCCT.Size = new System.Drawing.Size(399, 30);
            this.txtDCCT.TabIndex = 25;
            this.txtDCCT.TextChanged += new System.EventHandler(this.txtMaCT_TextChanged);
            // 
            // txtNgayCP
            // 
            this.txtNgayCP.Location = new System.Drawing.Point(260, 144);
            this.txtNgayCP.Name = "txtNgayCP";
            this.txtNgayCP.Size = new System.Drawing.Size(399, 30);
            this.txtNgayCP.TabIndex = 25;
            this.txtNgayCP.TextChanged += new System.EventHandler(this.txtMaCT_TextChanged);
            // 
            // txtNgayKC
            // 
            this.txtNgayKC.Location = new System.Drawing.Point(260, 183);
            this.txtNgayKC.Name = "txtNgayKC";
            this.txtNgayKC.Size = new System.Drawing.Size(399, 30);
            this.txtNgayKC.TabIndex = 25;
            this.txtNgayKC.TextChanged += new System.EventHandler(this.txtMaCT_TextChanged);
            // 
            // txtNgayHT
            // 
            this.txtNgayHT.Location = new System.Drawing.Point(260, 224);
            this.txtNgayHT.Name = "txtNgayHT";
            this.txtNgayHT.Size = new System.Drawing.Size(399, 30);
            this.txtNgayHT.TabIndex = 25;
            this.txtNgayHT.TextChanged += new System.EventHandler(this.txtMaCT_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgayHT);
            this.groupBox1.Controls.Add(this.txtNgayKC);
            this.groupBox1.Controls.Add(this.txtNgayCP);
            this.groupBox1.Controls.Add(this.txtDCCT);
            this.groupBox1.Controls.Add(this.txtTenCT);
            this.groupBox1.Controls.Add(this.txtMaCT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 266);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin công trình";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(861, 555);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 50);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(861, 353);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 50);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(861, 452);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 50);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmThemCongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 617);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lvwCT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThemCongTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm công trình";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThemCongTrinh_FormClosing);
            this.Load += new System.EventHandler(this.frmThemCongTrinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwCT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.TextBox txtDCCT;
        private System.Windows.Forms.TextBox txtNgayCP;
        private System.Windows.Forms.TextBox txtNgayKC;
        private System.Windows.Forms.TextBox txtNgayHT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
    }
}