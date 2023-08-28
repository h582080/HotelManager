using BLL.Models;


namespace BLL.Services.Contracts
{
    public interface ICustomerService
    {


        Task<List<Customer>> GetCustomers();


        Task<Customer> GetCustomerByID(int id);

        void InsertCustomer(Customer customer);
        void DeleteCustomer(int id);

        void UpdateCustomer(Customer customer);

        Task<Customer> Login(string username, string password);

        Task<Customer> GetCustomerByUsername(string username);

       
    }
}

