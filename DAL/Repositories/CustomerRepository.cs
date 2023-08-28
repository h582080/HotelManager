using DAL.DataContext;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Contracts
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        private HotelContext context;

        public CustomerRepository(HotelContext context)
        {
            this.context = context;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            try
            {
                return await context.Set<Customer>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Customer> GetCustomerByID(int id)
        {

            try
            {
                return await context.Set<Customer>().FindAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Customer> GetCustomerByUsername(string username)
        {

            try
            {
                var cu =  await context.Set<Customer>().Where(c => c.Username == username).FirstOrDefaultAsync();
                if (cu != null)
                {
                    return cu;
                }
                else
                {
                    throw new Exception("Customer Does not Exist!");
                }
            }
            catch
            {
                throw;
            }
        }

        public  void InsertCustomer(Customer customer)
        {
            context.Customers.Add(customer);
        }

        public async void DeleteCustomer(int customerID)
        {
            Customer customer =await context.Customers.FindAsync(customerID);
            if(customer != null)
            {
                context.Customers.Remove(customer);

            }
        }

        public void UpdateCustomer(Customer customer)
        {
            var entity = context.ServiceRequests.Find(customer.CustomerId);
            context.Entry(entity).State = EntityState.Detached;
            context.Entry(customer).State = EntityState.Modified;
        }

        public void Save()
        {
            
           
                 context.SaveChanges();
            

        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<Customer> GetCustomerByCred(string username, string password)
         {
            return await context.Customers.Where(c => c.Username == username && c.Password == password).FirstOrDefaultAsync();
        }
    }
}



