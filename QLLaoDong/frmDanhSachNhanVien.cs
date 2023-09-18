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
    public partial class frmDanhSachNhanVien : Form
    {
        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }
        clsNhanVien nvien=new clsNhanVien();
        private void frmDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            TaoTieuDeCot(lvwDS);
            LoadNVTOListView(lvwDS, nvien.GetNhanVienThuocPB(""));
            btnGiam.Enabled = false;
            btnTang.Enabled = false;
            btnTimKiem.Enabled = false;
            txtTuKhoa.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTuKhoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        //Load danh sach vao bang
        void LoadNVTOListView(ListView lvw, IEnumerable<tblNhanVien> dsNVien)
        {
            lvw.Items.Clear();
            ListViewItem ItemNV;
            foreach (tblNhanVien mt in dsNVien)
            {
                ItemNV = TaoItem(mt);
                lvw.Items.Add(ItemNV);
            }
        }
        //tao Item cho danh sach
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
        //Tao tieu de cot
        void TaoTieuDeCot(ListView lvw)
        {
            lvw.Columns.Add("Mã NV", 100);
            lvw.Columns.Add("Họ tên", 260);
            lvw.Columns.Add("Ngày sinh", 240);
            lvw.Columns.Add("Giới tính", 150);
            lvw.Columns.Add("Địa chỉ", 200);
            lvw.Columns.Add("Mã C Trình", 100);
            lvw.Columns.Add("Mã P Ban", 100);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhSachNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        //Sap xep
        private void radTheoLH_CheckedChanged(object sender, EventArgs e)
        {
            if(radTheoTen.Checked==true||radTheoMaNV.Checked==true)
            {
                btnGiam.Enabled = true;
                btnTang.Enabled = true;
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (radTheoMaNV.Checked == true)
                LoadNVTOListView(lvwDS, nvien.SXTangTheoMaNV());
            else
                LoadNVTOListView(lvwDS, nvien.SXTangTheoTen());
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (radTheoMaNV.Checked == true)
                LoadNVTOListView(lvwDS, nvien.SXGiamTheoMaNV());
            else
                LoadNVTOListView(lvwDS, nvien.SXGiamTheoten());
        }

        void XuLyHoTroAutocomlet()
        {
            IEnumerable<tblNhanVien> dsNVien = nvien.GetAllNhanVien();
            txtTuKhoa.AutoCompleteCustomSource.Clear();
            if (radTimMa.Checked==true)
            { 
                foreach (tblNhanVien n in dsNVien)
                    txtTuKhoa.AutoCompleteCustomSource.Add(n.MaNV);
            }
            else
            { 
               foreach (tblNhanVien n in dsNVien)
                    txtTuKhoa.AutoCompleteCustomSource.Add(n.Hoten);
            }
        }
        //Tim kiem
        private void radTimMa_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
            btnTimKiem.Enabled = true;
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTuKhoa.Text.Equals(""))
                MessageBox.Show("Bạn hãy nhập từ khóa tìm kiếm", "Thông báo");
            else
            {
                string strTuKhoa = txtTuKhoa.Text;
                int vttim = TimKiem(strTuKhoa);
                int vtChonTruoc;
                if(vttim>=0)
                {
                    if(lvwDS.SelectedItems.Count>0)
                    {
                        vtChonTruoc = lvwDS.SelectedIndices[0];
                        lvwDS.Items[vtChonTruoc].Selected = false;
                    }
                    lvwDS.Items[vttim].Selected = true;
                    lvwDS.Focus();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo");
                }
            }
        }
        int TimKiem(string strTuKhoa)
        {
            tblNhanVien n;
            for(int i=0;i<lvwDS.Items.Count;i++)
            {
                n = (tblNhanVien)lvwDS.Items[i].Tag;
                if(radTimMa.Checked)
                {
                    if (n.MaNV.Equals(strTuKhoa))
                        return i;
                }
                else
                {
                    if (n.Hoten.Equals(strTuKhoa))
                        return i;
                }
            }
            return -1;
        }
    }
}
