using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Contracts
{
     public interface ICustomerRepository : IDisposable
    {
       Task<List<Customer>> GetCustomers();
        Task<Customer> GetCustomerByID(int customerId);
        void InsertCustomer(Customer customer);
        void DeleteCustomer(int customerId);
        void UpdateCustomer(Customer customer);
        void Save();
       Task<Customer> GetCustomerByCred(string username, string password);
       Task<Customer> GetCustomerByUsername(string username);

    }
}
