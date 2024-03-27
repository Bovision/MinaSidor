using Core.DataCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Bvadmin.Interfaces
    {
    public interface IProduct
        {
        public Task<bool> createProduct(Product product);
        public Task<bool> deleteProduct(int productId);
        public Task<bool> updateProduct(Product product);
        public Task<Product> getProduct(int productId);
        public Task<Product> FindProduct(Param SearchParam);
        Task<List<Product>> getProducts();
        }
    }
