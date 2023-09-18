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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        bool KiemTraTonTaiForm(String frmTenForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(frmTenForm))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }


        private void btnThongTinNhom_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmThongTinNhom") == false)
            {
                frmThongTinNhom frm = new frmThongTinNhom();
                frm.MdiParent = this;
                frm.Name = "frmThongTinNhom";
                frm.Show();
            }
        }

        private void bntQLNV_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmQuanLyNhanVien") == false)
            {
                frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
                frm.MdiParent = this;
                frm.Name = "frmQuanLyNhanVien";
                frm.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmDanhSachNhanVien") == false)
            {
                frmDanhSachNhanVien frm = new frmDanhSachNhanVien();
                frm.MdiParent = this;
                frm.Name = "frmDanhSachNhanVien";
                frm.Show();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmThongKe") == false)
            {
                frmThongKe frm = new frmThongKe();
                frm.MdiParent = this;
                frm.Name = "frmThongKe";
                frm.Show();
            }
        }
    }
}
