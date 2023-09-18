using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLaoDong
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (txtMK.Text.Trim().Equals("") || txtTDN.Text.Trim().Equals(""))
                btnDangNhap.Enabled = false;
            else
                btnDangNhap.Enabled = true;
            if (chkMK.Checked == true)
                txtMK.UseSystemPasswordChar = true;
            else
                txtMK.UseSystemPasswordChar = false;
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            if (txtMK.Text.Trim().Equals("") || txtTDN.Text.Trim().Equals(""))
                btnDangNhap.Enabled = false;
            else
                btnDangNhap.Enabled = true;
        }
        private void chkMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMK.Checked == true)
                txtMK.UseSystemPasswordChar = true;
            else
                txtMK.UseSystemPasswordChar = false;
        }
        int dem;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTDN.Text.Trim().Equals("Dotnet05") && txtMK.Text.Trim().Equals("Dotnet05"))
                this.DialogResult = DialogResult.OK;
            else
            {
                dem++;
                MessageBox.Show("Thông tin đăng nhập không đúng", "Thông báo");
                txtTDN.Clear();
                txtMK.Clear();
                txtTDN.Focus();
            }
            if (dem > 3)
            {
                MessageBox.Show("Bạn đã nhập quá 3 lần", "Thông báo");
                this.Close();
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắn chán thoát không?", "Thông báo",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
