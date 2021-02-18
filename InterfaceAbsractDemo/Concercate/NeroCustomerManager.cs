using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbsractDemo.Abstract;
using InterfaceAbsractDemo.Entities;

namespace InterfaceAbsractDemo.Concercate
{
    public class NeroCustomerManager:BaseCustomerManager

    {
        private  ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Person not valid!");
            }
        }
    }
}
