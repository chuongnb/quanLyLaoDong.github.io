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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        clsNhanVien nv = new clsNhanVien();
        clsCongTrinh ct=new clsCongTrinh();
        clsPhongBan pb = new clsPhongBan();
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
        }
        private void frmThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(radPhongban.Checked==true)
            {
                int i = 0;
                foreach (var series in Chart1.Series)
                {
                    series.Points.Clear();
                }
                IEnumerable<tblPhongBan> dsPB = pb.GetAllPhongBan();
                foreach (tblPhongBan p in dsPB)
                {
                    Chart1.Series["SL"].Points.Add(pb.GetSLNVPB(p.MaPB));
                    Chart1.Series["SL"].Points[i].Label = pb.GetSLNVPB(p.MaPB).ToString();
                    Chart1.Series["SL"].Points[i].AxisLabel = p.TenPB;
                    i++;
                }
            }
            else
            {
                int i = 0;
                foreach (var series in Chart1.Series)
                {
                    series.Points.Clear();
                }
                IEnumerable<tblCongTrinh> dsCT = ct.GetAllCongTrinh();
                foreach (tblCongTrinh c in dsCT)
                {
                    Chart1.Series["SL"].Points.Add(ct.GetSLNVCT(c.MaCT));
                    Chart1.Series["SL"].Points[i].Label = ct.GetSLNVCT(c.MaCT).ToString();
                    Chart1.Series["SL"].Points[i].AxisLabel = c.TenCT;
                    i++;
                }
            }
        }
    }
}
