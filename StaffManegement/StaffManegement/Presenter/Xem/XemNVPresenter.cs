using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using StaffManegement.Model.Xem;
using StaffManegement.View.Them;
using StaffManegement.View.Xem;

namespace StaffManegement.Presenter.Them
{
    class XemNVPresenter
    {
        private MySqlDataAdapter da;
        ListStaffBelongRoom listStaff;
        public XemNVPresenter(ListStaffBelongRoom _listStaff, String sql)
        { 
            listStaff = _listStaff;
            QueryXemDSNV.execute(sql);
            da = QueryXemDSNV.da;
        }
       
        public MySqlDataAdapter getDA()
        {
            return da;
        }

    }
}
