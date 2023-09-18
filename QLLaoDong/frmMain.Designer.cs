namespace QLLaoDong
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnThongTinNhom = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDSNV = new System.Windows.Forms.Button();
            this.bntQLNV = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.TabControl();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.btnExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage3.Controls.Add(this.btnThongTinNhom);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1301, 47);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thông tin";
            // 
            // btnThongTinNhom
            // 
            this.btnThongTinNhom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongTinNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinNhom.Image")));
            this.btnThongTinNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinNhom.Location = new System.Drawing.Point(3, 2);
            this.btnThongTinNhom.Name = "btnThongTinNhom";
            this.btnThongTinNhom.Size = new System.Drawing.Size(212, 45);
            this.btnThongTinNhom.TabIndex = 6;
            this.btnThongTinNhom.Text = "Thông tin nhóm";
            this.btnThongTinNhom.UseVisualStyleBackColor = false;
            this.btnThongTinNhom.Click += new System.EventHandler(this.btnThongTinNhom_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Controls.Add(this.btnThoat);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1301, 47);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hệ thống";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(3, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 45);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.btnThongKe);
            this.tabPage1.Controls.Add(this.btnDSNV);
            this.tabPage1.Controls.Add(this.bntQLNV);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1301, 47);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chức năng chính";
            // 
            // btnDSNV
            // 
            this.btnDSNV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDSNV.Image = ((System.Drawing.Image)(resources.GetObject("btnDSNV.Image")));
            this.btnDSNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSNV.Location = new System.Drawing.Point(240, 3);
            this.btnDSNV.Name = "btnDSNV";
            this.btnDSNV.Size = new System.Drawing.Size(307, 45);
            this.btnDSNV.TabIndex = 6;
            this.btnDSNV.Text = "Danh sách tất cả nhân viên";
            this.btnDSNV.UseVisualStyleBackColor = false;
            this.btnDSNV.Click += new System.EventHandler(this.btnDSNV_Click);
            // 
            // bntQLNV
            // 
            this.bntQLNV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntQLNV.Image = ((System.Drawing.Image)(resources.GetObject("bntQLNV.Image")));
            this.bntQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntQLNV.Location = new System.Drawing.Point(6, 3);
            this.bntQLNV.Name = "bntQLNV";
            this.bntQLNV.Size = new System.Drawing.Size(228, 45);
            this.bntQLNV.TabIndex = 6;
            this.bntQLNV.Text = "Quản lý nhân viên";
            this.bntQLNV.UseVisualStyleBackColor = false;
            this.bntQLNV.Click += new System.EventHandler(this.bntQLNV_Click);
            // 
            // btnExit
            // 
            this.btnExit.Controls.Add(this.tabPage1);
            this.btnExit.Controls.Add(this.tabPage2);
            this.btnExit.Controls.Add(this.tabPage3);
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.SelectedIndex = 0;
            this.btnExit.Size = new System.Drawing.Size(1309, 85);
            this.btnExit.TabIndex = 4;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(553, 3);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(186, 45);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1309, 725);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Quản lý lao động";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.btnExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnThongTinNhom;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDSNV;
        private System.Windows.Forms.Button bntQLNV;
        private System.Windows.Forms.TabControl btnExit;
        private System.Windows.Forms.Button btnThongKe;
    }
}