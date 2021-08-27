using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Thor.Business.Abstract;
using Thor.Entities.Concrete;

namespace Thor.Business.Concrete
{
    public class CustomerService : ICustomerService
    {
        public Task Add(Customer customer)
        {
            return null;
        }
        public Task Delete(int customerId)
        {
            return null;
        }
        public Task<List<Customer>> GetCustomer()
        {
            return null;
        }
    }
}
