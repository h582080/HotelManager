using DAL.DataContext;
using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Models;
using BLL.Services.Contracts;

namespace BLL.Services
{
    public class CustomerService : ICustomerService
    {

        private ICustomerRepository _customerRepository;
        private Mapper _CustomerMapper;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository(new HotelContext());
            var _configCustomer = new MapperConfiguration(cfg => cfg.CreateMap<DAL.Models.Customer, Customer>().ReverseMap());
            _CustomerMapper = new Mapper(_configCustomer);
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return _CustomerMapper.Map<List<DAL.Models.Customer>,List<Customer>>(await _customerRepository.GetCustomers());
        }

        public async Task<Customer> GetCustomerByID(int id)
        {
            return _CustomerMapper.Map<DAL.Models.Customer, Customer>(await  _customerRepository.GetCustomerByID(id));
        }

        public  void InsertCustomer(Customer customer)
        {
            try
            {
                var c = _CustomerMapper.Map<Customer, DAL.Models.Customer>(customer);
                _customerRepository.InsertCustomer(c);
                _customerRepository.Save();
            }
            catch
            {
                throw;
            }
        }
        public void DeleteCustomer(int id)
        {
            try
            {
                _customerRepository.DeleteCustomer(id);
                _customerRepository.Save();
            }
            catch
            {
                throw;
            }
           
        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                var c = _CustomerMapper.Map<Customer,DAL.Models.Customer>(customer);
                _customerRepository.UpdateCustomer(c);
                _customerRepository.Save();
            }
            catch
            {
                throw;
            }
          
         }

        public async Task<Customer> Login (string username, string password)
        {
            return  _CustomerMapper.Map<DAL.Models.Customer,Customer>(await _customerRepository.GetCustomerByCred(username, password));
        }


        public async Task<Customer> GetCustomerByUsername(string username)
        {
            return _CustomerMapper.Map<DAL.Models.Customer, Customer>(await _customerRepository.GetCustomerByUsername(username));

        }
    }
}

