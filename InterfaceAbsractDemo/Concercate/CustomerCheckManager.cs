using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbsractDemo.Abstract;
using InterfaceAbsractDemo.Entities;

namespace InterfaceAbsractDemo.Concercate
{
    class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
