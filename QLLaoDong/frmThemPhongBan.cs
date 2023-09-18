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
    public partial class frmThemPhongBan : Form
    {
        public frmThemPhongBan()
        {
            InitializeComponent();
        }
        clsPhongBan pb=new clsPhongBan();
        private void frmThemPhongBan_Load(object sender, EventArgs e)
        {
            TaoTieuDeCot(lvwPB);
            LoadPBTOListView(lvwPB, pb.GetAllPhongBan());
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        void TaoTieuDeCot(ListView lvw)
        {
            lvw.Columns.Add("Mã PB", 100);
            lvw.Columns.Add("Tên PB", 200);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }
        ListViewItem TaoItem(tblPhongBan p)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(p.MaPB);
            lvwItem.SubItems.Add(p.TenPB);
            lvwItem.Tag = p;
            return lvwItem;
        }
        void PhongBanToTextbox(tblPhongBan p)
        {
            txtMaPB.Text = p.MaPB;
            txtTenPB.Text = p.TenPB;
            
        }
        void LoadPBTOListView(ListView lvw, IEnumerable<tblPhongBan> dsPB)
        {
            lvw.Items.Clear();
            ListViewItem ItemPB;
            foreach (tblPhongBan p in dsPB)
            {
                ItemPB = TaoItem(p);
                lvw.Items.Add(ItemPB);
            }
        }
        private void frmThemPhongBan_FormClosing(object sender, FormClosingEventArgs e)
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
            if (txtMaPB.Text.Equals("") || txtTenPB.Text.Equals(""))
                return true;
            else
                return false;
        }
        tblPhongBan TaoPhongBan()
        {
            tblPhongBan p = new tblPhongBan();
            p.MaPB = txtMaPB.Text;
            p.TenPB = txtTenPB.Text;
            return p;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblPhongBan p = TaoPhongBan();
                if (pb.CheckIfExist(p.MaPB) != null)
                    MessageBox.Show("Mã phòng ban đã tồn tại", "Thông báo");
                else
                {
                    pb.insertPhongBan(p);
                    IEnumerable<tblPhongBan> dsPB;
                    dsPB = pb.GetAllPhongBan();
                    LoadPBTOListView(lvwPB, dsPB);
                }
            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            tblPhongBan p;
            int vtthuc;
            if (lvwPB.SelectedItems.Count > 0)
            {
                r = MessageBox.Show("Bạn chắc chắn xóa?", "Hỏi xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    for (int i = 0; i < lvwPB.SelectedItems.Count; i++)
                    {
                        vtthuc = lvwPB.SelectedIndices[i];
                        p = (tblPhongBan)lvwPB.Items[vtthuc].Tag;
                        pb.DeletePB(p);
                    }
                    IEnumerable<tblPhongBan> dsPB;
                    dsPB = pb.GetAllPhongBan();
                    LoadPBTOListView(lvwPB, dsPB);
                }

            }
            btnXoa.Enabled = false;
        }

        private void lvwPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblPhongBan p = null;
            if (lvwPB.SelectedItems.Count > 0)
            {
                p = (tblPhongBan)lvwPB.SelectedItems[0].Tag;
                PhongBanToTextbox(p);
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
            }
            else
                btnXoa.Enabled = false;
           
        }

        private void txtMaPB_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }
    }
}
