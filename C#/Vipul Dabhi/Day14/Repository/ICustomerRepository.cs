using Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerDetails>> GetCustomers();
        Task<CustomerDetails> GetCustomer(int id);
        Task<CustomerDetails> AddCustomer(CustomerDetails customer);
        Task<CustomerDetails> UpdateCustomer(CustomerDetails customer);
        Task<string> DeleteCustomer(int id);
    }
}
 