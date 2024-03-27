using Core.DataCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Bvadmin.Interfaces
    {
    public interface IOrder
        {
        public Task<bool> createOrder(Orderitem order);
        public Task<bool> deleteOrder(int orderId);
        public Task<bool> updateOrder(Orderitem order);
        public Task<Orderitem> getOrder(int orderId);
        public Task<List<Orderitem>> getOrders(int custumerId);

        }
    }
