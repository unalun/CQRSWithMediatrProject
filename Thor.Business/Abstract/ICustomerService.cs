using System.Collections.Generic;
using System.Threading.Tasks;
using Thor.Entities.Concrete;

namespace Thor.Business.Abstract
{
    public interface ICustomerService
    {
        Task Add(Customer customer);
        Task Delete(int customerId);
        Task<List<Customer>> GetCustomer();
    }
}
