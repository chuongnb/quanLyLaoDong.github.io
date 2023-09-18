namespace QLLaoDong
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.chkMK = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMK
            // 
            this.chkMK.AutoSize = true;
            this.chkMK.Checked = true;
            this.chkMK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMK.Location = new System.Drawing.Point(363, 155);
            this.chkMK.Name = "chkMK";
            this.chkMK.Size = new System.Drawing.Size(159, 29);
            this.chkMK.TabIndex = 22;
            this.chkMK.Text = "Hiện mật khẩu";
            this.chkMK.UseVisualStyleBackColor = true;
            this.chkMK.CheckedChanged += new System.EventHandler(this.chkMK_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(237, 208);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(174, 43);
            this.btnDangNhap.TabIndex = 19;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnHuybo
            // 
            this.btnHuybo.Image = ((System.Drawing.Image)(resources.GetObject("btnHuybo.Image")));
            this.btnHuybo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuybo.Location = new System.Drawing.Point(467, 208);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(174, 43);
            this.btnHuybo.TabIndex = 20;
            this.btnHuybo.Text = "Hủy bỏ";
            this.btnHuybo.UseVisualStyleBackColor = true;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(363, 119);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(297, 30);
            this.txtMK.TabIndex = 17;
            this.txtMK.Text = "Dotnet05";
            this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(363, 70);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(297, 30);
            this.txtTDN.TabIndex = 18;
            this.txtTDN.Text = "Dotnet05";
            this.txtTDN.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 258);
            this.ControlBox = false;
            this.Controls.Add(this.chkMK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

