using Core.DataCore;
using Microsoft.AspNetCore.Mvc;
using Service.Bvadmin.Interfaces;

namespace MinaSidor.Server.wwwroot
    {
    [ApiController]
    [Route("[controller]/[action]")]
    public class CustomerController : ControllerBase
        {
         private readonly ICustomer _customer;
        public CustomerController(ICustomer customer)
            {
            _customer = customer;
            }
        [HttpGet]
        public async Task<Customer> GetCustomer(int CustomerId)
            {
            return await _customer.getCustomer(CustomerId);
            }
        [HttpGet]
        public async Task<List<Customer>> FindCustomer(string Searchtearm)
            {
            return await _customer.FindCustomer(Searchtearm);
            }
        [HttpPost]
        public async Task<bool> CreateCustomer(Customer customer)
            {
            return await _customer.createCustomer(customer);
            }
        [HttpPut]
        public async Task<bool> updateCustomer(Customer customer)
            {
            return await _customer.updateCustomer(customer);
            }
        [HttpDelete]
        public async Task<bool> deleteCustomer(int CustomerId)
            {
            return await _customer.deleteCustomer(CustomerId);
            }
        }
    }
