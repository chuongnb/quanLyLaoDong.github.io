using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLaoDong
{
    class clsPhongBan:clsKetNoi
    {
        qlLaoDongDataContext dt;
        public clsPhongBan()
        {
            dt = getDataConext();
        }
        public IEnumerable<tblPhongBan> GetAllPhongBan()
        {
            IEnumerable<tblPhongBan> q = from n in dt.tblPhongBans
                                         select n;
            return q;

        }
        public int GetSLNVPB(string strmaPB)
        {
            var sl = (from p in dt.tblPhongBans
                      join n in dt.tblNhanViens
                      on p.MaPB equals n.MaPB
                      where p.MaPB.Equals(strmaPB)
                      select p.MaPB
                      ).Count();
            return sl;
        }
        public tblPhongBan CheckIfExist(string strMaPB)
        {
            tblPhongBan cttemp = (from n in dt.tblPhongBans
                                   where n.MaPB.Equals(strMaPB)
                                   select n).FirstOrDefault();
            if (cttemp != null)
                return cttemp;
            else
                return null;
        }
        //Them phong
        public int insertPhongBan(tblPhongBan n)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(n.MaPB) != null)
                    return 0;
                else
                {
                    dt.tblPhongBans.InsertOnSubmit(n);
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
        //Xoa phong
        public int DeletePB(tblPhongBan p)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(p.MaPB) != null)
                {
                    dt.tblPhongBans.DeleteOnSubmit(p);
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
