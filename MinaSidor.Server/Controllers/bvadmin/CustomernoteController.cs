using Core.DataCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Bvadmin.Interfaces;

namespace MinaSidor.Server.Controllers.bvadmin
    {
    [Route("api/[controller]")]
    [ApiController]
    public class CustomernoteController : ControllerBase
        {
        private readonly ICustomer _customer;
        public CustomernoteController(ICustomer customer)
            {
            _customer = customer;
            }
        [HttpGet("GetCustomernote")]
        public async Task<Customernote> GetCustomernote(int NoteId)
            {
            return await _customer.getCustomernote(NoteId);
            }
        [HttpGet("GetCustomernotes")]
        public async Task<List<Customernote>> GetCustomernotes(int CustomerId)
            {
            return await _customer.getCustomernotes(CustomerId);
            }
        [HttpGet]
        public async Task<List<Customernote>> FindCustomernote(string Searchtearm,int CustomerID)
            {
            return await _customer.FindCustomernote(Searchtearm,CustomerID);
            }
        [HttpPost]
        public async Task<bool> CreateCustomernote(Customernote customer)
            {
            return await _customer.createCustomernote(customer);
            }
        [HttpPut]
        public async Task<bool> updateCustomernote(Customernote customer)
            {
            return await _customer.updateCustomernote(customer);
            }
        [HttpDelete]
        public async Task<bool> deleteCustomer(int CustomerId)
            {
            return await _customer.deleteCustomernote(CustomerId);
            }
        }
    }
