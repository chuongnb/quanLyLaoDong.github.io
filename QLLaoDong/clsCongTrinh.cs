using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLaoDong
{
    class clsCongTrinh:clsKetNoi
    {
        qlLaoDongDataContext dt;
        public clsCongTrinh()
        {
            dt = getDataConext();
        }
        public IEnumerable<tblCongTrinh> GetAllCongTrinh()
        {
            IEnumerable<tblCongTrinh> q = from n in dt.tblCongTrinhs
                                          select n;
            return q;

        }
        public int GetSLNVCT(string strmaCT)
        {
            var sl = (from c in dt.tblCongTrinhs
                      join n in dt.tblNhanViens
                      on c.MaCT equals n.MaCT
                      where c.MaCT.Equals(strmaCT)
                      select c.MaCT
                      ).Count();
            return sl;
        }
        public tblCongTrinh CheckIfExist(string strMaCT)
        {
            tblCongTrinh cttemp = (from n in dt.tblCongTrinhs
                                  where n.MaCT.Equals(strMaCT)
                                  select n).FirstOrDefault();
            if (cttemp != null)
                return cttemp;
            else
                return null;
        }
        //Them cong trinh
        public int insertCongTrinh(tblCongTrinh n)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(n.MaCT) != null)
                    return 0;
                else
                {
                    dt.tblCongTrinhs.InsertOnSubmit(n);
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
        //Xoa cong trinh
        public int DeleteCT(tblCongTrinh c)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(c.MaCT) != null)
                {
                    dt.tblCongTrinhs.DeleteOnSubmit(c);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi không xóa được " + ex.Message);
            }
        }
    }
}
