using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLaoDong
{
    class clsNhanVien:clsKetNoi
    {
        qlLaoDongDataContext dt;
        public clsNhanVien()
        {
            dt = getDataConext();
        }
        public IEnumerable<tblNhanVien> GetAllNhanVien()
        {
            IEnumerable<tblNhanVien> q = from n in dt.tblNhanViens
                                         select n;
            return q;
        }
        public IEnumerable<tblNhanVien> GetNhanVienThuocPB(string strMaPB)
        {
            IEnumerable<tblNhanVien> q;
            if (strMaPB.Equals(""))
                q = from n in dt.tblNhanViens
                    select n;
            else
                q = from n in dt.tblNhanViens
                    where n.MaPB.Equals(strMaPB)
                    select n;
            return q;
        }
      public IEnumerable<tblNhanVien> GetNhanVienThuocCT(string strMaCT)
       {
            IEnumerable<tblNhanVien> q;
            if (strMaCT.Equals(""))
                q = from n in dt.tblNhanViens
                    select n;
            else
                q = from n in dt.tblNhanViens
                    where n.MaCT.Equals(strMaCT)
                    select n;
            return q;

       }
        public tblNhanVien CheckIfExist(string strMaNV)
        {
            tblNhanVien nvtemp = (from n in dt.tblNhanViens
                                  where n.MaNV.Equals(strMaNV)
                                  select n).FirstOrDefault();
            if (nvtemp != null)
                return nvtemp;
            else
                return null;
        }
        //Xoa nhan vien
        public int DeleteNhanVien(tblNhanVien nv)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if(CheckIfExist(nv.MaNV)!=null)
                {
                    dt.tblNhanViens.DeleteOnSubmit(nv);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
                return 0;
            }
            catch(Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi không xóa được " + ex.Message);
            }
        }
        //Sua nhan vien
        public bool Sua(tblNhanVien nvSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblNhanVien> tam = (from n in dt.tblNhanViens
                                               where n.MaNV.Equals(nvSua.MaNV)
                                               select n);
                tam.First().MaNV = nvSua.MaNV;
                tam.First().Hoten = nvSua.Hoten;
                tam.First().Ngaysinh = nvSua.Ngaysinh;
                tam.First().Gioitinh = nvSua.Gioitinh;
                tam.First().Lienhe = nvSua.Lienhe;
                tam.First().MaCT = nvSua.MaCT;
                tam.First().MaPB = nvSua.MaPB;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch(Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi không sữa được " + ex.Message);
            }
        }
        //them nhan vien
        public int insertNhanVien(tblNhanVien n)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(n.MaNV) != null)
                    return 0;
                else
                {
                    dt.tblNhanViens.InsertOnSubmit(n);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi không thêm được " + ex.Message);
            }
        }
        //Sap xep theo ten/ma
        public IEnumerable<tblNhanVien> SXTangTheoMaNV()
        {
            IEnumerable<tblNhanVien> q;
            q = from n in dt.tblNhanViens
                orderby n.MaNV
                select n;
            return q;
        }
        public IEnumerable<tblNhanVien> SXGiamTheoMaNV()
        {
            IEnumerable<tblNhanVien> q;
            q = from n in dt.tblNhanViens
                orderby n.MaNV descending
                select n;
            return q;
        }
        public IEnumerable<tblNhanVien> SXTangTheoTen()
        {
            IEnumerable<tblNhanVien> q;
            q = from n in dt.tblNhanViens
                orderby n.Hoten
                select n;
            return q;
        }
        public IEnumerable<tblNhanVien> SXGiamTheoten()
        {
            IEnumerable<tblNhanVien> q;
            q = from n in dt.tblNhanViens
                orderby n.Hoten descending
                select n;
            return q;
        }
    }
}
