using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffManegement.Model.Sua;
using StaffManegement.Model.Xem;
using StaffManegement.View.Xem;

namespace StaffManegement.Presenter.Sua
{
    class UpdatePresenter
    {
        private Boolean kiemtra;
        ListStaffBelongRoom listStaff;
        public UpdatePresenter(ListStaffBelongRoom _listStaff, String sql)
        {
            listStaff = _listStaff;
            UpdateNVModel updateNVModel = new UpdateNVModel(sql);
            kiemtra = updateNVModel.getKiemtra();
        }
        public bool getKiemtra()
        {
            return kiemtra;
        }
    }
}
