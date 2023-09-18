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
    public partial class frmThemCongTrinh : Form
    {
        public frmThemCongTrinh()
        {
            InitializeComponent();
        }
        clsCongTrinh ct=new clsCongTrinh();
        private void frmThemCongTrinh_Load(object sender, EventArgs e)
        {
            TaoTieuDeCot(lvwCT);
            LoadCTTOListView(lvwCT, ct.GetAllCongTrinh());
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        void TaoTieuDeCot(ListView lvw)
        {
            lvw.Columns.Add("Mã CT", 100);
            lvw.Columns.Add("Tên CT", 200);
            lvw.Columns.Add("Địa điểm", 160);
            lvw.Columns.Add("Ngày cấp phép", 200);
            lvw.Columns.Add("Ngày Khởi công", 200);
            lvw.Columns.Add("Ngày hoành thành", 200);
            

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }
        ListViewItem TaoItem(tblCongTrinh c)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(c.MaCT);
            lvwItem.SubItems.Add(c.TenCT);
            lvwItem.SubItems.Add(c.DiaDiemCT);
            lvwItem.SubItems.Add(c.Ngaycapgiayphep.ToString());
            lvwItem.SubItems.Add(c.Ngaykhoicong.ToString());
            lvwItem.SubItems.Add(c.NgayhoanthanhDK.ToString());
            lvwItem.Tag = c;
            return lvwItem;
        }
        void CongTrinhToTextbox(tblCongTrinh c)
        {
            txtMaCT.Text = c.MaCT;
            txtTenCT.Text = c.TenCT;
            txtDCCT.Text = c.DiaDiemCT;
            txtNgayCP.Text = c.Ngaycapgiayphep.ToString();
            txtNgayKC.Text = c.Ngaykhoicong.ToString();
            txtNgayHT.Text = c.NgayhoanthanhDK.ToString(); 
        }
        void LoadCTTOListView(ListView lvw, IEnumerable<tblCongTrinh> dsCT)
        {
            lvw.Items.Clear();
            ListViewItem ItemCT;
            foreach (tblCongTrinh c in dsCT)
            {
                ItemCT = TaoItem(c);
                lvw.Items.Add(ItemCT);
            }
        }

        private void lvwCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblCongTrinh c=null;
            if (lvwCT.SelectedItems.Count > 0)
            {
                c = (tblCongTrinh)lvwCT.SelectedItems[0].Tag;
                CongTrinhToTextbox(c);
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
                btnXoa.Enabled = false;
            
        }

        private void frmThemCongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
            this.DialogResult = DialogResult.OK;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool KTDLRong()
        {
            if(txtMaCT.Text.Equals("")||txtTenCT.Text.Equals("")||txtDCCT.Text.Equals("")||txtNgayCP.Text.Equals("")||txtNgayKC.Text.Equals("")||txtNgayHT.Text.Equals(""))
                return true;
            else
                return false;
        }
        tblCongTrinh TaoCongTrinh()
        {
            tblCongTrinh c = new tblCongTrinh();
            c.MaCT = txtMaCT.Text;
            c.TenCT = txtTenCT.Text;
            c.DiaDiemCT = txtDCCT.Text;
            c.Ngaycapgiayphep = DateTime.Parse(txtNgayCP.Text);
            c.Ngaykhoicong = DateTime.Parse(txtNgayKC.Text);
            c.NgayhoanthanhDK = DateTime.Parse(txtNgayHT.Text);
            return c;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblCongTrinh c = TaoCongTrinh();
                if (ct.CheckIfExist(c.MaCT) != null)
                    MessageBox.Show("Mã công trình đã tồn tại", "Thông báo");
                else
                {
                    ct.insertCongTrinh(c);
                    IEnumerable<tblCongTrinh> dsCT;
                    dsCT = ct.GetAllCongTrinh();
                    LoadCTTOListView(lvwCT, dsCT);
                }
            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            tblCongTrinh c;
            int vtthuc;
            if (lvwCT.SelectedItems.Count > 0)
            {
                r = MessageBox.Show("Bạn chắc chắn xóa?", "Hỏi xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    for (int i = 0; i < lvwCT.SelectedItems.Count; i++)
                    {
                        vtthuc = lvwCT.SelectedIndices[i];
                        c = (tblCongTrinh)lvwCT.Items[vtthuc].Tag;
                        ct.DeleteCT(c);
                    }
                    IEnumerable<tblCongTrinh> dsCT;
                    dsCT = ct.GetAllCongTrinh();
                    LoadCTTOListView(lvwCT, dsCT);
                }
                btnXoa.Enabled = false;
            }
        }

        private void txtMaCT_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }
    }
}
