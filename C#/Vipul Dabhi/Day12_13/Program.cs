using Day12_13.Migrations;
using Day12_13.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Day12_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new ToyContext())
            //{
            //    var customer = new CustomerDetails()
            //    {
            //        CustomerName = "Nayan",
            //        CustomerAddress = "Charodi,Ahmedabad.",
            //        IsActive = true
                      
            //    };
            //    var customer1 = new CustomerDetails()
            //    {
            //        CustomerName = "Mehul",
            //        CustomerAddress = "Gota,Ahmedabad.",
            //        IsActive = true
            //    };

            //    context.CustomerDetails.Add(customer);
            //    context.CustomerDetails.Add(customer1);

            //    context.SaveChanges();
            //    Console.WriteLine("Customer Insert SuccessFully");
            //}

            //Update Customer

            using (var context = new ToyContext())
            {
                var customer = context.CustomerDetails.First<CustomerDetails>();
                customer.CustomerName = "Ramesh";
                customer.CustomerAddress = "Ghatlodiya,Ahmedabad.";
                customer.IsActive = false;

                context.SaveChanges();
                Console.WriteLine("Customer Updated SuccessFully");
            }

            //using (var context = new ToyContext()) 
            //{
            //    var products = context.ToysDetails
            //                          .SqlQuery(exec GetToysDetails)
            //                          .ToList();
            //}
        }
    } 
}
