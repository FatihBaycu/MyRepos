using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbsractDemo.Entities;

namespace InterfaceAbsractDemo.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.name);
        }
    }
}
