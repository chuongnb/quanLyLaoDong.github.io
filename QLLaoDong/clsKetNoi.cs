using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLaoDong
{
    
    public class clsKetNoi
    {
        qlLaoDongDataContext dt;
        public qlLaoDongDataContext getDataConext()
        {
            string str = @"Data Source=LAPTOP-E7DRMR2I;Initial Catalog=QLLaoDong1;Integrated Security=True";
            dt = new qlLaoDongDataContext(str);
            dt.Connection.Open();
            return dt;
        }
    }
}
