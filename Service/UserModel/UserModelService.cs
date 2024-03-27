using Core.DataCore;
using Data;
using Microsoft.EntityFrameworkCore;
using Service.Bvadmin.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.UserModel
{
    public class UserModelService : IUserModel
        {
        private readonly ApplicationDbContext _ApplicationDbContext;
        public UserModelService(ApplicationDbContext applicationDbContext)
            {
            _ApplicationDbContext = applicationDbContext;
            }
        public async Task<Customer> GetfullUser(int UserId)
            {
            var customer = await _ApplicationDbContext.Customers
                .Include(c => c.Orderitems) // inkludera orderitems för kunden
                .Include(c => c.Invoices)    // inkludera fakturor för kunden
                .FirstOrDefaultAsync(c => c.Id == UserId);

            return customer;
            }
        }
    }
