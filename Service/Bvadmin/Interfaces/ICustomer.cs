using Core.DataCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Bvadmin.Interfaces
    {
    public interface ICustomer
        {
        public Task<bool> createCustomer(Customer customer);
        public Task<bool> deleteCustomer(int customerId);
        public Task<bool> updateCustomer(Customer customer);
        public Task<Customer> getCustomer(int customerId);
        public Task<List<Customer>> FindCustomer(string SearchParam);
        public Task<List<Customernote>> getCustomernotes(int customerId);
        public Task<Customernote> getCustomernote(int noteId);
        public Task<bool> createCustomernote(Customernote customernote);
        public Task<bool> deleteCustomernote(int customernoteId);
        public Task<bool> updateCustomernote(Customernote customernote);
        public Task<List<Customernote>> FindCustomernote(string SearchParam, int CustomerID);
        public Task<List<Orderitem>> getOrderitems(int custumerId);

        }
    }
