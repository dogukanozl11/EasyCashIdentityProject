using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : IcustomerAccountProcessDal
    {
        private readonly IcustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(IcustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void TDelete(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.TDelete(t);
        }

        public CustomerAccountProcess TGetByID(int id)
        {
            return _customerAccountProcessDal.TGetByID(id);
        }

        public List<CustomerAccountProcess> TGetList()
        {
            return _customerAccountProcessDal.TGetList();
        }

        public void TInsert(CustomerAccountProcess t)
        {
           _customerAccountProcessDal.TInsert(t);
        }

        public void TUpdate(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.TUpdate(t);
        }
    }
}
