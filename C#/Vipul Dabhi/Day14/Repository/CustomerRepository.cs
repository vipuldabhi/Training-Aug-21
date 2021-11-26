using Day14.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ToyContext toyContext;
        public CustomerRepository(ToyContext context)
        {
            toyContext = context;   
        }
        public async Task<CustomerDetails> AddCustomer(CustomerDetails customer)
        {
            var Result = toyContext.CustomerDetails.Add(customer);
            await toyContext.SaveChangesAsync();
            return Result.Entity;
        }

        public async Task<string> DeleteCustomer(int id)
        {
            var Result = toyContext.CustomerDetails.Where(a => a.CustomerID == id).FirstOrDefault();
            if (Result != null)
            {
                toyContext.CustomerDetails.Remove(Result);
                await toyContext.SaveChangesAsync();
                return "Customer Deleted";
            }
            return "Invalid Entry";
        }

        public async Task<CustomerDetails> GetCustomer(int id)
        {
            return await toyContext.CustomerDetails.FirstOrDefaultAsync(a => a.CustomerID == id);
        }

        public async Task<IEnumerable<CustomerDetails>> GetCustomers()
        {
            return await toyContext.CustomerDetails.ToListAsync();
        }

        public async Task<CustomerDetails> UpdateCustomer(CustomerDetails customer)
        {
            var Result = await toyContext.CustomerDetails.FirstOrDefaultAsync(a => a.CustomerID == customer.CustomerID);
            if (Result != null)
            {
                Result.CustomerID = customer.CustomerID;
                Result.CustomerName = customer.CustomerName;
                Result.CustomerAddress = customer.CustomerAddress;
                await toyContext.SaveChangesAsync();
                return Result;
            }
            return null;
        }
    }
}
