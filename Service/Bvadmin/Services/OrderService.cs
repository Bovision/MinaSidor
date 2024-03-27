using AutoMapper;
using Core.DataCore;
using Data;
using Microsoft.EntityFrameworkCore;
using Service.Bvadmin.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Bvadmin.Services
    {
    public class OrderService : Interfaces.IOrder
        {
        private readonly ApplicationDbContext _ApplicationDbContext;
        public OrderService(ApplicationDbContext applicationDbContext)
            {
            _ApplicationDbContext = applicationDbContext;
            }
        public async Task<bool> createOrder(Orderitem order)
            {
            try
                {
                await _ApplicationDbContext.Orderitems.AddAsync(order);
                await _ApplicationDbContext.SaveChangesAsync();
                return true;
                }
            catch (Exception ex)
                {
                return false;
                }

            }

        public async Task<bool> deleteOrder(int orderId)
            {
            var Orderitem = await _ApplicationDbContext.Orderitems.FindAsync(orderId);
            if (Orderitem != null)
                {
                _ApplicationDbContext.Orderitems.Remove(Orderitem);
                await _ApplicationDbContext.SaveChangesAsync();
                return true;
                }
            return false;
            }

        public async Task<List<Orderitem>> getOrders(int CustomerId)
            {
            return await _ApplicationDbContext.Orderitems.Where(x => x.Customerid == CustomerId).ToListAsync();
            }

        public async Task<Orderitem> getOrder(int orderId)
            {
            return await _ApplicationDbContext.Orderitems.FindAsync(orderId);
            }

        public async Task<bool> updateOrder(Orderitem order)
            {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Orderitem, Orderitem>(); // Customer är den typ som ska mappas
            });

            // Skapa en IMapper-instans med hjälp av konfigurationen
            var mapper = new Mapper(config);
            var Orderitem = await _ApplicationDbContext.Orderitems.FindAsync(order.Id);
            mapper.Map(order, Orderitem);
            if (Orderitem != null)
                {
                _ApplicationDbContext.Orderitems.Update(Orderitem);
                await _ApplicationDbContext.SaveChangesAsync();
                return true;
                }
            return false;
            }
        }
    }
