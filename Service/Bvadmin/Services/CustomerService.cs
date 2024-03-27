using Core.DataCore;
using Data;
using Microsoft.EntityFrameworkCore;
using Service.Bvadmin.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Service.Bvadmin.Services
    {
    public class CustomerService : Interfaces.ICustomer
        {
        public readonly ApplicationDbContext _applicationDbContext;
 

        public CustomerService(ApplicationDbContext applicationDbContext)
            {
            _applicationDbContext = applicationDbContext;
            }
        public async Task<bool> createCustomer(Customer customer)
            {
            try
                {
                await _applicationDbContext.Customers.AddAsync(customer);
                await _applicationDbContext.SaveChangesAsync();
                return true;
                }
            catch (Exception ex)
                {
                return false;
                }
            }

        public async Task<bool> createCustomernote(Customernote customernote)
            {
            try
                {
                await _applicationDbContext.Customernotes.AddAsync(customernote);
                await _applicationDbContext.SaveChangesAsync();
                return true;
                }
            catch (Exception ex)
                {
                return false;
                }
            }

        public async Task<bool> deleteCustomer(int customerId)
            {
            var Customer = await _applicationDbContext.Customers.FindAsync(customerId);
            if (Customer != null)
                {
                _applicationDbContext.Customers.Remove(Customer);
                await _applicationDbContext.SaveChangesAsync();
                return true;
                }
            return false;
            }

        public async Task<bool> deleteCustomernote(int customernoteId)
            {
            var customernote = await _applicationDbContext.Customernotes.FindAsync(customernoteId);
            if (customernote != null)
                {
                _applicationDbContext.Customernotes.Remove(customernote);
                await _applicationDbContext.SaveChangesAsync();
                return true;
                }
            return false; ;
            }

        public async Task<List<Customer>> FindCustomer(string SearchParam)
            {
            int searchId;
            bool isNumeric = int.TryParse(SearchParam, out searchId);

            var customers = await _applicationDbContext.Customers
                .Where(c => c.Name.Contains(SearchParam) || (isNumeric && c.Id == searchId))
                .Take(10) // limit to 10 results
                .ToListAsync();

            return customers;
            }

        public async Task<List<Customernote>> FindCustomernote(string SearchParam , int CustomerID)
            {
            var customers = await _applicationDbContext.Customernotes
    .Where(c => c.Text.Contains(SearchParam) && (c.Customerid == CustomerID))
    .Take(10) // limit to 10 results
    .ToListAsync();
            return customers;
            }

        public async Task<Customer> getCustomer(int customerId)
            {
           return await _applicationDbContext.Customers.FindAsync(customerId);   
            }

        public Task<List<Customernote>> getCustomernotes(int customerId)
            {
            return _applicationDbContext.Customernotes.Where(c => c.Customerid == customerId).ToListAsync();    
            }
        public async Task<Customernote> getCustomernote(int noteId)
            {
             var list= await _applicationDbContext.Customernotes.Where(c => c.Id == noteId).ToListAsync();
            return list.FirstOrDefault();
            }
        public Task<List<Orderitem>> getOrderitems(int custumerId)
            {
            return _applicationDbContext.Orderitems.Where(c => c.Customerid == custumerId).ToListAsync();   
            }

        public async Task<bool> updateCustomer(Customer customer)
            {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Customer, Customer>(); // Customer är den typ som ska mappas
            });

            // Skapa en IMapper-instans med hjälp av konfigurationen
            var mapper = new Mapper(config);
            try
                { 
            var existingcustomer = await _applicationDbContext.Customers.FindAsync(customer.Id);
            if (existingcustomer == null)
                return false;
                mapper.Map(customer, existingcustomer);

                _applicationDbContext.Customers.Update(existingcustomer);
            await _applicationDbContext.SaveChangesAsync();

            return true;
            }
            catch (Exception ex)
                {
                return false;
                }
    }

        public async Task<bool> updateCustomernote(Customernote customernote)
            {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Customernote, Customernote>(); // Customer är den typ som ska mappas
            });

            // Skapa en IMapper-instans med hjälp av konfigurationen
            var mapper = new Mapper(config);
            try
                {
                var existingcustomernote = await _applicationDbContext.Customernotes.FindAsync(customernote.Id);
                if (existingcustomernote == null)
                    return false;
                mapper.Map(customernote, existingcustomernote);

                _applicationDbContext.Customernotes.Update(existingcustomernote);
                await _applicationDbContext.SaveChangesAsync();

                return true;
                }
            catch (Exception ex)
                {
                return false;
                }
            }
        }
    }
