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
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        clsNhanVien nv;
        clsPhongBan pb;
        clsCongTrinh ct;
        

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            cboCongTrinh.Enabled = true;
            cboPhongBan.Enabled = false;
            txtMaCT.ReadOnly = true;
            

            nv = new clsNhanVien();
            pb = new clsPhongBan();
            ct = new clsCongTrinh();
            IEnumerable<tblPhongBan> dsPB = pb.GetAllPhongBan();
            IEnumerable<tblCongTrinh> dsCT = ct.GetAllCongTrinh();
            cboPhongBan.DisplayMember = "TenPB";
            cboPhongBan.ValueMember = "MaPB";
            cboPhongBan.DataSource = dsPB;
            cboCongTrinh.DisplayMember = "TenCT";
            cboCongTrinh.ValueMember = "MaCT";
            cboCongTrinh.DataSource = dsCT;

            TaoTieuDeCot(lvvDanhSach);

            LoadNVTOListView(lvvDanhSach, nv.GetNhanVienThuocCT(cboCongTrinh.SelectedValue.ToString()));

        }
        private void radPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            if (radPhongBan.Checked == true)
            {
                cboPhongBan.Enabled = true;
                cboCongTrinh.Enabled = false;
            }
            else
            {
                cboCongTrinh.Enabled = true;
                cboPhongBan.Enabled = false;
            }
            
            if(radCongTrinh.Checked==true)
            {
                IEnumerable<tblNhanVien> dsNVien;
                string strMaCT = cboCongTrinh.SelectedValue.ToString();
                dsNVien = nv.GetNhanVienThuocCT(strMaCT);
                LoadNVTOListView(lvvDanhSach, dsNVien);
                txtMaCT.ReadOnly = true;
                txtMaPB.ReadOnly = false;
            }
            if( radPhongBan.Checked==true)
            {
                IEnumerable<tblNhanVien> dsNVien;
                string strMaPB =cboPhongBan.SelectedValue.ToString();
                dsNVien = nv.GetNhanVienThuocPB(strMaPB);
                LoadNVTOListView(lvvDanhSach, dsNVien);
                txtMaCT.ReadOnly = false;
                txtMaPB.ReadOnly = true;
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
           frmThemPhongBan frm = new QLLaoDong.frmThemPhongBan();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                IEnumerable<tblPhongBan> dsPB = pb.GetAllPhongBan();

                cboPhongBan.DisplayMember = "TenPB";
                cboPhongBan.ValueMember = "MaPB";
                cboPhongBan.DataSource = dsPB;
            }
           
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            frmThemCongTrinh frm = new QLLaoDong.frmThemCongTrinh();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                IEnumerable<tblCongTrinh> dsCT = ct.GetAllCongTrinh();
                cboCongTrinh.DisplayMember = "TenCT";
                cboCongTrinh.ValueMember = "MaCT";
                cboCongTrinh.DataSource = dsCT;
            }

         
        }
        void TaoTieuDeCot(ListView lvw)
        {
            lvw.Columns.Add("Mã NV", 70);
            lvw.Columns.Add("Họ tên", 200);
            lvw.Columns.Add("Ngày sinh", 150);
            lvw.Columns.Add("Giới tính", 100);
            lvw.Columns.Add("Địa chỉ", 120);
            lvw.Columns.Add("Mã C Trình", 100);
            lvw.Columns.Add("Mã P Ban", 100);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radPhongBan.Checked == true)
            {
                IEnumerable<tblNhanVien> dsNVien;
                string strMaPB = "";
                strMaPB = cboPhongBan.SelectedValue.ToString();
                dsNVien = nv.GetNhanVienThuocPB(strMaPB);
                LoadNVTOListView(lvvDanhSach, dsNVien);
            }
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        private void cboCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radCongTrinh.Checked==true)
            { 
                IEnumerable<tblNhanVien> dsNVien;
                string strMaCT = "";
                strMaCT = cboCongTrinh.SelectedValue.ToString();
                dsNVien = nv.GetNhanVienThuocCT(strMaCT);
                LoadNVTOListView(lvvDanhSach, dsNVien);
            }
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        void LoadNVTOListView(ListView lvw,IEnumerable<tblNhanVien> dsNVien)
        {
            lvw.Items.Clear();
            ListViewItem ItemNV;
            foreach(tblNhanVien mt in dsNVien)
            {
                ItemNV = TaoItem(mt);
                lvw.Items.Add(ItemNV);
            }
        }
        ListViewItem TaoItem(tblNhanVien nv)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(nv.MaNV);
            lvwItem.SubItems.Add(nv.Hoten);
            lvwItem.SubItems.Add(nv.Ngaysinh.ToString());
            lvwItem.SubItems.Add(nv.Gioitinh);
            lvwItem.SubItems.Add(nv.Lienhe);
            lvwItem.SubItems.Add(nv.MaCT);
            lvwItem.SubItems.Add(nv.MaPB);
            lvwItem.Tag = nv;
            return lvwItem;
        }
        void NhanVienToTextbox(tblNhanVien nv)
        {
            txtMaNV.Text = nv.MaNV;
            txtHoTen.Text = nv.Hoten;
            txtNgaySinh.Text = nv.Ngaysinh.ToString();
            if (nv.Gioitinh.Equals("Nam"))
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtLienHe.Text = nv.Lienhe;
            txtMaCT.Text = nv.MaCT;
            txtMaPB.Text = nv.MaPB;
        }

        private void lvvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblNhanVien nv = null;
            if (lvvDanhSach.SelectedItems.Count > 0)
            {
                nv = (tblNhanVien)lvvDanhSach.SelectedItems[0].Tag;
                NhanVienToTextbox(nv);
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            tblNhanVien n;
            int vtthuc;
            string ma = "";
            if (lvvDanhSach.SelectedItems.Count>0)
            {
                r = MessageBox.Show("Bạn chắc chắn xóa?", "Hỏi xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if(r==DialogResult.Yes)
                {
                    for(int i=0;i<lvvDanhSach.SelectedItems.Count;i++)
                    {
                        vtthuc = lvvDanhSach.SelectedIndices[i];
                        n = (tblNhanVien)lvvDanhSach.Items[vtthuc].Tag;
                        
                        if (radPhongBan.Checked == true)
                            ma = txtMaPB.Text;
                        else
                            ma = txtMaCT.Text;
                        nv.DeleteNhanVien(n); 
                    }
                    IEnumerable<tblNhanVien> dsNVien;
                    if (radPhongBan.Checked == true)
                    {

                        
                        dsNVien = nv.GetNhanVienThuocPB(ma);
                    }
                    else
                    {
                        
                        dsNVien = nv.GetNhanVienThuocCT(ma);
                    }
                        
                    LoadNVTOListView(lvvDanhSach, dsNVien);
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                }
            }
        }
        tblNhanVien TaoNhanVien()
        {
            tblNhanVien n = new tblNhanVien();
            n.MaNV = txtMaNV.Text;
            n.Hoten = txtHoTen.Text;
            n.Ngaysinh = DateTime.Parse(txtNgaySinh.Text);
            n.Lienhe = txtLienHe.Text;
            n.MaPB = txtMaPB.Text;
            n.MaCT = txtMaCT.Text;
            if (radNam.Checked == true)
                n.Gioitinh = "Nam";
            else
                n.Gioitinh = "Nữ";
            return n; 
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            tblNhanVien n = TaoNhanVien();
            string ma = "";
            if (radPhongBan.Checked == true)
                ma = txtMaPB.Text;
            else
                ma = txtMaCT.Text;
            nv.Sua(n);
            IEnumerable<tblNhanVien> dsNVien;
            if (radPhongBan.Checked == true)
                dsNVien = nv.GetNhanVienThuocPB(ma);
            else
                dsNVien = nv.GetNhanVienThuocCT(ma);
            LoadNVTOListView(lvvDanhSach, dsNVien);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        bool KTDLRong()
        {
            if ((txtMaNV.Text.Equals("") || txtHoTen.Text.Equals("") || txtNgaySinh.Text.Equals("") || txtLienHe.Text.Equals("") || txtMaCT.Text.Equals("") || txtMaPB.Text.Equals("")) || (radNam.Checked == false && radNu.Checked == false))
                return true;
            else
                return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblNhanVien n = TaoNhanVien();
                if (nv.CheckIfExist(n.MaNV) != null)
                    MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo");
                else
                {
                    string ma = "";
                    if (radPhongBan.Checked == true)
                        ma = txtMaPB.Text;
                    else
                        ma = txtMaCT.Text;
                    nv.insertNhanVien(n);
                    IEnumerable<tblNhanVien> dsNVien;
                    if (radPhongBan.Checked == true)
                        dsNVien = nv.GetNhanVienThuocPB(ma);
                    else
                        dsNVien = nv.GetNhanVienThuocCT(ma);
                    LoadNVTOListView(lvvDanhSach, dsNVien);
                }
            }
            else 
                MessageBox.Show("Bạn cần điền đầy đủ thông tin","Thông báo");
        
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }
    }
}
